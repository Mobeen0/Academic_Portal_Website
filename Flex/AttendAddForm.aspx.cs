using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AttendAddForm : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string CGroup = TextBox1.Text;
        string CNum = TextBox2.Text;
        string RNum = TextBox3.Text;
        string Stat = TextBox4.Text;
        string CHour = TextBox5.Text;

        int retVal = 0;
        string userName = Request.QueryString["arg1"];
        string query;
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-QCKS8SAO\\SQLEXPRESS;Initial Catalog=FLEX;Integrated Security=True");
        SqlCommand cm;
        conn.Open();

        query = "SELECT COUNT(*) " +
                "FROM COURSE_SECTIONS cs " +
                "INNER JOIN StudentSec ss " +
                "ON cs.C_NUM = ss.C_NUM AND cs.C_GROUP = ss.C_GROUP " +
                "INNER JOIN USERS u " +
                "ON u.REG_NO = cs.REG_NO " +
                "WHERE u.UNAME = '" + userName + "' AND ss.REG_NO = " + RNum+";";
        cm = new SqlCommand(query, conn);
        retVal = (int)cm.ExecuteScalar();
        if (retVal != 0) // user is found
        {
            query = "EXEC sys.sp_set_session_context @key=N'LoggedUser',@value='" + userName + "';";
            cm = new SqlCommand(query, conn);
            cm.ExecuteNonQuery();

            query = "SELECT MAX(AttendID) FROM ATTENDANCE;";
            cm = new SqlCommand(query, conn);
            retVal = (int)cm.ExecuteScalar();
            retVal += 1;
            query = "INSERT INTO ATTENDANCE(AttendID,DDATE,SEC_ID,CHOURS,SSTATUS,REG_NO) " +
                    "VALUES (" + retVal.ToString() + ",GETDATE(),0," + CHour + ",'" + Stat + "'," + RNum + ");";
            cm = new SqlCommand(query, conn);
            cm.ExecuteNonQuery();
        }
        cm.Dispose();
        conn.Close();



    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        string userName = Request.QueryString["arg1"];
        string pass = Request.QueryString["arg2"];
        string uType = Request.QueryString["arg3"];
        string pType = "None";
        string arg;
        arg = "Faculty.aspx?arg1=" + userName + "&arg2=" + pass + "&arg3=" + uType + "&arg4=" + pType;
        Response.Redirect(arg);
    }
}