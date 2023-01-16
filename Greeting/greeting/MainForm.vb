'Greeting
'
' Created by SharpDevelop.
' User: weboswall
' Date: 4/18/2016
' Time: 12:34 PM
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
	
	Sub DisplayButtonClick(sender As Object, e As EventArgs)
		DisplayLabel.Text="Hello and Welcome!"
	End Sub
	
	Sub ExitButtonClick(sender As Object, e As EventArgs)
		Application.Exit()
	End Sub
End Class
