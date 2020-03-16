'
' Created by SharpDevelop.
' User: bharr0
' Date: 5/02/2018
' Time: 12:00 PM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class PlayScriptThrough
	Inherits System.Windows.Forms.Form
	
	''' <summary>
	''' Designer variable used to keep track of non-visual components.
	''' </summary>
	Private components As System.ComponentModel.IContainer
	
	''' <summary>
	''' Disposes resources used by the form.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	
	''' <summary>
	''' This method is required for Windows Forms designer support.
	''' Do not change the method contents inside the source code editor. The Forms designer might
	''' not be able to load this method if it was changed manually.
	''' </summary>
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.pictureBox1 = New System.Windows.Forms.PictureBox()
		Me.pictureBox2 = New System.Windows.Forms.PictureBox()
		Me.label1 = New System.Windows.Forms.Label()
		Me.timer1 = New System.Windows.Forms.Timer(Me.components)
		Me.label2 = New System.Windows.Forms.Label()
		CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.pictureBox2,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'pictureBox1
		'
		Me.pictureBox1.BackColor = System.Drawing.Color.Black
		Me.pictureBox1.Location = New System.Drawing.Point(42, 217)
		Me.pictureBox1.Name = "pictureBox1"
		Me.pictureBox1.Size = New System.Drawing.Size(32, 32)
		Me.pictureBox1.TabIndex = 0
		Me.pictureBox1.TabStop = false
		'
		'pictureBox2
		'
		Me.pictureBox2.BackColor = System.Drawing.Color.Black
		Me.pictureBox2.Location = New System.Drawing.Point(80, 230)
		Me.pictureBox2.Name = "pictureBox2"
		Me.pictureBox2.Size = New System.Drawing.Size(8, 8)
		Me.pictureBox2.TabIndex = 1
		Me.pictureBox2.TabStop = false
		'
		'label1
		'
		Me.label1.Location = New System.Drawing.Point(712, 9)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(91, 35)
		Me.label1.TabIndex = 2
		Me.label1.Text = "Current Direction:"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"right"
		'
		'timer1
		'
		AddHandler Me.timer1.Tick, AddressOf Me.Timer1Tick
		'
		'label2
		'
		Me.label2.Location = New System.Drawing.Point(558, 9)
		Me.label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(149, 49)
		Me.label2.TabIndex = 3
		Me.label2.Text = "Current Action:"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Static"
		'
		'PlayScriptThrough
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.LightGray
		Me.ClientSize = New System.Drawing.Size(815, 559)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.label1)
		Me.Controls.Add(Me.pictureBox2)
		Me.Controls.Add(Me.pictureBox1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Name = "PlayScriptThrough"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "PlayScriptThrough"
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		AddHandler Shown, AddressOf Me.PlayScriptThroughShown
		CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.pictureBox2,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
	End Sub
	Private label2 As System.Windows.Forms.Label
	Private timer1 As System.Windows.Forms.Timer
	Private label1 As System.Windows.Forms.Label
	Private pictureBox2 As System.Windows.Forms.PictureBox
	Private pictureBox1 As System.Windows.Forms.PictureBox
End Class
