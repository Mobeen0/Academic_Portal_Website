using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ShowRegStd : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-QCKS8SAO\\SQLEXPRESS;Initial Catalog=FLEX;Integrated Security=True");
        conn.Open();
        string query = "SELECT * FROM " +
                     "COURSE_REGISTERING";

        ReportViewer reportView1 = new ReportViewer();
        reportView1.ProcessingMode = ProcessingMode.Local;
        reportView1.LocalReport.ReportPath = Server.MapPath("ShowRegisteringStudents.rdlc");

        DataTable dataTable = new DataTable();
        SqlCommand cmd = new SqlCommand(query, conn);
        SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
        dataAdapter.Fill(dataTable);
        ReportDataSource reportData = new ReportDataSource(@"DataSet1", dataTable);
        reportView1.LocalReport.DataSources.Add(reportData);

        reportView1.Width = 1500;
        reportView1.Height = 600;
        reportView1.ShowToolBar = false;
        reportView1.LocalReport.Refresh();
        mydiv.Controls.Add(reportView1);
        cmd.Dispose();
        conn.Close();
    }

}