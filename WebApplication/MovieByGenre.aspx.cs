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
    public partial class MovieByGenre : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            //Declaring the list for storing movie values 
            List<String> movieList = new List<string>();
            XmlReader read;
            string data;
            //Declaring the table for displaying data
            Table Table1 = new Table();
            Table1.BorderWidth = 1;

            try
            {
                //Storing the url of api to be used
                string url = "http://localhost:59511/Service1.svc/GetMoviesByGenre/" + DropDownList1.SelectedValue;
                //Initializing the client
                WebClient wc = new WebClient();
                //Reading the data stream from the url
                StreamReader reader = new StreamReader(wc.OpenRead(url));
                data = reader.ReadToEnd();
                read = XmlReader.Create(new StringReader(data));
               
                //Creating table row for the headings
                TableRow tr = new TableRow();
                TableCell c = new TableCell();
                TableCell c1 = new TableCell();
                TableCell c2 = new TableCell();
                TableCell c3 = new TableCell();
                 
                c.BorderWidth = 1;
                c1.BorderWidth = 1;
                c2.BorderWidth = 1;
                c3.BorderWidth = 1;

                c.Controls.Add(new LiteralControl("Movie Title"));
                c1.Controls.Add(new LiteralControl("Release Date"));
                c2.Controls.Add(new LiteralControl("Popularity"));
                c3.Controls.Add(new LiteralControl("Rating"));

                tr.Cells.Add(c);
                tr.Cells.Add(c1);
                tr.Cells.Add(c2);
                tr.Cells.Add(c3);

                Table1.Rows.Add(tr);
                //Reading the xml document until we reach the end
                while(!read.EOF)
                {
                    read.ReadToFollowing("MoviesDetail");
                    TableRow r = new TableRow();
                    
                    //Reading the required nodes
                    read.ReadToFollowing("popularity");
                    string popularity = Convert.ToString(read.ReadString());
                    read.ReadToFollowing("rating");
                    string rating = Convert.ToString(read.ReadString());
                    read.ReadToFollowing("releaseDate");
                    string releaseDate = Convert.ToString(read.ReadString());
                    read.ReadToFollowing("title");
                    string title = Convert.ToString(read.ReadString());

                    c = new TableCell();
                    c1 = new TableCell();
                    c2 = new TableCell();
                    c3 = new TableCell();
                    c.BorderWidth = 1;
                    c1.BorderWidth = 1;
                    c2.BorderWidth = 1;
                    c3.BorderWidth = 1;
                    //Storing the values in the table cells
                    c.Controls.Add(new LiteralControl(title));
                    c1.Controls.Add(new LiteralControl(releaseDate));
                    c2.Controls.Add(new LiteralControl(popularity));
                    c3.Controls.Add(new LiteralControl(rating));
                    //Adding cells to the row
                    r.Cells.Add(c);
                    r.Cells.Add(c1);
                    r.Cells.Add(c2);
                    r.Cells.Add(c3);
                    
                //Adding row to the table                    
                Table1.Rows.Add(r);
            }
                Table1.Visible = true;
                form1.Controls.Add(Table1);
            }
            catch (Exception ) { }

        }
        }
        
    
}