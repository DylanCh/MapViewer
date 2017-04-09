using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace DesktopApp
{
    public partial class Form1
    {
        private void gridCell_click(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string s = searchHistroyListView.Columns[e.ColumnIndex].Name;
                if (s.Equals("action"))
                {
                    int rowIndex = e.RowIndex;
                    var row = searchHistroyListView.Rows[e.RowIndex];
                    showMap(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
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
            if (MessageBox.Show("Are you sure to leave Map Viewer?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Process.Start(new ProcessStartInfo("http://maps.google.com"));
        }

        private void copyText(object sender, EventArgs e)
        {
            // copy string
            if (this.ActiveControl is TextBox)
            {
                try
                {
                    Clipboard.SetDataObject(((TextBox)this.ActiveControl).SelectedText, true);
                }
                catch (System.Runtime.InteropServices.ExternalException ex1)
                {
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

            string location;

            if (radioButton1.Checked)
            {
                location = addressTextBox.Text;
                urlQuery = location.Split(new char[0]);

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

            else
            {
                location = "New Location";
                string lat = latitudeTextBox.Text, lon = longitudeTextBox.Text;

                // if longitude is W, then decimal longitude is negative
                if (longitudeW.Checked == true)
                    lon = "-" + lon;

                // if latitude is S, then decimal latitude is negative
                if (latitudeS.Checked == true)
                    lat = "-" + lat;

                mapUrl = mapRoot + "/maps/place/@" + lat + "," + lon + ",17z";
            }

            addToSearchHistroy(location, mapUrl);
            showMap(location, mapUrl);
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
            else
            {
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

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                stream = openFile.OpenFile();
                if (stream != null)
                {
                    // read file into a string
                    using (stream)
                    {
                        using (BufferedStream buffer = new BufferedStream(stream))
                        {
                            using (StreamReader sr = new StreamReader(buffer))
                            {
                                string str;
                                while ((str = sr.ReadLine()) != null)
                                {
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

            urlParameter = fromTextBox.Text.Split(new char[0]);
            string last = urlParameter.Last();

            foreach (string s in urlParameter)
            {
                if (s.Equals(last))
                {
                    url = url + s + "/";
                }
                else url = url + s + "+";
            }

            Array.Clear(urlParameter, 0, urlParameter.Length); // clear the array for the second part of parameters
            urlParameter = toTextbox.Text.Split(new char[0]);
            last = urlParameter.Last();

            foreach (string s1 in urlParameter)
            {
                if (s1.Equals(last))
                {
                    url = url + s1;
                }
                else url = url + s1 + "+";
            }

            //Process.Start(new ProcessStartInfo(url));
            //this.mapBrowser.Navigate(url);
            showMap("MapViewer", url);
        }

        private void sendMeFeedbacksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl.TabPages.Add(tabPage3);
            tabControl.SelectedTab = tabPage3;
        }

        private void closeEmail_Click(object sender, EventArgs e)
        {
            tabControl.TabPages.Remove(tabPage3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();

                message.To.Add(new MailAddress("hchennyc@outlook.com"));
                message.Subject = subjectLine.Text;
                message.Body = messageBody.Text;

                smtp.Port = 587;
                if (emailDropDown.SelectedText.Equals("gmail.com")) {
                    message.From = new MailAddress(emailFrom.Text + "@gmail.com");
                    smtp.Host = "smtp.gmail.com";
                    smtp.Credentials = new NetworkCredential("from@gmail.com", "pwd");
                }
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
               
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oops " + ex.Message);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                openInBrowser = true;
            else openInBrowser = false;
        }
    }
}
