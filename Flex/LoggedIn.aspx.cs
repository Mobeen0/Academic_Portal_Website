using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LoggedIn : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        string pageType = Request.QueryString["arg4"];

        if (pageType == "Home")
        {
            Homepage();
        }
        if(pageType=="Attendence")
        {
            Attendpage();
        }
        if (pageType == "CourseReg")
        {
            //CourseRegistration(); // loaded directly from button click
        }
        if (pageType == "Transcript")
        {
            StTranscript();
        }


       
    }

    public void Homepage()
    {
        string userName = Request.QueryString["arg1"];
        string pass = Request.QueryString["arg2"];


        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-QCKS8SAO\\SQLEXPRESS;Initial Catalog=FLEX;Integrated Security=True");
        conn.Open();
        string query;
        query = "SELECT * " +
            "FROM USERS u " +
            "INNER JOIN STUDENT s " +
            "ON u.REG_NO = s.REG_NO AND u.UTYPE = s.UTYPE " +
            "INNER JOIN CAMPUSES c " +
            "ON c.C_ID = u.C_ID " +
            "INNER JOIN RELATIONS r " +
            "ON r.REG_NO = s.REG_NO " +
            "WHERE u.UNAME= '" + userName + "' AND u.PASS = '" + pass + "'";


        ReportViewer reportView1 = new ReportViewer();
        reportView1.ProcessingMode = ProcessingMode.Local;
        reportView1.LocalReport.ReportPath = Server.MapPath("HomeReport.rdlc");

        DataTable dataTable = new DataTable();
        SqlCommand cmd = new SqlCommand(query, conn);
        SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
        dataAdapter.Fill(dataTable);

        ReportDataSource reportData = new ReportDataSource(@"DataSet", dataTable);
        reportView1.LocalReport.DataSources.Add(reportData);
        ReportDataSource reportData1 = new ReportDataSource(@"DataSet1", dataTable);
        reportView1.LocalReport.DataSources.Add(reportData1);
        ReportDataSource reportData2 = new ReportDataSource(@"DataSet2", dataTable);
        reportView1.LocalReport.DataSources.Add(reportData2);
        ReportDataSource reportData3 = new ReportDataSource(@"DataSet3", dataTable);
        reportView1.LocalReport.DataSources.Add(reportData3);

        reportView1.Width = 1390;
        reportView1.Height = 1300;
        reportView1.ShowToolBar = false;
        reportView1.LocalReport.Refresh();
        mydiv.Controls.Add(reportView1);
        cmd.Dispose();
        conn.Close();
    }

    public void Attendpage()
    {
        string userName = Request.QueryString["arg1"];
        string pass = Request.QueryString["arg2"];


        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-QCKS8SAO\\SQLEXPRESS;Initial Catalog=FLEX;Integrated Security=True");
        string query;
        query = "EXEC Attend_Rep @UserName = '" + userName +"'" +", @uPass ="+ "'"+pass+"'";


        ReportViewer reportView1 = new ReportViewer();
        reportView1.ProcessingMode = ProcessingMode.Local;
        reportView1.LocalReport.ReportPath = Server.MapPath("AttendenceReport.rdlc");

        DataTable dataTable = new DataTable();
        SqlCommand cmd = new SqlCommand(query, conn);
        SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
        dataAdapter.Fill(dataTable);

        ReportDataSource reportData4 = new ReportDataSource(@"DataSet4", dataTable);
        reportView1.LocalReport.DataSources.Add(reportData4);

        reportView1.Width = 1390;
        reportView1.Height = 1300;
        reportView1.ShowToolBar = false;
        reportView1.LocalReport.Refresh();
        mydiv.Controls.Add(reportView1);
        cmd.Dispose();
        conn.Close();
    }


    public void StTranscript()
    {
        string userName = Request.QueryString["arg1"];
        string pass = Request.QueryString["arg2"];


        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-QCKS8SAO\\SQLEXPRESS;Initial Catalog=FLEX;Integrated Security=True");
        string query;
        query = "EXEC StTranscript @UserName = '" + userName + "'" + ", @uPass =" + "'" + pass + "'";


        ReportViewer reportView1 = new ReportViewer();
        reportView1.ProcessingMode = ProcessingMode.Local;
        reportView1.LocalReport.ReportPath = Server.MapPath("TranscriptReport.rdlc");

        DataTable dataTable = new DataTable();
        SqlCommand cmd = new SqlCommand(query, conn);
        SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
        dataAdapter.Fill(dataTable);

        ReportDataSource reportData1 = new ReportDataSource(@"DataSet1", dataTable);
        reportView1.LocalReport.DataSources.Add(reportData1);


        reportView1.Width = 1390;
        reportView1.Height = 1300;
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
        string arg = "LoggedIn.aspx?arg1=" + userName + "&arg2=" + pass+"&arg3="+uType+"&arg4="+pType;
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
}