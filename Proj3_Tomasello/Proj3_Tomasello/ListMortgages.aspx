<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListMortgages.aspx.cs" Inherits="Proj3_Tomasello.ListMortgages" %>

<%@ Register Src="~/SiteNavigation.ascx" TagPrefix="uc1" TagName="SiteNavigation" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>List Mortgages</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <uc1:SiteNavigation runat="server" id="SiteNavigation" />
            <h2>List Mortgages</h2>
            <asp:GridView ID="GridView" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
