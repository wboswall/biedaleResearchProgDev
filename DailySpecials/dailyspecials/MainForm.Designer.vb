'
' Created by SharpDevelop.
' User: weboswall
' Date: 4/18/2016
' Time: 2:22 PM
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
		Me.SoupOfTheDayButton = New System.Windows.Forms.Button()
		Me.ChefsSpecialButton = New System.Windows.Forms.Button()
		Me.DailyFishButton = New System.Windows.Forms.Button()
		Me.ResetButton = New System.Windows.Forms.Button()
		Me.ExitButton = New System.Windows.Forms.Button()
		Me.label1 = New System.Windows.Forms.Label()
		Me.label2 = New System.Windows.Forms.Label()
		Me.label3 = New System.Windows.Forms.Label()
		Me.label4 = New System.Windows.Forms.Label()
		Me.SuspendLayout
		'
		'SoupOfTheDayButton
		'
		Me.SoupOfTheDayButton.Location = New System.Drawing.Point(12, 84)
		Me.SoupOfTheDayButton.Name = "SoupOfTheDayButton"
		Me.SoupOfTheDayButton.Size = New System.Drawing.Size(144, 33)
		Me.SoupOfTheDayButton.TabIndex = 0
		Me.SoupOfTheDayButton.Text = "&Soup of the Day"
		Me.SoupOfTheDayButton.UseVisualStyleBackColor = true
		AddHandler Me.SoupOfTheDayButton.Click, AddressOf Me.SoupOfTheDayButtonClick
		'
		'ChefsSpecialButton
		'
		Me.ChefsSpecialButton.Location = New System.Drawing.Point(12, 122)
		Me.ChefsSpecialButton.Name = "ChefsSpecialButton"
		Me.ChefsSpecialButton.Size = New System.Drawing.Size(144, 33)
		Me.ChefsSpecialButton.TabIndex = 1
		Me.ChefsSpecialButton.Text = "&Chef's Special"
		Me.ChefsSpecialButton.UseVisualStyleBackColor = true
		AddHandler Me.ChefsSpecialButton.Click, AddressOf Me.ChefsSpecialButtonClick
		'
		'DailyFishButton
		'
		Me.DailyFishButton.Location = New System.Drawing.Point(12, 169)
		Me.DailyFishButton.Name = "DailyFishButton"
		Me.DailyFishButton.Size = New System.Drawing.Size(144, 33)
		Me.DailyFishButton.TabIndex = 2
		Me.DailyFishButton.Text = "&Daily Fish"
		Me.DailyFishButton.UseVisualStyleBackColor = true
		AddHandler Me.DailyFishButton.Click, AddressOf Me.DailyFishButtonClick
		'
		'ResetButton
		'
		Me.ResetButton.Location = New System.Drawing.Point(556, 56)
		Me.ResetButton.Name = "ResetButton"
		Me.ResetButton.Size = New System.Drawing.Size(75, 23)
		Me.ResetButton.TabIndex = 3
		Me.ResetButton.Text = "&Reset"
		Me.ResetButton.UseVisualStyleBackColor = true
		AddHandler Me.ResetButton.Click, AddressOf Me.ResetButtonClick
		'
		'ExitButton
		'
		Me.ExitButton.Location = New System.Drawing.Point(556, 94)
		Me.ExitButton.Name = "ExitButton"
		Me.ExitButton.Size = New System.Drawing.Size(75, 23)
		Me.ExitButton.TabIndex = 4
		Me.ExitButton.Text = "&Exit"
		Me.ExitButton.UseVisualStyleBackColor = true
		AddHandler Me.ExitButton.Click, AddressOf Me.ExitButtonClick
		'
		'label1
		'
		Me.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label1.Location = New System.Drawing.Point(196, 9)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(232, 32)
		Me.label1.TabIndex = 5
		Me.label1.Text = "Will's Bar and Grill"
		'
		'label2
		'
		Me.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.label2.Location = New System.Drawing.Point(179, 94)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(249, 23)
		Me.label2.TabIndex = 6
		'
		'label3
		'
		Me.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.label3.Location = New System.Drawing.Point(179, 132)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(249, 23)
		Me.label3.TabIndex = 7
		'
		'label4
		'
		Me.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.label4.Location = New System.Drawing.Point(179, 179)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(249, 23)
		Me.label4.TabIndex = 8
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(643, 243)
		Me.Controls.Add(Me.label4)
		Me.Controls.Add(Me.label3)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.label1)
		Me.Controls.Add(Me.ExitButton)
		Me.Controls.Add(Me.ResetButton)
		Me.Controls.Add(Me.DailyFishButton)
		Me.Controls.Add(Me.ChefsSpecialButton)
		Me.Controls.Add(Me.SoupOfTheDayButton)
		Me.Name = "MainForm"
		Me.Text = "DailySpecials"
		Me.ResumeLayout(false)
	End Sub
	Private label4 As System.Windows.Forms.Label
	Private label3 As System.Windows.Forms.Label
	Private label2 As System.Windows.Forms.Label
	Private label1 As System.Windows.Forms.Label
	Private ExitButton As System.Windows.Forms.Button
	Private ResetButton As System.Windows.Forms.Button
	Private DailyFishButton As System.Windows.Forms.Button
	Private ChefsSpecialButton As System.Windows.Forms.Button
	Private SoupOfTheDayButton As System.Windows.Forms.Button
End Class
