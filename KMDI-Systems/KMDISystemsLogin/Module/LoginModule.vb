﻿Imports System.IO
Imports System.Text
Imports System.Data.SqlClient
Imports System.Security.Cryptography

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

End Module
