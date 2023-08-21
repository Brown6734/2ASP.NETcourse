<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SE256_Brown_Masterbackend._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <link href="Content/pageforHome.css" rel="stylesheet" />

    <!--cc
    <div>
        <h1>Home Page</h1>

    </div>

    <div>
        <p>Our company name is Office Lovers</p>

    </div>

    <div>

        <p>We sell all kinds of products here. Mostly office supplies and some other things.</p>

    </div>-->

    <!--codsmment-->

    <!--first we need a header-->

    <!--text: business logo, shop, deals, services, search field (text box maybe) with magnifiying glass-->

    <!--also in header: three dots/lines for navigation, question mark for help, sign in (to login or create an account)-->

    <!--also in header: shopping cart-->





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

    <br />

    

    <!--buttons do not like -# pixels
        i try to do:
        margin-top: -40px; does not make a change on the website - like it should... -->

    

    <!--big promotions/deals - maybe on some sort of slideshow or slider thing? "C:\Users\Brown\OneDrive\Desktop\myprojects\SE256_Brown_Masterbackend\Imagess\navimage1.jpg"-->

    <div class="BigDeals1">

        <div class="dealRect1">
            <p>Deals/Promos</p>

            <img src="Imgs/promo1.png" class="promo1" />
        </div>
        <div class="dealRect2">
            <p>Deals/Promos</p>

            <img src="Imgs/promo2.png" class="promo2" />
        </div>
        <div class="dealRect3">
            <p>Deals/Promos</p>

            <img src="Imgs/promo3.png" class="promo3" />
        </div>

    </div>

    <br />
    <br />

    <div class="BigDeals2">
        <div class="deals2rect1">
            <p>Deals/Promos</p>

            <img src="Imgs/promo4.jpg" class="promo4" />
        </div>
        <div class="deals2rect2">
            <p>Deals/Promos</p>

            <img src="Imgs/promo5.jpg" class="promo5" />
        </div>
        <div class="deals2rect3">
            <p>Deals/Promos</p>

            <img src="Imgs/promo6.png" class="promo6" />
        </div>

    </div>

    <br />
    <br />

    <!--common validator properties:
        
        ControlToValidate
        Display
        ErrorMessage
        Text
        Enabled
        EnableClientScript
        ValidationGroup
        IsValid
        -------------



        

        -->

    <!--dd
        
        can do
        <asp:TextBox stuff>
       
        then validation

        -->

    <asp:TextBox ID="oneBox" runat="server" CssClass="athing" Text="help" />

    <asp:RequiredFieldValidator ID="valid1" runat="server" ControlToValidate="oneBox" ErrorMessage="not good" />

    <asp:TextBox ID="stuff2" runat="server" />

    <asp:RequiredFieldValidator ID="valid2" runat="server" ControlToValidate="stuff2" ErrorMessage="must be filled in" />

    <asp:TextBox ID="another" runat="server" CssClass="great" Text="dsfoij" />

    <asp:RegularExpressionValidator ID="valid3" runat="server" ErrorMessage="bad. very bad" ControlToValidate="another" VadliationExpression="[\w\.-]+(\+[\w-]*)?@([\w-]+\.)+[\w-]+" ></asp:RegularExpressionValidator>

    <asp:TextBox ID="txtNum" runat="server" MaxLength="3" />

    <asp:CompareValidator ID="valid4" runat="server" ErrorMessage="invalid data type"  ControlToValidate="txtNum" Operator="DataTypeCheck" Type="Integer" />

    <asp:ValidationSummary ID="valid5" runat="server" ShowMessageBox="true" />


    <br /> <br />
    <br /> <br />
    <br /> <br />

    <p class="footer2">&nbsp;</p>


    <!--
        drop down navigation - trying to get it to work - to move user to another page...
        dd
        -->


   

    
    
    
    
    <!--<asp:Label ID="something" runat="server" Text=":{-" CssClass="things" />-->

    <!--What asp things/template stuff do not like negavite numbers in css styling?
        Button
        Label
        Textbox
        CheckBox(s)
        Hyperlink
        -->

    <!--items that like negative numbers in css styling
        nav trees
        p tags
        tables
        -->

    <!--<asp:CheckBox ID="CheckBox1" runat="server" Text="happy" CssClass="neg2" OnCheckedChanged="CheckBox1_CheckedChanged" />-->

    <!--<asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click" CssClass="link1">LinkButton</asp:LinkButton>-->
    
    <!--<asp:HyperLink ID="HyperLink1" runat="server" CssClass="link2">HyperLink</asp:HyperLink>-->

   
    <!--input 
        button (html)
        
        <input type="button" value="thing"

        -->
    

    <script src="Scripts/Home.js"></script>


    

</asp:Content>




<asp:Content ID="Content1" ContentPlaceHolderID="BreakingNewsContent" runat="server">
    <!--Placeholder for breaking news content-->

    <!--<div>-->
        <!--<h1>Breaking News:</h1>-->
        <!--<p>
            After sharing his aweful brand of humor for decades, finds out that his jokes are not funny. Teacher shocked and amazed. His family and students request his face to be the image next to Dad-Jokes if it is added to dictionary.
        </p>-->
    <!--</div>-->


</asp:Content>




