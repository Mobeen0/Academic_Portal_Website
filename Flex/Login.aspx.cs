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

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void UserText_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-QCKS8SAO\\SQLEXPRESS;Initial Catalog=FLEX;Integrated Security=True");
        conn.Open();
        int Retval;
        SqlCommand cm;
        string userName = UserText.Text;
        string pass = PassText.Value;
        string query; // write query here
        query = "SELECT COUNT(*) " +
            "FROM USERS u " +
            "WHERE u.UNAME= '" + userName + "' AND u.PASS = '" + pass + "';"; 
        
        cm = new SqlCommand(query, conn);
        Retval = (int)cm.ExecuteScalar();
        string userType;
        query = "SELECT u.UTYPE " +
            "FROM USERS u " +
            "WHERE u.UNAME= '" + userName + "' AND u.PASS = '" + pass + "';";
        cm = new SqlCommand(query, conn);
        userType = (string)cm.ExecuteScalar();

        string arg;
        if(Retval == 1)
        {
            query = "EXEC sys.sp_set_session_context @key=N'LoggedUser',@value='" + userName + "';";
            cm = new SqlCommand(query, conn);
            cm.ExecuteNonQuery();
            
            if (userType == "S") // student
            {
                arg = "LoggedIn.aspx?arg1=" + userName + "&arg2=" + pass + "&arg3=" + userType + "&arg4=Home";
                cm.Dispose();
                conn.Close();
                Response.Redirect(arg); // Student user found in database
            }
            if (userType == "A") // Academic officer
            {
                arg = "AcademicPage.aspx?arg1=" + userName + "&arg2=" + pass + "&arg3=" + userType + "&arg4=Home";
                cm.Dispose();
                conn.Close();
                Response.Redirect(arg); // Admin user found in database
            }
            if (userType == "F") // A faculty member
            {
                arg = "Faculty.aspx?arg1=" + userName + "&arg2=" + pass + "&arg3=" + userType + "&arg4=Home";
                cm.Dispose();
                conn.Close();
                Response.Redirect(arg);
            }
        }
        else
        {
            ; // stays on the same page
        }

        cm.Dispose();
        conn.Close();

    }
}