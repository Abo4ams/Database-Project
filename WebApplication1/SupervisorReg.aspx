<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SupervisorReg.aspx.cs" Inherits="WebApplication1.SupervisorReg" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             First Name<br />
            <asp:TextBox ID="fname" runat="server" ></asp:TextBox>
            <br />
            Last Name<br />
            <asp:TextBox ID="lname" runat="server"></asp:TextBox>
            <br />
            Password<br />
            <asp:TextBox ID="password" runat="server" TextMode ="Password"></asp:TextBox>
            <br />
            Faculty<br />
            <asp:TextBox ID="faculty" runat="server" ></asp:TextBox>
            <br />
            E-mail<br />
            <asp:TextBox ID="email" runat="server" TextMode ="Email"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="signup" OnClick="submit" runat="server" Text="Submit" />
        </div>
    </form>
</body>
</html>
