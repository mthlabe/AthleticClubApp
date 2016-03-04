<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnRemoveAthlete = New System.Windows.Forms.Button()
        Me.btnEditAthlete = New System.Windows.Forms.Button()
        Me.ListBoxManAthletes = New System.Windows.Forms.ListBox()
        Me.lblManAthlete = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnRemoveEvent = New System.Windows.Forms.Button()
        Me.btnEditEvent = New System.Windows.Forms.Button()
        Me.ListBoxManEvents = New System.Windows.Forms.ListBox()
        Me.lblManEvent = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnRemoveAthlete)
        Me.Panel1.Controls.Add(Me.btnEditAthlete)
        Me.Panel1.Controls.Add(Me.ListBoxManAthletes)
        Me.Panel1.Controls.Add(Me.lblManAthlete)
        Me.Panel1.Location = New System.Drawing.Point(50, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(781, 183)
        Me.Panel1.TabIndex = 0
        '
        'btnRemoveAthlete
        '
        Me.btnRemoveAthlete.Location = New System.Drawing.Point(701, 129)
        Me.btnRemoveAthlete.Name = "btnRemoveAthlete"
        Me.btnRemoveAthlete.Size = New System.Drawing.Size(77, 23)
        Me.btnRemoveAthlete.TabIndex = 3
        Me.btnRemoveAthlete.Text = "Remove"
        Me.btnRemoveAthlete.UseVisualStyleBackColor = True
        '
        'btnEditAthlete
        '
        Me.btnEditAthlete.Location = New System.Drawing.Point(701, 100)
        Me.btnEditAthlete.Name = "btnEditAthlete"
        Me.btnEditAthlete.Size = New System.Drawing.Size(77, 23)
        Me.btnEditAthlete.TabIndex = 2
        Me.btnEditAthlete.Text = "Edit"
        Me.btnEditAthlete.UseVisualStyleBackColor = True
        '
        'ListBoxManAthletes
        '
        Me.ListBoxManAthletes.FormattingEnabled = True
        Me.ListBoxManAthletes.ItemHeight = 16
        Me.ListBoxManAthletes.Location = New System.Drawing.Point(25, 52)
        Me.ListBoxManAthletes.Name = "ListBoxManAthletes"
        Me.ListBoxManAthletes.Size = New System.Drawing.Size(670, 100)
        Me.ListBoxManAthletes.TabIndex = 1
        '
        'lblManAthlete
        '
        Me.lblManAthlete.AutoSize = True
        Me.lblManAthlete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblManAthlete.Location = New System.Drawing.Point(273, 17)
        Me.lblManAthlete.Name = "lblManAthlete"
        Me.lblManAthlete.Size = New System.Drawing.Size(136, 20)
        Me.lblManAthlete.TabIndex = 0
        Me.lblManAthlete.Text = "Manage Athlete"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnRemoveEvent)
        Me.Panel2.Controls.Add(Me.btnEditEvent)
        Me.Panel2.Controls.Add(Me.ListBoxManEvents)
        Me.Panel2.Controls.Add(Me.lblManEvent)
        Me.Panel2.Location = New System.Drawing.Point(50, 201)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(781, 176)
        Me.Panel2.TabIndex = 1
        '
        'btnRemoveEvent
        '
        Me.btnRemoveEvent.Location = New System.Drawing.Point(701, 119)
        Me.btnRemoveEvent.Name = "btnRemoveEvent"
        Me.btnRemoveEvent.Size = New System.Drawing.Size(77, 23)
        Me.btnRemoveEvent.TabIndex = 4
        Me.btnRemoveEvent.Text = "Remove"
        Me.btnRemoveEvent.UseVisualStyleBackColor = True
        '
        'btnEditEvent
        '
        Me.btnEditEvent.Location = New System.Drawing.Point(701, 90)
        Me.btnEditEvent.Name = "btnEditEvent"
        Me.btnEditEvent.Size = New System.Drawing.Size(77, 23)
        Me.btnEditEvent.TabIndex = 3
        Me.btnEditEvent.Text = "Edit"
        Me.btnEditEvent.UseVisualStyleBackColor = True
        '
        'ListBoxManEvents
        '
        Me.ListBoxManEvents.FormattingEnabled = True
        Me.ListBoxManEvents.ItemHeight = 16
        Me.ListBoxManEvents.Location = New System.Drawing.Point(25, 58)
        Me.ListBoxManEvents.Name = "ListBoxManEvents"
        Me.ListBoxManEvents.Size = New System.Drawing.Size(670, 84)
        Me.ListBoxManEvents.TabIndex = 2
        '
        'lblManEvent
        '
        Me.lblManEvent.AutoSize = True
        Me.lblManEvent.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblManEvent.Location = New System.Drawing.Point(273, 21)
        Me.lblManEvent.Name = "lblManEvent"
        Me.lblManEvent.Size = New System.Drawing.Size(171, 20)
        Me.lblManEvent.TabIndex = 1
        Me.lblManEvent.Text = "Manage Event/Race"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(756, 404)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(873, 439)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Admin"
        Me.Text = "Admin"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnRemoveAthlete As Button
    Friend WithEvents btnEditAthlete As Button
    Friend WithEvents ListBoxManAthletes As ListBox
    Friend WithEvents lblManAthlete As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnRemoveEvent As Button
    Friend WithEvents btnEditEvent As Button
    Friend WithEvents ListBoxManEvents As ListBox
    Friend WithEvents lblManEvent As Label
    Friend WithEvents btnCancel As Button
End Class
