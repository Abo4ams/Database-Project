<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminReg.aspx.cs" Inherits="WebApplication1.AdminReg" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             Email<br />
            <asp:TextBox ID="email" runat="server" TextMode ="Email"></asp:TextBox>
            <br />
             Password<br />
            <asp:TextBox ID="password" runat="server" TextMode ="Password" ></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="signup" OnClick="submit" runat="server" Text="Submit" />
        </div>
    </form>
</body>
</html>
