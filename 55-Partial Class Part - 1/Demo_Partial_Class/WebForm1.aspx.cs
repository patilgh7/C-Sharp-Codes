﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demo_Partial_Class
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Customer C1 = new Customer();
            C1.FirstName = "Pragim";
            C1.LastName = "Technologies";

            string FullName1 = C1.GetFullName();
            Response.Write("Full Name = " + FullName1 + "<br/>");


            PartialCustomer C2 = new PartialCustomer();
            C2.FirstName = "Gaurav";
            C2.LastName = "Patil";

            string FullName2 = C2.GetFullName();
            Response.Write("Full Name = " +FullName2 + "<br/>");


        }   
    }
}