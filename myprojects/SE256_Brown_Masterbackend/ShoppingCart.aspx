<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ShoppingCart.aspx.cs" Inherits="SE256_Brown_Masterbackend.ShoppingCart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="BreakingNewsContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Products1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Products2" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="MainContent" runat="server">

    <link href="Content/HomePage.css" rel="stylesheet" />


    <header>
        <asp:TreeView ID="pageLinks" runat="server">
            <Nodes>
                <asp:TreeNode Text="Other Page Links">
                    <asp:TreeNode Text="About Page" NavigateUrl="~/About.aspx" />
                    <asp:TreeNode Text="Contact Page" NavigateUrl ="~/Contact.aspx" />
                    <asp:TreeNode Text="Default Page" NavigateUrl ="~/Default.aspx" />
                    <asp:TreeNode Text="Help Page" NavigateUrl="~/helpPage.aspx" />
                    <asp:TreeNode Text="Ink Toners Page" NavigateUrl="~/InkToners.aspx" />
                    <asp:TreeNode Text="Reviews Page" NavigateUrl="~/Reviews.aspx" />
                    <asp:TreeNode Text="Set Store Page" NavigateUrl="~/SetStore.aspx" />
                    <asp:TreeNode Text="Shopping Cart Page" NavigateUrl="~/ShoppingCart.aspx" />
                    <asp:TreeNode Text="test page" NavigateUrl="~/testPage.aspx" />
                    <asp:TreeNode Text="backend" NavigateUrl ="~/Backend/Default.aspx" />
                </asp:TreeNode>
            </Nodes>
        </asp:TreeView>
    </header>


    <h1>Shopping Cart</h1>

    <p>How many items in [a] person's cart</p>

    <p>Tell them how many items there are in their cart</p>

    <p>Show them the items</p>

    <p>🛒</p>

    <asp:Label ID="itemNum" Text="whats the amount?" runat="server" />

    <p>Item #1</p>

    <p>Item Image (#1)</p>

    <br />

    <asp:Label ID="itemNum2" Text="whats the amount?" runat="server" />

    <br />

    <asp:Button ID="updateCart" Text="Update Cart" runat="server" OnClick="updateCart_Click" />
    

</asp:Content>
