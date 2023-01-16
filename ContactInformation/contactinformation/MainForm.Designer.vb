'
' Created by SharpDevelop.
' User: weboswall
' Date: 4/18/2016
' Time: 1:42 PM
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
		Me.PersonButton = New System.Windows.Forms.Button()
		Me.ExitButton = New System.Windows.Forms.Button()
		Me.DepartmentButton = New System.Windows.Forms.Button()
		Me.ResetButton = New System.Windows.Forms.Button()
		Me.PhoneNumberButton = New System.Windows.Forms.Button()
		Me.label1 = New System.Windows.Forms.Label()
		Me.label2 = New System.Windows.Forms.Label()
		Me.label3 = New System.Windows.Forms.Label()
		Me.SuspendLayout
		'
		'PersonButton
		'
		Me.PersonButton.Location = New System.Drawing.Point(12, 39)
		Me.PersonButton.Name = "PersonButton"
		Me.PersonButton.Size = New System.Drawing.Size(75, 23)
		Me.PersonButton.TabIndex = 0
		Me.PersonButton.Text = "&Person"
		Me.PersonButton.UseVisualStyleBackColor = true
		AddHandler Me.PersonButton.Click, AddressOf Me.PersonButtonClick
		'
		'ExitButton
		'
		Me.ExitButton.Location = New System.Drawing.Point(20, 79)
		Me.ExitButton.Name = "ExitButton"
		Me.ExitButton.Size = New System.Drawing.Size(75, 23)
		Me.ExitButton.TabIndex = 1
		Me.ExitButton.Text = "&Exit"
		Me.ExitButton.UseVisualStyleBackColor = true
		AddHandler Me.ExitButton.Click, AddressOf Me.ExitButtonClick
		'
		'DepartmentButton
		'
		Me.DepartmentButton.Location = New System.Drawing.Point(312, 39)
		Me.DepartmentButton.Name = "DepartmentButton"
		Me.DepartmentButton.Size = New System.Drawing.Size(75, 23)
		Me.DepartmentButton.TabIndex = 2
		Me.DepartmentButton.Text = "&Department"
		Me.DepartmentButton.UseVisualStyleBackColor = true
		AddHandler Me.DepartmentButton.Click, AddressOf Me.DepartmentButtonClick
		'
		'ResetButton
		'
		Me.ResetButton.Location = New System.Drawing.Point(119, 79)
		Me.ResetButton.Name = "ResetButton"
		Me.ResetButton.Size = New System.Drawing.Size(75, 23)
		Me.ResetButton.TabIndex = 3
		Me.ResetButton.Text = "&Reset"
		Me.ResetButton.UseVisualStyleBackColor = true
		AddHandler Me.ResetButton.Click, AddressOf Me.ResetButtonClick
		'
		'PhoneNumberButton
		'
		Me.PhoneNumberButton.Location = New System.Drawing.Point(512, 39)
		Me.PhoneNumberButton.Name = "PhoneNumberButton"
		Me.PhoneNumberButton.Size = New System.Drawing.Size(91, 23)
		Me.PhoneNumberButton.TabIndex = 4
		Me.PhoneNumberButton.Text = "&PhoneNumber"
		Me.PhoneNumberButton.UseVisualStyleBackColor = true
		AddHandler Me.PhoneNumberButton.Click, AddressOf Me.PhoneNumberButtonClick
		'
		'label1
		'
		Me.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.label1.Location = New System.Drawing.Point(12, 9)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(294, 23)
		Me.label1.TabIndex = 6
		'
		'label2
		'
		Me.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.label2.Location = New System.Drawing.Point(312, 9)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(194, 27)
		Me.label2.TabIndex = 7
		'
		'label3
		'
		Me.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.label3.Location = New System.Drawing.Point(512, 9)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(199, 23)
		Me.label3.TabIndex = 8
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(728, 115)
		Me.Controls.Add(Me.label3)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.label1)
		Me.Controls.Add(Me.PhoneNumberButton)
		Me.Controls.Add(Me.ResetButton)
		Me.Controls.Add(Me.DepartmentButton)
		Me.Controls.Add(Me.ExitButton)
		Me.Controls.Add(Me.PersonButton)
		Me.Name = "MainForm"
		Me.Text = "ContactInformation"
		Me.ResumeLayout(false)
	End Sub
	Private label3 As System.Windows.Forms.Label
	Private label2 As System.Windows.Forms.Label
	Private label1 As System.Windows.Forms.Label
	Private PhoneNumberButton As System.Windows.Forms.Button
	Private ResetButton As System.Windows.Forms.Button
	Private DepartmentButton As System.Windows.Forms.Button
	Private ExitButton As System.Windows.Forms.Button
	Private PersonButton As System.Windows.Forms.Button
End Class
