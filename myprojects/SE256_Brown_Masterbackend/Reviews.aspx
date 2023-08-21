<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Reviews.aspx.cs" Inherits="SE256_Brown_Masterbackend.Reviews" %>
<asp:Content ID="Content1" ContentPlaceHolderID="BreakingNewsContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Products1" runat="server">
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="Products2" runat="server">

    <!--reviews page-->

    <!--commment-->

    <link href="Content/Products.css" rel="stylesheet" />

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

    <!--comment-->

    <!--what will this section be used for?-->

    <!--reviews of the product(s)-->

    <!--comment-->

    

    <div class="review1">

        <p class="review1"></p>

        <p class="review1">Product Review: </p>
        
        <p class="review1">Number of stars: 1 - 5</p>

        <p class="review1">Customer name</p>

        <p class="review1">When the review was written</p>

        <p class="review1">Content of the review</p>

    </div>

    <br />
    <br />

    <div class="review2">

        <p class="review2"></p>

        <p class="review2">Product Review: </p>
        
        <p class="review2">Number of stars: 1 - 5</p>

        <p class="review2">Customer name</p>

        <p class="review2">When the review was written</p>

        <p class="review2">Content of the review</p>

    </div>

    <br />
    <br />

    <div class="review3">

        <p class="review3"></p>

        <p class="review3">Product Review: </p>
        
        <p class="review3">Number of stars: 1 - 5</p>

        <p class="review3">Customer name</p>

        <p class="review3">When the review was written</p>

        <p class="review3">Content of the review</p>

    </div>

</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="MainContent" runat="server">
</asp:Content>
