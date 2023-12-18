using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OverloadingIndexer
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {

            Company company = new Company();

            // Retrieving the Male and Female Gender from list and showing on web page
            Response.Write("Before Update");
            Response.Write("<br/>");
            Response.Write("Total Male Employees = " + company["Male"]);
            Response.Write("<br/>");

            Response.Write("Total Female Employees = " + company["Female"]);
            Response.Write("<br/>");


            Response.Write("<br/>"); 
            Response.Write("<br/>");



            // setting all Male Genders to Female
            Response.Write("After Changing to All Male To Female");
            company["Male"] = "Female";

            Response.Write("<br/>");
            Response.Write("Total Male Employees = " + company["Male"]);
            Response.Write("<br/>");

            Response.Write("Total Female Employees = " + company["Female"]);
            Response.Write("<br/>");


        }
    }
}