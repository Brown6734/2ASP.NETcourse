<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="helpPage.aspx.cs" Inherits="SE256_Brown_Masterbackend.helpPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="BreakingNewsContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Products1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Products2" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="MainContent" runat="server">

    <link href="Content/HomePage.css" rel="stylesheet" />


    <header class="headRed"><!--beginning of header; give it a class of headRed  &nbsp;-->
        
        <!--logo--> 
        <asp:Button ID="logoButton" runat="server" Text="logo" OnClick="logoButton_Click" CssClass="logoImage"/>

        <!--<asp:Image ID="Image1" runat="server" ImageUrl="~/Imgs/logotry1.png" Height="200px" Width="200px" />-->

        <p>I am currently working on fixing my header/improving the header.</p>



        

        <!--shop dropdown 
        <asp:DropDownList ID="shopdrop" runat="server" >
            <asp:ListItem Text="Shop"></asp:ListItem>
            <asp:ListItem>Option 1</asp:ListItem>
            <asp:ListItem>Option 2</asp:ListItem>
        </asp:DropDownList>-->

        
        
        
        
        <asp:TreeView ID="TreeView2" runat="server" CssClass="shopTree" Width="120px">
            <Nodes>
                <asp:TreeNode Text="Shop" Value="Shop" Expanded="False">
                    <asp:TreeNode Text="Option 1" Value="Option 1"></asp:TreeNode>
                    <asp:TreeNode Text="Option 2" Value="Option 2"></asp:TreeNode>
                </asp:TreeNode>
            </Nodes>
        </asp:TreeView>

        <p class="spaces">&nbsp; &nbsp; &nbsp; &nbsp; </p>

        
        

        <!--deals dropdown
        <asp:DropDownList ID="DropDeals" runat="server" >
            <asp:ListItem>Deals</asp:ListItem>
            <asp:ListItem>Option 1</asp:ListItem>
            <asp:ListItem>Option 2</asp:ListItem>
        </asp:DropDownList> -->

        

        <asp:TreeView ID="TreeView3" runat="server" CssClass="DealsTree" Width="120px">
            <Nodes>
                <asp:TreeNode Text="Deals" Value="Deals" Expanded="False">
                    <asp:TreeNode Text="Option 1" Value="Option 1"></asp:TreeNode>
                    <asp:TreeNode Text="Option 2" Value="Option 2"></asp:TreeNode>
                </asp:TreeNode>
            </Nodes>
        </asp:TreeView>

        <asp:TextBox ID="textSearch" runat="server"  Text="Search" CssClass="SearchBox" />
        

        <!--services dropdown-->

        <p class="spaces2"> &nbsp;</p>
        

        <asp:TreeView ID="TreeView4" runat="server" CssClass="ServicesTree">
            <Nodes>
                <asp:TreeNode Expanded="False" Text="Services" Value="Services">
                    <asp:TreeNode Text="Option 1" Value="Option 1"></asp:TreeNode>
                    <asp:TreeNode Text="Option 2" Value="Option 2"></asp:TreeNode>
                </asp:TreeNode>
            </Nodes>
        </asp:TreeView>

        


        
        <!--search textbox?--> 

        
        
        <!--navigation part it will be a drop down list-->
        <!--can do Selected="somethingevent??"-->
        

        <asp:TreeView ID="TreeView5" runat="server" CssClass="NavTree">
            <Nodes>
                <asp:TreeNode Expanded="False" Text="Nav (icon)" Value="Nav (icon)">
                    <asp:TreeNode Text="Option 1" Value="Option 1"></asp:TreeNode>
                    <asp:TreeNode Text="Option 2" Value="Option 2"></asp:TreeNode>
                </asp:TreeNode>
            </Nodes>
        </asp:TreeView>

        

        <!--can I dodSdeledctedddevent happdens brings user to another page in website/site--->

        <!--help icon/question mark - button-->

        <asp:Button ID="helpButton" runat="server" Text="?" CssClass="helpIcon" OnClick="helpButton_Click"/>

        

        <!--sign in button/login in; brings user to login page (mabye backend one for now)-->

        <asp:Button ID="loginButton" runat="server" Text="Sign In" OnClick="loginButton_Click"/>

        

        <!--shopping cart button-->

        <asp:Button ID="shoppingCartButton" runat="server" Text="🛒" OnClick="shoppingCartButton_Click"/>


      

        <br />

        <!--still in header-->
        <!--for business dropdown-->
        

        &nbsp; &nbsp; &nbsp; &nbsp;

        <asp:TreeView ID="TreeView6" runat="server" CssClass="BusTree">
            <Nodes>
                <asp:TreeNode Expanded="False" Text="For Business" Value="For Business">
                    <asp:TreeNode Text="Option 1" Value="Option 1"></asp:TreeNode>
                    <asp:TreeNode Text="Option 2" Value="Option 2"></asp:TreeNode>
                </asp:TreeNode>
            </Nodes>
        </asp:TreeView>

        <!--get it today--> 

        <p class="space4">&nbsp;</p>

        
        <asp:TreeView ID="TreeView7" runat="server" CssClass="TodayTree">
            <Nodes>
                <asp:TreeNode Expanded="False" Text="Get It Today" Value="Get It Today">
                    <asp:TreeNode Text="Option 1" Value="Option 1"></asp:TreeNode>
                    <asp:TreeNode Text="Option 2" Value="Option 2"></asp:TreeNode>
                </asp:TreeNode>
            </Nodes>
        </asp:TreeView>

        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;

        <!--ink and toner menu/option; bring user to another page-->
        <asp:Button ID="Button1" runat="server" Text="Ink and Toner" OnClick="Button1_Click"/>



        <!--space space space-->
        &nbsp; &nbsp; &nbsp; &nbsp; 

        <!--buy it again-->
        <asp:Button ID="Button2" runat="server" Text="Buy it Again" />

        &nbsp; &nbsp; &nbsp; &nbsp;

        <!--ideas -->
        

        &nbsp; &nbsp; &nbsp; &nbsp;

        <!--orders dropdown-->

        <asp:TreeView ID="TreeView8" runat="server" CssClass="OrdersTree">
            <Nodes>
                <asp:TreeNode Expanded="False" Text="Orders" Value="Orders">
                    <asp:TreeNode Text="Option 1" Value="Option 1"></asp:TreeNode>
                    <asp:TreeNode Text="Option 2" Value="Option 2"></asp:TreeNode>
                </asp:TreeNode>
            </Nodes>
        </asp:TreeView>

        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;

        <!--set your store-->
        <asp:Button ID="SetStoreBtn" runat="server" Text="Set Your Store" OnClick="SetStoreBtn_Click"/>


    </header> <!--end of header-->


    <h1>Help Page</h1>

    <p>add some info here</p>

    <p>to help people out if they get stuck</p>

</asp:Content>
