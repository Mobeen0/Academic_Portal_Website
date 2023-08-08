<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AcademicPage.aspx.cs" Inherits="AcademicPage" %>
<%@ Register assembly="Microsoft.ReportViewer.WebForms" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div runat ="server" style ="background-color:#f0f8ff; height: 861px; width: 1442px;">
        <div runat ="server" style ="position:absolute; top: 38px; left: 554px;">
            <asp:Image ID="Image1" runat="server" ImageUrl="~/flex-logo-blue.png" />
        </div>
        <div runat ="server" style ="position:absolute; top: 174px; left: 126px; height: 810px; width: 1204px;background:#242449;display:flex">
        </div>
         <div runat ="server" style ="position:absolute; top: 231px; left: 607px;">
            <asp:Label ID="Label1" runat="server" Text="Admin Controls" Font-Bold="True" Font-Size="XX-Large" ForeColor="White" Font-Names="Arial Black"></asp:Label>
        </div>
        <div runat="server" style="position:absolute; top: 363px; left: 193px;">
            <asp:Button ID="Courses" runat="server" Text="All Offered Courses" BackColor="#6699FF" BorderWidth="0px" Font-Bold="True" Font-Names="Bahnschrift" Font-Size="Medium" Height="140px" Width="201px" onmouseover="this.style.backgroundColor='#FFFF00';" onmouseout="this.style.backgroundColor='#6699FF';" ForeColor="White" OnClick="Courses_Click" />
        </div>
        <div runat="server" style="position:absolute; top: 364px; left: 623px;">
            <asp:Button ID="StdSections" runat="server" Text="Students Sections" BackColor="#6699FF" BorderWidth="0px" Font-Bold="True" Font-Names="Bahnschrift" Font-Size="Medium" Height="140px" Width="201px" onmouseover="this.style.backgroundColor='#FFFF00';" onmouseout="this.style.backgroundColor='#6699FF';" ForeColor="White" OnClick="StdSections_Click" />
        </div>
        <div runat="server" style="position:absolute; top: 363px; left: 1028px;">
            <asp:Button ID="CourseAlloc" runat="server" Text="Course Allocations" BackColor="#6699FF" BorderWidth="0px" Font-Bold="True" Font-Names="Bahnschrift" Font-Size="Medium" Height="140px" Width="201px" onmouseover="this.style.backgroundColor='#FFFF00';" onmouseout="this.style.backgroundColor='#6699FF';" ForeColor="White" OnClick="CourseAlloc_Click" />
        </div>
        <div runat="server" style="position:absolute; top: 599px; left: 193px;">
            <asp:Button ID="ADcourse" runat="server" Text="Add/Delete Course" BackColor="#6699FF" BorderWidth="0px" Font-Bold="True" Font-Names="Bahnschrift" Font-Size="Medium" Height="140px" Width="201px" onmouseover="this.style.backgroundColor='#FFFF00';" onmouseout="this.style.backgroundColor='#6699FF';" ForeColor="White" OnClick="ADcourse_Click" />
        </div>
        <div runat="server" style="position:absolute; top: 601px; left: 626px;">
            <asp:Button ID="Button2" runat="server" Text="Add Course Allocation" BackColor="#6699FF" BorderWidth="0px" Font-Bold="True" Font-Names="Bahnschrift" Font-Size="Medium" Height="140px" Width="201px" onmouseover="this.style.backgroundColor='#FFFF00';" onmouseout="this.style.backgroundColor='#6699FF';" ForeColor="White" OnClick="Button2_Click" />
        </div>
        <div runat ="server" style ="position:absolute; top: 601px; left: 1034px;">
            <asp:Button ID="Button1" runat="server" Text="Add Student Section" BackColor="#6699FF" BorderWidth="0px" Font-Bold="True" Font-Names="Bahnschrift" Font-Size="Medium" Height="140px" Width="201px" onmouseover="this.style.backgroundColor='#FFFF00';" onmouseout="this.style.backgroundColor='#6699FF';" ForeColor="White" OnClick="Button1_Click" />
        </div>
        <div runat ="server" style =" position:absolute; top: 816px; left: 628px;">
            <asp:Button ID="Button3" runat="server" Text="Show Audit Logs" BackColor="#6699FF" BorderWidth="0px" Font-Bold="True" Font-Names="Bahnschrift" Font-Size="Medium" Height="140px" Width="201px" onmouseover="this.style.backgroundColor='#FFFF00';" onmouseout="this.style.backgroundColor='#6699FF';" ForeColor="White" OnClick="Button3_Click" />
        </div>
        </div>
    </form>
</body>
</html>
