'
' Created by SharpDevelop.
' User: weboswall
' Date: 4/14/2016
' Time: 1:41 PM
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
		Me.ComedyButton = New System.Windows.Forms.Button()
		Me.DramaButton = New System.Windows.Forms.Button()
		Me.ActionButton = New System.Windows.Forms.Button()
		Me.SciFiButton = New System.Windows.Forms.Button()
		Me.HorrorButton = New System.Windows.Forms.Button()
		Me.NewReleasesButton = New System.Windows.Forms.Button()
		Me.label1 = New System.Windows.Forms.Label()
		Me.label2 = New System.Windows.Forms.Label()
		Me.label3 = New System.Windows.Forms.Label()
		Me.label4 = New System.Windows.Forms.Label()
		Me.label5 = New System.Windows.Forms.Label()
		Me.label6 = New System.Windows.Forms.Label()
		Me.ExitButton = New System.Windows.Forms.Button()
		Me.RestButton = New System.Windows.Forms.Button()
		Me.SuspendLayout
		'
		'ComedyButton
		'
		Me.ComedyButton.Location = New System.Drawing.Point(12, 12)
		Me.ComedyButton.Name = "ComedyButton"
		Me.ComedyButton.Size = New System.Drawing.Size(100, 23)
		Me.ComedyButton.TabIndex = 0
		Me.ComedyButton.Text = "&Comedy"
		Me.ComedyButton.UseVisualStyleBackColor = true
		AddHandler Me.ComedyButton.Click, AddressOf Me.ComedyButtonClick
		'
		'DramaButton
		'
		Me.DramaButton.Location = New System.Drawing.Point(12, 41)
		Me.DramaButton.Name = "DramaButton"
		Me.DramaButton.Size = New System.Drawing.Size(100, 23)
		Me.DramaButton.TabIndex = 1
		Me.DramaButton.Text = "&Drama"
		Me.DramaButton.UseVisualStyleBackColor = true
		AddHandler Me.DramaButton.Click, AddressOf Me.DramaButtonClick
		'
		'ActionButton
		'
		Me.ActionButton.Location = New System.Drawing.Point(12, 70)
		Me.ActionButton.Name = "ActionButton"
		Me.ActionButton.Size = New System.Drawing.Size(100, 23)
		Me.ActionButton.TabIndex = 2
		Me.ActionButton.Text = "&Action"
		Me.ActionButton.UseVisualStyleBackColor = true
		AddHandler Me.ActionButton.Click, AddressOf Me.ActionButtonClick
		'
		'SciFiButton
		'
		Me.SciFiButton.Location = New System.Drawing.Point(12, 99)
		Me.SciFiButton.Name = "SciFiButton"
		Me.SciFiButton.Size = New System.Drawing.Size(100, 23)
		Me.SciFiButton.TabIndex = 3
		Me.SciFiButton.Text = "&Sci-Fi"
		Me.SciFiButton.UseVisualStyleBackColor = true
		AddHandler Me.SciFiButton.Click, AddressOf Me.SciFiButtonClick
		'
		'HorrorButton
		'
		Me.HorrorButton.Location = New System.Drawing.Point(12, 128)
		Me.HorrorButton.Name = "HorrorButton"
		Me.HorrorButton.Size = New System.Drawing.Size(100, 23)
		Me.HorrorButton.TabIndex = 4
		Me.HorrorButton.Text = "&Horror"
		Me.HorrorButton.UseVisualStyleBackColor = true
		AddHandler Me.HorrorButton.Click, AddressOf Me.HorrorButtonClick
		'
		'NewReleasesButton
		'
		Me.NewReleasesButton.Location = New System.Drawing.Point(12, 157)
		Me.NewReleasesButton.Name = "NewReleasesButton"
		Me.NewReleasesButton.Size = New System.Drawing.Size(100, 23)
		Me.NewReleasesButton.TabIndex = 5
		Me.NewReleasesButton.Text = "&New Releases"
		Me.NewReleasesButton.UseVisualStyleBackColor = true
		AddHandler Me.NewReleasesButton.Click, AddressOf Me.NewReleasesButtonClick
		'
		'label1
		'
		Me.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.label1.Location = New System.Drawing.Point(125, 17)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(100, 23)
		Me.label1.TabIndex = 6
		'
		'label2
		'
		Me.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.label2.Location = New System.Drawing.Point(125, 41)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(100, 23)
		Me.label2.TabIndex = 7
		'
		'label3
		'
		Me.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.label3.Location = New System.Drawing.Point(125, 70)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(100, 23)
		Me.label3.TabIndex = 8
		'
		'label4
		'
		Me.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.label4.Location = New System.Drawing.Point(125, 99)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(100, 25)
		Me.label4.TabIndex = 9
		'
		'label5
		'
		Me.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.label5.Location = New System.Drawing.Point(125, 128)
		Me.label5.Name = "label5"
		Me.label5.Size = New System.Drawing.Size(100, 23)
		Me.label5.TabIndex = 10
		'
		'label6
		'
		Me.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.label6.Location = New System.Drawing.Point(125, 157)
		Me.label6.Name = "label6"
		Me.label6.Size = New System.Drawing.Size(100, 23)
		Me.label6.TabIndex = 11
		'
		'ExitButton
		'
		Me.ExitButton.Location = New System.Drawing.Point(12, 200)
		Me.ExitButton.Name = "ExitButton"
		Me.ExitButton.Size = New System.Drawing.Size(75, 23)
		Me.ExitButton.TabIndex = 12
		Me.ExitButton.Text = "&Exit"
		Me.ExitButton.UseVisualStyleBackColor = true
		AddHandler Me.ExitButton.Click, AddressOf Me.ExitButtonClick
		'
		'RestButton
		'
		Me.RestButton.Location = New System.Drawing.Point(125, 200)
		Me.RestButton.Name = "RestButton"
		Me.RestButton.Size = New System.Drawing.Size(75, 23)
		Me.RestButton.TabIndex = 13
		Me.RestButton.Text = "&Reset"
		Me.RestButton.UseVisualStyleBackColor = true
		AddHandler Me.RestButton.Click, AddressOf Me.RestButtonClick
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(284, 262)
		Me.Controls.Add(Me.RestButton)
		Me.Controls.Add(Me.ExitButton)
		Me.Controls.Add(Me.label6)
		Me.Controls.Add(Me.label5)
		Me.Controls.Add(Me.label4)
		Me.Controls.Add(Me.label3)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.label1)
		Me.Controls.Add(Me.NewReleasesButton)
		Me.Controls.Add(Me.HorrorButton)
		Me.Controls.Add(Me.SciFiButton)
		Me.Controls.Add(Me.ActionButton)
		Me.Controls.Add(Me.DramaButton)
		Me.Controls.Add(Me.ComedyButton)
		Me.Name = "MainForm"
		Me.Text = "CaseStudyVideoBonanza"
		Me.ResumeLayout(false)
	End Sub
	Private RestButton As System.Windows.Forms.Button
	Private ExitButton As System.Windows.Forms.Button
	Private label6 As System.Windows.Forms.Label
	Private label5 As System.Windows.Forms.Label
	Private label4 As System.Windows.Forms.Label
	Private label3 As System.Windows.Forms.Label
	Private label2 As System.Windows.Forms.Label
	Private label1 As System.Windows.Forms.Label
	Private NewReleasesButton As System.Windows.Forms.Button
	Private HorrorButton As System.Windows.Forms.Button
	Private SciFiButton As System.Windows.Forms.Button
	Private ActionButton As System.Windows.Forms.Button
	Private DramaButton As System.Windows.Forms.Button
	Private ComedyButton As System.Windows.Forms.Button
End Class
