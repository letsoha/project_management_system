<%@ Page Language="VB" MasterPageFile="~/admin/MasterPage.master" AutoEventWireup="false" CodeFile="ChangeMemberDetails.aspx.vb" Inherits="admin_Default2" title="Change Member Details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <strong><span style="font-size: 0.8em; font-family: Verdana">CHANGE MEMBER DETAILS</span></strong><br />
    <br />
    <asp:Label ID="lblMsg" runat="server" Width="549px" Font-Bold="True" Font-Names="Verdana" Font-Size="0.8em"></asp:Label><br />
    <table id="tableMemCodes" runat="server" style="width: 609px">
        <tr>
            <td align="right" style="width: 177px">
                <span style="font-size: 9pt; font-family: Verdana">Select&nbsp; Member To Modify</span></td>
            <td align="left" style="width: 100px">
                <asp:DropDownList ID="dpdMemberCode" runat="server" Width="344px">
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td align="center" colspan="2" valign="bottom">
                <asp:Button ID="btnMemDetails" runat="server" Font-Names="Verdana" Font-Size="0.75em"
                    Text="Display Member Details" /></td>
        </tr>
    </table>
    <table id="TblAddMemberControls" runat="server" style="width: 618px">
        <tr>
            <td align="right" style="width: 216px">
                <span style="font-size: 0.8em; font-family: Verdana">First Name</span></td>
            <td style="width: 100px">
                <asp:TextBox ID="txtFName" runat="server" Width="337px"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="right" style="width: 216px">
                <span style="font-size: 0.8em; font-family: Verdana">Last Name</span></td>
            <td style="width: 100px">
                <asp:TextBox ID="txtLName" runat="server" Width="335px"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="right" style="width: 216px">
                <span style="font-size: 0.8em; font-family: Verdana">Title</span></td>
            <td style="width: 100px">
                <asp:TextBox ID="txtTitle" runat="server" Width="334px"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="right" style="width: 216px" valign="top">
                <span style="font-size: 0.8em; font-family: Verdana">Address</span></td>
            <td style="width: 100px">
                <textarea id="txtAddress" runat="server" style="width: 334px; height: 78px"></textarea></td>
        </tr>
        <tr>
            <td align="right" style="width: 216px">
                <span style="font-size: 0.8em; font-family: Verdana">Telephone Number</span></td>
            <td style="width: 100px">
                <asp:TextBox ID="txtTelephone" runat="server" Width="332px"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="right" style="width: 216px">
                <span style="font-size: 0.8em; font-family: Verdana">Mobile Number</span></td>
            <td style="width: 100px">
                <asp:TextBox ID="txtMobile" runat="server" Width="329px"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="right" style="width: 216px; height: 18px">
                <span style="font-size: 0.8em; font-family: Verdana">Email Address</span></td>
            <td style="width: 100px; height: 18px">
                <asp:TextBox ID="txtEmail" runat="server" Width="329px"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 216px">
            </td>
            <td style="width: 100px">
                <asp:Button ID="btnChangeMember" runat="server" Font-Bold="False" Font-Names="Verdana"
                    Font-Size="0.75em" Text="Change Member Details" Width="206px" /></td>
        </tr>
    </table>
</asp:Content>

