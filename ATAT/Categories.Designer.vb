<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Categories
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
		Me.btnAdd = New System.Windows.Forms.Button
		Me.lstCategories = New System.Windows.Forms.ListBox
		Me.txtCategory = New System.Windows.Forms.TextBox
		Me.btnRemove = New System.Windows.Forms.Button
		Me.btnClose = New System.Windows.Forms.Button
		Me.SuspendLayout()
		'
		'btnAdd
		'
		Me.btnAdd.Location = New System.Drawing.Point(377, 9)
		Me.btnAdd.Name = "btnAdd"
		Me.btnAdd.Size = New System.Drawing.Size(99, 25)
		Me.btnAdd.TabIndex = 1
		Me.btnAdd.Text = "Add"
		Me.btnAdd.UseVisualStyleBackColor = True
		'
		'lstCategories
		'
		Me.lstCategories.FormattingEnabled = True
		Me.lstCategories.ItemHeight = 14
		Me.lstCategories.Location = New System.Drawing.Point(12, 40)
		Me.lstCategories.Name = "lstCategories"
		Me.lstCategories.Size = New System.Drawing.Size(359, 256)
		Me.lstCategories.Sorted = True
		Me.lstCategories.TabIndex = 4
		'
		'txtCategory
		'
		Me.txtCategory.Location = New System.Drawing.Point(12, 12)
		Me.txtCategory.Name = "txtCategory"
		Me.txtCategory.Size = New System.Drawing.Size(359, 22)
		Me.txtCategory.TabIndex = 0
		'
		'btnRemove
		'
		Me.btnRemove.Location = New System.Drawing.Point(377, 40)
		Me.btnRemove.Name = "btnRemove"
		Me.btnRemove.Size = New System.Drawing.Size(99, 25)
		Me.btnRemove.TabIndex = 2
		Me.btnRemove.Text = "Remove"
		Me.btnRemove.UseVisualStyleBackColor = True
		'
		'btnClose
		'
		Me.btnClose.Location = New System.Drawing.Point(377, 271)
		Me.btnClose.Name = "btnClose"
		Me.btnClose.Size = New System.Drawing.Size(99, 25)
		Me.btnClose.TabIndex = 3
		Me.btnClose.Text = "Close"
		Me.btnClose.UseVisualStyleBackColor = True
		'
		'Categories
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(487, 309)
		Me.Controls.Add(Me.btnClose)
		Me.Controls.Add(Me.btnRemove)
		Me.Controls.Add(Me.txtCategory)
		Me.Controls.Add(Me.lstCategories)
		Me.Controls.Add(Me.btnAdd)
		Me.Name = "Categories"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.Text = "Category management"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents btnAdd As System.Windows.Forms.Button
	Friend WithEvents lstCategories As System.Windows.Forms.ListBox
	Friend WithEvents txtCategory As System.Windows.Forms.TextBox
	Friend WithEvents btnRemove As System.Windows.Forms.Button
	Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
