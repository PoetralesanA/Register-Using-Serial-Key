<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gen
    Inherits MetroFramework.Forms.MetroForm

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
        Me.btnC = New MetroFramework.Controls.MetroButton()
        Me.txt_id = New MetroFramework.Controls.MetroTextBox()
        Me.result = New MetroFramework.Controls.MetroTextBox()
        Me.SuspendLayout()
        '
        'btnC
        '
        Me.btnC.Location = New System.Drawing.Point(17, 121)
        Me.btnC.Name = "btnC"
        Me.btnC.Size = New System.Drawing.Size(365, 39)
        Me.btnC.TabIndex = 0
        Me.btnC.Text = "Check"
        Me.btnC.UseSelectable = True
        '
        'txt_id
        '
        '
        '
        '
        Me.txt_id.CustomButton.Image = Nothing
        Me.txt_id.CustomButton.Location = New System.Drawing.Point(343, 1)
        Me.txt_id.CustomButton.Name = ""
        Me.txt_id.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txt_id.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_id.CustomButton.TabIndex = 1
        Me.txt_id.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_id.CustomButton.UseSelectable = True
        Me.txt_id.CustomButton.Visible = False
        Me.txt_id.Lines = New String(-1) {}
        Me.txt_id.Location = New System.Drawing.Point(17, 63)
        Me.txt_id.MaxLength = 32767
        Me.txt_id.Name = "txt_id"
        Me.txt_id.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_id.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_id.SelectedText = ""
        Me.txt_id.SelectionLength = 0
        Me.txt_id.SelectionStart = 0
        Me.txt_id.ShortcutsEnabled = True
        Me.txt_id.Size = New System.Drawing.Size(365, 23)
        Me.txt_id.TabIndex = 1
        Me.txt_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_id.UseSelectable = True
        Me.txt_id.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_id.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'result
        '
        '
        '
        '
        Me.result.CustomButton.Image = Nothing
        Me.result.CustomButton.Location = New System.Drawing.Point(343, 1)
        Me.result.CustomButton.Name = ""
        Me.result.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.result.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.result.CustomButton.TabIndex = 1
        Me.result.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.result.CustomButton.UseSelectable = True
        Me.result.CustomButton.Visible = False
        Me.result.Lines = New String(-1) {}
        Me.result.Location = New System.Drawing.Point(17, 92)
        Me.result.MaxLength = 32767
        Me.result.Name = "result"
        Me.result.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.result.ReadOnly = True
        Me.result.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.result.SelectedText = ""
        Me.result.SelectionLength = 0
        Me.result.SelectionStart = 0
        Me.result.ShortcutsEnabled = True
        Me.result.Size = New System.Drawing.Size(365, 23)
        Me.result.TabIndex = 2
        Me.result.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.result.UseSelectable = True
        Me.result.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.result.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Gen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(393, 176)
        Me.Controls.Add(Me.result)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.btnC)
        Me.MaximumSize = New System.Drawing.Size(393, 176)
        Me.MinimumSize = New System.Drawing.Size(393, 176)
        Me.Name = "Gen"
        Me.Opacity = 0.94R
        Me.Text = "Generator"
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnC As MetroFramework.Controls.MetroButton
    Friend WithEvents txt_id As MetroFramework.Controls.MetroTextBox
    Friend WithEvents result As MetroFramework.Controls.MetroTextBox
End Class
