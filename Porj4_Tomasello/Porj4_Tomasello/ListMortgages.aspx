<%@ Page Title="ListMortgages" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ListMortgages.aspx.cs" Inherits="Porj4_Tomasello.ListMortgages" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- github repo link: https://github.com/TylerTomasello/itmd-563/tree/master/Porj4_Tomasello -->
    <h2>List Mortgages</h2>
    <asp:GridView ID="GridView" runat="server"></asp:GridView>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
