using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Default1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Person p = new Person(TextBox1.Text, Convert.ToInt32(TextBox2.Text));

            ViewState["person"] = p;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Person p = ViewState["person"] as Person;

            if(p != null)
            {
                Label1.Text = p.Name;
                Label2.Text = p.Age.ToString();
            }
            else
            {
                Label1.Text = "Null";
                Label2.Text = "Null";
            }
        }
    }
}