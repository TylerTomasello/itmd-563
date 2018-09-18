<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ITMD563_Project1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Four Function Calculator</title>
</head>
<body>
    <form id="form1" method="get" runat="server">
        <div>
            <h1>Four Function Calculator</h1>
            <asp:Label ID="Label1" runat="server" Text="Operand 1"></asp:Label>
            <asp:TextBox ID="Op1" runat="server"></asp:TextBox>
            <br />

            <asp:Label ID="Label2" runat="server" Text="Operand 2"></asp:Label>
            <asp:TextBox ID="Op2" runat="server"></asp:TextBox>
            <hr />

            <p><b>Choose Calculation</b></p>
            <asp:Button ID="BtnAdd" runat="server" Onclick="BtnAdd_Click1" Text="+" />
            <asp:Button ID="BtnSub" runat="server" Onclick="BtnSub_Click" Text="-" />
            <asp:Button ID="BtnMult" runat="server" OnClick="BtnMult_Click" Text="*" />
            <asp:Button ID="BtnDivide" runat="server" OnClick="BtnDivide_Click" Text="/" />

            <hr />
            <asp:Label ID="Finish" runat="server" Text="Result is"></asp:Label>
            <asp:Label ID="Result" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
