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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.FullnameTbox = New MetroFramework.Controls.MetroTextBox()
        Me.AddUserBtn = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.UserAcctDGV = New MetroFramework.Controls.MetroGrid()
        Me.NicknameTbox = New MetroFramework.Controls.MetroTextBox()
        Me.UserAccessCbox = New MetroFramework.Controls.MetroComboBox()
        Me.UpdateUserBtn = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.AddUserAccessBtn = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        CType(Me.UserAcctDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FullnameTbox
        '
        '
        '
        '
        Me.FullnameTbox.CustomButton.Image = Nothing
        Me.FullnameTbox.CustomButton.Location = New System.Drawing.Point(344, 1)
        Me.FullnameTbox.CustomButton.Name = ""
        Me.FullnameTbox.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.FullnameTbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.FullnameTbox.CustomButton.TabIndex = 1
        Me.FullnameTbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.FullnameTbox.CustomButton.UseSelectable = True
        Me.FullnameTbox.CustomButton.Visible = False
        Me.FullnameTbox.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.FullnameTbox.ForeColor = System.Drawing.Color.Black
        Me.FullnameTbox.Lines = New String(-1) {}
        Me.FullnameTbox.Location = New System.Drawing.Point(20, 47)
        Me.FullnameTbox.MaxLength = 32767
        Me.FullnameTbox.Name = "FullnameTbox"
        Me.FullnameTbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.FullnameTbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.FullnameTbox.SelectedText = ""
        Me.FullnameTbox.SelectionLength = 0
        Me.FullnameTbox.SelectionStart = 0
        Me.FullnameTbox.Size = New System.Drawing.Size(366, 23)
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
        Me.AddUserBtn.BackColor = System.Drawing.Color.Black
        Me.AddUserBtn.ForeColor = System.Drawing.Color.Black
        Me.AddUserBtn.Image = Nothing
        Me.AddUserBtn.Location = New System.Drawing.Point(729, 43)
        Me.AddUserBtn.Name = "AddUserBtn"
        Me.AddUserBtn.Size = New System.Drawing.Size(55, 29)
        Me.AddUserBtn.Style = MetroFramework.MetroColorStyle.Teal
        Me.AddUserBtn.TabIndex = 4
        Me.AddUserBtn.Text = "&Add"
        Me.AddUserBtn.UseCustomBackColor = True
        Me.AddUserBtn.UseCustomForeColor = True
        Me.AddUserBtn.UseSelectable = True
        Me.AddUserBtn.UseStyleColors = True
        Me.AddUserBtn.UseVisualStyleBackColor = False
        '
        'UserAcctDGV
        '
        Me.UserAcctDGV.AllowUserToAddRows = False
        Me.UserAcctDGV.AllowUserToDeleteRows = False
        Me.UserAcctDGV.AllowUserToOrderColumns = True
        Me.UserAcctDGV.AllowUserToResizeRows = False
        Me.UserAcctDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.UserAcctDGV.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UserAcctDGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.UserAcctDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.UserAcctDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.UserAcctDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.UserAcctDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.UserAcctDGV.DefaultCellStyle = DataGridViewCellStyle5
        Me.UserAcctDGV.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UserAcctDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.UserAcctDGV.EnableHeadersVisualStyles = False
        Me.UserAcctDGV.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.UserAcctDGV.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UserAcctDGV.Location = New System.Drawing.Point(20, 90)
        Me.UserAcctDGV.MultiSelect = False
        Me.UserAcctDGV.Name = "UserAcctDGV"
        Me.UserAcctDGV.ReadOnly = True
        Me.UserAcctDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.UserAcctDGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.UserAcctDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.UserAcctDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.UserAcctDGV.Size = New System.Drawing.Size(825, 304)
        Me.UserAcctDGV.Style = MetroFramework.MetroColorStyle.Silver
        Me.UserAcctDGV.TabIndex = 6
        Me.UserAcctDGV.UseStyleColors = True
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
        Me.NicknameTbox.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.NicknameTbox.Lines = New String(-1) {}
        Me.NicknameTbox.Location = New System.Drawing.Point(392, 47)
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
        'UserAccessCbox
        '
        Me.UserAccessCbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UserAccessCbox.FormattingEnabled = True
        Me.UserAccessCbox.ItemHeight = 23
        Me.UserAccessCbox.Location = New System.Drawing.Point(519, 43)
        Me.UserAccessCbox.Name = "UserAccessCbox"
        Me.UserAccessCbox.Size = New System.Drawing.Size(174, 29)
        Me.UserAccessCbox.Style = MetroFramework.MetroColorStyle.Blue
        Me.UserAccessCbox.TabIndex = 3
        Me.UserAccessCbox.UseCustomBackColor = True
        Me.UserAccessCbox.UseCustomForeColor = True
        Me.UserAccessCbox.UseSelectable = True
        Me.UserAccessCbox.UseStyleColors = True
        '
        'UpdateUserBtn
        '
        Me.UpdateUserBtn.ForeColor = System.Drawing.Color.Black
        Me.UpdateUserBtn.Image = Nothing
        Me.UpdateUserBtn.Location = New System.Drawing.Point(787, 43)
        Me.UpdateUserBtn.Name = "UpdateUserBtn"
        Me.UpdateUserBtn.Size = New System.Drawing.Size(55, 29)
        Me.UpdateUserBtn.TabIndex = 5
        Me.UpdateUserBtn.Text = "Updat&e"
        Me.UpdateUserBtn.UseCustomForeColor = True
        Me.UpdateUserBtn.UseSelectable = True
        Me.UpdateUserBtn.UseStyleColors = True
        Me.UpdateUserBtn.UseVisualStyleBackColor = True
        '
        'AddUserAccessBtn
        '
        Me.AddUserAccessBtn.Image = Nothing
        Me.AddUserAccessBtn.Location = New System.Drawing.Point(698, 43)
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
        Me.Controls.Add(Me.UserAccessCbox)
        Me.Controls.Add(Me.NicknameTbox)
        Me.Controls.Add(Me.UserAcctDGV)
        Me.Controls.Add(Me.AddUserBtn)
        Me.Controls.Add(Me.FullnameTbox)
        Me.Name = "ManageAccounts"
        Me.Resizable = False
        Me.Theme = MetroFramework.MetroThemeStyle.[Default]
        CType(Me.UserAcctDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FullnameTbox As MetroFramework.Controls.MetroTextBox
    Friend AddUserBtn As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents UserAcctDGV As MetroFramework.Controls.MetroGrid
    Friend WithEvents NicknameTbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents UserAccessCbox As MetroFramework.Controls.MetroComboBox
    Friend WithEvents UpdateUserBtn As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents AddUserAccessBtn As MetroFramework.Controls.MetroTextBox.MetroTextButton
End Class
