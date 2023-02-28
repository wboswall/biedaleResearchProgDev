'
' Created by SharpDevelop.
' User: weboswall
' Date: 4/18/2016
' Time: 12:54 PM
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
		Me.FirstSayingButton = New System.Windows.Forms.Button()
		Me.SecondSayingButton = New System.Windows.Forms.Button()
		Me.ThirdSayingButton = New System.Windows.Forms.Button()
		Me.FourthSayingButton = New System.Windows.Forms.Button()
		Me.label1 = New System.Windows.Forms.Label()
		Me.label2 = New System.Windows.Forms.Label()
		Me.label3 = New System.Windows.Forms.Label()
		Me.label4 = New System.Windows.Forms.Label()
		Me.ResetButton = New System.Windows.Forms.Button()
		Me.ExitButton = New System.Windows.Forms.Button()
		Me.SuspendLayout
		'
		'FirstSayingButton
		'
		Me.FirstSayingButton.Location = New System.Drawing.Point(14, 4)
		Me.FirstSayingButton.Name = "FirstSayingButton"
		Me.FirstSayingButton.Size = New System.Drawing.Size(89, 23)
		Me.FirstSayingButton.TabIndex = 0
		Me.FirstSayingButton.Text = "&FirstSaying"
		Me.FirstSayingButton.UseVisualStyleBackColor = true
		AddHandler Me.FirstSayingButton.Click, AddressOf Me.FirstSayingButtonClick
		'
		'SecondSayingButton
		'
		Me.SecondSayingButton.Location = New System.Drawing.Point(14, 44)
		Me.SecondSayingButton.Name = "SecondSayingButton"
		Me.SecondSayingButton.Size = New System.Drawing.Size(89, 23)
		Me.SecondSayingButton.TabIndex = 1
		Me.SecondSayingButton.Text = "&SecondSaying"
		Me.SecondSayingButton.UseVisualStyleBackColor = true
		AddHandler Me.SecondSayingButton.Click, AddressOf Me.SecondSayingButtonClick
		'
		'ThirdSayingButton
		'
		Me.ThirdSayingButton.Location = New System.Drawing.Point(14, 78)
		Me.ThirdSayingButton.Name = "ThirdSayingButton"
		Me.ThirdSayingButton.Size = New System.Drawing.Size(89, 23)
		Me.ThirdSayingButton.TabIndex = 2
		Me.ThirdSayingButton.Text = "&ThirdSaying"
		Me.ThirdSayingButton.UseVisualStyleBackColor = true
		AddHandler Me.ThirdSayingButton.Click, AddressOf Me.ThirdSayingButtonClick
		'
		'FourthSayingButton
		'
		Me.FourthSayingButton.Location = New System.Drawing.Point(14, 119)
		Me.FourthSayingButton.Name = "FourthSayingButton"
		Me.FourthSayingButton.Size = New System.Drawing.Size(89, 23)
		Me.FourthSayingButton.TabIndex = 3
		Me.FourthSayingButton.Text = "&FourthSaying"
		Me.FourthSayingButton.UseVisualStyleBackColor = true
		AddHandler Me.FourthSayingButton.Click, AddressOf Me.FourthSayingButtonClick
		'
		'label1
		'
		Me.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label1.Location = New System.Drawing.Point(121, 9)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(479, 23)
		Me.label1.TabIndex = 4
		'
		'label2
		'
		Me.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label2.Location = New System.Drawing.Point(121, 49)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(479, 23)
		Me.label2.TabIndex = 5
		'
		'label3
		'
		Me.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label3.Location = New System.Drawing.Point(121, 83)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(479, 23)
		Me.label3.TabIndex = 6
		'
		'label4
		'
		Me.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label4.Location = New System.Drawing.Point(121, 119)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(479, 23)
		Me.label4.TabIndex = 7
		'
		'ResetButton
		'
		Me.ResetButton.Location = New System.Drawing.Point(14, 162)
		Me.ResetButton.Name = "ResetButton"
		Me.ResetButton.Size = New System.Drawing.Size(75, 23)
		Me.ResetButton.TabIndex = 8
		Me.ResetButton.Text = "&Reset"
		Me.ResetButton.UseVisualStyleBackColor = true
		AddHandler Me.ResetButton.Click, AddressOf Me.ResetButtonClick
		'
		'ExitButton
		'
		Me.ExitButton.Location = New System.Drawing.Point(121, 162)
		Me.ExitButton.Name = "ExitButton"
		Me.ExitButton.Size = New System.Drawing.Size(75, 23)
		Me.ExitButton.TabIndex = 9
		Me.ExitButton.Text = "&Exit"
		Me.ExitButton.UseVisualStyleBackColor = true
		AddHandler Me.ExitButton.Click, AddressOf Me.ExitButtonClick
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(619, 197)
		Me.Controls.Add(Me.ExitButton)
		Me.Controls.Add(Me.ResetButton)
		Me.Controls.Add(Me.label4)
		Me.Controls.Add(Me.label3)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.label1)
		Me.Controls.Add(Me.FourthSayingButton)
		Me.Controls.Add(Me.ThirdSayingButton)
		Me.Controls.Add(Me.SecondSayingButton)
		Me.Controls.Add(Me.FirstSayingButton)
		Me.Name = "MainForm"
		Me.Text = "CommonSayings"
		Me.ResumeLayout(false)
	End Sub
	Private ExitButton As System.Windows.Forms.Button
	Private ResetButton As System.Windows.Forms.Button
	Private label4 As System.Windows.Forms.Label
	Private label3 As System.Windows.Forms.Label
	Private label2 As System.Windows.Forms.Label
	Private label1 As System.Windows.Forms.Label
	Private FourthSayingButton As System.Windows.Forms.Button
	Private ThirdSayingButton As System.Windows.Forms.Button
	Private SecondSayingButton As System.Windows.Forms.Button
	Private FirstSayingButton As System.Windows.Forms.Button
End Class
