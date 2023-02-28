'
' Created by SharpDevelop.
' User: weboswall
' Date: 4/14/2016
' Time: 1:40 PM
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
		Me.CustomerRelationsButton = New System.Windows.Forms.Button()
		Me.MarketingButton = New System.Windows.Forms.Button()
		Me.OrderProcessingButton = New System.Windows.Forms.Button()
		Me.label1 = New System.Windows.Forms.Label()
		Me.label2 = New System.Windows.Forms.Label()
		Me.label3 = New System.Windows.Forms.Label()
		Me.label4 = New System.Windows.Forms.Label()
		Me.label5 = New System.Windows.Forms.Label()
		Me.label6 = New System.Windows.Forms.Label()
		Me.label7 = New System.Windows.Forms.Label()
		Me.label8 = New System.Windows.Forms.Label()
		Me.label9 = New System.Windows.Forms.Label()
		Me.ShippingButton = New System.Windows.Forms.Button()
		Me.label10 = New System.Windows.Forms.Label()
		Me.label11 = New System.Windows.Forms.Label()
		Me.ExitButton = New System.Windows.Forms.Button()
		Me.ResetButton = New System.Windows.Forms.Button()
		Me.SuspendLayout
		'
		'CustomerRelationsButton
		'
		Me.CustomerRelationsButton.Location = New System.Drawing.Point(21, 42)
		Me.CustomerRelationsButton.Name = "CustomerRelationsButton"
		Me.CustomerRelationsButton.Size = New System.Drawing.Size(111, 23)
		Me.CustomerRelationsButton.TabIndex = 0
		Me.CustomerRelationsButton.Text = "&Customer Relations"
		Me.CustomerRelationsButton.UseVisualStyleBackColor = true
		AddHandler Me.CustomerRelationsButton.Click, AddressOf Me.CustomerRelationsButtonClick
		'
		'MarketingButton
		'
		Me.MarketingButton.Location = New System.Drawing.Point(21, 85)
		Me.MarketingButton.Name = "MarketingButton"
		Me.MarketingButton.Size = New System.Drawing.Size(111, 23)
		Me.MarketingButton.TabIndex = 1
		Me.MarketingButton.Text = "&Marketing"
		Me.MarketingButton.UseVisualStyleBackColor = true
		AddHandler Me.MarketingButton.Click, AddressOf Me.MarketingButtonClick
		'
		'OrderProcessingButton
		'
		Me.OrderProcessingButton.Location = New System.Drawing.Point(21, 131)
		Me.OrderProcessingButton.Name = "OrderProcessingButton"
		Me.OrderProcessingButton.Size = New System.Drawing.Size(111, 23)
		Me.OrderProcessingButton.TabIndex = 2
		Me.OrderProcessingButton.Text = "&Order Processing"
		Me.OrderProcessingButton.UseVisualStyleBackColor = true
		AddHandler Me.OrderProcessingButton.Click, AddressOf Me.OrderProcessingButtonClick
		'
		'label1
		'
		Me.label1.Location = New System.Drawing.Point(21, 9)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(100, 23)
		Me.label1.TabIndex = 3
		Me.label1.Text = "Department"
		'
		'label2
		'
		Me.label2.Location = New System.Drawing.Point(178, 9)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(104, 23)
		Me.label2.TabIndex = 4
		Me.label2.Text = "Department Contact"
		'
		'label3
		'
		Me.label3.Location = New System.Drawing.Point(357, 9)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(100, 23)
		Me.label3.TabIndex = 5
		Me.label3.Text = "Telephone Number"
		'
		'label4
		'
		Me.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.label4.Location = New System.Drawing.Point(178, 46)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(122, 23)
		Me.label4.TabIndex = 6
		'
		'label5
		'
		Me.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.label5.Location = New System.Drawing.Point(357, 46)
		Me.label5.Name = "label5"
		Me.label5.Size = New System.Drawing.Size(125, 23)
		Me.label5.TabIndex = 7
		'
		'label6
		'
		Me.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.label6.Location = New System.Drawing.Point(178, 85)
		Me.label6.Name = "label6"
		Me.label6.Size = New System.Drawing.Size(122, 23)
		Me.label6.TabIndex = 8
		'
		'label7
		'
		Me.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.label7.Location = New System.Drawing.Point(357, 85)
		Me.label7.Name = "label7"
		Me.label7.Size = New System.Drawing.Size(125, 23)
		Me.label7.TabIndex = 9
		'
		'label8
		'
		Me.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.label8.Location = New System.Drawing.Point(178, 136)
		Me.label8.Name = "label8"
		Me.label8.Size = New System.Drawing.Size(122, 23)
		Me.label8.TabIndex = 10
		'
		'label9
		'
		Me.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.label9.Location = New System.Drawing.Point(357, 131)
		Me.label9.Name = "label9"
		Me.label9.Size = New System.Drawing.Size(125, 23)
		Me.label9.TabIndex = 11
		'
		'ShippingButton
		'
		Me.ShippingButton.Location = New System.Drawing.Point(21, 178)
		Me.ShippingButton.Name = "ShippingButton"
		Me.ShippingButton.Size = New System.Drawing.Size(111, 23)
		Me.ShippingButton.TabIndex = 12
		Me.ShippingButton.Text = "&Shipping"
		Me.ShippingButton.UseVisualStyleBackColor = true
		AddHandler Me.ShippingButton.Click, AddressOf Me.ShippingButtonClick
		'
		'label10
		'
		Me.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.label10.Location = New System.Drawing.Point(178, 183)
		Me.label10.Name = "label10"
		Me.label10.Size = New System.Drawing.Size(122, 23)
		Me.label10.TabIndex = 13
		'
		'label11
		'
		Me.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.label11.Location = New System.Drawing.Point(357, 178)
		Me.label11.Name = "label11"
		Me.label11.Size = New System.Drawing.Size(125, 23)
		Me.label11.TabIndex = 14
		'
		'ExitButton
		'
		Me.ExitButton.Location = New System.Drawing.Point(21, 227)
		Me.ExitButton.Name = "ExitButton"
		Me.ExitButton.Size = New System.Drawing.Size(111, 23)
		Me.ExitButton.TabIndex = 15
		Me.ExitButton.Text = "&Exit"
		Me.ExitButton.UseVisualStyleBackColor = true
		AddHandler Me.ExitButton.Click, AddressOf Me.ExitButtonClick
		'
		'ResetButton
		'
		Me.ResetButton.Location = New System.Drawing.Point(178, 227)
		Me.ResetButton.Name = "ResetButton"
		Me.ResetButton.Size = New System.Drawing.Size(111, 23)
		Me.ResetButton.TabIndex = 16
		Me.ResetButton.Text = "&Reset"
		Me.ResetButton.UseVisualStyleBackColor = true
		AddHandler Me.ResetButton.Click, AddressOf Me.ResetButtonClick
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(573, 262)
		Me.Controls.Add(Me.ResetButton)
		Me.Controls.Add(Me.ExitButton)
		Me.Controls.Add(Me.label11)
		Me.Controls.Add(Me.label10)
		Me.Controls.Add(Me.ShippingButton)
		Me.Controls.Add(Me.label9)
		Me.Controls.Add(Me.label8)
		Me.Controls.Add(Me.label7)
		Me.Controls.Add(Me.label6)
		Me.Controls.Add(Me.label5)
		Me.Controls.Add(Me.label4)
		Me.Controls.Add(Me.label3)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.label1)
		Me.Controls.Add(Me.OrderProcessingButton)
		Me.Controls.Add(Me.MarketingButton)
		Me.Controls.Add(Me.CustomerRelationsButton)
		Me.Name = "MainForm"
		Me.Text = "CaseStudyVeryBusyVBMailOrder"
		Me.ResumeLayout(false)
	End Sub
	Private ResetButton As System.Windows.Forms.Button
	Private ExitButton As System.Windows.Forms.Button
	Private label11 As System.Windows.Forms.Label
	Private label10 As System.Windows.Forms.Label
	Private ShippingButton As System.Windows.Forms.Button
	Private label9 As System.Windows.Forms.Label
	Private label8 As System.Windows.Forms.Label
	Private label7 As System.Windows.Forms.Label
	Private label6 As System.Windows.Forms.Label
	Private label5 As System.Windows.Forms.Label
	Private label4 As System.Windows.Forms.Label
	Private label3 As System.Windows.Forms.Label
	Private label2 As System.Windows.Forms.Label
	Private label1 As System.Windows.Forms.Label
	Private OrderProcessingButton As System.Windows.Forms.Button
	Private MarketingButton As System.Windows.Forms.Button
	Private CustomerRelationsButton As System.Windows.Forms.Button
End Class
