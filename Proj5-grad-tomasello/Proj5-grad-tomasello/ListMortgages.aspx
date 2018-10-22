<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ListMortgages.aspx.cs" Inherits="Proj5_grad_tomasello.ListMortgages" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- github repo link:  https://github.com/TylerTomasello/itmd-563/tree/master/Proj5-grad-tomasello-->
    <h2>List Mortgages</h2>
    <asp:GridView ID="GridView" runat="server" BackColor="#CCFF99">
        <Columns>
            <asp:BoundField HeaderText="Principle"></asp:BoundField>
        </Columns>
    </asp:GridView>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
