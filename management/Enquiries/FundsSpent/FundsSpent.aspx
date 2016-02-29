<%@ Page Language="VB" MasterPageFile="~/admin/MasterPage.master" AutoEventWireup="false" CodeFile="FundsSpent.aspx.vb" Inherits="admin_Default2" title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <span style="font-size: 0.8em; font-family: Verdana"><strong>FUNDS SPENT</strong><br />
        <br />
        <asp:Label ID="lblMsg" runat="server" ForeColor="Red" Width="564px"></asp:Label><br />
        <table style="width: 561px">
            <tr>
                <td align="right" style="width: 100px" valign="top">
                    Date From</td>
                <td style="width: 100px">
                    <asp:Calendar ID="DateFrom" runat="server" BackColor="White" BorderColor="#3366CC"
                        BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" Font-Names="Verdana"
                        Font-Size="8pt" ForeColor="#003399" Height="146px" Width="168px">
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
                <td align="right" style="width: 100px" valign="top">
                    Date To</td>
                <td style="width: 100px">
                    <asp:Calendar ID="DateTo" runat="server" BackColor="White" BorderColor="#3366CC"
                        BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" Font-Names="Verdana"
                        Font-Size="8pt" ForeColor="#003399" Height="146px" Width="167px">
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
                <td align="center" colspan="2">
                    <asp:Button ID="btnSearchByDate" runat="server" Font-Names="Verdana" Font-Size="0.75em"
                        Text="Search By Date Range" /></td>
            </tr>
            <tr>
                <td align="left" colspan="2">
                    <asp:Label ID="lblResults" runat="server" Font-Bold="False" ForeColor="Red" Width="536px"></asp:Label><br />
                    <br />
                    <table id="TableTotalSpent" runat="server" style="width: 371px">
                        <tr>
                            <td style="width: 100px">
                                <strong>TOTAL SPENT</strong></td>
                            <td style="width: 100px">
                                <asp:Label ID="lblTotalSpent" runat="server" Width="245px"></asp:Label></td>
                        </tr>
                    </table>
                    <br />
                    <br />
                    <asp:GridView ID="gvData" runat="server" BackColor="White" BorderColor="#E7E7FF"
                        BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal" Width="539px">
                        <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
                        <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
                        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
                        <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
                        <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                        <AlternatingRowStyle BackColor="#F7F7F7" />
                    </asp:GridView>
                </td>
            </tr>
        </table>
    </span>
</asp:Content>

