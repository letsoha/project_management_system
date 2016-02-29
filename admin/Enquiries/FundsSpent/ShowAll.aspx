<%@ Page Language="VB" MasterPageFile="~/admin/MasterPage.master" AutoEventWireup="false" CodeFile="ShowAll.aspx.vb" Inherits="admin_Default2" title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table id="FundsRecTable" runat="server" style="width: 543px">
        <tr>
            <td align="left" colspan="2">
                <asp:Label ID="lblResults" runat="server" ForeColor="Red" Width="533px" Font-Bold="True" Font-Names="Verdana" Font-Size="0.65em"></asp:Label></td>
        </tr>
        <tr>
            <td align="center" colspan="2" style="text-align: left">
                <br />
                <table id="Tabletotal" runat="server">
                    <tr>
                        <td style="width: 225px">
                            <strong><span style="font-size: 0.75em; font-family: Verdana">TOTAL AMOUNT SPENT</span></strong></td>
                        <td style="width: 100px">
                            <asp:Label ID="lblTotal" runat="server" Width="221px" Font-Names="Verdana" Font-Size="0.75em"></asp:Label></td>
                    </tr>
                </table>
                <br />
                <br />
                <asp:GridView ID="gvData" runat="server" BackColor="White" BorderColor="#999999"
                    BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" Height="83px"
                    Width="517px" Font-Names="Verdana" Font-Size="0.8em">
                    <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                    <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                    <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                    <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                    <AlternatingRowStyle BackColor="Gainsboro" />
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>

