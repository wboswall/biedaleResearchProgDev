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
	
	Sub ComedyButtonClick(sender As Object, e As EventArgs)
		label1.Text="Aisle 1"
	End Sub
	
	Sub DramaButtonClick(sender As Object, e As EventArgs)
		label2.Text="Aisle 2"
	End Sub
	
	Sub ActionButtonClick(sender As Object, e As EventArgs)
		label3.Text="Aisle 3"
	End Sub
	
	Sub SciFiButtonClick(sender As Object, e As EventArgs)
		label4.Text="Aisle 4"
	End Sub
	
	Sub HorrorButtonClick(sender As Object, e As EventArgs)
		label5.Text="Aisle 5"
	End Sub
	
	Sub NewReleasesButtonClick(sender As Object, e As EventArgs)
		label6.Text="Back Wall"
	End Sub
	
	Sub ExitButtonClick(sender As Object, e As EventArgs)
		Application.Exit()
	End Sub
	
	Sub RestButtonClick(sender As Object, e As EventArgs)
		label1.ResetText()
		label2.ResetText()
		label3.ResetText()
		label4.ResetText()
		label5.ResetText()
		label6.ResetText()
	End Sub
End Class
