<%@ Page Language="VB" MasterPageFile="~/admin/MasterPage.master" AutoEventWireup="false" CodeFile="AddFundsRec.aspx.vb" Inherits="admin_Default2" title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <span style="font-size: 0.8em; font-family: Verdana"><strong>ADD FUNDS RECIEVED</strong><br />
        <br />
        <asp:Label ID="lblMsg" runat="server" ForeColor="Red" Width="515px"></asp:Label><br />
        <table id="FundsRecTblControls" runat="server" style="font-weight: bold; width: 508px">
            <tr>
                <td align="right" style="width: 100px">
                    Source</td>
                <td style="width: 100px">
                    <asp:TextBox ID="txtSource" runat="server" Width="260px"></asp:TextBox></td>
            </tr>
            <tr>
                <td align="right" style="width: 100px">
                    Source Reference</td>
                <td style="width: 100px">
                    <asp:TextBox ID="txtSourceRef" runat="server" Width="260px"></asp:TextBox></td>
            </tr>
            <tr>
                <td align="right" style="width: 100px">
                    Project</td>
                <td style="width: 100px">
                    <asp:DropDownList ID="dpdProject" runat="server" Width="266px">
                    </asp:DropDownList></td>
            </tr>
            <tr>
                <td align="right" style="width: 100px; height: 26px">
                    Amount Received</td>
                <td style="width: 100px; height: 26px">
                    <asp:TextBox ID="txtAmount" runat="server" Width="260px"></asp:TextBox></td>
            </tr>
            <tr>
                <td align="center" colspan="2" style="height: 21px">
                    <asp:Button ID="btnSave" runat="server" Font-Names="Verdana" Font-Size="0.75em" Text="Save"
                        Width="115px" /></td>
            </tr>
        </table>
    </span>
</asp:Content>

