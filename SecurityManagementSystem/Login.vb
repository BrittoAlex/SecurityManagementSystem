Imports Microsoft.VisualBasic.ApplicationServices
Imports System.Data.SqlClient

Public Class Login

    Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\britt\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\SecurityManagementSystem.mdf;Integrated Security=True;Connect Timeout=30;"
    Public user As String = ""
    Public loggedadmin As String = ""
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LoginBTN_Click(sender As Object, e As EventArgs) Handles LoginBTN.Click
        ' Login logic using database
        Dim username As String = Login_username.Text
        Dim password As String = Login_password.Text

        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()

                If (AdminCheck.Checked) Then
                    ' Checking if the admin is authenticated
                    Dim query As String = "SELECT COUNT(*) FROM Adminbase WHERE Adminusername = @Username AND Password = @Password;"
                    Using command As New SqlCommand(query, connection)
                        command.Parameters.AddWithValue("@Username", username)
                        command.Parameters.AddWithValue("@Password", password)

                        Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())

                        If count > 0 Then
                            ' User exists with the provided username and password
                            ' Proceed with login
                            loggedadmin = username
                            Me.Hide()
                            Admin.Show()
                        Else
                            MsgBox("Incorrect Credentials" + vbCrLf + username + vbCrLf + password)
                        End If
                    End Using

                Else
                    ' Checking if the end user is authenticated
                    Dim query As String = "SELECT COUNT(*) FROM Userbase WHERE Username = @Username AND Password = @Password"
                    Using command As New SqlCommand(query, connection)
                        command.Parameters.AddWithValue("@Username", username)
                        command.Parameters.AddWithValue("@Password", password)

                        Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())

                        If count > 0 Then
                            ' User exists with the provided username and password
                            ' Proceed with login
                            user = username
                            Me.Hide()
                            Security.Show()
                        Else
                            MsgBox("Incorrect Credentials" + vbCrLf + username + vbCrLf + password)
                        End If
                    End Using
                End If

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        SignUp.Show()
    End Sub
End Class