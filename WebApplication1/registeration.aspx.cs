using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void reg(object sender, EventArgs e)
        {
            if (Type.SelectedItem.Value== "0")
                Response.Redirect("GUCianStudentReg.aspx");
            else if (Type.SelectedItem.Value == "1")
                Response.Redirect("NonGUCianStudentReg.aspx");
            else if (Type.SelectedItem.Value == "2")
                Response.Redirect("AdminReg.aspx");
            else if (Type.SelectedItem.Value == "3")
                Response.Redirect("SupervisorReg.aspx");
            else if(Type.SelectedItem.Value == "4")
                Response.Redirect("ExaminerReg.aspx");
            else
                Response.Write("Please Choose a type");

        }
    }
}