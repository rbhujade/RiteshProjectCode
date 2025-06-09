<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Web_Form_Net_Framework_Project.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Email"></asp:Label>
            <asp:TextBox ID="Email" runat="server"></asp:TextBox>
            <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="Password" runat="server"></asp:TextBox>

            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click"/>

            <asp:Label ID="Label3" runat="server" Text=""></asp:Label>

        </div>
    </form>
</body>
</html>
