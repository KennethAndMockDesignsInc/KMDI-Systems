Public Class ChangeTilePermision
    Public tileAccess, AddedAccess, RemovedTileAccess As String
    Public indexofTileAccessCodes As Integer
    Dim containsString As Boolean

    Dim EngrSDreq = "|01", DelReciepts = "|02", DR = "|03", DrReports = "|04", EngrsItinerary = "|05", EngrSDsubm = "|06", 'Engineering
     addendum = "|07", SalesItinerary = "|08", SalesMoni = "|09", SUS = "|10", CallerInfo = "|11", Collection = "|12", ExtDMGs = "|13", CheckBalance = "|14", 'Sales and OP
     ProdSDreq = "|15", CuttList = "|16", StatsMoni = "|17", GlassSpecs = "|18", ProdSDSubm = "|19", ' Production
     ArchiFirm = "|20", Inventory = "|21", Request = "|22", 'Marketing
     Accesories = "|23", myList As String = "|24" ' Costing

    Public Sub CheckCHKBOX()

        Try
            Dim Tilecode As String
            For searchingTileAccess As Integer = 0 To tileAccess.Length - 1 Step 3
                Tilecode = tileAccess.Substring(searchingTileAccess, 3)
                'MsgBox(Tilecode)

                Select Case Tilecode
                    Case EngrSDreq
                        EngrSDRequestChk.CheckState = CheckState.Checked
                    Case DelReciepts
                        DeliveryRecieptsChk.CheckState = CheckState.Checked
                    Case DR
                        DRChk.CheckState = CheckState.Checked
                    Case DrReports
                        DRReportChk.CheckState = CheckState.Checked
                    Case EngrsItinerary
                        EngrsItineraryChk.CheckState = CheckState.Checked
                    Case EngrSDsubm
                        EngrSDSubmittalChk.CheckState = CheckState.Checked

                    Case addendum
                        AddendumChk.CheckState = CheckState.Checked
                    Case SalesItinerary
                        SalesITChk.CheckState = CheckState.Checked
                    Case SalesMoni
                        SalesMonitoringChk.CheckState = CheckState.Checked
                    Case SUS
                        SUSChk.CheckState = CheckState.Checked
                    Case CallerInfo
                        CallerInfoChk.CheckState = CheckState.Checked
                    Case Collection
                        CollectionChk.CheckState = CheckState.Checked
                    Case ExtDMGs
                        ExtDmgsChk.CheckState = CheckState.Checked
                    Case CheckBalance
                        ChkBalanaceCHK.CheckState = CheckState.Checked

                    Case ProdSDreq
                        ProdSDRequestChk.CheckState = CheckState.Checked
                    Case CuttList
                        CuttingListChk.CheckState = CheckState.Checked
                    Case StatsMoni
                        StatusMonitoringChk.CheckState = CheckState.Checked
                    Case GlassSpecs
                        GlassSpecsChk.CheckState = CheckState.Checked
                    Case ProdSDSubm
                        ProdSDSubmittalChk.CheckState = CheckState.Checked

                    Case ArchiFirm
                        ArchFirmChk.CheckState = CheckState.Checked
                    Case Inventory
                        InventoryChk.CheckState = CheckState.Checked
                    Case Request
                        RequestChk.CheckState = CheckState.Checked

                    Case Accesories
                        AccessoriesChk.CheckState = CheckState.Checked
                    Case myList
                        MyListChk.CheckState = CheckState.Checked
                End Select
            Next
        Catch ex As Exception
            'MessageBox.Show(ex.Message & "dito")
        End Try

    End Sub

    Public Sub LoggedAcctPermissions()
        Select Case AccountType
            Case "Accounting"
                RequestChk.CheckState = CheckState.Checked
                InventoryChk.CheckState = CheckState.Checked
                ArchFirmChk.CheckState = CheckState.Checked
                MyListChk.CheckState = CheckState.Checked
                AccessoriesChk.CheckState = CheckState.Checked

            Case "AEIC"
                ChkBalanaceCHK.CheckState = CheckState.Checked
                SUSChk.CheckState = CheckState.Checked
                CollectionChk.CheckState = CheckState.Checked
                SalesMonitoringChk.CheckState = CheckState.Checked

            Case "Costing"
                MyListChk.CheckState = CheckState.Checked
                AccessoriesChk.CheckState = CheckState.Checked

            Case "Cutting"
                ProdSDreq.CheckState = CheckState.Checked
                ProdSDSubm.CheckState = CheckState.Checked
                CuttingListChk.CheckState = CheckState.Checked

            Case "Delivery"
                ProdSDreq.CheckState = CheckState.Checked
                ProdSDSubm.CheckState = CheckState.Checked
                GlassSpecsChk.CheckState = CheckState.Checked

            Case "Engineering"
                DRChk.CheckState = CheckState.Checked
                EngrsItinerary.CheckState = CheckState.Checked
                DRReportChk.CheckState = CheckState.Checked
                DeliveryRecieptsChk.CheckState = CheckState.Checked

            Case "Engr. Manager"
                DRChk.CheckState = CheckState.Checked
                EngrsItinerary.CheckState = CheckState.Checked
                DRReportChk.CheckState = CheckState.Checked
                DeliveryRecieptsChk.CheckState = CheckState.Checked
                EngrSDRequestChk.CheckState = CheckState.Checked
                EngrSDsubm.CheckState = CheckState.Checked

            Case "Fabrication"
                ProdSDreq.CheckState = CheckState.Checked
                ProdSDSubm.CheckState = CheckState.Checked
                StatusMonitoringChk.CheckState = CheckState.Checked

            Case "Marketing"
                RequestChk.CheckState = CheckState.Checked
                InventoryChk.CheckState = CheckState.Checked
                ArchFirmChk.CheckState = CheckState.Checked

            Case "Points"
                CallerInfoChk.CheckState = CheckState.Checked
                ExtDmgsChk.CheckState = CheckState.Checked
                SalesITChk.CheckState = CheckState.Checked
                AddendumChk.CheckState = CheckState.Checked

            Case "Purchasing"
                RequestChk.CheckState = CheckState.Checked
                InventoryChk.CheckState = CheckState.Checked
                ArchFirmChk.CheckState = CheckState.Checked
                MyListChk.CheckState = CheckState.Checked
                AccessoriesChk.CheckState = CheckState.Checked

            Case "Sales"
                CallerInfoChk.CheckState = CheckState.Checked
                ExtDmgsChk.CheckState = CheckState.Checked
                SalesITChk.CheckState = CheckState.Checked
                AddendumChk.CheckState = CheckState.Checked
                ChkBalanaceCHK.CheckState = CheckState.Checked
                SUSChk.CheckState = CheckState.Checked
                CollectionChk.CheckState = CheckState.Checked
                SalesMonitoringChk.CheckState = CheckState.Checked

            Case "SalesMartin"
                CallerInfoChk.CheckState = CheckState.Checked
                ExtDmgsChk.CheckState = CheckState.Checked
                SalesITChk.CheckState = CheckState.Checked
                AddendumChk.CheckState = CheckState.Checked
                ChkBalanaceCHK.CheckState = CheckState.Checked
                SUSChk.CheckState = CheckState.Checked
                CollectionChk.CheckState = CheckState.Checked
                SalesMonitoringChk.CheckState = CheckState.Checked
                EngrSDSubmittalChk.CheckState = CheckState.Checked

            Case "Admin"

            Case "Guest"
                MsgBox("HERE in Guest")
                For Each cc As Control In Me.Controls
                    If TypeOf cc Is MetroFramework.Controls.MetroCheckBox Then
                        DirectCast(cc, MetroFramework.Controls.MetroCheckBox).Checked = True
                    End If
                Next

        End Select
    End Sub

    Private Sub ChangeTilePermision_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KMDI_ACCT_ACCESS_TB_READ_FOR_ChangeTilePermision(ManageAccounts.UsersAutonum)
        MsgBox("tileAccess: " & tileAccess)
        MsgBox("RemovedTileAccess: " & RemovedTileAccess)

        MsgBox(AccountType)
        LoggedAcctPermissions()
        CheckCHKBOX()
    End Sub

    Private Sub ChangeTilePermision_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
        ManageAccounts.Enabled = True
    End Sub

    Private Sub MetroTextButton1_Click(sender As Object, e As EventArgs) Handles MetroTextButton1.Click
        Try

            For Each cc As Control In Me.Controls
                If TypeOf cc Is MetroFramework.Controls.MetroCheckBox Then
                    DirectCast(cc, MetroFramework.Controls.MetroCheckBox).Checked = True
                End If
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub EngrSDRequestChk_CheckedChanged(sender As Object, e As EventArgs) Handles EngrSDRequestChk.CheckedChanged
        If EngrSDRequestChk.Checked = False Then
            RemovedTileAccess += EngrSDreq
            containsString = AddedAccess.Contains(EngrSDreq)
            Select Case containsString
                Case True
                    indexofTileAccessCodes = AddedAccess.IndexOf(EngrSDreq)
                    AddedAccess = AddedAccess.Remove(indexofTileAccessCodes, 3)

            End Select

        Else
            AddedAccess += EngrSDreq
            containsString = AddedAccess.Contains(EngrSDreq)

            Select Case containsString
                Case True
                    indexofTileAccessCodes = RemovedTileAccess.IndexOf(EngrSDreq)
                    RemovedTileAccess = RemovedTileAccess.Remove(indexofTileAccessCodes, 3)

            End Select
            'indexofTileAccessCodes = tileAccess.IndexOf(EngrSDreq)
            'RemovedTileAccess = RemovedTileAccess.Remove(indexofTileAccessCodes, 3)
        End If

        MsgBox("AddedAccess: " & AddedAccess)
        MsgBox("RemovedTileAccess: " & RemovedTileAccess)

    End Sub

    Private Sub DeliveryRecieptsChk_CheckedChanged(sender As Object, e As EventArgs) Handles DeliveryRecieptsChk.CheckedChanged

        If DeliveryRecieptsChk.Checked = False Then
            indexofTileAccessCodes = tileAccess.IndexOf(DelReciepts)
            tileAccess = tileAccess.Remove(indexofTileAccessCodes, 3)
        Else
            tileAccess += DelReciepts
        End If


    End Sub

    Private Sub DRChk_CheckedChanged(sender As Object, e As EventArgs) Handles DRChk.CheckedChanged
        If DRChk.Checked = False Then
            indexofTileAccessCodes = tileAccess.IndexOf(DR)
            tileAccess = tileAccess.Remove(indexofTileAccessCodes, 3)
        Else
            tileAccess += DR
        End If


    End Sub

    Private Sub DRReportChk_CheckedChanged(sender As Object, e As EventArgs) Handles DRReportChk.CheckedChanged
        If DRReportChk.Checked = False Then
            indexofTileAccessCodes = tileAccess.IndexOf(DrReports)
            tileAccess = tileAccess.Remove(indexofTileAccessCodes, 3)
        Else
            tileAccess += DrReports
        End If


    End Sub

    Private Sub EngrsItineraryChk_CheckedChanged(sender As Object, e As EventArgs) Handles EngrsItineraryChk.CheckedChanged
        If EngrsItineraryChk.Checked = False Then
            indexofTileAccessCodes = tileAccess.IndexOf(EngrsItinerary)
            tileAccess = tileAccess.Remove(indexofTileAccessCodes, 3)
        Else
            tileAccess += EngrsItinerary
        End If


    End Sub

    Private Sub EngrSDSubmittalChk_CheckedChanged(sender As Object, e As EventArgs) Handles EngrSDSubmittalChk.CheckedChanged
        If EngrSDSubmittalChk.Checked = False Then
            indexofTileAccessCodes = tileAccess.IndexOf(EngrSDsubm)
            tileAccess = tileAccess.Remove(indexofTileAccessCodes, 3)
        Else
            tileAccess += EngrSDsubm
        End If


    End Sub

    Private Sub AddendumChk_CheckedChanged(sender As Object, e As EventArgs) Handles AddendumChk.CheckedChanged
        If AddendumChk.Checked = False Then
            indexofTileAccessCodes = tileAccess.IndexOf(addendum)
            tileAccess = tileAccess.Remove(indexofTileAccessCodes, 3)
        Else
            tileAccess += addendum
        End If


    End Sub

    Private Sub SalesITChk_CheckedChanged(sender As Object, e As EventArgs) Handles SalesITChk.CheckedChanged
        If SalesITChk.Checked = False Then
            indexofTileAccessCodes = tileAccess.IndexOf(SalesItinerary)
            tileAccess = tileAccess.Remove(indexofTileAccessCodes, 3)
        Else
            tileAccess += SalesItinerary
        End If


    End Sub

    Private Sub SalesMonitoringChk_CheckedChanged(sender As Object, e As EventArgs) Handles SalesMonitoringChk.CheckedChanged
        If SalesMonitoringChk.Checked = False Then
            indexofTileAccessCodes = tileAccess.IndexOf(SalesMoni)
            tileAccess = tileAccess.Remove(indexofTileAccessCodes, 3)
        Else
            tileAccess += SalesMoni
        End If


    End Sub

    Private Sub SUSChk_CheckedChanged(sender As Object, e As EventArgs) Handles SUSChk.CheckedChanged
        If SUSChk.Checked = False Then
            indexofTileAccessCodes = tileAccess.IndexOf(SUS)
            tileAccess = tileAccess.Remove(indexofTileAccessCodes, 3)
        Else
            tileAccess += SUS
        End If


    End Sub

    Private Sub CallerInfoChk_CheckedChanged(sender As Object, e As EventArgs) Handles CallerInfoChk.CheckedChanged
        If CallerInfoChk.Checked = False Then
            indexofTileAccessCodes = tileAccess.IndexOf(CallerInfo)
            tileAccess = tileAccess.Remove(indexofTileAccessCodes, 3)
        Else
            tileAccess += CallerInfo
        End If


    End Sub

    Private Sub CollectionChk_CheckedChanged(sender As Object, e As EventArgs) Handles CollectionChk.CheckedChanged
        If CollectionChk.Checked = False Then
            indexofTileAccessCodes = tileAccess.IndexOf(Collection)
            tileAccess = tileAccess.Remove(indexofTileAccessCodes, 3)
        Else
            tileAccess += Collection
        End If


    End Sub

    Private Sub ExtDmgsChk_CheckedChanged(sender As Object, e As EventArgs) Handles ExtDmgsChk.CheckedChanged

        If ExtDmgsChk.Checked = False Then
            indexofTileAccessCodes = tileAccess.IndexOf(ExtDMGs)
            tileAccess = tileAccess.Remove(indexofTileAccessCodes, 3)
        Else
            tileAccess += ExtDMGs
        End If


    End Sub

    Private Sub ChkBalanaceCHK_CheckedChanged(sender As Object, e As EventArgs) Handles ChkBalanaceCHK.CheckedChanged

        If ChkBalanaceCHK.Checked = False Then
            indexofTileAccessCodes = tileAccess.IndexOf(CheckBalance)
            tileAccess = tileAccess.Remove(indexofTileAccessCodes, 3)
        Else
            tileAccess += CheckBalance
        End If


    End Sub

    Private Sub ProdSDRequestChk_CheckedChanged(sender As Object, e As EventArgs) Handles ProdSDRequestChk.CheckedChanged

        If ProdSDRequestChk.Checked = False Then
            indexofTileAccessCodes = tileAccess.IndexOf(ProdSDreq)
            tileAccess = tileAccess.Remove(indexofTileAccessCodes, 3)
        Else
            tileAccess += ProdSDreq
        End If


    End Sub

    Private Sub CuttingListChk_CheckedChanged(sender As Object, e As EventArgs) Handles CuttingListChk.CheckedChanged

        If CuttingListChk.Checked = False Then
            indexofTileAccessCodes = tileAccess.IndexOf(CuttList)
            tileAccess = tileAccess.Remove(indexofTileAccessCodes, 3)
        Else
            tileAccess += CuttList
        End If


    End Sub

    Private Sub StatusMonitoringChk_CheckedChanged(sender As Object, e As EventArgs) Handles StatusMonitoringChk.CheckedChanged

        If StatusMonitoringChk.Checked = False Then
            indexofTileAccessCodes = tileAccess.IndexOf(StatsMoni)
            tileAccess = tileAccess.Remove(indexofTileAccessCodes, 3)
        Else
            tileAccess += StatsMoni
        End If


    End Sub

    Private Sub GlassSpecsChk_CheckedChanged(sender As Object, e As EventArgs) Handles GlassSpecsChk.CheckedChanged

        If GlassSpecsChk.Checked = False Then
            indexofTileAccessCodes = tileAccess.IndexOf(GlassSpecs)
            tileAccess = tileAccess.Remove(indexofTileAccessCodes, 3)
        Else
            tileAccess += GlassSpecs
        End If


    End Sub

    Private Sub ProdSDSubmittalChk_CheckedChanged(sender As Object, e As EventArgs) Handles ProdSDSubmittalChk.CheckedChanged

        If ProdSDSubmittalChk.Checked = False Then
            indexofTileAccessCodes = tileAccess.IndexOf(ProdSDSubm)
            tileAccess = tileAccess.Remove(indexofTileAccessCodes, 3)
        Else
            tileAccess += ProdSDSubm
        End If


    End Sub

    Private Sub ArchFirmChk_CheckedChanged(sender As Object, e As EventArgs) Handles ArchFirmChk.CheckedChanged

        If ArchFirmChk.Checked = False Then
            indexofTileAccessCodes = tileAccess.IndexOf(ArchiFirm)
            tileAccess = tileAccess.Remove(indexofTileAccessCodes, 3)
        Else
            tileAccess += ArchiFirm
        End If


    End Sub

    Private Sub InventoryChk_CheckedChanged(sender As Object, e As EventArgs) Handles InventoryChk.CheckedChanged

        If InventoryChk.Checked = False Then
            indexofTileAccessCodes = tileAccess.IndexOf(Inventory)
            tileAccess = tileAccess.Remove(indexofTileAccessCodes, 3)
        Else
            tileAccess += Inventory
        End If


    End Sub

    Private Sub RequestChk_CheckedChanged(sender As Object, e As EventArgs) Handles RequestChk.CheckedChanged

        If RequestChk.Checked = False Then
            indexofTileAccessCodes = tileAccess.IndexOf(Request)
            tileAccess = tileAccess.Remove(indexofTileAccessCodes, 3)
        Else
            tileAccess += Request
        End If


    End Sub

    Private Sub AccessoriesChk_CheckedChanged(sender As Object, e As EventArgs) Handles AccessoriesChk.CheckedChanged

        If AccessoriesChk.Checked = False Then
            indexofTileAccessCodes = tileAccess.IndexOf(Accesories)
            tileAccess = tileAccess.Remove(indexofTileAccessCodes, 3)
        Else
            tileAccess += Accesories
        End If


    End Sub

    Private Sub MyListChk_CheckedChanged(sender As Object, e As EventArgs) Handles MyListChk.CheckedChanged

        If MyListChk.Checked = False Then
            indexofTileAccessCodes = tileAccess.IndexOf(myList)
            tileAccess = tileAccess.Remove(indexofTileAccessCodes, 3)
        Else
            tileAccess += myList
        End If


    End Sub

    Private Sub SaveManageBtn_Click(sender As Object, e As EventArgs) Handles SaveManageBtn.Click
        Dim Tcode As String
        For searchingTileAccess As Integer = 0 To tileAccess.Length - 1 Step 3
            Tcode = tileAccess.Substring(searchingTileAccess + 1, 2)
            MsgBox(ManageAccounts.userAccess & vbCrLf & Tcode & vbCrLf & ManageAccounts.UsersAutonum)
            KMDI_ACCT_ACCESS_TB_INSERT(ManageAccounts.userAccess, Tcode, "0", ManageAccounts.UsersAutonum)
        Next
    End Sub

End Class