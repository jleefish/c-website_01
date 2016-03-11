<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" Trace="true"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Default</title>
</head>
<body style="font-family: Arial">
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Enter your name: "></asp:Label>
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="cmdHello" runat="server" OnClick="cmdHello_Click" Text="Hello" />
        <asp:Label ID="lblHello" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
