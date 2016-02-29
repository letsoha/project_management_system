<%@ Page Language="VB" MasterPageFile="~/admin/MasterPage.master" AutoEventWireup="false" CodeFile="AddProject.aspx.vb" Inherits="admin_Default2" title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <span style="font-size: 0.8em; font-family: Verdana"><strong>ADD NEW PROJECT</strong></span><br />
    <br />
    <asp:Label ID="lblMsg" runat="server" Font-Names="Verdana" Font-Size="0.75em" ForeColor="Red"
        Width="652px"></asp:Label><br />
    <table style="width: 655px" id="TableNewProj" runat="server">
        <tr>
            <td style="width: 215px" align="right">
                <span style="font-size: 0.75em; font-family: Verdana">Title of the Project</span></td>
            <td style="width: 140px">
                <asp:TextBox ID="txtProjTitle" runat="server" Width="241px"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 215px; height: 26px" align="right">
                <span style="font-size: 0.75em; font-family: Verdana">Description of Project</span></td>
            <td style="width: 140px; height: 26px">
                <asp:TextBox ID="txtDescr" runat="server" Width="240px"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 215px" align="right">
                <span style="font-size: 0.75em; font-family: Verdana">Project Priority&nbsp; </span></td>
            <td style="width: 140px">
                <asp:DropDownList ID="dpdPriority" runat="server" Width="247px">
                    <asp:ListItem Enabled="False" Selected="True">-- Select --</asp:ListItem>
                    <asp:ListItem Value="1">Low</asp:ListItem>
                    <asp:ListItem Value="2">Medium</asp:ListItem>
                    <asp:ListItem Value="3">High</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td style="width: 215px" align="right">
                <span style="font-size: 0.75em; font-family: Verdana">Comments</span></td>
            <td style="width: 140px">
                <asp:TextBox ID="txtComments" runat="server" Width="241px"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 215px" align="right">
                <span style="font-size: 0.75em; font-family: Verdana">Select Responsible Member</span></td>
            <td style="width: 140px">
                <asp:DropDownList ID="dpdMembers" runat="server" Width="247px">
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td style="width: 215px" valign="top" align="right">
                <span style="font-size: 9pt; font-family: Verdana">Select Project Start Date</span></td>
            <td style="width: 140px">
                <asp:Calendar ID="StartDate" runat="server" BackColor="White" BorderColor="#3366CC"
                    BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" Font-Names="Verdana"
                    Font-Size="8pt" ForeColor="#003399" Height="147px" Width="248px">
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
            <td style="width: 215px" valign="top" align="right">
                <span style="font-size: 9pt; font-family: Verdana">Select Project Completion Date</span></td>
            <td style="width: 140px">
                <asp:Calendar ID="EndDate" runat="server" BackColor="White" BorderColor="#3366CC"
                    BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" Font-Names="Verdana"
                    Font-Size="8pt" ForeColor="#003399" Height="147px" Width="248px">
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
                <asp:Button ID="btnSave" runat="server" Font-Names="Verdana" Font-Size="0.65em" Text="Save"
                    Width="85px" /></td>
        </tr>
    </table>
</asp:Content>

