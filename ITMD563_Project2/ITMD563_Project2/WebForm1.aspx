<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ITMD563_Project2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <!-- link to github page https://github.com/TylerTomasello/itmd-563 -->
    <form id="form1" runat="server">
        <div>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString='<%$ ConnectionStrings:NorthwindConnectionString %>' SelectCommand="SELECT * FROM [Products]" ConflictDetection="CompareAllValues" DeleteCommand="DELETE FROM [Products] WHERE [ProductID] = @original_ProductID AND [ProductName] = @original_ProductName AND (([SupplierID] = @original_SupplierID) OR ([SupplierID] IS NULL AND @original_SupplierID IS NULL)) AND (([CategoryID] = @original_CategoryID) OR ([CategoryID] IS NULL AND @original_CategoryID IS NULL)) AND (([QuantityPerUnit] = @original_QuantityPerUnit) OR ([QuantityPerUnit] IS NULL AND @original_QuantityPerUnit IS NULL)) AND (([UnitPrice] = @original_UnitPrice) OR ([UnitPrice] IS NULL AND @original_UnitPrice IS NULL)) AND (([UnitsInStock] = @original_UnitsInStock) OR ([UnitsInStock] IS NULL AND @original_UnitsInStock IS NULL)) AND (([UnitsOnOrder] = @original_UnitsOnOrder) OR ([UnitsOnOrder] IS NULL AND @original_UnitsOnOrder IS NULL)) AND (([ReorderLevel] = @original_ReorderLevel) OR ([ReorderLevel] IS NULL AND @original_ReorderLevel IS NULL)) AND [Discontinued] = @original_Discontinued" InsertCommand="INSERT INTO [Products] ([ProductName], [SupplierID], [CategoryID], [QuantityPerUnit], [UnitPrice], [UnitsInStock], [UnitsOnOrder], [ReorderLevel], [Discontinued]) VALUES (@ProductName, @SupplierID, @CategoryID, @QuantityPerUnit, @UnitPrice, @UnitsInStock, @UnitsOnOrder, @ReorderLevel, @Discontinued)" OldValuesParameterFormatString="original_{0}" UpdateCommand="UPDATE [Products] SET [ProductName] = @ProductName, [SupplierID] = @SupplierID, [CategoryID] = @CategoryID, [QuantityPerUnit] = @QuantityPerUnit, [UnitPrice] = @UnitPrice, [UnitsInStock] = @UnitsInStock, [UnitsOnOrder] = @UnitsOnOrder, [ReorderLevel] = @ReorderLevel, [Discontinued] = @Discontinued WHERE [ProductID] = @original_ProductID AND [ProductName] = @original_ProductName AND (([SupplierID] = @original_SupplierID) OR ([SupplierID] IS NULL AND @original_SupplierID IS NULL)) AND (([CategoryID] = @original_CategoryID) OR ([CategoryID] IS NULL AND @original_CategoryID IS NULL)) AND (([QuantityPerUnit] = @original_QuantityPerUnit) OR ([QuantityPerUnit] IS NULL AND @original_QuantityPerUnit IS NULL)) AND (([UnitPrice] = @original_UnitPrice) OR ([UnitPrice] IS NULL AND @original_UnitPrice IS NULL)) AND (([UnitsInStock] = @original_UnitsInStock) OR ([UnitsInStock] IS NULL AND @original_UnitsInStock IS NULL)) AND (([UnitsOnOrder] = @original_UnitsOnOrder) OR ([UnitsOnOrder] IS NULL AND @original_UnitsOnOrder IS NULL)) AND (([ReorderLevel] = @original_ReorderLevel) OR ([ReorderLevel] IS NULL AND @original_ReorderLevel IS NULL)) AND [Discontinued] = @original_Discontinued">
                <DeleteParameters>
                    <asp:Parameter Name="original_ProductID" Type="Int32"></asp:Parameter>
                    <asp:Parameter Name="original_ProductName" Type="String"></asp:Parameter>
                    <asp:Parameter Name="original_SupplierID" Type="Int32"></asp:Parameter>
                    <asp:Parameter Name="original_CategoryID" Type="Int32"></asp:Parameter>
                    <asp:Parameter Name="original_QuantityPerUnit" Type="String"></asp:Parameter>
                    <asp:Parameter Name="original_UnitPrice" Type="Decimal"></asp:Parameter>
                    <asp:Parameter Name="original_UnitsInStock" Type="Int16"></asp:Parameter>
                    <asp:Parameter Name="original_UnitsOnOrder" Type="Int16"></asp:Parameter>
                    <asp:Parameter Name="original_ReorderLevel" Type="Int16"></asp:Parameter>
                    <asp:Parameter Name="original_Discontinued" Type="Boolean"></asp:Parameter>
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="ProductName" Type="String"></asp:Parameter>
                    <asp:Parameter Name="SupplierID" Type="Int32"></asp:Parameter>
                    <asp:Parameter Name="CategoryID" Type="Int32"></asp:Parameter>
                    <asp:Parameter Name="QuantityPerUnit" Type="String"></asp:Parameter>
                    <asp:Parameter Name="UnitPrice" Type="Decimal"></asp:Parameter>
                    <asp:Parameter Name="UnitsInStock" Type="Int16"></asp:Parameter>
                    <asp:Parameter Name="UnitsOnOrder" Type="Int16"></asp:Parameter>
                    <asp:Parameter Name="ReorderLevel" Type="Int16"></asp:Parameter>
                    <asp:Parameter Name="Discontinued" Type="Boolean"></asp:Parameter>
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="ProductName" Type="String"></asp:Parameter>
                    <asp:Parameter Name="SupplierID" Type="Int32"></asp:Parameter>
                    <asp:Parameter Name="CategoryID" Type="Int32"></asp:Parameter>
                    <asp:Parameter Name="QuantityPerUnit" Type="String"></asp:Parameter>
                    <asp:Parameter Name="UnitPrice" Type="Decimal"></asp:Parameter>
                    <asp:Parameter Name="UnitsInStock" Type="Int16"></asp:Parameter>
                    <asp:Parameter Name="UnitsOnOrder" Type="Int16"></asp:Parameter>
                    <asp:Parameter Name="ReorderLevel" Type="Int16"></asp:Parameter>
                    <asp:Parameter Name="Discontinued" Type="Boolean"></asp:Parameter>
                    <asp:Parameter Name="original_ProductID" Type="Int32"></asp:Parameter>
                    <asp:Parameter Name="original_ProductName" Type="String"></asp:Parameter>
                    <asp:Parameter Name="original_SupplierID" Type="Int32"></asp:Parameter>
                    <asp:Parameter Name="original_CategoryID" Type="Int32"></asp:Parameter>
                    <asp:Parameter Name="original_QuantityPerUnit" Type="String"></asp:Parameter>
                    <asp:Parameter Name="original_UnitPrice" Type="Decimal"></asp:Parameter>
                    <asp:Parameter Name="original_UnitsInStock" Type="Int16"></asp:Parameter>
                    <asp:Parameter Name="original_UnitsOnOrder" Type="Int16"></asp:Parameter>
                    <asp:Parameter Name="original_ReorderLevel" Type="Int16"></asp:Parameter>
                    <asp:Parameter Name="original_Discontinued" Type="Boolean"></asp:Parameter>
                </UpdateParameters>
            </asp:SqlDataSource>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="ProductID" DataSourceID="SqlDataSource1" AllowSorting="True" CellPadding="4" ForeColor="#333333" GridLines="None" AllowPaging="True" PageSize="20">
                <AlternatingRowStyle BackColor="White"></AlternatingRowStyle>
                <Columns>
                    <asp:CommandField ShowEditButton="True" ShowDeleteButton="True"></asp:CommandField>
                    <asp:BoundField DataField="ProductID" HeaderText="ProductID" ReadOnly="True" InsertVisible="False" SortExpression="ProductID"></asp:BoundField>
                    <asp:BoundField DataField="ProductName" HeaderText="ProductName" SortExpression="ProductName"></asp:BoundField>
                    <asp:BoundField DataField="SupplierID" HeaderText="SupplierID" SortExpression="SupplierID"></asp:BoundField>
                    <asp:BoundField DataField="CategoryID" HeaderText="CategoryID" SortExpression="CategoryID"></asp:BoundField>
                    <asp:BoundField DataField="QuantityPerUnit" HeaderText="QuantityPerUnit" SortExpression="QuantityPerUnit"></asp:BoundField>
                    <asp:BoundField DataField="UnitPrice" HeaderText="UnitPrice" SortExpression="UnitPrice"></asp:BoundField>
                    <asp:BoundField DataField="UnitsInStock" HeaderText="UnitsInStock" SortExpression="UnitsInStock"></asp:BoundField>
                    <asp:BoundField DataField="UnitsOnOrder" HeaderText="UnitsOnOrder" SortExpression="UnitsOnOrder"></asp:BoundField>
                    <asp:BoundField DataField="ReorderLevel" HeaderText="ReorderLevel" SortExpression="ReorderLevel"></asp:BoundField>
                    <asp:CheckBoxField DataField="Discontinued" HeaderText="Discontinued" SortExpression="Discontinued"></asp:CheckBoxField>
                </Columns>
                <EditRowStyle BackColor="#2461BF"></EditRowStyle>

                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White"></FooterStyle>

                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White"></HeaderStyle>

                <PagerStyle HorizontalAlign="Center" BackColor="#2461BF" ForeColor="White"></PagerStyle>

                <RowStyle BackColor="#EFF3FB"></RowStyle>

                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333"></SelectedRowStyle>

                <SortedAscendingCellStyle BackColor="#F5F7FB"></SortedAscendingCellStyle>

                <SortedAscendingHeaderStyle BackColor="#6D95E1"></SortedAscendingHeaderStyle>

                <SortedDescendingCellStyle BackColor="#E9EBEF"></SortedDescendingCellStyle>

                <SortedDescendingHeaderStyle BackColor="#4870BE"></SortedDescendingHeaderStyle>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
