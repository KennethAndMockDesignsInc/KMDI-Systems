﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KMDISystemsLogin
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
        Me.ConnectionTypeCbox = New MetroFramework.Controls.MetroComboBox()
        Me.PasswordTbox = New MetroFramework.Controls.MetroTextBox()
        Me.UserNameTbox = New MetroFramework.Controls.MetroTextBox()
        Me.PasswordLbl = New MetroFramework.Controls.MetroLabel()
        Me.UserNameLbl = New MetroFramework.Controls.MetroLabel()
        Me.ConnectionTypeLbl = New MetroFramework.Controls.MetroLabel()
        Me.SuspendLayout()
        '
        'ConnectionTypeCbox
        '
        Me.ConnectionTypeCbox.FontWeight = MetroFramework.MetroComboBoxWeight.Bold
        Me.ConnectionTypeCbox.FormattingEnabled = True
        Me.ConnectionTypeCbox.ItemHeight = 23
        Me.ConnectionTypeCbox.Items.AddRange(New Object() {"Local Access", "Remote Access"})
        Me.ConnectionTypeCbox.Location = New System.Drawing.Point(173, 40)
        Me.ConnectionTypeCbox.Name = "ConnectionTypeCbox"
        Me.ConnectionTypeCbox.Size = New System.Drawing.Size(184, 29)
        Me.ConnectionTypeCbox.TabIndex = 13
        Me.ConnectionTypeCbox.UseSelectable = True
        '
        'PasswordTbox
        '
        '
        '
        '
        Me.PasswordTbox.CustomButton.Image = Nothing
        Me.PasswordTbox.CustomButton.Location = New System.Drawing.Point(162, 1)
        Me.PasswordTbox.CustomButton.Name = ""
        Me.PasswordTbox.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.PasswordTbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.PasswordTbox.CustomButton.TabIndex = 1
        Me.PasswordTbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.PasswordTbox.CustomButton.UseSelectable = True
        Me.PasswordTbox.CustomButton.Visible = False
        Me.PasswordTbox.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.PasswordTbox.FontWeight = MetroFramework.MetroTextBoxWeight.Bold
        Me.PasswordTbox.Lines = New String(-1) {}
        Me.PasswordTbox.Location = New System.Drawing.Point(173, 126)
        Me.PasswordTbox.MaxLength = 32767
        Me.PasswordTbox.Name = "PasswordTbox"
        Me.PasswordTbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.PasswordTbox.SelectedText = ""
        Me.PasswordTbox.SelectionLength = 0
        Me.PasswordTbox.SelectionStart = 0
        Me.PasswordTbox.Size = New System.Drawing.Size(184, 23)
        Me.PasswordTbox.TabIndex = 12
        Me.PasswordTbox.UseSelectable = True
        Me.PasswordTbox.WaterMark = "Password"
        Me.PasswordTbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.PasswordTbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'UserNameTbox
        '
        '
        '
        '
        Me.UserNameTbox.CustomButton.Image = Nothing
        Me.UserNameTbox.CustomButton.Location = New System.Drawing.Point(162, 1)
        Me.UserNameTbox.CustomButton.Name = ""
        Me.UserNameTbox.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.UserNameTbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.UserNameTbox.CustomButton.TabIndex = 1
        Me.UserNameTbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.UserNameTbox.CustomButton.UseSelectable = True
        Me.UserNameTbox.CustomButton.Visible = False
        Me.UserNameTbox.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.UserNameTbox.FontWeight = MetroFramework.MetroTextBoxWeight.Bold
        Me.UserNameTbox.Lines = New String(-1) {}
        Me.UserNameTbox.Location = New System.Drawing.Point(173, 84)
        Me.UserNameTbox.MaxLength = 32767
        Me.UserNameTbox.Name = "UserNameTbox"
        Me.UserNameTbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UserNameTbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.UserNameTbox.SelectedText = ""
        Me.UserNameTbox.SelectionLength = 0
        Me.UserNameTbox.SelectionStart = 0
        Me.UserNameTbox.Size = New System.Drawing.Size(184, 23)
        Me.UserNameTbox.TabIndex = 11
        Me.UserNameTbox.UseSelectable = True
        Me.UserNameTbox.WaterMark = "User Name"
        Me.UserNameTbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.UserNameTbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'PasswordLbl
        '
        Me.PasswordLbl.AutoSize = True
        Me.PasswordLbl.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.PasswordLbl.Location = New System.Drawing.Point(25, 124)
        Me.PasswordLbl.Name = "PasswordLbl"
        Me.PasswordLbl.Size = New System.Drawing.Size(86, 25)
        Me.PasswordLbl.TabIndex = 10
        Me.PasswordLbl.Text = "Password:"
        '
        'UserNameLbl
        '
        Me.UserNameLbl.AutoSize = True
        Me.UserNameLbl.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.UserNameLbl.Location = New System.Drawing.Point(25, 84)
        Me.UserNameLbl.Name = "UserNameLbl"
        Me.UserNameLbl.Size = New System.Drawing.Size(101, 25)
        Me.UserNameLbl.TabIndex = 9
        Me.UserNameLbl.Text = "User Name:"
        '
        'ConnectionTypeLbl
        '
        Me.ConnectionTypeLbl.AutoSize = True
        Me.ConnectionTypeLbl.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.ConnectionTypeLbl.Location = New System.Drawing.Point(25, 44)
        Me.ConnectionTypeLbl.Name = "ConnectionTypeLbl"
        Me.ConnectionTypeLbl.Size = New System.Drawing.Size(142, 25)
        Me.ConnectionTypeLbl.TabIndex = 8
        Me.ConnectionTypeLbl.Text = "Connection Type:"
        '
        'KMDISystemsLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(393, 171)
        Me.Controls.Add(Me.ConnectionTypeCbox)
        Me.Controls.Add(Me.PasswordTbox)
        Me.Controls.Add(Me.UserNameTbox)
        Me.Controls.Add(Me.PasswordLbl)
        Me.Controls.Add(Me.UserNameLbl)
        Me.Controls.Add(Me.ConnectionTypeLbl)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Name = "KMDISystemsLogin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ConnectionTypeCbox As MetroFramework.Controls.MetroComboBox
    Friend WithEvents PasswordTbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents UserNameTbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents PasswordLbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents UserNameLbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents ConnectionTypeLbl As MetroFramework.Controls.MetroLabel
End Class
