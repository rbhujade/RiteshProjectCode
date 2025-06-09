<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Student.aspx.cs" Inherits="Web_Form_Net_Framework_Project.Student" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label runat="server" >Name</asp:Label>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
            <asp:FileUpload ID="FileUpload1" runat="server" />
            <asp:FileUpload ID="FileUpload2" runat="server" AllowMultiple ="true"/>
        </div>
        <div>
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click"/>
        </div>
    </form>
</body>
</html>
