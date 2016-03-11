<%@ Page Title="qsControl1" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="qsControl1.aspx.cs" Inherits="qsControl1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="Label1" runat="server" Font-Size="Larger" Text="Pick your favorite color: "></asp:Label>
    <br />
    <br />
    <br />
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/qsControl2.aspx?favColor=red">Red</asp:HyperLink>
    <br />
    <br />
    <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/qsControl2.aspx?favColor=blue">Blue</asp:HyperLink>
    <br />
</asp:Content>

