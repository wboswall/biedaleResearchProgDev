'
' Created by SharpDevelop.
' User: weboswall
' Date: 4/18/2016
' Time: 1:42 PM
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
	
	Sub PersonButtonClick(sender As Object, e As EventArgs)
		label1.Text="Willie Boswall"
	End Sub
	
	Sub DepartmentButtonClick(sender As Object, e As EventArgs)
		label2.Text="Traditional Programming"
	End Sub
	
	Sub PhoneNumberButtonClick(sender As Object, e As EventArgs)
		label3.Text="902-628-7892 ext:709"
	End Sub
	
	Sub ExitButtonClick(sender As Object, e As EventArgs)
		Application.Exit()
	End Sub
	
	Sub ResetButtonClick(sender As Object, e As EventArgs)
		label1.ResetText()
		label2.ResetText()
		label3.ResetText()
	End Sub
End Class
