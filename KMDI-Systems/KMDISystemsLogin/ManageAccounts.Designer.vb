<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ManageAccounts
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.FullnameTbox = New MetroFramework.Controls.MetroTextBox()
        Me.AddUserBtn = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.MetroGrid1 = New MetroFramework.Controls.MetroGrid()
        Me.NicknameTbox = New MetroFramework.Controls.MetroTextBox()
        Me.MetroComboBox1 = New MetroFramework.Controls.MetroComboBox()
        Me.UpdateUserBtn = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.AddUserAccessBtn = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
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
        Me.FullnameTbox.ForeColor = System.Drawing.Color.DimGray
        Me.FullnameTbox.Lines = New String(-1) {}
        Me.FullnameTbox.Location = New System.Drawing.Point(9, 47)
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
        Me.FullnameTbox.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.FullnameTbox.UseCustomBackColor = True
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
        Me.AddUserBtn.Location = New System.Drawing.Point(737, 43)
        Me.AddUserBtn.Name = "AddUserBtn"
        Me.AddUserBtn.Size = New System.Drawing.Size(55, 29)
        Me.AddUserBtn.Style = MetroFramework.MetroColorStyle.Teal
        Me.AddUserBtn.TabIndex = 4
        Me.AddUserBtn.Text = "&Add"
        Me.AddUserBtn.Theme = MetroFramework.MetroThemeStyle.Dark
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.MetroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MetroGrid1.DefaultCellStyle = DataGridViewCellStyle2
        Me.MetroGrid1.EnableHeadersVisualStyles = False
        Me.MetroGrid1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MetroGrid1.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroGrid1.Location = New System.Drawing.Point(9, 76)
        Me.MetroGrid1.Name = "MetroGrid1"
        Me.MetroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.MetroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.MetroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MetroGrid1.Size = New System.Drawing.Size(846, 328)
        Me.MetroGrid1.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroGrid1.TabIndex = 6
        Me.MetroGrid1.UseCustomBackColor = True
        Me.MetroGrid1.UseCustomForeColor = True
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
        Me.NicknameTbox.Location = New System.Drawing.Point(407, 47)
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
        Me.NicknameTbox.UseCustomBackColor = True
        Me.NicknameTbox.UseCustomForeColor = True
        Me.NicknameTbox.UseSelectable = True
        Me.NicknameTbox.UseStyleColors = True
        Me.NicknameTbox.WaterMark = "Nickname"
        Me.NicknameTbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.NicknameTbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroComboBox1
        '
        Me.MetroComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MetroComboBox1.FormattingEnabled = True
        Me.MetroComboBox1.ItemHeight = 23
        Me.MetroComboBox1.Location = New System.Drawing.Point(534, 43)
        Me.MetroComboBox1.Name = "MetroComboBox1"
        Me.MetroComboBox1.Size = New System.Drawing.Size(174, 29)
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
        Me.UpdateUserBtn.Location = New System.Drawing.Point(798, 43)
        Me.UpdateUserBtn.Name = "UpdateUserBtn"
        Me.UpdateUserBtn.Size = New System.Drawing.Size(55, 29)
        Me.UpdateUserBtn.TabIndex = 5
        Me.UpdateUserBtn.Text = "Updat&e"
        Me.UpdateUserBtn.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.UpdateUserBtn.UseSelectable = True
        Me.UpdateUserBtn.UseVisualStyleBackColor = True
        '
        'AddUserAccessBtn
        '
        Me.AddUserAccessBtn.Image = Nothing
        Me.AddUserAccessBtn.Location = New System.Drawing.Point(710, 43)
        Me.AddUserAccessBtn.Name = "AddUserAccessBtn"
        Me.AddUserAccessBtn.Size = New System.Drawing.Size(19, 29)
        Me.AddUserAccessBtn.Style = MetroFramework.MetroColorStyle.Teal
        Me.AddUserAccessBtn.TabIndex = 7
        Me.AddUserAccessBtn.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.AddUserAccessBtn.UseCustomBackColor = True
        Me.AddUserAccessBtn.UseCustomForeColor = True
        Me.AddUserAccessBtn.UseSelectable = True
        Me.AddUserAccessBtn.UseStyleColors = True
        Me.AddUserAccessBtn.UseVisualStyleBackColor = True
        '
        'ManageAccounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(865, 414)
        Me.Controls.Add(Me.AddUserAccessBtn)
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
    Friend WithEvents UpdateUserBtn As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend AddUserAccessBtn As MetroFramework.Controls.MetroTextBox.MetroTextButton
End Class
