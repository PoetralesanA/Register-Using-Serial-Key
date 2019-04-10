'//////////////////////////////// Message /////////////////////////////////'
' ./Read
'Hello Mastah.. Selamat datang di Software sederhana saya.. _
'saya membuat app ini dari 0 & saya berharap, jika ingin dioprek kembali _
'cantumkan nama saya beserta group Programmer VB.NET Indonesia (https://www.facebook.com/groups/72258093620) .
'Semoga tools ini bermanfaat yaa untuk kalian.. Selamat mengembangkan... ^_^ 
'//////////////////////////////////////////////////////////////////////////'
Imports Microsoft.Win32 'Registry Akses
Public Class formReg
    WithEvents mytimer As New Timer
    Dim nick = My.Computer.Name
    Dim CheckColor = False
    Private Sub MyID()
        '// ini masih basicnya aja yaa~ _
        ' kalian bisa kembangkan lagi nantinya,. entah mengabungkan dengan nama computer, mac addr / hwid.


        '// = Menampilkan info TotalPhysicalMemory & TotalVirtualMemory = //
        With My.Computer.Info
            txt_id.Text = .TotalPhysicalMemory & "-" &
                                .TotalVirtualMemory
        End With
        '-------------------------------------------------------------------
    End Sub
    Private Sub Close_()
        Me.Close()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MetroTabControl1.SelectedIndex = 0 ' select tab 1
        icoAbout()
        Me.StyleManager = MetroStyleManager1

        MyID() 'userid
        txt_key.WaterMark = "Insert Your Key...." 'placeholder
        mytimer.Interval = 10 ' set timer
        pgb.Visible = False 'hide progressbar
        Me.MaximizeBox = False ' disable maxBox
        Gen.c()
        silentencrypt.Text = (AESE(txt_id.Text, mykey)) ' <~ || silent check || (registry) _
        ' untuk memberi value (secara encrypt) ke registry ,, yang nantinya akan di check kembali(decrypt)

        '/////////////////////////////////////////////////////////////////////////////////////////////////
        '// ------------------------------------ Check Register ------------------------------------
        Try
            Dim valGet As String = Registry.GetValue(
                           "hkey_current_user\software\vb and vba program settings\Appregist", "key",
                           Nothing)
            If AESD(valGet, mykey) = txt_id.Text Then ' jika value pada registry(decrypt) = txt_id _ maka
                'formMain.Show()
                'Me.Close()
                formMain.Show()
                Me.BeginInvoke(New MethodInvoker(AddressOf Close_)) ' <~ handle error (delay sebelum keluar)
            End If
        Catch ex As Exception
            'bypass error msg registry :D
        End Try
        '--------------------------------------------------------------------------------------------
    End Sub

    Private Sub btn_register(sender As Object, e As EventArgs) Handles MetroButton1.Click
        If Gen.CheckForm = True Then ' jika form masih aktif (checkform=true), Maka..
            '// Tampilkan pesan >>
            MsgBox("Prosses Gagal, Form Gen Masih Berjalan",
                    MsgBoxStyle.Exclamation, "")
        Else
            '// Jika check form=false (tidak aktif), maka.. _
            ' Lanjutkan prosses >>
            If AESD(txt_key.Text, mykey) = txt_id.Text Then 'jika txt_key(Decrypt) sama dengan txt_id . Maka_
                setVal() ' isi value(key) dalam registry
                'tampilkan
                MsgBox("Hello~ Welcome " & nick & vbNewLine & vbNewLine &
                     "This App Created By PoetralesanA", MsgBoxStyle.Information, "")
                formMain.Show()
                Me.Close()
            Else
                txt_key.WithError = True ' <~  control txt error
                MsgBox("Key Failed!!", MsgBoxStyle.Critical, "")
                txt_key.Clear()
            End If
        End If
    End Sub
    Private Sub timer() Handles mytimer.Tick
        'pgb = progressbar
        pgb.Value += 1
        If pgb.Value = 100 Then
            mytimer.Stop()
            MetroButton2.Enabled = True
            FmCollors()
            MetroButton2.Text = "Terapkan"

            ' Validasi Warna
            If CheckColor <> False Then
                MsgBox("Done~", MsgBoxStyle.Information, "")
            End If
        End If
    End Sub
    Private Sub btn_theme(sender As Object, e As EventArgs) Handles MetroButton2.Click
        MetroButton2.Enabled = False
        MetroButton2.Text = "Process..."
        pgb.Value = 0
        pgb.Visible = True
        mytimer.Start()
    End Sub

    Private Sub MetroTabPage1_Click(sender As Object, e As EventArgs) Handles MetroTabPage1.Leave ' event tab keluar
        '/////// refresh /////////
        txt_key.Clear()
        txt_key.WithError = False
        MetroButton2.Text = "Terapkan"
        '/////////////////////////
    End Sub
    Private Sub callformGen(sender As Object, e As EventArgs) Handles MetroLink1.Click
        Gen.Show()
    End Sub
    Private Sub setVal() 'mengisi value key di registry
        Try
            Registry.SetValue(
                            "hkey_current_user\software\vb and vba program settings\Appregist", "key",
                            silentencrypt.Text)
        Catch ex As Exception
            ' bypass error msg Registry
        End Try
    End Sub
    Public Sub CheckNremoveReg()
        Try
            Dim checking = Registry.CurrentUser.OpenSubKey("software\vb and vba program settings\Appregist", False) ' check folder Appregist
            If checking Is Nothing Then ' jika tidak tersedia, maka _
                MsgBox("Gagal, karena subkey tidak tersedia", MsgBoxStyle.Critical, "") ' <~ tampilkan pesan
                Application.Exit()
            Else ' sebaliknya (jika terpenuhi,..) , Maka _
                Registry.CurrentUser.DeleteSubKey("software\vb and vba program settings\Appregist") ' delete sub
                MsgBox("Reset Berhasil~" & vbNewLine &
             "Aplikasi akan melakukan load kembali", MsgBoxStyle.Information, "")
                Application.Restart()
            End If
        Catch ex As Exception
            ' bypass error msg Registry
        End Try
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Try
            Dim q = MessageBox.Show("Kunjungi Group...?", "Visit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If q = MsgBoxResult.Yes Then
                Process.Start("https://www.facebook.com/groups/72258093620")
            End If
        Catch ex As Exception
            '//Handle jika user belum pernah memilih browser
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "")
        End Try

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Try
            Process.Start(My.Resources.mycontact)
        Catch ex As Exception
            'Handle jika user belum pernah memilih browser
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "")
        End Try

    End Sub
    Private Sub icoAbout()
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.Image = My.Resources.about
    End Sub
    Private Sub FmCollors()
        CheckColor = True
        If r1.Checked = True Then
            MetroStyleManager1.Style = MetroFramework.MetroColorStyle.Black
        ElseIf r2.Checked = True Then
            MetroStyleManager1.Style = MetroFramework.MetroColorStyle.Blue
        ElseIf r3.Checked = True Then
            MetroStyleManager1.Style = MetroFramework.MetroColorStyle.Brown
        ElseIf r4.Checked = True Then
            MetroStyleManager1.Style = MetroFramework.MetroColorStyle.Default
        ElseIf r5.Checked = True Then
            MetroStyleManager1.Style = MetroFramework.MetroColorStyle.Green
        ElseIf r6.Checked = True Then
            MetroStyleManager1.Style = MetroFramework.MetroColorStyle.Lime
        ElseIf r7.Checked = True Then
            MetroStyleManager1.Style = MetroFramework.MetroColorStyle.Magenta
        ElseIf r8.Checked = True Then
            MetroStyleManager1.Style = MetroFramework.MetroColorStyle.Orange
        ElseIf r9.Checked = True Then
            MetroStyleManager1.Style = MetroFramework.MetroColorStyle.Pink
        ElseIf r10.Checked = True Then
            MetroStyleManager1.Style = MetroFramework.MetroColorStyle.Purple
        ElseIf r11.Checked = True Then
            MetroStyleManager1.Style = MetroFramework.MetroColorStyle.Red
        ElseIf r12.Checked = True Then
            MetroStyleManager1.Style = MetroFramework.MetroColorStyle.Silver
        ElseIf r13.Checked = True Then
            MetroStyleManager1.Style = MetroFramework.MetroColorStyle.Teal
        ElseIf r14.Checked = True Then
            MetroStyleManager1.Style = MetroFramework.MetroColorStyle.Yellow
        Else
            CheckColor = False
            Dim acc = MsgBox("Anda belum memilih warna",
                            MsgBoxStyle.Critical, "Error!")
        End If
    End Sub
End Class