'
' Created by SharpDevelop.
' User: weboswall
' Date: 4/18/2016
' Time: 12:54 PM
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
	
	Sub FirstSayingButtonClick(sender As Object, e As EventArgs)
		label1.Text="A penny saved is a penny earned."
	End Sub
	
	Sub SecondSayingButtonClick(sender As Object, e As EventArgs)
		label2.Text="The early bird gets the worm."
	End Sub
	
	Sub ThirdSayingButtonClick(sender As Object, e As EventArgs)
		Label3.Text="A penny for your thoughts."
	End Sub
	
	Sub FourthSayingButtonClick(sender As Object, e As EventArgs)
		label4.Text="An insult to injury."
	End Sub
	
	Sub ResetButtonClick(sender As Object, e As EventArgs)
		label1.ResetText()
		label2.ResetText()
		label3.ResetText()
		label4.ResetText()
	End Sub
	
	Sub ExitButtonClick(sender As Object, e As EventArgs)
		Application.Exit()
	End Sub
End Class
