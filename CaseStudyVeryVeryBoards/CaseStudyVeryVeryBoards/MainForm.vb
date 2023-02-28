'
' Created by SharpDevelop.
' User: weboswall
' Date: 4/14/2016
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
	
	Sub DownTownButtonClick(sender As Object, e As EventArgs)
		label1.Text="Hours 8am-12am 66 St.Louis Blvd."
	End Sub
	
	Sub MallButtonClick(sender As Object, e As EventArgs)
		label2.Text="Hours 6am-10pm 55 Gerald's Street"
	End Sub
	
	Sub SuburbsButtonClick(sender As Object, e As EventArgs)
		label3.Text="Hours 8:30am-11pm 77 St.La Loch Rd."
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
