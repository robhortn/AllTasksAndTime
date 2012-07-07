<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
	Inherits BaseForm

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
		Me.components = New System.ComponentModel.Container()
		Me.btnLogIt = New System.Windows.Forms.Button()
		Me.txtTaskDescription = New System.Windows.Forms.TextBox()
		Me.cboCategories = New System.Windows.Forms.ComboBox()
		Me.btnManageCategory = New System.Windows.Forms.Button()
		Me.btnClose = New System.Windows.Forms.Button()
		Me.lblTaskDescription = New System.Windows.Forms.Label()
		Me.tmrCheckStopWatch = New System.Windows.Forms.Timer(Me.components)
		Me.lblElapsed = New System.Windows.Forms.Label()
		Me.lblElapsedTimeSoFar = New System.Windows.Forms.Label()
		Me.lblTaskTitle = New System.Windows.Forms.Label()
		Me.tmrTotalLogged = New System.Windows.Forms.Timer(Me.components)
		Me.lblTotalTimeElapsed = New System.Windows.Forms.Label()
		Me.lblTotalTime = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'btnLogIt
		'
		Me.btnLogIt.Location = New System.Drawing.Point(592, 52)
		Me.btnLogIt.Name = "btnLogIt"
		Me.btnLogIt.Size = New System.Drawing.Size(99, 25)
		Me.btnLogIt.TabIndex = 1
		Me.btnLogIt.Text = "Log time"
		Me.btnLogIt.UseVisualStyleBackColor = True
		'
		'txtTaskDescription
		'
		Me.txtTaskDescription.Location = New System.Drawing.Point(12, 52)
		Me.txtTaskDescription.Multiline = True
		Me.txtTaskDescription.Name = "txtTaskDescription"
		Me.txtTaskDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.txtTaskDescription.Size = New System.Drawing.Size(565, 53)
		Me.txtTaskDescription.TabIndex = 0
		Me.txtTaskDescription.Text = "Coding."
		'
		'cboCategories
		'
		Me.cboCategories.FormattingEnabled = True
		Me.cboCategories.Location = New System.Drawing.Point(12, 115)
		Me.cboCategories.Name = "cboCategories"
		Me.cboCategories.Size = New System.Drawing.Size(456, 22)
		Me.cboCategories.Sorted = True
		Me.cboCategories.TabIndex = 3
		'
		'btnManageCategory
		'
		Me.btnManageCategory.Location = New System.Drawing.Point(474, 112)
		Me.btnManageCategory.Name = "btnManageCategory"
		Me.btnManageCategory.Size = New System.Drawing.Size(103, 25)
		Me.btnManageCategory.TabIndex = 4
		Me.btnManageCategory.Text = "Categories ..."
		Me.btnManageCategory.UseVisualStyleBackColor = True
		'
		'btnClose
		'
		Me.btnClose.Location = New System.Drawing.Point(592, 112)
		Me.btnClose.Name = "btnClose"
		Me.btnClose.Size = New System.Drawing.Size(99, 25)
		Me.btnClose.TabIndex = 2
		Me.btnClose.Text = "Close"
		Me.btnClose.UseVisualStyleBackColor = True
		'
		'lblTaskDescription
		'
		Me.lblTaskDescription.AutoSize = True
		Me.lblTaskDescription.Location = New System.Drawing.Point(12, 10)
		Me.lblTaskDescription.Name = "lblTaskDescription"
		Me.lblTaskDescription.Size = New System.Drawing.Size(79, 14)
		Me.lblTaskDescription.TabIndex = 5
		Me.lblTaskDescription.Text = "Working on"
		'
		'tmrCheckStopWatch
		'
		Me.tmrCheckStopWatch.Interval = 1000
		'
		'lblElapsed
		'
		Me.lblElapsed.AutoSize = True
		Me.lblElapsed.Location = New System.Drawing.Point(10, 29)
		Me.lblElapsed.Name = "lblElapsed"
		Me.lblElapsed.Size = New System.Drawing.Size(85, 14)
		Me.lblElapsed.TabIndex = 6
		Me.lblElapsed.Text = "For this long"
		'
		'lblElapsedTimeSoFar
		'
		Me.lblElapsedTimeSoFar.AutoSize = True
		Me.lblElapsedTimeSoFar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.lblElapsedTimeSoFar.Location = New System.Drawing.Point(99, 29)
		Me.lblElapsedTimeSoFar.Name = "lblElapsedTimeSoFar"
		Me.lblElapsedTimeSoFar.Size = New System.Drawing.Size(65, 14)
		Me.lblElapsedTimeSoFar.TabIndex = 7
		Me.lblElapsedTimeSoFar.Text = "00:00:00"
		'
		'lblTaskTitle
		'
		Me.lblTaskTitle.AutoSize = True
		Me.lblTaskTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.lblTaskTitle.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTaskTitle.Location = New System.Drawing.Point(99, 10)
		Me.lblTaskTitle.Name = "lblTaskTitle"
		Me.lblTaskTitle.Size = New System.Drawing.Size(128, 14)
		Me.lblTaskTitle.TabIndex = 8
		Me.lblTaskTitle.Text = "title text goes here"
		'
		'tmrTotalLogged
		'
		Me.tmrTotalLogged.Interval = 1000
		'
		'lblTotalTimeElapsed
		'
		Me.lblTotalTimeElapsed.AutoSize = True
		Me.lblTotalTimeElapsed.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.lblTotalTimeElapsed.Location = New System.Drawing.Point(375, 29)
		Me.lblTotalTimeElapsed.Name = "lblTotalTimeElapsed"
		Me.lblTotalTimeElapsed.Size = New System.Drawing.Size(65, 14)
		Me.lblTotalTimeElapsed.TabIndex = 10
		Me.lblTotalTimeElapsed.Text = "00:00:00"
		'
		'lblTotalTime
		'
		Me.lblTotalTime.AutoSize = True
		Me.lblTotalTime.Location = New System.Drawing.Point(170, 29)
		Me.lblTotalTime.Name = "lblTotalTime"
		Me.lblTotalTime.Size = New System.Drawing.Size(196, 14)
		Me.lblTotalTime.TabIndex = 9
		Me.lblTotalTime.Text = "and total time logged so far is"
		'
		'Main
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(700, 153)
		Me.Controls.Add(Me.lblTotalTimeElapsed)
		Me.Controls.Add(Me.lblTotalTime)
		Me.Controls.Add(Me.lblTaskTitle)
		Me.Controls.Add(Me.lblElapsedTimeSoFar)
		Me.Controls.Add(Me.lblElapsed)
		Me.Controls.Add(Me.lblTaskDescription)
		Me.Controls.Add(Me.btnClose)
		Me.Controls.Add(Me.btnManageCategory)
		Me.Controls.Add(Me.cboCategories)
		Me.Controls.Add(Me.txtTaskDescription)
		Me.Controls.Add(Me.btnLogIt)
		Me.Name = "Main"
		Me.Text = "All Tasks And Time 1.0"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents btnLogIt As System.Windows.Forms.Button
	Friend WithEvents txtTaskDescription As System.Windows.Forms.TextBox
	Friend WithEvents cboCategories As System.Windows.Forms.ComboBox
	Friend WithEvents btnManageCategory As System.Windows.Forms.Button
	Friend WithEvents btnClose As System.Windows.Forms.Button
	Friend WithEvents lblTaskDescription As System.Windows.Forms.Label
	Friend WithEvents tmrCheckStopWatch As System.Windows.Forms.Timer
	Friend WithEvents lblElapsed As System.Windows.Forms.Label
	Friend WithEvents lblElapsedTimeSoFar As System.Windows.Forms.Label
	Friend WithEvents lblTaskTitle As System.Windows.Forms.Label
	Friend WithEvents tmrTotalLogged As System.Windows.Forms.Timer
	Friend WithEvents lblTotalTimeElapsed As System.Windows.Forms.Label
	Friend WithEvents lblTotalTime As System.Windows.Forms.Label

End Class
