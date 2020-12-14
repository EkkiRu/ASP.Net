using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace WebApplication4
{
    public partial class Register : System.Web.UI.Page
    {
        private SqlConnection sqlConnection = null;
        protected async void Page_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;

            sqlConnection = new SqlConnection(connectionString);

            await sqlConnection.OpenAsync();

        }

        protected async void Button1_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> db = new Dictionary<string, string>();

            SqlCommand getUsersCredCmd = new SqlCommand("Select [Login], [Password] From [Users]");

            SqlDataReader sqlReader = null;

            try
            {
                sqlReader = await getUsersCredCmd.ExecuteReaderAsync();

                while (await sqlReader.ReadAsync())
                {
                    db.Add(Convert.ToString(sqlReader["Login"]), Convert.ToString(sqlReader["Password"]));
                }
            }
            catch
            {

            }
            finally
            {
                if (sqlReader != null)
                {
                    sqlReader.Close();
                }
            }
            if(!db.Keys.Contains(TextBox1.Text))
            {
                SqlCommand regUser = new SqlCommand("Insert into [Users](Login, Password) Values(@Login, @Password)", sqlConnection);
                regUser.Parameters.AddWithValue("Login", TextBox1.Text);
                regUser.Parameters.AddWithValue("Password", TextBox2.Text);

                await regUser.ExecuteNonQueryAsync();
                
                Response.Redirect("Login.aspx", false);

            }
            else
            {
                string script = "alert('Pomenyai login')";
                ClientScript.RegisterClientScriptBlock(this.GetType(), "MessageBox", script, true);
            }
          
        }
        protected void Page_Unload(object sender, EventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != System.Data.ConnectionState.Closed)
            {
                sqlConnection.Close();
            }
        }
    }
}