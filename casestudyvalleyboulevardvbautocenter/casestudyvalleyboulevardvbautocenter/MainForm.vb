'
' Created by SharpDevelop.
' User: weboswall
' Date: 4/14/2016
' Time: 1:41 PM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Partial Class MainForm
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	Sub AutoSalesButtonClick(sender As Object, e As EventArgs)
		label1.Text="Family wagon, immaculate condition $12,995"
	End Sub
	
	Sub ServiceCenterButtonClick(sender As Object, e As EventArgs)
		label2.Text="Lube, oil, filter $25.99"
	End Sub
	
	Sub DetailShopClick(sender As Object, e As EventArgs)
		label3.Text="Complete detail $79.97 for most cars"
	End Sub
	
	Sub EmploymentOpportunitiesButtonClick(sender As Object, e As EventArgs)
		label4.Text="Sales position, contact Mr. Mann 551-2134 ext. 475"
	End Sub
	
	Sub ExitButtonClick(sender As Object, e As EventArgs)
		Application.Exit()
	End Sub
	
	Sub ResetButtonClick(sender As Object, e As EventArgs)
		label1.ResetText()
		label2.ResetText()
		label3.ResetText()
		label4.ResetText()
	End Sub
End Class
