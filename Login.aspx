<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Login.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Login</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Panel ID="Panel1" runat="server" Height="165px" Width="674px">
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Verdana" Font-Size="0.7em"
            Text="Userid" Width="130px" Height="20px"></asp:Label>
        <asp:TextBox ID="txtUserID" runat="server" Width="150px"></asp:TextBox>
            <asp:Label ID="lblWrongUser" runat="server" Font-Bold="True" Font-Names="Verdana"
                Font-Size="0.8em" ForeColor="Red" Width="220px"></asp:Label><br />
            <br />
        <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Names="Verdana" Font-Size="0.7em"
            Text="Password" Width="130px" Height="20px"></asp:Label>
        <input id="Pass" style="width: 150px" type="password" runat="server" />
            &nbsp;<asp:Label ID="lblWrongPass" runat="server" Font-Bold="True" Font-Names="Verdana"
                Font-Size="0.8em" ForeColor="Red" Width="214px"></asp:Label><br />
            <br />
        <asp:Button ID="btnLogin" runat="server" Font-Bold="False" Font-Names="Verdana" Font-Size="0.7em"
            Text="Login" BackColor="Control" BorderColor="Lavender" BorderStyle="Outset" Width="65px" />
        <asp:Button ID="btnCancel" runat="server" Font-Bold="False" Font-Names="Verdana" Font-Size="0.7em"
            Text="Cancel" BackColor="Control" BorderColor="Lavender" BorderStyle="Outset" Width="65px" /></asp:Panel>
        <br />
        &nbsp;
    </div>
    </form>
</body>
</html>
