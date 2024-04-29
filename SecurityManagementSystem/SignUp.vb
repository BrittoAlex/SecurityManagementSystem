Imports System.Data.SqlClient

Public Class SignUp

    Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\britt\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\SecurityManagementSystem.mdf;Integrated Security=True;Connect Timeout=30;"

    Private Sub signupBTN_Click(sender As Object, e As EventArgs) Handles signupBTN.Click

        If (UsernameBOX.Text.Length > 0 AndAlso NameBOX.Text.Length > 0 AndAlso PasswordBOX.Text.Length >= 8) Then ' Check if password is at least 8 characters long
            ' Validate username and name
            If ValidateText(UsernameBOX.Text) AndAlso ValidateText(NameBOX.Text) Then
                Try
                    Using connection As New SqlConnection(connectionString)
                        connection.Open()

                        Dim query As String = "INSERT INTO [dbo].[Userbase] ([Username], [Securityname], [Password]) VALUES (@username, @name, @password)"

                        Using command As New SqlCommand(query, connection)
                            command.Parameters.AddWithValue("@username", UsernameBOX.Text)
                            command.Parameters.AddWithValue("@name", NameBOX.Text)
                            command.Parameters.AddWithValue("@password", PasswordBOX.Text)

                            Dim rowsAffected As Integer = command.ExecuteNonQuery()
                            If rowsAffected > 0 Then
                                MessageBox.Show("User successfully added to the database.")
                                Me.Close()
                                Login.Show()
                            Else
                                MessageBox.Show("Failed to add user to the database.")
                            End If
                        End Using
                    End Using

                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            Else
                MsgBox("Username and name should contain only letters.")
            End If
        Else
            MsgBox("Fill the values in all the fields and ensure that the password is at least 8 characters long.")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub SignUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PasswordBOX_TextChanged(sender As Object, e As EventArgs) Handles PasswordBOX.TextChanged

    End Sub

    Private Sub UsernameBOX_TextChanged(sender As Object, e As EventArgs) Handles UsernameBOX.TextChanged

    End Sub

    Private Sub NameBOX_TextChanged(sender As Object, e As EventArgs) Handles NameBOX.TextChanged

    End Sub

    Private Function ValidateText(text As String) As Boolean
        ' Validate that text contains only letters
        Return text.All(Function(c) Char.IsLetter(c))
    End Function
End Class