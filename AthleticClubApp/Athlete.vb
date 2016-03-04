Imports System.IO

Public Class Athlete

    Public member_no As String
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim searchForAthele As New SearchForAthele()
        Dim a As Integer
        a = MessageBox.Show("Are you sure you want to exit????", "Membership Registration", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If a = vbYes Then
            Me.Close()
            searchForAthele.Show()
        Else

            Exit Sub
        End If
    End Sub

    Private Function generate_membership_no(regYear As String, birthDate As String, randomValue As String)
        Dim result As String
        result = regYear & birthDate & randomValue

        Dim s = 0
        For var = 1 To Len(result)
            s += Mid(result, var, 1)
        Next var

        Dim q
        Dim d = s Mod 10

        If d = 0 Then
            q = 0
        Else
            q = (10 - d)
        End If

        Return result & q

    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim strFileName As String = "C:\Users\user\AthleticClubSystem\Athletes.txt"

        Dim membership_no As String
        Dim gender As String
        Dim regYear As String = Mid((DateTimePickerReg.Value.Year).ToString, 3, 2)
        Dim birthDate As String = Replace(Format(DateTimePickerBD.Value.Date, "yyyy-MM-dd"), "-", "")
        Dim randomValue As String = CInt(Math.Floor((999 - 0 + 1) * Rnd())) + 0
        membership_no = generate_membership_no(regYear, birthDate, randomValue)

        If rbnFemale.Checked = True Then
            gender = "Female"
        ElseIf rbnMale.Checked = True Then
            gender = "Male"
        End If

        Dim myStreamWriter As System.IO.StreamWriter

        If membership_no = "" Or txtName.Text = "" Or txtSurname.Text = "" Or txtMFee.Text = "" Or gender = "" Then
            MsgBox("Athlete Data is not completed", MsgBoxStyle.OkOnly)
        Else
            Try

                myStreamWriter = System.IO.File.AppendText(strFileName)
                myStreamWriter.Write(Environment.NewLine)
                myStreamWriter.Write(membership_no & ",")
                myStreamWriter.Write(txtName.Text & ",")
                myStreamWriter.Write(txtSurname.Text & ",")
                myStreamWriter.Write(gender & ",")
                myStreamWriter.Write(Format(DateTimePickerBD.Value.Date, "yyyy-MM-dd") & ",")
                myStreamWriter.Write(txtMFee.Text & ",")
                myStreamWriter.Write(Format(DateTimePickerReg.Value.Date, "yyyy-MM-dd"))
                myStreamWriter.Flush()
                myStreamWriter.Close()

                Dim searchForAthele As New SearchForAthele()
                MsgBox("Athlete has been successfully saved", MsgBoxStyle.OkOnly)
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
        Dim gender As String
        If gender = "Female" Then
            rbnFemale.Checked = True

        ElseIf gender = "Male" Then
            rbnMale.Checked = True

        End If
        If member_no = "" Then
            MsgBox("Athlete Data is not completed", MsgBoxStyle.OkOnly)
        Else
            Try

                Dim strFileName As String = "C:\Users\user\AthleticClubSystem\Athletes.txt"
                Dim lines = IO.File.ReadAllLines(strFileName)
                For i = 0 To lines.Length - 1
                    Dim line = lines(i)
                    Dim values = line.Split(","c)
                    If values.Length > 6 Then
                        Dim id = values(0)
                        If id = member_no Then
                            lines(i) = String.Format("{0},{1},{2},{3},{4},{5},{6}", member_no, txtName.Text, txtSurname.Text, gender, Format(DateTimePickerBD.Value.Date, "yyyy-MM-dd").ToString(), txtMFee.Text, Format(DateTimePickerReg.Value.Date, "yyyy-MM-dd").ToString())
                            Exit For
                        End If
                    End If
                Next
                IO.File.WriteAllLines(strFileName, lines)

                Dim searchForAthele As New SearchForAthele()
                MsgBox("Athlete has been successfully updated", MsgBoxStyle.OkOnly)
                member_no = ""
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
