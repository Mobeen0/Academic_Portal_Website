using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Faculty : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string userName = Request.QueryString["arg1"];
        string pass = Request.QueryString["arg2"];
        string uType = Request.QueryString["arg3"];
        string pType = Request.QueryString["arg4"];
        string arg;
        if (pType == "AttendAdd")
        {
            arg = "AttendAddForm.aspx?arg1=" + userName + "&arg2=" + pass + "&arg3=" + uType + "&arg4=" + pType;
            Response.Redirect(arg);
        }
        if (pType == "AttendReport" || pType=="FacStudents")
        {
            arg = "FacultyReports.aspx?arg1=" + userName + "&arg2=" + pass + "&arg3=" + uType + "&arg4=" + pType;
            Response.Redirect(arg);
        }
    }

    protected void StdSections_Click(object sender, EventArgs e)
    {
        string userName = Request.QueryString["arg1"];
        string pass = Request.QueryString["arg2"];
        string uType = Request.QueryString["arg3"];
        string pType = "FacStudents";

        string arg = "Faculty.aspx?arg1=" + userName + "&arg2=" + pass + "&arg3=" + uType + "&arg4=" + pType;
        Response.Redirect(arg);
    }

    protected void Courses_Click(object sender, EventArgs e)
    {
        string userName = Request.QueryString["arg1"];
        string pass = Request.QueryString["arg2"];
        string uType = Request.QueryString["arg3"];
        string pType = "AttendAdd";

        string arg = "Faculty.aspx?arg1=" + userName + "&arg2=" + pass + "&arg3=" + uType + "&arg4=" + pType;
        Response.Redirect(arg);
    }

    protected void CourseAlloc_Click(object sender, EventArgs e)
    {
        string userName = Request.QueryString["arg1"];
        string pass = Request.QueryString["arg2"];
        string uType = Request.QueryString["arg3"];
        string pType = "AttendReport";

        string arg = "Faculty.aspx?arg1=" + userName + "&arg2=" + pass + "&arg3=" + uType + "&arg4=" + pType;
        Response.Redirect(arg);

    }

    protected void ADcourse_Click(object sender, EventArgs e)
    {

    }

    protected void Button2_Click(object sender, EventArgs e)
    {

    }
}