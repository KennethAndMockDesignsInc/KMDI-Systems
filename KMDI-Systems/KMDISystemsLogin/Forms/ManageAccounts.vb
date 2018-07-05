Public Class ManageAccounts
    Public UsersAutonum As Integer
    Public userAccess As String

    Private Sub ManageAccounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KMDI_ACCT_TB_READ()
        UserAccessCbox_Popolate()
        MaximizeBox = False
    End Sub

    Private Sub UserAcctDGV_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles UserAcctDGV.RowPostPaint
        rowpostpaint(sender, e)
    End Sub

    Private Sub ManageAccounts_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
        KMDI_MainFRM.Enabled = True
    End Sub

    Private Sub UserAccessCbox_Enter(sender As Object, e As EventArgs) Handles UserAccessCbox.Enter
        UserAccessCbox_Popolate()
    End Sub

    Private Sub TilePermisionMenu_Click(sender As Object, e As EventArgs) Handles TilePermisionMenu.Click
        ChangeTilePermision.Show()
        Me.Enabled = False
    End Sub

    Private Sub UserAcctDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles UserAcctDGV.CellMouseClick
        If (e.RowIndex >= 0 And e.ColumnIndex >= 0 And e.Button = MouseButtons.Right) Then

            UserAcctDGV.Rows(e.RowIndex).Selected = True
            Dim r As New Rectangle
            r = UserAcctDGV.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, True)
            PermisionMenu.Show()

            PermisionMenu.Location = New Point(MousePosition.X, MousePosition.Y)

            If UserAcctDGV.RowCount >= 0 And e.RowIndex >= 0 Then

                Try
                    FullnameTbox.Text = UserAcctDGV.Item("FULLNAME", e.RowIndex).Value.ToString
                    NicknameTbox.Text = UserAcctDGV.Item("NICKNAME", e.RowIndex).Value.ToString
                    userAccess = UserAcctDGV.Item("ACCTTYPE", e.RowIndex).Value.ToString
                    UserAccessCbox.Text = UserAcctDGV.Item("ACCTTYPE", e.RowIndex).Value.ToString
                    UsersAutonum = UserAcctDGV.Item("AUTONUM", e.RowIndex).Value.ToString
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try

            End If

        End If

    End Sub

    Private Sub WritePermisionMenu_Click(sender As Object, e As EventArgs) Handles WritePermisionMenu.Click
        ChangeWritePermision.Show()
        Me.Enabled = False
    End Sub

End Class