using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int counter = 0;
            object obj = ViewState["counter"];

            if (obj != null)
            {
                counter = Convert.ToInt32(obj);
            }
            counter++;
            ViewState["counter"] = counter;
            Label1.Text = counter.ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}