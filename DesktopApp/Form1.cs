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
        private Form form2;
        private List<KeyValuePair<String, String>> searchHistory; // location name, url
        private bool openInBrowser = false;

        public Form1()
        {
            InitializeComponent();

            tabPage1.Text = "Map Viewer";
            tabPage2.Text = "Trip Planner";
            tabPage3.Text = "Email Me!";
            tabControl.TabPages.Remove(tabPage3);

            emailDropDown.DataSource = new String[] {
                "gmail.com"
            };

            showToolbarToolStripMenuItem.Checked = false;

            searchHistory = new List<KeyValuePair<string, string>>();

            searchHistroyListView.Columns.Add("loc","Searched location name");
            searchHistroyListView.Columns.Add("url", "URL");
            searchHistroyListView.Columns.Add("action", "");

            searchHistroyListView.CellClick += new DataGridViewCellEventHandler(gridCell_click);

            try {
                IPHostEntry ipEntry = Dns.GetHostEntry(mapRoot);
            }
            catch (Exception e){
                MessageBox.Show("No internet connections");
                Console.WriteLine(e);
            }
        }

        
    }
}
