Public Class KMDI_MainFRM

    Private Sub KMDI_MainFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MngeAccTile_Click(sender As Object, e As EventArgs) Handles MngeAccTile.Click
        ManageAccounts.Show()
        Me.Enabled = False
    End Sub

    Private Sub LogoutTile_Click(sender As Object, e As EventArgs) Handles LogoutTile.Click
        If MetroFramework.MetroMessageBox.Show(Me, "Are you sure you want to Logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                               MessageBoxDefaultButton.Button1) = DialogResult.Yes Then

            Me.Close()
        Else

        End If
    End Sub

    Private Sub KMDI_MainFRM_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        KMDISystemsLogin.Show()
        Me.Dispose()
    End Sub

    Private Sub WinDoorMakerTile_Click(sender As Object, e As EventArgs) Handles WinDoorMakerTile.Click
        WinDoorMaker.Show()
    End Sub
End Class