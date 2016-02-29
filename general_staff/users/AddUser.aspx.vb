'INSERT RECORD
'Add User
'File: AddUser.aspx.vb
Imports System.Data.OleDb
Imports System.Data
Imports Microsoft.VisualBasic
Partial Class admin_Default2
    Inherits System.Web.UI.Page
    Dim Business As New BusinessClass
    Protected Sub btnAddUser_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddUser.Click
        Dim strConn As String
        Dim result As String
        Dim dsUsers As New DataSet
        Dim strUsername As String

        strConn = Business.GetConnection()
        dsUsers = Business.GetUser(txtUserId.Text, txtPassword.Value)

        If strConn <> "true" Then
            lblDisplay.Text = "An error has occured in connection."
            Return
        Else
            If dsUsers.Tables("Users").Rows.Count <> 0 Then
                strUsername = dsUsers.Tables("Users").Rows(0).Item("Userid")
                If strUsername = txtUserId.Text Then
                    lblDisplay.Text = "User ID already exist."
                    Me.txtUserId.Text = ""
                End If
            End If
            result = Business.AddUser(txtUserId.Text, txtPassword.Value, dpdAccessLevel.SelectedItem.Value, txtName.Text, txtLastName.Text, txtAddress.Value, txtPhone.Text, txtMobile.Text, txtEmail.Text)
            If result <> "true" Then
                lblDisplay.Text = "Error has occured when adding New User."
                Return
            Else
                lblDisplay.Text = "Saved successfully. The new User has been successfully added."
                Me.AddUserControls.Visible = False
            End If
        End If
    End Sub
End Class
