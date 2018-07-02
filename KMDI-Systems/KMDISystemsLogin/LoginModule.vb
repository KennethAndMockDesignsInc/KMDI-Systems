Imports System.IO
Imports System.Text
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Security.Cryptography
Imports System.Windows.Forms.DataVisualization.Charting

Module LoginModule
    Dim AccessPoint As String = KMDISystemsLogin.KMDISystemsLogin_AccessPoint
    Dim DBName As String = "HERETOSAVE"
    Dim DBUserName As String = "kmdiadmin"
    Dim DBPassword As String = "kmdiadmin"
    Public sqlConnection As New SqlConnection With {.ConnectionString = "Data Source='" & AccessPoint & "';Network Library=DBMSSOCN;Initial Catalog='" & DBName & "';User ID='" & DBUserName & "';Password='" & DBPassword & "';"}
    Public sqlCommand As SqlCommand
    Public Read As SqlDataReader

    Public sqlDataAdapter As New SqlDataAdapter
    Public sqlDataSet As New DataSet
    Public sqlBindingSource As New BindingSource
    Public Query As String

    Public Sub KMDISystems_Login(ByVal UserName As String,
                                 ByVal Password As String)
        Try
            sqlConnection.Close()

            Try
                sqlConnection.Open()
            Catch ex As Exception
                MetroFramework.MetroMessageBox.Show(KMDISystemsLogin, "Error connecting to server. Please check your connection.", "", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Exit Sub
            End Try

            Query = "Select [ACCTTYPE]
                     From KMDI_ACCT_TB
                     Where [username] = @UserName AND [password] COLLATE Latin1_General_CS_AS = @Password"
            sqlCommand = New SqlCommand(Query, sqlConnection)
            sqlCommand.Parameters.AddWithValue("@UserName", UserName)
            sqlCommand.Parameters.AddWithValue("@Password", Encrypt(Password))
            Read = sqlCommand.ExecuteReader
            Read.Read()
            If Read.HasRows Then
                If Read("ACCTTYPE").ToString() = "Admin" Then
                    With KMDI_MainFRM
                        .Show()
                        .DBNameCbox.Items.Insert(0, "KMDIDATA")
                        .DBNameCbox.Items.Insert(1, "HAUSERDB")
                        .DbNameCbox.Items.Insert(2, "HERETOSAVE")
                        .DbNameCbox.SelectedIndex = 0
                    End With
                Else
                    With KMDI_MainFRM
                        .Show()
                        .DBNameCbox.Items.Insert(0, "KMDIDATA")
                        .DbNameCbox.Items.Insert(1, "HAUSERDB")
                        .DbNameCbox.SelectedIndex = 0
                    End With
                End If
                KMDISystemsLogin.Close()
            Else
                MetroFramework.MetroMessageBox.Show(KMDISystemsLogin, "Login failed! Please Try again", "", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Public Function Encrypt(clearText As String) As String

        Dim EncryptionKey As String = "MAKV2SPBNI99212"

        Dim clearBytes As Byte() = Encoding.Unicode.GetBytes(clearText)

        Using encryptor As Aes = Aes.Create()

            Dim pdb As New Rfc2898DeriveBytes(EncryptionKey, New Byte() {&H49, &H76, &H61, &H6E, &H20, &H4D, &H65, &H64, &H76, &H65, &H64, &H65, &H76})

            encryptor.Key = pdb.GetBytes(32)

            encryptor.IV = pdb.GetBytes(16)

            Using ms As New MemoryStream()

                Using cs As New CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write)

                    cs.Write(clearBytes, 0, clearBytes.Length)

                    cs.Close()

                End Using

                clearText = Convert.ToBase64String(ms.ToArray())

            End Using

        End Using

        Return clearText

    End Function

    Public Sub KMDI_ACCT_TB_READ()
        Try
            sqlConnection.Close()
            sqlConnection.Open()

            sqlDataSet.Clear()
            Query = "SELECT [AUTONUM],
                            [FULLNAME],
                            [NICKNAME],
                            [ACCTTYPE]
                     FROM [KMDI_ACCT_TB]"
            sqlCommand = New SqlCommand(Query, sqlConnection)
            sqlDataAdapter.SelectCommand = sqlCommand
            sqlDataAdapter.Fill(sqlDataSet, "KMDI_ACCT_TB")
            sqlBindingSource.DataSource = sqlDataSet
            sqlBindingSource.DataMember = "KMDI_ACCT_TB"
            ManageAccounts.UserAcctDGV.DataSource = sqlBindingSource

            With ManageAccounts.UserAcctDGV
                .DefaultCellStyle.BackColor = Color.White
                .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
            End With

            ManageAccounts.UserAcctDGV.Columns("AUTONUM").Visible = False

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Public Sub rowpostpaint(ByVal sender As Object, ByVal e As DataGridViewRowPostPaintEventArgs)
        Dim grid As DataGridView = DirectCast(sender, DataGridView)
        e.PaintHeader(DataGridViewPaintParts.Background)
        Dim rowIdx As String = (e.RowIndex + 1).ToString()
        Dim rowFont As New System.Drawing.Font("Microsoft Sans Serif", 8.0!,
            System.Drawing.FontStyle.Regular,
            System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        Dim centerFormat = New StringFormat()
        centerFormat.Alignment = StringAlignment.Far
        centerFormat.LineAlignment = StringAlignment.Near

        Dim headerBounds As Rectangle = New Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height)

        e.Graphics.DrawString(rowIdx, rowFont, SystemBrushes.ControlText, headerBounds, centerFormat)
    End Sub
End Module
