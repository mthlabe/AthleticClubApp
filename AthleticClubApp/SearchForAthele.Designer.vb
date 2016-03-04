<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchForAthele
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
        Me.txtMembershipNoOnSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.GroupBoxMembers = New System.Windows.Forms.GroupBox()
        Me.ListBoxAthletes = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnAddEvent = New System.Windows.Forms.Button()
        Me.btnAddNew = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnAdmin = New System.Windows.Forms.Button()
        Me.GroupBoxMembers.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtMembershipNoOnSearch
        '
        Me.txtMembershipNoOnSearch.Location = New System.Drawing.Point(15, 48)
        Me.txtMembershipNoOnSearch.Name = "txtMembershipNoOnSearch"
        Me.txtMembershipNoOnSearch.Size = New System.Drawing.Size(171, 22)
        Me.txtMembershipNoOnSearch.TabIndex = 0
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(183, 47)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "SEARCH"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'GroupBoxMembers
        '
        Me.GroupBoxMembers.Controls.Add(Me.ListBoxAthletes)
        Me.GroupBoxMembers.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxMembers.Location = New System.Drawing.Point(32, 104)
        Me.GroupBoxMembers.Name = "GroupBoxMembers"
        Me.GroupBoxMembers.Size = New System.Drawing.Size(745, 150)
        Me.GroupBoxMembers.TabIndex = 1
        Me.GroupBoxMembers.TabStop = False
        Me.GroupBoxMembers.Text = "Registered Members"
        '
        'ListBoxAthletes
        '
        Me.ListBoxAthletes.FormattingEnabled = True
        Me.ListBoxAthletes.ItemHeight = 16
        Me.ListBoxAthletes.Location = New System.Drawing.Point(15, 32)
        Me.ListBoxAthletes.Name = "ListBoxAthletes"
        Me.ListBoxAthletes.Size = New System.Drawing.Size(713, 100)
        Me.ListBoxAthletes.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnAdmin)
        Me.GroupBox1.Controls.Add(Me.btnAddNew)
        Me.GroupBox1.Controls.Add(Me.btnAddEvent)
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.txtMembershipNoOnSearch)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(32, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(745, 86)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Find By Membership No."
        '
        'btnAddEvent
        '
        Me.btnAddEvent.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnAddEvent.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddEvent.ForeColor = System.Drawing.Color.White
        Me.btnAddEvent.Location = New System.Drawing.Point(364, 10)
        Me.btnAddEvent.Name = "btnAddEvent"
        Me.btnAddEvent.Size = New System.Drawing.Size(141, 23)
        Me.btnAddEvent.TabIndex = 2
        Me.btnAddEvent.Text = "ADD NEW RACE"
        Me.btnAddEvent.UseVisualStyleBackColor = False
        '
        'btnAddNew
        '
        Me.btnAddNew.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnAddNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNew.ForeColor = System.Drawing.Color.White
        Me.btnAddNew.Location = New System.Drawing.Point(502, 10)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(161, 23)
        Me.btnAddNew.TabIndex = 2
        Me.btnAddNew.Text = "ADD NEW MEMBER"
        Me.btnAddNew.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(701, 260)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnAdmin
        '
        Me.btnAdmin.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdmin.ForeColor = System.Drawing.Color.White
        Me.btnAdmin.Location = New System.Drawing.Point(660, 9)
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.Size = New System.Drawing.Size(75, 23)
        Me.btnAdmin.TabIndex = 3
        Me.btnAdmin.Text = "ADMIN"
        Me.btnAdmin.UseVisualStyleBackColor = False
        '
        'SearchForAthele
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(789, 295)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBoxMembers)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "SearchForAthele"
        Me.Text = "Athletic Club System"
        Me.GroupBoxMembers.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtMembershipNoOnSearch As TextBox
    Friend WithEvents GroupBoxMembers As GroupBox
    Friend WithEvents ListBoxAthletes As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnAddNew As Button
    Friend WithEvents btnAddEvent As Button
    Friend WithEvents btnAdmin As Button
End Class
