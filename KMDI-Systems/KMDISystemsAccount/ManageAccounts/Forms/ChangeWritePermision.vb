Public Class ChangeWritePermision
    Public AccessAutonum As Integer

    Private Sub ManageUserAccess_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KMDI_ACCT_ACCESS_TB_READ_FOR_ChangeWritePermision(ManageAccounts.UsersAutonum)
        MaximizeBox = False

        AcctTypeTbox.Text = ManageAccounts.UserAccessCbox.Text
        TileAccessCode.Focus()
        WriteCbox.SelectedIndex = 0
    End Sub

    Private Sub ManageUserAccess_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ManageAccounts.Enabled = True
        Me.Dispose()
    End Sub

    Private Sub UserAccessDGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles UserAccessDGV.CellClick
        If UserAccessDGV.RowCount >= 0 And e.RowIndex >= 0 Then

            Try

                AccessAutonum = UserAccessDGV.Item("Autonumber", e.RowIndex).Value.ToString
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If
    End Sub

End Class