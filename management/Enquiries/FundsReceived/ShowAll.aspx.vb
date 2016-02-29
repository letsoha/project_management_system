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
        Dim Total As Single
        Dim Amount As Single
        Dim count As Integer

        strConn = Business.GetConnection()
        dsProjects = Business.GetProjectCodeName()

        If strConn <> "true" Then
            lblResults.Text = "There was an error in connection."
        Else
            If Not IsPostBack Then
                dsFundsRec = Business.GetFundsRec()
                If dsFundsRec.Tables("FundsReceived").Rows.Count < 1 Then
                    lblResults.Text = "No results found."
                Else
                    For count = 0 To dsFundsRec.Tables("FundsReceived").Rows.Count - 1
                        Amount = dsFundsRec.Tables("FundsReceived").Rows(count).Item("AmountReceived") + Amount
                    Next count
                    lblResults.Text = "Results found: " + dsFundsRec.Tables("FundsReceived").Rows.Count.ToString() + "."
                    lblTotal.Text = Amount
                    Me.gvData.DataSource = dsFundsRec.Tables("FundsReceived")
                    Me.gvData.DataBind()
                End If
            End If
        End If
    End Sub
End Class
