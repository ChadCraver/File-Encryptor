Imports System
Imports System.IO
Imports System.Security
Imports System.Security.Cryptography

Public Class frmFileEncryptor

    ' Global variables.

    Public strFileToEncrypt As String
    Public strFileToDecrypt As String
    Public strOutputEncrypt As String
    Public strOutputDecrypt As String
    Public fsInput As FileStream
    Public fsOutput As FileStream

    Private Function CreateKey(ByVal strPassword As String) As Byte()
        ' Convert strPassword to an array and store in chrData.
        Dim chrData() As Char = strPassword.ToCharArray
        ' Use intLength to get strPassword size.
        Dim intLength As Integer = chrData.GetUpperBound(0)
        ' Declare bytDataToHash and make it the same size as chrData.
        Dim bytDataToHash(intLength) As Byte


        ' Use For Next to convert and store chrData into bytDataToHash.
        For i As Integer = 0 To chrData.GetUpperBound(0)
            bytDataToHash(i) = CByte(Asc(chrData(i)))
        Next

        ' Declare what hash to use.
        Dim SHA512 As New SHA512Managed
        ' Declare bytResult, Hash bytDataToHash and store it in bytResult.
        Dim bytResult As Byte() = SHA512.ComputeHash(bytDataToHash)
        ' Declare bytKey(31). It will hold 256 bits.
        Dim bytKey(31) As Byte

        ' Use For Next to put a specific size (256 bits) of byteResult into bytKey.
        ' The 0 to 31 will put the first 256 bits of 512 bits into bytKey.
        For i As Integer = 0 To 31
            bytKey(i) = bytResult(i)
        Next

        ' Reutrn the key.
        Return bytKey
    End Function

    Private Function CreateIV(ByVal strPassword As String) As Byte()
        ' Intitialization vector.
        ' Convert strPassword to an array and store in chrData.
        Dim chrData() As Char = strPassword.ToCharArray
        ' Use intLength to get strPassword size.
        Dim intLength As Integer = chrData.GetUpperBound(0)
        ' Declare bytDataToHash and make it the same size as chrData.
        Dim bytDataToHash(intLength) As Byte


        ' Use For Next to convert and store chrData into bytDataToHash.
        For i As Integer = 0 To chrData.GetUpperBound(0)
            bytDataToHash(i) = CByte(Asc(chrData(i)))
        Next

        ' Declare what hash to use.
        Dim SHA512 As New SHA512Managed
        ' Declare bytResult, Hash bytDataToHash and store it in bytResult.
        Dim bytResult As Byte() = SHA512.ComputeHash(bytDataToHash)
        ' Declare bytIV(15). It will hold 128 bits.
        Dim bytIV(15) As Byte

        ' Use For Next to put a specific size (128 bits) of bytResult into bytIV.
        ' The 0 to 30 for bytKey used the first 256 bits of the hashed password.
        ' The 32 to 47 will put the next 128 bits into bytIV.
        For i As Integer = 32 To 47
            bytIV(i - 32) = bytResult(i)
        Next

        ' Return the IV.
        Return bytIV
    End Function

    Private Enum CryptoAction
        ' Define the enumeration for CryptoAction.
        ActionEncrypt = 1
        ActionDecrypt = 2
    End Enum

    Private Function EncryptOrDecryptFile(ByVal strInputFile As String,
                                     ByVal strOutputFile As String,
                                     ByVal bytKey() As Byte,
                                     ByVal bytIV() As Byte,
                                     ByVal Direction As CryptoAction)
        Try
            ' Setup file streams to handle input and output.
            fsInput = New FileStream(strInputFile, FileMode.Open, FileAccess.Read)
            fsOutput = New FileStream(strOutputFile, FileMode.OpenOrCreate, FileAccess.Write)

            ' Ensure fsOutput is empty.
            fsOutput.SetLength(0)

            ' Declare variables for encrypt/decrypt process.
            Dim bytBuffer(4096) As Byte ' Holds a block of bytes for processing.
            Dim lngBytesProcessed As Long = 0 ' A running count of bytes processed.
            Dim lngFileLength As Long = fsInput.Length ' The input file's length.
            Dim intBytesInCurrentBlock As Integer ' Current bytes being processed.
            Dim csCryptoStream As CryptoStream

            ' Declare the CryptoServiceProvider.
            Dim cspRijndael As New RijndaelManaged

            ' Setup Progress Bar
            pbStatus.Value = 0
            pbStatus.Maximum = 100

            ' Determine if encryption or decryption and setup CryptoStream.
            Select Case Direction
                Case CryptoAction.ActionEncrypt
                    csCryptoStream = New CryptoStream(fsOutput, cspRijndael.CreateEncryptor(bytKey, bytIV), CryptoStreamMode.Write)
                Case CryptoAction.ActionDecrypt
                    csCryptoStream = New CryptoStream(fsOutput, cspRijndael.CreateDecryptor(bytKey, bytIV), CryptoStreamMode.Write)
            End Select

            ' Use While to loop until all of the file is processed.
            While lngBytesProcessed < lngFileLength
                ' Read file with the input filestream.
                intBytesInCurrentBlock = fsInput.Read(bytBuffer, 0, 4096)
                ' Write output file with the cryptostream.
                csCryptoStream.Write(bytBuffer, 0, intBytesInCurrentBlock)
                ' Update lngBytesProcessed
                lngBytesProcessed += CLng(intBytesInCurrentBlock)

                ' Update Progress Bar
                pbStatus.Value = CInt((lngBytesProcessed / lngFileLength) * 100)
            End While

            ' Close filestreams and cryptostream.
            csCryptoStream.Close()
            fsInput.Close()
            fsOutput.Close()
            Return True
        Catch ex As Exception
            fsInput.Close()
            fsOutput.Close()
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Unhandled Error Encountered")
            Return False
        End Try
    End Function

    Private Function ChangeFileExt(ByVal Direction As CryptoAction)
        ' Change file extension.
        Select Case Direction
            Case CryptoAction.ActionEncrypt
                OpenFileDialog.FileName = ""
                OpenFileDialog.Title = "Choose a file to encrypt"
                OpenFileDialog.InitialDirectory = "C:\"
                OpenFileDialog.Filter = "All Files (*.*) | *.*"

                ' Find out if the user chose a file.
                If OpenFileDialog.ShowDialog = DialogResult.OK Then
                    strFileToEncrypt = OpenFileDialog.FileName
                    txtFileToEncrypt.Text = strFileToEncrypt

                    Dim iPosition As Integer = 0
                    Dim i As Integer = 0

                    ' Get the position of the last "\" in the OpenFileDialog.FileName path.
                    ' Returns -1 when the character your searching for is absent.
                    ' IndexOf searches for left to right.
                    While strFileToEncrypt.IndexOf("\"c, i) <> -1
                        iPosition = strFileToEncrypt.IndexOf("\"c, i)
                        i = iPosition + 1
                    End While

                    ' Assign strOutputFile to the position after the last "\" in the path.
                    ' This position is the beginning of the file name.
                    strOutputEncrypt = strFileToEncrypt.Substring(iPosition + 1)
                    ' Assign S the entire path, ending at the last "\".
                    Dim S As String = strFileToEncrypt.Substring(0, iPosition + 1)
                    ' Replace the "." in the file extension with "_".
                    strOutputEncrypt = strOutputEncrypt.Replace("."c, "_"c)
                    ' The final file name. XXXX.encrypt
                    txtEncryptFileDestination.Text = S & strOutputEncrypt & ".encrypt"

                    Return S & strOutputEncrypt & ".encrypt"
                End If
            Case CryptoAction.ActionDecrypt
                OpenFileDialog.FileName = ""
                OpenFileDialog.Title = "Choose a file to decrypt"
                OpenFileDialog.InitialDirectory = "C:\"
                OpenFileDialog.Filter = "Encrypted Files (*.encrypt) | *.encrypt"

                ' Find out if the user chose a file.
                If OpenFileDialog.ShowDialog = DialogResult.OK Then
                    strFileToDecrypt = OpenFileDialog.FileName
                    txtFileToDecrypt.Text = strFileToDecrypt

                    Dim iPosition As Integer = 0
                    Dim i As Integer = 0

                    ' Get the position of the last "\" in the OpenFileDialog.FileName path.
                    ' Returns -1 when the character your searching for is absent.
                    ' IndexOf searches for left to right.
                    While strFileToDecrypt.IndexOf("\"c, i) <> -1
                        iPosition = strFileToDecrypt.IndexOf("\"c, i)
                        i = iPosition + 1
                    End While

                    ' Assign strOutputFile to the position after the last "\" in the path.
                    ' This position is the beginning of the file name.
                    strOutputDecrypt = strFileToDecrypt.Substring(0, strFileToDecrypt.Length - 8)
                    ' Assign S the entire path, ending at the last "\".
                    Dim S As String = strFileToDecrypt.Substring(0, iPosition + 1)
                    ' Replace the "_" in the file extension with ".".
                    strOutputDecrypt = strOutputDecrypt.Substring((iPosition + 1))
                    txtDecryptFileDestination.Text = S & strOutputDecrypt.Replace("_"c, "."c)

                    Return S & strOutputDecrypt.Replace("_"c, "."c)
                End If
        End Select
    End Function

    Private Sub btnBrowseEncrypt_Click(sender As Object, e As EventArgs) Handles btnBrowseEncrypt.Click
        ChangeFileExt(CryptoAction.ActionEncrypt)
    End Sub

    Private Sub btnBrowseDecrypt_Click(sender As Object, e As EventArgs) Handles btnBrowseDecrypt.Click
        ChangeFileExt(CryptoAction.ActionDecrypt)
    End Sub

    Private Sub btnEncryptFile_Click(sender As Object, e As EventArgs) Handles btnEncryptFile.Click
        Dim bytKey As Byte()
        Dim bytIV As Byte()

        If txtFileToEncrypt.Text = "" Then
            ChangeFileExt(CryptoAction.ActionEncrypt)
        End If

        If txtEncryptPassword1.Text = "" Or txtEncryptPassword2.Text = "" Then
            MsgBox("You must provide and confirm a password to encrypt the file!", vbOKOnly + vbCritical, "Password Required")
            Exit Sub
        End If

        If txtEncryptPassword1.Text = txtEncryptPassword2.Text Then
            bytKey = CreateKey(txtEncryptPassword1.Text)
            bytIV = CreateIV(txtEncryptPassword1.Text)
            If EncryptOrDecryptFile(strFileToEncrypt, txtEncryptFileDestination.Text, bytKey, bytIV, CryptoAction.ActionEncrypt) = False Then
                MsgBox("Encryption failed!", vbOKOnly + vbCritical, "Encryption Failed")
                Exit Sub
            End If
            pbStatus.Value = 0
            txtEncryptPassword1.Text = ""
            txtEncryptPassword2.Text = ""
            If chkDeleteFileAfterEncryption.Checked = True Then
                My.Computer.FileSystem.DeleteFile(txtFileToEncrypt.Text)
            End If
            MsgBox("Encryption complete!", vbOKOnly, "Successful Encryption")
        Else
            MsgBox("Your passwords don't match!", vbOKOnly + vbCritical, "Password Don't Match")
        End If
    End Sub

    Private Sub btnDecryptFile_Click(sender As Object, e As EventArgs) Handles btnDecryptFile.Click
        Dim bytKey As Byte()
        Dim bytIV As Byte()

        If txtFileToDecrypt.Text = "" Then
            ChangeFileExt(CryptoAction.ActionDecrypt)
        End If

        If txtDecryptPassword1.Text = "" Or txtDecryptPassword2.Text = "" Then
            MsgBox("You must provide and confirm the password used to encrypt the file!", vbOKOnly + vbCritical, "Password Required")
            Exit Sub
        End If

        If txtDecryptPassword1.Text = txtDecryptPassword2.Text Then
            bytKey = CreateKey(txtDecryptPassword1.Text)
            bytIV = CreateIV(txtDecryptPassword1.Text)
            If EncryptOrDecryptFile(strFileToDecrypt, txtDecryptFileDestination.Text, bytKey, bytIV, CryptoAction.ActionDecrypt) = False Then
                MsgBox("Decryption failed!", vbOKOnly + vbCritical, "Decryption Failed")
                Exit Sub
            End If
            pbStatus.Value = 0
            txtDecryptPassword1.Text = ""
            txtDecryptPassword2.Text = ""
            If chkDeleteFileAfterDecryption.Checked = True Then
                My.Computer.FileSystem.DeleteFile(txtFileToDecrypt.Text)
            End If
            MsgBox("Decryption complete!", vbOKOnly, "Successful Decryption")
        Else
            MsgBox("Your passwords don't match!", vbOKOnly + vbCritical, "Password Don't Match")
        End If
    End Sub
End Class
