using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication
{
    public partial class NewsFocus : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        string searchkey;
        protected void Button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client ob = new ServiceReference1.Service1Client();
            Label1.Text = searchkey;
            Label1.Text = ob.NewsFocusService(searchkey);
            Label1.Visible = true;

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchkey = DropDownList1.SelectedItem.Text;
        }
    }
}