'
' Created by SharpDevelop.
' User: bharr0
' Date: 5/02/2018
' Time: 10:32 AM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class MainForm
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
		Me.listBox1 = New System.Windows.Forms.ListBox()
		Me.groupBox1 = New System.Windows.Forms.GroupBox()
		Me.groupBox2 = New System.Windows.Forms.GroupBox()
		Me.button1 = New System.Windows.Forms.Button()
		Me.label3 = New System.Windows.Forms.Label()
		Me.label2 = New System.Windows.Forms.Label()
		Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown()
		Me.label1 = New System.Windows.Forms.Label()
		Me.colorDialog1 = New System.Windows.Forms.ColorDialog()
		Me.groupBox3 = New System.Windows.Forms.GroupBox()
		Me.listBox2 = New System.Windows.Forms.ListBox()
		Me.button2 = New System.Windows.Forms.Button()
		Me.button3 = New System.Windows.Forms.Button()
		Me.button4 = New System.Windows.Forms.Button()
		Me.button5 = New System.Windows.Forms.Button()
		Me.button6 = New System.Windows.Forms.Button()
		Me.saveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
		Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog()
		Me.groupBox1.SuspendLayout
		Me.groupBox2.SuspendLayout
		CType(Me.numericUpDown1,System.ComponentModel.ISupportInitialize).BeginInit
		Me.groupBox3.SuspendLayout
		Me.SuspendLayout
		'
		'listBox1
		'
		Me.listBox1.FormattingEnabled = true
		Me.listBox1.ItemHeight = 15
		Me.listBox1.Items.AddRange(New Object() {"MoveForw(times)", "MoveBack(times)", "SweepLeft(times)", "SweepRight(times)", "TurnRigh(times)", "TurnLeft(times)", "ChangeColour(colour)", "ChangeBackColour(colour)", "Jump(times,hlf)", "Wait(times)", "MsgBox(message)"})
		Me.listBox1.Location = New System.Drawing.Point(7, 22)
		Me.listBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.listBox1.Name = "listBox1"
		Me.listBox1.Size = New System.Drawing.Size(304, 109)
		Me.listBox1.TabIndex = 0
		AddHandler Me.listBox1.SelectedIndexChanged, AddressOf Me.ListBox1SelectedIndexChanged
		'
		'groupBox1
		'
		Me.groupBox1.Controls.Add(Me.listBox1)
		Me.groupBox1.Location = New System.Drawing.Point(16, 15)
		Me.groupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.groupBox1.Name = "groupBox1"
		Me.groupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.groupBox1.Size = New System.Drawing.Size(319, 139)
		Me.groupBox1.TabIndex = 1
		Me.groupBox1.TabStop = false
		Me.groupBox1.Text = "Commands"
		'
		'groupBox2
		'
		Me.groupBox2.Controls.Add(Me.button1)
		Me.groupBox2.Controls.Add(Me.label3)
		Me.groupBox2.Controls.Add(Me.label2)
		Me.groupBox2.Controls.Add(Me.numericUpDown1)
		Me.groupBox2.Controls.Add(Me.label1)
		Me.groupBox2.Location = New System.Drawing.Point(16, 160)
		Me.groupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.groupBox2.Name = "groupBox2"
		Me.groupBox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.groupBox2.Size = New System.Drawing.Size(319, 139)
		Me.groupBox2.TabIndex = 2
		Me.groupBox2.TabStop = false
		Me.groupBox2.Text = "Parameters"
		'
		'button1
		'
		Me.button1.Enabled = false
		Me.button1.Location = New System.Drawing.Point(8, 104)
		Me.button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.button1.Name = "button1"
		Me.button1.Size = New System.Drawing.Size(303, 26)
		Me.button1.TabIndex = 4
		Me.button1.Text = "Change"
		Me.button1.UseVisualStyleBackColor = true
		AddHandler Me.button1.Click, AddressOf Me.Button1Click
		'
		'label3
		'
		Me.label3.Location = New System.Drawing.Point(8, 88)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(117, 26)
		Me.label3.TabIndex = 3
		Me.label3.Text = "XXXXXXXXXXXXXXXX"
		'
		'label2
		'
		Me.label2.Location = New System.Drawing.Point(8, 68)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(117, 26)
		Me.label2.TabIndex = 2
		Me.label2.Text = "Colour"
		'
		'numericUpDown1
		'
		Me.numericUpDown1.Location = New System.Drawing.Point(7, 37)
		Me.numericUpDown1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.numericUpDown1.Maximum = New Decimal(New Integer() {570, 0, 0, 0})
		Me.numericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.numericUpDown1.Name = "numericUpDown1"
		Me.numericUpDown1.Size = New System.Drawing.Size(305, 21)
		Me.numericUpDown1.TabIndex = 1
		Me.numericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'label1
		'
		Me.label1.Location = New System.Drawing.Point(7, 19)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(117, 26)
		Me.label1.TabIndex = 0
		Me.label1.Text = "Times"
		'
		'groupBox3
		'
		Me.groupBox3.Controls.Add(Me.listBox2)
		Me.groupBox3.Location = New System.Drawing.Point(341, 14)
		Me.groupBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.groupBox3.Name = "groupBox3"
		Me.groupBox3.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.groupBox3.Size = New System.Drawing.Size(296, 352)
		Me.groupBox3.TabIndex = 3
		Me.groupBox3.TabStop = false
		Me.groupBox3.Text = "Script so far"
		'
		'listBox2
		'
		Me.listBox2.FormattingEnabled = true
		Me.listBox2.HorizontalScrollbar = true
		Me.listBox2.ItemHeight = 15
		Me.listBox2.Location = New System.Drawing.Point(7, 22)
		Me.listBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.listBox2.Name = "listBox2"
		Me.listBox2.ScrollAlwaysVisible = true
		Me.listBox2.Size = New System.Drawing.Size(282, 319)
		Me.listBox2.TabIndex = 0
		AddHandler Me.listBox2.SelectedIndexChanged, AddressOf Me.ListBox2SelectedIndexChanged
		'
		'button2
		'
		Me.button2.Enabled = false
		Me.button2.Location = New System.Drawing.Point(16, 306)
		Me.button2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.button2.Name = "button2"
		Me.button2.Size = New System.Drawing.Size(319, 26)
		Me.button2.TabIndex = 5
		Me.button2.Text = "Add to Script"
		Me.button2.UseVisualStyleBackColor = true
		AddHandler Me.button2.Click, AddressOf Me.Button2Click
		'
		'button3
		'
		Me.button3.Enabled = false
		Me.button3.Location = New System.Drawing.Point(16, 339)
		Me.button3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.button3.Name = "button3"
		Me.button3.Size = New System.Drawing.Size(319, 26)
		Me.button3.TabIndex = 6
		Me.button3.Text = "Remove From Script"
		Me.button3.UseVisualStyleBackColor = true
		AddHandler Me.button3.Click, AddressOf Me.Button3Click
		'
		'button4
		'
		Me.button4.Location = New System.Drawing.Point(16, 406)
		Me.button4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.button4.Name = "button4"
		Me.button4.Size = New System.Drawing.Size(622, 26)
		Me.button4.TabIndex = 7
		Me.button4.Text = "Play Script"
		Me.button4.UseVisualStyleBackColor = true
		AddHandler Me.button4.Click, AddressOf Me.Button4Click
		'
		'button5
		'
		Me.button5.Location = New System.Drawing.Point(329, 373)
		Me.button5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.button5.Name = "button5"
		Me.button5.Size = New System.Drawing.Size(308, 26)
		Me.button5.TabIndex = 8
		Me.button5.Text = "Import Script"
		Me.button5.UseVisualStyleBackColor = true
		AddHandler Me.button5.Click, AddressOf Me.Button5Click
		'
		'button6
		'
		Me.button6.Enabled = false
		Me.button6.Location = New System.Drawing.Point(16, 373)
		Me.button6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.button6.Name = "button6"
		Me.button6.Size = New System.Drawing.Size(308, 26)
		Me.button6.TabIndex = 9
		Me.button6.Text = "Export Script"
		Me.button6.UseVisualStyleBackColor = true
		AddHandler Me.button6.Click, AddressOf Me.Button6Click
		'
		'saveFileDialog1
		'
		Me.saveFileDialog1.DefaultExt = "bcs"
		Me.saveFileDialog1.Filter = "Basic Commands Script|*.bcs"
		'
		'openFileDialog1
		'
		Me.openFileDialog1.DefaultExt = "bcs"
		Me.openFileDialog1.Filter = "Basic Commands Script|*.bcs"
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7!, 15!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(651, 446)
		Me.Controls.Add(Me.button6)
		Me.Controls.Add(Me.button5)
		Me.Controls.Add(Me.button4)
		Me.Controls.Add(Me.button3)
		Me.Controls.Add(Me.button2)
		Me.Controls.Add(Me.groupBox3)
		Me.Controls.Add(Me.groupBox2)
		Me.Controls.Add(Me.groupBox1)
		Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.MaximizeBox = false
		Me.Name = "MainForm"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Basic Commands"
		Me.groupBox1.ResumeLayout(false)
		Me.groupBox2.ResumeLayout(false)
		CType(Me.numericUpDown1,System.ComponentModel.ISupportInitialize).EndInit
		Me.groupBox3.ResumeLayout(false)
		Me.ResumeLayout(false)
	End Sub
	Private openFileDialog1 As System.Windows.Forms.OpenFileDialog
	Private saveFileDialog1 As System.Windows.Forms.SaveFileDialog
	Private button6 As System.Windows.Forms.Button
	Private button5 As System.Windows.Forms.Button
	Private button4 As System.Windows.Forms.Button
	Private button3 As System.Windows.Forms.Button
	Private button2 As System.Windows.Forms.Button
	Public WithEvents listBox2 As System.Windows.Forms.ListBox
	Private groupBox3 As System.Windows.Forms.GroupBox
	Private button1 As System.Windows.Forms.Button
	Public WithEvents colorDialog1 As System.Windows.Forms.ColorDialog
	Private label3 As System.Windows.Forms.Label
	Private label2 As System.Windows.Forms.Label
	Private label1 As System.Windows.Forms.Label
	Private numericUpDown1 As System.Windows.Forms.NumericUpDown
	Private groupBox2 As System.Windows.Forms.GroupBox
	Private groupBox1 As System.Windows.Forms.GroupBox
	Public WithEvents listBox1 As System.Windows.Forms.ListBox
End Class
