'
' Created by SharpDevelop.
' User: bharr0
' Date: 7/02/2018
' Time: 12:34 PM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Partial Class spawnnewobject
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	Sub Button1Click(sender As Object, e As EventArgs)
		If colorDialog1.ShowDialog = DialogResult.OK Then
			label2.ForeColor = colorDialog1.color
		End If
	End Sub
	
	Sub Button2Click(sender As Object, e As EventArgs)
		Dim itemToAdd As String = MainForm.listbox1.selecteditem.ToString.Replace("colour",colorDialog1.color.tostring)
		itemToAdd = itemToAdd.Replace("sizex",NumericUpDown1.value)
		itemToAdd = itemToAdd.Replace("sizey",NumericUpDown2.value)
		itemToAdd = itemToAdd.Replace("locx",NumericUpDown3.value)
		itemToAdd = itemToAdd.Replace("locy",NumericUpDown4.value)
		MainForm.listbox2.Items.Add(itemToAdd)
		Me.Close
	End Sub
	
	Sub SpawnnewobjectLoad(sender As Object, e As EventArgs)
		ColorDialog1.Color = Color.Black
		label2.ForeColor = Color.Black
		numericUpDown1.Value = 8
		numericUpDown2.Value = 8
		numericUpDown3.Value = 0
		numericUpDown4.Value = 0
	End Sub
End Class
