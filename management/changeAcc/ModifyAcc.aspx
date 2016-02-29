<%@ Page Language="VB" MasterPageFile="~/admin/MasterPage.master" AutoEventWireup="false" CodeFile="ModifyAcc.aspx.vb" Inherits="admin_Default2" title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <strong><span style="font-size: 0.85em; font-family: Verdana; text-decoration: underline">
        Modify Account Description<br />
    </span></strong>
    <br />
    <asp:Label ID="lblMsg" runat="server" Font-Bold="True" Font-Names="Verdana" Font-Size="0.65em"
        ForeColor="#3399CC" Width="492px"></asp:Label><br />
    <br />
    <asp:Label ID="lblAccCode" runat="server" Font-Names="Verdana" Font-Size="0.8em"
        Text="Account Code and Description" Width="232px"></asp:Label>
    &nbsp;
    <asp:DropDownList ID="dpdAccCode" runat="server" Font-Names="Verdana" Font-Size="0.8em"
        Width="249px">
    </asp:DropDownList><br />
    <br />
    <asp:Label ID="lblDescr" runat="server" Font-Names="Verdana" Font-Size="0.8em" Text="Account Description"
        Width="234px"></asp:Label>
    &nbsp;&nbsp;
    <asp:TextBox ID="txtDescription" runat="server" Font-Names="Verdana" Font-Size="0.8em" Width="240px"></asp:TextBox><br />
    <br />
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
    <asp:Button ID="btnModifyAcc" runat="server" Text="Modify Account" />
    &nbsp;
    <asp:Button ID="btnClear" runat="server" Text="Clear" /><br />
</asp:Content>

