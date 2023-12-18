using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Creating_Indexer_Demo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            Company company = new Company();

            // Retrieving the names and showing on web page
            Response.Write("Name of Employee With Id = 2:" + company[2]);
            Response.Write("<br/>");

            Response.Write("Name of Employee With Id = 5:" + company[5]);
            Response.Write("<br/>");

            Response.Write("Name of Employee With Id = 8:" + company[8]);
            Response.Write("<br/>");
            Response.Write("<br/>");
            Response.Write("<br/>");

            // changing the names

            Response.Write("Changing the name of employee with Id = 2, 5 & 8");
            Response.Write("<br/>");

            company[2] = "Ram";
            company[5] = "Shyam";
            company[8] = "Krish";

            Response.Write("Name of Employee With Id = 2:" + company[2]);
            Response.Write("<br/>");

            Response.Write("Name of Employee With Id = 5:" + company[5]);
            Response.Write("<br/>");

            Response.Write("Name of Employee With Id = 8:" + company[8]);
            Response.Write("<br/>");


        }
    }
}