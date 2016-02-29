<%@ Page Language="VB" AutoEventWireup="false" CodeFile="MainMenu.aspx.vb" Inherits="MainMenu" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Main Menu</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table border="0" cellpadding="0" cellspacing="0" style="width: 100%; height: 100%">
            <tr>
                <td colspan="2" style="height: 1px">
                </td>
            </tr>
            <tr>
                <td style="width: 148px" valign="top">
                    <asp:Menu ID="Menu1" runat="server" BackColor="#B5C7DE" DynamicHorizontalOffset="2"
                        Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284E98" StaticSubMenuIndent="10px"
                        Width="142px">
                        <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                        <DynamicHoverStyle BackColor="#284E98" ForeColor="White" />
                        <DynamicMenuStyle BackColor="#B5C7DE" />
                        <StaticSelectedStyle BackColor="#507CD1" />
                        <DynamicSelectedStyle BackColor="#507CD1" />
                        <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                        <Items>
                            <asp:MenuItem Text="ENQUIRIES" Value="ENQUIRIES">
                                <asp:MenuItem Text="Projects" Value="Projects"></asp:MenuItem>
                            </asp:MenuItem>
                            <asp:MenuItem Text="REPORTS" Value="REPORTS">
                                <asp:MenuItem Text="Projects" Value="Projects"></asp:MenuItem>
                            </asp:MenuItem>
                            <asp:MenuItem Text="TRANSACTIONS" Value="TRANSACTIONS">
                                <asp:MenuItem Text="Projects" Value="Projects"></asp:MenuItem>
                            </asp:MenuItem>
                        </Items>
                        <StaticHoverStyle BackColor="#284E98" ForeColor="White" />
                    </asp:Menu>
                </td>
                <td valign="top">
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
