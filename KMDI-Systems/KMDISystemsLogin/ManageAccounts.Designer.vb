<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageAccounts
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.FullnameTbox = New MetroFramework.Controls.MetroTextBox()
        Me.AddUserBtn = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.MetroGrid1 = New MetroFramework.Controls.MetroGrid()
        Me.NicknameTbox = New MetroFramework.Controls.MetroTextBox()
        Me.MetroComboBox1 = New MetroFramework.Controls.MetroComboBox()
        Me.UpdateUserBtn = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FullnameTbox
        '
        '
        '
        '
        Me.FullnameTbox.CustomButton.Image = Nothing
        Me.FullnameTbox.CustomButton.Location = New System.Drawing.Point(370, 1)
        Me.FullnameTbox.CustomButton.Name = ""
        Me.FullnameTbox.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.FullnameTbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.FullnameTbox.CustomButton.TabIndex = 1
        Me.FullnameTbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.FullnameTbox.CustomButton.UseSelectable = True
        Me.FullnameTbox.CustomButton.Visible = False
        Me.FullnameTbox.Lines = New String(-1) {}
        Me.FullnameTbox.Location = New System.Drawing.Point(11, 25)
        Me.FullnameTbox.MaxLength = 32767
        Me.FullnameTbox.Name = "FullnameTbox"
        Me.FullnameTbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.FullnameTbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.FullnameTbox.SelectedText = ""
        Me.FullnameTbox.SelectionLength = 0
        Me.FullnameTbox.SelectionStart = 0
        Me.FullnameTbox.Size = New System.Drawing.Size(392, 23)
        Me.FullnameTbox.Style = MetroFramework.MetroColorStyle.Blue
        Me.FullnameTbox.TabIndex = 1
        Me.FullnameTbox.UseCustomForeColor = True
        Me.FullnameTbox.UseSelectable = True
        Me.FullnameTbox.UseStyleColors = True
        Me.FullnameTbox.WaterMark = "Fullname"
        Me.FullnameTbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FullnameTbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'AddUserBtn
        '
        Me.AddUserBtn.Image = Nothing
        Me.AddUserBtn.Location = New System.Drawing.Point(739, 25)
        Me.AddUserBtn.Name = "AddUserBtn"
        Me.AddUserBtn.Size = New System.Drawing.Size(55, 23)
        Me.AddUserBtn.Style = MetroFramework.MetroColorStyle.Teal
        Me.AddUserBtn.TabIndex = 4
        Me.AddUserBtn.Text = "&Add"
        Me.AddUserBtn.UseCustomBackColor = True
        Me.AddUserBtn.UseCustomForeColor = True
        Me.AddUserBtn.UseSelectable = True
        Me.AddUserBtn.UseStyleColors = True
        Me.AddUserBtn.UseVisualStyleBackColor = True
        '
        'MetroGrid1
        '
        Me.MetroGrid1.AllowUserToResizeRows = False
        Me.MetroGrid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MetroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.MetroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.MetroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MetroGrid1.DefaultCellStyle = DataGridViewCellStyle5
        Me.MetroGrid1.EnableHeadersVisualStyles = False
        Me.MetroGrid1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MetroGrid1.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroGrid1.Location = New System.Drawing.Point(9, 56)
        Me.MetroGrid1.Name = "MetroGrid1"
        Me.MetroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid1.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.MetroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.MetroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MetroGrid1.Size = New System.Drawing.Size(846, 351)
        Me.MetroGrid1.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroGrid1.TabIndex = 6
        Me.MetroGrid1.UseStyleColors = True
        '
        'NicknameTbox
        '
        '
        '
        '
        Me.NicknameTbox.CustomButton.Image = Nothing
        Me.NicknameTbox.CustomButton.Location = New System.Drawing.Point(99, 1)
        Me.NicknameTbox.CustomButton.Name = ""
        Me.NicknameTbox.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.NicknameTbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.NicknameTbox.CustomButton.TabIndex = 1
        Me.NicknameTbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.NicknameTbox.CustomButton.UseSelectable = True
        Me.NicknameTbox.CustomButton.Visible = False
        Me.NicknameTbox.Lines = New String(-1) {}
        Me.NicknameTbox.Location = New System.Drawing.Point(409, 25)
        Me.NicknameTbox.MaxLength = 32767
        Me.NicknameTbox.Name = "NicknameTbox"
        Me.NicknameTbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.NicknameTbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.NicknameTbox.SelectedText = ""
        Me.NicknameTbox.SelectionLength = 0
        Me.NicknameTbox.SelectionStart = 0
        Me.NicknameTbox.Size = New System.Drawing.Size(121, 23)
        Me.NicknameTbox.Style = MetroFramework.MetroColorStyle.Blue
        Me.NicknameTbox.TabIndex = 2
        Me.NicknameTbox.UseCustomForeColor = True
        Me.NicknameTbox.UseSelectable = True
        Me.NicknameTbox.UseStyleColors = True
        Me.NicknameTbox.WaterMark = "Nickname"
        Me.NicknameTbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.NicknameTbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroComboBox1
        '
        Me.MetroComboBox1.FormattingEnabled = True
        Me.MetroComboBox1.ItemHeight = 23
        Me.MetroComboBox1.Location = New System.Drawing.Point(536, 21)
        Me.MetroComboBox1.Name = "MetroComboBox1"
        Me.MetroComboBox1.Size = New System.Drawing.Size(197, 29)
        Me.MetroComboBox1.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroComboBox1.TabIndex = 3
        Me.MetroComboBox1.UseCustomBackColor = True
        Me.MetroComboBox1.UseCustomForeColor = True
        Me.MetroComboBox1.UseSelectable = True
        Me.MetroComboBox1.UseStyleColors = True
        '
        'UpdateUserBtn
        '
        Me.UpdateUserBtn.Image = Nothing
        Me.UpdateUserBtn.Location = New System.Drawing.Point(800, 25)
        Me.UpdateUserBtn.Name = "UpdateUserBtn"
        Me.UpdateUserBtn.Size = New System.Drawing.Size(55, 23)
        Me.UpdateUserBtn.TabIndex = 5
        Me.UpdateUserBtn.Text = "Updat&e"
        Me.UpdateUserBtn.UseSelectable = True
        Me.UpdateUserBtn.UseVisualStyleBackColor = True
        '
        'ManageAccounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(865, 414)
        Me.Controls.Add(Me.UpdateUserBtn)
        Me.Controls.Add(Me.MetroComboBox1)
        Me.Controls.Add(Me.NicknameTbox)
        Me.Controls.Add(Me.MetroGrid1)
        Me.Controls.Add(Me.AddUserBtn)
        Me.Controls.Add(Me.FullnameTbox)
        Me.Name = "ManageAccounts"
        Me.Theme = MetroFramework.MetroThemeStyle.[Default]
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FullnameTbox As MetroFramework.Controls.MetroTextBox
    Friend AddUserBtn As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents MetroGrid1 As MetroFramework.Controls.MetroGrid
    Friend WithEvents NicknameTbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroComboBox1 As MetroFramework.Controls.MetroComboBox
    Friend UpdateUserBtn As MetroFramework.Controls.MetroTextBox.MetroTextButton
End Class
