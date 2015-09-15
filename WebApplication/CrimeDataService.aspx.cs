using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication
{
    public partial class CrimeDataService : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            crimeService.Service1Client ob = new crimeService.Service1Client();
            string zip = TextBox1.Text;
            //Calling the service and displaying the result 
            Label1.Text = ob.GetCrimeByZip(zip);
            Label1.Visible = true;

            HttpCookie cookie = new HttpCookie("myCookieId");
             cookie["Label2"] = Label2.Text;
            
             cookie.Expires = DateTime.Now.AddMonths(2);
             Response.Cookies.Add(cookie);



        }
    }
}