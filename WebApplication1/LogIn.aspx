<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="WebApplication1.LogIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Please LogIn:<br />
            <br />
            Email:<br />
            <asp:TextBox ID="email" runat="server" TextMode="Email" ></asp:TextBox>
              <br />
            <br />
            Password:<br />
            <asp:TextBox ID="password" runat="server" TextMode ="Password" ></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="signIn" OnClick="logIn" runat="server" Text="Log In" />
              <br />
              <br /> 
             <asp:HyperLink ID="HyperLink1" runat="server" Text="Haven't registered yet?" NavigateUrl="registeration.aspx"></asp:HyperLink>
             <br />
            <br />
             <asp:HyperLink ID="HyperLink2" runat="server" Text="Want to add your phone number?" NavigateUrl="addMobile.aspx"></asp:HyperLink>
        </div>
    </form>
</body>
</html>
