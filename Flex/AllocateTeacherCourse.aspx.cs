using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AllocateTeacherCourse : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string CourseGroup = TextBox1.Text;
        string CourseNum = TextBox2.Text;
        string Coord = TextBox3.Text;

        string query;
        string userName = Request.QueryString["arg1"];
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-QCKS8SAO\\SQLEXPRESS;Initial Catalog=FLEX;Integrated Security=True");
        conn.Open();
        SqlCommand cm;
        query = "EXEC sys.sp_set_session_context @key=N'LoggedUser',@value='" + userName + "';";
        cm = new SqlCommand(query, conn);
        cm.ExecuteNonQuery();
        query = "UPDATE COURSES " +
                       "SET COORDINATOR = " + Coord + " " +
                       "WHERE C_NUM = " + CourseNum + " AND C_GROUP = '" + CourseGroup + "'";
        cm = new SqlCommand(query, conn);
        cm.ExecuteNonQuery();
        cm.Dispose();
        conn.Close();
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

    protected void Button2_Click(object sender, EventArgs e)
    {
        string CourseGroup = TextBox1.Text;
        string CourseNum = TextBox2.Text;
        string section = TextBox4.Text;
        string Instructor = TextBox5.Text;

        string userName = Request.QueryString["arg1"];
        string query;
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-QCKS8SAO\\SQLEXPRESS;Initial Catalog=FLEX;Integrated Security=True");
        conn.Open();
        SqlCommand cm;
        query = "EXEC sys.sp_set_session_context @key=N'LoggedUser',@value='" + userName + "';";
        cm = new SqlCommand(query, conn);
        cm.ExecuteNonQuery();

        query = "SELECT MAX(SEC_ID) FROM COURSE_SECTIONS";
        cm = new SqlCommand(query, conn);
        int retVal = (int)cm.ExecuteScalar();
        retVal += 1;

        query = "INSERT INTO COURSE_SECTIONS(SEC_ID,C_GROUP,C_NUM,REG_NO,SECTION,S_ID) VALUES(" + retVal.ToString() +
                       ", '" + CourseGroup + "' ," + CourseNum + "," + Instructor + ",'" + section + "',0) ;";
        cm = new SqlCommand(query, conn);
        cm.ExecuteNonQuery();
        cm.Dispose();
        conn.Close();


    }
}