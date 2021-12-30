using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class AdminReg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["PostGradOffice"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            String mail = email.Text;
            String pass = password.Text;

            SqlCommand loginProc = new SqlCommand("addAdmin", conn);
            loginProc.CommandType = CommandType.StoredProcedure;

            loginProc.Parameters.Add(new SqlParameter("@email", mail));
            loginProc.Parameters.Add(new SqlParameter("@password", pass));

            conn.Open();
            loginProc.ExecuteNonQuery();
            conn.Close();
            Response.Redirect("login.aspx");
        }
    }
}