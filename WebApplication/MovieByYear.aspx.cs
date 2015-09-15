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
    public partial class MovieByYear : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Declaring the list for storing movie values
            List<String> movieList = new List<string>();
            XmlReader xmlRead;
            string data;
            //Declaring the table for displaying data
            Table Table1 = new Table();
            Table1.BorderWidth = 1;

            try
            {
                //Storing the url of api to be used
                string url = "http://localhost:54743/Service1.svc/GetMovieByYear/" + TextBox1.Text;
                //Initializing the client
                WebClient wc = new WebClient();
                //Reading the data stream from the url
                StreamReader reader = new StreamReader(wc.OpenRead(url));
                data = reader.ReadToEnd();
                xmlRead = XmlReader.Create(new StringReader(data));

                //Creating table row for the headings
                TableRow tr = new TableRow();
                TableCell c = new TableCell();
                TableCell c2 = new TableCell();
                TableCell c3 = new TableCell();
                c.BorderWidth = 1;
                c2.BorderWidth = 1;
                c3.BorderWidth = 1;

                c.Controls.Add(new LiteralControl("Movie Title"));
                c2.Controls.Add(new LiteralControl("Popularity"));
                c3.Controls.Add(new LiteralControl("Rating"));

                tr.Cells.Add(c);
                tr.Cells.Add(c2);
                tr.Cells.Add(c3);

                Table1.Rows.Add(tr);
                //Reading the xml document until we reach the end
                while (!xmlRead.EOF)
                {

                    xmlRead.ReadToFollowing("MoviesDetail");
                    TableRow r = new TableRow();
                    //Reading the required nodes
                    xmlRead.ReadToFollowing("popularity");
                    string popularity = Convert.ToString(xmlRead.ReadString());
                    xmlRead.ReadToFollowing("rating");
                    string rating = Convert.ToString(xmlRead.ReadString());
                    xmlRead.ReadToFollowing("title");
                    string title = Convert.ToString(xmlRead.ReadString());

                    c = new TableCell();
                    c2 = new TableCell();
                    c3 = new TableCell();
                    c.BorderWidth = 1;
                    c2.BorderWidth = 1;
                    c3.BorderWidth = 1;
                    //Storing the values in the table cells
                    c.Controls.Add(new LiteralControl(title));
                    c2.Controls.Add(new LiteralControl(popularity));
                    c3.Controls.Add(new LiteralControl(rating));
                    //Adding cells to the row
                    r.Cells.Add(c);
                    r.Cells.Add(c2);
                    r.Cells.Add(c3);

                    //Adding row to the table
                    Table1.Rows.Add(r);
                }


                Table1.Visible = true;
                form1.Controls.Add(Table1);
            }
            catch (Exception) { }
        }
    }
}