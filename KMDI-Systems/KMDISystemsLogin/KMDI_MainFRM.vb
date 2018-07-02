Public Class KMDI_MainFRM
    Private Sub KMDI_MainFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub KMDI_MainFRM_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        KMDISystemsLogin.Show()
        Me.Dispose()
    End Sub
End Class