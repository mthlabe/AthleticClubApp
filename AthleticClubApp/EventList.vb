Public Class EventList

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim searchForAthele As New SearchForAthele()
        Dim a As Integer
        a = MessageBox.Show("Are you sure you want to exit????", "Add New Race", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If a = vbYes Then
            Me.Close()
            searchForAthele.Show()
        Else

            Exit Sub
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim strFileName As String = "C:\Users\user\AthleticClubSystem\Events.txt"

        Dim myStreamWriter As System.IO.StreamWriter

        If txtTitle.Text = "" Or txtDistance.Text = "" Or txtLoc.Text = "" Or txtRegFee.Text = "" Then
            MsgBox("Event Data is not completed", MsgBoxStyle.OkOnly)
        Else
            Try

                myStreamWriter = System.IO.File.AppendText(strFileName)
                myStreamWriter.Write(Environment.NewLine)
                myStreamWriter.Write(Replace(txtTitle.Text, " ", "_") & ",")
                myStreamWriter.Write(Replace(txtDistance.Text, " ", "_") & ",")
                myStreamWriter.Write(Replace(txtLoc.Text, " ", "_") & ",")
                myStreamWriter.Write(Replace(txtRegFee.Text, " ", "_") & ",")
                myStreamWriter.Write(Format(DateTimePickerEvent.Value.Date, "yyyy-MM-dd"))
                myStreamWriter.Flush()
                myStreamWriter.Close()

                Dim searchForAthele As New SearchForAthele()
                MsgBox("Event has been successfully saved", MsgBoxStyle.OkOnly)
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

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If txtTitle.Text = "" Or txtDistance.Text = "" Or txtLoc.Text = "" Or txtRegFee.Text = "" Then
            MsgBox("Event Data is not completed", MsgBoxStyle.OkOnly)
        Else
            Try

                Dim strFileName As String = "C:\Users\user\AthleticClubSystem\Events.txt"
                Dim lines = IO.File.ReadAllLines(strFileName)
                For i = 0 To lines.Length - 1
                    Dim line = lines(i)
                    Dim values = line.Split(","c)
                    If values.Length > 6 Then
                        Dim id = values(0)
                        If id = txtTitle.Text Then
                            lines(i) = String.Format("{0},{1},{2},{3},{4}", txtTitle.Text, txtDistance.Text, txtLoc.Text, txtRegFee.Text, Format(DateTimePickerEvent.Value.Date, "yyyy-MM-dd").ToString())
                            Exit For
                        End If
                    End If
                Next
                IO.File.WriteAllLines(strFileName, lines)

                Dim searchForAthele As New SearchForAthele()
                MsgBox("Race has been successfully updated", MsgBoxStyle.OkOnly)
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