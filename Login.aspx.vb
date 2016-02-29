'Login code for Project
'File: Login.aspx.vb
Imports System.Data
Imports System.Data.OleDb
Partial Class _Default
    Inherits System.Web.UI.Page
    Dim Business As New BusinessClass
    'Friend Userid As String = txtUserID.Text
    Protected Sub btnLogin_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Dim ds As New DataSet
        Dim result As String
        Dim strUsername As String
        Dim strPassword As String
        Dim intLevel As Integer
        Dim LoginDate As Date
        Dim NewDate As Date

        result = Business.GetConnection()

        LoginDate = Date.Now()

        NewDate = Business.LogonDate(LoginDate, txtUserID.Text)

        ds = Business.GetUser(txtUserID.Text, Pass.Value)

        If result <> "true" Then
            Response.Write("Connection error")
        Else
            If ds.Tables("Users").Rows.Count = "0" Then
                lblWrongUser.Text = "Userid not found."
            Else
                strUsername = ds.Tables("Users").Rows(0).Item("Userid")
                strPassword = ds.Tables("Users").Rows(0).Item("Passwords")
                intLevel = ds.Tables("Users").Rows(0).Item("AccessLevel")
                If strUsername <> txtUserID.Text Then
                    If IsPostBack Then
                        lblWrongUser.Text = "Wrong Username entered."
                    Else
                        lblWrongUser.Text = ""
                    End If
                Else
                    If strPassword <> Pass.Value Then
                        lblWrongPass.Text = "Wrong Password entered."
                    Else
                        If intLevel = "0" Then
                            Response.Redirect("admin\default.aspx")
                        Else
                            If intLevel = "1" Then
                                Response.Redirect("management\default.aspx")
                            Else
                                If intLevel = "2" Then
                                    Response.Redirect("general_staff\default.aspx")
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub
End Class