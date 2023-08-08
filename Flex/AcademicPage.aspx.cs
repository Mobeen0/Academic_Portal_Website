using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AcademicPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string userName = Request.QueryString["arg1"];
        string pass = Request.QueryString["arg2"];
        string uType= Request.QueryString["arg3"];
        string pageType = Request.QueryString["arg4"];
        string arg;
        arg = "AcademicReports.aspx?arg1=" + userName + "&arg2=" + pass + "&arg3=" + uType + "&arg4=" + pageType;
        if (pageType == "ShowCourse" || pageType=="StudentSection" || pageType=="CourseInfo" || pageType=="ShowAuditLog")
        {
            Response.Redirect(arg);
        }
        if (pageType == "Add/Delete")
        {
            arg = "AddCourseForm.aspx?arg1=" + userName + "&arg2=" + pass + "&arg3=" + uType + "&arg4=" + pageType;
            Response.Redirect(arg);
        }
        if (pageType == "AllocTeacherCourse")
        {
            arg = "AllocateTeacherCourse.aspx?arg1=" + userName + "&arg2=" + pass + "&arg3=" + uType + "&arg4=" + pageType;
            Response.Redirect(arg);
        }
        if (pageType == "ShowRegStd")
        {
            arg = "ShowRegStd.aspx?arg1=" + userName + "&arg2=" + pass + "&arg3=" + uType + "&arg4=" + pageType;
            Response.Redirect(arg);
        }
    }


    protected void Courses_Click(object sender, EventArgs e)
    {
        string userName = Request.QueryString["arg1"];
        string pass = Request.QueryString["arg2"];
        string uType = Request.QueryString["arg3"];
        string pageType = "ShowCourse";
        string arg;
        arg = "AcademicPage.aspx?arg1=" + userName + "&arg2=" + pass + "&arg3=" + uType + "&arg4=" + pageType;
        Response.Redirect(arg);
    }

    protected void StdSections_Click(object sender, EventArgs e)
    {
        string userName = Request.QueryString["arg1"];
        string pass = Request.QueryString["arg2"];
        string uType = Request.QueryString["arg3"];
        string pageType = "StudentSection";
        string arg;
        arg = "AcademicPage.aspx?arg1=" + userName + "&arg2=" + pass + "&arg3=" + uType + "&arg4=" + pageType;
        Response.Redirect(arg);
    }

    protected void CourseAlloc_Click(object sender, EventArgs e)
    {
        string userName = Request.QueryString["arg1"];
        string pass = Request.QueryString["arg2"];
        string uType = Request.QueryString["arg3"];
        string pageType = "CourseInfo";
        string arg;
        arg = "AcademicPage.aspx?arg1=" + userName + "&arg2=" + pass + "&arg3=" + uType + "&arg4=" + pageType;
        Response.Redirect(arg);
    }

    protected void ADcourse_Click(object sender, EventArgs e)
    {
        string userName = Request.QueryString["arg1"];
        string pass = Request.QueryString["arg2"];
        string uType = Request.QueryString["arg3"];
        string pageType = "Add/Delete";
        string arg;
        arg = "AcademicPage.aspx?arg1=" + userName + "&arg2=" + pass + "&arg3=" + uType + "&arg4=" + pageType;
        Response.Redirect(arg);

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        string userName = Request.QueryString["arg1"];
        string pass = Request.QueryString["arg2"];
        string uType = Request.QueryString["arg3"];
        string pageType = "AllocTeacherCourse";
        string arg;
        arg = "AcademicPage.aspx?arg1=" + userName + "&arg2=" + pass + "&arg3=" + uType + "&arg4=" + pageType;
        Response.Redirect(arg);
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string userName = Request.QueryString["arg1"];
        string pass = Request.QueryString["arg2"];
        string uType = Request.QueryString["arg3"];
        string pageType = "ShowRegStd";
        string arg;
        arg = "AcademicPage.aspx?arg1=" + userName + "&arg2=" + pass + "&arg3=" + uType + "&arg4=" + pageType;
        Response.Redirect(arg);

    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        string userName = Request.QueryString["arg1"];
        string pass = Request.QueryString["arg2"];
        string uType = Request.QueryString["arg3"];
        string pageType = "ShowAuditLog";
        string arg;
        arg = "AcademicPage.aspx?arg1=" + userName + "&arg2=" + pass + "&arg3=" + uType + "&arg4=" + pageType;
        Response.Redirect(arg);
    }

}