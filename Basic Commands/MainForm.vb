'
' Created by SharpDevelop.
' User: bharr0
' Date: 5/02/2018
' Time: 10:32 AM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Partial Class MainForm
	Public ColorForObj As Color = Color.black
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	Sub ListBox1SelectedIndexChanged(sender As Object, e As EventArgs)
		Button2.Enabled = true
		If listBox1.SelectedItem = "ChangeColour(colour)" Or listBox1.SelectedItem = "ChangeBackColour(colour)" Then
			numericUpDown1.DecimalPlaces = 0
			numericUpDown1.Value = 1
			button1.Enabled = True
			numericUpDown1.Enabled = False
		ElseIf listBox1.SelectedItem = "MsgBox(message)" Then
			numericUpDown1.DecimalPlaces = 0
			numericUpDown1.Value = 1
			button1.Enabled = False
			numericUpDown1.Enabled = False
		ElseIf listBox1.SelectedItem = "SpawnObject(colour;sizex;sizey;locx;locy)" Then
			numericUpDown1.DecimalPlaces = 0
			numericUpDown1.Value = 1
			button1.Enabled = False
			numericUpDown1.Enabled = False
		ElseIf listBox1.SelectedItem = "Wait(times)" Then
			numericUpDown1.DecimalPlaces = 2
			button1.Enabled = False
			numericUpDown1.Enabled = True
			label3.ForeColor = Color.Black
		Else
			numericUpDown1.DecimalPlaces = 0
			button1.Enabled = False
			numericUpDown1.Enabled = True
			label3.ForeColor = Color.Black
		End If
	End Sub
	
	Sub Button1Click(sender As Object, e As EventArgs)
		If colordialog1.ShowDialog = DialogResult.OK Then
			Label3.ForeColor = colorDialog1.Color
			ColorForObj = colorDialog1.color
		End If
	End Sub
	
	Sub Button2Click(sender As Object, e As EventArgs)
		If listBox1.SelectedItem = "MsgBox(message)" Then
			Dim message As String = InputBox("Please enter the message to display","Message Prompt")
			If VarType(message)=vbEmpty Then
				Exit Sub
			ElseIf message="" Then
				MsgBox("Nothing was entered; cannot be blank.",vbCritical,"Error While Adding Component")
				Exit Sub
			Else
				listBox2.Items.Add(listBox1.SelectedItem.ToString.Replace("message",message))
				Exit Sub
			End If
		End If
		If listBox1.SelectedItem = "Jump(times,hlf)" Then
			Dim message As String = InputBox("Please enter the High-to-Low Factor (HLF)","High-to-Low Factor Prompt","12")
			If VarType(message)=vbEmpty Then
				Exit Sub
			ElseIf message="" Then
				MsgBox("Nothing was entered; cannot be blank.",vbCritical,"Error While Adding Component")
				Exit Sub
			ElseIf Not IsNumeric(message) Then
				MsgBox("Value was not numeric; must be numeric.",vbCritical,"Error While Adding Component")
				Exit Sub
			Else
				Dim command As String = listBox1.SelectedItem.ToString.Replace("times",numericUpDown1.value)
				command = command.Replace("hlf",message)
				listBox2.Items.Add(command)
				Exit Sub
			End If
		End If
		If listBox1.SelectedItem = "SpawnObject(colour;sizex;sizey;locx;locy)" Then
			spawnnewobject.showdialog
			Exit Sub
		End If
		Button6.Enabled = true
		If listBox1.SelectedItem = "ChangeColour(colour)" Or listBox1.SelectedItem = "ChangeBackColour(colour)" Then
			listBox2.items.Add(listBox1.SelectedItem.ToString.Replace("colour",colorDialog1.Color.tostring()))
		Else
			listBox2.Items.Add(listBox1.SelectedItem.ToString.Replace("times",numericUpDown1.value))
		End If
	End Sub
	
	Sub Button3Click(sender As Object, e As EventArgs)
		If listBox2.SelectedIndex >= 0 Then
			listBox2.Items.RemoveAt(listBox2.selectedindex)
		End If
	End Sub
	
	Sub ListBox2SelectedIndexChanged(sender As Object, e As EventArgs)
		If listBox2.SelectedIndex >= 0 Then
			button3.Enabled = True
		Else
			button3.Enabled = false
		End If
	End Sub
	
	Sub Button4Click(sender As Object, e As EventArgs)
		If listBox2.Items.Count <= 0 Then
			MsgBox("No items in script to play",vbCritical,"Error Loading Script")
			Exit Sub
		Else
			PlayScriptThrough.showdialog
		End If
	End Sub
	
	
	Sub Button5Click(sender As Object, e As EventArgs)
		If openFileDialog1.ShowDialog = DialogResult.OK Then
			Try
				listBox2.Items.clear
				For Each line As String In System.IO.File.ReadAllLines(openfiledialog1.FileName)
					listBox2.Items.Add(line)
				Next
				MsgBox("Successfully imported file",vbInformation,"Success")
			Catch ex As Exception
				MsgBox(ex.ToString,vbCritical,"Error Importing File")
				Exit Sub
			End Try
		End If
	End Sub
	
	Sub Button6Click(sender As Object, e As EventArgs)
		If listBox2.Items.Count = 0 Then
			MsgBox("There is nothing to export! Add some items to the script, and then try again.",vbCritical,"Error Exporting File")
			Exit Sub
		Else
			If saveFileDialog1.ShowDialog = DialogResult.OK Then
				Try
					Dim filecontents As String = ""
					For Each item As String In listBox2.Items
						If filecontents = "" Then
							filecontents = item
						Else
							filecontents = filecontents & vbCrLf & item
						End If
					Next
					System.IO.File.WriteAllText(savefiledialog1.FileName,filecontents)
					MsgBox("Successfully exported to file",vbInformation,"Success")
				Catch ex As Exception
					MsgBox(ex.ToString,vbCritical,"Error Exporting File")
					Exit Sub
				End Try
			End If
		End If
	End Sub
End Class
