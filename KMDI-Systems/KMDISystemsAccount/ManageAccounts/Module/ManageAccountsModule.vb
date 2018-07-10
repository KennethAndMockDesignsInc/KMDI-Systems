Imports System.Data.SqlClient

Module ManageAccountsModule

    Dim confirmQuery As Integer

    Public Sub KMDI_ACCT_ACCESS_TB_DELETE(ByVal TileAccess As String,
                                          ByVal UserAcctAutonum As String)
        Try
            Query = "DELETE FROM [KMDI_ACCT_ACCESS_TB] WHERE
                                                       [TileAccess] = @TileAccess AND
                                                       [UserAcctAutonum] = @UserAcctAutonum"
            sqlCommand = New SqlCommand(Query, sqlConnection)
            sqlCommand.Parameters.AddWithValue("@TileAccess", TileAccess)
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

                    If tileAccessHere <> Nothing Then
                        ChangeTilePermision.tileAccess += "|" + tileAccessHere
                    Else
                        ChangeTilePermision.tileAccess = Nothing
                        Exit While
                    End If
                End If
            End While
            Read.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
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
End Module
