Imports System.Data.OleDb
Imports System.Data
Imports Microsoft.VisualBasic
Partial Class admin_Default2
    Inherits System.Web.UI.Page
    Dim Business As New BusinessClass
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim strConn As String = ""
        Dim dsFundsSpent As New DataSet
        
        strConn = Business.GetConnection()
        dsFundsSpent = Business.GetFundsSpent()

        If strConn <> "true" Then
            lblMsg.Text = "There was an error in connection."
        Else
            If dsFundsSpent.Tables("FundsSpent").Rows.Count < 1 Then
                lblResults.Text = "No results found."
                Me.gvData.Visible = False
                Me.TableTotalSpent.Visible = False
            Else
                If Not IsPostBack Then
                    Me.TableTotalSpent.Visible = True
                    Me.gvData.Visible = True
                    Me.gvData.DataSource = dsFundsSpent
                    Me.gvData.DataBind()
                End If
            End If
        End If
    End Sub
    Protected Sub btnSearchByDate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSearchByDate.Click
        Dim strConn As String = ""
        Dim ds As New DataSet
        Dim count As Integer
        Dim Amount As Single

        strConn = Business.GetConnection()
        ds = Business.GetFundsSpentByDate(DateFrom.SelectedDate, DateTo.SelectedDate)
        
        If strConn <> "true" Then
            lblMsg.Text = "There was an error in connection."
        Else
            If ds.Tables("FundsSpent").Rows.Count < 1 Then
                lblResults.Text = "No results found."
                Me.gvData.Visible = False
                Me.TableTotalSpent.Visible = False
            Else
                For count = 0 To ds.Tables("FundsSpent").Rows.Count - 1
                    Amount = Amount + ds.Tables("FundsSpent").Rows(count).Item("AmountSpent")
                Next count

                Me.TableTotalSpent.Visible = True
                Me.gvData.Visible = True
                Me.gvData.DataSource = ds
                Me.gvData.DataBind()
                lblTotalSpent.Text = Amount
            End If
        End If
    End Sub
End Class
