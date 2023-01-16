'
' Created by SharpDevelop.
' User: weboswall
' Date: 4/14/2016
' Time: 11:23 AM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class MainForm
	Inherits System.Windows.Forms.Form
	
	''' <summary>
	''' Designer variable used to keep track of non-visual components.
	''' </summary>
	Private components As System.ComponentModel.IContainer
	
	''' <summary>
	''' Disposes resources used by the form.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	
	''' <summary>
	''' This method is required for Windows Forms designer support.
	''' Do not change the method contents inside the source code editor. The Forms designer might
	''' not be able to load this method if it was changed manually.
	''' </summary>
	Private Sub InitializeComponent()
		Me.BooksButton = New System.Windows.Forms.Button()
		Me.MusicButton = New System.Windows.Forms.Button()
		Me.PeriodicalsButton = New System.Windows.Forms.Button()
		Me.PrintButton = New System.Windows.Forms.Button()
		Me.ExitButton = New System.Windows.Forms.Button()
		Me.PromotionLabel = New System.Windows.Forms.TextBox()
		Me.PromotionCodeLabel = New System.Windows.Forms.TextBox()
		Me.label1 = New System.Windows.Forms.Label()
		Me.label2 = New System.Windows.Forms.Label()
		Me.CoffeeBarButton = New System.Windows.Forms.Button()
		Me.label3 = New System.Windows.Forms.Label()
		Me.ResetButton = New System.Windows.Forms.Button()
		Me.RestartButton = New System.Windows.Forms.Button()
		Me.SuspendLayout
		'
		'BooksButton
		'
		Me.BooksButton.Location = New System.Drawing.Point(14, 11)
		Me.BooksButton.Name = "BooksButton"
		Me.BooksButton.Size = New System.Drawing.Size(75, 23)
		Me.BooksButton.TabIndex = 0
		Me.BooksButton.Text = "&Books"
		Me.BooksButton.UseVisualStyleBackColor = true
		AddHandler Me.BooksButton.Click, AddressOf Me.BooksButtonClick
		'
		'MusicButton
		'
		Me.MusicButton.Location = New System.Drawing.Point(14, 40)
		Me.MusicButton.Name = "MusicButton"
		Me.MusicButton.Size = New System.Drawing.Size(75, 23)
		Me.MusicButton.TabIndex = 1
		Me.MusicButton.Text = "&Music"
		Me.MusicButton.UseVisualStyleBackColor = true
		AddHandler Me.MusicButton.Click, AddressOf Me.MusicButtonClick
		'
		'PeriodicalsButton
		'
		Me.PeriodicalsButton.Location = New System.Drawing.Point(14, 69)
		Me.PeriodicalsButton.Name = "PeriodicalsButton"
		Me.PeriodicalsButton.Size = New System.Drawing.Size(75, 23)
		Me.PeriodicalsButton.TabIndex = 2
		Me.PeriodicalsButton.Text = "&Periodicals"
		Me.PeriodicalsButton.UseVisualStyleBackColor = true
		AddHandler Me.PeriodicalsButton.Click, AddressOf Me.PeriodicalsButtonClick
		'
		'PrintButton
		'
		Me.PrintButton.Location = New System.Drawing.Point(14, 127)
		Me.PrintButton.Name = "PrintButton"
		Me.PrintButton.Size = New System.Drawing.Size(75, 23)
		Me.PrintButton.TabIndex = 4
		Me.PrintButton.Text = "&Print"
		Me.PrintButton.UseVisualStyleBackColor = true
		AddHandler Me.PrintButton.Click, AddressOf Me.PrintButtonClick
		'
		'ExitButton
		'
		Me.ExitButton.Location = New System.Drawing.Point(14, 156)
		Me.ExitButton.Name = "ExitButton"
		Me.ExitButton.Size = New System.Drawing.Size(75, 23)
		Me.ExitButton.TabIndex = 5
		Me.ExitButton.Text = "&Exit"
		Me.ExitButton.UseVisualStyleBackColor = true
		AddHandler Me.ExitButton.Click, AddressOf Me.ExitButtonClick
		'
		'PromotionLabel
		'
		Me.PromotionLabel.Location = New System.Drawing.Point(222, 26)
		Me.PromotionLabel.Name = "PromotionLabel"
		Me.PromotionLabel.Size = New System.Drawing.Size(267, 20)
		Me.PromotionLabel.TabIndex = 6
		'
		'PromotionCodeLabel
		'
		Me.PromotionCodeLabel.Location = New System.Drawing.Point(222, 52)
		Me.PromotionCodeLabel.Name = "PromotionCodeLabel"
		Me.PromotionCodeLabel.Size = New System.Drawing.Size(76, 20)
		Me.PromotionCodeLabel.TabIndex = 7
		'
		'label1
		'
		Me.label1.Location = New System.Drawing.Point(116, 26)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(100, 23)
		Me.label1.TabIndex = 8
		Me.label1.Text = "Current Promotion"
		'
		'label2
		'
		Me.label2.Location = New System.Drawing.Point(116, 55)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(100, 23)
		Me.label2.TabIndex = 9
		Me.label2.Text = "Promotion Code"
		'
		'CoffeeBarButton
		'
		Me.CoffeeBarButton.Location = New System.Drawing.Point(14, 98)
		Me.CoffeeBarButton.Name = "CoffeeBarButton"
		Me.CoffeeBarButton.Size = New System.Drawing.Size(75, 23)
		Me.CoffeeBarButton.TabIndex = 10
		Me.CoffeeBarButton.Text = "&CoffeeBar"
		Me.CoffeeBarButton.UseVisualStyleBackColor = true
		AddHandler Me.CoffeeBarButton.Click, AddressOf Me.CoffeeBarButtonClick
		'
		'label3
		'
		Me.label3.BackColor = System.Drawing.Color.Cyan
		Me.label3.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label3.ForeColor = System.Drawing.Color.LightCyan
		Me.label3.Location = New System.Drawing.Point(196, 155)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(291, 23)
		Me.label3.TabIndex = 11
		Me.label3.Text = "Programmed By: GalaxyUI Inc."
		'
		'ResetButton
		'
		Me.ResetButton.Location = New System.Drawing.Point(116, 81)
		Me.ResetButton.Name = "ResetButton"
		Me.ResetButton.Size = New System.Drawing.Size(75, 23)
		Me.ResetButton.TabIndex = 12
		Me.ResetButton.Text = "&Reset"
		Me.ResetButton.UseVisualStyleBackColor = true
		AddHandler Me.ResetButton.Click, AddressOf Me.ResetButtonClick
		'
		'RestartButton
		'
		Me.RestartButton.Location = New System.Drawing.Point(115, 158)
		Me.RestartButton.Name = "RestartButton"
		Me.RestartButton.Size = New System.Drawing.Size(75, 23)
		Me.RestartButton.TabIndex = 13
		Me.RestartButton.Text = "&Restart"
		Me.RestartButton.UseVisualStyleBackColor = true
		AddHandler Me.RestartButton.Click, AddressOf Me.RestartButtonClick
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.CancelButton = Me.ResetButton
		Me.ClientSize = New System.Drawing.Size(499, 187)
		Me.Controls.Add(Me.RestartButton)
		Me.Controls.Add(Me.ResetButton)
		Me.Controls.Add(Me.label3)
		Me.Controls.Add(Me.CoffeeBarButton)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.label1)
		Me.Controls.Add(Me.PromotionCodeLabel)
		Me.Controls.Add(Me.PromotionLabel)
		Me.Controls.Add(Me.ExitButton)
		Me.Controls.Add(Me.PrintButton)
		Me.Controls.Add(Me.PeriodicalsButton)
		Me.Controls.Add(Me.MusicButton)
		Me.Controls.Add(Me.BooksButton)
		Me.KeyPreview = true
		Me.Name = "MainForm"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "RnR Read and Refreshment"
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private RestartButton As System.Windows.Forms.Button
	Private ResetButton As System.Windows.Forms.Button
	Private label3 As System.Windows.Forms.Label
	Private label2 As System.Windows.Forms.Label
	Private label1 As System.Windows.Forms.Label
	Private PromotionCodeLabel As System.Windows.Forms.TextBox
	Private PromotionLabel As System.Windows.Forms.TextBox
	Private ExitButton As System.Windows.Forms.Button
	Private PrintButton As System.Windows.Forms.Button
	Private CoffeeBarButton As System.Windows.Forms.Button
	Private PeriodicalsButton As System.Windows.Forms.Button
	Private MusicButton As System.Windows.Forms.Button
	Private BooksButton As System.Windows.Forms.Button
	
	Sub PrintButtonClick(sender As Object, e As EventArgs)
		
	End Sub
	
	Sub ExitButtonClick(sender As Object, e As EventArgs)
		'Close Application
		Application.Exit()
	End Sub
End Class
