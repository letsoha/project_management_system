<%@ Page Language="VB" MasterPageFile="~/admin/MasterPage.master" AutoEventWireup="false" CodeFile="DeleteUser.aspx.vb" Inherits="admin_Default2" title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <span style="font-size: 0.8em; font-family: Verdana"><strong><span style="text-decoration: underline">
        Delete User account<br />
        <br />
    </span></strong>
        <table style="font-weight: bold; width: 496px; text-decoration: underline">
            <tr>
                <td style="width: 132px">
                    User ID</td>
                <td style="width: 100px">
                    <asp:TextBox ID="txtUserId" runat="server" Width="239px"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 132px">
                </td>
                <td style="width: 100px">
                    <asp:Button ID="btnDeleteUser" runat="server" Text="Delete User Account" Width="208px" /></td>
            </tr>
        </table>
    </span>
</asp:Content>

