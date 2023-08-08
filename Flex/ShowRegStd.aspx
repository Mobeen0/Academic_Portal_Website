<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ShowRegStd.aspx.cs" Inherits="ShowRegStd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div id ="mydiv" runat ="server" style ="position:absolute; top: -10px; left: 10px; height: 727px; width: 1144px;">
            <asp:ReportViewer ID="reportView1" style ="width:100%; height:100%;"> </asp:ReportViewer>
        </div>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>

        <div runat="server" style ="position:absolute; top: 909px; left: 1054px;">
            <asp:Button ID="Button1" runat="server" Text="Register Student" />
        </div>
        <div runat ="server" style ="position:absolute; top: 761px; left: 840px;">
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </div>
        <div runat ="server" style ="position:absolute; top: 808px; left: 840px;">
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </div>
        <div runat ="server" style ="position:absolute; top: 761px; left: 729px;">
            <asp:Label ID="Label1" runat="server" Text="Roll Num" Font-Bold="True"></asp:Label>
        </div>
        <div runat ="server" style ="position:absolute; top: 808px; left: 715px;">
            <asp:Label ID="Label2" runat="server" Text="Course Group" Font-Bold="True"></asp:Label>
        </div>
        <div runat ="server" style ="position:absolute; top: 847px; left: 720px;">
            <asp:Label ID="Label3" runat="server" Text="Course Num" Font-Bold="True"></asp:Label>
        </div>
        <div runat ="server" style ="position:absolute; top: 850px; left: 840px;">
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </div>
        <div runat ="server" style ="position:absolute; top: 894px; left: 839px;">
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </div>
        <div runat ="server" style ="position:absolute">

        </div>
        <div runat ="server" style ="position:absolute; top: 896px; left: 742px;">
            <asp:Label ID="Label4" runat="server" Text="Section" Font-Bold="True"></asp:Label>
        </div>
    </form>
</body>
</html>
