using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace WebApplication
{
    public partial class PaymentValidation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String status = "false";

            string CardNumber = TextBox2.Text.Trim();
            string CVV = TextBox3.Text.Trim();
            string ExpiryDate = TextBox4.Text.Trim();
            string FullName = TextBox1.Text;

            String url = "http://localhost:63697/Service1.svc/CreditCardVal?name=" + FullName + "&cardno=" + CardNumber + "&cvv=" + CVV + "&expiry_date=" + ExpiryDate;
            WebRequest urlrequest = WebRequest.Create(@url);
            urlrequest.Method = "GET";

            HttpWebResponse response = urlrequest.GetResponse() as HttpWebResponse;

            if (response.StatusCode == HttpStatusCode.OK)
            {
                using (Stream responseStream = response.GetResponseStream())
                {
                    XmlDocument xmlDocObject = new XmlDocument();
                    xmlDocObject.Load(responseStream);
                    status = Convert.ToString(xmlDocObject["boolean"].InnerText);
                }
            }
            else
            {
                Label1.Text = " Unable to connect";
                Label1.Visible = true;
            }


            if (status == "true")
            {
                Label1.Text = "Valid";
                Label1.Visible = true;


            }
            else
            {
                Label1.Text = "Invalid";
                Label1.Visible = true;
            }
        

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string username = TextBox5.Text;
            string password = TextBox6.Text;
            double amount = Convert.ToDouble(TextBox7.Text);


            String url = "http://localhost:63681/Service1.svc/PaymentVal?usrnm=" + username + "&passwd=" + password + "&amt=" + amount;
            WebRequest urlrequest = WebRequest.Create(@url);
            urlrequest.Method = "GET";

            HttpWebResponse response = urlrequest.GetResponse() as HttpWebResponse;

            if (response.StatusCode == HttpStatusCode.OK)
            {
                using (Stream responseStream = response.GetResponseStream())
                {
                    XmlDocument xmlDocObject = new XmlDocument();
                    xmlDocObject.Load(responseStream);
                    Label2.Text = Convert.ToString(xmlDocObject["string"].InnerText);
                    Label2.Visible = true;
                }
            }
            else
            {
                Label2.Text = " Unable to connect";
                Label2.Visible = true;
            }


        }


        

        
    }
}