Public Class Gen
    Public CheckForm As Boolean ' <~ check form
    Private Sub Closing_() Handles Me.FormClosed
        CheckForm = False ' form nonaktif
    End Sub
    Private Sub Gen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '//////////////////// Placeholder ////////////////////
        txt_id.WaterMark = "Paste Your Uid..."
        result.WaterMark = "Result.."
        '////////////////////////////////////////////////////

        CheckForm = True ' form aktif
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles btnC.Click
        If txt_id.Text <> "" Then ' jika txtid tidak kosong.. Maka.. _
            '/// lanjutkan prosses
            If btnC.Text = "Check" Then ' jika buton bertulisan check, Maka _
                result.Text = AESE(txt_id.Text, mykey) ' buat serialkey ...
                btnC.Text = "Clear" 'ubah text check menjadi clear
            Else
                If btnC.Text = "Clear" Then 'jika btn text = clear ,.. maka _
                    '///// clear text /////
                    txt_id.Clear()
                    result.Clear()
                    '/////////////////////
                    btnC.Text = "Check" 'ubah txt clear menjadi Check
                End If
            End If
        Else
            '// Jika txtid kosong, Maka _
            MsgBox("Gagal, uid tidak boleh kosong",
                            MsgBoxStyle.Exclamation, "")
        End If
    End Sub
#Region ""
    Public Sub c()
        ' Just kidink broo AHAHAHAHA
        If mykey <> "poetratamvan" Then
            MsgBox("Error!" & vbNewLine, MsgBoxStyle.Critical, "code error : poetratamvan")
            Application.Exit()
        End If
    End Sub
#End Region
End Class