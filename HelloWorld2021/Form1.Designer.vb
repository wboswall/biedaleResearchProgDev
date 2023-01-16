<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
		Me.ButtonClickMe = New System.Windows.Forms.Button()
		Me.ButtonExit = New System.Windows.Forms.Button()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.ButtonClearText = New System.Windows.Forms.Button()
		Me.ButtonRestartApp = New System.Windows.Forms.Button()
		Me.ButtonEnglish = New System.Windows.Forms.Button()
		Me.ButtonSpanish = New System.Windows.Forms.Button()
		Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
		Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
		Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
		Me.ButtonPrintPreview = New System.Windows.Forms.Button()
		Me.ButtonPrint = New System.Windows.Forms.Button()
		Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
		Me.SuspendLayout()
		'
		'ButtonClickMe
		'
		Me.ButtonClickMe.Location = New System.Drawing.Point(12, 145)
		Me.ButtonClickMe.Name = "ButtonClickMe"
		Me.ButtonClickMe.Size = New System.Drawing.Size(100, 34)
		Me.ButtonClickMe.TabIndex = 1
		Me.ButtonClickMe.Text = "&Click Me"
		Me.ButtonClickMe.UseVisualStyleBackColor = True
		'
		'ButtonExit
		'
		Me.ButtonExit.Location = New System.Drawing.Point(118, 145)
		Me.ButtonExit.Name = "ButtonExit"
		Me.ButtonExit.Size = New System.Drawing.Size(100, 34)
		Me.ButtonExit.TabIndex = 2
		Me.ButtonExit.Text = "&Exit"
		Me.ButtonExit.UseVisualStyleBackColor = True
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.Label1.Location = New System.Drawing.Point(73, 75)
		Me.Label1.Name = "Label1"
		Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label1.Size = New System.Drawing.Size(268, 30)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "A greeting will appear here."
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'ButtonClearText
		'
		Me.ButtonClearText.Location = New System.Drawing.Point(228, 145)
		Me.ButtonClearText.Name = "ButtonClearText"
		Me.ButtonClearText.Size = New System.Drawing.Size(92, 33)
		Me.ButtonClearText.TabIndex = 3
		Me.ButtonClearText.Text = "&Clear Text"
		Me.ButtonClearText.UseVisualStyleBackColor = True
		'
		'ButtonRestartApp
		'
		Me.ButtonRestartApp.Location = New System.Drawing.Point(12, 199)
		Me.ButtonRestartApp.Name = "ButtonRestartApp"
		Me.ButtonRestartApp.Size = New System.Drawing.Size(142, 37)
		Me.ButtonRestartApp.TabIndex = 4
		Me.ButtonRestartApp.Text = "&Restart App"
		Me.ButtonRestartApp.UseVisualStyleBackColor = True
		'
		'ButtonEnglish
		'
		Me.ButtonEnglish.Location = New System.Drawing.Point(163, 198)
		Me.ButtonEnglish.Name = "ButtonEnglish"
		Me.ButtonEnglish.Size = New System.Drawing.Size(92, 37)
		Me.ButtonEnglish.TabIndex = 5
		Me.ButtonEnglish.Text = "&English"
		Me.ButtonEnglish.UseVisualStyleBackColor = True
		'
		'ButtonSpanish
		'
		Me.ButtonSpanish.Location = New System.Drawing.Point(262, 199)
		Me.ButtonSpanish.Name = "ButtonSpanish"
		Me.ButtonSpanish.Size = New System.Drawing.Size(99, 37)
		Me.ButtonSpanish.TabIndex = 6
		Me.ButtonSpanish.Text = "&Spanish"
		Me.ButtonSpanish.UseVisualStyleBackColor = True
		'
		'PrintDialog1
		'
		Me.PrintDialog1.UseEXDialog = True
		'
		'ButtonPrintPreview
		'
		Me.ButtonPrintPreview.Location = New System.Drawing.Point(12, 259)
		Me.ButtonPrintPreview.Name = "ButtonPrintPreview"
		Me.ButtonPrintPreview.Size = New System.Drawing.Size(151, 37)
		Me.ButtonPrintPreview.TabIndex = 7
		Me.ButtonPrintPreview.Text = "&Print Preview"
		Me.ButtonPrintPreview.UseVisualStyleBackColor = True
		'
		'ButtonPrint
		'
		Me.ButtonPrint.Location = New System.Drawing.Point(175, 258)
		Me.ButtonPrint.Name = "ButtonPrint"
		Me.ButtonPrint.Size = New System.Drawing.Size(166, 37)
		Me.ButtonPrint.TabIndex = 8
		Me.ButtonPrint.Text = "Prin&t"
		Me.ButtonPrint.UseVisualStyleBackColor = True
		'
		'PrintPreviewDialog1
		'
		Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
		Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
		Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
		Me.PrintPreviewDialog1.Enabled = True
		Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
		Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
		Me.PrintPreviewDialog1.Visible = False
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(390, 308)
		Me.Controls.Add(Me.ButtonPrint)
		Me.Controls.Add(Me.ButtonPrintPreview)
		Me.Controls.Add(Me.ButtonSpanish)
		Me.Controls.Add(Me.ButtonEnglish)
		Me.Controls.Add(Me.ButtonRestartApp)
		Me.Controls.Add(Me.ButtonClearText)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.ButtonExit)
		Me.Controls.Add(Me.ButtonClickMe)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Name = "Form1"
		Me.Text = "Hello World 2021"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents ButtonClickMe As Button
	Friend WithEvents ButtonExit As Button
	Friend WithEvents Label1 As Label
	Friend WithEvents ButtonClearText As Button
	Friend WithEvents ButtonRestartApp As Button
	Friend WithEvents ButtonEnglish As Button
	Friend WithEvents ButtonSpanish As Button
	Friend WithEvents PrintDocument1 As Printing.PrintDocument
	Friend WithEvents PrintDialog1 As PrintDialog
	Friend WithEvents PageSetupDialog1 As PageSetupDialog
	Friend WithEvents ButtonPrintPreview As Button
	Friend WithEvents ButtonPrint As Button
	Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class
