using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SecondWebProject
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          /*  Response.Write("Ну дарова! <br />");

            for(int i = 0; i<10; i++)
            {
                Response.Write("*");
            }*/
        }
        protected void Page_Unload(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Response.Write(Request.QueryString);
            Response.Write(Server.MapPath("File.txt"));
        }
    }
}