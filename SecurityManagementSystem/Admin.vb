Imports System.Data.SqlClient

Public Class Admin

    Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\britt\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\SecurityManagementSystem.mdf;Integrated Security=True;Connect Timeout=30;"
    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AdminLabel.Text = Login.loggedadmin

        ' Fill security log
        Try
            Dim securityQuery As String = "SELECT * FROM Securitylog"
            logGRID.DataSource = getDataTable(securityQuery)

            ' Adjust the width of columns to fit their content
            For Each column As DataGridViewColumn In logGRID.Columns
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            Next
        Catch ex As Exception
            MsgBox("Error loading expense data: " & ex.Message)
        End Try

        ' Fill incident log
        Try
            Dim incidentQuery As String = "SELECT * FROM Incident"
            incGRID.DataSource = getDataTable(incidentQuery)

            ' Adjust the width of columns to fit their content
            For Each column As DataGridViewColumn In incGRID.Columns
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            Next
        Catch ex As Exception
            MsgBox("Error loading expense data: " & ex.Message)
        End Try
    End Sub

    Private Sub logoutBTN_Click(sender As Object, e As EventArgs) Handles logoutBTN.Click
        Me.Close()
        Login.Show()
    End Sub

    'to return tabel data
    Public Function getDataTable(query As String) As DataTable
        Dim dataTable As New DataTable()

        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Using command As New SqlCommand(query, connection)
                    Using adapter As New SqlDataAdapter(command)
                        adapter.Fill(dataTable)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error retrieving data: " & ex.Message)
        End Try

        Return dataTable
    End Function
End Class