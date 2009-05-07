Option Explicit On
Public Class frmMain

    Private Sub cmdBrowseImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBrowseImage.Click
        Dim dlgImage As New OpenFileDialog
        Dim dlgRstImage As New DialogResult

        dlgImage.ShowDialog()
        txtImage.Text = dlgImage.FileName

    End Sub

    Private Sub cmdBrowseIcon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBrowseIcon.Click
        Dim dlgImage As New FolderBrowserDialog
        Dim dlgRstImage As New DialogResult

        dlgImage.ShowDialog()
        txtIcon.Text = dlgImage.SelectedPath

    End Sub

    Private Sub cmdConvert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConvert.Click
        Try
            Dim icoImage As Image
            Dim icoBMP As Bitmap
            Dim icoIOStream As System.IO.StreamWriter = System.IO.File.CreateText(txtIcon.Text)

            icoImage = Image.FromFile(txtImage.Text)
            PictureBox1.Image = icoImage
            icoBMP = CType(icoImage, Bitmap)
            Icon.FromHandle(icoBMP.GetHicon).Save(icoIOStream.BaseStream)
            icoIOStream.Close()
            icoIOStream.Dispose()
            'icoImage.Save(txtIcon.Text, System.Drawing.Imaging.ImageFormat.Icon)
            Call MsgBox("Successfully Converted Image to Icon", MsgBoxStyle.OkOnly, "Success")
        Catch
            Call MsgBox(Err.Description, MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub
End Class
