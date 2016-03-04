Option Explicit On

Public Class SearchForAthele
    Private Sub Form_Load() Handles Me.Load
        Try

            Dim sourcePath As String = "C:\Users\user\AthleticClubSystem\Athletes.txt"
            If System.IO.File.Exists(sourcePath) Then
                Dim members() As String = IO.File.ReadAllLines(sourcePath)
                For Each member As String In members
                    If Len(member) > 0 Then
                        Dim values() As String = member.Split(",")
                        If values.Length = 7 Then
                            ListBoxAthletes.Items.Add(values(0) & " " & values(1) & " " & values(2))
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
    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        Me.Hide()
        Dim athleteForm As New Athlete()
        athleteForm.Show()

    End Sub

    Private Sub txtMembershipNoOnSearch_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMembershipNoOnSearch.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MsgBox("Please enter numbers only", MsgBoxStyle.OkOnly)
            e.Handled = True
        End If
    End Sub
    Private Function validate_membership_no(membership_no As String)

        Dim s = 0
        Dim result As Boolean = False

        If IsNumeric(membership_no) Then

            For var = 1 To Len(membership_no)
                s += Mid(membership_no, var, 1)
            Next var

            Dim d = s Mod 10

            If d = 0 Then
                result = True
            End If
        End If


        Return result

    End Function

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If validate_membership_no(txtMembershipNoOnSearch.Text) = True And
            Len(txtMembershipNoOnSearch.Text) = 14 Then

            Dim sourcePath As String = "C:\Users\user\AthleticClubSystem\Athletes.txt"
            If System.IO.File.Exists(sourcePath) Then
                Dim members() As String = IO.File.ReadAllLines(sourcePath)
                For Each member As String In members
                    If Len(member) > 0 Then
                        Dim values() As String = member.Split(",")
                        If values.Length = 7 Then
                            If values(0) = txtMembershipNoOnSearch.Text Then
                                GroupBoxMembers.Text = "Search Results"
                                ListBoxAthletes.Items.Clear()
                                ListBoxAthletes.Items.Add(values(0) & " " & values(1) & " " & values(2))
                            End If
                        End If
                    End If
                Next
            End If
        ElseIf txtMembershipNoOnSearch.Text = "" Then
            MsgBox("Please Enter a Membership Number", MsgBoxStyle.OkOnly)
        Else
            MsgBox("Membership Number is NOT VALID", MsgBoxStyle.OkOnly)
        End If


    End Sub

    Private Sub ListBoxAthletes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxAthletes.SelectedIndexChanged
        Dim currentMember As String = ListBoxAthletes.SelectedItem.ToString()
        Dim values() As String = currentMember.Split(" ")
        If values.Length = 3 Then
            Dim eventRecord As New AthleticEvent
            eventRecord.txtMSN.Text = values(0)

            eventRecord.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim searchForAthele As New SearchForAthele()
        Dim a As Integer
        a = MessageBox.Show("Are you sure you want to exit????", "Athletic Club System", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If a = vbYes Then
            Me.Close()
        Else

            Exit Sub
        End If
    End Sub

    Private Sub btnAddEvent_Click(sender As Object, e As EventArgs) Handles btnAddEvent.Click
        Me.Hide()
        Dim eventForm As New EventList()
        eventForm.Show()
    End Sub

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        Me.Hide()
        Dim eventAmin As New Admin()
        eventAmin.Show()
    End Sub
End Class