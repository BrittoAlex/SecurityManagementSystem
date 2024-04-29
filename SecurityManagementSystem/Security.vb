Imports System.Data.SqlClient

Public Class Security
    Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\britt\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\SecurityManagementSystem.mdf;Integrated Security=True;Connect Timeout=30;"
    Dim connection As New SqlConnection(connectionString)

    Private Sub Security_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserLabel.Text = Login.user
    End Sub

    Private Sub sectorBOX_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SectorBOX.SelectedIndexChanged
        ' Check sector availability
        Dim sector As String = SectorBOX.SelectedItem.ToString()
        Dim query As String = $"SELECT TOP 1 Securityname, Status FROM Securitylog WHERE Sector = '{sector}' ORDER BY ID DESC"
        Dim command As New SqlCommand(query, connection)
        connection.Open()
        Dim reader As SqlDataReader = command.ExecuteReader()
        If reader.Read() Then
            Dim securityname As String = reader("Securityname").ToString()
            Dim status As String = reader("Status").ToString()
            If status = "on duty" Then
                SectorLOG.Text = $"Sector {sector} is currently occupied."
            Else
                SectorLOG.Text = $"Sector {sector} is available."
            End If
        End If
        connection.Close()
    End Sub

    Private Sub statusBOX_SelectedIndexChanged(sender As Object, e As EventArgs) Handles StatusBOX.SelectedIndexChanged
        ' Log status change
        Dim dateTime As DateTime = DateTime.Now
        Dim formattedDateTime As String = dateTime.ToString("yyyy-MM-dd HH:mm:ss")
        Dim status As String = StatusBOX.SelectedItem.ToString()
        StatusLOG.AppendText($"{dateTime} | {status}{Environment.NewLine}")
    End Sub

    Private Sub UpdateBTN_Click(sender As Object, e As EventArgs) Handles UpdateBTN.Click
        ' Insert incident data into the database if incident groupbox has data
        If Not String.IsNullOrEmpty(BriefBOX.Text) AndAlso Not String.IsNullOrEmpty(DetailsBOX.Text) Then
            ' Insert incident data into the database
            Dim sector As String = INCsecBOX.SelectedItem.ToString()
            Dim incidentType As String = INCtypeBOX.SelectedItem.ToString()
            Dim brief As String = BriefBOX.Text
            Dim details As String = DetailsBOX.Text
            Dim dateTime As DateTime = DateTime.Now
            Dim formattedDateTime As String = dateTime.ToString("yyyy-MM-dd HH:mm:ss")
            Dim incusername As String = Login.user
            Dim incquery As String = "SELECT Securityname FROM userbase WHERE username = @username"
            Dim incname As String = sendQuery(incquery, "Securityname", incusername)

            Dim query As String = $"INSERT INTO Incident (Sector, IncidentDate, Username, Securityname, IncidentType, IncidentBrief, IncidentDetail) VALUES (@Sector, @IncidentDate, @Username, @Securityname, @IncidentType, @IncidentBrief, @IncidentDetail)"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@Sector", sector)
            command.Parameters.AddWithValue("@IncidentDate", dateTime)
            command.Parameters.AddWithValue("@Username", incusername)
            command.Parameters.AddWithValue("@Securityname", incname)
            command.Parameters.AddWithValue("@IncidentType", incidentType)
            command.Parameters.AddWithValue("@IncidentBrief", brief)
            command.Parameters.AddWithValue("@IncidentDetail", details)

            connection.Open()
            command.ExecuteNonQuery()
            connection.Close()

            LastUpdate.Text = formattedDateTime
            MessageBox.Show("Incident logged successfully.")
        End If

        ' Update security log
        If (SectorBOX.Text.Length > 0 And StatusBOX.Text.Length > 0) Then
            Try
                Dim selectedSector As String = SectorBOX.SelectedItem.ToString()
                Dim selectedStatus As String = StatusBOX.SelectedItem.ToString()
                Dim logDateTime As DateTime = DateTime.Now
                Dim formattedLogDateTime As String = logDateTime.ToString("yyyy-MM-dd HH:mm:ss")
                Dim logMessage As String = $"{formattedLogDateTime} | {selectedStatus}"
                Dim secusername As String = Login.user
                Dim secquery As String = "SELECT Securityname FROM userbase WHERE username = @username"
                Dim secname As String = sendQuery(secquery, "Securityname", secusername)

                ' Insert log data into the security log table
                Dim logQuery As String = $"INSERT INTO Securitylog (Username, Securityname, [Date], [Time], Sector, Status) VALUES (@Username, @Securityname, @Date, @Time, @Sector, @Status)"
                Dim logCommand As New SqlCommand(logQuery, connection)
                logCommand.Parameters.AddWithValue("@Username", secusername)
                logCommand.Parameters.AddWithValue("@Securityname", secname)
                logCommand.Parameters.AddWithValue("@Date", formattedLogDateTime)
                logCommand.Parameters.AddWithValue("@Time", formattedLogDateTime)
                logCommand.Parameters.AddWithValue("@Sector", selectedSector)
                logCommand.Parameters.AddWithValue("@Status", selectedStatus)

                connection.Open()
                logCommand.ExecuteNonQuery()
                connection.Close()

                ' Update label with the current time
                LastUpdate.Text = formattedLogDateTime

                MessageBox.Show("Security log updated successfully.")
            Catch ex As Exception
                MsgBox("One of the fields are empty")
            End Try
        Else
            MsgBox("fill all the sector and status section to proceed")
        End If
    End Sub


    ' Function to send queries and get required values for user details
    Public Function sendQuery(query As String, attrib As String, username As String) As String
        Dim value As String = ""
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@username", username)
                    Dim reader As SqlDataReader = command.ExecuteReader()

                    While reader.Read()
                        value = Convert.ToString(reader(attrib))
                        Return value
                    End While
                End Using
            Catch ex As Exception
                MessageBox.Show("Error executing query: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
        Return value
    End Function

    Private Sub LogoutBTN_Click(sender As Object, e As EventArgs) Handles LogoutBTN.Click
        Me.Hide()
        Login.Show()
    End Sub
End Class
