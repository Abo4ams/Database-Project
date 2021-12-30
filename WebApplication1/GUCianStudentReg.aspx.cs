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
    public partial class GUCianStudentReg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["PostGradOffice"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand loginProc = new SqlCommand("studentRegister", conn);
            loginProc.CommandType = CommandType.StoredProcedure;

            loginProc.Parameters.Add(new SqlParameter("@first_name", fname.Text));
            loginProc.Parameters.Add(new SqlParameter("@last_name", lname.Text));
            loginProc.Parameters.Add(new SqlParameter("@password", password.Text));
            loginProc.Parameters.Add(new SqlParameter("@faculty", faculty.Text));
            loginProc.Parameters.Add(new SqlParameter("@Gucian", 1));
            loginProc.Parameters.Add(new SqlParameter("@email", email.Text));
            loginProc.Parameters.Add(new SqlParameter("@address", address.Text));

            conn.Open();
            loginProc.ExecuteNonQuery();
            conn.Close();
            Response.Redirect("login.aspx");
        }
    }
}
