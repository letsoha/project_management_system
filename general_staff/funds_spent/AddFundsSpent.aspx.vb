Imports System.Data.OleDb
Imports System.Data
Imports Microsoft.VisualBasic
Partial Class admin_Default2
    Inherits System.Web.UI.Page
    Dim Business As New BusinessClass
    Protected Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim strConn As String = ""
        Dim NewExpNum As String
        Dim count As Integer
        Dim dsExpNum As DataSet
        Dim strExpNumber As String
        Dim result As String = ""
        
        strConn = Business.GetConnection()
        If strConn <> "true" Then
            lblMsg.Text = "There was an error in connection."
        Else
            dsExpNum = Business.GetFundsSpent()

            For count = 0 To dsExpNum.Tables("FundsSpent").Rows.Count - 1
                strExpNumber = dsExpNum.Tables("FundsSpent").Rows(count).Item("ExpenditureNumber")
            Next count
            count = count - 1

            strExpNumber = dsExpNum.Tables("FundsSpent").Rows(count).Item("ExpenditureNumber").ToString.Substring(3)
            NewExpNum = strExpNumber + 1

            If NewExpNum < 10 Then
                NewExpNum = "EX0000000" + NewExpNum
            Else
                If NewExpNum > 10 And NewExpNum < 1000 Then
                    NewExpNum = "EX000000" + NewExpNum
                Else
                    If NewExpNum > 999 And NewExpNum < 10000 Then
                        NewExpNum = "EX00000" + NewExpNum
                    Else
                        If NewExpNum > 9999 And NewExpNum < 100000 Then
                            NewExpNum = "EX0000" + NewExpNum
                        Else
                            If NewExpNum > 99999 And NewExpNum < 1000000 Then
                                NewExpNum = "EX000" + NewExpNum
                            Else
                                If NewExpNum > 999999 And NewExpNum < 10000000 Then
                                    NewExpNum = "EX00" + NewExpNum
                                Else
                                    If NewExpNum >= 10000000 And NewExpNum < 100000000 Then
                                        NewExpNum = "EX0" + NewExpNum
                                    Else
                                        If NewExpNum > 1000000000 Then
                                            lblMsg.Text = "The database has reached maximum limit of Expenditure Numbers. Please contact your systemm administrator."
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
            result = Business.AddFundsSpent(NewExpNum, DateSpent.SelectedDate, dpdAcc.SelectedItem.Text.Substring(0, 5), dpdProject.SelectedItem.Text.Substring(0, 10), txtOtherRef.Text, Val(txtAmountSpent.Text))
            If result <> "true" Then
                lblMsg.Text = result
            Else
                Me.FundsRecTblControls.Visible = False
                lblMsg.Text = "Saved successfully."
            End If
        End If
    End Sub
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim strConn As String
        Dim dsAccCodes As New DataSet
        Dim dsProjects As New DataSet
        Dim countAcc As Integer
        Dim countProjects As Integer

        strConn = Business.GetConnection()
        dsAccCodes = Business.GetAccCodes()
        dsProjects = Business.GetProjectCodeName()

        If strConn <> "true" Then
            lblMsg.Text = "There was an error in connection."
        Else
            If Not IsPostBack Then
                For countProjects = 0 To dsProjects.Tables("Projects").Rows.Count - 1
                    dpdProject.Items.Add(dsProjects.Tables("Projects").Rows(countProjects).Item("ProjectCode") & " - " & dsProjects.Tables("Projects").Rows(countProjects).Item("ProjectTitle"))
                Next countProjects

                For countAcc = 0 To dsAccCodes.Tables("AccountCodes").Rows.Count - 1
                    dpdAcc.Items.Add(dsAccCodes.Tables("AccountCodes").Rows(countAcc).Item("AccountCodes") & " - " & dsAccCodes.Tables("AccountCodes").Rows(countAcc).Item("Description"))
                Next countAcc
            End If
        End If
    End Sub
End Class
