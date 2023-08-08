using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CourseRegStd : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string pageType = Request.QueryString["arg4"];

        if (pageType == "CourseReg")
        {
            CourseRegistration();
        }


    }
    public void CourseRegistration()
    {
        string userName = Request.QueryString["arg1"];
        string pass = Request.QueryString["arg2"];


        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-QCKS8SAO\\SQLEXPRESS;Initial Catalog=FLEX;Integrated Security=True");
        string query;
        query = "EXEC Offered_Courses @UserName = '" + userName + "'" + ", @uPass =" + "'" + pass + "'";


        ReportViewer reportView1 = new ReportViewer();
        reportView1.ProcessingMode = ProcessingMode.Local;
        reportView1.LocalReport.ReportPath = Server.MapPath("Allowed_Courses.rdlc");

        DataTable dataTable = new DataTable();
        SqlCommand cmd = new SqlCommand(query, conn);
        SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
        dataAdapter.Fill(dataTable);

        ReportDataSource reportData1 = new ReportDataSource(@"DataSet1", dataTable);
        reportView1.LocalReport.DataSources.Add(reportData1);


        reportView1.Width = 1390;
        reportView1.Height = 600;
        reportView1.ShowToolBar = false;
        reportView1.LocalReport.Refresh();
        mydiv.Controls.Add(reportView1);
        cmd.Dispose();
        conn.Close();

    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string userName = Request.QueryString["arg1"];
        string pass = Request.QueryString["arg2"];
        string uType = Request.QueryString["arg3"];
        string pType = "Home";
        string arg = "LoggedIn.aspx?arg1=" + userName + "&arg2=" + pass + "&arg3=" + uType + "&arg4=" + pType;
        Response.Redirect(arg);
    }


    protected void Button5_Click(object sender, EventArgs e)
    {
        string userName = Request.QueryString["arg1"];
        string pass = Request.QueryString["arg2"];
        string uType = Request.QueryString["arg3"];
        string pType = "Transcript";
        string arg = "LoggedIn.aspx?arg1=" + userName + "&arg2=" + pass + "&arg3=" + uType + "&arg4=" + pType;
        Response.Redirect(arg);

    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        string userName = Request.QueryString["arg1"];
        string pass = Request.QueryString["arg2"];
        string uType = Request.QueryString["arg3"];
        string pType = "Attendence";
        string arg = "LoggedIn.aspx?arg1=" + userName + "&arg2=" + pass + "&arg3=" + uType + "&arg4=" + pType;
        Response.Redirect(arg);
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        string userName = Request.QueryString["arg1"];
        string pass = Request.QueryString["arg2"];
        string uType = Request.QueryString["arg3"];
        string pType = "CourseReg";
        string arg = "CourseRegStd.aspx?arg1=" + userName + "&arg2=" + pass + "&arg3=" + uType + "&arg4=" + pType;
        Response.Redirect(arg);
    }

    protected void Button4_Click(object sender, EventArgs e)
    {

    }



    protected void RegisterButton_Click(object sender, EventArgs e)
    {
        string userName = Request.QueryString["arg1"];
        string pass = Request.QueryString["arg2"];
        string CNum = CNumLabel.Text;
        string CGroup = CGroupLabel.Text;
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-QCKS8SAO\\SQLEXPRESS;Initial Catalog=FLEX;Integrated Security=True");
        conn.Open();
        SqlCommand cm;
        int retVal = 1;
        string query;
        query = "SELECT COUNT(*) " +
                "FROM USERS u " +
                "INNER JOIN COURSE_Registering ct "+
                "ON u.REG_NO = ct.REG_NO "+
                "WHERE u.UNAME = '" + userName + "' AND u.PASS = '" + pass + "' AND ct.C_GROUP = '" + CGroup+"' AND ct.C_NUM = "+CNum+";";
        cm = new SqlCommand(query,conn);
        retVal = (int)cm.ExecuteScalar();
        if (retVal == 0)
        {
            query = "EXEC sys.sp_set_session_context @key=N'LoggedUser',@value='" + userName + "';";
            cm = new SqlCommand(query, conn);
            cm.ExecuteNonQuery();

            query = "EXEC CRSRegister @UserName = '" + userName + "', @uPass = '" + pass + "', @CrsNum = " + CNum + " , @CRSGroup = '" + CGroup + "';";
            cm = new SqlCommand(query, conn);
            cm.ExecuteNonQuery();
        }
        cm.Dispose();
        conn.Close();

        string uType = Request.QueryString["arg3"];
        string pType = "CourseReg";
        string arg = "CourseRegStd.aspx?arg1=" + userName + "&arg2=" + pass + "&arg3=" + uType + "&arg4=" + pType;
        Response.Redirect(arg);



    }
}