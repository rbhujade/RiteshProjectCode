using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Form_Net_Framework_Project
{
    public partial class Student : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie hc = new HttpCookie("student");
            hc.Value = "Ritesh";
            Response.Cookies.Add(hc);

            var cook = Response.Cookies["student"].Value;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}