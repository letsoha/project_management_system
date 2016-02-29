Imports System.Data.OleDb
Imports System.Data
Imports Microsoft.VisualBasic
Partial Class admin_Default2
    Inherits System.Web.UI.Page
    Dim Business As New BusinessClass
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim strConn As String = ""
        Dim dsProjects As New DataSet
        Dim count As Integer

        strConn = Business.GetConnection()
        dsProjects = Business.GetProjectCodeName()

        If strConn <> "true" Then
            lblMsg.Text = "There was an error in connection."
        Else
            If Not IsPostBack Then
                For count = 0 To dsProjects.Tables("Projects").Rows.Count - 1
                    dpdProject.Items.Add(dsProjects.Tables("Projects").Rows(count).Item("ProjectCode") & " - " & dsProjects.Tables("Projects").Rows(count).Item("ProjectTitle"))
                Next
            End If
        End If
    End Sub
    Protected Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim strConn As String = ""
        Dim NewRcptNum As String
        Dim count As Integer
        Dim dsReceiptNum As DataSet
        Dim strReceipt As String
        Dim result As String = ""
        Dim CurrentDate As Date

        strConn = Business.GetConnection()
        If strConn <> "true" Then
            lblMsg.Text = "There was an error in connection."
        Else
            dsReceiptNum = Business.GetReceiptNum()

            For count = 0 To dsReceiptNum.Tables("ReceiptNum").Rows.Count - 1
                strReceipt = dsReceiptNum.Tables("ReceiptNum").Rows(count).Item("ReceiptNumber")
            Next count
            count = count - 1

            strReceipt = dsReceiptNum.Tables("ReceiptNum").Rows(count).Item("ReceiptNumber").ToString.Substring(2)
            NewRcptNum = strReceipt + 1

            If NewRcptNum < 10 Then
                NewRcptNum = "R00000000" + NewRcptNum
            Else
                If NewRcptNum > 10 And NewRcptNum < 1000 Then
                    NewRcptNum = "R0000000" + NewRcptNum
                Else
                    If NewRcptNum > 999 And NewRcptNum < 10000 Then
                        NewRcptNum = "R000000" + NewRcptNum
                    Else
                        If NewRcptNum > 9999 And NewRcptNum < 100000 Then
                            NewRcptNum = "R00000" + NewRcptNum
                        Else
                            If NewRcptNum > 99999 And NewRcptNum < 1000000 Then
                                NewRcptNum = "R0000" + NewRcptNum
                            Else
                                If NewRcptNum > 999999 And NewRcptNum < 10000000 Then
                                    NewRcptNum = "R000" + NewRcptNum
                                Else
                                    If NewRcptNum >= 10000000 And NewRcptNum < 100000000 Then
                                        NewRcptNum = "R00" + NewRcptNum
                                    Else
                                        If NewRcptNum >= 100000000 And NewRcptNum < 1000000000 Then
                                            NewRcptNum = "R0" + NewRcptNum
                                        Else
                                            If NewRcptNum > 1000000000 Then
                                                lblMsg.Text = "The database has reached maximum limit of Receipt Numbers."
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
            CurrentDate = Date.Now()
            result = Business.AddFundsReceived(NewRcptNum, CurrentDate, txtSource.Text, txtSourceRef.Text, dpdProject.SelectedItem.Text.Substring(0, 10), Val(txtAmount.Text))
            If result <> "true" Then
                lblMsg.Text = result
            Else
                Me.FundsRecTblControls.Visible = False
                lblMsg.Text = "Saved successfully."
            End If
        End If
    End Sub
End Class
