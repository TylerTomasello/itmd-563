<%@ Page Title="ClearMortgages" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ClearMortgages.aspx.cs" Inherits="Porj4_Tomasello.ClearMortgages" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- github repo link: https://github.com/TylerTomasello/itmd-563/tree/master/Porj4_Tomasello -->
    <h2>Clear Mortgages</h2>
    <asp:Button ID="Clear" runat="server" OnClick="Clear_Click" Text="Clear Mortgages" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
