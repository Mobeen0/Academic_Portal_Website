using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

public partial class AddCourseForm : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        string userName = Request.QueryString["arg1"];
        string pass = Request.QueryString["arg2"];
        string uType = Request.QueryString["arg3"];
        string pageType = "None";
        string arg;
        arg = "AcademicPage.aspx?arg1=" + userName + "&arg2=" + pass + "&arg3=" + uType + "&arg4=" + pageType;
        Response.Redirect(arg);
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string CGrp = CourseGrp.Text;
        string CNum = CourseNum.Text;
        string CHour = CHours.Text;
        string CName = CourseName.Text;

        string query = "SELECT COUNT(*) FROM COURSES WHERE C_NUM = '" + CNum + "' AND C_GROUP = '" + CGrp + "'";

        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-QCKS8SAO\\SQLEXPRESS;Initial Catalog=FLEX;Integrated Security=True");
        conn.Open();
        int Retval;
        SqlCommand cm;
        cm = new SqlCommand(query, conn);
        Retval = (int)cm.ExecuteScalar();

        string userName = Request.QueryString["arg1"];
        if (Retval == 0)
        {
            query = "EXEC sys.sp_set_session_context @key=N'LoggedUser',@value='" + userName + "';";
            cm = new SqlCommand(query, conn);
            cm.ExecuteNonQuery();
            query = "INSERT INTO COURSES(C_NUM,C_GROUP,CREDIT_HOURS,C_NAME) VALUES ("+CNum+", '"+CGrp+"',"+CHour+", '"+CName+"')";
            cm = new SqlCommand(query, conn);
            cm.ExecuteNonQuery();
        }
        cm.Dispose();
        conn.Close();
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        string CGrp = CourseGrp.Text;
        string CNum = CourseNum.Text;

        string query = "SELECT COUNT(*) FROM COURSES WHERE C_NUM =" + CNum + " AND C_GROUP = '" + CGrp + "' ;";

        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-QCKS8SAO\\SQLEXPRESS;Initial Catalog=FLEX;Integrated Security=True");
        conn.Open();
        int Retval;
        SqlCommand cm;
        cm = new SqlCommand(query, conn);
        Retval = (int)cm.ExecuteScalar();

        string userName = Request.QueryString["arg1"];

        if (Retval == 1)
        {
            query = "EXEC sys.sp_set_session_context @key=N'LoggedUser',@value='" + userName + "';";
            cm = new SqlCommand(query, conn);
            cm.ExecuteNonQuery();

            query = "DELETE COURSES WHERE C_NUM = "+CNum + " AND C_GROUP = '"+ CGrp + "' ;";
            cm = new SqlCommand(query, conn);
            cm.ExecuteNonQuery();
        }

        cm.Dispose();
        conn.Close();
    }
}