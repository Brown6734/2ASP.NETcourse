<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="testPage.aspx.cs" Inherits="SE256_Brown_Masterbackend.testPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="BreakingNewsContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Products1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Products2" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="MainContent" runat="server">

    <link href="Content/inks.css" rel="stylesheet" />



    <!--<asp:Button ID="thingButton" runat="server" Text="{}" CssClass="button2" />-->

    <!--<asp:Button ID="greatButton" runat="server" Text="\\" CssClass="button3" />-->

    <!--<asp:Button ID="imageButton" runat="server" Text="#^$" CssClass="button4" />-->

    <!--<asp:Button ID="someButton" runat="server" Text="ths" CssClass="button1" />-->

    

    <asp:TreeView ID="TreeView8" runat="server" CssClass="button1" >
        <Nodes>
            <asp:TreeNode Text="logo" Value="logo" />
        </Nodes>
    </asp:TreeView>

   

    <asp:TreeView ID="TreeView1" runat="server" CssClass="Tree1">

        <Nodes>
            <asp:TreeNode Text="Thing1" Value="Thing1" Expanded="False">
                <asp:TreeNode Text="thing2" Value="thing2" />
            </asp:TreeNode>


        </Nodes>

    </asp:TreeView>

    <p class="aspace">&nbsp;</p>

    <asp:TreeView ID="TreeView2" runat="server" CssClass="Tree2" >
        <Nodes>

            <asp:TreeNode Text="option1" Value="option1"/>
            <asp:TreeNode Text="option2" Value="optin2" />

        </Nodes>


    </asp:TreeView>

    <p class="aSpace2">&nbsp;</p>

    

  

    <asp:TreeView ID="TreeView3" runat="server" CssClass="Tree3">

        <Nodes>

            <asp:TreeNode Text="stuff1" Value="stuff1"/>
            <asp:TreeNode Text="stuff2" Value="stuff2" />

        </Nodes>


    </asp:TreeView>

    <asp:TreeView ID="TreeView4" runat="server" CssClass="Tree4" >
        <Nodes>

            <asp:TreeNode Text="text1" Value="text1" />
            <asp:TreeNode Text="text2" Value="text2" />
                
        </Nodes>


    </asp:TreeView>

    <asp:TreeView ID="TreeView5" runat="server" CssClass="button2" >
        <Nodes>
            <asp:TreeNode Text="hed" />
        </Nodes>

    </asp:TreeView>

    <asp:TreeView ID="TreeView6" runat="server" CssClass="button3">
        <Nodes>
            <asp:TreeNode Text="fds" Value="fds" />
        </Nodes>

    </asp:TreeView>

    <asp:TreeView ID="TreeView7" runat="server" CssClass="button4" >
        <Nodes>
            <asp:TreeNode Text="563" Value="563" />
        </Nodes>

    </asp:TreeView>
    

    <br />





</asp:Content>
