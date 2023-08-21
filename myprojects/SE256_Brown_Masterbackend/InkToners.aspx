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


    </header> <!--end of header-->

    

    <div>
        <p>This page determines what ink or toner your printer needs</p>

        <p>Just put in which printer you have, and you will get the ink or toner you need</p>

        <p>the printers we can check are:
            printer 1, printer 2, printer 3, printer 4, printer 5, and printer 6
        </p>

    </div>

   

    <br /> <br />
    <br /> <br />

    <asp:Button ID="loopButton" runat="server" Text="test" OnClick="loopButton_Click"/>

    <asp:TextBox ID="inkText" runat="server" Text="inks" />

    <br />

    <asp:TextBox ID="tonerText" runat="server" Text="toners" />

    <br />

    <asp:TextBox ID="printerText" runat="server" Text="printers" />

    <br /> <br />
    <br /> <br />

    <asp:TextBox ID="stuff1" runat="server" Text="which printer?" />

    <br /> <br />

    <asp:TextBox ID="needNum" runat="server" MaxLength="3" />

    <asp:RequiredFieldValidator ID="inkValid" runat="server" ControlToValidate="inkText" ErrorMessage="must be filled in" />

    

    <asp:RequiredFieldValidator ID="tonerValid" runat="server" ControlToValidate="tonerText" ErrorMessage="must not be empty" />

    

    <asp:RequiredFieldValidator ID="printerValid" runat="server" ControlToValidate="printerText" ErrorMessage="must not be empty" />
    
  

    <asp:CompareValidator ID="numCompare" runat="server" ErrorMessage="invalid data type" ControlToValidate="needNum" Operator="DataTypeCheck" Type="Integer" />


    

</asp:Content>
