<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
        <asp:Image ID="Image1" runat="server" ImageUrl="~/flex-logo-blue.png" style="z-index: 1; left: 20px; top: 7px; position: relative; height: 187px; width: 505px;" />
        </p>
        <div style ="position:relative; top: 0px; left: 0px; width: 499px; height: 362px;" runat="server">
        <p style="position: relative; top: 312px; left: 384px; width: 72px; height: 30px;">
            <asp:Button ID="Button1" runat="server" Text="Login" Font-Bold="True" Font-Italic="True" OnClick="Button1_Click" onmouseover="this.style.backgroundColor='#00FF00';" onmouseout="this.style.backgroundColor='#FFFFFF';" />
        </p>
        <p style="position: relative; top: 71px; left: 255px; width: 127px;">
            <asp:Label ID="Label1" runat="server" Text="Log In" Font-Bold="True" Font-Names="Arial Black" Font-Overline="True" Font-Size="20pt" Font-Underline="True"></asp:Label>
        </p>
        <p style="position: relative; top: 93px; left: 87px; width: 128px; height: 33px;">
            &nbsp
            <asp:Label ID="UserLabel" runat="server" Text="Username:" Font-Bold="True" Font-Names="Arial Black" Font-Size="20px"></asp:Label>
        </p>
        <p style="position: relative; top: 87px; left: 96px; width: 128px; height: 33px">
            <asp:Label ID="PassLabel" runat="server" Font-Bold="True" Font-Names="Arial Black" Text="Password:" Font-Size="20px"></asp:Label>
        </p>
        <p style="position: relative; top: -8px; left: 228px; width: 163px; height: 29px; margin-top:20px;">
            <asp:TextBox ID="UserText" runat="server" Height="20px" Width="163px" OnTextChanged="UserText_TextChanged"></asp:TextBox>
        </p>
        <p style="position: relative; top: -11px; left: 229px; width: 163px; margin-top: 20px;">
            <input id="PassText" runat="server" type="password" />
        </p>
        <p style="position: relative; top: 27px; left: 74px; width: 160px;">
            <asp:CheckBox ID="RememberBox" runat="server" Text="Remember me?" Font-Bold="False" Font-Italic="True" Font-Names="Arial" Font-Size="12px" />
        </p>
        </div>
        <div style ="position:relative; top: -626px; left: 748px; width: 636px; height: 761px; margin-right: 0px;" runat="server">
            <asp:Image ID="Image2" runat="server" Height="783px" ImageUrl="~/LibraryPhoto.jpeg" Width="755px" />
        </div>
    </form>
</body>
</html>
