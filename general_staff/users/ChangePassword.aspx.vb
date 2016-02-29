Imports System.Data
Imports System.Data.OleDb
Partial Class admin_Default2
    Inherits System.Web.UI.Page
    Dim Business As New BusinessClass
    Protected Sub btnChangePassword_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnChangePassword.Click
        Dim strconn As String
        Dim combo As New DataSet
        Dim dsData As New DataSet
        Dim result As String = ""

        strconn = Business.GetConnection()

        If strconn <> "true" Then
            Response.Write("Error in connection.")
        Else
            If txtPassword.Value <> txtConfirmPass.Value Then
                lblError.Text = "Passwords do not match."
                Return
            Else
                result = Business.ChangePassword(txtUserid.Text, txtPassword.Value)
                If result <> "true" Then
                    Response.Write("Error occured when updating User Password.")
                Else
                    lblError.Text = txtUserid.Text + "'s Password has been changed to '" + txtPassword.Value + "'."
                    Me.ChangePassTable.Visible = False
                End If
            End If
        End If
    End Sub
End Class
