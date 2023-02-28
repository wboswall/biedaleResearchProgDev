'
' Created by SharpDevelop.
' User: weboswall
' Date: 4/14/2016
' Time: 11:23 AM

'Ch1 R'n R Reading and Refreshment
'Programmer: Bradley/Millspaugh
'Date: June 2008
'Description: This project displays current promotions for each department.
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
	
	Sub BooksButtonClick(sender As Object, e As EventArgs)
		'Display the current promotion.
		PromotionLabel.Text="Buy two, get the second one for half price."
		PromotionCodeLabel.Text="B606"
	End Sub
	
	Sub MusicButtonClick(sender As Object, e As EventArgs)
		'Display the current promotion.
		PromotionLabel.Text="Get a free MP3 download with purchase of a CD."
		PromotionCodeLabel.Text="M606"
	End Sub
	
	Sub PeriodicalsButtonClick(sender As Object, e As EventArgs)
		'Display the current promotion.
		PromotionLabel.Text="Elite members receive 10% off everypurchase."
		PromotionCodeLabel.Text="P606"
	End Sub
	
	Sub CoffeeBarButtonClick(sender As Object, e As EventArgs)
		'Display the current promotion.
		PromotionLabel.Text="Celebrate the seasion with 20% off speciality drinks."
		PromotionCodeLabel.Text="C606"
	End Sub
	
	Sub ResetButtonClick(sender As Object, e As EventArgs)
		PromotionLabel.Clear()
		PromotionCodeLabel.Clear()
	End Sub
	
	Sub RestartButtonClick(sender As Object, e As EventArgs)
		Application.Restart()
	End Sub
End Class
