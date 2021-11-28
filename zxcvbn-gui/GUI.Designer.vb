<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GUI
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GUI))
        Me.l_CheckPswd = New System.Windows.Forms.Label()
        Me.l_Entropy = New System.Windows.Forms.Label()
        Me.l_CrackTime = New System.Windows.Forms.Label()
        Me.l_CalcTime = New System.Windows.Forms.Label()
        Me.l_Score = New System.Windows.Forms.Label()
        Me.tb_Pswd = New System.Windows.Forms.TextBox()
        Me.l_CalcTimeVar = New System.Windows.Forms.Label()
        Me.l_ScoreVar = New System.Windows.Forms.Label()
        Me.l_CrackTimeVar = New System.Windows.Forms.Label()
        Me.l_EntropyVar = New System.Windows.Forms.Label()
        Me.cb_EnableMasking = New System.Windows.Forms.CheckBox()
        Me.tt_Main = New System.Windows.Forms.ToolTip(Me.components)
        Me.bt_DisplayLicense = New System.Windows.Forms.Button()
        Me.pb_Score = New System.Windows.Forms.PictureBox()
        CType(Me.pb_Score, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'l_CheckPswd
        '
        Me.l_CheckPswd.AutoSize = True
        Me.l_CheckPswd.Location = New System.Drawing.Point(12, 12)
        Me.l_CheckPswd.Name = "l_CheckPswd"
        Me.l_CheckPswd.Size = New System.Drawing.Size(116, 17)
        Me.l_CheckPswd.TabIndex = 0
        Me.l_CheckPswd.Text = "Check Password:"
        Me.tt_Main.SetToolTip(Me.l_CheckPswd, "To begin calculating the Password Strength, Entropy, Crack Time and Score, begin " &
        "typing into the Text Box.")
        '
        'l_Entropy
        '
        Me.l_Entropy.AutoSize = True
        Me.l_Entropy.Location = New System.Drawing.Point(12, 44)
        Me.l_Entropy.Name = "l_Entropy"
        Me.l_Entropy.Size = New System.Drawing.Size(61, 17)
        Me.l_Entropy.TabIndex = 1
        Me.l_Entropy.Text = "Entropy:"
        Me.tt_Main.SetToolTip(Me.l_Entropy, "Bits of entropy for the Password.")
        '
        'l_CrackTime
        '
        Me.l_CrackTime.AutoSize = True
        Me.l_CrackTime.Location = New System.Drawing.Point(12, 67)
        Me.l_CrackTime.Name = "l_CrackTime"
        Me.l_CrackTime.Size = New System.Drawing.Size(83, 17)
        Me.l_CrackTime.TabIndex = 2
        Me.l_CrackTime.Text = "Crack Time:"
        Me.tt_Main.SetToolTip(Me.l_CrackTime, "The amount of Time it would take to crack the specified Password. Displayed like " &
        "the following:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Seconds ; Human Readable Time")
        '
        'l_CalcTime
        '
        Me.l_CalcTime.AutoSize = True
        Me.l_CalcTime.Location = New System.Drawing.Point(12, 113)
        Me.l_CalcTime.Name = "l_CalcTime"
        Me.l_CalcTime.Size = New System.Drawing.Size(116, 17)
        Me.l_CalcTime.TabIndex = 4
        Me.l_CalcTime.Text = "Calculation Time:"
        Me.tt_Main.SetToolTip(Me.l_CalcTime, "The amount of Time the zxcvbn library took to calculate the Entropy, Crack Time a" &
        "nd Score Values.")
        '
        'l_Score
        '
        Me.l_Score.AutoSize = True
        Me.l_Score.Location = New System.Drawing.Point(12, 90)
        Me.l_Score.Name = "l_Score"
        Me.l_Score.Size = New System.Drawing.Size(49, 17)
        Me.l_Score.TabIndex = 3
        Me.l_Score.Text = "Score:"
        Me.tt_Main.SetToolTip(Me.l_Score, resources.GetString("l_Score.ToolTip"))
        '
        'tb_Pswd
        '
        Me.tb_Pswd.Location = New System.Drawing.Point(134, 9)
        Me.tb_Pswd.Name = "tb_Pswd"
        Me.tb_Pswd.Size = New System.Drawing.Size(459, 22)
        Me.tb_Pswd.TabIndex = 5
        '
        'l_CalcTimeVar
        '
        Me.l_CalcTimeVar.AutoSize = True
        Me.l_CalcTimeVar.Location = New System.Drawing.Point(131, 113)
        Me.l_CalcTimeVar.Name = "l_CalcTimeVar"
        Me.l_CalcTimeVar.Size = New System.Drawing.Size(31, 17)
        Me.l_CalcTimeVar.TabIndex = 9
        Me.l_CalcTimeVar.Text = "N/A"
        '
        'l_ScoreVar
        '
        Me.l_ScoreVar.AutoSize = True
        Me.l_ScoreVar.Location = New System.Drawing.Point(131, 90)
        Me.l_ScoreVar.Name = "l_ScoreVar"
        Me.l_ScoreVar.Size = New System.Drawing.Size(31, 17)
        Me.l_ScoreVar.TabIndex = 8
        Me.l_ScoreVar.Text = "N/A"
        '
        'l_CrackTimeVar
        '
        Me.l_CrackTimeVar.AutoSize = True
        Me.l_CrackTimeVar.Location = New System.Drawing.Point(131, 67)
        Me.l_CrackTimeVar.Name = "l_CrackTimeVar"
        Me.l_CrackTimeVar.Size = New System.Drawing.Size(66, 17)
        Me.l_CrackTimeVar.TabIndex = 7
        Me.l_CrackTimeVar.Text = "N/A ; N/A"
        '
        'l_EntropyVar
        '
        Me.l_EntropyVar.AutoSize = True
        Me.l_EntropyVar.Location = New System.Drawing.Point(131, 44)
        Me.l_EntropyVar.Name = "l_EntropyVar"
        Me.l_EntropyVar.Size = New System.Drawing.Size(31, 17)
        Me.l_EntropyVar.TabIndex = 6
        Me.l_EntropyVar.Text = "N/A"
        '
        'cb_EnableMasking
        '
        Me.cb_EnableMasking.AutoSize = True
        Me.cb_EnableMasking.Location = New System.Drawing.Point(456, 40)
        Me.cb_EnableMasking.Name = "cb_EnableMasking"
        Me.cb_EnableMasking.Size = New System.Drawing.Size(137, 21)
        Me.cb_EnableMasking.TabIndex = 11
        Me.cb_EnableMasking.Text = "Masked Text Box"
        Me.tt_Main.SetToolTip(Me.cb_EnableMasking, "Enables or Disables the Masking of the Text Box." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This Setting will be remembered" &
        " on Program Exit.")
        Me.cb_EnableMasking.UseVisualStyleBackColor = True
        '
        'tt_Main
        '
        Me.tt_Main.AutomaticDelay = 50
        Me.tt_Main.AutoPopDelay = 5000
        Me.tt_Main.InitialDelay = 50
        Me.tt_Main.ReshowDelay = 10
        Me.tt_Main.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'bt_DisplayLicense
        '
        Me.bt_DisplayLicense.Location = New System.Drawing.Point(456, 104)
        Me.bt_DisplayLicense.Name = "bt_DisplayLicense"
        Me.bt_DisplayLicense.Size = New System.Drawing.Size(137, 32)
        Me.bt_DisplayLicense.TabIndex = 12
        Me.bt_DisplayLicense.Text = "Display License"
        Me.tt_Main.SetToolTip(Me.bt_DisplayLicense, "Displays the Dropbox License for zxcvbn, zxcvbn-cs and zxcvbn-gui.")
        Me.bt_DisplayLicense.UseVisualStyleBackColor = True
        '
        'pb_Score
        '
        Me.pb_Score.Location = New System.Drawing.Point(168, 90)
        Me.pb_Score.Name = "pb_Score"
        Me.pb_Score.Size = New System.Drawing.Size(17, 17)
        Me.pb_Score.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_Score.TabIndex = 10
        Me.pb_Score.TabStop = False
        '
        'GUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(605, 142)
        Me.Controls.Add(Me.bt_DisplayLicense)
        Me.Controls.Add(Me.cb_EnableMasking)
        Me.Controls.Add(Me.pb_Score)
        Me.Controls.Add(Me.l_CalcTimeVar)
        Me.Controls.Add(Me.l_ScoreVar)
        Me.Controls.Add(Me.l_CrackTimeVar)
        Me.Controls.Add(Me.l_EntropyVar)
        Me.Controls.Add(Me.tb_Pswd)
        Me.Controls.Add(Me.l_CalcTime)
        Me.Controls.Add(Me.l_Score)
        Me.Controls.Add(Me.l_CrackTime)
        Me.Controls.Add(Me.l_Entropy)
        Me.Controls.Add(Me.l_CheckPswd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "GUI"
        Me.Text = "zxcvbn GUI"
        CType(Me.pb_Score, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents l_CheckPswd As Label
    Friend WithEvents l_Entropy As Label
    Friend WithEvents l_CrackTime As Label
    Friend WithEvents l_CalcTime As Label
    Friend WithEvents l_Score As Label
    Friend WithEvents tb_Pswd As TextBox
    Friend WithEvents l_CalcTimeVar As Label
    Friend WithEvents l_ScoreVar As Label
    Friend WithEvents l_CrackTimeVar As Label
    Friend WithEvents l_EntropyVar As Label
    Friend WithEvents pb_Score As PictureBox
    Friend WithEvents cb_EnableMasking As CheckBox
    Friend WithEvents tt_Main As ToolTip
    Friend WithEvents bt_DisplayLicense As Button
End Class
