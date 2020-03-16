Imports System
Imports System.Security.Cryptography
Imports System.Text
Imports System.Windows.Forms
Imports System.Management
Imports System.Management.Instrumentation
''' <date>03052017</date><time>192522</time>
''' <type>class</type>
''' <summary>GrandDRM Main Class, implement this class when using GrandDRM.</summary>
Public NotInheritable Class GDRM
    Public Shared key As String
    ''' <date>03052017</date><time>200141</time>
    ''' <type>function</type>
    ''' <summary>
    ''' Function to be called when the user clicks the "Activate" button on the drm form.
    ''' </summary>
    ''' <param name="encryptkey"></param>
    ''' <param name="keyinput"></param>
    ''' <param name="serial"></param>
    ''' <param name="drmform"></param>
    ''' <param name="protectedform"></param>
    ''' <param name="VEmail"></param>
    ''' <returns></returns>
    Public Function main(ByVal encryptkey As String, keyinput As String, serial As String, drmform As Form, protectedform As Form, VEmail As String, PName As String, PEdition As String)
        Dim KAddress01 As String = "C:" & "\GrandDRM"
        Dim KAddress02 As String = "C:" & "\GrandDRM\" & PName
        Dim KAddress03 As String = "C:" & "\GrandDRM\" & PName & "\" & PEdition
        Dim KAddress04 As String = "C:" & "\GrandDRM\" & PName & "\" & PEdition & "\dyndata"
        Dim KAddress05 As String = "C:" & "\GrandDRM\" & PName & "\" & PEdition & "\dyndata\activation.xml"
        If keyinput = "" Then
            MsgBox("No key was entered. Please contact your vendor for your key on, " & VEmail & ". Include your Serial, and your full name.", vbCritical, "Validation Error")
            Exit Function
        Else
            Dim objFSO As Object = CreateObject("Scripting.FileSystemObject")
            If Not objFSO.FileExists(KAddress04) Then
                Dim password As String = encryptkey
                Dim wrapper As AESMain = New AESMain()
                Dim cipherText1 As String = wrapper.AES_Encrypt(serial, password)
                Dim cipherText As String
                cipherText = hash(cipherText1)
                If cipherText1 = keyinput Then
                    If objFSO.FolderExists(KAddress01) Then
                        If objFSO.FolderExists(KAddress02) Then
                            If objFSO.FolderExists(KAddress03) Then
                                If objFSO.FolderExists(KAddress04) Then
                                    objFSO.CreateTextFile(KAddress05)
                                    key = cipherText
                                    Call xmlwrite(PName, PEdition)
                                    protectedform.Show()
                                    drmform.Close()
                                Else
                                    objFSO.CreateFolder(KAddress04)
                                    objFSO.CreateTextFile(KAddress05)
                                    key = cipherText
                                    Call xmlwrite(PName, PEdition)
                                    protectedform.Show()
                                    drmform.Close()
                                End If
                            Else
                                objFSO.CreateFolder(KAddress03)
                                objFSO.CreateFolder(KAddress04)
                                objFSO.CreateTextFile(KAddress05)
                                key = cipherText
                                Call xmlwrite(PName, PEdition)
                                protectedform.Show()
                                drmform.Close()
                            End If
                        Else
                            objFSO.CreateFolder(KAddress02)
                            objFSO.CreateFolder(KAddress03)
                            objFSO.CreateFolder(KAddress04)
                            objFSO.CreateTextFile(KAddress05)
                            key = cipherText
                            Call xmlwrite(PName, PEdition)
                            protectedform.Show()
                            drmform.Close()
                        End If
                    Else
                        objFSO.CreateFolder(KAddress01)
                        objFSO.CreateFolder(KAddress02)
                        objFSO.CreateFolder(KAddress03)
                        objFSO.CreateFolder(KAddress04)
                        objFSO.CreateTextFile(KAddress05)
                        key = cipherText
                        Call xmlwrite(PName, PEdition)
                        protectedform.Show()
                        drmform.Close()
                    End If
                    MsgBox("Activation was successful", vbInformation, "Success")
                    Exit Function
                Else
                    MsgBox("Invalid key. Please contact your vendor for your key on, " & VEmail & ". Include your Serial Key, your Product Name, and your registration name.", vbCritical, "Validation Error")
                    Exit Function
                End If
                MsgBox("Activation was successful", vbInformation, "Success")
                protectedform.Show()
                drmform.Show()
                Exit Function
            Else
                MsgBox("Invalid key. Please contact your vendor for your key on, " & VEmail & ". Include your Serial Key, your Product Name, and your registration name.", vbCritical, "Validation Error")
                Exit Function
            End If
        End If
    End Function
    ''' <date>03052017</date><time>200413</time>
    ''' <type>function</type>
    ''' <summary>
    ''' Function to be called when the module or object that loads at application execution, is started. E.g. Form1_Load. Parameters to define before using; serialtextbox (the textbox control in which the product serial should be displayed), protectedform (the form which the DRM is protecting), drmform (the DRM GUI form), and encryptkey (the encryption key used for encrypting and decrypting the activation data).
    ''' </summary>
    ''' <param name="serialtextbox"></param>
    ''' <param name="protectedform"></param>
    ''' <param name="drmform"></param>
    ''' <param name="encryptkey"></param>
    ''' <returns></returns>
    Public Function onload(ByVal serialtextbox As TextBox, regname As TextBox, PNameTB As TextBox, protectedform As Form, drmform As Form, encryptkey As String, PName As String, PEdition As String)
        drmform.Text = "GrandDRM"
        PNameTB.Text = PName
        regname.Text = owner_()
        drmform.Hide()
        Dim enclib As New AESMain
        Dim KAddress01 As String = "C:" & "\GrandDRM"
        Dim KAddress02 As String = "C:" & "\GrandDRM\" & PName
        Dim KAddress03 As String = "C:" & "\GrandDRM\" & PName & "\" & PEdition
        Dim KAddress04 As String = "C:" & "\GrandDRM\" & PName & "\" & PEdition & "\dyndata"
        Dim KAddress05 As String = "C:" & "\GrandDRM\" & PName & "\" & PEdition & "\dyndata\activation.xml"
        Dim objFSO As Object = CreateObject("Scripting.FileSystemObject")
        Try
            If Not objFSO.FileExists(KAddress05) Then
                MsgBox("Your software is not activated", vbExclamation, "Not Activated")
                serialtextbox.Text = serialgrab()
                drmform.Show()
                protectedform.Close()
            Else
                serialtextbox.Text = serialgrab()
                If xml_product(PName, PEdition) = hash(enclib.AES_Encrypt(hash(PName), "enclib.encryptpublic_owner?ispc=true#html%20code")) Then

                    If xml_owner(PName, PEdition) = hash(enclib.AES_Encrypt(hash(owner_()), "enclib.encryptpublic_owner?ispc=true#html%20code")) Then
                        Dim password As String = encryptkey
                        Dim wrapper As AESMain = New AESMain()
                        Dim cipherText1 As String = wrapper.AES_Encrypt(serialtextbox.Text, password)
                        Dim read As String = xml_key(PName, PEdition)
                        Dim cipherText As String
                        cipherText = hash(cipherText1)
                        If cipherText = read Then
                            protectedform.Show()
                            drmform.Close()
                        Else
                            MsgBox("Your license file is either corrupted, is from an earlier version, or has an incorrect license key.", vbCritical, "Validation Error")
                            objFSO.DeleteFolder(KAddress02)
                            protectedform.Close()
                            drmform.Show()
                        End If
                    Else
                        MsgBox("Your license file is for another PC. If you have recently changed your computer's name, please reactivate using the same key that you were given during activating the product on the previous computer name.", vbCritical, "Validation Error")
                        objFSO.DeleteFolder(KAddress02)
                        protectedform.Close()
                        drmform.Show()
                    End If
                Else
                    MsgBox("Your license file is for another product", vbCritical, "Validation Error")
                    My.Computer.FileSystem.DeleteDirectory(KAddress02, FileIO.DeleteDirectoryOption.DeleteAllContents)
                    protectedform.Close()
                    drmform.Show()
                End If
            End If
        Catch ex As Exception
            MsgBox("Your license file is either corrupted, is from an earlier version, ors has an incorrect license key." & vbCrLf & ex.Message, vbCritical, "Validation Error")
            objFSO.DeleteFolder(KAddress02)
            protectedform.Close()
            drmform.Show()
        End Try
    End Function
    ''' <date>03052017</date><time>200659</time>
    ''' <type>function</type>
    ''' <summary>
    ''' Returns the name of the computer, or the "owner" of the activation data
    ''' </summary>
    ''' <returns></returns>
    Public Function owner_()
        Return My.Computer.Name
    End Function
    ''' <date>10052017</date><time>164337</time>
    ''' <type>function</type>
    ''' <summary>
    ''' Function to write data to the xml file, must have PName and PEdition values included.
    ''' </summary>
    ''' <param name="PName"></param>
    ''' <param name="PEdition"></param>
    ''' <returns></returns>
    Public Function xmlwrite(ByVal PName As String, PEdition As String)
        Dim enclib As New AESMain
        Dim KAddress05 As String = "C:" & "\GrandDRM\" & PName & "\" & PEdition & "\dyndata\activation.xml"
        Dim overview As New GrandDRM
        overview.key = key
        overview.pc = hash(enclib.AES_Encrypt(hash(owner_()), "enclib.encryptpublic_owner?ispc=true#html%20code"))
        overview.product = hash(enclib.AES_Encrypt(hash(PName), "enclib.encryptpublic_owner?ispc=true#html%20code"))
        Dim writer As New System.Xml.Serialization.XmlSerializer(GetType(GrandDRM))
        Dim file As New System.IO.StreamWriter(
            KAddress05)
        writer.Serialize(file, overview)
        file.Close()
    End Function
    ''' <date>10052017</date><time>164532</time>
    ''' <type>function</type>
    ''' <summary>
    ''' Function to read data from the xml file, must have PName and PEdition values included.
    ''' </summary>
    ''' <param name="PName"></param>
    ''' <param name="PEdition"></param>
    ''' <returns></returns>
    Public Function xml_key(ByVal PName As String, PEdition As String)
        Dim KAddress05 As String = "C:" & "\GrandDRM\" & PName & "\" & PEdition & "\dyndata\activation.xml"
        Dim reader As New System.Xml.Serialization.XmlSerializer(GetType(GrandDRM))
        Dim file As New System.IO.StreamReader(
            KAddress05)
        Dim overview As GrandDRM
        overview = CType(reader.Deserialize(file), GrandDRM)
        file.Close()
        Return overview.key
    End Function
    ''' <date>03052017</date><time>200659</time>
    ''' <type>function</type>
    ''' <summary>
    ''' Returns the XML-declared name of the computer, or the "owner" of the activation data
    ''' </summary>
	''' <param name="PName"></param>
	''' <param name="PEdition"></param>
    ''' <returns></returns>
    Public Function xml_owner(ByVal PName As String, PEdition As String)
        Dim KAddress05 As String = "C:" & "\GrandDRM\" & PName & "\" & PEdition & "\dyndata\activation.xml"
        Dim reader As New System.Xml.Serialization.XmlSerializer(GetType(GrandDRM))
        Dim file As New System.IO.StreamReader(
            KAddress05)
        Dim overview As GrandDRM
        overview = CType(reader.Deserialize(file), GrandDRM)
        file.Close()
        Return overview.pc
    End Function
	''' <date>26052017</date><time>165738</time>
	''' <type>function</type>
	''' <summary>
	''' Returns a hashed result of whatever string input it is given
	''' </summary>
	''' <param name="input"></param>
	''' <returns></returns>
    Public Function hash(ByVal input As String)
        Using md5Hash As MD5 = MD5.Create()
            Return MD5Main.GetMd5Hash(md5Hash, input)
        End Using
    End Function
    ''' <date>26052017</date><time>170028</time>
    ''' <type>function</type>
    ''' <summary>
    ''' Returns the XML-declared product name
    ''' </summary>
    ''' <param name="PName"></param>
    ''' <param name="PEdition"></param>
    Public Function xml_product(ByVal PName As String, PEdition As String)
        Dim KAddress05 As String = "C:" & "\GrandDRM\" & PName & "\" & PEdition & "\dyndata\activation.xml"
        Dim reader As New System.Xml.Serialization.XmlSerializer(GetType(GrandDRM))
        Dim file As New System.IO.StreamReader(
            KAddress05)
        Dim overview As GrandDRM
        overview = CType(reader.Deserialize(file), GrandDRM)
        file.Close()
        Return overview.product
    End Function
    ''' <summary>
    ''' Used by the serialgrab function to add hyphens every 5 characters
    ''' </summary>
    ''' <param name="serialtext"></param>
    ''' <returns></returns>
    Private Function serial(ByVal serialtext As String)
        If serialtext.Length >= 5 + 1 Then
            Dim s As String = serialtext.Replace("-", "")
            For x As Integer = 5 To s.Length Step 5
                s = s.Insert(x + ((x \ 5) - 1), "-")
            Next
            s = s.TrimEnd("-"c)
            Return s
        End If
    End Function
    ''' <summary>
    ''' Grabs Windows management serial keys and formats them into a program-acceptable key
    ''' </summary>
    ''' <returns></returns>
    Function serialgrab()
        Dim objMOS As Management.ManagementObjectSearcher
        Dim objMOC As Management.ManagementObjectCollection
        Dim objMO As Management.ManagementObject
        objMOS = New Management.ManagementObjectSearcher("Select * From Win32_Processor")
        objMOC = objMOS.Get
        For Each objMO In objMOC
            key = objMO("ProcessorID")
        Next
        objMOS = New Management.ManagementObjectSearcher("Select * From Win32_BaseBoard")
        objMOC = objMOS.Get
        For Each objMO In objMOC
            key = key & objMO("SerialNumber")
        Next
        objMOS = New Management.ManagementObjectSearcher("Select * From Win32_BIOS")
        objMOC = objMOS.Get
        For Each objMO In objMOC
            key = key & objMO("SerialNumber")
        Next
        Return serial(key)
    End Function
