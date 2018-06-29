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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MetroStyleManager1 = New MetroFramework.Components.MetroStyleManager(Me.components)
        Me.MetroStyleExtender1 = New MetroFramework.Components.MetroStyleExtender(Me.components)
        Me.FullnameTbox = New MetroFramework.Controls.MetroTextBox()
        Me.MetroGrid1 = New MetroFramework.Controls.MetroGrid()
        Me.NicknameTbox = New MetroFramework.Controls.MetroTextBox()
        Me.MetroComboBox1 = New MetroFramework.Controls.MetroComboBox()
        Me.MetroTextButton1 = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroStyleManager1
        '
        Me.MetroStyleManager1.Owner = Me
        Me.MetroStyleManager1.Style = MetroFramework.MetroColorStyle.Green
        '
        'MetroStyleExtender1
        '
        Me.MetroStyleExtender1.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'FullnameTbox
        '
        '
        '
        '
        Me.FullnameTbox.CustomButton.Image = Nothing
        Me.FullnameTbox.CustomButton.Location = New System.Drawing.Point(253, 1)
        Me.FullnameTbox.CustomButton.Name = ""
        Me.FullnameTbox.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.FullnameTbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.FullnameTbox.CustomButton.TabIndex = 1
        Me.FullnameTbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.FullnameTbox.CustomButton.UseSelectable = True
        Me.FullnameTbox.CustomButton.Visible = False
        Me.FullnameTbox.Lines = New String(-1) {}
        Me.FullnameTbox.Location = New System.Drawing.Point(23, 23)
        Me.FullnameTbox.MaxLength = 32767
        Me.FullnameTbox.Name = "FullnameTbox"
        Me.FullnameTbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.FullnameTbox.PromptText = "Fullname"
        Me.FullnameTbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.FullnameTbox.SelectedText = ""
        Me.FullnameTbox.SelectionLength = 0
        Me.FullnameTbox.SelectionStart = 0
        Me.FullnameTbox.ShortcutsEnabled = True
        Me.FullnameTbox.ShowClearButton = True
        Me.FullnameTbox.Size = New System.Drawing.Size(279, 27)
        Me.FullnameTbox.Style = MetroFramework.MetroColorStyle.Teal
        Me.FullnameTbox.TabIndex = 0
        Me.FullnameTbox.UseCustomForeColor = True
        Me.FullnameTbox.UseSelectable = True
        Me.FullnameTbox.WaterMark = "Fullname"
        Me.FullnameTbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FullnameTbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
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
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(89, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(104, Byte), Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.MetroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(104, Byte), Integer))
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MetroGrid1.DefaultCellStyle = DataGridViewCellStyle11
        Me.MetroGrid1.EnableHeadersVisualStyles = False
        Me.MetroGrid1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MetroGrid1.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroGrid1.Location = New System.Drawing.Point(8, 58)
        Me.MetroGrid1.Name = "MetroGrid1"
        Me.MetroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(89, Byte), Integer))
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(104, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid1.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.MetroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.MetroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MetroGrid1.Size = New System.Drawing.Size(767, 234)
        Me.MetroGrid1.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroGrid1.TabIndex = 1
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
        Me.NicknameTbox.CustomButton.Location = New System.Drawing.Point(150, 1)
        Me.NicknameTbox.CustomButton.Name = ""
        Me.NicknameTbox.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.NicknameTbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.NicknameTbox.CustomButton.TabIndex = 1
        Me.NicknameTbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.NicknameTbox.CustomButton.UseSelectable = True
        Me.NicknameTbox.CustomButton.Visible = False
        Me.NicknameTbox.Lines = New String(-1) {}
        Me.NicknameTbox.Location = New System.Drawing.Point(308, 23)
        Me.NicknameTbox.MaxLength = 32767
        Me.NicknameTbox.Name = "NicknameTbox"
        Me.NicknameTbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.NicknameTbox.PromptText = "Nickname"
        Me.NicknameTbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.NicknameTbox.SelectedText = ""
        Me.NicknameTbox.SelectionLength = 0
        Me.NicknameTbox.SelectionStart = 0
        Me.NicknameTbox.ShortcutsEnabled = True
        Me.NicknameTbox.ShowClearButton = True
        Me.NicknameTbox.Size = New System.Drawing.Size(176, 27)
        Me.NicknameTbox.Style = MetroFramework.MetroColorStyle.Teal
        Me.NicknameTbox.TabIndex = 2
        Me.NicknameTbox.UseCustomForeColor = True
        Me.NicknameTbox.UseSelectable = True
        Me.NicknameTbox.WaterMark = "Nickname"
        Me.NicknameTbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.NicknameTbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroComboBox1
        '
        Me.MetroComboBox1.FormattingEnabled = True
        Me.MetroComboBox1.ItemHeight = 23
        Me.MetroComboBox1.Location = New System.Drawing.Point(490, 23)
        Me.MetroComboBox1.Name = "MetroComboBox1"
        Me.MetroComboBox1.Size = New System.Drawing.Size(121, 29)
        Me.MetroComboBox1.TabIndex = 3
        Me.MetroComboBox1.UseSelectable = True
        '
        'MetroTextButton1
        '
        Me.MetroTextButton1.Image = Nothing
        Me.MetroTextButton1.Location = New System.Drawing.Point(617, 27)
        Me.MetroTextButton1.Name = "MetroTextButton1"
        Me.MetroTextButton1.Size = New System.Drawing.Size(121, 23)
        Me.MetroTextButton1.TabIndex = 4
        Me.MetroTextButton1.Text = "MetroTextButton1"
        Me.MetroTextButton1.UseSelectable = True
        Me.MetroTextButton1.UseVisualStyleBackColor = True
        '
        'ManageAccounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(783, 300)
        Me.Controls.Add(Me.MetroTextButton1)
        Me.Controls.Add(Me.MetroComboBox1)
        Me.Controls.Add(Me.NicknameTbox)
        Me.Controls.Add(Me.MetroGrid1)
        Me.Controls.Add(Me.FullnameTbox)
        Me.Name = "ManageAccounts"
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Public WithEvents MetroStyleManager1 As MetroFramework.Components.MetroStyleManager
    Friend WithEvents MetroGrid1 As MetroFramework.Controls.MetroGrid
    Friend WithEvents FullnameTbox As MetroFramework.Controls.MetroTextBox
    Public WithEvents MetroStyleExtender1 As MetroFramework.Components.MetroStyleExtender
    Friend WithEvents MetroComboBox1 As MetroFramework.Controls.MetroComboBox
    Friend WithEvents NicknameTbox As MetroFramework.Controls.MetroTextBox
    Friend MetroTextButton1 As MetroFramework.Controls.MetroTextBox.MetroTextButton
End Class
