<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SetStore.aspx.cs" Inherits="SE256_Brown_Masterbackend.SetStore" %>
<asp:Content ID="Content1" ContentPlaceHolderID="BreakingNewsContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Products1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Products2" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="MainContent" runat="server">

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

    <div class="search">
        <p>Search field</p>

        <br />

        <p>You can search a store by: &nbsp; Zip Code, City, or State</p>

        <br />

        <p>The valid zip codes are: 
            12345, 67890, 12121, 34653
        </p>

    </div>

    <asp:TextBox ID="storeFind" runat="server" Text="enter your zip code" />

    <asp:RequiredFieldValidator ID="zipCodeValid" runat="server" ControlToValidate="storeFind" ErrorMessage="must not be empty" />
    <br />

    <asp:CompareValidator ID="codeCompare" runat="server" ErrorMessage="not a valid zip code" ControlToValidate="storeFind" Operator="DataTypeCheck" Type="Integer" />

    <asp:TextBox ID="yourStore" runat="server" Text="store" />

    <asp:Button ID="storeSearch" runat="server" Text="Submit Button" OnClick="storeSearch_Click" />
    

</asp:Content>
