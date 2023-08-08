<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddCourseForm.aspx.cs" Inherits="AddCourseForm" %>
<%@ Register assembly="Microsoft.ReportViewer.WebForms" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div runat="server" style ="position:absolute; top: 87px; left: 460px;">
            <asp:TextBox ID="CourseGrp" runat="server"></asp:TextBox>
        </div>
        <div runat ="server" style ="position:absolute; top: 131px; left: 459px;">
            <asp:TextBox ID="CourseNum" runat="server"></asp:TextBox>
        </div>
        <div runat ="server" style ="position:absolute; top: 176px; left: 460px;">
            <asp:TextBox ID="CourseName" runat="server"></asp:TextBox>
        </div>
         <div runat ="server" style ="position:absolute; top: 213px; left: 460px;">
            <asp:TextBox ID="CHours" runat="server"></asp:TextBox>
        </div>
        <div runat="server" style ="position:absolute; top: 87px; left: 325px;">
            <asp:Label ID="Label1" runat="server" Text="Course Group" Font-Bold="True"></asp:Label>
        </div>
        <div runat ="server" style ="position:absolute; top: 131px; left: 327px;">
            <asp:Label ID="CrseLabel" runat="server" Text="Course Num" Font-Bold="True"></asp:Label>
        </div>
        <div runat ="server" style ="position:absolute; top: 176px; left: 325px;">
            <asp:Label ID="Label3" runat="server" Text="Course Name" Font-Bold="True"></asp:Label>
        </div>
        <div runat="server" style ="position:absolute; top: 214px; left: 328px;">
            <asp:Label ID="Label2" runat="server" Text="Credit Hours" Font-Bold="True"></asp:Label>
        </div>
        <div runat="server" style = "position:absolute; top: 191px; left: 710px;">
            <asp:Button ID="Button1" runat="server" Text="Add Course" OnClick="Button1_Click" />
        </div>
        <div runat="server" style = "position:absolute; top: 237px; left: 706px;">
            <asp:Button ID="Button2" runat="server" Text="Delete Course" OnClick="Button2_Click" />
        </div>
        <div runat ="server" style ="position:absolute; top: 18px; left: 58px;">
            <asp:Button ID="Button3" runat="server" Text="Back" OnClick="Button3_Click" />
        </div>
    </form>
</body>
</html>
