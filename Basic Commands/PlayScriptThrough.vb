Option Infer On
Imports System.Text.RegularExpressions
Imports System.Linq
Imports VB = Microsoft.VisualBasic
'
' Created by SharpDevelop.
' User: bharr0
' Date: 5/02/2018
' Time: 12:00 PM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Partial Class PlayScriptThrough
	Public sizechangeglobal As Integer = 12	
	Dim spawnObject As New PictureBox	
	Public currentDirection As String = "right"	
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	Sub PlayScriptThroughShown(sender As Object, e As EventArgs)
		spawnObject = New PictureBox
		Try
			Me.Controls.Remove(spawnObject)
		Catch
		End Try
		sizechangeglobal = 12
		pictureBox1.Location = New Point(42,217)
		pictureBox2.Location = New Point(80,230)
		pictureBox1.BackColor = Color.black
		pictureBox2.BackColor = Color.black
		Me.backcolor = Color.LightGray
		currentDirection = "right"
		wait(0.5)
		label1.Text = "Current Direction:" & vbCrLf & "right"
		timer1.start
		Dim intLnNumber As Integer = 1
		For Each item As String In MainForm.ListBox2.Items
			If item.startswith("ChangeColour(") Then
				Dim command As String = item.Remove(0,13)
				command = command.TrimEnd(")")
				label2.Text = "Current Action:" & vbCrLf & "Change Colour"
				pictureBox1.BackColor = colourfromdata(command)
				pictureBox2.BackColor = ColourFromData(command)
				wait(0.5)
			ElseIf item.startswith("ChangeBackColour(") Then
				Dim command As String = item.Remove(0,17)
				command = command.TrimEnd(")")
				label2.Text = "Current Action:" & vbCrLf & "Change Back Colour"
			    Me.backcolor = colourfromdata(command)
				wait(0.5)
			ElseIf item.StartsWith("MoveForw(") Then
				Dim command As String = item.Remove(0,9)
				command = command.TrimEnd(")")
				MoveForward(command)
				wait(0.5)
			ElseIf item.StartsWith("TurnLeft(") Then
				Dim command As String = item.Remove(0,9)
				command = command.TrimEnd(")")
				TurnLeft(command)
			ElseIf item.StartsWith("TurnRigh(") Then
				Dim command As String = item.Remove(0,9)
				command = command.TrimEnd(")")
				TurnRight(command)
			ElseIf item.StartsWith("SweepLeft(") Then
				Dim command As String = item.Remove(0,10)
				command = command.TrimEnd(")")
				SweepLeft(command)
			ElseIf item.StartsWith("SweepRight(") Then
				Dim command As String = item.Remove(0,11)
				command = command.TrimEnd(")")
				SweepRight(command)
			ElseIf item.StartsWith("MoveBack(") Then
				Dim command As String = item.Remove(0,9)
				command = command.TrimEnd(")")
				MoveBack(command)
			ElseIf item.StartsWith("Jump(") Then
				Dim command As String = item.Remove(0,5)
				command = command.TrimEnd(")")
				Dim split() As String = command.Split(","c)
				sizechangeglobal = split(1)
				Jump(split(0))
			ElseIf item.StartsWith("Wait(") Then
				Dim command As String = item.Remove(0,5)
				command = command.TrimEnd(")")
				wait(command)
			ElseIf item.StartsWith("MsgBox(") Then
				Dim command As String = item.Remove(0,7)
				command = command.TrimEnd(")")
				MsgBox(command)
			Else
				MsgBox("Unknown function:" & vbCrLf & item & vbCrLf & "At line:" & vbCrLf & intLnNumber,vbCritical,"Error in BCS")
				Me.Close
				Exit sub
			End If
			intLnNumber += 1
		Next
		intLnNumber = 0
		label2.Text = "Current Action:" & vbCrLf & "Static"
	End Sub
	Sub MoveForward(times As Integer)
		Dim timesLocal As Integer = times
			Do Until timesLocal = 0
				If currentDirection = "right" Then
					pictureBox1.Location = New Point(pictureBox1.Location.X + 1,pictureBox1.Location.y)
					pictureBox2.Location = New Point(pictureBox2.Location.X + 1,pictureBox2.Location.y)
				End If
				If currentDirection = "left" Then
					pictureBox1.Location = New Point(pictureBox1.Location.X - 1,pictureBox1.Location.y)
					pictureBox2.Location = New Point(pictureBox2.Location.X - 1,pictureBox2.Location.y)
				End If
				If currentDirection = "up" Then
					pictureBox1.Location = New Point(pictureBox1.Location.X,pictureBox1.Location.y - 1)
					pictureBox2.Location = New Point(pictureBox2.Location.X,pictureBox2.Location.y - 1)
				End If
				If currentDirection = "down" Then
					pictureBox1.Location = New Point(pictureBox1.Location.X,pictureBox1.Location.y + 1)
					pictureBox2.Location = New Point(pictureBox2.Location.X,pictureBox2.Location.y + 1)
				End If
				timesLocal -= 1
				label2.Text = "Current Action:" & vbCrLf & "Move Forward" & vbCrLf & timeslocal
				wait(0.01)
			Loop
	End Sub
	Sub Jump(times As Integer)
		Dim sizechange As Integer = sizechangeglobal
		Dim timesLocal As Integer = times
		Do Until timesLocal = 0
			Do Until sizechange = 0
				pictureBox1.Size = New Size(pictureBox1.Width + 1, picturebox1.Height + 1)
				pictureBox2.Size = New Size(pictureBox2.Width + 1, picturebox2.Height + 1)
				wait(0.05)
				sizechange -= 1
			Loop
			Dim jumpProgress As Integer = 88
			Do Until jumpProgress = 0
				If currentDirection = "right" Then
					pictureBox1.Location = New Point(pictureBox1.Location.X + 1,pictureBox1.Location.y)
					pictureBox2.Location = New Point(pictureBox2.Location.X + 1,pictureBox2.Location.y)
				End If
				If currentDirection = "left" Then
					pictureBox1.Location = New Point(pictureBox1.Location.X - 1,pictureBox1.Location.y)
					pictureBox2.Location = New Point(pictureBox2.Location.X - 1,pictureBox2.Location.y)
				End If
				If currentDirection = "up" Then
					pictureBox1.Location = New Point(pictureBox1.Location.X,pictureBox1.Location.y - 1)
					pictureBox2.Location = New Point(pictureBox2.Location.X,pictureBox2.Location.y - 1)
				End If
				If currentDirection = "down" Then
					pictureBox1.Location = New Point(pictureBox1.Location.X,pictureBox1.Location.y + 1)
					pictureBox2.Location = New Point(pictureBox2.Location.X,pictureBox2.Location.y + 1)
				End If
				jumpProgress -= 1
				wait(0.001)
			Loop
				timesLocal -= 1
				Do Until sizechange = sizechangeglobal
					pictureBox1.Size = New Size(pictureBox1.Width - 1, picturebox1.Height - 1)
					pictureBox2.Size = New Size(pictureBox2.Width - 1, picturebox2.Height - 1)
					wait(0.05)
					sizechange += 1
				Loop
				label2.Text = "Current Action:" & vbCrLf & "Jumping" & vbCrLf & timeslocal
				wait(0.01)
			Loop
	End Sub
	Sub MoveBack(times As Integer)
		Dim timesLocal As Integer = times
			Do Until timesLocal = 0
				If currentDirection = "right" Then
					pictureBox1.Location = New Point(pictureBox1.Location.X - 1,pictureBox1.Location.y)
					pictureBox2.Location = New Point(pictureBox2.Location.X - 1,pictureBox2.Location.y)
				End If
				If currentDirection = "left" Then
					pictureBox1.Location = New Point(pictureBox1.Location.X + 1,pictureBox1.Location.y)
					pictureBox2.Location = New Point(pictureBox2.Location.X + 1,pictureBox2.Location.y)
				End If
				If currentDirection = "up" Then
					pictureBox1.Location = New Point(pictureBox1.Location.X,pictureBox1.Location.y + 1)
					pictureBox2.Location = New Point(pictureBox2.Location.X,pictureBox2.Location.y + 1)
				End If
				If currentDirection = "down" Then
					pictureBox1.Location = New Point(pictureBox1.Location.X,pictureBox1.Location.y - 1)
					pictureBox2.Location = New Point(pictureBox2.Location.X,pictureBox2.Location.y - 1)
				End If
				timesLocal -= 1
				label2.Text = "Current Action:" & vbCrLf & "Move Backward" & vbCrLf & timeslocal
				wait(0.01)
			Loop
	End Sub
	Sub SweepLeft(times As Integer)
		Dim timesLocal As Integer = times
			Do Until timesLocal = 0
				If currentDirection = "right" Then
					pictureBox1.Location = New Point(pictureBox1.Location.X,pictureBox1.Location.y - 1)
					pictureBox2.Location = New Point(pictureBox2.Location.X,pictureBox2.Location.y - 1)
				End If
				If currentDirection = "left" Then
					pictureBox1.Location = New Point(pictureBox1.Location.X,pictureBox1.Location.y + 1)
					pictureBox2.Location = New Point(pictureBox2.Location.X,pictureBox2.Location.y + 1)
				End If
				If currentDirection = "up" Then
					pictureBox1.Location = New Point(pictureBox1.Location.X - 1,pictureBox1.Location.y)
					pictureBox2.Location = New Point(pictureBox2.Location.X - 1,pictureBox2.Location.y)
				End If
				If currentDirection = "down" Then
					pictureBox1.Location = New Point(pictureBox1.Location.X + 1,pictureBox1.Location.y + 1)
					pictureBox2.Location = New Point(pictureBox2.Location.X + 1,pictureBox2.Location.y + 1)
				End If
				timesLocal -= 1
				label2.Text = "Current Action:" & vbCrLf & "Sweep Left" & vbCrLf & timeslocal
				wait(0.01)
			Loop
	End Sub
	Sub SweepRight(times As Integer)
		Dim timesLocal As Integer = times
			Do Until timesLocal = 0
				If currentDirection = "right" Then
					pictureBox1.Location = New Point(pictureBox1.Location.X,pictureBox1.Location.y + 1)
					pictureBox2.Location = New Point(pictureBox2.Location.X,pictureBox2.Location.y + 1)
				End If
				If currentDirection = "left" Then
					pictureBox1.Location = New Point(pictureBox1.Location.X,pictureBox1.Location.y - 1)
					pictureBox2.Location = New Point(pictureBox2.Location.X,pictureBox2.Location.y - 1)
				End If
				If currentDirection = "up" Then
					pictureBox1.Location = New Point(pictureBox1.Location.X + 1,pictureBox1.Location.y)
					pictureBox2.Location = New Point(pictureBox2.Location.X + 1,pictureBox2.Location.y)
				End If
				If currentDirection = "down" Then
					pictureBox1.Location = New Point(pictureBox1.Location.X - 1,pictureBox1.Location.y + 1)
					pictureBox2.Location = New Point(pictureBox2.Location.X - 1,pictureBox2.Location.y + 1)
				End If
				timesLocal -= 1
				label2.Text = "Current Action:" & vbCrLf & "Sweep Right" & vbCrLf & timeslocal
				wait(0.01)
			Loop
	End Sub
	Sub TurnLeft(times As Integer)
		Dim timesLocal As Integer = times
		Do Until timesLocal = 0
		If currentDirection = "right" Then
			currentDirection = "up"
			pictureBox2.Location = New Point(pictureBox1.Location.X + 12, pictureBox1.Location.Y - 12)
		ElseIf currentDirection = "up" Then
			currentDirection = "left"
			pictureBox2.Location = New Point(pictureBox1.Location.X - 12, pictureBox1.Location.Y + 12)
		ElseIf currentDirection = "down" Then
			currentDirection = "right"
			pictureBox2.Location = New Point(pictureBox1.Location.X + 38, pictureBox1.Location.Y + 12)
		ElseIf currentDirection = "left" Then
			currentDirection = "down"
			pictureBox2.Location = New Point(pictureBox1.Location.X + 12, pictureBox1.Location.Y + 38)
		End If
		wait(0.5)
		timesLocal -= 1
		label2.Text = "Current Action:" & vbCrLf & "Turn Left" & vbCrLf & timeslocal
		Loop
	End Sub
	Sub TurnRight(times As Integer)
		Dim timesLocal As Integer = times
		Do Until timesLocal = 0
		If currentDirection = "right" Then
			currentDirection = "down"
			pictureBox2.Location = New Point(pictureBox1.Location.X + 12, pictureBox1.Location.Y + 38)
		ElseIf currentDirection = "up" Then
			currentDirection = "right"
			pictureBox2.Location = New Point(pictureBox1.Location.X + 38, pictureBox1.Location.Y + 12)
		ElseIf currentDirection = "down" Then
			currentDirection = "left"
			pictureBox2.Location = New Point(pictureBox1.Location.X - 12, pictureBox1.Location.Y + 12)
		ElseIf currentDirection = "left" Then
			currentDirection = "up"
			pictureBox2.Location = New Point(pictureBox1.Location.X + 12, pictureBox1.Location.Y - 12)
		End If
		wait(0.5)
		timesLocal -= 1
		label2.Text = "Current Action:" & vbCrLf & "Turn Right" & vbCrLf & timeslocal
		Loop
	End Sub
	Public Sub wait(ByVal seconds As Single)
    Static start As Single
    start = VB.Timer()
    Do While VB.Timer() < start + seconds
        System.Windows.Forms.Application.DoEvents()
    Loop
