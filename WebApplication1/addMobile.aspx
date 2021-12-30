<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addMobile.aspx.cs" Inherits="WebApplication1.addMobile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            ID:<br />
            <asp:TextBox ID="id" runat="server" ></asp:TextBox>
              <br />
            <br />
            Phone Number:<br />
            <asp:TextBox ID="mobile" runat="server" TextMode="Phone" ></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="addPhone" OnClick="add" runat="server" Text="Add Phone" />

        </div>
    </form>
</body>
</html>
