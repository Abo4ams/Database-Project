<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registeration.aspx.cs" Inherits="WebApplication1.register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Please Choose Your Type:<br />
            <br />
            <asp:DropDownList ID="Type" runat="server" >
                <asp:ListItem Text="GUCian Student" Value="0"></asp:ListItem>
                <asp:ListItem Text="NonGUCian Student" Value="1"></asp:ListItem>
                <asp:ListItem Text="Admin" Value="2"></asp:ListItem>
                <asp:ListItem Text="Supervisor" Value="3"></asp:ListItem>
                <asp:ListItem Text="Examiner" Value="4"></asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="registration" OnClick="reg" runat="server" Text="Register" />
           
            <br />
        </div>
    </form>
</body>
</html>
