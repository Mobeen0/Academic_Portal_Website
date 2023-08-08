using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FacultyReports : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string pType = Request.QueryString["arg4"];
        if (pType == "AttendReport")
        {
            AttendReport();
        }
        if (pType == "FacStudents")
        {
            StdReport();
        }

    }
    public void AttendReport()
    {
        string userName = Request.QueryString["arg1"];
        string pass = Request.QueryString["arg2"];


        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-QCKS8SAO\\SQLEXPRESS;Initial Catalog=FLEX;Integrated Security=True");
        string query;
        query = "EXEC ATTENDPercentage;";


        ReportViewer reportView1 = new ReportViewer();
        reportView1.ProcessingMode = ProcessingMode.Local;
        reportView1.LocalReport.ReportPath = Server.MapPath("AttendFacReport.rdlc");

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

    public void StdReport()
    {
        string userName = Request.QueryString["arg1"];
        string pass = Request.QueryString["arg2"];


        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-QCKS8SAO\\SQLEXPRESS;Initial Catalog=FLEX;Integrated Security=True");
        string query;
        query = "EXEC TeacherSections @UserName= '" + userName + "',@password ='" + pass + "';";


        ReportViewer reportView1 = new ReportViewer();
        reportView1.ProcessingMode = ProcessingMode.Local;
        reportView1.LocalReport.ReportPath = Server.MapPath("FacultyStudents.rdlc");

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
        string pageType = "None";
        string arg;
        arg = "Faculty.aspx?arg1=" + userName + "&arg2=" + pass + "&arg3=" + uType + "&arg4=" + pageType;
        Response.Redirect(arg);
    }
}