﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SiteNavigation.ascx.cs" Inherits="Proj3_Tomasello.SiteNavigation" %>
<h1>Mortgage Calculator</h1>
<hr />
<asp:Menu ID="Menu1" Orientation="Horizontal" runat="server" ForeColor="Black" BackColor="#FFFF99">
    <Items>
        <asp:MenuItem NavigateUrl="~/CalcMortgage.aspx" Text="Calc Mortgage" Value="CalcMortgage"></asp:MenuItem>
        <asp:MenuItem NavigateUrl="~/ListMortgages.aspx" Text="List Mortgages" Value="ListMortgages"></asp:MenuItem>
        <asp:MenuItem NavigateUrl="~/ClearMortgages.aspx" Text="Clear Mortgages" Value="ClearMortgages"></asp:MenuItem>
    </Items>
</asp:Menu>
<hr />
