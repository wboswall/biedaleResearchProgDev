'
' Created by SharpDevelop.
' User: weboswall
' Date: 4/18/2016
' Time: 10:13 AM
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
	
	Sub EnglishButtonClick(sender As Object, e As EventArgs)
		DisplayLabel.Text="Hello World!"
	End Sub
	
	Sub SpanishButtonClick(sender As Object, e As EventArgs)
		DisplayLabel.Text="Hola Mundo!"
	End Sub
	
	Sub ResetButtonClick(sender As Object, e As EventArgs)
		DisplayLabel.Text="Will Display"+" "+"Hello World!"+" "+"In Different Languages."
	End Sub
	
	Sub FrenchButtonClick(sender As Object, e As EventArgs)
		DisplayLabel.Text="Bonjour le monde!"
	End Sub
	
	Sub ItalianButtonClick(sender As Object, e As EventArgs)
		DisplayLabel.Text="Ciao mondo!"
	End Sub
	
	Sub ExitButtonClick(sender As Object, e As EventArgs)
		Application.Exit()
	End Sub
End Class
