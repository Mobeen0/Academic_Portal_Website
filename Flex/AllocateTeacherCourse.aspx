<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AllocateTeacherCourse.aspx.cs" Inherits="AllocateTeacherCourse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div runat="server" style ="position:absolute; top: 44px; left: 106px; height: 522px; width: 1243px;background:#242449">

        </div>
        <div runat="server" style ="position:absolute; top: 103px; left: 463px;">
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </div>
        <div runat ="server" style ="position:absolute; top: 104px; left: 804px;">
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </div>
        <div runat ="server" style ="position:absolute; top: 272px; left: 263px;">
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </div>
        <div runat ="server" style="position:absolute; top: 104px; left: 327px;">
            <asp:Label ID="Label1" runat="server" Text="Course Group" Font-Bold="True" ForeColor="White"></asp:Label>
        </div>
        <div runat ="server" style="position:absolute; top: 105px; left: 657px;">
            <asp:Label ID="Label2" runat="server" Text="Course Number" Font-Bold="True" ForeColor="White"></asp:Label>
        </div>
        <div runat ="server" style="position:absolute; top: 270px; left: 133px;">
            <asp:Label ID="Label3" runat="server" Text="Coordinator" Font-Bold="True" ForeColor="White"></asp:Label>
        </div>
        <div runat ="server" style="position:absolute; top: 318px; left: 303px;">
            <asp:Button ID="Button1" runat="server" Text="Add Coordinator" OnClick="Button1_Click" />
        </div>
        <div runat ="server" style="position:absolute; top: 241px; left: 991px;">
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </div>
        <div runat ="server" style="position:absolute; top: 243px; left: 906px;">
            <asp:Label ID="Label4" runat="server" Text="Section" Font-Bold="True" ForeColor="White"></asp:Label>
        </div>
        <div runat ="server" style="position:absolute; top: 301px; left: 993px;">
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        </div>
        <div runat ="server" style="position:absolute; top: 303px; left: 897px;">
            <asp:Label ID="Label5" runat="server" Text="Instructor" Font-Bold="True" ForeColor="White"></asp:Label>
        </div>
        <div runat ="server" style="position:absolute; top: 368px; left: 1101px;">
            <asp:Button ID="Button2" runat="server" Text="Add Instructor" OnClick="Button2_Click" />
        </div>
        <div runat="server" style ="position:absolute; top: 15px; left: 54px;">
            <asp:Button ID="Button3" runat="server" Text="Back" OnClick="Button3_Click" />
        </div>
    </form>
</body>
</html>
