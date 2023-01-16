'
' Created by SharpDevelop.
' User: weboswall
' Date: 4/14/2016
' Time: 1:40 PM
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
	
	Sub CustomerRelationsButtonClick(sender As Object, e As EventArgs)
		label4.Text="Tricia  Mills"
		label5.Text="500-1111"
	End Sub
	
	Sub MarketingButtonClick(sender As Object, e As EventArgs)
		label6.Text="Michelle Rigner"
		label7.Text="500-2222"
	End Sub
	
	Sub OrderProcessingButtonClick(sender As Object, e As EventArgs)
		label8.Text="Kenna DeVoss"
		label9.Text="500-3333"
	End Sub
	
	Sub ShippingButtonClick(sender As Object, e As EventArgs)
		label10.Text="Eric Andrews"
		label11.Text="500-4444"
	End Sub
	
	Sub ExitButtonClick(sender As Object, e As EventArgs)
		Application.Exit()
	End Sub
	
	Sub ResetButtonClick(sender As Object, e As EventArgs)
		label4.ResetText()
		label5.ResetText()
		label6.ResetText()
		label7.ResetText()
		label8.ResetText()
		label9.ResetText()
		label10.ResetText()
		label11.ResetText()
	End Sub
End Class
