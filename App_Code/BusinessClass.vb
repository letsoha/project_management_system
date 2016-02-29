Imports Microsoft.VisualBasic
Imports System.Data.OleDb
Imports System.Data
Public Class BusinessClass
    Dim myConnection As New OleDbConnection
    Public Function GetConnection() As String
        Dim signal As String = "true"
        Try
            myConnection = New OleDbConnection("PROVIDER=Microsoft.Jet.OLEDB.4.0;DATA Source = C:\Documents and Settings\Owner\My Documents\Visual Studio 2005\WebSites\Project\App_Data\SystemDatabase.mdb")
            myConnection.Open()
        Catch ex As Exception
            signal = ex.Message.ToString()
        End Try
        Return signal
    End Function
    Public Function GetUser(ByVal Username As String, ByVal Passwords As String) As DataSet
        Dim sql As String
        Dim da As OleDb.OleDbDataAdapter
        Dim dsUsers As New DataSet

        If myConnection.State = ConnectionState.Closed Then
            myConnection.Open()
        End If

        sql = "SELECT * FROM Users WHERE (Userid = '" + Username + "' OR Passwords = '" + Passwords + "')"
        da = New OleDb.OleDbDataAdapter(sql, myConnection)
        da.Fill(dsUsers, "Users")

        If myConnection.State = ConnectionState.Open Then
            myConnection.Close()
        End If
        Return dsUsers
    End Function
    Public Function AddAcc(ByVal AccCode As String, ByVal Description As String, ByVal Comments As String) As String
        Dim sql As String
        Dim business As New BusinessClass
        Dim cmd As OleDb.OleDbCommand
        Dim result As String = "true"

        If myConnection.State = ConnectionState.Closed Then
            myConnection.Open()
        End If

        Try
            sql = "INSERT INTO Accounts (AccountCodes, Description, Comments) VALUES ('" + AccCode + "', '" + Description + "', '" + Comments + "')"
            cmd = New OleDbCommand(sql, myConnection)

            cmd.CommandText = sql
            cmd.ExecuteNonQuery() 'execute query
        Catch ex As Exception
            result = ex.Message.ToString()
        End Try

        If myConnection.State = ConnectionState.Open Then
            myConnection.Close()
        End If
        Return result
    End Function
    Public Function NewAcc() As DataSet
        Dim sql As String
        Dim dsAcc As New DataSet
        Dim da As New OleDb.OleDbDataAdapter

        If myConnection.State = ConnectionState.Closed Then
            myConnection.Open()
        End If

        sql = "SELECT * FROM Accounts"
        da = New OleDb.OleDbDataAdapter(sql, myConnection)
        da.Fill(dsAcc, "Accounts")

        If myConnection.State = ConnectionState.Open Then
            myConnection.Close()
        End If
        Return dsAcc
    End Function
    Public Function ModifyAcc(ByVal AccCode As String, ByVal Description As String) As String
        Dim sql As String
        Dim ds As New DataSet
        Dim cmd As OleDb.OleDbCommand
        Dim result As String = ""
        Try
            sql = "UPDATE Accounts SET Description = '" + Description + "' WHERE (AccountCodes = '" + AccCode + "')"
            cmd = New OleDb.OleDbCommand(sql, myConnection)
            If cmd.Connection.State = ConnectionState.Closed Then
                cmd.Connection.Open()
            End If
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
            If cmd.Connection.State = ConnectionState.Open Then
                cmd.Connection.Close()
            End If
            result = "true"
        Catch ex As Exception
            result = ex.Message.ToString()
        End Try
        Return result
    End Function
    Public Function FillComboBox() As DataSet
        Dim dsSales As New DataSet
        Dim da As New OleDb.OleDbDataAdapter
        Dim sql As String

        If myConnection.State = ConnectionState.Closed Then
            myConnection.Open()
        End If
        sql = "SELECT * FROM Accounts"
        da = New OleDb.OleDbDataAdapter(sql, myConnection)
        da.Fill(dsSales, "AccCodes")
        If myConnection.State = ConnectionState.Open Then
            myConnection.Close()
        End If
        Return dsSales
    End Function
    Public Function AddUser(ByVal UserId As String, ByVal Passwords As String, ByVal AccessLevel As String, ByVal Name As String, ByVal LastName As String, ByVal Address As String, ByVal Telephone As String, ByVal Mobile As String, ByVal Email As String) As String
        Dim sql As String
        Dim cmd As OleDb.OleDbCommand
        Dim result As String = "true"

        If myConnection.State = ConnectionState.Closed Then
            myConnection.Open()
        End If

        Try
            sql = "INSERT INTO Users (UserId, Passwords, AccessLevel, Name, LastName, Address, Telephone, MobileNumber, EmailAddress) VALUES ('" + UserId + "', '" + Passwords + "', '" + AccessLevel + "', '" + Name + "', '" + LastName + "', '" + Address + "', '" + Telephone + "', '" + Mobile + "', '" + Email + "')"
            cmd = New OleDbCommand(sql, myConnection)

            cmd.CommandText = sql
            cmd.ExecuteNonQuery() 'execute query

        Catch ex As Exception
            result = ex.Message.ToString()
        End Try

        If myConnection.State = ConnectionState.Open Then
            myConnection.Close()
        End If
        Return result
    End Function
    Public Function LogonDate(ByVal Dates As Date, ByVal Userid As String) As Date
        Dim sql As String
        Dim cmd As OleDb.OleDbCommand
        Dim result As Date

        If myConnection.State = ConnectionState.Closed Then
            myConnection.Open()
        End If

        Try
            sql = "UPDATE Users SET Dates = '" + Dates + "' WHERE (Userid = '" + Userid + "')"
            cmd = New OleDbCommand(sql, myConnection)

            cmd.CommandText = sql
            If myConnection.State = ConnectionState.Closed Then
                cmd.Connection.Open()
            End If
            cmd.ExecuteNonQuery() 'execute query

        Catch ex As Exception
            result = ex.Message.ToString()
        End Try
        result = Date.Now()
        If myConnection.State = ConnectionState.Open Then
            myConnection.Close()
        End If
        Return result
    End Function
    Public Function ChangeAccess(ByVal Userid As String, ByVal Access As String) As String
        Dim sql As String
        Dim cmd As OleDb.OleDbCommand
        Dim result As String = "true"
        Try
            sql = "UPDATE Users SET AccessLevel = '" + Access + "' WHERE (Userid = '" + Userid + "')"
            cmd = New OleDb.OleDbCommand(sql, myConnection)

            If cmd.Connection.State = ConnectionState.Closed Then
                cmd.Connection.Open()
            End If

            cmd.CommandText = sql
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            result = ex.Message.ToString()
        End Try
        Return result
    End Function
    Public Function UserLastLoginTime(ByVal Userid As String) As DataSet
        Dim sql As String
        Dim cmd As OleDb.OleDbCommand
        Dim dsUserDate As New DataSet
        Dim result As String = "true"

        If myConnection.State = ConnectionState.Closed Then
            myConnection.Open()
        End If

        Try
            sql = "SELECT Dates, Userid FROM Users WHERE (Userid = '" + Userid + "')"
            cmd = New OleDb.OleDbCommand(sql, myConnection)
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            result = ex.Message.ToString()
        End Try

        If myConnection.State = ConnectionState.Open Then
            myConnection.Close()
        End If
        Return dsUserDate
    End Function
    Public Function ChangePassword(ByVal Userid As String, ByVal Passwords As String) As String
        Dim sql As String
        Dim cmd As OleDb.OleDbCommand
        Dim result As String = "true"
        Try
            sql = "UPDATE Users SET Passwords = '" + Passwords + "' WHERE (Userid = '" + Userid + "')"
            cmd = New OleDb.OleDbCommand(sql, myConnection)

            If cmd.Connection.State = ConnectionState.Closed Then
                cmd.Connection.Open()
            End If

            cmd.CommandText = sql
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            result = ex.Message.ToString()
        End Try
        Return result
    End Function
    Public Function AddNewMember(ByVal MemberCode As String, ByVal FName As String, ByVal LName As String, ByVal Title As String, ByVal Address As String, ByVal Telephone As String, ByVal Mobile As String, ByVal Email As String) As String
        Dim sql As String
        Dim cmd As OleDb.OleDbCommand
        Dim result As String = "true"

        If myConnection.State = ConnectionState.Closed Then
            myConnection.Open()
        End If

        Try
            sql = "INSERT INTO Members (MemberCode, LastName, FirstName, Title, Address, TelephoneNumber, MobileNumber, EmailAddress) VALUES ('" + MemberCode + "', '" + LName + "', '" + FName + "', '" + Title + "', '" + Address + "', '" + Telephone + "', '" + Mobile + "', '" + Email + "')"
            cmd = New OleDbCommand(sql, myConnection)

            cmd.CommandText = sql
            cmd.ExecuteNonQuery() 'execute query

        Catch ex As Exception
            result = ex.Message.ToString()
        End Try

        If myConnection.State = ConnectionState.Open Then
            myConnection.Close()
        End If
        Return result
    End Function
    Public Function GetMemberDetails() As DataSet
        Dim sql As String
        Dim cmd As OleDb.OleDbCommand
        Dim dsMemberDetails As New DataSet
        Dim da As OleDb.OleDbDataAdapter
        Dim result As String = "true"

        If myConnection.State = ConnectionState.Closed Then
            myConnection.Open()
        End If

        Try
            sql = "SELECT * FROM Members ORDER BY MemberCode ASC"
            cmd = New OleDb.OleDbCommand(sql, myConnection)
            da = New OleDbDataAdapter(sql, myConnection)
            da.Fill(dsMemberDetails, "Members")

        Catch ex As Exception
            result = ex.Message.ToString()
        End Try

        If myConnection.State = ConnectionState.Open Then
            myConnection.Close()
        End If
        Return dsMemberDetails
    End Function
    Public Function ChangeMemberDetails(ByVal MemberCode As String, ByVal LastName As String, ByVal FirstName As String, ByVal Title As String, ByVal Address As String, ByVal TelNumber As String, ByVal MobileNumber As String, ByVal EmailAddress As String) As String
        Dim sql As String
        Dim cmd As OleDb.OleDbCommand
        Dim result As String = "true"

        Try
            sql = "UPDATE Members SET Members.MemberCode = '" + MemberCode + "', Members.LastName = '" + LastName + "', Members.FirstName = '" + FirstName + "', Members.Title = '" + Title + "', Members.Address = '" + Address + "', Members.TelephoneNumber = '" + TelNumber + "', Members.MobileNumber = '" + MobileNumber + "', Members.EmailAddress = '" + EmailAddress + "'  WHERE (MemberCode = '" + MemberCode + "')"
            cmd = New OleDb.OleDbCommand(sql, myConnection)

            If cmd.Connection.State = ConnectionState.Closed Then
                cmd.Connection.Open()
            End If

            cmd.CommandText = sql
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            result = ex.Message.ToString()
        End Try
        Return result
    End Function
    Public Function GetMemCodes(ByVal MemberCode As String) As DataSet
        Dim sql As String
        Dim cmd As OleDb.OleDbCommand
        Dim dsMemberCodes As New DataSet
        Dim da As OleDb.OleDbDataAdapter
        Dim result As String = "true"

        If myConnection.State = ConnectionState.Closed Then
            myConnection.Open()
        End If

        Try
            sql = "SELECT * FROM Members WHERE (MemberCode = '" + MemberCode + "')"
            cmd = New OleDb.OleDbCommand(sql, myConnection)
            da = New OleDbDataAdapter(sql, myConnection)
            da.Fill(dsMemberCodes, "MemberCodes")

        Catch ex As Exception
            result = ex.Message.ToString()
        End Try

        If myConnection.State = ConnectionState.Open Then
            myConnection.Close()
        End If
        Return dsMemberCodes
    End Function
    Public Function GetMemberCodes() As DataSet
        Dim sql As String
        Dim cmd As OleDb.OleDbCommand
        Dim dsMemberCodes As New DataSet
        Dim da As OleDb.OleDbDataAdapter
        Dim result As String = "true"

        If myConnection.State = ConnectionState.Closed Then
            myConnection.Open()
        End If

        Try
            sql = "SELECT Member Code FROM Members"
            cmd = New OleDb.OleDbCommand(sql, myConnection)
            da = New OleDbDataAdapter(sql, myConnection)
            da.Fill(dsMemberCodes, "MemberCodes")

        Catch ex As Exception
            result = ex.Message.ToString()
        End Try

        If myConnection.State = ConnectionState.Open Then
            myConnection.Close()
        End If
        Return dsMemberCodes
    End Function
    Public Function AddFundsReceived(ByVal ReceiptNumber As String, ByVal DateReceived As Date, ByVal Source As String, ByVal SourceRef As String, ByVal Project As String, ByVal AmntReceived As String) As String
        Dim sql As String
        Dim sqlUpdate As String
        Dim business As New BusinessClass
        Dim cmd As OleDb.OleDbCommand
        Dim result As String = "true"

        If myConnection.State = ConnectionState.Closed Then
            myConnection.Open()
        End If

        Try
            sql = "INSERT INTO FundsReceived (ReceiptNumber, Dates, Source, SourceReference, Project, AmountReceived) VALUES ('" + ReceiptNumber + "', '" + DateReceived + "', '" + Source + "', '" + SourceRef + "', '" + Project + "', '" + AmntReceived + "')"
            sqlUpdate = "UPDATE Projects SET ReceiptNumber = '" + ReceiptNumber + "' WHERE (ProjectCode = '" + Project + "')"
            cmd = New OleDbCommand(sql, myConnection)
            cmd.Parameters.Add(New OleDbParameter("@DateReceived", DateReceived))
            
            cmd.CommandText = sql
            cmd.CommandText = sqlUpdate
            cmd.ExecuteNonQuery() 'execute query

            If myConnection.State = ConnectionState.Open Then
                myConnection.Close()
            End If

        Catch ex As Exception
            result = ex.Message.ToString()
        End Try
        Return result
    End Function
    Public Function GetProjectCodeName() As DataSet
        Dim dsProjects As New DataSet
        Dim da As New OleDb.OleDbDataAdapter
        Dim sql As String

        If myConnection.State = ConnectionState.Closed Then
            myConnection.Open()
        End If
        sql = "SELECT * FROM Projects ORDER BY ProjectCode ASC"
        da = New OleDb.OleDbDataAdapter(sql, myConnection)
        da.Fill(dsProjects, "Projects")
        If myConnection.State = ConnectionState.Open Then
            myConnection.Close()
        End If
        Return dsProjects
    End Function
    Public Function GetReceiptNum() As DataSet
        Dim dsReceipts As New DataSet
        Dim da As New OleDb.OleDbDataAdapter
        Dim sql As String

        If myConnection.State = ConnectionState.Closed Then
            myConnection.Open()
        End If
        sql = "SELECT * FROM FundsReceived ORDER BY ReceiptNumber ASC"
        da = New OleDb.OleDbDataAdapter(sql, myConnection)
        da.Fill(dsReceipts, "ReceiptNum")
        If myConnection.State = ConnectionState.Open Then
            myConnection.Close()
        End If
        Return dsReceipts
    End Function
    Public Function GetFundsRec() As DataSet
        Dim sql As String
        Dim dsFundsRec As New DataSet
        Dim da As OleDb.OleDbDataAdapter
        Dim cmd As OleDb.OleDbCommand

        sql = "SELECT * FROM FundsReceived ORDER BY Dates DESC"
        cmd = New OleDb.OleDbCommand(sql, myConnection)
        
        If myConnection.State = ConnectionState.Closed Then
            myConnection.Open()
        End If
        da = New OleDb.OleDbDataAdapter(cmd)
        da.Fill(dsFundsRec, "FundsReceived")

        If myConnection.State = ConnectionState.Open Then
            myConnection.Close()
        End If
        Return dsFundsRec
    End Function
    Public Function GetFundsRecByDate(ByVal DateFrom As Date, ByVal DateTo As Date) As DataSet
        Dim sql As String
        Dim dsFundsRec As New DataSet
        Dim da As OleDb.OleDbDataAdapter
        Dim cmd As OleDb.OleDbCommand

        sql = "SELECT FundsReceived.Dates, Projects.ProjectTitle, FundsReceived.ReceiptNumber, FundsReceived.AmountReceived, FundsReceived.Source, FundsReceived.SourceReference FROM FundsReceived, Projects  WHERE (FundsReceived.Dates >= DateFrom AND FundsReceived.Dates <= DateTo) ORDER BY FundsReceived.Dates, Projects.ProjectTitle DESC"
        cmd = New OleDb.OleDbCommand(sql, myConnection)
        cmd.Parameters.Add(New OleDbParameter("@DateFrom", DateFrom))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@DateTo", DateTo))

        If cmd.Connection.State = ConnectionState.Closed Then
            cmd.Connection.Open()
        End If

        da = New OleDb.OleDbDataAdapter(cmd)
        da.Fill(dsFundsRec, "FundsReceived")
        If cmd.Connection.State = ConnectionState.Open Then
            cmd.Connection.Close()
        End If
        Return dsFundsRec
    End Function
    Public Function GetFundsRecByDateAndProject(ByVal DateFrom As Date, ByVal DateTo As Date, ByVal ProjectCode As String) As DataSet
        Dim sql As String
        Dim dsFundsRec As New DataSet
        Dim da As OleDb.OleDbDataAdapter
        Dim cmd As OleDb.OleDbCommand

        sql = "SELECT FundsReceived.Dates, Projects.ProjectTitle, FundsReceived.ReceiptNumber, FundsReceived.AmountReceived, FundsReceived.Source, FundsReceived.SourceReference FROM FundsReceived, Projects  WHERE (FundsReceived.Dates >= DateFrom AND FundsReceived.Dates <= DateTo AND Projects.ProjectCode = '" + ProjectCode + "') ORDER BY FundsReceived.Dates, Projects.ProjectTitle DESC"
        cmd = New OleDb.OleDbCommand(sql, myConnection)
        cmd.Parameters.Add(New OleDbParameter("@DateFrom", DateFrom))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@DateTo", DateTo))

        If myConnection.State = ConnectionState.Closed Then
            myConnection.Open()
        End If
        da = New OleDb.OleDbDataAdapter(cmd)
        da.Fill(dsFundsRec, "FundsReceived")

        If myConnection.State = ConnectionState.Open Then
            myConnection.Close()
        End If
        Return dsFundsRec
    End Function
    Public Function GetFundSpent() As DataSet
        Dim sql As String
        Dim dsSpent As New DataSet
        Dim da As OleDb.OleDbDataAdapter
        Dim cmd As OleDb.OleDbCommand

        sql = "SELECT * FROM FundsSpent ORDER BY DateSpent ASC"
        cmd = New OleDb.OleDbCommand(sql, myConnection)

        If myConnection.State = ConnectionState.Closed Then
            myConnection.Open()
        End If
        da = New OleDb.OleDbDataAdapter(cmd)
        da.Fill(dsSpent, "FundsSpent")

        If myConnection.State = ConnectionState.Open Then
            myConnection.Close()
        End If
        Return dsSpent
    End Function
    Public Function GetFundsSpentByDate(ByVal DateFrom As Date, ByVal DateTo As Date) As DataSet
        Dim sql As String
        Dim dsFundsSpent As New DataSet
        Dim da As OleDb.OleDbDataAdapter
        Dim cmd As OleDb.OleDbCommand

        sql = "SELECT FundsSpent.DateSpent, Projects.ProjectTitle, Accounts.Description, FundsSpent.ExpenditureNumber, FundsSpent.AmountSpent, FundsSpent.OtherReference FROM FundsSpent, Projects, Accounts  WHERE (FundsSpent.DateSpent >= " + DateFrom + " AND FundsSpent.DateSpent <= " + DateTo + ") ORDER BY FundsSpent.DateSpent DESC"
        cmd = New OleDb.OleDbCommand(sql, myConnection)
        cmd.Parameters.Add(New OleDbParameter("@DateFrom", DateFrom))
        cmd.Parameters.Add(New OleDb.OleDbParameter("@DateTo", DateTo))

        If cmd.Connection.State = ConnectionState.Closed Then
            cmd.Connection.Open()
        End If

        da = New OleDb.OleDbDataAdapter(cmd)
        cmd.CommandText = sql
        cmd.ExecuteNonQuery()

        da.Fill(dsFundsSpent, "FundsSpent")
        If cmd.Connection.State = ConnectionState.Open Then
            cmd.Connection.Close()
        End If
        Return dsFundsSpent
    End Function
    Public Function AddFundsSpent(ByVal ExpenditureNumber As String, ByVal DateSpent As Date, ByVal Account As String, ByVal Project As String, ByVal OtherRef As String, ByVal AmntSpent As String) As String
        Dim sql As String
        Dim sqlUpdate As String
        Dim business As New BusinessClass
        Dim cmd As OleDb.OleDbCommand
        Dim result As String = "true"

        If myConnection.State = ConnectionState.Closed Then
            myConnection.Open()
        End If

        Try
            sql = "INSERT INTO FundsSpent (ExpenditureNumber, DateSpent, Account, Project, OtherReference, AmountSpent) VALUES ('" + ExpenditureNumber + "', '" + DateSpent + "', '" + Account + "', '" + Project + "', '" + OtherRef + "', '" + AmntSpent + "')"
            sqlUpdate = "UPDATE Projects SET ExpenditureNumber = '" + ExpenditureNumber + "' WHERE (ProjectCode = '" + Project + "')"
            cmd = New OleDbCommand(sql, myConnection)
            cmd = New OleDbCommand(sqlUpdate, myConnection)
            cmd.Parameters.Add(New OleDbParameter("@DateSpent", DateSpent))

            cmd.CommandText = sql
            cmd.CommandText = sqlUpdate
            cmd.ExecuteNonQuery() 'execute query

            If myConnection.State = ConnectionState.Open Then
                myConnection.Close()
            End If

        Catch ex As Exception
            result = ex.Message.ToString()
        End Try

        Return result
    End Function
    Public Function GetFundsSpent() As DataSet
        Dim sql As String
        Dim dsFundsSpent As New DataSet
        Dim da As OleDb.OleDbDataAdapter
        Dim cmd As OleDb.OleDbCommand

        sql = "SELECT * FROM FundsSpent ORDER BY ExpenditureNumber ASC"
        cmd = New OleDb.OleDbCommand(sql, myConnection)

        If myConnection.State = ConnectionState.Closed Then
            myConnection.Open()
        End If
        da = New OleDb.OleDbDataAdapter(cmd)
        da.Fill(dsFundsSpent, "FundsSpent")

        If myConnection.State = ConnectionState.Open Then
            myConnection.Close()
        End If
        Return dsFundsSpent
    End Function
    Public Function GetAccCodes() As DataSet
        Dim sql As String
        Dim dsAccCodes As New DataSet
        Dim da As New OleDb.OleDbDataAdapter

        If myConnection.State = ConnectionState.Closed Then
            myConnection.Open()
        End If

        sql = "SELECT AccountCodes, Description FROM Accounts ORDER BY AccountCodes, Description"
        da = New OleDb.OleDbDataAdapter(sql, myConnection)
        da.Fill(dsAccCodes, "AccountCodes")

        If myConnection.State = ConnectionState.Open Then
            myConnection.Close()
        End If
        Return dsAccCodes
    End Function
    Public Function AddNewProject(ByVal ProjectCode As String, ByVal ProjectTitle As String, ByVal Description As String, ByVal Priority As String, ByVal StartDate As Date, ByVal CompletionDate As String, ByVal Comments As String, ByVal Member As String, ByVal MemberCode As String) As String
        Dim sql As String
        Dim cmd As OleDb.OleDbCommand
        Dim result As String = "true"

        If myConnection.State = ConnectionState.Closed Then
            myConnection.Open()
        End If

        Try
            sql = "INSERT INTO Projects (ProjectCode, ProjectTitle, Description, Priority, StartDate, CompletionDate, Comments, Member, MemberCode) VALUES ('" + ProjectCode + "', '" + ProjectTitle + "', '" + Description + "', '" + Priority + "', '" + StartDate + "', '" + CompletionDate + "', '" + Comments + "', '" + Member + "', '" + MemberCode + "')"
            cmd = New OleDbCommand(sql, myConnection)
            cmd.Parameters.Add(New OleDb.OleDbParameter("@StartDate", StartDate))
            cmd.Parameters.Add(New OleDb.OleDbParameter("@CompletionDate", CompletionDate))

            cmd.CommandText = sql
            cmd.ExecuteNonQuery() 'execute query

        Catch ex As Exception
            result = ex.Message.ToString()
        End Try

        If myConnection.State = ConnectionState.Open Then
            myConnection.Close()
        End If
        Return result
    End Function
End Class