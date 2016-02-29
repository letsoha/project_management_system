<%@ Page Language="VB" MasterPageFile="~/admin/MasterPage.master" AutoEventWireup="false" CodeFile="AddUser.aspx.vb" Inherits="admin_Default2" title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <span style="text-decoration: underline"><strong><span style="font-size: 0.85em;
        font-family: Verdana">ADD NEW USER</span></strong><br />
    </span>
    <br />
    <asp:Label ID="lblDisplay" runat="server" Font-Bold="True" Font-Names="Verdana" Font-Size="0.8em"
        Width="566px"></asp:Label><br />
    <br />
    <table style="width: 479px" id="AddUserControls" runat="server">
        <tr>
            <td style="width: 166px">
                <span style="font-size: 0.8em; font-family: Verdana">User ID</span></td>
            <td style="width: 100px">
                <asp:TextBox ID="txtUserId" runat="server" Width="251px"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 166px">
                <span style="font-size: 0.8em; font-family: Verdana">Password</span></td>
            <td style="width: 100px">
                <input id="txtPassword" style="width: 250px" type="password" runat="server" /></td>
        </tr>
        <tr>
            <td style="width: 166px">
                <span style="font-size: 0.8em; font-family: Verdana">Confirm Password</span></td>
            <td style="width: 100px">
                <input id="txtConfirmPassword" style="width: 248px" type="password" runat="server" /></td>
        </tr>
        <tr>
            <td style="width: 166px">
                <span style="font-size: 0.8em; font-family: Verdana">Access Level</span></td>
            <td style="width: 100px">
                <asp:DropDownList ID="dpdAccessLevel" runat="server" Width="256px">
                    <asp:ListItem Value="0">Administrator</asp:ListItem>
                    <asp:ListItem Value="1">Management</asp:ListItem>
                    <asp:ListItem Value="2">General Staff</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td style="width: 166px">
                <span style="font-size: 0.8em; font-family: Verdana">Name</span></td>
            <td style="width: 100px">
                <asp:TextBox ID="txtName" runat="server" Width="249px"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 166px">
                <span style="font-size: 0.8em; font-family: Verdana">Last Name</span></td>
            <td style="width: 100px">
                <asp:TextBox ID="txtLastName" runat="server" Width="246px"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 166px">
                <span style="font-size: 0.8em; font-family: Verdana">Address</span></td>
            <td style="width: 100px">
                <textarea id="txtAddress" rows="2" cols="4" style="width: 245px" runat="server"></textarea></td>
        </tr>
        <tr>
            <td style="width: 166px">
                <span style="font-size: 0.8em; font-family: Verdana">Telephone</span></td>
            <td style="width: 100px">
                <asp:TextBox ID="txtPhone" runat="server" Width="244px"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 166px">
                <span style="font-size: 0.8em; font-family: Verdana">Mobile Number</span></td>
            <td style="width: 100px">
                <asp:TextBox ID="txtMobile" runat="server" Width="244px"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 166px">
                <span style="font-size: 0.8em; font-family: Verdana">Email Address</span></td>
            <td style="width: 100px">
                <asp:TextBox ID="txtEmail" runat="server" Width="244px"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 166px">
            </td>
            <td style="width: 100px">
                <asp:Button ID="btnAddUser" runat="server" Text="Add User" Width="109px" Font-Names="Verdana" Font-Size="0.8em" /></td>
        </tr>
    </table>
</asp:Content>

