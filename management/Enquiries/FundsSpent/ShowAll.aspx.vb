Imports System.Data.OleDb
Imports System.Data
Imports Microsoft.VisualBasic
Partial Class admin_Default2
    Inherits System.Web.UI.Page
    Dim Business As New BusinessClass
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim strConn As String = ""
        Dim dsFundsSpent As New DataSet
        Dim Amount As Single
        Dim count As Integer

        strConn = Business.GetConnection()
        
        If strConn <> "true" Then
            lblResults.Text = "There was an error in connection."
        Else
            If Not IsPostBack Then
                dsFundsSpent = Business.GetFundSpent()
                If dsFundsSpent.Tables("FundsSpent").Rows.Count > 0 Then
                    For count = 0 To dsFundsSpent.Tables("FundsSpent").Rows.Count - 1
                        Amount = dsFundsSpent.Tables("FundsSpent").Rows(count).Item("AmountSpent") + Amount
                    Next count
                    lblTotal.Text = "R " + Amount.ToString()
                    lblResults.Text = "Results found: " + dsFundsSpent.Tables("FundsSpent").Rows.Count.ToString() + "."
                    Me.gvData.DataSource = dsFundsSpent.Tables("FundsSpent")
                    Me.gvData.DataBind()
                Else
                    lblResults.Text = "No results found."
                End If

            End If
        End If
    End Sub
End Class
