'
' Created by SharpDevelop.
' User: weboswall
' Date: 4/18/2016
' Time: 2:22 PM
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
	
	Sub SoupOfTheDayButtonClick(sender As Object, e As EventArgs)
		label2.Text="Tortilla Soup"
	End Sub
	
	Sub ChefsSpecialButtonClick(sender As Object, e As EventArgs)
		label3.Text="California Summery Soup"
	End Sub
	
	Sub DailyFishButtonClick(sender As Object, e As EventArgs)
		label4.Text="BC Smoked Natural Catched Salmon NO GMO!"
	End Sub
	
	Sub ResetButtonClick(sender As Object, e As EventArgs)
		label2.ResetText()
		label3.ResetText()
		label4.ResetText()
	End Sub
	
	Sub ExitButtonClick(sender As Object, e As EventArgs)
		Application.Exit()
	End Sub
End Class
