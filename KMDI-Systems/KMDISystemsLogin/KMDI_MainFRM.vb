Public Class KMDI_MainFRM
    Public Sub formclosed()
        KMDISystemsLogin.Show()
        Me.Dispose()
    End Sub

    Private Sub KMDI_MainFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub KMDI_MainFRM_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        formclosed()
    End Sub

    Private Sub MngeAccTile_Click(sender As Object, e As EventArgs) Handles MngeAccTile.Click
        ManageAccounts.Show()
        Me.Enabled = False
    End Sub

    Private Sub LogoutTile_Click(sender As Object, e As EventArgs) Handles LogoutTile.Click
        formclosed()
    End Sub
End Class