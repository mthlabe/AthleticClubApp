<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AthleticEvent
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblMSN = New System.Windows.Forms.Label()
        Me.txtMSN = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtSeconds = New System.Windows.Forms.TextBox()
        Me.txtMinutes = New System.Windows.Forms.TextBox()
        Me.txtHours = New System.Windows.Forms.TextBox()
        Me.lblseconds = New System.Windows.Forms.Label()
        Me.lblminutes = New System.Windows.Forms.Label()
        Me.lblhours = New System.Windows.Forms.Label()
        Me.ListBoxRaces = New System.Windows.Forms.ListBox()
        Me.lblRace = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblMSN
        '
        Me.lblMSN.AutoSize = True
        Me.lblMSN.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMSN.Location = New System.Drawing.Point(33, 32)
        Me.lblMSN.Name = "lblMSN"
        Me.lblMSN.Size = New System.Drawing.Size(125, 17)
        Me.lblMSN.TabIndex = 0
        Me.lblMSN.Text = "Membership No."
        '
        'txtMSN
        '
        Me.txtMSN.Location = New System.Drawing.Point(165, 26)
        Me.txtMSN.Name = "txtMSN"
        Me.txtMSN.ReadOnly = True
        Me.txtMSN.Size = New System.Drawing.Size(207, 22)
        Me.txtMSN.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.ListBoxRaces)
        Me.GroupBox1.Controls.Add(Me.lblRace)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(36, 116)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(558, 148)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Race results record"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtSeconds)
        Me.GroupBox2.Controls.Add(Me.txtMinutes)
        Me.GroupBox2.Controls.Add(Me.txtHours)
        Me.GroupBox2.Controls.Add(Me.lblseconds)
        Me.GroupBox2.Controls.Add(Me.lblminutes)
        Me.GroupBox2.Controls.Add(Me.lblhours)
        Me.GroupBox2.Location = New System.Drawing.Point(276, 35)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(215, 91)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Finish-Time"
        '
        'txtSeconds
        '
        Me.txtSeconds.Location = New System.Drawing.Point(129, 54)
        Me.txtSeconds.Name = "txtSeconds"
        Me.txtSeconds.Size = New System.Drawing.Size(34, 22)
        Me.txtSeconds.TabIndex = 11
        Me.txtSeconds.Text = "00"
        '
        'txtMinutes
        '
        Me.txtMinutes.Location = New System.Drawing.Point(78, 54)
        Me.txtMinutes.Name = "txtMinutes"
        Me.txtMinutes.Size = New System.Drawing.Size(34, 22)
        Me.txtMinutes.TabIndex = 10
        Me.txtMinutes.Text = "00"
        '
        'txtHours
        '
        Me.txtHours.Location = New System.Drawing.Point(28, 54)
        Me.txtHours.Name = "txtHours"
        Me.txtHours.Size = New System.Drawing.Size(32, 22)
        Me.txtHours.TabIndex = 9
        Me.txtHours.Text = "00"
        '
        'lblseconds
        '
        Me.lblseconds.AutoSize = True
        Me.lblseconds.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblseconds.Location = New System.Drawing.Point(126, 32)
        Me.lblseconds.Name = "lblseconds"
        Me.lblseconds.Size = New System.Drawing.Size(37, 17)
        Me.lblseconds.TabIndex = 8
        Me.lblseconds.Text = "secs"
        '
        'lblminutes
        '
        Me.lblminutes.AutoSize = True
        Me.lblminutes.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblminutes.Location = New System.Drawing.Point(75, 33)
        Me.lblminutes.Name = "lblminutes"
        Me.lblminutes.Size = New System.Drawing.Size(37, 17)
        Me.lblminutes.TabIndex = 7
        Me.lblminutes.Text = "mins"
        '
        'lblhours
        '
        Me.lblhours.AutoSize = True
        Me.lblhours.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhours.Location = New System.Drawing.Point(25, 33)
        Me.lblhours.Name = "lblhours"
        Me.lblhours.Size = New System.Drawing.Size(28, 17)
        Me.lblhours.TabIndex = 6
        Me.lblhours.Text = "hrs"
        '
        'ListBoxRaces
        '
        Me.ListBoxRaces.FormattingEnabled = True
        Me.ListBoxRaces.ItemHeight = 16
        Me.ListBoxRaces.Location = New System.Drawing.Point(70, 42)
        Me.ListBoxRaces.Name = "ListBoxRaces"
        Me.ListBoxRaces.Size = New System.Drawing.Size(188, 84)
        Me.ListBoxRaces.TabIndex = 2
        '
        'lblRace
        '
        Me.lblRace.AutoSize = True
        Me.lblRace.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRace.Location = New System.Drawing.Point(23, 42)
        Me.lblRace.Name = "lblRace"
        Me.lblRace.Size = New System.Drawing.Size(41, 17)
        Me.lblRace.TabIndex = 0
        Me.lblRace.Text = "Race"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(410, 270)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(519, 270)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'AthleticEvent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(622, 316)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtMSN)
        Me.Controls.Add(Me.lblMSN)
        Me.Name = "AthleticEvent"
        Me.Text = "Athletic Event"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMSN As Label
    Friend WithEvents txtMSN As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblRace As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents ListBoxRaces As ListBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblseconds As Label
    Friend WithEvents lblminutes As Label
    Friend WithEvents lblhours As Label
    Friend WithEvents txtSeconds As TextBox
    Friend WithEvents txtMinutes As TextBox
    Friend WithEvents txtHours As TextBox
End Class
