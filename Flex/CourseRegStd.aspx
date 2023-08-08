<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CourseRegStd.aspx.cs" Inherits="CourseRegStd" %>
<%@ Register assembly="Microsoft.ReportViewer.WebForms" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div id ="mydiv" runat ="server" style ="position:absolute; top: -6px; left: 120px; height: 492px; width: 1144px;">
            <asp:ReportViewer ID="reportView1" style ="width:100%; height:100%;"> </asp:ReportViewer>
        </div>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <style>
            .flow-layout {
                background-color:midnightblue;
            }
        </style>
        <div class="flow-layout" runat="server" style="position:relative; top: -52px; left: -2px; width: 115px; height: 1268px; margin-left: 0px; margin-right: 0px;">
            <div style ="position:absolute; top: 4px; left: 2px; height: 130px; width:115px; margin-left: 0px; background-color:darkslateblue" runat="server">
            </div>
            <div runat="server" style ="position:absolute; top: 145px; left: 5px; height: 138px; width: 117px;">
                <asp:Button ID="HomeButton" runat="server" Text="Home" BackColor="#006699" BorderStyle="Outset" Font-Bold="True" Font-Size="Medium" ForeColor="White" Height="138px" OnClick="Button1_Click" Width="102px" BorderColor="#6600FF" BorderWidth="3px" style="margin-left: 3px;" onmouseover="this.style.backgroundColor='#FF0000';" onmouseout="this.style.backgroundColor='#006699';" />
            </div>
            <div runat="server" style ="position:absolute; height:138px;width:117px;left:5px; top:310px">
                <asp:Button ID="CourseReg" runat="server" Text="Registration" BackColor="#006699" BorderStyle="Outset" Font-Bold="True" Font-Size="Small" ForeColor="White" Height="138px" OnClick="Button2_Click" Width="102px" BorderColor="#6600FF" BorderWidth="3px" style="margin-left: 3px;" onmouseover="this.style.backgroundColor='#FF0000';" onmouseout="this.style.backgroundColor='#006699';" />
            </div>
            <div runat="server" style ="position:absolute; height:138px;width:117px;left:5px; top:475px">
                <asp:Button ID="Attend" runat="server" Text="Attendence" BackColor="#006699" BorderStyle="Outset" Font-Bold="True" Font-Size="Small" ForeColor="White" Height="138px" OnClick="Button3_Click" Width="102px" BorderColor="#6600FF" BorderWidth="3px" style="margin-left: 3px;" onmouseover="this.style.backgroundColor='#FF0000';" onmouseout="this.style.backgroundColor='#006699';" />
            </div>
            <div runat="server" style ="position:absolute; height:138px;width:117px;left:5px; top:640px">
                <asp:Button ID="Mark" runat="server" Text="Marks" BackColor="#006699" BorderStyle="Outset" Font-Bold="True" Font-Size="Small" ForeColor="White" Height="138px" OnClick="Button4_Click" Width="102px" BorderColor="#6600FF" BorderWidth="3px" style="margin-left: 3px;" onmouseover="this.style.backgroundColor='#FF0000';" onmouseout="this.style.backgroundColor='#006699';" />
            </div>
            <div runat="server" style ="position:absolute; height:138px;width:117px;left:5px; top:805px">
                <asp:Button ID="Transcript" runat="server" Text="Transcript" BackColor="#006699" BorderStyle="Outset" Font-Bold="True" Font-Size="Small" ForeColor="White" Height="138px" OnClick="Button5_Click" Width="102px" BorderColor="#6600FF" BorderWidth="3px" style="margin-left: 3px;" onmouseover="this.style.backgroundColor='#FF0000';" onmouseout="this.style.backgroundColor='#006699';" />
            </div>
        </div>
        <div runat="server" style ="position:absolute; top: 506px; left: 149px; height: 158px; width: 1109px;">
            <div runat="server" style ="position:absolute; top: 148px; left: 182px;">
                <asp:Label ID="Label1" runat="server" Text="Enter Course Group:"></asp:Label>
            </div>
            <div runat="server" style ="position:absolute; top: 151px; left: 370px;">
                <asp:TextBox ID="CGroupLabel" runat="server" Width="104px"></asp:TextBox>
            </div>
            <div runat="server" style ="position:absolute; top: 198px; left: 192px;">
                <asp:Label ID="Label2" runat="server" Text="Enter Course Num:"></asp:Label>
            </div>
            <div runat ="server" style ="position:absolute; top: 205px; left: 371px;">
                <asp:TextBox ID="CNumLabel" runat="server" Width="105px"></asp:TextBox>
            </div>
            <div runat ="server" style ="position:absolute; top: 224px; left: 581px;">
                <asp:Button ID="RegisterButton" runat="server" Text="Register" OnClick="RegisterButton_Click" />
            </div>
        </div>
        
    </form>
</body>
</html>
