<%@ Page Language="VB" MasterPageFile="~/admin/MasterPage.master" AutoEventWireup="false" CodeFile="AddMember.aspx.vb" Inherits="admin_Default2" title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <span style="font-size: 0.8em; font-family: Verdana"><span style="text-decoration: underline">
        <strong>Add New Member<br />
            <br />
        </strong></span>
        <asp:Label ID="lblMsg" runat="server" Font-Bold="True" Font-Overline="False" Font-Underline="False"
            ForeColor="#8080FF" Width="600px"></asp:Label><br />
        <br />
        <table id="TblAddMemberControls" style="width: 356px" runat="server">
            <tr>
                <td align="right" style="width: 144px">
                    First Name</td>
                <td style="width: 100px">
                    <asp:TextBox ID="txtFName" runat="server" Width="185px"></asp:TextBox></td>
            </tr>
            <tr>
                <td align="right" style="width: 144px">
                    Last Name</td>
                <td style="width: 100px">
                    <asp:TextBox ID="txtLName" runat="server" Width="185px"></asp:TextBox></td>
            </tr>
            <tr>
                <td align="right" style="width: 144px">
                    Title</td>
                <td style="width: 100px">
                    <asp:TextBox ID="txtTitle" runat="server" Width="186px"></asp:TextBox></td>
            </tr>
            <tr>
                <td align="right" style="width: 144px" valign="top">
                    Address</td>
                <td style="width: 100px">
                    <textarea id="txtAddress" style="width: 188px; height: 78px" runat="server"></textarea></td>
            </tr>
            <tr>
                <td align="right" style="width: 144px">
                    Telephone Number</td>
                <td style="width: 100px">
                    <asp:TextBox ID="txtTelephone" runat="server" Width="185px"></asp:TextBox></td>
            </tr>
            <tr>
                <td align="right" style="width: 144px">
                    Mobile Number</td>
                <td style="width: 100px">
                    <asp:TextBox ID="txtMobile" runat="server" Width="184px"></asp:TextBox></td>
            </tr>
            <tr>
                <td align="right" style="width: 144px; height: 18px">
                    Email Address</td>
                <td style="width: 100px; height: 18px">
                    <asp:TextBox ID="txtEmail" runat="server" Width="183px"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 144px">
                </td>
                <td style="width: 100px">
                    <asp:Button ID="btnAddMember" runat="server" Font-Bold="False" Font-Names="Verdana"
                        Font-Size="0.75em" Text="Add Member" Width="131px" /></td>
            </tr>
        </table>
    </span>
</asp:Content>

