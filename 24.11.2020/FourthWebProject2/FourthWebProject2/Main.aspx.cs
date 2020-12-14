using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FourthWebProject2
{
    public partial class Main : System.Web.UI.Page
    {
        String name = string.Empty;
        String age = string.Empty;
        protected void Page_Load(object sender, EventArgs e)
        {
            name = Request.Form["TextBox2"];
            age = Request.Form["TextBox1"];
            if(!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(age))
            {
                Label1.Text = name;
                Label2.Text = age;
            }
            else
            {
                Label3.Text = "Error";
            }

        }
    }
}