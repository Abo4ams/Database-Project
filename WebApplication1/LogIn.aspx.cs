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
    public partial class LogIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void logIn(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["PostGradOffice"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            String mail = email.Text;
            String pass = password.Text;

            SqlCommand loginProc = new SqlCommand("userLoginEmail", conn);
            loginProc.CommandType = CommandType.StoredProcedure;

            loginProc.Parameters.Add(new SqlParameter("@email", mail));
            loginProc.Parameters.Add(new SqlParameter("@password", pass));


            SqlParameter sucess = loginProc.Parameters.Add("@success", SqlDbType.Bit);
            SqlParameter type = loginProc.Parameters.Add("@type", SqlDbType.Int);
            sucess.Direction = ParameterDirection.Output;
            type.Direction = ParameterDirection.Output;

            conn.Open();
            loginProc.ExecuteNonQuery();
            conn.Close();
            if (email.Text == "" || password.Text == "")
            {
                Response.Write("<script>alert('You have to enter you email and password')</script>");
            }
            else
            {
                if (sucess.Value.ToString() == "True")
                {
                    Session["user"] = mail;

                    if (type.Value.ToString() == "0")
                        Response.Redirect("GUCianStudent.aspx");
                    else if (type.Value.ToString() == "1")
                        Response.Redirect("NonGUCianStudent.aspx");
                    else if (type.Value.ToString() == "2")
                        Response.Redirect("Admin.aspx");
                    else if (type.Value.ToString() == "3")
                        Response.Redirect("Supervisor.aspx");
                    else if (type.Value.ToString() == "4")
                        Response.Redirect("Examiner.aspx");

                }
                else
                    Response.Write("<script>alert('Please Register First')</script>");
            }
        }
    }
}