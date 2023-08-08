<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FacultyReports.aspx.cs" Inherits="FacultyReports" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div id ="mydiv" runat ="server" style ="position:absolute; top: -10px; left: 8px; height: 727px; width: 1144px;">
            <asp:ReportViewer ID="reportView1" style ="width:100%; height:100%;"> </asp:ReportViewer>
        </div>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <div runat ="server" style ="position:absolute; top: 19px; left: 34px;">
            <asp:Button ID="BackButton" runat="server" Text="Back" OnClick="BackButton_Click" />
        </div>
    </form>
</body>
</html>
