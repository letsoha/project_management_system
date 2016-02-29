Imports System.Data.OleDb
Imports System.Data
Imports Microsoft.VisualBasic
Partial Class admin_Default2
    Inherits System.Web.UI.Page
    Dim Business As New BusinessClass
    Protected Sub btnAddMember_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddMember.Click
        Dim strConn As String
        Dim result As String = ""
        Dim dsMemberCodes As DataSet
        Dim NewMemberCode As String
        Dim strMemberCode As String
        Dim count As Integer

        strConn = Business.GetConnection()
        dsMemberCodes = Business.GetMemberCodes()
        For count = 0 To dsMemberCodes.Tables("MemberCodes").Rows.Count - 1
            strMemberCode = dsMemberCodes.Tables("MemberCodes").Rows(count).Item("MemberCode")
        Next count

        count = count - 1
        strMemberCode = dsMemberCodes.Tables("MemberCodes").Rows(count).Item("MemberCode").ToString.Substring(0, 5)
        strMemberCode = strMemberCode + 1

        If strMemberCode < 9 Then
            NewMemberCode = "M0000" + strMemberCode
            result = Business.AddNewMember(NewMemberCode, txtFName.Text, txtLName.Text, txtTitle.Text, txtAddress.Value, txtTelephone.Text, txtMobile.Text, txtEmail.Text)
        Else
            If strMemberCode > 9 And strMemberCode < 100 Then
                NewMemberCode = "M000" + strMemberCode
                result = Business.AddNewMember(NewMemberCode, txtFName.Text, txtLName.Text, txtTitle.Text, txtAddress.Value, txtTelephone.Text, txtMobile.Text, txtEmail.Text)
            Else
                If strMemberCode > 99 And strMemberCode < 1000 Then
                    NewMemberCode = "M00" + strMemberCode
                    result = Business.AddNewMember(NewMemberCode, txtFName.Text, txtLName.Text, txtTitle.Text, txtAddress.Value, txtTelephone.Text, txtMobile.Text, txtEmail.Text)
                Else
                    If strMemberCode > 999 And strMemberCode < 10000 Then
                        NewMemberCode = "M0" + strMemberCode
                        result = Business.AddNewMember(NewMemberCode, txtFName.Text, txtLName.Text, txtTitle.Text, txtAddress.Value, txtTelephone.Text, txtMobile.Text, txtEmail.Text)
                    Else
                        If strMemberCode > 9999 And strMemberCode < 100000 Then
                            NewMemberCode = "M" + strMemberCode
                            result = Business.AddNewMember(NewMemberCode, txtFName.Text, txtLName.Text, txtTitle.Text, txtAddress.Value, txtTelephone.Text, txtMobile.Text, txtEmail.Text)
                        Else
                            If strMemberCode > 999999 Then
                                lblMsg.Text = "The system has reached maximum number of Members that can be added to the database. Please contact your systems administrator for assistance."
                                Me.TblAddMemberControls.Visible = False
                            End If
                        End If
                    End If
                End If
            End If
        End If

        If strConn <> "true" Then
            lblMsg.Text = "An error has occured in connection."
            Me.TblAddMemberControls.Visible = False
            Return
        Else
            If result <> "true" Then
                lblMsg.Text = result
                Me.TblAddMemberControls.Visible = False
            Else
                lblMsg.Text = "New Member has been added successfully."
                Me.TblAddMemberControls.Visible = False
            End If
        End If
    End Sub
End Class
