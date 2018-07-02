Public Class ManageUserAccess
    Private Sub ManageUserAccess_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KMDI_ACCT_ACCESS_TB_READ()
        MaximizeBox = False
    End Sub

    Private Sub ManageUserAccess_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ManageAccounts.Enabled = True
        Me.Dispose()
    End Sub
End Class