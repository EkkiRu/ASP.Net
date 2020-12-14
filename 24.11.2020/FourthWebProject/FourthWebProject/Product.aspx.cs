using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FourthWebProject
{
    public partial class Product : System.Web.UI.Page
    {
        string id = string.Empty; 
        protected void Page_Load(object sender, EventArgs e)
        {
            id = Request.QueryString["id"];

            if (!string.IsNullOrEmpty(id))
            {
                Label1.Text = id;
            }
            else
            {
                Label1.Text = "Null";
            }
        }
    }
}