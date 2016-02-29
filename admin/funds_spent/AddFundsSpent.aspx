<%@ Page Language="VB" MasterPageFile="~/admin/MasterPage.master" AutoEventWireup="false" CodeFile="AddFundsSpent.aspx.vb" Inherits="admin_Default2" title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <strong><span style="font-size: 9pt; font-family: Verdana">ADD FUNDS SPENT<br />
        <br />
    </span></strong>
    <asp:Label ID="lblMsg" runat="server" Font-Bold="False" Font-Size="0.8em" ForeColor="Red"
        Width="574px"></asp:Label><br />
    <table id="FundsRecTblControls" runat="server" style="font-weight: bold; width: 580px">
        <tr>
            <td align="right" style="width: 167px" valign="top">
                <span style="font-size: 0.8em; font-family: Verdana">Date Spent</span></td>
            <td style="width: 100px">
                <asp:Calendar ID="DateSpent" runat="server" BackColor="White" BorderColor="#3366CC"
                    BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" Font-Names="Verdana"
                    Font-Size="8pt" ForeColor="#003399" Height="147px" Width="163px">
                    <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                    <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
                    <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
                    <WeekendDayStyle BackColor="#CCCCFF" />
                    <OtherMonthDayStyle ForeColor="#999999" />
                    <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
                    <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
                    <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" Font-Bold="True"
                        Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
                </asp:Calendar>
            </td>
        </tr>
        <tr>
            <td align="right" style="width: 167px" valign="top">
                <span style="font-size: 0.8em; font-family: Verdana">Account</span></td>
            <td style="width: 100px">
                <asp:DropDownList ID="dpdAcc" runat="server" Width="184px">
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td align="right" style="width: 167px" valign="top">
                <span style="font-size: 0.8em; font-family: Verdana">Project</span></td>
            <td style="width: 100px">
                <asp:DropDownList ID="dpdProject" runat="server" Width="321px">
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td align="right" style="width: 167px; height: 26px" valign="top">
                <span style="font-size: 0.8em; font-family: Verdana">Other Reference</span></td>
            <td style="width: 100px; height: 26px">
                <asp:TextBox ID="txtOtherRef" runat="server" Width="314px"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="right" style="width: 167px; height: 26px" valign="top">
                <span style="font-size: 0.8em; font-family: Verdana">Amount Spent</span></td>
            <td style="width: 100px; height: 26px">
                <asp:TextBox ID="txtAmountSpent" runat="server" Width="312px"></asp:TextBox>
                </td>
        </tr>
        <tr>
            <td align="center" colspan="2" style="height: 21px">
                <asp:Button ID="btnSave" runat="server" Font-Names="Verdana" Font-Size="0.75em" Text="Save"
                    Width="115px" /></td>
        </tr>
    </table>
</asp:Content>

