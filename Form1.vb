Public Class Form1

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        ' Opens the open file dialog, if the result is good then load the image
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            PictureBox1.Load(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear Picture, Nothing seems to mean null
        PictureBox1.Image = Nothing
    End Sub

    Private Sub btnBackground_Click(sender As Object, e As EventArgs) Handles btnBackground.Click
        ' If colour selection ok, change background colour
        If ColorDialog1.ShowDialog() = DialogResult.OK Then
            PictureBox1.BackColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        ' Terminate Application
        Close()
    End Sub

    Private Sub chkBoxStretch_CheckedChanged(sender As Object, e As EventArgs) Handles chkBoxStretch.CheckedChanged
        If chkBoxStretch.Checked Then
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        Else
            PictureBox1.SizeMode = PictureBoxSizeMode.Normal
        End If
    End Sub

End Class