End Class
''' <date>10052017</date><time>165105</time>
''' <type>class</type>
''' <summary>
''' Nothing of importance, just a plain old variable block.
''' </summary>
Public Class GrandDRM
    Public key As String
    Public pc As String
    Public product As String
End Class
''' <date>09052017</date><time>151757</time>
''' <type>class</type>
''' <summary>
''' This is the AES Class used for checking, decrypting, and encrypting the key.
''' </summary>
Public NotInheritable Class AESMain
	''' <date>09052017</date><time>152947</time>
	''' <type>function</type>
	''' <summary>
	''' This is the main AES encryption class, include a password and an input string (serial in this case), and it will encrypt it.
	''' </summary>
	''' <returns></returns>
    Public Function AES_Encrypt(ByVal input As String, ByVal pass As String) As String
        Dim AES As New System.Security.Cryptography.RijndaelManaged
        Dim Hash_AES As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim encrypted As String = ""
        Try
            Dim hash(31) As Byte
            Dim temp As Byte() = Hash_AES.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(pass))
            Array.Copy(temp, 0, hash, 0, 16)
            Array.Copy(temp, 0, hash, 15, 16)
            AES.Key = hash
            AES.Mode = Security.Cryptography.CipherMode.ECB
            Dim DESEncrypter As System.Security.Cryptography.ICryptoTransform = AES.CreateEncryptor
            Dim Buffer As Byte() = System.Text.ASCIIEncoding.ASCII.GetBytes(input)
            encrypted = Convert.ToBase64String(DESEncrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
            Return encrypted
        Catch ex As Exception
        End Try
    End Function
	''' <date>09052017</date><time>153309</time>
	''' <type>function</type>
	''' <summary>
	''' This is the main AES decryption class, include a password and an input string (encrypted serial in this case), and it will decrypt it.
	''' </summary>
	''' <returns></returns>
    Public Function AES_Decrypt(ByVal input As String, ByVal pass As String) As String
        Dim AES As New System.Security.Cryptography.RijndaelManaged
        Dim Hash_AES As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim decrypted As String = ""
        Try
            Dim hash(31) As Byte
            Dim temp As Byte() = Hash_AES.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(pass))
            Array.Copy(temp, 0, hash, 0, 16)
            Array.Copy(temp, 0, hash, 15, 16)
            AES.Key = hash
            AES.Mode = Security.Cryptography.CipherMode.ECB
            Dim DESDecrypter As System.Security.Cryptography.ICryptoTransform = AES.CreateDecryptor
            Dim Buffer As Byte() = Convert.FromBase64String(input)
            decrypted = System.Text.ASCIIEncoding.ASCII.GetString(DESDecrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
            Return decrypted
        Catch ex As Exception
        End Try
    End Function
End Class
''' <date>09052017</date><time>153614</time>
''' <type>class</type>
''' <summary>
''' This is the main MD5 Hashing class (used for hashing encrypted serials to use in the activation file)
''' </summary>
Public Class MD5Main
	''' <date>09052017</date><time>154121</time>
	''' <type>function</type>
	''' <summary>
	''' This function generates the MD5 hash
	''' </summary>
	''' <returns></returns>
    Shared Function GetMd5Hash(ByVal md5Hash As MD5, ByVal input As String) As String

        ' Convert the input string to a byte array and compute the hash.
        Dim data As Byte() = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input))

        ' Create a new Stringbuilder to collect the bytes
        ' and create a string.
        Dim sBuilder As New StringBuilder()

        ' Loop through each byte of the hashed data 
        ' and format each one as a hexadecimal string.
        Dim i As Integer
        For i = 0 To data.Length - 1
            sBuilder.Append(data(i).ToString("x2"))
        Next i

        ' Return the hexadecimal string.
        Return sBuilder.ToString()

    End Function 'GetMd5Hash
    ''' <date>09052017</date><time>153930</time>
    ''' <type>function</type>
    ''' <summary>
    ''' This function verifies if a hash is legitimate
    ''' </summary>
    ''' <returns></returns>
    Shared Function VerifyMd5Hash(ByVal md5Hash As MD5, ByVal input As String, ByVal hash As String) As Boolean
        ' Hash the input.
        Dim hashOfInput As String = GetMd5Hash(md5Hash, input)

        ' Create a StringComparer an compare the hashes.
        Dim comparer As StringComparer = StringComparer.OrdinalIgnoreCase

        If 0 = comparer.Compare(hashOfInput, hash) Then
            Return True
        Else
            Return False
        End If

    End Function 'VerifyMd5Hash
End Class 'Program 