<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ExaminerReg.aspx.cs" Inherits="WebApplication1.ExaminerReg" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Thesis Serial Number<br />
            <asp:TextBox ID="thesis" runat="server" ></asp:TextBox>
            <br />
            Defense Date<br />
            <asp:TextBox ID="defense" runat="server" TextMode="DateTime"></asp:TextBox>
            <br />
            Examiner Name<br />
            <asp:TextBox ID="name" runat="server" ></asp:TextBox>
            <br />
            Password<br />
            <asp:TextBox ID="password" runat="server" TextMode ="Password"></asp:TextBox>
            <br />
            National<br />
            <asp:TextBox ID="national" runat="server" ></asp:TextBox>
            <br />
            Field Of Work<br />
            <asp:TextBox ID="field" runat="server" ></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="signup" OnClick="submit" runat="server" Text="Submit" />
        </div>
    </form>
</body>
</html>
