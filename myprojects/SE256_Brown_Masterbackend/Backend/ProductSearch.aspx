<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductSearch.aspx.cs" Inherits="SE256_Brown_Masterbackend.Backend.ProductSearch" %>
<asp:Content ID="Content1" ContentPlaceHolderID="BreakingNewsContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Products1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Products2" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="MainContent" runat="server">

    <!--dd-->

    <!--seach for products-->

    <h1>Products Search</h1>

    <p>Optional Search Criteria to narrow search results</p>

    <p>
        <!--search criterias: Product Title
            Product Manufacturer-->

        Product Title: <asp:TextBox ID="txtTitle" runat="server" Columns="40" />

        &nbsp;&nbsp;&nbsp;&nbsp;

        Product Manufacturer: <asp:TextBox ID="txtManu" runat="server" Columns="40" />
    </p>

    <br />

    <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />

    <br />
    <br />

    <asp:DataGrid ID="dgResults" runat="server" AutoGenerateColumns="false">
        <Columns>

            <!--data fields:
                ProductName - title
                ProductManu
                ProductPrice
                Available
                ProductDesc
                ManuDate
                QuantOnHand

                table - Products3
                id - Products3_ID
               
                -->
            <asp:BoundColumn DataField="ProductName" HeaderText="Product Name" />
            <asp:BoundColumn DataField="ProductManu" HeaderText="Product Manufacturer" />
            <asp:BoundColumn DataField="ProductPrice" HeaderText="Proudct Price" />
            <asp:BoundColumn DataField="Available" HeaderText="Is product Avaiable?" />
            <asp:BoundColumn DataField="ProductDesc" HeaderText="Product Description" />
            <asp:BoundColumn DataField="ManuDate" HeaderText="Product Manufactured Date" />
            <asp:BoundColumn DataField="QuantOnHand" HeaderText="Product: Quantity On Hand" />
            <asp:HyperLinkColumn Text="Edit" DataNavigateUrlFormatString="~/Backend/Product2.aspx?Product3_ID={0}" DataNavigateUrlField="Products3_ID" />


        </Columns>

    </asp:DataGrid>

    <br /><br />
    <br /><br />

    <h1>Another output option: creating our own output while looping thru records using a repeater and item template</h1>

    <asp:Repeater ID="rptSearch" runat="server">
        <HeaderTemplate>

            <asp:Label ID="lblHeader" runat="server" Text="your results......" />

        </HeaderTemplate>

        <ItemTemplate>

            <!--data fields:
                ProductName - title
                ProductManu
                ProductPrice
                Available
                ProductDesc
                ManuDate
                QuantOnHand

                table - Products3
                id - Products3_ID
               
                -->
            <br />
            <asp:Label ID="lblProductName" runat="server" Text="<%# Eval("ProductName")%>" />
            <asp:Label ID="lblProductManu" runat="server" Text="<%# Eval("ProductManu")%>" />

            <asp:HyperLink ID="HyperLink1" runat="server" Text="Edit" NavigateUrl= "<%# Eval("Products3_ID", "Product2.aspx?Products3_ID={0}")%>" />


        </ItemTemplate>

    </asp:Repeater>

    <br /><br />
    <br /><br />

    <h1>another output option: creating our own output via a method that loops through each record and developing ALL the HTML</h1>

    <asp:Literal ID="litResults" runat="server" Text="" />

</asp:Content>
