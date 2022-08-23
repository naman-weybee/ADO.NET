<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebFormApp.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
                <a href="WebForm1.aspx" style="background-color: #FFFF66">Home</a><br /><br />
            <asp:Label ID="Label7" runat="server" BorderColor="Red" BorderStyle="None" ForeColor="#000099"></asp:Label>
            <br />
            <br />
            <table align="left">
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label1" runat="server" ForeColor="#00CCFF"></asp:Label>
                    </td>
                    <td class="auto-style1">
                        <asp:Label ID="Label4" runat="server" ForeColor="#00CCFF"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label2" runat="server" ForeColor="#009933"></asp:Label>
                    </td>
                    <td class="auto-style1">
                        <asp:Label ID="Label5" runat="server" ForeColor="#009933"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label3" runat="server" ForeColor="Fuchsia"></asp:Label>
                    </td>
                    <td class="auto-style1">
                        <asp:Label ID="Label6" runat="server" ForeColor="Fuchsia"></asp:Label>
                    </td>
                </tr>
            </table>
    </form>
</body>
</html>
