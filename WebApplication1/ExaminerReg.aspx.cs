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
    public partial class ExaminerReg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["PostGradOffice"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand loginProc = new SqlCommand("AddExaminer", conn);
            loginProc.CommandType = CommandType.StoredProcedure;

            int thesisNo = Int16.Parse(thesis.Text);
            DateTime defenseDate = Convert.ToDateTime(defense);


            loginProc.Parameters.Add(new SqlParameter("@ThesisSerialNo", thesisNo));
            loginProc.Parameters.Add(new SqlParameter("@DefenseDate", defenseDate));
            loginProc.Parameters.Add(new SqlParameter("@ExaminerName", name.Text));
            loginProc.Parameters.Add(new SqlParameter("@Password", password.Text));
            loginProc.Parameters.Add(new SqlParameter("@National", national.Text)); /* are we gonna change the string type to a bit?? */
            loginProc.Parameters.Add(new SqlParameter("@fieldOfWork", field.Text));

            conn.Open();
            loginProc.ExecuteNonQuery();
            conn.Close();
            Response.Redirect("login.aspx");
        }
    }
}