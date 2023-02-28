'
' Created by SharpDevelop.
' User: weboswall
' Date: 4/18/2016
' Time: 12:34 PM
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
		Me.DisplayLabel = New System.Windows.Forms.Label()
		Me.DisplayButton = New System.Windows.Forms.Button()
		Me.ExitButton = New System.Windows.Forms.Button()
		Me.SuspendLayout
		'
		'DisplayLabel
		'
		Me.DisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.DisplayLabel.Font = New System.Drawing.Font("TypoUpright BT", 72!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.DisplayLabel.Location = New System.Drawing.Point(26, 17)
		Me.DisplayLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
		Me.DisplayLabel.Name = "DisplayLabel"
		Me.DisplayLabel.Size = New System.Drawing.Size(760, 118)
		Me.DisplayLabel.TabIndex = 0
		Me.DisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'DisplayButton
		'
		Me.DisplayButton.Font = New System.Drawing.Font("Bookman Old Style", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.DisplayButton.Location = New System.Drawing.Point(149, 151)
		Me.DisplayButton.Margin = New System.Windows.Forms.Padding(6)
		Me.DisplayButton.Name = "DisplayButton"
		Me.DisplayButton.Size = New System.Drawing.Size(162, 76)
		Me.DisplayButton.TabIndex = 1
		Me.DisplayButton.Text = "&Display Greeting"
		Me.DisplayButton.UseVisualStyleBackColor = true
		AddHandler Me.DisplayButton.Click, AddressOf Me.DisplayButtonClick
		'
		'ExitButton
		'
		Me.ExitButton.Font = New System.Drawing.Font("Bookman Old Style", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.ExitButton.Location = New System.Drawing.Point(547, 151)
		Me.ExitButton.Margin = New System.Windows.Forms.Padding(6)
		Me.ExitButton.Name = "ExitButton"
		Me.ExitButton.Size = New System.Drawing.Size(162, 42)
		Me.ExitButton.TabIndex = 2
		Me.ExitButton.Text = "&Exit"
		Me.ExitButton.UseVisualStyleBackColor = true
		AddHandler Me.ExitButton.Click, AddressOf Me.ExitButtonClick
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(13!, 24!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(801, 242)
		Me.Controls.Add(Me.ExitButton)
		Me.Controls.Add(Me.DisplayButton)
		Me.Controls.Add(Me.DisplayLabel)
		Me.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.Margin = New System.Windows.Forms.Padding(6)
		Me.Name = "MainForm"
		Me.Text = "Greeting"
		Me.ResumeLayout(false)
	End Sub
	Private ExitButton As System.Windows.Forms.Button
	Private DisplayButton As System.Windows.Forms.Button
	Private DisplayLabel As System.Windows.Forms.Label
End Class
