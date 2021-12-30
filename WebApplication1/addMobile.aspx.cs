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
    public partial class addMobile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void add(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["PostGradOffice"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            String ID = id.Text;
            String phoneNo = mobile.Text;

            SqlCommand loginProc = new SqlCommand("addMobile", conn);
            loginProc.CommandType = CommandType.StoredProcedure;

            loginProc.Parameters.Add(new SqlParameter("@ID", id));
            loginProc.Parameters.Add(new SqlParameter("@mobile_number", phoneNo));


            conn.Open();
            loginProc.ExecuteNonQuery();
            conn.Close();
            if (id.Text == "" || mobile.Text == "")
            {
                Response.Write("<script>alert('You have to enter you id and phone number')</script>");
            }
            }
        }
    }
