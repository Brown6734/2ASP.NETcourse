<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="SE256_Brown_Masterbackend.About" %>

<%--dd
<asp:Content ID="Content1" ContentPlaceHolderID="BreakingNewsContent" runat="server">
    <div>

    </div>
</asp:Content>
--%>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
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
                </asp:TreeNode>
            </Nodes>
        </asp:TreeView>


    </header>
    
    
    <h2><%: Title %>.</h2>
    <h3>This company sells products. We sell all kinds of products. We are located the United States. Our company has been in business since 2015</h3>
    <p>We ship to the United States and Canada. We have a 60 day return policy.</p>
</asp:Content>
