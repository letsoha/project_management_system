<%@ Page Language="VB" MasterPageFile="~/admin/MasterPage.master" AutoEventWireup="false" CodeFile="ChangePassword.aspx.vb" Inherits="admin_Default2" title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <span style="font-size: 0.8em; font-family: Verdana"><span><strong>
        Change User Password</strong><br />
        <br />
    </span>
        <table style="font-weight: bold; width: 473px; text-decoration: underline" runat="server" id="ChangePassTable">
            <tr>
                <td style="width: 143px">
                    User ID</td>
                <td style="width: 100px">
                    <asp:TextBox ID="txtUserid" runat="server" Width="194px"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 143px">
                    New Password</td>
                <td style="width: 100px">
                    <input id="txtPassword" style="width: 195px" type="password" runat="server" /></td>
            </tr>
            <tr>
                <td style="width: 143px">
                    Confirm Password</td>
                <td style="width: 100px">
                    <input id="txtConfirmPass" style="width: 195px" type="password" runat="server" /></td>
            </tr>
            <tr>
                <td style="width: 143px">
                </td>
                <td style="width: 100px">
                    <asp:Button ID="btnChangePassword" runat="server" Text="Change Password" Width="131px" Font-Names="Verdana" Font-Size="0.8em" /></td>
            </tr>
        </table>
    </span>
    <asp:Label ID="lblError" runat="server" Font-Names="Verdana" Font-Size="0.77em" ForeColor="Red"
        Width="360px"></asp:Label>
</asp:Content>

