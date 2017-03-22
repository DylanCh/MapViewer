using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;
using System.IO;

namespace DesktopApp
{
    public partial class Form1 : Form
    {
        private static String mapRoot ="www.google.com";

        public Form1()
        {
            InitializeComponent();

            tabPage1.Text = "Map Viewer";
            tabPage2.Text = "Trip Planner";

            showToolbarToolStripMenuItem.Checked = false;

            try {
                IPHostEntry ipEntry = Dns.GetHostEntry(mapRoot);
            }
            catch (Exception e){
                MessageBox.Show("No internet connections");
                Console.WriteLine(e);
            }
        }

        private void exitClicked(object sender, EventArgs e)
        {
            // TODO: close the window   
            this.Close();
        }

        private void goToGoogleMaps(object sender, EventArgs e)
        {
            // TODO: open maps.google.com
            if( MessageBox.Show("Are you sure to leave Map Viewer?","Confirm", MessageBoxButtons.YesNo)== DialogResult.Yes)               
                Process.Start(new ProcessStartInfo("http://maps.google.com"));
        }

        private void copyText(object sender, EventArgs e)
        {
            // copy string
            if (this.ActiveControl is TextBox) {
                try
                {
                    Clipboard.SetDataObject(((TextBox)this.ActiveControl).SelectedText, true);
                }
                catch (System.Runtime.InteropServices.ExternalException ex1) {
                    Console.WriteLine(ex1.ToString());
                }
            }
        }

        private void pasteText(object sender, EventArgs e)
        {
            // paste text
            this.ActiveControl.Text = this.ActiveControl.Text.Insert(
                ((TextBox)this.ActiveControl).SelectionStart,
                Clipboard.GetText()
            );
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // submit button

            // separate textbox text
            string[] urlQuery;
            string mapUrl = "";

            if (radioButton1.Checked)
            {
                urlQuery = addressTextBox.Text.Split(new char[0]);

                string last = urlQuery.Last();
                foreach (string s in urlQuery)
                {
                    string toAppend = s;
                    // the last element does not need to add '+' to the end
                    if (!s.Equals(last))
                        toAppend = s + "+";
                    mapUrl += toAppend;
                }

                mapUrl = mapRoot + "/maps/place/" + mapUrl;
            }

            else {
                string lat=latitudeTextBox.Text, lon=longitudeTextBox.Text;

                // if longitude is W, then decimal longitude is negative
                if (longitudeW.Checked == true)
                    lon = "-" + lon;

                // if latitude is S, then decimal latitude is negative
                if (latitudeS.Checked == true)
                    lat = "-" + lat;

                mapUrl = mapRoot + "/maps/place/@" + lat + "," + lon + ",17z";
            }
            Process.Start(new ProcessStartInfo(mapUrl));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // reset textbox
            addressTextBox.Text = "";
            latitudeTextBox.Text = "";
            longitudeTextBox.Text = "";
        }

        private void addressChecked(object sender, EventArgs e)
        {
            // address checked
            // enable textbox1
            changeLocationType(true);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            // GeoLocation checked
            changeLocationType(false);
        }

        private void changeLocationType(Boolean isAddress) {
            addressTextBox.Enabled = isAddress;
            latitudeTextBox.Enabled = !isAddress;
            longitudeTextBox.Enabled = !isAddress;

            // latitude/longitude radio buttons
            latitudeN.Enabled = !isAddress;
            latitudeS.Enabled = !isAddress;
            longitudeW.Enabled = !isAddress;
            longitudeE.Enabled = !isAddress;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void showToolbarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // show hide toolbar
            if (!showToolbarToolStripMenuItem.Checked)
            {
                toolStrip1.Hide();
                showToolbarToolStripMenuItem.Checked = true;               
            }
            else {
                toolStrip1.Show();
                showToolbarToolStripMenuItem.Checked = false;               
            }
        }

        private void importFromFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "txt files (*.txt)|*.txt"; // currently accepts text files
            openFile.FilterIndex = 1;
            openFile.Title = "Select a text file that contains an address";
            openFile.RestoreDirectory = true;

            Stream stream = null;
            StringBuilder addressBuilder = new StringBuilder();

            if (openFile.ShowDialog() == DialogResult.OK) {
                stream = openFile.OpenFile();
                if (stream != null) {
                    // read file into a string
                    using (stream) {
                        using (BufferedStream buffer = new BufferedStream(stream)) {
                            using (StreamReader sr = new StreamReader(buffer)) {
                                string str;
                                while ((str = sr.ReadLine()) != null) {
                                    addressBuilder.Append(str);
                                }
                            }
                        }
                    }
                    // set string to the address textbox
                    string importedAddress = addressBuilder.ToString();
                    addressTextBox.Text = importedAddress;
                }
                else // if stream is null
                {
                    MessageBox.Show("Cannot open file or the file is empty.");
                }

            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string url = mapRoot + "/maps/dir/";
            string[] urlParameter;

            urlParameter= fromTextBox.Text.Split(new char[0]);
            string last = urlParameter.Last();

            foreach (string s in urlParameter) {
                if (s.Equals(last))
                {
                    url = url + s + "/";
                }
                else url = url + s + "+";
            }

            Array.Clear(urlParameter,0,urlParameter.Length); // clear the array for the second part of parameters
            urlParameter = toTextbox.Text.Split(new char[0]);
            last = urlParameter.Last();

            foreach (string s1 in urlParameter) {
                if (s1.Equals(last))
                {
                    url = url + s1;
                }
                else url = url + s1 + "+";
            }

            Process.Start(new ProcessStartInfo(url));
        }
    }
}
