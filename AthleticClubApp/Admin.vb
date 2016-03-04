Public Class Admin
    Private Sub frmAdmin_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.M AndAlso e.Modifiers = Keys.Alt) Then
            Form_Load()
            Me.KeyPreview = True
        End If

    End Sub
    Private Sub Form_Load() Handles Me.Load
        Try

            Dim sourcePath As String = "C:\Users\user\AthleticClubSystem\Athletes.txt"
            If System.IO.File.Exists(sourcePath) Then
                Dim members() As String = IO.File.ReadAllLines(sourcePath)
                For Each member As String In members
                    If Len(member) > 0 Then
                        Dim values() As String = member.Split(",")
                        If values.Length = 7 Then
                            ListBoxManAthletes.Items.Add(values(0) & " " & values(1) & " " & values(2) & " " & values(3) & " " & values(4) & " " & values(5) & " " & values(6))
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

        Try
            Dim sourcePath As String = "C:\Users\user\AthleticClubSystem\Events.txt"
            If System.IO.File.Exists(sourcePath) Then
                Dim races() As String = IO.File.ReadAllLines(sourcePath)
                For Each race As String In races
                    If Len(race) > 0 Then
                        Dim values() As String = race.Split(",")
                        If values.Length = 5 Then
                            ListBoxManEvents.Items.Add(values(0) & " " & values(1) & " " & values(2) & " " & values(3) & " " & values(4))
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
        a = MessageBox.Show("Are you sure you want to exit????", "Admin Form", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If a = vbYes Then
            Me.Close()
            searchForAthele.Show()
        Else

            Exit Sub
        End If
    End Sub

    Private Sub btnEditAthlete_Click(sender As Object, e As EventArgs) Handles btnEditAthlete.Click
        Try
            Dim currentMember As String = ListBoxManAthletes.SelectedItem
            Dim values() As String = currentMember.Split(" ")
            If values.Length = 7 Then

                Dim athleteForm As New Athlete
                athleteForm.member_no = values(0)
                athleteForm.txtName.Text = values(1)
                athleteForm.txtSurname.Text = values(2)
                athleteForm.DateTimePickerBD.Value = values(4)
                athleteForm.txtMFee.Text = values(5)
                athleteForm.DateTimePickerBD.Value = values(6)

                If values(3) = "Female" Then
                    athleteForm.rbnFemale.Checked = True
                ElseIf values(3) = "Male" Then
                    athleteForm.rbnMale.Checked = True
                End If

                athleteForm.btnSave.Visible = False
                athleteForm.btnUpdate.Visible = True
                athleteForm.Show()
                Me.Hide()
            End If
        Catch ex As NullReferenceException
            MsgBox("Please Select Athlete You Wish To Delete", MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub btnRemoveAthlete_Click(sender As Object, e As EventArgs) Handles btnRemoveAthlete.Click
        Dim a As Integer
        Dim count As Integer = 0
        Try
            Dim currentMember As String = ListBoxManAthletes.SelectedItem.ToString()

            a = MessageBox.Show("Are you sure you want to Delete????", "Admin Form", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If a = vbYes Then
                Dim values() As String = currentMember.Split(" ")
                If values.Length = 7 Then
                    Dim athletes As New List(Of String)(IO.File.ReadAllLines("C:\Users\user\AthleticClubSystem\Athletes.txt"))
                    For Each athlete As String In athletes
                        Dim vals() As String = athlete.Split(",")
                        If values(0) = vals(0) Then
                            athletes.RemoveAt(count)
                            Exit For
                        End If
                        count += 1
                    Next

                    IO.File.WriteAllLines("C:\Users\user\AthleticClubSystem\Athletes.txt", athletes.ToArray())
                    MessageBox.Show("Athlete has been removed", "Admin Form", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                    SearchForAthele.Show()
                End If
            Else
                Exit Sub
                Me.Refresh()
            End If
        Catch ex As NullReferenceException
            MsgBox("Please Select A Race You Wish To Delete", MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub btnEditEvent_Click(sender As Object, e As EventArgs) Handles btnEditEvent.Click
        Try
            Dim currentEvent As String = ListBoxManEvents.SelectedItem
            Dim values() As String = currentEvent.Split(" ")
            If values.Length = 5 Then
                Dim EventForm As New EventList
                EventForm.txtTitle.Text = Replace(values(0), "_", " ")
                EventForm.txtDistance.Text = Replace(values(1), "_", " ")
                EventForm.txtLoc.Text = Replace(values(2), "_", " ")
                EventForm.txtRegFee.Text = Replace(values(3), "_", " ")
                EventForm.DateTimePickerEvent.Value = Replace(values(4), "_", " ")

                EventForm.btnSave.Visible = False
                EventForm.btnUpdate.Visible = True
                EventForm.Show()
                Me.Hide()
            End If
        Catch ex As NullReferenceException
            MsgBox("Please Select A Race You Wish To Edit", MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub btnRemoveEvent_Click(sender As Object, e As EventArgs) Handles btnRemoveEvent.Click
        Dim a As Integer
        Dim count As Integer = 0
        Try
            Dim currentRace As String = ListBoxManEvents.SelectedItem.ToString()
            a = MessageBox.Show("Are you sure you want to Delete????", "Admin Form", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If a = vbYes Then
                Dim values() As String = currentRace.Split(" ")
                If values.Length = 5 Then
                    Dim races As New List(Of String)(IO.File.ReadAllLines("C:\Users\user\AthleticClubSystem\Events.txt"))
                    For Each race As String In races
                        Dim vals() As String = race.Split(",")
                        If values(0) = vals(0) Then
                            races.RemoveAt(count)
                            Exit For
                        End If
                        count += 1
                    Next

                    IO.File.WriteAllLines("C:\Users\user\AthleticClubSystem\Events.txt", races.ToArray())
                    MessageBox.Show("Race has been removed", "Admin Form", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                    SearchForAthele.Show()
                End If
            Else
                Exit Sub
                Me.Refresh()
            End If
        Catch ex As NullReferenceException
            MsgBox("Please Select A Race You Wish To Delete", MsgBoxStyle.OkOnly)
        End Try
    End Sub
End Class