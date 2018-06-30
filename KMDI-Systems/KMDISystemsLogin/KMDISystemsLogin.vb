Public Class KMDISystemsLogin
    Dim KMDISystems_UserName As String
    Dim KMDISystems_Password As String

    Private Sub KMDISystemsLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectionTypeCbox.SelectedIndex = 0
        MaximizeBox = False
    End Sub

    Private Sub UserNameTbox_TextChanged(sender As Object, e As EventArgs) Handles UserNameTbox.TextChanged
        KMDISystems_UserName = UserNameTbox.Text
    End Sub

    Private Sub UserNameTbox_KeyDown(sender As Object, e As KeyEventArgs) Handles UserNameTbox.KeyDown
        If e.KeyCode = Keys.Enter Then
            UserNameTbox.Text = Trim(UserNameTbox.Text)
            If UserNameTbox.Text = Nothing Then
                MetroFramework.MetroMessageBox.Show(Me, "Please enter username", "", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Else
                KMDISystems_Login(KMDISystems_UserName,
                                  KMDISystems_Password)
            End If
        End If
    End Sub

    Private Sub PasswordTbox_TextChanged(sender As Object, e As EventArgs) Handles PasswordTbox.TextChanged
        KMDISystems_Password = PasswordTbox.Text
    End Sub

    Private Sub PasswordTbox_KeyDown(sender As Object, e As KeyEventArgs) Handles PasswordTbox.KeyDown
        If e.KeyCode = Keys.Enter Then
            PasswordTbox.Text = Trim(PasswordTbox.Text)
            If PasswordTbox.Text = Nothing Then
                MetroFramework.MetroMessageBox.Show(Me, "Please enter password", "", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Else
                KMDISystems_Login(KMDISystems_UserName,
                                  KMDISystems_Password)
            End If
        End If
    End Sub

    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        UserNameTbox.Text = Trim(UserNameTbox.Text)
        PasswordTbox.Text = Trim(PasswordTbox.Text)
        If UserNameTbox.Text = Nothing Then
            MetroFramework.MetroMessageBox.Show(Me, "Please enter username", "", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        ElseIf PasswordTbox.Text = Nothing Then
            MetroFramework.MetroMessageBox.Show(Me, "Please enter password", "", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        Else
            KMDISystems_Login(KMDISystems_UserName,
                              KMDISystems_Password)
        End If
    End Sub

    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Me.Close()
    End Sub

    Private Sub KMDISystemsLogin_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub

    Private Sub ConnectionTypeCbox_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ConnectionTypeCbox.SelectionChangeCommitted
        If ConnectionTypeCbox.SelectedIndex = 0 Then
        ElseIf ConnectionTypeCbox.SelectedIndex = 1 Then

        End If
    End Sub
End Class
