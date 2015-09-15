using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication
{
    public partial class NearestStore : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            //Creating the client for consuming the service
            findNearestStore.Service1Client ob = new findNearestStore.Service1Client();
            //Storing the final result and displaying it
            string result = ob.findNearestStore(TextBox2.Text, TextBox1.Text);
            Label1.Text = result;
            Label1.Visible = true;
        }
    }
}