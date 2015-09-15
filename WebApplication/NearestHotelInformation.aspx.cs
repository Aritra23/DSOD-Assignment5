using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication
{
    public partial class NearestHotelInformation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string r = TextBox1.Text;
            ServiceReference1.Service1Client ob = new ServiceReference1.Service1Client();
            Label1.Text = ob.nearbyhotels(r);
            Label1.Visible = true;
        }
    }
}