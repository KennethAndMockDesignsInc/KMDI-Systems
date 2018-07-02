<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ManageUserAccess
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
        Me.UserAccessDGV = New MetroFramework.Controls.MetroGrid()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.AccessCodeTbox = New MetroFramework.Controls.MetroTextBox()
        Me.UserAccessTbox = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.UpdateAccessBtn = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.AddAccessBtn = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.DelAccessBtn = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        CType(Me.UserAccessDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UserAccessDGV
        '
        Me.UserAccessDGV.AllowUserToAddRows = False
        Me.UserAccessDGV.AllowUserToDeleteRows = False
        Me.UserAccessDGV.AllowUserToOrderColumns = True
        Me.UserAccessDGV.AllowUserToResizeRows = False
        Me.UserAccessDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.UserAccessDGV.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UserAccessDGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.UserAccessDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.UserAccessDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.UserAccessDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.UserAccessDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.UserAccessDGV.DefaultCellStyle = DataGridViewCellStyle5
        Me.UserAccessDGV.Dock = System.Windows.Forms.DockStyle.Right
        Me.UserAccessDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.UserAccessDGV.EnableHeadersVisualStyles = False
        Me.UserAccessDGV.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.UserAccessDGV.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UserAccessDGV.Location = New System.Drawing.Point(251, 60)
        Me.UserAccessDGV.MultiSelect = False
        Me.UserAccessDGV.Name = "UserAccessDGV"
        Me.UserAccessDGV.ReadOnly = True
        Me.UserAccessDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.UserAccessDGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.UserAccessDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.UserAccessDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.UserAccessDGV.Size = New System.Drawing.Size(329, 134)
        Me.UserAccessDGV.Style = MetroFramework.MetroColorStyle.Silver
        Me.UserAccessDGV.TabIndex = 7
        Me.UserAccessDGV.UseStyleColors = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(9, 65)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(86, 19)
        Me.MetroLabel1.TabIndex = 8
        Me.MetroLabel1.Text = "Access Code:"
        '
        'AccessCodeTbox
        '
        '
        '
        '
        Me.AccessCodeTbox.CustomButton.Image = Nothing
        Me.AccessCodeTbox.CustomButton.Location = New System.Drawing.Point(122, 1)
        Me.AccessCodeTbox.CustomButton.Name = ""
        Me.AccessCodeTbox.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.AccessCodeTbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.AccessCodeTbox.CustomButton.TabIndex = 1
        Me.AccessCodeTbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.AccessCodeTbox.CustomButton.UseSelectable = True
        Me.AccessCodeTbox.CustomButton.Visible = False
        Me.AccessCodeTbox.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.AccessCodeTbox.ForeColor = System.Drawing.Color.Black
        Me.AccessCodeTbox.Lines = New String(-1) {}
        Me.AccessCodeTbox.Location = New System.Drawing.Point(101, 63)
        Me.AccessCodeTbox.MaxLength = 32767
        Me.AccessCodeTbox.Name = "AccessCodeTbox"
        Me.AccessCodeTbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.AccessCodeTbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.AccessCodeTbox.SelectedText = ""
        Me.AccessCodeTbox.SelectionLength = 0
        Me.AccessCodeTbox.SelectionStart = 0
        Me.AccessCodeTbox.Size = New System.Drawing.Size(144, 23)
        Me.AccessCodeTbox.Style = MetroFramework.MetroColorStyle.Blue
        Me.AccessCodeTbox.TabIndex = 1
        Me.AccessCodeTbox.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.AccessCodeTbox.UseCustomBackColor = True
        Me.AccessCodeTbox.UseCustomForeColor = True
        Me.AccessCodeTbox.UseSelectable = True
        Me.AccessCodeTbox.UseStyleColors = True
        Me.AccessCodeTbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.AccessCodeTbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'UserAccessTbox
        '
        '
        '
        '
        Me.UserAccessTbox.CustomButton.Image = Nothing
        Me.UserAccessTbox.CustomButton.Location = New System.Drawing.Point(122, 1)
        Me.UserAccessTbox.CustomButton.Name = ""
        Me.UserAccessTbox.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.UserAccessTbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.UserAccessTbox.CustomButton.TabIndex = 1
        Me.UserAccessTbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.UserAccessTbox.CustomButton.UseSelectable = True
        Me.UserAccessTbox.CustomButton.Visible = False
        Me.UserAccessTbox.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.UserAccessTbox.ForeColor = System.Drawing.Color.Black
        Me.UserAccessTbox.Lines = New String(-1) {}
        Me.UserAccessTbox.Location = New System.Drawing.Point(101, 112)
        Me.UserAccessTbox.MaxLength = 32767
        Me.UserAccessTbox.Name = "UserAccessTbox"
        Me.UserAccessTbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UserAccessTbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.UserAccessTbox.SelectedText = ""
        Me.UserAccessTbox.SelectionLength = 0
        Me.UserAccessTbox.SelectionStart = 0
        Me.UserAccessTbox.Size = New System.Drawing.Size(144, 23)
        Me.UserAccessTbox.Style = MetroFramework.MetroColorStyle.Blue
        Me.UserAccessTbox.TabIndex = 2
        Me.UserAccessTbox.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.UserAccessTbox.UseCustomBackColor = True
        Me.UserAccessTbox.UseCustomForeColor = True
        Me.UserAccessTbox.UseSelectable = True
        Me.UserAccessTbox.UseStyleColors = True
        Me.UserAccessTbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.UserAccessTbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(9, 114)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(80, 19)
        Me.MetroLabel2.TabIndex = 10
        Me.MetroLabel2.Text = "User Access:"
        '
        'UpdateAccessBtn
        '
        Me.UpdateAccessBtn.ForeColor = System.Drawing.Color.Black
        Me.UpdateAccessBtn.Image = Nothing
        Me.UpdateAccessBtn.Location = New System.Drawing.Point(98, 157)
        Me.UpdateAccessBtn.Name = "UpdateAccessBtn"
        Me.UpdateAccessBtn.Size = New System.Drawing.Size(55, 29)
        Me.UpdateAccessBtn.TabIndex = 13
        Me.UpdateAccessBtn.Text = "Updat&e"
        Me.UpdateAccessBtn.UseCustomForeColor = True
        Me.UpdateAccessBtn.UseSelectable = True
        Me.UpdateAccessBtn.UseStyleColors = True
        Me.UpdateAccessBtn.UseVisualStyleBackColor = True
        '
        'AddAccessBtn
        '
        Me.AddAccessBtn.BackColor = System.Drawing.Color.Black
        Me.AddAccessBtn.ForeColor = System.Drawing.Color.Black
        Me.AddAccessBtn.Image = Nothing
        Me.AddAccessBtn.Location = New System.Drawing.Point(40, 157)
        Me.AddAccessBtn.Name = "AddAccessBtn"
        Me.AddAccessBtn.Size = New System.Drawing.Size(55, 29)
        Me.AddAccessBtn.Style = MetroFramework.MetroColorStyle.Teal
        Me.AddAccessBtn.TabIndex = 12
        Me.AddAccessBtn.Text = "&Add"
        Me.AddAccessBtn.UseCustomBackColor = True
        Me.AddAccessBtn.UseCustomForeColor = True
        Me.AddAccessBtn.UseSelectable = True
        Me.AddAccessBtn.UseStyleColors = True
        Me.AddAccessBtn.UseVisualStyleBackColor = False
        '
        'DelAccessBtn
        '
        Me.DelAccessBtn.ForeColor = System.Drawing.Color.Black
        Me.DelAccessBtn.Image = Nothing
        Me.DelAccessBtn.Location = New System.Drawing.Point(159, 157)
        Me.DelAccessBtn.Name = "DelAccessBtn"
        Me.DelAccessBtn.Size = New System.Drawing.Size(55, 29)
        Me.DelAccessBtn.TabIndex = 14
        Me.DelAccessBtn.Text = "&Delete"
        Me.DelAccessBtn.UseCustomForeColor = True
        Me.DelAccessBtn.UseSelectable = True
        Me.DelAccessBtn.UseStyleColors = True
        Me.DelAccessBtn.UseVisualStyleBackColor = True
        '
        'ManageUserAccess
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 214)
        Me.Controls.Add(Me.DelAccessBtn)
        Me.Controls.Add(Me.UpdateAccessBtn)
        Me.Controls.Add(Me.AddAccessBtn)
        Me.Controls.Add(Me.UserAccessTbox)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.AccessCodeTbox)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.UserAccessDGV)
        Me.Name = "ManageUserAccess"
        Me.Resizable = False
        CType(Me.UserAccessDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UserAccessDGV As MetroFramework.Controls.MetroGrid
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents AccessCodeTbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents UserAccessTbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend UpdateAccessBtn As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend AddAccessBtn As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend DelAccessBtn As MetroFramework.Controls.MetroTextBox.MetroTextButton
End Class
