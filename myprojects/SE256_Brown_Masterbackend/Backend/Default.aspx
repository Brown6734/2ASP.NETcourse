<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SE256_Brown_Masterbackend.Backend.Default" %>


<asp:Content ID="Content1" ContentPlaceHolderID="BreakingNewsContent" runat="server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        Username: <asp:TextBox ID="txtUName" runat="server" />
        <br />
        <br />
        Password: <asp:TextBox ID="txtPW" runat="server" TextMode="Password" />
        <br />
        <br />
        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" />
        <br />
        <br />
        <asp:Label ID="lblFeedback" runat="server" Text="" />

    </div>

    <br /> <br />
    <br /> <br />

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

</asp:Content>
