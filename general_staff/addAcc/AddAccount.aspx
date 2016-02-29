<%@ Page Language="VB" MasterPageFile="~/admin/MasterPage.master" AutoEventWireup="false" CodeFile="AddAccount.aspx.vb" Inherits="admin_Default2" title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="lblDisplay" runat="server" Width="251px"></asp:Label><br />
    <table>
        <tr>
            <td style="width: 100px">
                <asp:Label ID="lblDesc" runat="server" Font-Names="Verdana" Font-Size="0.8em" Text="Description"
                    Width="126px"></asp:Label></td>
            <td style="width: 100px">
                <asp:TextBox ID="txtDescr" runat="server" Width="222px"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 100px" valign="top">
                <asp:Label ID="lblComment" runat="server" Font-Names="Verdana" Font-Size="0.8em" Text="Comments"
                    Width="124px"></asp:Label></td>
            <td style="width: 100px">
                <textarea id="textComments" runat="server" style="width: 224px; height: 63px"></textarea></td>
        </tr>
        <tr>
            <td style="width: 100px">
            </td>
            <td colspan="1">
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;<asp:Button ID="btnOk" runat="server" Text="Add"
                    Width="75px" />
                &nbsp; &nbsp;&nbsp;<asp:Button ID="btnCancel" runat="server" Text="Clear" Width="79px" />
                &nbsp;
            </td>
        </tr>
    </table>
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;<br />
    <br />
</asp:Content>

