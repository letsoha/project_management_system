'UPDATING A RECORD
'File: ChangeAccessLevel.aspx.vb
'For: System Project
Imports System.Data.OleDb
Imports System.Data
Imports Microsoft.VisualBasic
Partial Class admin_Default2
    Inherits System.Web.UI.Page
    Dim Business As New BusinessClass
    Protected Sub btnUserAccess_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnUserAccess.Click
        Dim strconn As String
        Dim combo As New DataSet
        Dim dsData As New DataSet
        Dim result As String = ""
        strconn = Business.GetConnection()
        
        If strconn <> "true" Then
            Response.Write("Error in connection.")
        Else
            result = Business.ChangeAccess(txtUserid.Text, dpdAccess.SelectedItem.Value)
            If result <> "true" Then
                Response.Write("Error occured when updating User Access Type.")
            Else
                lblDisplay.Text = "User: " + txtUserid.Text + " access type has been changed to " + dpdAccess.SelectedItem.Text + "."
                Me.AccessInput.Visible = False
            End If
        End If
    End Sub
End Class
