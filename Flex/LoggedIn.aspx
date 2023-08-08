<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LoggedIn.aspx.cs" Inherits="LoggedIn" %>
<%@ Register assembly="Microsoft.ReportViewer.WebForms" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

</head>
<body>
    <form id="form1" runat="server">
        <div id ="mydiv" runat ="server" style ="position:absolute; top: -6px; left: 120px; height: 727px; width: 1144px;">
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
                <asp:Button ID="HomeButton" runat="server" Text="Home" BackColor="#006699" BorderStyle="None" Font-Bold="True" Font-Size="Medium" ForeColor="White" Height="138px" OnClick="Button1_Click" Width="102px" BorderColor="#6600FF" BorderWidth="3px" style="margin-left: 3px;" onmouseover="this.style.backgroundColor='#FF0000';" onmouseout="this.style.backgroundColor='#006699';"/>
            </div>
            <div class ="options" runat="server" style ="position:absolute; height:138px;width:117px;left:5px; top:310px">
                <asp:Button ID="CourseReg" runat="server" Text="Registration" BackColor="#006699" BorderStyle="None" Font-Bold="True" Font-Size="Small" ForeColor="White" Height="138px" OnClick="Button2_Click" Width="102px" BorderColor="#6600FF" BorderWidth="3px" style="margin-left: 3px;" onmouseover="this.style.backgroundColor='#FF0000';" onmouseout="this.style.backgroundColor='#006699';" />
            </div>
            <div class ="options" runat="server" style ="position:absolute; height:138px;width:117px;left:5px; top:475px">
                <asp:Button ID="Attend" runat="server" Text="Attendence" BackColor="#006699" BorderStyle="None" Font-Bold="True" Font-Size="Small" ForeColor="White" Height="138px" OnClick="Button3_Click" Width="102px" BorderColor="#6600FF" BorderWidth="3px" style="margin-left: 3px;" onmouseover="this.style.backgroundColor='#FF0000';" onmouseout="this.style.backgroundColor='#006699';" />
            </div>
            <div class ="options" runat="server" style ="position:absolute; height:138px;width:117px;left:5px; top:640px">
                <asp:Button ID="Mark" runat="server" Text="Marks" BackColor="#006699" BorderStyle="None" Font-Bold="True" Font-Size="Small" ForeColor="White" Height="138px" OnClick="Button4_Click" Width="102px" BorderColor="#6600FF" BorderWidth="3px" style="margin-left: 3px;" onmouseover="this.style.backgroundColor='#FF0000';" onmouseout="this.style.backgroundColor='#006699';" />
            </div>
            <div class ="options" runat="server" style ="position:absolute; height:138px;width:117px;left:5px; top:805px">
                <asp:Button ID="Transcript" runat="server" Text="Transcript" BackColor="#006699" BorderStyle="None" Font-Bold="True" Font-Size="Small" ForeColor="White" Height="138px" OnClick="Button5_Click" Width="102px" BorderColor="#6600FF" BorderWidth="3px" style="margin-left: 3px;" onmouseover="this.style.backgroundColor='#FF0000';" onmouseout="this.style.backgroundColor='#006699';" />
            </div>
        </div>
    </form>
</body>
</html>
