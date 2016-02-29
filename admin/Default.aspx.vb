Imports System.Data.OleDb
Imports System.Data
Imports Microsoft.VisualBasic
Partial Class admin_Default
    Inherits System.Web.UI.Page
    Dim Business As New BusinessClass
    Friend Userid As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lblUserid.Text = Userid
    End Sub
End Class
