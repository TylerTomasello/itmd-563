<%@ Page Title="CalcMortgage" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="CalcMortgage.aspx.cs" Inherits="Porj4_Tomasello.CalcMortgage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- github repo link: https://github.com/TylerTomasello/itmd-563/tree/master/Porj4_Tomasello -->
    <h2>Calculate Mortgage Monthly Payment</h2>
        <div>
            Please enter principle amount
            <asp:TextBox ID="PrincipleAmount" runat="server"></asp:TextBox>
            &nbsp
        </div>
        <br />

        <div>
            Please enter the loan duration in years
            <asp:RadioButtonList ID="Duration" AutoPostBack="true" OnSelectedIndexChanged="Duration_SelectedIndexChanged" runat="server">
                <asp:ListItem Value="15">15 Years</asp:ListItem>
                <asp:ListItem Value="30">30 Years</asp:ListItem>
                <asp:ListItem>Other</asp:ListItem>
            </asp:RadioButtonList>
            <asp:TextBox ID="OtherYears" runat="server"></asp:TextBox>
        </div>
        <br />

        <div>
            Please select the interest rate
            <asp:DropDownList ID="DropDownList1" AutoPostBack="true" runat="server">
                <asp:ListItem>.25</asp:ListItem>
                <asp:ListItem>.50</asp:ListItem>
                <asp:ListItem>.75</asp:ListItem>
                <asp:ListItem>1.00</asp:ListItem>
                <asp:ListItem>1.25</asp:ListItem>
                <asp:ListItem>1.50</asp:ListItem>
                <asp:ListItem>1.75</asp:ListItem>
                <asp:ListItem>2.00</asp:ListItem>
                <asp:ListItem>2.25</asp:ListItem>
                <asp:ListItem>2.50</asp:ListItem>
                <asp:ListItem>2.75</asp:ListItem>
                <asp:ListItem>3.00</asp:ListItem>
                <asp:ListItem>3.25</asp:ListItem>
                <asp:ListItem>3.50</asp:ListItem>
                <asp:ListItem>3.75</asp:ListItem>
                <asp:ListItem>4.00</asp:ListItem>
                <asp:ListItem>4.25</asp:ListItem>
                <asp:ListItem>4.50</asp:ListItem>
                <asp:ListItem>4.75</asp:ListItem>
                <asp:ListItem>5.00</asp:ListItem>
                <asp:ListItem>5.25</asp:ListItem>
                <asp:ListItem>5.50</asp:ListItem>
                <asp:ListItem>5.75</asp:ListItem>
                <asp:ListItem>6.00</asp:ListItem>
                <asp:ListItem>6.25</asp:ListItem>
                <asp:ListItem>6.50</asp:ListItem>
                <asp:ListItem>6.75</asp:ListItem>
                <asp:ListItem>7.00</asp:ListItem>
                <asp:ListItem>7.25</asp:ListItem>
                <asp:ListItem>7.50</asp:ListItem>
                <asp:ListItem>7.75</asp:ListItem>
                <asp:ListItem>8.00</asp:ListItem>
                <asp:ListItem>8.25</asp:ListItem>
                <asp:ListItem>8.50</asp:ListItem>
                <asp:ListItem>8.75</asp:ListItem>
                <asp:ListItem>9.00</asp:ListItem>
                <asp:ListItem>9.25</asp:ListItem>
                <asp:ListItem>9.50</asp:ListItem>
                <asp:ListItem>9.75</asp:ListItem>
                <asp:ListItem>10.00</asp:ListItem>
            </asp:DropDownList>
        </div>
        <br />

        <div>
            <asp:Button ID="Compute" runat="server" OnClick="Compute_Click" Text="Monthly Payment" />
        </div>
        <br />

        <asp:Label ID="Result" runat="server"></asp:Label>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
