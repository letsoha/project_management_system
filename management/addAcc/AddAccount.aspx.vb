Imports Microsoft.VisualBasic
Imports System.Data.OleDb
Imports System.Data
Partial Class admin_Default2
    Inherits System.Web.UI.Page
    Dim Business As New BusinessClass
    Protected Sub btnOk_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Dim Business As New BusinessClass
        Dim dsAcc As New DataSet
        Dim strConn As String
        Dim result As String
        Dim count As Integer
        Dim AccCode As String = ""
        strConn = Business.GetConnection()
        If strConn <> "true" Then
            lblDisplay.Text = "Error has occured in connection."
            Return
        Else
            dsAcc = Business.NewAcc()
            For count = 0 To dsAcc.Tables("Accounts").Rows.Count() - 1
                AccCode = dsAcc.Tables("Accounts").Rows(count).Item("AccountCodes").ToString().Substring(2, 3)
            Next count
            AccCode = AccCode + 1
            If AccCode < 9 Then
                AccCode = "AC00" + AccCode
            Else
                If AccCode > 99 And AccCode < 100 Then
                    AccCode = "AC" + AccCode
                Else
                    If AccCode > 999 Then
                        lblDisplay.Text = "Maximum number of Accounts to be added to the database has been reached. Please contact your system administrator for assistance."
                        Me.lblDesc.Visible = False
                        Me.lblComment.Visible = False
                        Me.btnOk.Visible = False
                        Me.btnCancel.Visible = False
                        Me.txtDescr.Visible = False
                        Me.textComments.Visible = False
                    End If
                End If
            End If
            result = Business.AddAcc(AccCode, txtDescr.Text, textComments.Value)
        End If

        If result <> "true" Then
            lblDisplay.Text = "Error has occured when adding New Account."
            Return
        Else
            lblDisplay.Text = "Saved successfully. The new Account has been successfully added"
            Me.lblDesc.Visible = False
            Me.lblComment.Visible = False
            Me.btnOk.Visible = False
            Me.btnCancel.Visible = False
            Me.txtDescr.Visible = False
            Me.textComments.Visible = False
        End If
    End Sub
End Class