End Sub
	Sub PlayScriptThroughFormClosing(sender As Object, e As EventArgs)
		
	End Sub
' ...
''' <summary>
''' Convert a string of the format "color [nameOfColor]" or
''' "color [A=a, R=r, G=g, B=b]" to a System.Drawing.Color.
''' </summary>
''' <param name="s">A String representing the colour.</param>
''' <returns>A System.Drawing.Color.</returns>
''' <remarks>Returns fallbackColour if the colour could not be parsed.</remarks>
Function ColourFromData(s As String) As Color
    Dim fallbackColour = Color.Black

    If Not s.StartsWith("color", StringComparison.OrdinalIgnoreCase) Then
        Return fallbackColour
    End If

    ' Extract whatever is between the brackets.
    Dim re = New Regex("\[(.+?)]")
    Dim colorNameMatch = re.Match(s)
    If Not colorNameMatch.Success Then
        Return fallbackColour
    End If

    Dim colourName = colorNameMatch.Groups(1).Value

    ' Get the names of the known colours.
    'TODO: If this function is called frequently, consider creating allColours as a variable with a larger scope.
    Dim allColours = [Enum].GetNames(GetType(System.Drawing.KnownColor))

    ' Attempt a case-insensitive match to the known colours.
    Dim nameOfColour = allColours.FirstOrDefault(Function(c) String.Compare(c, colourName, StringComparison.OrdinalIgnoreCase) = 0)

    If Not String.IsNullOrEmpty(nameOfColour) Then
        Return Color.FromName(nameOfColour)
    End If

    ' Was not a named colour. Parse for ARGB values.
    re = New Regex("A=(\d+).*?R=(\d+).*?G=(\d+).*?B=(\d+)", RegexOptions.IgnoreCase)
    Dim componentMatches = re.Match(colourName)

    If componentMatches.Success Then

        Dim a = Integer.Parse(componentMatches.Groups(1).Value)
        Dim r = Integer.Parse(componentMatches.Groups(2).Value)
        Dim g = Integer.Parse(componentMatches.Groups(3).Value)
        Dim b = Integer.Parse(componentMatches.Groups(4).Value)

        Dim maxValue = 255

        If a > maxValue OrElse r > maxValue OrElse g > maxValue OrElse b > maxValue Then
            Return fallbackColour
        End If

        Return System.Drawing.Color.FromArgb(a, r, g, b)

    End If

    Return fallbackColour

End Function

	
	Sub Timer1Tick(sender As Object, e As EventArgs)
		label1.Text = "Current Direction:" & vbCrLf & currentdirection		
	End Sub
End Class
