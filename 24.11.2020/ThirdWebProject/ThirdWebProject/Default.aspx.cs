using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThirdWebProject
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            foreach (string el in Request.QueryString)
            {
                Response.Write(el + " " + Request.QueryString[el]+ "<br />");
            }
            //Response.Write("Общая информация: <br />");
            //Response.Write(Request.ApplicationPath + "<br />");
            //Response.Write(Request.PhysicalApplicationPath + "<br />");
            //Response.Write(Request.Browser.Platform + "<br />");
            //Response.Write(Request.Browser.Type + "<br />");
            //Response.Write("Языки: <br />");

            //foreach(String lang in Request.UserLanguages)
            //{
            //    Response.Write(lang + "<br />");
            //}

            //Response.Write("Основной Язык " + Request.UserLanguages[0] + "<br />");
            //Response.Write("Отправляем с локального компа "+ Request.IsLocal +"<br />");
            //foreach (var header in Request.Headers)
            //    Response.Write(header + "<br />");


        }
    }
}