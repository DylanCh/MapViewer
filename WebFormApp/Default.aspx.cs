using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace WebFormApp
{
    public partial class _Default : Page
    {
        private string mapRoot = "https://www.google.com/maps/embed/v1/place?key=AIzaSyD-Ps5yzGVHllW5BBG8hfJdFJY1UurEbks&q=";

        protected void Page_Load(object sender, EventArgs e)
        {
            inThisPage.Enabled = false;
            onGoogleMaps.Selected = true;
            form1LatLong.Visible = false;

           
        }

        protected void submitBtn_Click(object sender, EventArgs e)
        {
            string address = this.address.Text;
            string[] urlQuery;
            string mapUrl = "";

            urlQuery = address.Split(new char[0]);
            string last = urlQuery.Last();
            foreach (string s in urlQuery)
            {
                string toAppend = s;
                // the last element does not need to add '+' to the end
                if (!s.Equals(last))
                    toAppend = s + "+";
                mapUrl += toAppend;
            }
            if (inThisPage.Selected)
            {
                mapUrl = mapRoot + mapUrl;

                //mapFrame.Attributes.Add("src", mapUrl);
                HtmlGenericControl mapFrame = new HtmlGenericControl("iframe");
                mapFrame.Attributes.Add("src", mapUrl);
                mapFrame.Attributes.Add("width", "800");
                mapFrame.Attributes.Add("height", "600");
                mapFrame.Attributes.Add("frameborder", "0");
                displayArea.Controls.Add(mapFrame);
                displayArea.Visible = true;
            }
            else if (onGoogleMaps.Selected)
            {
                mapUrl =  "http://google.com/maps/place/" + mapUrl;
                Response.Redirect(mapUrl);
                // Open in new window
                //Response.Write("<script type=\"text/javascript\">"+
                //    "window.open('"+ mapUrl +"','_blank'); </script>");
            }
        }

        protected void resetBtn_Click(object sender, EventArgs e)
        {
            address.Text = String.Empty;
        }

        protected void submitTripButton_Click(object sender, EventArgs e) {
            // TODO: implement
            string url = "https://www.google.com/maps/dir/";
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
            urlParameter = toTextBox.Text.Split(new char[0]);
            last = urlParameter.Last();

            foreach (string s1 in urlParameter)
            {
                if (s1.Equals(last))
                {
                    url = url + s1;
                }
                else url = url + s1 + "+";
            }

            Response.Redirect(url);
        }

        protected void searchByLongitudeLatitude_click(object sender, EventArgs e) {
            
            string lat = latitudeTextBox.Text, lon = longitudeTextBox.Text;

            // if longitude is W, then decimal longitude is negative
            if (longitudeW.Selected == true)
                lon = "-" + lon;

            // if latitude is S, then decimal latitude is negative
            if (latitudeS.Selected == true)
                lat = "-" + lat;

           string mapUrl ="https://www.google.com/maps/place/@" + lat + "," + lon + ",17z";

            Response.Redirect(mapUrl);
            
        }

        protected void locationType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //switch (locTypeDDList.SelectedItem.Value)
            //{
            //    case "1": switchLocationType(); break;
            //    case "2": switchLocationType(); break;
            //}
            switchLocationType();
        }

        private void switchLocationType() {
            if (locTypeDDList.SelectedItem.Value.Equals("1"))
            {
                locTypeDDList.ClearSelection();
                form1.Visible = true;
                form1LatLong.Visible = false;
            }
            else if (locTypeDDList.SelectedItem.Value.Equals("2"))
            {
                //locTypeDDList.ClearSelection();
                form1.Visible = false;
                form1LatLong.Visible = true;
            }
        }
    }
}