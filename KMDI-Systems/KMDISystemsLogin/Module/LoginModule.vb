Imports System.IO
Imports System.Text
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Security.Cryptography
Imports System.Windows.Forms.DataVisualization.Charting

Module LoginModule
    Public AccountType As String

    Dim AccessPoint As String = KMDISystemsLogin.KMDISystemsLogin_AccessPoint
    Dim DBName As String = "HERETOSAVE"
    Dim DBUserName As String = "kmdiadmin"
    Dim DBPassword As String = "kmdiadmin"
    Public sqlConnection As New SqlConnection With {.ConnectionString = "Data Source='" & AccessPoint & "';Network Library=DBMSSOCN;Initial Catalog='" & DBName & "';User ID='" & DBUserName & "';Password='" & DBPassword & "';"}
    Public sqlCommand As SqlCommand
    Public Read As SqlDataReader

    Public sqlDataAdapter As SqlDataAdapter
    Public sqlDataSet As DataSet
    Public sqlBindingSource As BindingSource
    Public Query As String

    Dim confirmQuery As Integer


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
                AccountType = Read.Item("ACCTTYPE").ToString
                If Read("ACCTTYPE").ToString() = "Admin" Then
                    With KMDI_MainFRM
                        .Show()
                        .DbNameCbox.Items.Insert(0, "KMDIDATA")
                        .DbNameCbox.Items.Insert(1, "HAUSERDB")
                        .DbNameCbox.Items.Insert(2, "HERETOSAVE")
                        .DbNameCbox.SelectedIndex = 0
                    End With
                Else
                    With KMDI_MainFRM
                        .Show()
                        .DbNameCbox.Items.Insert(0, "KMDIDATA")
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
        Dim sqlDataAdapter As New SqlDataAdapter
        Dim sqlDataSet As New DataSet
        Dim sqlBindingSource As New BindingSource


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

    Public Sub KMDI_ACCT_ACCESS_TB_READ_FOR_ChangeWritePermision(ByVal UserAcctAutonum As String)
        Try
            Dim sqlDataAdapter As New SqlDataAdapter
            Dim sqlDataSet As New DataSet
            Dim sqlBindingSource As New BindingSource

            sqlConnection.Close()
            sqlConnection.Open()

            sqlDataSet.Clear()
            Query = "SELECT [Autonumber]
                           ,[ACCTYPE] as [Account Type]
                           ,[TileAccess] as [Tile]
                           ,[Write] as [Write]
                           ,[UserAcctAutonum] as [User ID]
                     FROM [KMDI_ACCT_ACCESS_TB]
                     WHERE [UserAcctAutonum] = @UserAcctAutonum"
            sqlCommand = New SqlCommand(Query, sqlConnection)
            sqlCommand.Parameters.AddWithValue("@UserAcctAutonum", UserAcctAutonum)

            sqlDataAdapter.SelectCommand = sqlCommand
            sqlDataAdapter.Fill(sqlDataSet, "KMDI_ACCT_ACCESS_TB")
            sqlBindingSource.DataSource = sqlDataSet
            sqlBindingSource.DataMember = "KMDI_ACCT_ACCESS_TB"
            ChangeWritePermision.UserAccessDGV.DataSource = sqlBindingSource

            With ChangeWritePermision.UserAccessDGV
                .DefaultCellStyle.BackColor = Color.White
                .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
            End With

            ChangeWritePermision.UserAccessDGV.Columns("Autonumber").Visible = False

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Public Sub UserAccessCbox_Popolate()
        Try
            Dim sqlDataAdapter As New SqlDataAdapter
            Dim sqlDataSet As New DataSet
            Dim sqlBindingSource As New BindingSource

            sqlConnection.Close()
            sqlConnection.Open()

            sqlDataSet.Clear()
            Query = "Select Distinct [ACCTTYPE] 
                     FROM [KMDI_ACCT_TB]"
            sqlCommand = New SqlCommand(Query, sqlConnection)
            sqlDataAdapter.SelectCommand = sqlCommand
            sqlDataAdapter.Fill(sqlDataSet, "KMDI_ACCT_TB2")
            sqlBindingSource.DataSource = sqlDataSet
            sqlBindingSource.DataMember = "KMDI_ACCT_TB2"
            ManageAccounts.UserAccessCbox.DataSource = sqlBindingSource
            ManageAccounts.UserAccessCbox.ValueMember = "ACCTTYPE"
            ManageAccounts.UserAccessCbox.SelectedIndex = -1

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Public Sub KMDI_ACCT_ACCESS_TB_INSERT(ByVal ACCTYPE As String,
                                          ByVal TileAccess As String,
                                          ByVal Write As String,
                                          ByVal UserAcctAutonum As String)
        Try
            Query = "INSERT INTO [KMDI_ACCT_ACCESS_TB] ([ACCTYPE]
                                                       ,[TileAccess]
                                                       ,[Write]
                                                       ,[UserAcctAutonum])
                                                VALUES (@ACCTYPE,
                                                        @TileAccess,
                                                        @Write,
                                                        @UserAcctAutonum)"
            sqlCommand = New SqlCommand(Query, sqlConnection)
            sqlCommand.Parameters.AddWithValue("@ACCTYPE", ACCTYPE)
            sqlCommand.Parameters.AddWithValue("@TileAccess", TileAccess)
            sqlCommand.Parameters.AddWithValue("@Write", Write)
            sqlCommand.Parameters.AddWithValue("@UserAcctAutonum", UserAcctAutonum)
            confirmQuery = sqlCommand.ExecuteNonQuery

            If confirmQuery <> 0 Then
                MetroFramework.MetroMessageBox.Show(ChangeWritePermision, "Success", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MetroFramework.MetroMessageBox.Show(ChangeWritePermision, "Failed", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub KMDI_ACCT_ACCESS_TB_READ_FOR_ChangeTilePermision(ByVal UserAcctAutonum As String)
        Try
            Dim sqlDataAdapter As New SqlDataAdapter
            Dim sqlDataSet As New DataSet
            Dim sqlBindingSource As New BindingSource
            Dim tileAccessHere As String
            sqlConnection.Close()
            sqlConnection.Open()

            sqlDataSet.Clear()
            Query = "SELECT [TileAccess] as [Tile]
                       FROM [KMDI_ACCT_ACCESS_TB]
                     WHERE [UserAcctAutonum] = @UserAcctAutonum"
            sqlCommand = New SqlCommand(Query, sqlConnection)
            sqlCommand.Parameters.AddWithValue("@UserAcctAutonum", UserAcctAutonum)

            Read = sqlCommand.ExecuteReader

            While Read.Read
                If Read.HasRows Then
                    tileAccessHere = Read.Item("Tile").ToString
                    ChangeTilePermision.tileAccess += "|" + tileAccessHere
                Else
                    MsgBox("no result")
                    Exit While
                End If
            End While
            Read.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub


End Module
