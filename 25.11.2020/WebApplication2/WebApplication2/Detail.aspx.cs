using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class Detail : System.Web.UI.Page
    {
        Dictionary<int, string> dict = new Dictionary<int, string>();
        protected void Page_Load(object sender, EventArgs e)
        {
            dict.Add(1, "С# is != very very");
            dict.Add(2, "Java is == very very");

            string temp = Request.QueryString["id"];

            if (!string.IsNullOrEmpty(temp))
            {
                int id = Convert.ToInt32(temp);
                Label1.Text = dict[id];
            }
            else
            {
                Label1.Text = "null";
            }
        }
    }
}