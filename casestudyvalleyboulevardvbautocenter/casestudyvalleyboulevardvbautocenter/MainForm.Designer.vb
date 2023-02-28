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
		Me.AutoSalesButton = New System.Windows.Forms.Button()
		Me.ServiceCenterButton = New System.Windows.Forms.Button()
		Me.DetailShop = New System.Windows.Forms.Button()
		Me.EmploymentOpportunitiesButton = New System.Windows.Forms.Button()
		Me.label1 = New System.Windows.Forms.Label()
		Me.label2 = New System.Windows.Forms.Label()
		Me.label3 = New System.Windows.Forms.Label()
		Me.label4 = New System.Windows.Forms.Label()
		Me.ExitButton = New System.Windows.Forms.Button()
		Me.ResetButton = New System.Windows.Forms.Button()
		Me.SuspendLayout
		'
		'AutoSalesButton
		'
		Me.AutoSalesButton.Location = New System.Drawing.Point(12, 12)
		Me.AutoSalesButton.Name = "AutoSalesButton"
		Me.AutoSalesButton.Size = New System.Drawing.Size(182, 23)
		Me.AutoSalesButton.TabIndex = 0
		Me.AutoSalesButton.Text = "&Auto Sales"
		Me.AutoSalesButton.UseVisualStyleBackColor = true
		AddHandler Me.AutoSalesButton.Click, AddressOf Me.AutoSalesButtonClick
		'
		'ServiceCenterButton
		'
		Me.ServiceCenterButton.Location = New System.Drawing.Point(12, 51)
		Me.ServiceCenterButton.Name = "ServiceCenterButton"
		Me.ServiceCenterButton.Size = New System.Drawing.Size(182, 23)
		Me.ServiceCenterButton.TabIndex = 1
		Me.ServiceCenterButton.Text = "&Service Center"
		Me.ServiceCenterButton.UseVisualStyleBackColor = true
		AddHandler Me.ServiceCenterButton.Click, AddressOf Me.ServiceCenterButtonClick
		'
		'DetailShop
		'
		Me.DetailShop.Location = New System.Drawing.Point(12, 89)
		Me.DetailShop.Name = "DetailShop"
		Me.DetailShop.Size = New System.Drawing.Size(182, 23)
		Me.DetailShop.TabIndex = 2
		Me.DetailShop.Text = "&Service Center"
		Me.DetailShop.UseVisualStyleBackColor = true
		AddHandler Me.DetailShop.Click, AddressOf Me.DetailShopClick
		'
		'EmploymentOpportunitiesButton
		'
		Me.EmploymentOpportunitiesButton.Location = New System.Drawing.Point(12, 127)
		Me.EmploymentOpportunitiesButton.Name = "EmploymentOpportunitiesButton"
		Me.EmploymentOpportunitiesButton.Size = New System.Drawing.Size(182, 23)
		Me.EmploymentOpportunitiesButton.TabIndex = 3
		Me.EmploymentOpportunitiesButton.Text = "&Employment Opportunities"
		Me.EmploymentOpportunitiesButton.UseVisualStyleBackColor = true
		AddHandler Me.EmploymentOpportunitiesButton.Click, AddressOf Me.EmploymentOpportunitiesButtonClick
		'
		'label1
		'
		Me.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.label1.Location = New System.Drawing.Point(218, 16)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(315, 23)
		Me.label1.TabIndex = 4
		'
		'label2
		'
		Me.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.label2.Location = New System.Drawing.Point(218, 55)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(315, 23)
		Me.label2.TabIndex = 5
		'
		'label3
		'
		Me.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.label3.Location = New System.Drawing.Point(218, 93)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(315, 23)
		Me.label3.TabIndex = 6
		'
		'label4
		'
		Me.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.label4.Location = New System.Drawing.Point(218, 126)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(315, 23)
		Me.label4.TabIndex = 7
		'
		'ExitButton
		'
		Me.ExitButton.Location = New System.Drawing.Point(12, 177)
		Me.ExitButton.Name = "ExitButton"
		Me.ExitButton.Size = New System.Drawing.Size(75, 23)
		Me.ExitButton.TabIndex = 8
		Me.ExitButton.Text = "&Exit"
		Me.ExitButton.UseVisualStyleBackColor = true
		AddHandler Me.ExitButton.Click, AddressOf Me.ExitButtonClick
		'
		'ResetButton
		'
		Me.ResetButton.Location = New System.Drawing.Point(149, 177)
		Me.ResetButton.Name = "ResetButton"
		Me.ResetButton.Size = New System.Drawing.Size(75, 23)
		Me.ResetButton.TabIndex = 9
		Me.ResetButton.Text = "&Reset"
		Me.ResetButton.UseVisualStyleBackColor = true
		AddHandler Me.ResetButton.Click, AddressOf Me.ResetButtonClick
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(545, 262)
		Me.Controls.Add(Me.ResetButton)
		Me.Controls.Add(Me.ExitButton)
		Me.Controls.Add(Me.label4)
		Me.Controls.Add(Me.label3)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.label1)
		Me.Controls.Add(Me.EmploymentOpportunitiesButton)
		Me.Controls.Add(Me.DetailShop)
		Me.Controls.Add(Me.ServiceCenterButton)
		Me.Controls.Add(Me.AutoSalesButton)
		Me.Name = "MainForm"
		Me.Text = "CaseStudyValleyBoulevardVBAutoCenter"
		Me.ResumeLayout(false)
	End Sub
	Private ResetButton As System.Windows.Forms.Button
	Private ExitButton As System.Windows.Forms.Button
	Private label4 As System.Windows.Forms.Label
	Private label3 As System.Windows.Forms.Label
	Private label2 As System.Windows.Forms.Label
	Private label1 As System.Windows.Forms.Label
	Private EmploymentOpportunitiesButton As System.Windows.Forms.Button
	Private DetailShop As System.Windows.Forms.Button
	Private ServiceCenterButton As System.Windows.Forms.Button
	Private AutoSalesButton As System.Windows.Forms.Button
End Class
