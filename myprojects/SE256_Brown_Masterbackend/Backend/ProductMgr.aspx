<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductMgr.aspx.cs" Inherits="SE256_Brown_Masterbackend.Backend.ProductMgr" %>
<asp:Content ID="Content1" ContentPlaceHolderID="BreakingNewsContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Products1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Products2" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Product Search</h1>

    <p>Optional search criteria to narrow down search results</p>

    <!--fields for Products3 table-->
    <!--Products3_ID - int-->
    <!--ProductName-->
    <!--ProductManu-->
    <!--ProductPrice-->
    <!--Available-->
    <!--ProductDesc-->
    <!--ManuDate-->
    <!--QuantOnHand-->

    <p>
        Product Name: <asp:TextBox ID="txtName" runat="server" Columns="30" />
        &nbsp;&nbsp;&nbsp;&nbsp;

        Product Manufacturer: <asp:TextBox ID="txtManu" runat="server" Columns="30" />
    </p>

    <br />

    <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />

    <br />
    <br />

    <asp:DataGrid ID="dgResults" runat="server" AutoGenerateColumns="false">
        <Columns>
            
            

            <asp:BoundColumn DataField="ProductName" HeaderText="Product Name" />
            <asp:BoundColumn DataField="ProductManu" HeaderText="Product Manu" />
           
            <asp:HyperLinkColumn Text="Edit" DataNavigateUrlFormatString="~/Backend/Product2.aspx?Products3_ID={0}" DataNavigateUrlField="Products3_ID" />


        </Columns>

    </asp:DataGrid>

    <br /> <br />
    <br /> <br />

    <h1>Another output option. creating our own output while looping thru records using a repeater and item template</h1>

    <asp:Repeater ID="rptSearch" runat="server">
        <HeaderTemplate>
            <asp:Label ID="lblHeader" runat="server" Text="your results...." />
        </HeaderTemplate>

        <ItemTemplate>
            <br />
            <asp:Label ID="lblPName" runat="server" Text='<%# Eval("ProductName")%>' />
            <asp:Label ID="lblManu" runat="server" Text='<%# Eval("ProductManu")%>' />
            <asp:Label ID="lblPrice" runat="server" Text='<%# Eval("ProductPrice")%>' />
            <asp:HyperLink ID="HyperLinkProducts" runat="server" Text="Edit" NavigateUrl='<%# Eval("Products3_ID", "Product2.aspx?Products3_ID={0}")%>' />
        </ItemTemplate>

    </asp:Repeater>

    <br /><br />
    <br /><br />

    <h1>Another output option. creating our own output via a method that loops through each records and developing all the html</h1>

    <asp:Literal ID="litResults" runat="server" Text="" />

</asp:Content>
