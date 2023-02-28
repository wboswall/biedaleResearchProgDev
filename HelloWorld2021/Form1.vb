Public Class Form1
	Public Property Form1 As Object

	Private Sub ButtonClickMe_Click(sender As Object, e As EventArgs) Handles ButtonClickMe.Click
		'Displays Default Message
		Label1.Text = "Hello World 2021!"
	End Sub

	Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
		'Close the program
		Me.Close()
	End Sub

	Private Sub ButtonClearText_Click(sender As Object, e As EventArgs) Handles ButtonClearText.Click
		'Resets the text to ""
		Label1.ResetText()
	End Sub

	Private Sub ButtonRestartApp_Click(sender As Object, e As EventArgs) Handles ButtonRestartApp.Click
		'Restarts the application
		Application.Restart()

	End Sub

	Private Sub ButtonEnglish_Click(sender As Object, e As EventArgs) Handles ButtonEnglish.Click
		'Displays the classic message in English
		Label1.Text = "Hello World!"
	End Sub

	Private Sub ButtonSpanish_Click(sender As Object, e As EventArgs) Handles ButtonSpanish.Click
		'Displays the classic message in Spanish
		Label1.Text = "Hola Mundo!"
	End Sub

	Private Sub ButtonPrintPreview_Click(sender As Object, e As EventArgs) Handles ButtonPrintPreview.Click
		'Print Preview
		PrintPreviewDialog1.ShowDialog()

	End Sub

	Private Sub ButtonPrint_Click(sender As Object, e As EventArgs) Handles ButtonPrint.Click
		'Print document
		PrintDocument1.Print()
	End Sub
End Class
