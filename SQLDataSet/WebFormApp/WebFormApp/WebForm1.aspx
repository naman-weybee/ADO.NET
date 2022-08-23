<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebFormExample.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .auto-style1 {  
            width: 100px;  
        }  
        .auto-style4 {
            width: 100%;
        }
    </style>
    </head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="center">
                <tr>
                    <td class="auto-style1">User Name </td>
                    <td>
                        <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Email ID</td>
                    <td>
                        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Contact</td>
                    <td>
                        <asp:TextBox ID="txtContact" runat="server" MaxLength="10"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td style="text-align: center">
                        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                    </td>
                </tr>
            </table>
            <asp:Label ID="Label7" runat="server"></asp:Label>
            <br />
            <br />
            <table align="left">
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label1" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style1">
                        <asp:Label ID="Label4" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label2" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style1">
                        <asp:Label ID="Label5" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label3" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style1">
                        <asp:Label ID="Label6" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
