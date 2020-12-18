Public Class CRY

    Private Sub mnC_Click(sender As System.Object, e As System.EventArgs) Handles mnC.Click
        Dim cript As New Segurança.Criptografia()
        Try
            txtCr.Text = cript.Criptografar(txtCr.Text)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Erro de criptografia!")
            Exit Sub
        End Try
        mnC.Enabled = False
        mnD.Enabled = True
    End Sub

    Private Sub mnD_Click(sender As System.Object, e As System.EventArgs) Handles mnD.Click
        Dim cript As New Segurança.Criptografia()
        Try
            txtCr.Text = cript.Descriptografar(txtCr.Text)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Erro de criptografia!")
            Exit Sub
        End Try
        mnC.Enabled = True
        mnD.Enabled = False
    End Sub
End Class
