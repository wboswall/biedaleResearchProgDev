'
' Created by SharpDevelop.
' User: weboswall
' Date: 4/14/2016
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
		Me.DownTownButton = New System.Windows.Forms.Button()
		Me.MallButton = New System.Windows.Forms.Button()
		Me.SuburbsButton = New System.Windows.Forms.Button()
		Me.label1 = New System.Windows.Forms.Label()
		Me.label2 = New System.Windows.Forms.Label()
		Me.label3 = New System.Windows.Forms.Label()
		Me.ExitButton = New System.Windows.Forms.Button()
		Me.ResetButton = New System.Windows.Forms.Button()
		Me.SuspendLayout
		'
		'DownTownButton
		'
		Me.DownTownButton.Location = New System.Drawing.Point(17, 24)
		Me.DownTownButton.Name = "DownTownButton"
		Me.DownTownButton.Size = New System.Drawing.Size(75, 23)
		Me.DownTownButton.TabIndex = 0
		Me.DownTownButton.Text = "&Downtown"
		Me.DownTownButton.UseVisualStyleBackColor = true
		AddHandler Me.DownTownButton.Click, AddressOf Me.DownTownButtonClick
		'
		'MallButton
		'
		Me.MallButton.Location = New System.Drawing.Point(17, 62)
		Me.MallButton.Name = "MallButton"
		Me.MallButton.Size = New System.Drawing.Size(75, 23)
		Me.MallButton.TabIndex = 1
		Me.MallButton.Text = "&Mall"
		Me.MallButton.UseVisualStyleBackColor = true
		AddHandler Me.MallButton.Click, AddressOf Me.MallButtonClick
		'
		'SuburbsButton
		'
		Me.SuburbsButton.Location = New System.Drawing.Point(17, 103)
		Me.SuburbsButton.Name = "SuburbsButton"
		Me.SuburbsButton.Size = New System.Drawing.Size(75, 23)
		Me.SuburbsButton.TabIndex = 2
		Me.SuburbsButton.Text = "&Suburbs"
		Me.SuburbsButton.UseVisualStyleBackColor = true
		AddHandler Me.SuburbsButton.Click, AddressOf Me.SuburbsButtonClick
		'
		'label1
		'
		Me.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.label1.Location = New System.Drawing.Point(113, 24)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(255, 23)
		Me.label1.TabIndex = 3
		'
		'label2
		'
		Me.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.label2.Location = New System.Drawing.Point(113, 62)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(255, 23)
		Me.label2.TabIndex = 4
		'
		'label3
		'
		Me.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.label3.Location = New System.Drawing.Point(113, 108)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(255, 23)
		Me.label3.TabIndex = 5
		'
		'ExitButton
		'
		Me.ExitButton.Location = New System.Drawing.Point(17, 153)
		Me.ExitButton.Name = "ExitButton"
		Me.ExitButton.Size = New System.Drawing.Size(75, 23)
		Me.ExitButton.TabIndex = 6
		Me.ExitButton.Text = "&Exit"
		Me.ExitButton.UseVisualStyleBackColor = true
		AddHandler Me.ExitButton.Click, AddressOf Me.ExitButtonClick
		'
		'ResetButton
		'
		Me.ResetButton.Location = New System.Drawing.Point(138, 153)
		Me.ResetButton.Name = "ResetButton"
		Me.ResetButton.Size = New System.Drawing.Size(75, 23)
		Me.ResetButton.TabIndex = 7
		Me.ResetButton.Text = "&Reset"
		Me.ResetButton.UseVisualStyleBackColor = true
		AddHandler Me.ResetButton.Click, AddressOf Me.ResetButtonClick
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(380, 185)
		Me.Controls.Add(Me.ResetButton)
		Me.Controls.Add(Me.ExitButton)
		Me.Controls.Add(Me.label3)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.label1)
		Me.Controls.Add(Me.SuburbsButton)
		Me.Controls.Add(Me.MallButton)
		Me.Controls.Add(Me.DownTownButton)
		Me.Name = "MainForm"
		Me.Text = "CaseStudyVeryVeryBoards"
		Me.ResumeLayout(false)
	End Sub
	Private ResetButton As System.Windows.Forms.Button
	Private ExitButton As System.Windows.Forms.Button
	Private label3 As System.Windows.Forms.Label
	Private label2 As System.Windows.Forms.Label
	Private label1 As System.Windows.Forms.Label
	Private SuburbsButton As System.Windows.Forms.Button
	Private MallButton As System.Windows.Forms.Button
	Private DownTownButton As System.Windows.Forms.Button
End Class
