Imports System.Data.OleDb
Imports System.Data
Imports Microsoft.VisualBasic
Partial Class admin_Default2
    Inherits System.Web.UI.Page
    Dim Business As New BusinessClass
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim strConn As String
        Dim result As String = ""
        Dim dsMembers As DataSet
        'Dim strMember As String
        'Dim Member As String
        'Dim MemberCode As String
        Dim count As Integer

        strConn = Business.GetConnection()
        dsMembers = Business.GetMemberDetails()

        If strConn <> "true" Then
            lblMsg.Text = "There was an error in connection."
        Else
            If Not IsPostBack Then
                For count = 0 To dsMembers.Tables("Members").Rows.Count - 1
                    dpdMembers.Items.Add(dsMembers.Tables("Members").Rows(count).Item("MemberCode") & " - " & dsMembers.Tables("Members").Rows(count).Item("FirstName") & " " & dsMembers.Tables("Members").Rows(count).Item("LastName"))
                Next count
            End If
        End If
    End Sub
    Protected Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim strConn As String = ""
        Dim NewProjCode As String
        Dim count As Integer
        Dim dsProjectCode As New DataSet
        Dim strProjCode As String
        Dim result As String = ""
        Dim dsMembers As DataSet
        Dim strMember As String
        Dim Member As String
        Dim MemberCode As String
        Dim countMembers As Integer

        strConn = Business.GetConnection()
        If strConn <> "true" Then
            lblMsg.Text = "There was an error in connection."
        Else
            dsProjectCode = Business.GetProjectCodeName()

            For count = 0 To dsProjectCode.Tables("Projects").Rows.Count - 1
                strProjCode = dsProjectCode.Tables("Projects").Rows(count).Item("ProjectCode")
            Next count
            count = count - 1

            strProjCode = dsProjectCode.Tables("Projects").Rows(count).Item("ProjectCode").ToString.Substring(3)
            NewProjCode = strProjCode + 1

            If NewProjCode < 10 Then
                NewProjCode = "PR0000000" + NewProjCode
            Else
                If NewProjCode > 10 And NewProjCode < 1000 Then
                    NewProjCode = "PR000000" + NewProjCode
                Else
                    If NewProjCode > 999 And NewProjCode < 10000 Then
                        NewProjCode = "PR00000" + NewProjCode
                    Else
                        If NewProjCode > 9999 And NewProjCode < 100000 Then
                            NewProjCode = "PR0000" + NewProjCode
                        Else
                            If NewProjCode > 99999 And NewProjCode < 1000000 Then
                                NewProjCode = "PR000" + NewProjCode
                            Else
                                If NewProjCode > 999999 And NewProjCode < 10000000 Then
                                    NewProjCode = "PR00" + NewProjCode
                                Else
                                    If NewProjCode >= 10000000 And NewProjCode < 100000000 Then
                                        NewProjCode = "PR0" + NewProjCode
                                    Else
                                        If NewProjCode > 1000000000 Then
                                            lblMsg.Text = "The database has reached maximum limit of Expenditure Numbers. Please contact your systemm administrator."
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If

            result = Business.AddNewProject(NewProjCode, txtProjTitle.Text, txtDescr.Text, dpdPriority.SelectedItem.Value, StartDate.SelectedDate, EndDate.SelectedDate, txtComments.Text, dpdMembers.SelectedItem.Text.Substring(9), dpdMembers.SelectedItem.Text.Substring(0, 6))
            If result <> "true" Then
                lblMsg.Text = result
            Else
                Me.TableNewProj.Visible = False
                lblMsg.Text = "Saved successfully."
            End If
        End If
    End Sub
End Class
