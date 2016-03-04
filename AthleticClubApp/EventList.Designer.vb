<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EventList
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.lblEventDate = New System.Windows.Forms.Label()
        Me.DateTimePickerEvent = New System.Windows.Forms.DateTimePicker()
        Me.lblRegFee = New System.Windows.Forms.Label()
        Me.txtRegFee = New System.Windows.Forms.TextBox()
        Me.lblLoc = New System.Windows.Forms.Label()
        Me.txtLoc = New System.Windows.Forms.TextBox()
        Me.lblDistance = New System.Windows.Forms.Label()
        Me.txtDistance = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Title "
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(267, 40)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(282, 22)
        Me.txtTitle.TabIndex = 1
        '
        'lblEventDate
        '
        Me.lblEventDate.AutoSize = True
        Me.lblEventDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEventDate.Location = New System.Drawing.Point(43, 111)
        Me.lblEventDate.Name = "lblEventDate"
        Me.lblEventDate.Size = New System.Drawing.Size(88, 17)
        Me.lblEventDate.TabIndex = 2
        Me.lblEventDate.Text = "Event Date"
        '
        'DateTimePickerEvent
        '
        Me.DateTimePickerEvent.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerEvent.Location = New System.Drawing.Point(267, 106)
        Me.DateTimePickerEvent.Name = "DateTimePickerEvent"
        Me.DateTimePickerEvent.Size = New System.Drawing.Size(282, 22)
        Me.DateTimePickerEvent.TabIndex = 3
        Me.DateTimePickerEvent.Value = New Date(2016, 2, 20, 0, 0, 0, 0)
        '
        'lblRegFee
        '
        Me.lblRegFee.AutoSize = True
        Me.lblRegFee.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegFee.Location = New System.Drawing.Point(40, 179)
        Me.lblRegFee.Name = "lblRegFee"
        Me.lblRegFee.Size = New System.Drawing.Size(128, 17)
        Me.lblRegFee.TabIndex = 4
        Me.lblRegFee.Text = "Registration Fee"
        '
        'txtRegFee
        '
        Me.txtRegFee.Location = New System.Drawing.Point(267, 174)
        Me.txtRegFee.Name = "txtRegFee"
        Me.txtRegFee.Size = New System.Drawing.Size(112, 22)
        Me.txtRegFee.TabIndex = 5
        '
        'lblLoc
        '
        Me.lblLoc.AutoSize = True
        Me.lblLoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoc.Location = New System.Drawing.Point(43, 246)
        Me.lblLoc.Name = "lblLoc"
        Me.lblLoc.Size = New System.Drawing.Size(70, 17)
        Me.lblLoc.TabIndex = 6
        Me.lblLoc.Text = "Location"
        '
        'txtLoc
        '
        Me.txtLoc.Location = New System.Drawing.Point(267, 243)
        Me.txtLoc.Name = "txtLoc"
        Me.txtLoc.Size = New System.Drawing.Size(282, 22)
        Me.txtLoc.TabIndex = 7
        '
        'lblDistance
        '
        Me.lblDistance.AutoSize = True
        Me.lblDistance.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDistance.Location = New System.Drawing.Point(40, 320)
        Me.lblDistance.Name = "lblDistance"
        Me.lblDistance.Size = New System.Drawing.Size(71, 17)
        Me.lblDistance.TabIndex = 8
        Me.lblDistance.Text = "Distance"
        '
        'txtDistance
        '
        Me.txtDistance.Location = New System.Drawing.Point(267, 314)
        Me.txtDistance.Name = "txtDistance"
        Me.txtDistance.Size = New System.Drawing.Size(112, 22)
        Me.txtDistance.TabIndex = 9
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(496, 429)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 10
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(577, 429)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(659, 428)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 12
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = True
        Me.btnUpdate.Visible = False
        '
        'EventList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(780, 475)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.txtDistance)
        Me.Controls.Add(Me.lblDistance)
        Me.Controls.Add(Me.txtLoc)
        Me.Controls.Add(Me.lblLoc)
        Me.Controls.Add(Me.txtRegFee)
        Me.Controls.Add(Me.lblRegFee)
        Me.Controls.Add(Me.DateTimePickerEvent)
        Me.Controls.Add(Me.lblEventDate)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.Label1)
        Me.Name = "EventList"
        Me.Text = "Event (race)"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents lblEventDate As Label
    Friend WithEvents DateTimePickerEvent As DateTimePicker
    Friend WithEvents lblRegFee As Label
    Friend WithEvents txtRegFee As TextBox
    Friend WithEvents lblLoc As Label
    Friend WithEvents txtLoc As TextBox
    Friend WithEvents lblDistance As Label
    Friend WithEvents txtDistance As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnUpdate As Button
End Class
