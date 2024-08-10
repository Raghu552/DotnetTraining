<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Validations.aspx.cs" Inherits="ASP_Assignment.Validations" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Validations</title>
    <style>
        *{
            background-color:burlywood;
        }
        #form1{
            color:darkviolet;
            font-size:20px;
            font-family:'Times New Roman', Times, serif;                
        }
        #txt{
            color:aqua
        }
        #btn{
            color:blue;
            font-size:25px;
        }
        #btn:hover{
            color:brown;
            background-color:black;
            cursor:pointer;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h2 id="txt">Insert Your Details</h2><p>
            Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtN" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Name Cannot be Empty" ForeColor="Red" ControlToValidate="txtN"></asp:RequiredFieldValidator>
            <br />
            <br />
            Family Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Txtfn" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Family Name Cannot be Empty" ForeColor="Red" ControlToValidate="Txtfn"></asp:RequiredFieldValidator>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtN" ControlToValidate="Txtfn" ErrorMessage="Name, Family name cannot be same" ForeColor="Blue" Operator="NotEqual"></asp:CompareValidator>
            <br />
            <br />
            Address&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Txtadd" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Address Cannot be Empty" ForeColor="Red" ControlToValidate="Txtadd"></asp:RequiredFieldValidator>
            <br />
            <br />
            City&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Txtc" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="City Cannot be Empty" ForeColor="Red" ControlToValidate="Txtc"></asp:RequiredFieldValidator>
            <br />
            <br />
            Zip Code&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Txtzc" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Zip Code Cannot be Empty" ForeColor="Red" ControlToValidate="Txtzc"></asp:RequiredFieldValidator>
            <br />
            <br />
            Phone&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Txtp" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Mobile Number Cannot be Empty" ForeColor="Red" ControlToValidate="Txtp"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="Txtp" ErrorMessage="Invalid Number" ForeColor="Blue" ValidationExpression="\d{10}"></asp:RegularExpressionValidator>
            <br />
            <br />
            Email&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Txtem" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="Email Cannot be Empty" ForeColor="Red" ControlToValidate="Txtem"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="Txtem" ErrorMessage="Invalid Email" ForeColor="Blue" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        </p>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btn" runat="server" Text="Check" OnClick="btn_Click" Font-Size="Medium"  />
        </p>
    </form>
</body>
</html>
