<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Faculty.aspx.cs" Inherits="Faculty" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div runat ="server" style ="position:absolute; top: 38px; left: 554px;">
            <asp:Image ID="Image1" runat="server" ImageUrl="~/flex-logo-blue.png" />
        </div>
         <div runat ="server" style ="position:absolute; top: 174px; left: 126px; height: 810px; width: 1204px;background:#242449;display:flex">
        </div>
         <div runat ="server" style ="position:absolute; top: 232px; left: 579px;">
            <asp:Label ID="Label1" runat="server" Text="Faculty Controls" Font-Bold="True" Font-Size="XX-Large" ForeColor="White" Font-Names="Arial Black"></asp:Label>
        </div>
        <div runat="server" style="position:absolute; top: 363px; left: 193px;">
            <asp:Button ID="Attend" runat="server" Text="Set Attendence" BackColor="#6699FF" BorderWidth="0px" Font-Bold="True" Font-Names="Bahnschrift" Font-Size="Medium" Height="140px" Width="201px" onmouseover="this.style.backgroundColor='#FFFF00';" onmouseout="this.style.backgroundColor='#6699FF';" ForeColor="White" OnClick="Courses_Click" />
        </div>
        <div runat="server" style="position:absolute; top: 364px; left: 623px;">
            <asp:Button ID="StdSections" runat="server" Text="Evaluation Report" BackColor="#6699FF" BorderWidth="0px" Font-Bold="True" Font-Names="Bahnschrift" Font-Size="Medium" Height="140px" Width="201px" onmouseover="this.style.backgroundColor='#FFFF00';" onmouseout="this.style.backgroundColor='#6699FF';" ForeColor="White" OnClick="StdSections_Click" />
        </div>
        <div runat="server" style="position:absolute; top: 363px; left: 1028px;">
            <asp:Button ID="CourseAlloc" runat="server" Text="Attendance Report" BackColor="#6699FF" BorderWidth="0px" Font-Bold="True" Font-Names="Bahnschrift" Font-Size="Medium" Height="140px" Width="201px" onmouseover="this.style.backgroundColor='#FFFF00';" onmouseout="this.style.backgroundColor='#6699FF';" ForeColor="White" OnClick="CourseAlloc_Click" />
        </div>
        <div runat="server" style="position:absolute; top: 599px; left: 193px;">
            <asp:Button ID="ADcourse" runat="server" Text="Option4" BackColor="#6699FF" BorderWidth="0px" Font-Bold="True" Font-Names="Bahnschrift" Font-Size="Medium" Height="140px" Width="201px" onmouseover="this.style.backgroundColor='#FFFF00';" onmouseout="this.style.backgroundColor='#6699FF';" ForeColor="White" OnClick="ADcourse_Click" />
        </div>
        <div runat="server" style="position:absolute; top: 601px; left: 626px;">
            <asp:Button ID="Button2" runat="server" Text="Option5" BackColor="#6699FF" BorderWidth="0px" Font-Bold="True" Font-Names="Bahnschrift" Font-Size="Medium" Height="140px" Width="201px" onmouseover="this.style.backgroundColor='#FFFF00';" onmouseout="this.style.backgroundColor='#6699FF';" ForeColor="White" OnClick="Button2_Click" />
        </div>
    </form>
</body>
</html>
