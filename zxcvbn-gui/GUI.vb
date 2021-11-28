#Region "License"
'Copyright(c) 2012 Dropbox, Inc.

'Permission Is hereby granted, free Of charge, to any person obtaining
'a copy Of this software And associated documentation files (the
'"Software"), to deal in the Software without restriction, including
'without limitation the rights To use, copy, modify, merge, publish,
'distribute, sublicense, And/Or sell copies Of the Software, And to
'permit persons To whom the Software Is furnished To Do so, subject To
'the following conditions:

'The above copyright notice And this permission notice shall be
'included in all copies Or substantial portions of the Software.

'THE SOFTWARE Is PROVIDED "AS IS", WITHOUT WARRANTY Of ANY KIND,
'EXPRESS Or IMPLIED, INCLUDING BUT Not LIMITED TO THE WARRANTIES OF
'MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE And
'NONINFRINGEMENT.IN NO EVENT SHALL THE AUTHORS Or COPYRIGHT HOLDERS BE
'LIABLE FOR ANY CLAIM, DAMAGES Or OTHER LIABILITY, WHETHER IN AN ACTION
'OF CONTRACT, TORT Or OTHERWISE, ARISING FROM, OUT OF Or IN CONNECTION
'With THE SOFTWARE Or THE USE Or OTHER DEALINGS In THE SOFTWARE.
#End Region
#Region "Code"
Imports Zxcvbn

Public Class GUI
    Dim zx As New Zxcvbn.Zxcvbn
    ''' <summary>
    ''' Mask the Checkbox if it was masked previously by checking My.Settings and setting the Check Box properly.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub GUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.MaskedEnabled = True Then
            tb_Pswd.UseSystemPasswordChar = True
            cb_EnableMasking.Checked = True
        ElseIf My.Settings.MaskedEnabled = False Then
            tb_Pswd.UseSystemPasswordChar = False
            cb_EnableMasking.Checked = False
        End If
    End Sub

    ''' <summary>
    ''' Calculate the Entropy, Crack Time and Score on Text Change
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tb_Pswd_TextChanged(sender As Object, e As EventArgs) Handles tb_Pswd.TextChanged
        Dim result = zx.EvaluatePassword(tb_Pswd.Text)

        ' Set Text to N/A if Text Box is empty
        If tb_Pswd.Text = "" Or tb_Pswd.Text = Nothing Then
            l_EntropyVar.Text = "N/A"
            l_CrackTimeVar.Text = "N/A ; N/A"
            l_ScoreVar.Text = "N/A"
            l_CalcTimeVar.Text = "N/A"
            'Set Score Image to Nothing
            pb_Score.Image = Nothing
        Else
            l_EntropyVar.Text = result.Entropy
            l_CrackTimeVar.Text = result.CrackTime & " ; " & result.CrackTimeDisplay
            l_ScoreVar.Text = result.Score
            l_CalcTimeVar.Text = result.CalcTime
            'Get and Set Score Image
            pb_Score.Image = GetScoreImage(result.Score)
        End If
    End Sub
    ''' <summary>
    ''' Get Score Image using the passed Score paramater
    ''' </summary>
    ''' <param name="Score"></param>
    ''' <returns></returns>
    Private Function GetScoreImage(Score As Integer)
        Dim result = Nothing
        If Score = 0 Or Score = 1 Then result = My.Resources.red
        If Score = 2 Then result = My.Resources.yellow
        If Score = 3 Or Score = 4 Then result = My.Resources.green
        ' Throw an Exception if Score is above 4 or below 0
        If Score > 5 Or Score < -1 Then result = Nothing : Throw New Exception("Invalid Score parameter passed. The Score Parameter must be above 0 and below 4.")
        Return result
    End Function

    ''' <summary>
    ''' Save the Masking Setting and Mask the Text Box, on Checked Change
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cb_EnableMasking_CheckedChanged(sender As Object, e As EventArgs) Handles cb_EnableMasking.CheckedChanged
        If cb_EnableMasking.Checked = True Then
            tb_Pswd.UseSystemPasswordChar = True
            My.Settings.MaskedEnabled = True : My.Settings.Save()
        ElseIf cb_EnableMasking.Checked = False Then
            tb_Pswd.UseSystemPasswordChar = False
            My.Settings.MaskedEnabled = False : My.Settings.Save()
        End If
    End Sub

    ''' <summary>
    ''' Display the Dropbox License on Button Press
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub bt_DisplayLicense_Click(sender As Object, e As EventArgs) Handles bt_DisplayLicense.Click
        MsgBox(My.Resources.DropboxLicense, MsgBoxStyle.Information, "License for zxcvbn, zxcvbn-cs and zxcvbn-gui")
    End Sub
End Class
#End Region