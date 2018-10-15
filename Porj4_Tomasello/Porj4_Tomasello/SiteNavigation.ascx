<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SiteNavigation.ascx.cs" Inherits="Porj4_Tomasello.SiteNavigation" %>
<!-- github repo link: https://github.com/TylerTomasello/itmd-563/tree/master/Porj4_Tomasello -->
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
