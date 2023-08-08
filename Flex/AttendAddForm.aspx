<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AttendAddForm.aspx.cs" Inherits="AttendAddForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div runat ="server" style ="position:absolute; top: 109px; left: 338px;">
            <asp:Label ID="Label1" runat="server" Text="Course Group" Font-Bold="True"></asp:Label>
        </div>
        <div runat ="server" style ="position:absolute; top: 159px; left: 342px;">
            <asp:Label ID="Label2" runat="server" Text="Course Num" Font-Bold="True"></asp:Label>
        </div>
        <div runat ="server" style ="position:absolute; top: 204px; left: 344px;">
            <asp:Label ID="Label3" runat="server" Text="Roll Num" Font-Bold="True"></asp:Label>
        </div>
        <div runat ="server" style ="position:absolute; top: 250px; left: 352px;">
            <asp:Label ID="Label4" runat="server" Text="Status" Font-Bold="True"></asp:Label>
        </div>
        <div runat ="server" style ="position:absolute; top: 108px; left: 497px;">
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </div>
        <div runat ="server" style ="position:absolute; top: 160px; left: 496px;">
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </div>
        <div runat ="server" style ="position:absolute; top: 211px; left: 496px;">
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </div>
        <div runat ="server" style ="position:absolute; top: 255px; left: 493px;">
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </div>
        <div runat ="server" style ="position:absolute; top: 338px; left: 752px;">
            <asp:Button ID="Button1" runat="server" Text="Add Attendence" OnClick="Button1_Click" />
        </div>
        <div runat ="server" style ="position:absolute; top: 295px; left: 495px;">
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        </div>
        <div runat ="server" style ="position:absolute; top: 294px; left: 326px;">
            <asp:Label ID="Label5" runat="server" Text="Credit Hours" Font-Bold="True"></asp:Label>
        </div>
        <div runat ="server" style ="position:absolute; top: 27px; left: 76px;">
            <asp:Button ID="Button2" runat="server" Text="Back" OnClick="Button2_Click" />
        </div>
    </form>
</body>
</html>
