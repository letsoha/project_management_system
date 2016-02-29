<%@ Page Language="VB" MasterPageFile="~/admin/MasterPage.master" AutoEventWireup="false" CodeFile="FundsReceived.aspx.vb" Inherits="admin_Default2" title="ENQUIRIES - Funds Received" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <span style="font-size: 0.8em; font-family: Verdana"><strong>FUNDS RECEIVED<br />
    </strong>
        <br />
        <asp:Label ID="lblMsg" runat="server" Font-Bold="False" ForeColor="Red" Width="542px"></asp:Label><br />
        <table id="FundsRecTable" runat="server" style="width: 543px">
            <tr>
                <td align="right" style="width: 100px" valign="top">
                    Date From</td>
                <td style="width: 100px">
                    <asp:Calendar ID="DateFrom" runat="server" BackColor="White" BorderColor="#3366CC"
                        BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" Font-Names="Verdana"
                        Font-Size="8pt" ForeColor="#003399" Height="147px" Width="168px">
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
                        Font-Size="8pt" ForeColor="#003399" Height="147px" Width="168px">
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
                <td align="right" style="width: 100px">
                    Project</td>
                <td style="width: 100px">
                    <asp:DropDownList ID="dpdProjects" runat="server" Width="344px">
                    </asp:DropDownList></td>
            </tr>
            <tr>
                <td align="center" colspan="2">
                    <asp:Button ID="btnSearchDate" runat="server" Font-Names="Verdana" Font-Size="0.75em"
                        Text="Search By Date Range" />
                    <asp:Button ID="btnSearchBoth" runat="server" Font-Names="Verdana" Font-Size="0.75em"
                        Text="Search By Date and Project" /></td>
            </tr>
            <tr>
                <td align="left" colspan="2">
                    <asp:Label ID="lblResults" runat="server" ForeColor="Red" Width="533px"></asp:Label></td>
            </tr>
            <tr>
                <td align="center" colspan="2" style="text-align: left">
                    <br />
                    <table id="Tabletotal" runat="server">
                        <tr>
                            <td style="width: 225px">
                                <strong>TOTAL AMOUNT RECEIVED</strong></td>
                            <td style="width: 100px">
                                <asp:Label ID="lblTotal" runat="server" Width="221px"></asp:Label></td>
                        </tr>
                    </table>
                    <br />
                    <br />
                    <asp:GridView ID="gvData" runat="server" BackColor="White" BorderColor="#999999"
                        BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" Height="83px"
                        Width="517px">
                        <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                        <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                        <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                        <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                        <AlternatingRowStyle BackColor="Gainsboro" />
                    </asp:GridView>
                </td>
            </tr>
        </table>
    </span>
</asp:Content>

