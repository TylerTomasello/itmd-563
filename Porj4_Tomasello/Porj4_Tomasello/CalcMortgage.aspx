<%@ Page Title="CalcMortgage" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="CalcMortgage.aspx.cs" Inherits="Porj4_Tomasello.CalcMortgage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
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
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
                <asp:ListItem>4</asp:ListItem>
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
