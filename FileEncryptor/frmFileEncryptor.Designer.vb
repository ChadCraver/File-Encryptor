<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFileEncryptor
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFileEncryptor))
        Me.txtFileToEncrypt = New System.Windows.Forms.TextBox()
        Me.txtEncryptFileDestination = New System.Windows.Forms.TextBox()
        Me.txtEncryptPassword1 = New System.Windows.Forms.TextBox()
        Me.txtEncryptPassword2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pbStatus = New System.Windows.Forms.ProgressBar()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.btnBrowseEncrypt = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.chkDeleteFileAfterEncryption = New System.Windows.Forms.CheckBox()
        Me.btnEncryptFile = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.chkDeleteFileAfterDecryption = New System.Windows.Forms.CheckBox()
        Me.btnDecryptFile = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDecryptPassword2 = New System.Windows.Forms.TextBox()
        Me.txtDecryptPassword1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnBrowseDecrypt = New System.Windows.Forms.Button()
        Me.txtFileToDecrypt = New System.Windows.Forms.TextBox()
        Me.txtDecryptFileDestination = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtFileToEncrypt
        '
        Me.txtFileToEncrypt.Location = New System.Drawing.Point(106, 6)
        Me.txtFileToEncrypt.Name = "txtFileToEncrypt"
        Me.txtFileToEncrypt.ReadOnly = True
        Me.txtFileToEncrypt.Size = New System.Drawing.Size(179, 20)
        Me.txtFileToEncrypt.TabIndex = 0
        '
        'txtEncryptFileDestination
        '
        Me.txtEncryptFileDestination.Location = New System.Drawing.Point(106, 32)
        Me.txtEncryptFileDestination.Name = "txtEncryptFileDestination"
        Me.txtEncryptFileDestination.ReadOnly = True
        Me.txtEncryptFileDestination.Size = New System.Drawing.Size(259, 20)
        Me.txtEncryptFileDestination.TabIndex = 2
        '
        'txtEncryptPassword1
        '
        Me.txtEncryptPassword1.Location = New System.Drawing.Point(106, 59)
        Me.txtEncryptPassword1.Name = "txtEncryptPassword1"
        Me.txtEncryptPassword1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtEncryptPassword1.Size = New System.Drawing.Size(260, 20)
        Me.txtEncryptPassword1.TabIndex = 3
        '
        'txtEncryptPassword2
        '
        Me.txtEncryptPassword2.Location = New System.Drawing.Point(106, 85)
        Me.txtEncryptPassword2.Name = "txtEncryptPassword2"
        Me.txtEncryptPassword2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtEncryptPassword2.Size = New System.Drawing.Size(260, 20)
        Me.txtEncryptPassword2.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "File to encrypt:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "File destination:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Type password:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Confirm password:"
        '
        'pbStatus
        '
        Me.pbStatus.Location = New System.Drawing.Point(1, 177)
        Me.pbStatus.Name = "pbStatus"
        Me.pbStatus.Size = New System.Drawing.Size(384, 23)
        Me.pbStatus.TabIndex = 6
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog1"
        '
        'btnBrowseEncrypt
        '
        Me.btnBrowseEncrypt.Location = New System.Drawing.Point(291, 3)
        Me.btnBrowseEncrypt.Name = "btnBrowseEncrypt"
        Me.btnBrowseEncrypt.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowseEncrypt.TabIndex = 1
        Me.btnBrowseEncrypt.Text = "Browse"
        Me.btnBrowseEncrypt.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(1, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(384, 175)
        Me.TabControl1.TabIndex = 8
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.chkDeleteFileAfterEncryption)
        Me.TabPage1.Controls.Add(Me.btnEncryptFile)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.btnBrowseEncrypt)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.txtFileToEncrypt)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.txtEncryptFileDestination)
        Me.TabPage1.Controls.Add(Me.txtEncryptPassword2)
        Me.TabPage1.Controls.Add(Me.txtEncryptPassword1)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(376, 149)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Encrypt"
        '
        'chkDeleteFileAfterEncryption
        '
        Me.chkDeleteFileAfterEncryption.AutoSize = True
        Me.chkDeleteFileAfterEncryption.Checked = True
        Me.chkDeleteFileAfterEncryption.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDeleteFileAfterEncryption.Location = New System.Drawing.Point(9, 126)
        Me.chkDeleteFileAfterEncryption.Name = "chkDeleteFileAfterEncryption"
        Me.chkDeleteFileAfterEncryption.Size = New System.Drawing.Size(188, 17)
        Me.chkDeleteFileAfterEncryption.TabIndex = 5
        Me.chkDeleteFileAfterEncryption.Text = "Delete original file after encryption."
        Me.chkDeleteFileAfterEncryption.UseVisualStyleBackColor = True
        '
        'btnEncryptFile
        '
        Me.btnEncryptFile.Location = New System.Drawing.Point(291, 120)
        Me.btnEncryptFile.Name = "btnEncryptFile"
        Me.btnEncryptFile.Size = New System.Drawing.Size(75, 23)
        Me.btnEncryptFile.TabIndex = 6
        Me.btnEncryptFile.Text = "Encrypt"
        Me.btnEncryptFile.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Controls.Add(Me.chkDeleteFileAfterDecryption)
        Me.TabPage2.Controls.Add(Me.btnDecryptFile)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.txtDecryptPassword2)
        Me.TabPage2.Controls.Add(Me.txtDecryptPassword1)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.btnBrowseDecrypt)
        Me.TabPage2.Controls.Add(Me.txtFileToDecrypt)
        Me.TabPage2.Controls.Add(Me.txtDecryptFileDestination)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(376, 149)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Decrypt"
        '
        'chkDeleteFileAfterDecryption
        '
        Me.chkDeleteFileAfterDecryption.AutoSize = True
        Me.chkDeleteFileAfterDecryption.Checked = True
        Me.chkDeleteFileAfterDecryption.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDeleteFileAfterDecryption.Location = New System.Drawing.Point(7, 125)
        Me.chkDeleteFileAfterDecryption.Name = "chkDeleteFileAfterDecryption"
        Me.chkDeleteFileAfterDecryption.Size = New System.Drawing.Size(202, 17)
        Me.chkDeleteFileAfterDecryption.TabIndex = 12
        Me.chkDeleteFileAfterDecryption.Text = "Delete encrypted file after decryption."
        Me.chkDeleteFileAfterDecryption.UseVisualStyleBackColor = True
        '
        'btnDecryptFile
        '
        Me.btnDecryptFile.Location = New System.Drawing.Point(291, 119)
        Me.btnDecryptFile.Name = "btnDecryptFile"
        Me.btnDecryptFile.Size = New System.Drawing.Size(75, 23)
        Me.btnDecryptFile.TabIndex = 13
        Me.btnDecryptFile.Text = "Decrypt"
        Me.btnDecryptFile.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 87)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Confirm password:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 61)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Type password:"
        '
        'txtDecryptPassword2
        '
        Me.txtDecryptPassword2.Location = New System.Drawing.Point(106, 84)
        Me.txtDecryptPassword2.Name = "txtDecryptPassword2"
        Me.txtDecryptPassword2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtDecryptPassword2.Size = New System.Drawing.Size(260, 20)
        Me.txtDecryptPassword2.TabIndex = 11
        '
        'txtDecryptPassword1
        '
        Me.txtDecryptPassword1.Location = New System.Drawing.Point(106, 58)
        Me.txtDecryptPassword1.Name = "txtDecryptPassword1"
        Me.txtDecryptPassword1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtDecryptPassword1.Size = New System.Drawing.Size(260, 20)
        Me.txtDecryptPassword1.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "File to encrypt:"
        '
        'btnBrowseDecrypt
        '
        Me.btnBrowseDecrypt.Location = New System.Drawing.Point(291, 3)
        Me.btnBrowseDecrypt.Name = "btnBrowseDecrypt"
        Me.btnBrowseDecrypt.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowseDecrypt.TabIndex = 8
        Me.btnBrowseDecrypt.Text = "Browse"
        Me.btnBrowseDecrypt.UseVisualStyleBackColor = True
        '
        'txtFileToDecrypt
        '
        Me.txtFileToDecrypt.Location = New System.Drawing.Point(106, 6)
        Me.txtFileToDecrypt.Name = "txtFileToDecrypt"
        Me.txtFileToDecrypt.ReadOnly = True
        Me.txtFileToDecrypt.Size = New System.Drawing.Size(179, 20)
        Me.txtFileToDecrypt.TabIndex = 7
        '
        'txtDecryptFileDestination
        '
        Me.txtDecryptFileDestination.Location = New System.Drawing.Point(106, 32)
        Me.txtDecryptFileDestination.Name = "txtDecryptFileDestination"
        Me.txtDecryptFileDestination.ReadOnly = True
        Me.txtDecryptFileDestination.Size = New System.Drawing.Size(259, 20)
        Me.txtDecryptFileDestination.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "File destination:"
        '
        'frmFileEncryptor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 202)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.pbStatus)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmFileEncryptor"
        Me.Text = "File Encryptor"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtFileToEncrypt As TextBox
    Friend WithEvents txtEncryptFileDestination As TextBox
    Friend WithEvents txtEncryptPassword1 As TextBox
    Friend WithEvents txtEncryptPassword2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents pbStatus As ProgressBar
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents btnBrowseEncrypt As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents btnEncryptFile As Button
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label5 As Label
    Friend WithEvents btnBrowseDecrypt As Button
    Friend WithEvents txtFileToDecrypt As TextBox
    Friend WithEvents txtDecryptFileDestination As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnDecryptFile As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtDecryptPassword2 As TextBox
    Friend WithEvents txtDecryptPassword1 As TextBox
    Friend WithEvents chkDeleteFileAfterEncryption As CheckBox
    Friend WithEvents chkDeleteFileAfterDecryption As CheckBox
End Class
