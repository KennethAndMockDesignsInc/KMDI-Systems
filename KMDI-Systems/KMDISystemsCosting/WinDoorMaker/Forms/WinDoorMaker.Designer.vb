<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WinDoorMaker
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
        Me.WinDoorMakerMainPNL = New MetroFramework.Controls.MetroPanel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.WinDoorMakerMainPNL.SuspendLayout()
        Me.SuspendLayout()
        '
        'WinDoorMakerMainPNL
        '
        Me.WinDoorMakerMainPNL.AutoScroll = True
        Me.WinDoorMakerMainPNL.Controls.Add(Me.FlowLayoutPanel2)
        Me.WinDoorMakerMainPNL.Controls.Add(Me.FlowLayoutPanel1)
        Me.WinDoorMakerMainPNL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WinDoorMakerMainPNL.HorizontalScrollbar = True
        Me.WinDoorMakerMainPNL.HorizontalScrollbarBarColor = True
        Me.WinDoorMakerMainPNL.HorizontalScrollbarHighlightOnWheel = False
        Me.WinDoorMakerMainPNL.HorizontalScrollbarSize = 10
        Me.WinDoorMakerMainPNL.Location = New System.Drawing.Point(20, 60)
        Me.WinDoorMakerMainPNL.Name = "WinDoorMakerMainPNL"
        Me.WinDoorMakerMainPNL.Size = New System.Drawing.Size(839, 345)
        Me.WinDoorMakerMainPNL.TabIndex = 0
        Me.WinDoorMakerMainPNL.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.WinDoorMakerMainPNL.VerticalScrollbar = True
        Me.WinDoorMakerMainPNL.VerticalScrollbarBarColor = True
        Me.WinDoorMakerMainPNL.VerticalScrollbarHighlightOnWheel = False
        Me.WinDoorMakerMainPNL.VerticalScrollbarSize = 10
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(839, 44)
        Me.FlowLayoutPanel1.TabIndex = 2
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 44)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(200, 301)
        Me.FlowLayoutPanel2.TabIndex = 3
        '
        'WinDoorMaker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(879, 425)
        Me.Controls.Add(Me.WinDoorMakerMainPNL)
        Me.Name = "WinDoorMaker"
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.WinDoorMakerMainPNL.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents WinDoorMakerMainPNL As MetroFramework.Controls.MetroPanel
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
End Class
