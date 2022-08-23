<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="WebFormApp.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
        <a href="WebForm1.aspx" style="background-color: #FFFF66">Home</a><br />
        <br />
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
        <p>
            &nbsp;</p>
        <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical">
            <AlternatingRowStyle BackColor="Gainsboro" />
            <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
            <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
            <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#0000A9" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#000065" />
        </asp:GridView>
    </form>
</body>
</html>
