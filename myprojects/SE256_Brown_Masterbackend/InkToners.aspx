<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InkToners.aspx.cs" Inherits="SE256_Brown_Masterbackend.InkToners" %>
<asp:Content ID="Content1" ContentPlaceHolderID="BreakingNewsContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Products1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Products2" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="MainContent" runat="server">
    
    <header class="headRed"><!--beginning of header; give it a class of headRed  &nbsp;-->
        
        <!--logo--> 

        <asp:TreeView ID="logoTree" runat="server" CssClass="logoButton">
            <Nodes>
                <asp:TreeNode Text="logo" NavigateUrl="~/Default.aspx"/>
            </Nodes>

        </asp:TreeView>
        
        <br />

        <a href="testPage.aspx">Test Page Link</a>


        <br />

        <!--<asp:Image ID="Image1" runat="server" ImageUrl="~/Imgs/logotry1.png" Height="200px" Width="200px" />-->

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

        <asp:TreeView ID="helpTree" runat="server" CssClass="helpIcon">
            <Nodes>
                <asp:TreeNode Text="?" />
            </Nodes>
        </asp:TreeView>

        

        <!--sign in button/login in; brings user to login page (mabye backend one for now)-->

        <asp:TreeView ID="signTree" runat="server" CssClass="loginButton">
            <Nodes>
                <asp:TreeNode Text="Sign In" NavigateUrl="~/Backend/Default.aspx"/>
            </Nodes>
        </asp:TreeView>

        

        <!--shopping cart button 🛒-->

        <asp:TreeView ID="cartTree" runat="server" CssClass="shoppingCart">
            <Nodes>
                <asp:TreeNode Text="🛒" NavigateUrl="~/ShoppingCart.aspx" />
            </Nodes>
        </asp:TreeView>


      

        <br />

        <!--still in header-->
        <!--for business dropdown-->
        

        

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

        

        <!--ink and toner menu/option; bring user to another page-->
        
        <asp:TreeView ID="inkTree" runat="server" CssClass="inkToner">
            <Nodes>
                <asp:TreeNode Text="Ink & Toner" NavigateUrl="~/InkToners.aspx" />
            </Nodes>
        </asp:TreeView>



        <!--space space space-->
        

        

        

        <!--ideas -->
        

        

        <!--orders dropdown-->

        <asp:TreeView ID="TreeView8" runat="server" CssClass="OrdersTree">
            <Nodes>
                <asp:TreeNode Expanded="False" Text="Orders" Value="Orders">
                    <asp:TreeNode Text="Option 1" Value="Option 1"></asp:TreeNode>
                    <asp:TreeNode Text="Option 2" Value="Option 2"></asp:TreeNode>
                </asp:TreeNode>
            </Nodes>
        </asp:TreeView>

        

        <!--set your store-->
        
        <asp:TreeView ID="setStoreID" runat="server" CssClass="storeSet">
            <Nodes>
                <asp:TreeNode Text="Set Your Store" NavigateUrl="~/SetStore.aspx" />
            </Nodes>
        </asp:TreeView>


    </header> <!--end of header-->

    <div class="ink1">
        <p>Ink number one</p>
    </div>

    <br />
    <br />

    <div class="ink2">
        <p>Ink number two</p>

    </div>

    <br />
    <br />

    <div class="toner1">
        <p>Toner number one</p>

    </div>

    <br />
    <br />

    <div class="toner2">
        <p>Toner number two</p>

    </div>

    <br /> <br />
    <br /> <br />

    <asp:Button ID="loopButton" runat="server" Text="happy" OnClick="loopButton_Click"/>

</asp:Content>
