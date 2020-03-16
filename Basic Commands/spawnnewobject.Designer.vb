'
' Created by SharpDevelop.
' User: bharr0
' Date: 7/02/2018
' Time: 12:34 PM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class spawnnewobject
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
		Me.button1 = New System.Windows.Forms.Button()
		Me.label2 = New System.Windows.Forms.Label()
		Me.label1 = New System.Windows.Forms.Label()
		Me.colorDialog1 = New System.Windows.Forms.ColorDialog()
		Me.groupBox2 = New System.Windows.Forms.GroupBox()
		Me.label4 = New System.Windows.Forms.Label()
		Me.numericUpDown2 = New System.Windows.Forms.NumericUpDown()
		Me.label3 = New System.Windows.Forms.Label()
		Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown()
		Me.groupBox3 = New System.Windows.Forms.GroupBox()
		Me.label5 = New System.Windows.Forms.Label()
		Me.numericUpDown4 = New System.Windows.Forms.NumericUpDown()
		Me.numericUpDown3 = New System.Windows.Forms.NumericUpDown()
		Me.label6 = New System.Windows.Forms.Label()
		Me.button2 = New System.Windows.Forms.Button()
		Me.groupBox1.SuspendLayout
		Me.groupBox2.SuspendLayout
		CType(Me.numericUpDown2,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.numericUpDown1,System.ComponentModel.ISupportInitialize).BeginInit
		Me.groupBox3.SuspendLayout
		CType(Me.numericUpDown4,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.numericUpDown3,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'groupBox1
		'
		Me.groupBox1.Controls.Add(Me.button1)
		Me.groupBox1.Controls.Add(Me.label2)
		Me.groupBox1.Controls.Add(Me.label1)
		Me.groupBox1.Location = New System.Drawing.Point(12, 12)
		Me.groupBox1.Name = "groupBox1"
		Me.groupBox1.Size = New System.Drawing.Size(260, 77)
		Me.groupBox1.TabIndex = 0
		Me.groupBox1.TabStop = false
		Me.groupBox1.Text = "Colour"
		'
		'button1
		'
		Me.button1.Location = New System.Drawing.Point(6, 49)
		Me.button1.Name = "button1"
		Me.button1.Size = New System.Drawing.Size(248, 23)
		Me.button1.TabIndex = 2
		Me.button1.Text = "Change"
		Me.button1.UseVisualStyleBackColor = true
		AddHandler Me.button1.Click, AddressOf Me.Button1Click
		'
		'label2
		'
		Me.label2.Location = New System.Drawing.Point(6, 31)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(158, 15)
		Me.label2.TabIndex = 1
		Me.label2.Text = "XXXXXXXXXXXXXXXX"
		'
		'label1
		'
		Me.label1.Location = New System.Drawing.Point(6, 16)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(47, 15)
		Me.label1.TabIndex = 0
		Me.label1.Text = "Current:"
		'
		'groupBox2
		'
		Me.groupBox2.Controls.Add(Me.label4)
		Me.groupBox2.Controls.Add(Me.numericUpDown2)
		Me.groupBox2.Controls.Add(Me.label3)
		Me.groupBox2.Controls.Add(Me.numericUpDown1)
		Me.groupBox2.Location = New System.Drawing.Point(12, 95)
		Me.groupBox2.Name = "groupBox2"
		Me.groupBox2.Size = New System.Drawing.Size(260, 115)
		Me.groupBox2.TabIndex = 1
		Me.groupBox2.TabStop = false
		Me.groupBox2.Text = "Size"
		'
		'label4
		'
		Me.label4.Location = New System.Drawing.Point(6, 69)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(100, 14)
		Me.label4.TabIndex = 3
		Me.label4.Text = "Y"
		'
		'numericUpDown2
		'
		Me.numericUpDown2.Location = New System.Drawing.Point(6, 86)
		Me.numericUpDown2.Maximum = New Decimal(New Integer() {128, 0, 0, 0})
		Me.numericUpDown2.Minimum = New Decimal(New Integer() {8, 0, 0, 0})
		Me.numericUpDown2.Name = "numericUpDown2"
		Me.numericUpDown2.Size = New System.Drawing.Size(248, 20)
		Me.numericUpDown2.TabIndex = 2
		Me.numericUpDown2.Value = New Decimal(New Integer() {8, 0, 0, 0})
		'
		'label3
		'
		Me.label3.Location = New System.Drawing.Point(6, 20)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(100, 14)
		Me.label3.TabIndex = 1
		Me.label3.Text = "X"
		'
		'numericUpDown1
		'
		Me.numericUpDown1.Location = New System.Drawing.Point(6, 37)
		Me.numericUpDown1.Maximum = New Decimal(New Integer() {128, 0, 0, 0})
		Me.numericUpDown1.Minimum = New Decimal(New Integer() {8, 0, 0, 0})
		Me.numericUpDown1.Name = "numericUpDown1"
		Me.numericUpDown1.Size = New System.Drawing.Size(248, 20)
		Me.numericUpDown1.TabIndex = 0
		Me.numericUpDown1.Value = New Decimal(New Integer() {8, 0, 0, 0})
		'
		'groupBox3
		'
		Me.groupBox3.Controls.Add(Me.label5)
		Me.groupBox3.Controls.Add(Me.numericUpDown4)
		Me.groupBox3.Controls.Add(Me.numericUpDown3)
		Me.groupBox3.Controls.Add(Me.label6)
		Me.groupBox3.Location = New System.Drawing.Point(12, 216)
		Me.groupBox3.Name = "groupBox3"
		Me.groupBox3.Size = New System.Drawing.Size(260, 113)
		Me.groupBox3.TabIndex = 2
		Me.groupBox3.TabStop = false
		Me.groupBox3.Text = "Location"
		'
		'label5
		'
		Me.label5.Location = New System.Drawing.Point(6, 67)
		Me.label5.Name = "label5"
		Me.label5.Size = New System.Drawing.Size(100, 14)
		Me.label5.TabIndex = 7
		Me.label5.Text = "Y"
		'
		'numericUpDown4
		'
		Me.numericUpDown4.Location = New System.Drawing.Point(6, 35)
		Me.numericUpDown4.Maximum = New Decimal(New Integer() {1024, 0, 0, 0})
		Me.numericUpDown4.Name = "numericUpDown4"
		Me.numericUpDown4.Size = New System.Drawing.Size(248, 20)
		Me.numericUpDown4.TabIndex = 4
		'
		'numericUpDown3
		'
		Me.numericUpDown3.Location = New System.Drawing.Point(6, 84)
		Me.numericUpDown3.Maximum = New Decimal(New Integer() {1024, 0, 0, 0})
		Me.numericUpDown3.Name = "numericUpDown3"
		Me.numericUpDown3.Size = New System.Drawing.Size(248, 20)
		Me.numericUpDown3.TabIndex = 6
		'
		'label6
		'
		Me.label6.Location = New System.Drawing.Point(6, 18)
		Me.label6.Name = "label6"
		Me.label6.Size = New System.Drawing.Size(100, 14)
		Me.label6.TabIndex = 5
		Me.label6.Text = "X"
		'
		'button2
		'
		Me.button2.Location = New System.Drawing.Point(12, 335)
		Me.button2.Name = "button2"
		Me.button2.Size = New System.Drawing.Size(260, 23)
		Me.button2.TabIndex = 3
		Me.button2.Text = "Add Component"
		Me.button2.UseVisualStyleBackColor = true
		AddHandler Me.button2.Click, AddressOf Me.Button2Click
		'
		'spawnnewobject
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(284, 365)
		Me.Controls.Add(Me.button2)
		Me.Controls.Add(Me.groupBox3)
		Me.Controls.Add(Me.groupBox2)
		Me.Controls.Add(Me.groupBox1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.MaximizeBox = false
		Me.Name = "spawnnewobject"
		Me.ShowIcon = false
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "SpawnNewObject"
		AddHandler Load, AddressOf Me.SpawnnewobjectLoad
		Me.groupBox1.ResumeLayout(false)
		Me.groupBox2.ResumeLayout(false)
		CType(Me.numericUpDown2,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.numericUpDown1,System.ComponentModel.ISupportInitialize).EndInit
		Me.groupBox3.ResumeLayout(false)
		CType(Me.numericUpDown4,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.numericUpDown3,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
	End Sub
	Private button2 As System.Windows.Forms.Button
	Private label6 As System.Windows.Forms.Label
	Private numericUpDown3 As System.Windows.Forms.NumericUpDown
	Private numericUpDown4 As System.Windows.Forms.NumericUpDown
	Private label5 As System.Windows.Forms.Label
	Private groupBox3 As System.Windows.Forms.GroupBox
	Private numericUpDown2 As System.Windows.Forms.NumericUpDown
	Private label4 As System.Windows.Forms.Label
	Private label3 As System.Windows.Forms.Label
	Private numericUpDown1 As System.Windows.Forms.NumericUpDown
	Private groupBox2 As System.Windows.Forms.GroupBox
	Private button1 As System.Windows.Forms.Button
	Private label2 As System.Windows.Forms.Label
	Private label1 As System.Windows.Forms.Label
	Private colorDialog1 As System.Windows.Forms.ColorDialog
	Private groupBox1 As System.Windows.Forms.GroupBox
End Class
