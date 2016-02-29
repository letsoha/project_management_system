Imports System.Data.OleDb
Imports System.Data
Imports Microsoft.VisualBasic
Partial Class admin_Default2
    Inherits System.Web.UI.Page
    Dim Business As New BusinessClass
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim strConn As String = ""
        Dim dsProjects As New DataSet
        Dim dsFundsRec As New DataSet
        Dim count As Integer

        strConn = Business.GetConnection()
        dsProjects = Business.GetProjectCodeName()

        If strConn <> "true" Then
            lblMsg.Text = "There was an error in connection."
        Else
            If Not IsPostBack Then
                For count = 0 To dsProjects.Tables("Projects").Rows.Count - 1
                    dpdProjects.Items.Add(dsProjects.Tables("Projects").Rows(count).Item("ProjectCode") & " - " & dsProjects.Tables("Projects").Rows(count).Item("ProjectTitle"))
                Next
                dsFundsRec = Business.GetFundsRec()
                Me.gvData.DataSource = dsFundsRec.Tables("FundsReceived")
                Me.gvData.DataBind()
            End If
        End If
    End Sub
    Protected Sub btnSearchDate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSearchDate.Click
        Dim ds As New DataSet
        Dim result As String = "true"
        Dim count As Integer
        Dim Amount As Single

        result = Business.GetConnection()
        ds = Business.GetFundsRecByDate(DateFrom.SelectedDate, DateTo.SelectedDate)

        If result <> "true" Then
            Response.Write("An Error has occured, Connection has been broken")
        Else
            If ds.Tables("FundsReceived").Rows.Count < 1 Then
                lblResults.Text = "No results found."
                Me.gvData.Visible = False
                Me.Tabletotal.Visible = False
            Else
                lblResults.Text = "Results found: " + ds.Tables("FundsReceived").Rows.Count.ToString() + "."
                Me.gvData.DataSource = ds.Tables("FundsReceived")
                Me.gvData.DataBind()
                For count = 0 To ds.Tables("FundsReceived").Rows.Count - 1
                    Amount = Amount + ds.Tables("FundsReceived").Rows(count).Item("AmountReceived")
                Next count
                Me.Tabletotal.Visible = True
                lblTotal.Text = Amount
            End If
        End If
    End Sub
    Protected Sub gvData_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles gvData.PageIndexChanging
        Dim newPageIndex As Integer = e.NewPageIndex
        Dim result As String
        Dim ds As New DataSet

        gvData.PageIndex = newPageIndex
        result = Business.GetConnection()

        If result <> "true" Then
            Response.Write("Error in connection.")
        Else
            ds = Business.GetFundsRec()
            Me.gvData.DataSource = ds.Tables("FundsReceived")
            Me.gvData.DataBind()
        End If
    End Sub

    Protected Sub btnSearchBoth_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSearchBoth.Click
        Dim ds As New DataSet
        Dim result As String = "true"
        Dim count As Integer
        Dim Amount As Single

        result = Business.GetConnection()
        ds = Business.GetFundsRecByDateAndProject(DateFrom.SelectedDate, DateTo.SelectedDate, dpdProjects.SelectedItem.Text.Substring(0, 10))
        If result <> "true" Then
            lblMsg.Text = "An Error has occured, Connection has been broken"
        Else
            If ds.Tables("FundsReceived").Rows.Count < 1 Then
                lblResults.Text = "No results found."
                Me.gvData.Visible = False
                Me.Tabletotal.Visible = False
            Else
                lblResults.Text = "Results found: " + ds.Tables("FundsReceived").Rows.Count.ToString() + "."
                Me.gvData.Visible = True
                Me.gvData.DataSource = ds.Tables("FundsReceived")
                Me.gvData.DataBind()
                For count = 0 To ds.Tables("FundsReceived").Rows.Count - 1
                    Amount = Amount + ds.Tables("FundsReceived").Rows(count).Item("AmountReceived")
                Next count
                Me.Tabletotal.Visible = True
                lblTotal.Text = Amount
            End If
        End If
    End Sub
End Class
