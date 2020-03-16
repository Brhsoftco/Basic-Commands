Imports Microsoft.VisualBasic.ApplicationServices
'
' Created by SharpDevelop.
' User: bharr0
' Date: 6/03/2018
' Time: 2:48 PM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Partial Class drmgui
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	
	Sub DrmguiLoad(sender As Object, e As EventArgs)
		Dim gdrm_ As New GDRM
		gdrm_.onload(textBox1,textBox2,textBox3,MainForm,Me,"oeirhgio3hg8wrioht89498536984h$*(%($(","Basic Commands","Educational Edition")
	End Sub
	
	Sub Button1Click(sender As Object, e As EventArgs)
		Dim gdrm_ As New GDRM
		gdrm_.main("oeirhgio3hg8wrioht89498536984h$*(%($(",textBox4.Text,textBox1.Text,Me,MainForm,"commasters.activation@outlook.com.au","Basic Commands","Educational Edition")
	End Sub
End Class