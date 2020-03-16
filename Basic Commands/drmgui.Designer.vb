'
' Created by SharpDevelop.
' User: bharr0
' Date: 6/03/2018
' Time: 2:48 PM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class drmgui
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
		Me.groupBox1 = New System.Windows.Forms.GroupBox()
		Me.textBox1 = New System.Windows.Forms.TextBox()
		Me.groupBox2 = New System.Windows.Forms.GroupBox()
		Me.textBox2 = New System.Windows.Forms.TextBox()
		Me.groupBox3 = New System.Windows.Forms.GroupBox()
		Me.textBox3 = New System.Windows.Forms.TextBox()
		Me.button1 = New System.Windows.Forms.Button()
		Me.groupBox4 = New System.Windows.Forms.GroupBox()
		Me.textBox4 = New System.Windows.Forms.TextBox()
		Me.groupBox1.SuspendLayout
		Me.groupBox2.SuspendLayout
		Me.groupBox3.SuspendLayout
		Me.groupBox4.SuspendLayout
		Me.SuspendLayout
		'
		'groupBox1
		'
		Me.groupBox1.Controls.Add(Me.textBox1)
		Me.groupBox1.Location = New System.Drawing.Point(9, 9)
		Me.groupBox1.Margin = New System.Windows.Forms.Padding(2)
		Me.groupBox1.Name = "groupBox1"
		Me.groupBox1.Padding = New System.Windows.Forms.Padding(2)
		Me.groupBox1.Size = New System.Drawing.Size(202, 45)
		Me.groupBox1.TabIndex = 0
		Me.groupBox1.TabStop = false
		Me.groupBox1.Text = "Serial Key"
		'
		'textBox1
		'
		Me.textBox1.Location = New System.Drawing.Point(5, 20)
		Me.textBox1.Margin = New System.Windows.Forms.Padding(2)
		Me.textBox1.Name = "textBox1"
		Me.textBox1.ReadOnly = true
		Me.textBox1.Size = New System.Drawing.Size(193, 21)
		Me.textBox1.TabIndex = 0
		'
		'groupBox2
		'
		Me.groupBox2.Controls.Add(Me.textBox2)
		Me.groupBox2.Location = New System.Drawing.Point(9, 59)
		Me.groupBox2.Margin = New System.Windows.Forms.Padding(2)
		Me.groupBox2.Name = "groupBox2"
		Me.groupBox2.Padding = New System.Windows.Forms.Padding(2)
		Me.groupBox2.Size = New System.Drawing.Size(202, 48)
		Me.groupBox2.TabIndex = 1
		Me.groupBox2.TabStop = false
		Me.groupBox2.Text = "Owner"
		'
		'textBox2
		'
		Me.textBox2.Location = New System.Drawing.Point(5, 20)
		Me.textBox2.Margin = New System.Windows.Forms.Padding(2)
		Me.textBox2.Name = "textBox2"
		Me.textBox2.ReadOnly = true
		Me.textBox2.Size = New System.Drawing.Size(193, 21)
		Me.textBox2.TabIndex = 0
		'
		'groupBox3
		'
		Me.groupBox3.Controls.Add(Me.textBox3)
		Me.groupBox3.Location = New System.Drawing.Point(9, 112)
		Me.groupBox3.Margin = New System.Windows.Forms.Padding(2)
		Me.groupBox3.Name = "groupBox3"
		Me.groupBox3.Padding = New System.Windows.Forms.Padding(2)
		Me.groupBox3.Size = New System.Drawing.Size(202, 44)
		Me.groupBox3.TabIndex = 2
		Me.groupBox3.TabStop = false
		Me.groupBox3.Text = "Product Name"
		'
		'textBox3
		'
		Me.textBox3.Location = New System.Drawing.Point(5, 19)
		Me.textBox3.Margin = New System.Windows.Forms.Padding(2)
		Me.textBox3.Name = "textBox3"
		Me.textBox3.ReadOnly = true
		Me.textBox3.Size = New System.Drawing.Size(193, 21)
		Me.textBox3.TabIndex = 0
		'
		'button1
		'
		Me.button1.Location = New System.Drawing.Point(9, 160)
		Me.button1.Margin = New System.Windows.Forms.Padding(2)
		Me.button1.Name = "button1"
		Me.button1.Size = New System.Drawing.Size(407, 23)
		Me.button1.TabIndex = 3
		Me.button1.Text = "Activate"
		Me.button1.UseVisualStyleBackColor = true
		AddHandler Me.button1.Click, AddressOf Me.Button1Click
		'
		'groupBox4
		'
		Me.groupBox4.Controls.Add(Me.textBox4)
		Me.groupBox4.Location = New System.Drawing.Point(216, 9)
		Me.groupBox4.Name = "groupBox4"
		Me.groupBox4.Size = New System.Drawing.Size(200, 147)
		Me.groupBox4.TabIndex = 4
		Me.groupBox4.TabStop = false
		Me.groupBox4.Text = "Activation Key"
		'
		'textBox4
		'
		Me.textBox4.Location = New System.Drawing.Point(7, 20)
		Me.textBox4.Multiline = true
		Me.textBox4.Name = "textBox4"
		Me.textBox4.Size = New System.Drawing.Size(187, 121)
		Me.textBox4.TabIndex = 0
		'
		'drmgui
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7!, 15!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(426, 188)
		Me.Controls.Add(Me.groupBox4)
		Me.Controls.Add(Me.button1)
		Me.Controls.Add(Me.groupBox3)
		Me.Controls.Add(Me.groupBox2)
		Me.Controls.Add(Me.groupBox1)
		Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Margin = New System.Windows.Forms.Padding(2)
		Me.MaximizeBox = false
		Me.MinimizeBox = false
		Me.Name = "drmgui"
		Me.ShowIcon = false
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "GrandDRM"
		AddHandler Load, AddressOf Me.DrmguiLoad
		Me.groupBox1.ResumeLayout(false)
		Me.groupBox1.PerformLayout
		Me.groupBox2.ResumeLayout(false)
		Me.groupBox2.PerformLayout
		Me.groupBox3.ResumeLayout(false)
		Me.groupBox3.PerformLayout
		Me.groupBox4.ResumeLayout(false)
		Me.groupBox4.PerformLayout
		Me.ResumeLayout(false)
	End Sub
	Private textBox4 As System.Windows.Forms.TextBox
	Private groupBox4 As System.Windows.Forms.GroupBox
	Private button1 As System.Windows.Forms.Button
	Private textBox3 As System.Windows.Forms.TextBox
	Private groupBox3 As System.Windows.Forms.GroupBox
	Private textBox2 As System.Windows.Forms.TextBox
	Private groupBox2 As System.Windows.Forms.GroupBox
	Private textBox1 As System.Windows.Forms.TextBox
	Private groupBox1 As System.Windows.Forms.GroupBox
End Class
