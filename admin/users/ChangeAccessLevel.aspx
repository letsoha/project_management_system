<%@ Page Language="VB" MasterPageFile="~/admin/MasterPage.master" AutoEventWireup="false" CodeFile="ChangeAccessLevel.aspx.vb" Inherits="admin_Default2" title="Change User Access Type" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <span style="font-size: 0.8em; font-family: Verdana"><span><strong>
        CHANGE USER ACCESS LEVEL</strong><br />
        <br />
        <asp:Label ID="lblDisplay" runat="server" Font-Underline="False" Width="583px"></asp:Label><br />
    </span>
        <table style="font-weight: bold; width: 496px; text-decoration: underline" id="AccessInput" runat="server">
            <tr>
                <td style="width: 145px">
                    User ID</td>
                <td style="width: 100px">
                    <asp:TextBox ID="txtUserid" runat="server" Width="239px"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 145px">
                    New Access Level</td>
                <td style="width: 100px">
                    <asp:DropDownList ID="dpdAccess" runat="server" Width="245px">
                        <asp:ListItem Value="0">Administrator</asp:ListItem>
                        <asp:ListItem Value="1">Management</asp:ListItem>
                        <asp:ListItem Value="2">General Staff</asp:ListItem>
                    </asp:DropDownList></td>
            </tr>
            <tr>
                <td style="width: 145px">
                </td>
                <td style="width: 100px">
                    <asp:Button ID="btnUserAccess" runat="server" Text="Change User Access" Width="208px" /></td>
            </tr>
        </table>
    </span>
</asp:Content>

