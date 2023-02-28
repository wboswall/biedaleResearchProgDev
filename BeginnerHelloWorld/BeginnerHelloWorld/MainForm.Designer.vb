'
' Created by SharpDevelop.
' User: weboswall
' Date: 4/18/2016
' Time: 10:13 AM
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
		Me.EnglishButton = New System.Windows.Forms.Button()
		Me.SpanishButton = New System.Windows.Forms.Button()
		Me.FrenchButton = New System.Windows.Forms.Button()
		Me.ItalianButton = New System.Windows.Forms.Button()
		Me.DisplayLabel = New System.Windows.Forms.Label()
		Me.ExitButton = New System.Windows.Forms.Button()
		Me.ResetButton = New System.Windows.Forms.Button()
		Me.SuspendLayout
		'
		'EnglishButton
		'
		Me.EnglishButton.Location = New System.Drawing.Point(8, 14)
		Me.EnglishButton.Name = "EnglishButton"
		Me.EnglishButton.Size = New System.Drawing.Size(75, 23)
		Me.EnglishButton.TabIndex = 0
		Me.EnglishButton.Text = "&English"
		Me.EnglishButton.UseVisualStyleBackColor = true
		AddHandler Me.EnglishButton.Click, AddressOf Me.EnglishButtonClick
		'
		'SpanishButton
		'
		Me.SpanishButton.Location = New System.Drawing.Point(99, 14)
		Me.SpanishButton.Name = "SpanishButton"
		Me.SpanishButton.Size = New System.Drawing.Size(75, 23)
		Me.SpanishButton.TabIndex = 1
		Me.SpanishButton.Text = "&Spanish"
		Me.SpanishButton.UseVisualStyleBackColor = true
		AddHandler Me.SpanishButton.Click, AddressOf Me.SpanishButtonClick
		'
		'FrenchButton
		'
		Me.FrenchButton.Location = New System.Drawing.Point(8, 52)
		Me.FrenchButton.Name = "FrenchButton"
		Me.FrenchButton.Size = New System.Drawing.Size(75, 23)
		Me.FrenchButton.TabIndex = 2
		Me.FrenchButton.Text = "&French"
		Me.FrenchButton.UseVisualStyleBackColor = true
		AddHandler Me.FrenchButton.Click, AddressOf Me.FrenchButtonClick
		'
		'ItalianButton
		'
		Me.ItalianButton.Location = New System.Drawing.Point(99, 52)
		Me.ItalianButton.Name = "ItalianButton"
		Me.ItalianButton.Size = New System.Drawing.Size(75, 23)
		Me.ItalianButton.TabIndex = 3
		Me.ItalianButton.Text = "&Italian"
		Me.ItalianButton.UseVisualStyleBackColor = true
		AddHandler Me.ItalianButton.Click, AddressOf Me.ItalianButtonClick
		'
		'DisplayLabel
		'
		Me.DisplayLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(192,Byte),Integer), CType(CType(192,Byte),Integer))
		Me.DisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.DisplayLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.DisplayLabel.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.DisplayLabel.Location = New System.Drawing.Point(8, 88)
		Me.DisplayLabel.Name = "DisplayLabel"
		Me.DisplayLabel.Size = New System.Drawing.Size(254, 83)
		Me.DisplayLabel.TabIndex = 4
		Me.DisplayLabel.Text = "Will Display -Hello World! In Different Languages."
		'
		'ExitButton
		'
		Me.ExitButton.Location = New System.Drawing.Point(187, 52)
		Me.ExitButton.Name = "ExitButton"
		Me.ExitButton.Size = New System.Drawing.Size(75, 23)
		Me.ExitButton.TabIndex = 5
		Me.ExitButton.Text = "&Exit"
		Me.ExitButton.UseVisualStyleBackColor = true
		AddHandler Me.ExitButton.Click, AddressOf Me.ExitButtonClick
		'
		'ResetButton
		'
		Me.ResetButton.Location = New System.Drawing.Point(187, 14)
		Me.ResetButton.Name = "ResetButton"
		Me.ResetButton.Size = New System.Drawing.Size(75, 23)
		Me.ResetButton.TabIndex = 6
		Me.ResetButton.Text = "&Reset"
		Me.ResetButton.UseVisualStyleBackColor = true
		AddHandler Me.ResetButton.Click, AddressOf Me.ResetButtonClick
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(270, 179)
		Me.Controls.Add(Me.ResetButton)
		Me.Controls.Add(Me.ExitButton)
		Me.Controls.Add(Me.DisplayLabel)
		Me.Controls.Add(Me.ItalianButton)
		Me.Controls.Add(Me.FrenchButton)
		Me.Controls.Add(Me.SpanishButton)
		Me.Controls.Add(Me.EnglishButton)
		Me.Name = "MainForm"
		Me.Text = "BeginnerHelloWorld"
		Me.ResumeLayout(false)
	End Sub
	Private ResetButton As System.Windows.Forms.Button
	Private ExitButton As System.Windows.Forms.Button
	Private DisplayLabel As System.Windows.Forms.Label
	Private ItalianButton As System.Windows.Forms.Button
	Private FrenchButton As System.Windows.Forms.Button
	Private SpanishButton As System.Windows.Forms.Button
	Private EnglishButton As System.Windows.Forms.Button
End Class
