using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace DesktopApp
{
    public partial class Form1
    {
        private void changeLocationType(Boolean isAddress)
        {
            addressTextBox.Enabled = isAddress;
            latitudeTextBox.Enabled = !isAddress;
            longitudeTextBox.Enabled = !isAddress;

            // latitude/longitude radio buttons
            latitudeN.Enabled = !isAddress;
            latitudeS.Enabled = !isAddress;
            longitudeW.Enabled = !isAddress;
            longitudeE.Enabled = !isAddress;
        }

        private void addToSearchHistroy(string location, string mapUrl)
        {
            KeyValuePair<String, String> newEntry = new KeyValuePair<string, string>(location, mapUrl);
            searchHistory.Add(newEntry);
            //goToMap.Click += new EventHandler(btn_click);
            searchHistroyListView.Rows.Add(newEntry.Key, newEntry.Value, ">>");
        }

        private void showMap(string location, string mapUrl)
        {
            if (!openInBrowser)
            {
                form2 = new Form();
                form2.Text = location;
                form2.Size = new Size(new Point(915, 815));
                WebBrowser mapBrowser = new WebBrowser();
                mapBrowser.Size = new Size(new Point(900, 800));
                form2.Controls.Add(mapBrowser);
                mapBrowser.Navigate(mapUrl);
                form2.Show();
            }
            else Process.Start(new ProcessStartInfo(mapUrl));
        }

    }
}
