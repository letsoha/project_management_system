Imports System.Data.OleDb
Imports System.Data
Imports Microsoft.VisualBasic
Partial Class admin_Default2
    Inherits System.Web.UI.Page
    Dim Business As New BusinessClass
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim count As Integer
        Dim combo As New DataSet
        Dim dsData As New DataSet
        Dim result As String

        result = Business.GetConnection()
        If result = "true" Then
            'Load the combo Box
            combo = Business.FillComboBox()
            If Not IsPostBack Then
                For count = 0 To combo.Tables("AccCodes").Rows.Count - 1
                    dpdAccCode.Items.Add(combo.Tables("AccCodes").Rows(count).Item("AccountCodes") & " - " & combo.Tables("AccCodes").Rows(count).Item("Description"))
                Next count
            End If
        End If
    End Sub
    Protected Sub btnModifyAcc_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnModifyAcc.Click
        Dim Accounts As String
        Dim result As String
        Dim strAccCode As String

        result = Business.GetConnection()
        strAccCode = dpdAccCode.SelectedItem.ToString.Substring(0, 5)
        Accounts = Business.ModifyAcc(strAccCode, txtDescription.Text)
        If result <> "true" Then
            lblMsg.Text = "An error has occured in Connection."
        Else
            lblMsg.Text = "Account Number: " + strAccCode + ", has been successfully updated."
            Me.lblAccCode.Visible = False
            Me.dpdAccCode.Visible = False
            Me.lblDescr.Visible = False
            Me.txtDescription.Visible = False
            Me.btnModifyAcc.Visible = False
            Me.btnClear.Visible = False
        End If
    End Sub
End Class
