<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Brown_Calc_Assignn.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtLCD" runat="server" OnTextChanged="TextBox1_TextChanged" Width="218px"></asp:TextBox>

            <!--this label's value will change - to the last math operation that was performed-->
            <asp:Label ID="lblOperations" runat="server" Text="&nbsp;"></asp:Label>

            <!--if something is stored in memory, this label's text value will be M-->
            <asp:Label ID="lblMemory" runat="server" Text="&nbsp;"></asp:Label>
            <!--when something is stored in memory, change the text property? to the last math operation that occured-->
            <br />

            <asp:Button ID="btnMemoryStore" runat="server" Text="MS" OnClick="btnMemoryStore_Click" />
            <asp:Button ID="btnMemoryRestore" runat="server" Text="MR" OnClick="btnMemoryRestore_Click" />
            <asp:Button ID="btnMemoryClear" runat="server" Text="MC" OnClick="btnMemoryClear_Click" />

            <!--Bonus 5 points:
                Employ MS (Memory Store)
                MR (Memory Restore/Recall)
                MC (Memory Clear)
                buttons to Store, Restore, and Clear the memory variable-->

            <!--bonus 10 points:
                modify the operand buttons to allow the user to enter a series of calculations and only needing to click on the Equals button when performing the final calculation-->
           
            


            <br />
            <br />
            <asp:Button ID="btn1" runat="server" Text="1" OnClick="btn1_Click" />
            <asp:Button ID="btn2" runat="server" Text="2" OnClick="btnNumeric_Click" />
            <asp:Button ID="btn3" runat="server" Text="3" OnClick="btnNumeric_Click" />

            <!--I need to move the minus button over-->

            <!--comment-->
            

            <asp:Button ID="btnPlus" runat="server" Text="+" OnClick="btnOperations_Click" />
            
            
            
            


            <!--need to do numbers: 4, 5, and 6 (more buttons)-->
            <br />
            <asp:Button ID="btn4" runat="server" Text="4" OnClick="btnNumeric_Click" /> <!--button for 4-->
            <asp:Button ID="btn5" runat="server" Text="5" OnClick="btnNumeric_Click" /> <!--button for 5-->
            <asp:Button ID="btn6" runat="server" Text="6" OnClick="btnNumeric_Click"/> <!--button for 6-->
            <asp:Button ID="btnSub" runat="server" Text="-" OnClick="btnOperations_Click" />

            <!--need buttons 7, 8, and 9-->
            <br />
            <asp:Button ID="btn7" runat="server" Text="7" OnClick="btnNumeric_Click" /> <!--button for 7-->
            <asp:Button ID="btn8" runat="server" Text="8" OnClick="btnNumeric_Click"/> <!--button for 8-->
            <asp:Button ID="btn9" runat="server" Text="9" OnClick="btnNumeric_Click"/> <!--button for 9-->
            <asp:Button ID="btnMult" runat="server" Text="*" OnClick="btnOperations_Click" />
            
            <!--button for 0 and decimal point . -->
            <br />

            

            <asp:Button ID="btnEquals" runat="server" Text="=" OnClick="btnEquals_Click" />
            <asp:Button ID="btn0" runat="server" Text="0" OnClick="btnNumeric_Click" />
            <asp:Button ID="btnDecimal" runat="server" Text="." OnClick="btnDecimal_Click" />
            <asp:Button ID="btnDivide" runat="server" Text="÷" OnClick="btnOperations_Click" />

            <br />


            
        </div>
    </form>
</body>
</html>
