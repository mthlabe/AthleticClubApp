<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Athlete
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblSurname = New System.Windows.Forms.Label()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.gboxGender = New System.Windows.Forms.GroupBox()
        Me.rbnMale = New System.Windows.Forms.RadioButton()
        Me.rbnFemale = New System.Windows.Forms.RadioButton()
        Me.lblBirthDate = New System.Windows.Forms.Label()
        Me.DateTimePickerBD = New System.Windows.Forms.DateTimePicker()
        Me.gbMFee = New System.Windows.Forms.GroupBox()
        Me.DateTimePickerReg = New System.Windows.Forms.DateTimePicker()
        Me.lblJinedDate = New System.Windows.Forms.Label()
        Me.txtMFee = New System.Windows.Forms.TextBox()
        Me.lblMFee = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.gboxGender.SuspendLayout()
        Me.gbMFee.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(45, 44)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(55, 20)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(106, 42)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(204, 22)
        Me.txtName.TabIndex = 1
        '
        'lblSurname
        '
        Me.lblSurname.AutoSize = True
        Me.lblSurname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSurname.Location = New System.Drawing.Point(441, 46)
        Me.lblSurname.Name = "lblSurname"
        Me.lblSurname.Size = New System.Drawing.Size(81, 20)
        Me.lblSurname.TabIndex = 2
        Me.lblSurname.Text = "Surname"
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(548, 43)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(237, 22)
        Me.txtSurname.TabIndex = 3
        '
        'gboxGender
        '
        Me.gboxGender.Controls.Add(Me.rbnMale)
        Me.gboxGender.Controls.Add(Me.rbnFemale)
        Me.gboxGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboxGender.Location = New System.Drawing.Point(49, 101)
        Me.gboxGender.Name = "gboxGender"
        Me.gboxGender.Size = New System.Drawing.Size(175, 115)
        Me.gboxGender.TabIndex = 4
        Me.gboxGender.TabStop = False
        Me.gboxGender.Text = "Gender"
        '
        'rbnMale
        '
        Me.rbnMale.AutoSize = True
        Me.rbnMale.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbnMale.Location = New System.Drawing.Point(19, 69)
        Me.rbnMale.Name = "rbnMale"
        Me.rbnMale.Size = New System.Drawing.Size(59, 21)
        Me.rbnMale.TabIndex = 1
        Me.rbnMale.TabStop = True
        Me.rbnMale.Text = "Male"
        Me.rbnMale.UseVisualStyleBackColor = True
        '
        'rbnFemale
        '
        Me.rbnFemale.AutoSize = True
        Me.rbnFemale.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbnFemale.Location = New System.Drawing.Point(19, 38)
        Me.rbnFemale.Name = "rbnFemale"
        Me.rbnFemale.Size = New System.Drawing.Size(75, 21)
        Me.rbnFemale.TabIndex = 0
        Me.rbnFemale.TabStop = True
        Me.rbnFemale.Text = "Female"
        Me.rbnFemale.UseVisualStyleBackColor = True
        '
        'lblBirthDate
        '
        Me.lblBirthDate.AutoSize = True
        Me.lblBirthDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBirthDate.Location = New System.Drawing.Point(45, 261)
        Me.lblBirthDate.Name = "lblBirthDate"
        Me.lblBirthDate.Size = New System.Drawing.Size(115, 20)
        Me.lblBirthDate.TabIndex = 5
        Me.lblBirthDate.Text = "Date Of Birth"
        '
        'DateTimePickerBD
        '
        Me.DateTimePickerBD.CustomFormat = ""
        Me.DateTimePickerBD.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerBD.Location = New System.Drawing.Point(203, 259)
        Me.DateTimePickerBD.Name = "DateTimePickerBD"
        Me.DateTimePickerBD.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePickerBD.TabIndex = 6
        '
        'gbMFee
        '
        Me.gbMFee.Controls.Add(Me.DateTimePickerReg)
        Me.gbMFee.Controls.Add(Me.lblJinedDate)
        Me.gbMFee.Controls.Add(Me.txtMFee)
        Me.gbMFee.Controls.Add(Me.lblMFee)
        Me.gbMFee.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbMFee.Location = New System.Drawing.Point(230, 101)
        Me.gbMFee.Name = "gbMFee"
        Me.gbMFee.Size = New System.Drawing.Size(555, 104)
        Me.gbMFee.TabIndex = 7
        Me.gbMFee.TabStop = False
        Me.gbMFee.Text = "Membership Fee && Joined Date"
        '
        'DateTimePickerReg
        '
        Me.DateTimePickerReg.CustomFormat = ""
        Me.DateTimePickerReg.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerReg.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerReg.Location = New System.Drawing.Point(342, 41)
        Me.DateTimePickerReg.Name = "DateTimePickerReg"
        Me.DateTimePickerReg.Size = New System.Drawing.Size(193, 22)
        Me.DateTimePickerReg.TabIndex = 3
        Me.DateTimePickerReg.Value = New Date(2016, 2, 21, 20, 15, 42, 0)
        '
        'lblJinedDate
        '
        Me.lblJinedDate.AutoSize = True
        Me.lblJinedDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJinedDate.Location = New System.Drawing.Point(294, 46)
        Me.lblJinedDate.Name = "lblJinedDate"
        Me.lblJinedDate.Size = New System.Drawing.Size(42, 17)
        Me.lblJinedDate.TabIndex = 2
        Me.lblJinedDate.Text = "Date "
        '
        'txtMFee
        '
        Me.txtMFee.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMFee.Location = New System.Drawing.Point(133, 41)
        Me.txtMFee.Name = "txtMFee"
        Me.txtMFee.Size = New System.Drawing.Size(114, 22)
        Me.txtMFee.TabIndex = 1
        '
        'lblMFee
        '
        Me.lblMFee.AutoSize = True
        Me.lblMFee.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMFee.Location = New System.Drawing.Point(29, 47)
        Me.lblMFee.Name = "lblMFee"
        Me.lblMFee.Size = New System.Drawing.Size(88, 17)
        Me.lblMFee.TabIndex = 0
        Me.lblMFee.Text = "Amount Paid"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(527, 355)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(611, 355)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 9
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(714, 354)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 10
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = True
        Me.btnUpdate.Visible = False
        '
        'Athlete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(856, 424)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.gbMFee)
        Me.Controls.Add(Me.DateTimePickerBD)
        Me.Controls.Add(Me.lblBirthDate)
        Me.Controls.Add(Me.gboxGender)
        Me.Controls.Add(Me.txtSurname)
        Me.Controls.Add(Me.lblSurname)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.Name = "Athlete"
        Me.Text = "Member Profile"
        Me.gboxGender.ResumeLayout(False)
        Me.gboxGender.PerformLayout()
        Me.gbMFee.ResumeLayout(False)
        Me.gbMFee.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblSurname As Label
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents gboxGender As GroupBox
    Friend WithEvents rbnMale As RadioButton
    Friend WithEvents rbnFemale As RadioButton
    Friend WithEvents lblBirthDate As Label
    Friend WithEvents DateTimePickerBD As DateTimePicker
    Friend WithEvents gbMFee As GroupBox
    Friend WithEvents lblMFee As Label
    Friend WithEvents txtMFee As TextBox
    Friend WithEvents lblJinedDate As Label
    Friend WithEvents DateTimePickerReg As DateTimePicker
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnUpdate As Button
End Class
