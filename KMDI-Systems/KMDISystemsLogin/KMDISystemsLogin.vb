Public Class KMDISystemsLogin
    Dim KMDISystems_UserName As String
    Dim KMDISystems_Password As String

    Private Sub KMDISystemsLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectionTypeCbox.SelectedIndex = 0
        MaximizeBox = False
    End Sub

    Private Sub PasswordTbox_KeyDown(sender As Object, e As KeyEventArgs) Handles PasswordTbox.KeyDown
        If e.KeyCode = Keys.Enter Then
            KMDISystems_Login(KMDISystems_UserName,
                              KMDISystems_Password)
        End If
    End Sub

    Private Sub UserNameTbox_TextChanged(sender As Object, e As EventArgs) Handles UserNameTbox.TextChanged
        KMDISystems_UserName = UserNameTbox.Text
    End Sub

    Private Sub PasswordTbox_TextChanged(sender As Object, e As EventArgs) Handles PasswordTbox.TextChanged
        KMDISystems_Password = PasswordTbox.Text
    End Sub
End Class
