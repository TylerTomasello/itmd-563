<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ClearMortgages.aspx.cs" Inherits="Proj3_Tomasello.ClearMortgages" %>

<%@ Register Src="~/SiteNavigation.ascx" TagPrefix="uc1" TagName="SiteNavigation" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Clear Mortgages</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <uc1:SiteNavigation runat="server" id="SiteNavigation" />
            <h2>Clear Mortgages</h2>
        </div>
        <asp:Button ID="Clear" runat="server" OnClick="Clear_Click" Text="Clear Mortgages" />
    </form>
</body>
</html>
