Imports System.Data
Imports System.Data.OleDb
Partial Class admin_Default2
    Inherits System.Web.UI.Page
    Dim Business As New BusinessClass
    Dim LName As String
    Dim FName As String
    Shadows Title As String
    Dim Address As String
    Dim Telephone As String
    Dim Mobile As String
    Dim Email As String
    Protected Sub btnChangeMember_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnChangeMember.Click
        Dim strConn As String
        Dim dsMemberDetails As New DataSet
        Dim result As String
        
        strConn = Business.GetConnection()
        If strConn <> "true" Then
            lblMsg.Text = "There was an error in connection, please contact your system administrator."
        Else
            
            LName = txtLName.Text
            FName = txtFName.Text
            Title = txtTitle.Text
            Address = txtAddress.Value
            Telephone = txtTelephone.Text
            Mobile = txtMobile.Text
            Email = txtEmail.Text

            result = Business.ChangeMemberDetails(dpdMemberCode.SelectedItem.Text.Substring(0, 6), LName, FName, Title, Address, Telephone, Mobile, Email)

            If result <> "true" Then
                lblMsg.Text = "Error while updating Member information."
            Else
                Me.tableMemCodes.Visible = False
                Me.TblAddMemberControls.Visible = False
                lblMsg.Text = "Member details changed successfully."
            End If
        End If
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim count As Integer
        Dim dsMemberDetails As New DataSet
        Dim dsData As New DataSet
        Dim result As String

        result = Business.GetConnection()
        If result = "true" Then
            'Load the combo Box and text boxes
            dsMemberDetails = Business.GetMemberDetails()
            If Not IsPostBack Then
                For count = 0 To dsMemberDetails.Tables("Members").Rows.Count - 1
                    dpdMemberCode.Items.Add(dsMemberDetails.Tables("Members").Rows(count).Item("MemberCode") & " - " & dsMemberDetails.Tables("Members").Rows(count).Item("LastName") & " " & dsMemberDetails.Tables("Members").Rows(count).Item("FirstName"))
                Next count
                Me.tableMemCodes.Visible = True
                Me.TblAddMemberControls.Visible = False
            End If
        End If
    End Sub
    Protected Sub btnMemDetails_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMemDetails.Click
        Dim dsMemCode As New DataSet
        Dim dsMemDetails As New DataSet
        Dim strConn As String
        
        strConn = Business.GetConnection()
        If strConn <> "true" Then
            lblMsg.Text = "There was an error in connection. Please try again or contact your system administrator."
            Me.tableMemCodes.Visible = False
            Me.TblAddMemberControls.Visible = False
        Else
            Me.tableMemCodes.Visible = False
            Me.TblAddMemberControls.Visible = True
            dsMemCode = Business.GetMemCodes(dpdMemberCode.SelectedItem.Text.Substring(0, 6))

            If dsMemCode.Tables("MemberCodes").Rows.Count < 1 Then
                lblMsg.Text = "No such record found. Contact your System Administrator."
            Else
                txtLName.Text = dsMemCode.Tables("MemberCodes").Rows(0).Item("LastName")
                txtFName.Text = dsMemCode.Tables("MemberCodes").Rows(0).Item("FirstName")
                txtTitle.Text = dsMemCode.Tables("MemberCodes").Rows(0).Item("Title")
                txtAddress.Value = dsMemCode.Tables("MemberCodes").Rows(0).Item("Address")
                txtTelephone.Text = dsMemCode.Tables("MemberCodes").Rows(0).Item("TelephoneNumber")
                txtMobile.Text = dsMemCode.Tables("MemberCodes").Rows(0).Item("MobileNumber")
                txtEmail.Text = dsMemCode.Tables("MemberCodes").Rows(0).Item("EmailAddress")

                lblMsg.Text = "Modify details of preference."

                Me.tableMemCodes.Visible = False
                Me.TblAddMemberControls.Visible = True
            End If
        End If
    End Sub
End Class
