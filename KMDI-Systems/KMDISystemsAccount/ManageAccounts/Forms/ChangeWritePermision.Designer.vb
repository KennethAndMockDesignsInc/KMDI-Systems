﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ChangeWritePermision
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChangeWritePermision))
        Me.UserAccessDGV = New MetroFramework.Controls.MetroGrid()
        Me.SearchAccessTbox = New MetroFramework.Controls.MetroTextBox()
        Me.AcctTypeTbox = New MetroFramework.Controls.MetroTextBox()
        Me.TileAccessCode = New MetroFramework.Controls.MetroTextBox()
        Me.UpdateWriteCode = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.WriteCbox = New MetroFramework.Controls.MetroComboBox()
        CType(Me.UserAccessDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UserAccessDGV
        '
        Me.UserAccessDGV.AllowUserToAddRows = False
        Me.UserAccessDGV.AllowUserToDeleteRows = False
        Me.UserAccessDGV.AllowUserToOrderColumns = True
        Me.UserAccessDGV.AllowUserToResizeRows = False
        Me.UserAccessDGV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UserAccessDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.UserAccessDGV.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UserAccessDGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.UserAccessDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.UserAccessDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.UserAccessDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.UserAccessDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.UserAccessDGV.DefaultCellStyle = DataGridViewCellStyle2
        Me.UserAccessDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.UserAccessDGV.EnableHeadersVisualStyles = False
        Me.UserAccessDGV.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.UserAccessDGV.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UserAccessDGV.Location = New System.Drawing.Point(155, 60)
        Me.UserAccessDGV.MultiSelect = False
        Me.UserAccessDGV.Name = "UserAccessDGV"
        Me.UserAccessDGV.ReadOnly = True
        Me.UserAccessDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.UserAccessDGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.UserAccessDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.UserAccessDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.UserAccessDGV.Size = New System.Drawing.Size(570, 156)
        Me.UserAccessDGV.Style = MetroFramework.MetroColorStyle.Silver
        Me.UserAccessDGV.TabIndex = 7
        Me.UserAccessDGV.UseStyleColors = True
        '
        'SearchAccessTbox
        '
        '
        '
        '
        Me.SearchAccessTbox.CustomButton.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.SearchAccessTbox.CustomButton.Location = New System.Drawing.Point(679, 1)
        Me.SearchAccessTbox.CustomButton.Name = ""
        Me.SearchAccessTbox.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.SearchAccessTbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.SearchAccessTbox.CustomButton.TabIndex = 1
        Me.SearchAccessTbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.SearchAccessTbox.CustomButton.UseSelectable = True
        Me.SearchAccessTbox.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.SearchAccessTbox.ForeColor = System.Drawing.Color.Black
        Me.SearchAccessTbox.Lines = New String(-1) {}
        Me.SearchAccessTbox.Location = New System.Drawing.Point(20, 27)
        Me.SearchAccessTbox.MaxLength = 32767
        Me.SearchAccessTbox.Name = "SearchAccessTbox"
        Me.SearchAccessTbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.SearchAccessTbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.SearchAccessTbox.SelectedText = ""
        Me.SearchAccessTbox.SelectionLength = 0
        Me.SearchAccessTbox.SelectionStart = 0
        Me.SearchAccessTbox.ShowButton = True
        Me.SearchAccessTbox.ShowClearButton = True
        Me.SearchAccessTbox.Size = New System.Drawing.Size(705, 27)
        Me.SearchAccessTbox.Style = MetroFramework.MetroColorStyle.Blue
        Me.SearchAccessTbox.TabIndex = 8
        Me.SearchAccessTbox.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.SearchAccessTbox.UseCustomBackColor = True
        Me.SearchAccessTbox.UseCustomForeColor = True
        Me.SearchAccessTbox.UseSelectable = True
        Me.SearchAccessTbox.UseStyleColors = True
        Me.SearchAccessTbox.WaterMark = "Search"
        Me.SearchAccessTbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.SearchAccessTbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic)
        '
        'AcctTypeTbox
        '
        '
        '
        '
        Me.AcctTypeTbox.CustomButton.Image = Nothing
        Me.AcctTypeTbox.CustomButton.Location = New System.Drawing.Point(107, 1)
        Me.AcctTypeTbox.CustomButton.Name = ""
        Me.AcctTypeTbox.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.AcctTypeTbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.AcctTypeTbox.CustomButton.TabIndex = 1
        Me.AcctTypeTbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.AcctTypeTbox.CustomButton.UseSelectable = True
        Me.AcctTypeTbox.CustomButton.Visible = False
        Me.AcctTypeTbox.Enabled = False
        Me.AcctTypeTbox.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.AcctTypeTbox.Lines = New String(-1) {}
        Me.AcctTypeTbox.Location = New System.Drawing.Point(20, 63)
        Me.AcctTypeTbox.MaxLength = 32767
        Me.AcctTypeTbox.Name = "AcctTypeTbox"
        Me.AcctTypeTbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.AcctTypeTbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.AcctTypeTbox.SelectedText = ""
        Me.AcctTypeTbox.SelectionLength = 0
        Me.AcctTypeTbox.SelectionStart = 0
        Me.AcctTypeTbox.Size = New System.Drawing.Size(129, 23)
        Me.AcctTypeTbox.Style = MetroFramework.MetroColorStyle.Blue
        Me.AcctTypeTbox.TabIndex = 9
        Me.AcctTypeTbox.UseCustomBackColor = True
        Me.AcctTypeTbox.UseCustomForeColor = True
        Me.AcctTypeTbox.UseSelectable = True
        Me.AcctTypeTbox.UseStyleColors = True
        Me.AcctTypeTbox.WaterMark = "Account Type"
        Me.AcctTypeTbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.AcctTypeTbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'TileAccessCode
        '
        '
        '
        '
        Me.TileAccessCode.CustomButton.Image = Nothing
        Me.TileAccessCode.CustomButton.Location = New System.Drawing.Point(107, 1)
        Me.TileAccessCode.CustomButton.Name = ""
        Me.TileAccessCode.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.TileAccessCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.TileAccessCode.CustomButton.TabIndex = 1
        Me.TileAccessCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.TileAccessCode.CustomButton.UseSelectable = True
        Me.TileAccessCode.CustomButton.Visible = False
        Me.TileAccessCode.Enabled = False
        Me.TileAccessCode.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.TileAccessCode.Lines = New String(-1) {}
        Me.TileAccessCode.Location = New System.Drawing.Point(20, 92)
        Me.TileAccessCode.MaxLength = 32767
        Me.TileAccessCode.Name = "TileAccessCode"
        Me.TileAccessCode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TileAccessCode.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TileAccessCode.SelectedText = ""
        Me.TileAccessCode.SelectionLength = 0
        Me.TileAccessCode.SelectionStart = 0
        Me.TileAccessCode.Size = New System.Drawing.Size(129, 23)
        Me.TileAccessCode.Style = MetroFramework.MetroColorStyle.Blue
        Me.TileAccessCode.TabIndex = 10
        Me.TileAccessCode.UseCustomBackColor = True
        Me.TileAccessCode.UseCustomForeColor = True
        Me.TileAccessCode.UseSelectable = True
        Me.TileAccessCode.UseStyleColors = True
        Me.TileAccessCode.WaterMark = "Tile Access"
        Me.TileAccessCode.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.TileAccessCode.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'UpdateWriteCode
        '
        Me.UpdateWriteCode.Image = Nothing
        Me.UpdateWriteCode.Location = New System.Drawing.Point(20, 156)
        Me.UpdateWriteCode.Name = "UpdateWriteCode"
        Me.UpdateWriteCode.Size = New System.Drawing.Size(129, 57)
        Me.UpdateWriteCode.TabIndex = 11
        Me.UpdateWriteCode.Text = "&Save"
        Me.UpdateWriteCode.UseSelectable = True
        Me.UpdateWriteCode.UseVisualStyleBackColor = True
        '
        'WriteCbox
        '
        Me.WriteCbox.FormattingEnabled = True
        Me.WriteCbox.ItemHeight = 23
        Me.WriteCbox.Items.AddRange(New Object() {"0", "1"})
        Me.WriteCbox.Location = New System.Drawing.Point(20, 121)
        Me.WriteCbox.Name = "WriteCbox"
        Me.WriteCbox.Size = New System.Drawing.Size(129, 29)
        Me.WriteCbox.TabIndex = 13
        Me.WriteCbox.UseSelectable = True
        '
        'ChangeWritePermision
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(745, 226)
        Me.Controls.Add(Me.WriteCbox)
        Me.Controls.Add(Me.UpdateWriteCode)
        Me.Controls.Add(Me.TileAccessCode)
        Me.Controls.Add(Me.AcctTypeTbox)
        Me.Controls.Add(Me.SearchAccessTbox)
        Me.Controls.Add(Me.UserAccessDGV)
        Me.Name = "ChangeWritePermision"
        Me.Resizable = False
        CType(Me.UserAccessDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UserAccessDGV As MetroFramework.Controls.MetroGrid
    Friend WithEvents SearchAccessTbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents AcctTypeTbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents TileAccessCode As MetroFramework.Controls.MetroTextBox
    Friend UpdateWriteCode As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents WriteCbox As MetroFramework.Controls.MetroComboBox
End Class
