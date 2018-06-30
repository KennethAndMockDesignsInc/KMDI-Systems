Public Class ManageAccounts
    Private Sub ManageAccounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KMDI_ACCT_TB_READ()
        MaximizeBox = False
    End Sub

    Private Sub UpdateUserBtn_Click(sender As Object, e As EventArgs) Handles UpdateUserBtn.Click

    End Sub

    Private Sub UserAcctDGV_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles UserAcctDGV.RowPostPaint
        rowpostpaint(sender, e)
    End Sub

    Private Sub UserAcctDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles UserAcctDGV.CellContentClick

    End Sub
End Class