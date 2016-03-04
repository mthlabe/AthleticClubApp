Public Class AthleticEvent
    Private Sub Form_Load() Handles Me.Load
        Try
            Dim sourcePath As String = "C:\Users\user\AthleticClubSystem\Events.txt"
            If System.IO.File.Exists(sourcePath) Then
                Dim races() As String = IO.File.ReadAllLines(sourcePath)
                For Each race As String In races
                    If Len(race) > 0 Then
                        Dim values() As String = race.Split(",")
                        If values.Length = 5 Then
                            ListBoxRaces.Items.Add(values(0))
                        End If
                    End If
                Next
            End If
        Catch ax As UnauthorizedAccessException
            MsgBox("ax: " & ax.ToString)
        Catch ix As IO.IOException
            MsgBox("ix: " & ix.ToString)
        Catch ex As Exception
            MsgBox("ex: " & ex.ToString)
        End Try

    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim searchForAthele As New SearchForAthele()
        Dim a As Integer
        a = MessageBox.Show("Are you sure you want to exit????", "Race Recording", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If a = vbYes Then
            Me.Close()
            searchForAthele.Show()
        Else

            Exit Sub
        End If
    End Sub

    Private Sub txtHours_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtHours.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MsgBox("Please enter numbers only", MsgBoxStyle.OkOnly)
            e.Handled = True
        End If

    End Sub

    Private Sub txtMinutes_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMinutes.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MsgBox("Please enter numbers only", MsgBoxStyle.OkOnly)
            e.Handled = True
        End If
    End Sub

    Private Sub txtSeconds_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSeconds.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MsgBox("Please enter numbers only", MsgBoxStyle.OkOnly)
            e.Handled = True
        End If
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim strFileName As String = "C:\Users\user\AthleticClubSystem\RaceRecords.txt"

        Dim currentEvent As String = ListBoxRaces.SelectedItem
        Dim hours As String = txtHours.Text
        Dim minutes As String = txtMinutes.Text
        Dim seconds As String = txtSeconds.Text

        Dim finish_time As String

        Dim myStreamWriter As System.IO.StreamWriter

        If hours = "" Or minutes = "" Or seconds = "" Or currentEvent = "" Then
            MsgBox("Athlete Race Record is not completed", MsgBoxStyle.OkOnly)
        Else
            finish_time = hours & ":" & minutes & ":" & seconds
            Try

                myStreamWriter = System.IO.File.AppendText(strFileName)

                myStreamWriter.Write(Environment.NewLine)
                myStreamWriter.Write(txtMSN.Text & ",")
                myStreamWriter.Write(currentEvent & ",")
                myStreamWriter.Write(finish_time)

                myStreamWriter.Flush()
                myStreamWriter.Close()

                Dim searchForAthele As New SearchForAthele()
                MsgBox("Athlete Race Record has been successfully saved", MsgBoxStyle.OkOnly)
                Me.Close()
                searchForAthele.Show()

            Catch ax As UnauthorizedAccessException
                MsgBox("ax: " & ax.ToString)
            Catch ix As IO.IOException
                MsgBox("ix: " & ix.ToString)
            Catch ex As Exception
                MsgBox("ex: " & ex.ToString)
            End Try
        End If
    End Sub

End Class