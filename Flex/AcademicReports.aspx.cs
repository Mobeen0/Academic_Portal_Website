using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
public partial class AcademicReports : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string pageType = Request.QueryString["arg4"];
        if (pageType == "ShowCourse")
        {
            ShowCourses();
        }
        if (pageType == "StudentSection")
        {
            StudentSection();
        }
        if (pageType == "CourseInfo")
        {
            CourseInfo();
        }
        if (pageType == "ShowAuditLog")
        {
            ShowAudits();
        }
    }

    public void ShowAudits()
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-QCKS8SAO\\SQLEXPRESS;Initial Catalog=FLEX;Integrated Security=True");
        string query;
        query = "SELECT * FROM AUDIT_LOG;";


        ReportViewer reportView1 = new ReportViewer();
        reportView1.ProcessingMode = ProcessingMode.Local;
        reportView1.LocalReport.ReportPath = Server.MapPath("ShowAuditLogs.rdlc");

        DataTable dataTable = new DataTable();
        SqlCommand cmd = new SqlCommand(query, conn);
        SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
        dataAdapter.Fill(dataTable);

        ReportDataSource reportData1 = new ReportDataSource(@"DataSet1", dataTable);
        reportView1.LocalReport.DataSources.Add(reportData1);


        reportView1.Width = 1500;
        reportView1.Height = 1300;
        reportView1.ShowToolBar = false;
        reportView1.LocalReport.Refresh();
        mydiv.Controls.Add(reportView1);
        cmd.Dispose();
        conn.Close();
    }
    public void ShowCourses()
    {
        string userName = Request.QueryString["arg1"];
        string pass = Request.QueryString["arg2"];


        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-QCKS8SAO\\SQLEXPRESS;Initial Catalog=FLEX;Integrated Security=True");
        string query;
        query = "EXEC AllCourse @UserName = '" + userName + "'" + ", @uPass =" + "'" + pass + "'";


        ReportViewer reportView1 = new ReportViewer();
        reportView1.ProcessingMode = ProcessingMode.Local;
        reportView1.LocalReport.ReportPath = Server.MapPath("AllCourses.rdlc");

        DataTable dataTable = new DataTable();
        SqlCommand cmd = new SqlCommand(query, conn);
        SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
        dataAdapter.Fill(dataTable);

        ReportDataSource reportData1 = new ReportDataSource(@"DataSet1", dataTable);
        reportView1.LocalReport.DataSources.Add(reportData1);


        reportView1.Width = 1500;
        reportView1.Height = 1300;
        reportView1.ShowToolBar = false;
        reportView1.LocalReport.Refresh();
        mydiv.Controls.Add(reportView1);
        cmd.Dispose();
        conn.Close();
    }

    public void StudentSection()
    {
        string userName = Request.QueryString["arg1"];
        string pass = Request.QueryString["arg2"];


        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-QCKS8SAO\\SQLEXPRESS;Initial Catalog=FLEX;Integrated Security=True");
        string query;
        query = "EXEC StudentSections ;";


        ReportViewer reportView1 = new ReportViewer();
        reportView1.ProcessingMode = ProcessingMode.Local;
        reportView1.LocalReport.ReportPath = Server.MapPath("StudentSections.rdlc");

        DataTable dataTable = new DataTable();
        SqlCommand cmd = new SqlCommand(query, conn);
        SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
        dataAdapter.Fill(dataTable);

        ReportDataSource reportData1 = new ReportDataSource(@"DataSet1", dataTable);
        reportView1.LocalReport.DataSources.Add(reportData1);


        reportView1.Width = 1500;
        reportView1.Height = 1300;
        reportView1.ShowToolBar = false;
        reportView1.LocalReport.Refresh();
        mydiv.Controls.Add(reportView1);
        cmd.Dispose();
        conn.Close();
    }

    public void CourseInfo()
    {
        string userName = Request.QueryString["arg1"];
        string pass = Request.QueryString["arg2"];


        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-QCKS8SAO\\SQLEXPRESS;Initial Catalog=FLEX;Integrated Security=True");
        string query;
        query = "EXEC ShowInstructorsTeaching ;";


        ReportViewer reportView1 = new ReportViewer();
        reportView1.ProcessingMode = ProcessingMode.Local;
        reportView1.LocalReport.ReportPath = Server.MapPath("CourseInfo.rdlc");

        DataTable dataTable = new DataTable();
        SqlCommand cmd = new SqlCommand(query, conn);
        SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
        dataAdapter.Fill(dataTable);

        ReportDataSource reportData1 = new ReportDataSource(@"DataSet1", dataTable);
        reportView1.LocalReport.DataSources.Add(reportData1);


        reportView1.Width = 1500;
        reportView1.Height = 1300;
        reportView1.ShowToolBar = false;
        reportView1.LocalReport.Refresh();
        mydiv.Controls.Add(reportView1);
        cmd.Dispose();
        conn.Close();
    }

    protected void BackButton_Click(object sender, EventArgs e)
    {
        string userName = Request.QueryString["arg1"];
        string pass = Request.QueryString["arg2"];
        string uType = Request.QueryString["arg3"];
        string pageType = "Menu";
        string arg;
        arg = "AcademicPage.aspx?arg1=" + userName + "&arg2=" + pass + "&arg3=" + uType + "&arg4=" + pageType;
        Response.Redirect(arg);
    }
}