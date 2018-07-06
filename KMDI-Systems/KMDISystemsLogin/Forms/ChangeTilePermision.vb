Public Class ChangeTilePermision
    Public tileAccess, AddedAccess, RemovedTileAccess As String

    Public indexofTileAccessCodes As Integer
    Dim containsString As Boolean

    Dim accounttypehere As String = ManageAccounts.userAccess

    Dim EngrSDreq = "|01", DelReciepts = "|02", DR = "|03", DrReports = "|04", EngrsItinerary = "|05", EngrSDsubm = "|06", 'Engineering
     addendum = "|07", SalesItinerary = "|08", SalesMoni = "|09", SUS = "|10", CallerInfo = "|11", Collection = "|12", ExtDMGs = "|13", CheckBalance = "|14", 'Sales and OP
     ProdSDreq = "|15", CuttList = "|16", StatsMoni = "|17", GlassSpecs = "|18", ProdSDSubm = "|19", ' Production
     ArchiFirm = "|20", Inventory = "|21", Request = "|22", 'Marketing
     Accesories = "|23", myList As String = "|24" ' Costing


    Public Sub CheckCHKBOX()

        Try
            Dim Tilecode As String

            If tileAccess <> Nothing Then
                For searchingTileAccess As Integer = 0 To tileAccess.Length - 1 Step 3
                    Tilecode = tileAccess.Substring(searchingTileAccess, 3)

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
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Public Sub LoggedAcctPermissions()
        Select Case accounttypehere
            Case "Accounting"
                RequestChk.CheckState = CheckState.Checked
                InventoryChk.CheckState = CheckState.Checked
                ArchFirmChk.CheckState = CheckState.Checked
                MyListChk.CheckState = CheckState.Checked
                AccessoriesChk.CheckState = CheckState.Checked

                RequestChk.Enabled = False
                InventoryChk.Enabled = False
                ArchFirmChk.Enabled = False
                MyListChk.Enabled = False
                AccessoriesChk.Enabled = False

            Case "AEIC"
                ChkBalanaceCHK.CheckState = CheckState.Checked
                SUSChk.CheckState = CheckState.Checked
                CollectionChk.CheckState = CheckState.Checked
                SalesMonitoringChk.CheckState = CheckState.Checked

                ChkBalanaceCHK.Enabled = False
                SUSChk.Enabled = False
                CollectionChk.Enabled = False
                SalesMonitoringChk.Enabled = False

            Case "Costing"
                MyListChk.CheckState = CheckState.Checked
                AccessoriesChk.CheckState = CheckState.Checked

                MyListChk.Enabled = False
                AccessoriesChk.Enabled = False

            Case "Cutting"
                ProdSDreq.CheckState = CheckState.Checked
                ProdSDSubm.CheckState = CheckState.Checked
                CuttingListChk.CheckState = CheckState.Checked

                ProdSDreq.Enabled = False
                ProdSDSubm.Enabled = False
                CuttingListChk.Enabled = False

            Case "Delivery"
                ProdSDreq.CheckState = CheckState.Checked
                ProdSDSubm.CheckState = CheckState.Checked
                GlassSpecsChk.CheckState = CheckState.Checked

                ProdSDreq.Enabled = False
                ProdSDSubm.Enabled = False
                GlassSpecsChk.Enabled = False

            Case "Engineering"
                DRChk.CheckState = CheckState.Checked
                EngrsItineraryChk.CheckState = CheckState.Checked
                DRReportChk.CheckState = CheckState.Checked
                DeliveryRecieptsChk.CheckState = CheckState.Checked

                DRChk.Enabled = False
                EngrsItineraryChk.Enabled = False
                DRReportChk.Enabled = False
                DeliveryRecieptsChk.Enabled = False

            Case "Engr. Manager"
                DRChk.CheckState = CheckState.Checked
                EngrsItineraryChk.CheckState = CheckState.Checked
                DRReportChk.CheckState = CheckState.Checked
                DeliveryRecieptsChk.CheckState = CheckState.Checked
                EngrSDRequestChk.CheckState = CheckState.Checked
                EngrSDsubm.CheckState = CheckState.Checked

                DRChk.Enabled = False
                EngrsItineraryChk.Enabled = False
                DRReportChk.Enabled = False
                DeliveryRecieptsChk.Enabled = False
                EngrSDRequestChk.Enabled = False
                EngrSDsubm.Enabled = False

            Case "Fabrication"
                ProdSDreq.CheckState = CheckState.Checked
                ProdSDSubm.CheckState = CheckState.Checked
                StatusMonitoringChk.CheckState = CheckState.Checked

                ProdSDreq.Enabled = False
                ProdSDSubm.Enabled = False
                StatusMonitoringChk.Enabled = False

            Case "Marketing"
                RequestChk.CheckState = CheckState.Checked
                InventoryChk.CheckState = CheckState.Checked
                ArchFirmChk.CheckState = CheckState.Checked

                RequestChk.Enabled = False
                InventoryChk.Enabled = False
                ArchFirmChk.Enabled = False

            Case "Points"
                CallerInfoChk.CheckState = CheckState.Checked
                ExtDmgsChk.CheckState = CheckState.Checked
                SalesITChk.CheckState = CheckState.Checked
                AddendumChk.CheckState = CheckState.Checked

                CallerInfoChk.Enabled = False
                ExtDmgsChk.Enabled = False
                SalesITChk.Enabled = False
                AddendumChk.Enabled = False

            Case "Purchasing"
                RequestChk.CheckState = CheckState.Checked
                InventoryChk.CheckState = CheckState.Checked
                ArchFirmChk.CheckState = CheckState.Checked
                MyListChk.CheckState = CheckState.Checked
                AccessoriesChk.CheckState = CheckState.Checked

                RequestChk.Enabled = False
                InventoryChk.Enabled = False
                ArchFirmChk.Enabled = False
                MyListChk.Enabled = False
                AccessoriesChk.Enabled = False

            Case "Sales"
                CallerInfoChk.CheckState = CheckState.Checked
                ExtDmgsChk.CheckState = CheckState.Checked
                SalesITChk.CheckState = CheckState.Checked
                AddendumChk.CheckState = CheckState.Checked
                ChkBalanaceCHK.CheckState = CheckState.Checked
                SUSChk.CheckState = CheckState.Checked
                CollectionChk.CheckState = CheckState.Checked
                SalesMonitoringChk.CheckState = CheckState.Checked

                CallerInfoChk.Enabled = False
                ExtDmgsChk.Enabled = False
                SalesITChk.Enabled = False
                AddendumChk.Enabled = False
                ChkBalanaceCHK.Enabled = False
                SUSChk.Enabled = False
                CollectionChk.Enabled = False
                SalesMonitoringChk.Enabled = False

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

                CallerInfoChk.Enabled = False
                ExtDmgsChk.Enabled = False
                SalesITChk.Enabled = False
                AddendumChk.Enabled = False
                ChkBalanaceCHK.Enabled = False
                SUSChk.Enabled = False
                CollectionChk.Enabled = False
                SalesMonitoringChk.Enabled = False
                EngrSDSubmittalChk.Enabled = False

            Case "Admin"

            Case "Guest"


        End Select
    End Sub

    Private Sub ChangeTilePermision_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddedAccess = ""
        RemovedTileAccess = ""

        KMDI_ACCT_ACCESS_TB_READ_FOR_ChangeTilePermision(ManageAccounts.UsersAutonum)
        MsgBox("tileAccess: " & tileAccess)
        MsgBox("RemovedTileAccess: " & RemovedTileAccess)

        MsgBox(accounttypehere)
        LoggedAcctPermissions()
        CheckCHKBOX()
    End Sub

    Private Sub ChangeTilePermision_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
        ManageAccounts.Enabled = True
    End Sub

    Private Sub EngrSDRequestChk_Click(sender As Object, e As EventArgs) Handles EngrSDRequestChk.Click
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

            containsString = RemovedTileAccess.Contains(EngrSDreq)
            Select Case containsString
                Case True
                    indexofTileAccessCodes = RemovedTileAccess.IndexOf(EngrSDreq)
                    RemovedTileAccess = RemovedTileAccess.Remove(indexofTileAccessCodes, 3)

            End Select

        End If

        MsgBox("AddedAccess: " & AddedAccess)
        MsgBox("RemovedTileAccess: " & RemovedTileAccess)

    End Sub

    Private Sub DeliveryRecieptsChk_Click(sender As Object, e As EventArgs) Handles DeliveryRecieptsChk.Click
        If DeliveryRecieptsChk.Checked = False Then
            RemovedTileAccess += DelReciepts
            containsString = AddedAccess.Contains(DelReciepts)
            Select Case containsString
                Case True
                    indexofTileAccessCodes = AddedAccess.IndexOf(DelReciepts)
                    AddedAccess = AddedAccess.Remove(indexofTileAccessCodes, 3)

            End Select

        Else
            AddedAccess += DelReciepts

            containsString = RemovedTileAccess.Contains(DelReciepts)
            Select Case containsString
                Case True
                    indexofTileAccessCodes = RemovedTileAccess.IndexOf(DelReciepts)
                    RemovedTileAccess = RemovedTileAccess.Remove(indexofTileAccessCodes, 3)

            End Select

        End If

        MsgBox("AddedAccess: " & AddedAccess)
        MsgBox("RemovedTileAccess: " & RemovedTileAccess)


        'If DeliveryRecieptsChk.Checked = False Then
        '    indexofTileAccessCodes = tileAccess.IndexOf(DelReciepts)
        '    tileAccess = tileAccess.Remove(indexofTileAccessCodes, 3)
        'Else
        '    tileAccess += DelReciepts
        'End If


    End Sub

    Private Sub DRChk_Click(sender As Object, e As EventArgs) Handles DRChk.Click
        If DRChk.Checked = False Then
            RemovedTileAccess += DR
            containsString = AddedAccess.Contains(DR)
            Select Case containsString
                Case True
                    indexofTileAccessCodes = AddedAccess.IndexOf(DR)
                    AddedAccess = AddedAccess.Remove(indexofTileAccessCodes, 3)

            End Select

        Else
            AddedAccess += DR

            containsString = RemovedTileAccess.Contains(DR)
            Select Case containsString
                Case True
                    indexofTileAccessCodes = RemovedTileAccess.IndexOf(DR)
                    RemovedTileAccess = RemovedTileAccess.Remove(indexofTileAccessCodes, 3)

            End Select

        End If

        MsgBox("AddedAccess: " & AddedAccess)
        MsgBox("RemovedTileAccess: " & RemovedTileAccess)

        'If DRChk.Checked = False Then
        '    indexofTileAccessCodes = tileAccess.IndexOf(DR)
        '    tileAccess = tileAccess.Remove(indexofTileAccessCodes, 3)
        'Else
        '    tileAccess += DR
        'End If


    End Sub

    Private Sub DRReportChk_Click(sender As Object, e As EventArgs) Handles DRReportChk.Click
        If DRReportChk.Checked = False Then
            RemovedTileAccess += DrReports
            containsString = AddedAccess.Contains(DrReports)
            Select Case containsString
                Case True
                    indexofTileAccessCodes = AddedAccess.IndexOf(DrReports)
                    AddedAccess = AddedAccess.Remove(indexofTileAccessCodes, 3)

            End Select

        Else
            AddedAccess += DrReports

            containsString = RemovedTileAccess.Contains(DrReports)
            Select Case containsString
                Case True
                    indexofTileAccessCodes = RemovedTileAccess.IndexOf(DrReports)
                    RemovedTileAccess = RemovedTileAccess.Remove(indexofTileAccessCodes, 3)

            End Select

        End If

        MsgBox("AddedAccess: " & AddedAccess)
        MsgBox("RemovedTileAccess: " & RemovedTileAccess)

        'If DRReportChk.Checked = False Then
        '    indexofTileAccessCodes = tileAccess.IndexOf(DrReports)
        '    tileAccess = tileAccess.Remove(indexofTileAccessCodes, 3)
        'Else
        '    tileAccess += DrReports
        'End If


    End Sub

    Private Sub EngrsItineraryChk_Click(sender As Object, e As EventArgs) Handles EngrsItineraryChk.Click
        If EngrsItineraryChk.Checked = False Then
            RemovedTileAccess += EngrsItinerary
            containsString = AddedAccess.Contains(EngrsItinerary)
            Select Case containsString
                Case True
                    indexofTileAccessCodes = AddedAccess.IndexOf(EngrsItinerary)
                    AddedAccess = AddedAccess.Remove(indexofTileAccessCodes, 3)

            End Select

        Else
            AddedAccess += EngrsItinerary

            containsString = RemovedTileAccess.Contains(EngrsItinerary)
            Select Case containsString
                Case True
                    indexofTileAccessCodes = RemovedTileAccess.IndexOf(EngrsItinerary)
                    RemovedTileAccess = RemovedTileAccess.Remove(indexofTileAccessCodes, 3)

            End Select

        End If

        MsgBox("AddedAccess: " & AddedAccess)
        MsgBox("RemovedTileAccess: " & RemovedTileAccess)

        'If EngrsItineraryChk.Checked = False Then
        '    indexofTileAccessCodes = tileAccess.IndexOf(EngrsItinerary)
        '    tileAccess = tileAccess.Remove(indexofTileAccessCodes, 3)
        'Else
        '    tileAccess += EngrsItinerary
        'End If


    End Sub

    Private Sub EngrSDSubmittalChk_Click(sender As Object, e As EventArgs) Handles EngrSDSubmittalChk.Click
        If EngrSDSubmittalChk.Checked = False Then
            RemovedTileAccess += EngrSDsubm
            containsString = AddedAccess.Contains(EngrSDsubm)
            Select Case containsString
                Case True
                    indexofTileAccessCodes = AddedAccess.IndexOf(EngrSDsubm)
                    AddedAccess = AddedAccess.Remove(indexofTileAccessCodes, 3)

            End Select

        Else
            AddedAccess += EngrSDsubm

            containsString = RemovedTileAccess.Contains(EngrSDsubm)
            Select Case containsString
                Case True
                    indexofTileAccessCodes = RemovedTileAccess.IndexOf(EngrSDsubm)
                    RemovedTileAccess = RemovedTileAccess.Remove(indexofTileAccessCodes, 3)

            End Select

        End If

        MsgBox("AddedAccess: " & AddedAccess)
        MsgBox("RemovedTileAccess: " & RemovedTileAccess)


        'If EngrSDSubmittalChk.Checked = False Then
        '    indexofTileAccessCodes = tileAccess.IndexOf(EngrSDsubm)
        '    tileAccess = tileAccess.Remove(indexofTileAccessCodes, 3)
        'Else
        '    tileAccess += EngrSDsubm
        'End If


    End Sub

    Private Sub AddendumChk_Click(sender As Object, e As EventArgs) Handles AddendumChk.Click
        If AddendumChk.Checked = False Then
            RemovedTileAccess += addendum
            containsString = AddedAccess.Contains(addendum)
            Select Case containsString
                Case True
                    indexofTileAccessCodes = AddedAccess.IndexOf(addendum)
                    AddedAccess = AddedAccess.Remove(indexofTileAccessCodes, 3)

            End Select

        Else
            AddedAccess += addendum

            containsString = RemovedTileAccess.Contains(addendum)
            Select Case containsString
                Case True
                    indexofTileAccessCodes = RemovedTileAccess.IndexOf(addendum)
                    RemovedTileAccess = RemovedTileAccess.Remove(indexofTileAccessCodes, 3)

            End Select

        End If

        MsgBox("AddedAccess: " & AddedAccess)
        MsgBox("RemovedTileAccess: " & RemovedTileAccess)


        'If AddendumChk.Checked = False Then
        '    indexofTileAccessCodes = tileAccess.IndexOf(addendum)
        '    tileAccess = tileAccess.Remove(indexofTileAccessCodes, 3)
        'Else
        '    tileAccess += addendum
        'End If


    End Sub

    Private Sub SalesITChk_Click(sender As Object, e As EventArgs) Handles SalesITChk.Click
        If SalesITChk.Checked = False Then
            RemovedTileAccess += SalesItinerary
            containsString = AddedAccess.Contains(SalesItinerary)
            Select Case containsString
                Case True
                    indexofTileAccessCodes = AddedAccess.IndexOf(SalesItinerary)
                    AddedAccess = AddedAccess.Remove(indexofTileAccessCodes, 3)

            End Select

        Else
            AddedAccess += SalesItinerary

            containsString = RemovedTileAccess.Contains(SalesItinerary)
            Select Case containsString
                Case True
                    indexofTileAccessCodes = RemovedTileAccess.IndexOf(SalesItinerary)
                    RemovedTileAccess = RemovedTileAccess.Remove(indexofTileAccessCodes, 3)

            End Select

        End If

        MsgBox("AddedAccess: " & AddedAccess)
        MsgBox("RemovedTileAccess: " & RemovedTileAccess)


        'If SalesITChk.Checked = False Then
        '    indexofTileAccessCodes = tileAccess.IndexOf(SalesItinerary)
        '    tileAccess = tileAccess.Remove(indexofTileAccessCodes, 3)
        'Else
        '    tileAccess += SalesItinerary
        'End If


    End Sub

    Private Sub SalesMonitoringChk_Click(sender As Object, e As EventArgs) Handles SalesMonitoringChk.Click
        If SalesMonitoringChk.Checked = False Then
            RemovedTileAccess += SalesMoni
            containsString = AddedAccess.Contains(SalesMoni)
            Select Case containsString
                Case True
                    indexofTileAccessCodes = AddedAccess.IndexOf(SalesMoni)
                    AddedAccess = AddedAccess.Remove(indexofTileAccessCodes, 3)

            End Select

        Else
            AddedAccess += SalesMoni

            containsString = RemovedTileAccess.Contains(SalesMoni)
            Select Case containsString
                Case True
                    indexofTileAccessCodes = RemovedTileAccess.IndexOf(SalesMoni)
                    RemovedTileAccess = RemovedTileAccess.Remove(indexofTileAccessCodes, 3)

            End Select

        End If

        MsgBox("AddedAccess: " & AddedAccess)
        MsgBox("RemovedTileAccess: " & RemovedTileAccess)


        'If SalesMonitoringChk.Checked = False Then
        '    indexofTileAccessCodes = tileAccess.IndexOf(SalesMoni)
        '    tileAccess = tileAccess.Remove(indexofTileAccessCodes, 3)
        'Else
        '    tileAccess += SalesMoni
        'End If


    End Sub

    Private Sub SUSChk_Click(sender As Object, e As EventArgs) Handles SUSChk.Click
        If SUSChk.Checked = False Then
            RemovedTileAccess += SUS
            containsString = AddedAccess.Contains(SUS)
            Select Case containsString
                Case True
                    indexofTileAccessCodes = AddedAccess.IndexOf(SUS)
                    AddedAccess = AddedAccess.Remove(indexofTileAccessCodes, 3)

            End Select

        Else
            AddedAccess += SUS

            containsString = RemovedTileAccess.Contains(SUS)
            Select Case containsString
                Case True
                    indexofTileAccessCodes = RemovedTileAccess.IndexOf(SUS)
                    RemovedTileAccess = RemovedTileAccess.Remove(indexofTileAccessCodes, 3)

            End Select

        End If

        MsgBox("AddedAccess: " & AddedAccess)
        MsgBox("RemovedTileAccess: " & RemovedTileAccess)



        'If SUSChk.Checked = False Then
        '    indexofTileAccessCodes = tileAccess.IndexOf(SUS)
        '    tileAccess = tileAccess.Remove(indexofTileAccessCodes, 3)
        'Else
        '    tileAccess += SUS
        'End If


    End Sub

    Private Sub CallerInfoChk_Click(sender As Object, e As EventArgs) Handles CallerInfoChk.Click
        If CallerInfoChk.Checked = False Then
            RemovedTileAccess += CallerInfo
            containsString = AddedAccess.Contains(CallerInfo)
            Select Case containsString
                Case True
                    indexofTileAccessCodes = AddedAccess.IndexOf(CallerInfo)
                    AddedAccess = AddedAccess.Remove(indexofTileAccessCodes, 3)

            End Select

        Else
            AddedAccess += CallerInfo

            containsString = RemovedTileAccess.Contains(CallerInfo)
            Select Case containsString
                Case True
                    indexofTileAccessCodes = RemovedTileAccess.IndexOf(CallerInfo)
                    RemovedTileAccess = RemovedTileAccess.Remove(indexofTileAccessCodes, 3)

            End Select

        End If

        MsgBox("AddedAccess: " & AddedAccess)
        MsgBox("RemovedTileAccess: " & RemovedTileAccess)


        'If CallerInfoChk.Checked = False Then
        '    indexofTileAccessCodes = tileAccess.IndexOf(CallerInfo)
        '    tileAccess = tileAccess.Remove(indexofTileAccessCodes, 3)
        'Else
        '    tileAccess += CallerInfo
        'End If


    End Sub

    Private Sub CollectionChk_Click(sender As Object, e As EventArgs) Handles CollectionChk.Click
        If CollectionChk.Checked = False Then
            RemovedTileAccess += Collection
            containsString = AddedAccess.Contains(Collection)
            Select Case containsString
                Case True
                    indexofTileAccessCodes = AddedAccess.IndexOf(Collection)
                    AddedAccess = AddedAccess.Remove(indexofTileAccessCodes, 3)

            End Select

        Else
            AddedAccess += Collection

            containsString = RemovedTileAccess.Contains(Collection)
            Select Case containsString
                Case True
                    indexofTileAccessCodes = RemovedTileAccess.IndexOf(Collection)
                    RemovedTileAccess = RemovedTileAccess.Remove(indexofTileAccessCodes, 3)

            End Select

        End If

        MsgBox("AddedAccess: " & AddedAccess)
        MsgBox("RemovedTileAccess: " & RemovedTileAccess)


        'If CollectionChk.Checked = False Then
        '    indexofTileAccessCodes = tileAccess.IndexOf(Collection)
        '    tileAccess = tileAccess.Remove(indexofTileAccessCodes, 3)
        'Else
        '    tileAccess += Collection
        'End If


    End Sub

    Private Sub ExtDmgsChk_Click(sender As Object, e As EventArgs) Handles ExtDmgsChk.Click
        If ExtDmgsChk.Checked = False Then
            RemovedTileAccess += ExtDMGs
            containsString = AddedAccess.Contains(ExtDMGs)
            Select Case containsString
                Case True
                    indexofTileAccessCodes = AddedAccess.IndexOf(ExtDMGs)
                    AddedAccess = AddedAccess.Remove(indexofTileAccessCodes, 3)

            End Select

        Else
            AddedAccess += ExtDMGs

            containsString = RemovedTileAccess.Contains(ExtDMGs)
            Select Case containsString
                Case True
                    indexofTileAccessCodes = RemovedTileAccess.IndexOf(ExtDMGs)
                    RemovedTileAccess = RemovedTileAccess.Remove(indexofTileAccessCodes, 3)

            End Select

        End If

        MsgBox("AddedAccess: " & AddedAccess)
        MsgBox("RemovedTileAccess: " & RemovedTileAccess)

        'If ExtDmgsChk.Checked = False Then
        '    indexofTileAccessCodes = tileAccess.IndexOf(ExtDMGs)
        '    tileAccess = tileAccess.Remove(indexofTileAccessCodes, 3)
        'Else
        '    tileAccess += ExtDMGs
        'End If


    End Sub

    Private Sub ChkBalanaceCHK_Click(sender As Object, e As EventArgs) Handles ChkBalanaceCHK.Click
        If ChkBalanaceCHK.Checked = False Then
            RemovedTileAccess += CheckBalance
            containsString = AddedAccess.Contains(CheckBalance)
            Select Case containsString
                Case True
                    indexofTileAccessCodes = AddedAccess.IndexOf(CheckBalance)
                    AddedAccess = AddedAccess.Remove(indexofTileAccessCodes, 3)

            End Select

        Else
            AddedAccess += CheckBalance

            containsString = RemovedTileAccess.Contains(CheckBalance)
            Select Case containsString
                Case True
                    indexofTileAccessCodes = RemovedTileAccess.IndexOf(CheckBalance)
                    RemovedTileAccess = RemovedTileAccess.Remove(indexofTileAccessCodes, 3)

            End Select

        End If

        MsgBox("AddedAccess: " & AddedAccess)
        MsgBox("RemovedTileAccess: " & RemovedTileAccess)


        'If ChkBalanaceCHK.Checked = False Then
        '    indexofTileAccessCodes = tileAccess.IndexOf(CheckBalance)
        '    tileAccess = tileAccess.Remove(indexofTileAccessCodes, 3)
        'Else
        '    tileAccess += CheckBalance
        'End If


    End Sub

    Private Sub ProdSDRequestChk_Click(sender As Object, e As EventArgs) Handles ProdSDRequestChk.Click
        If ProdSDRequestChk.Checked = False Then
            RemovedTileAccess += ProdSDreq
            containsString = AddedAccess.Contains(ProdSDreq)
            Select Case containsString
                Case True
                    indexofTileAccessCodes = AddedAccess.IndexOf(ProdSDreq)
                    AddedAccess = AddedAccess.Remove(indexofTileAccessCodes, 3)

            End Select

        Else
            AddedAccess += ProdSDreq

            containsString = RemovedTileAccess.Contains(ProdSDreq)
            Select Case containsString
                Case True
                    indexofTileAccessCodes = RemovedTileAccess.IndexOf(ProdSDreq)
                    RemovedTileAccess = RemovedTileAccess.Remove(indexofTileAccessCodes, 3)

            End Select

        End If

        MsgBox("AddedAccess: " & AddedAccess)
        MsgBox("RemovedTileAccess: " & RemovedTileAccess)


        'If ProdSDRequestChk.Checked = False Then
        '    indexofTileAccessCodes = tileAccess.IndexOf(ProdSDreq)
        '    tileAccess = tileAccess.Remove(indexofTileAccessCodes, 3)
        'Else
        '    tileAccess += ProdSDreq
        'End If


    End Sub

    Private Sub CuttingListChk_Click(sender As Object, e As EventArgs) Handles CuttingListChk.Click
        If CuttingListChk.Checked = False Then
            RemovedTileAccess += CuttList
            containsString = AddedAccess.Contains(CuttList)
            Select Case containsString
                Case True
                    indexofTileAccessCodes = AddedAccess.IndexOf(CuttList)
                    AddedAccess = AddedAccess.Remove(indexofTileAccessCodes, 3)

            End Select

        Else
            AddedAccess += CuttList

            containsString = RemovedTileAccess.Contains(CuttList)
            Select Case containsString
                Case True
                    indexofTileAccessCodes = RemovedTileAccess.IndexOf(CuttList)
                    RemovedTileAccess = RemovedTileAccess.Remove(indexofTileAccessCodes, 3)

            End Select

        End If

        MsgBox("AddedAccess: " & AddedAccess)
        MsgBox("RemovedTileAccess: " & RemovedTileAccess)

        'If CuttingListChk.Checked = False Then
        '    indexofTileAccessCodes = tileAccess.IndexOf(CuttList)
        '    tileAccess = tileAccess.Remove(indexofTileAccessCodes, 3)
        'Else
        '    tileAccess += CuttList
        'End If


    End Sub

    Private Sub StatusMonitoringChk_Click(sender As Object, e As EventArgs) Handles StatusMonitoringChk.Click
        If StatusMonitoringChk.Checked = False Then
            RemovedTileAccess += StatsMoni
            containsString = AddedAccess.Contains(StatsMoni)
            Select Case containsString
                Case True
                    indexofTileAccessCodes = AddedAccess.IndexOf(StatsMoni)
                    AddedAccess = AddedAccess.Remove(indexofTileAccessCodes, 3)

            End Select

        Else
            AddedAccess += StatsMoni

            containsString = RemovedTileAccess.Contains(StatsMoni)
            Select Case containsString
                Case True
                    indexofTileAccessCodes = RemovedTileAccess.IndexOf(StatsMoni)
                    RemovedTileAccess = RemovedTileAccess.Remove(indexofTileAccessCodes, 3)

            End Select

        End If

        MsgBox("AddedAccess: " & AddedAccess)
        MsgBox("RemovedTileAccess: " & RemovedTileAccess)

        'If StatusMonitoringChk.Checked = False Then
        '    indexofTileAccessCodes = tileAccess.IndexOf(StatsMoni)
        '    tileAccess = tileAccess.Remove(indexofTileAccessCodes, 3)
        'Else
        '    tileAccess += StatsMoni
        'End If


    End Sub

    Private Sub GlassSpecsChk_Click(sender As Object, e As EventArgs) Handles GlassSpecsChk.Click
        If GlassSpecsChk.Checked = False Then
            RemovedTileAccess += GlassSpecs
            containsString = AddedAccess.Contains(GlassSpecs)
            Select Case containsString
                Case True
                    indexofTileAccessCodes = AddedAccess.IndexOf(GlassSpecs)
                    AddedAccess = AddedAccess.Remove(indexofTileAccessCodes, 3)

            End Select

        Else
            AddedAccess += GlassSpecs

            containsString = RemovedTileAccess.Contains(GlassSpecs)
            Select Case containsString
                Case True
                    indexofTileAccessCodes = RemovedTileAccess.IndexOf(GlassSpecs)
                    RemovedTileAccess = RemovedTileAccess.Remove(indexofTileAccessCodes, 3)

            End Select

        End If

        MsgBox("AddedAccess: " & AddedAccess)
        MsgBox("RemovedTileAccess: " & RemovedTileAccess)


        'If GlassSpecsChk.Checked = False Then
        '    indexofTileAccessCodes = tileAccess.IndexOf(GlassSpecs)
        '    tileAccess = tileAccess.Remove(indexofTileAccessCodes, 3)
        'Else
        '    tileAccess += GlassSpecs
        'End If


    End Sub

    Private Sub ProdSDSubmittalChk_Click(sender As Object, e As EventArgs) Handles ProdSDSubmittalChk.Click
        If ProdSDSubmittalChk.Checked = False Then
            RemovedTileAccess += ProdSDSubm
            containsString = AddedAccess.Contains(ProdSDSubm)
            Select Case containsString
                Case True
                    indexofTileAccessCodes = AddedAccess.IndexOf(ProdSDSubm)
                    AddedAccess = AddedAccess.Remove(indexofTileAccessCodes, 3)

            End Select

        Else
            AddedAccess += ProdSDSubm

            containsString = RemovedTileAccess.Contains(ProdSDSubm)
            Select Case containsString
                Case True
                    indexofTileAccessCodes = RemovedTileAccess.IndexOf(ProdSDSubm)
                    RemovedTileAccess = RemovedTileAccess.Remove(indexofTileAccessCodes, 3)

            End Select

        End If

        MsgBox("AddedAccess: " & AddedAccess)
        MsgBox("RemovedTileAccess: " & RemovedTileAccess)


        'If ProdSDSubmittalChk.Checked = False Then
        '    indexofTileAccessCodes = tileAccess.IndexOf(ProdSDSubm)
        '    tileAccess = tileAccess.Remove(indexofTileAccessCodes, 3)
        'Else
        '    tileAccess += ProdSDSubm
        'End If


    End Sub

    Private Sub ArchFirmChk_Click(sender As Object, e As EventArgs) Handles ArchFirmChk.Click
        If ArchFirmChk.Checked = False Then
            RemovedTileAccess += ArchiFirm
            containsString = AddedAccess.Contains(ArchiFirm)
            Select Case containsString
                Case True
                    indexofTileAccessCodes = AddedAccess.IndexOf(ArchiFirm)
                    AddedAccess = AddedAccess.Remove(indexofTileAccessCodes, 3)

            End Select

        Else
            AddedAccess += ArchiFirm

            containsString = RemovedTileAccess.Contains(ArchiFirm)
            Select Case containsString
                Case True
                    indexofTileAccessCodes = RemovedTileAccess.IndexOf(ArchiFirm)
                    RemovedTileAccess = RemovedTileAccess.Remove(indexofTileAccessCodes, 3)

            End Select

        End If

        MsgBox("AddedAccess: " & AddedAccess)
        MsgBox("RemovedTileAccess: " & RemovedTileAccess)


        'If ArchFirmChk.Checked = False Then
        '    indexofTileAccessCodes = tileAccess.IndexOf(ArchiFirm)
        '    tileAccess = tileAccess.Remove(indexofTileAccessCodes, 3)
        'Else
        '    tileAccess += ArchiFirm
        'End If


    End Sub

    Private Sub InventoryChk_Click(sender As Object, e As EventArgs) Handles InventoryChk.Click
        If InventoryChk.Checked = False Then
            RemovedTileAccess += Inventory
            containsString = AddedAccess.Contains(Inventory)
            Select Case containsString
                Case True
                    indexofTileAccessCodes = AddedAccess.IndexOf(Inventory)
                    AddedAccess = AddedAccess.Remove(indexofTileAccessCodes, 3)

            End Select

        Else
            AddedAccess += Inventory

            containsString = RemovedTileAccess.Contains(Inventory)
            Select Case containsString
                Case True
                    indexofTileAccessCodes = RemovedTileAccess.IndexOf(Inventory)
                    RemovedTileAccess = RemovedTileAccess.Remove(indexofTileAccessCodes, 3)

            End Select

        End If

        MsgBox("AddedAccess: " & AddedAccess)
        MsgBox("RemovedTileAccess: " & RemovedTileAccess)


        'If InventoryChk.Checked = False Then
        '    indexofTileAccessCodes = tileAccess.IndexOf(Inventory)
        '    tileAccess = tileAccess.Remove(indexofTileAccessCodes, 3)
        'Else
        '    tileAccess += Inventory
        'End If


    End Sub

    Private Sub RequestChk_Click(sender As Object, e As EventArgs) Handles RequestChk.Click
        If RequestChk.Checked = False Then
            RemovedTileAccess += Request
            containsString = AddedAccess.Contains(Request)
            Select Case containsString
                Case True
                    indexofTileAccessCodes = AddedAccess.IndexOf(Request)
                    AddedAccess = AddedAccess.Remove(indexofTileAccessCodes, 3)

            End Select

        Else
            AddedAccess += Request

            containsString = RemovedTileAccess.Contains(Request)
            Select Case containsString
                Case True
                    indexofTileAccessCodes = RemovedTileAccess.IndexOf(Request)
                    RemovedTileAccess = RemovedTileAccess.Remove(indexofTileAccessCodes, 3)

            End Select

        End If

        MsgBox("AddedAccess: " & AddedAccess)
        MsgBox("RemovedTileAccess: " & RemovedTileAccess)

        'If RequestChk.Checked = False Then
        '    indexofTileAccessCodes = tileAccess.IndexOf(Request)
        '    tileAccess = tileAccess.Remove(indexofTileAccessCodes, 3)
        'Else
        '    tileAccess += Request
        'End If


    End Sub

    Private Sub AccessoriesChk_Click(sender As Object, e As EventArgs) Handles AccessoriesChk.Click
        If AccessoriesChk.Checked = False Then
            RemovedTileAccess += Accesories
            containsString = AddedAccess.Contains(Accesories)
            Select Case containsString
                Case True
                    indexofTileAccessCodes = AddedAccess.IndexOf(Accesories)
                    AddedAccess = AddedAccess.Remove(indexofTileAccessCodes, 3)

            End Select

        Else
            AddedAccess += Accesories

            containsString = RemovedTileAccess.Contains(Accesories)
            Select Case containsString
                Case True
                    indexofTileAccessCodes = RemovedTileAccess.IndexOf(Accesories)
                    RemovedTileAccess = RemovedTileAccess.Remove(indexofTileAccessCodes, 3)

            End Select

        End If

        MsgBox("AddedAccess: " & AddedAccess)
        MsgBox("RemovedTileAccess: " & RemovedTileAccess)

        'If AccessoriesChk.Checked = False Then
        '    indexofTileAccessCodes = tileAccess.IndexOf(Accesories)
        '    tileAccess = tileAccess.Remove(indexofTileAccessCodes, 3)
        'Else
        '    tileAccess += Accesories
        'End If


    End Sub

    Private Sub MyListChk_Click(sender As Object, e As EventArgs) Handles MyListChk.Click
        If MyListChk.Checked = False Then
            RemovedTileAccess += myList
            containsString = AddedAccess.Contains(myList)
            Select Case containsString
                Case True
                    indexofTileAccessCodes = AddedAccess.IndexOf(myList)
                    AddedAccess = AddedAccess.Remove(indexofTileAccessCodes, 3)

            End Select

        Else
            AddedAccess += myList

            containsString = RemovedTileAccess.Contains(myList)
            Select Case containsString
                Case True
                    indexofTileAccessCodes = RemovedTileAccess.IndexOf(myList)
                    RemovedTileAccess = RemovedTileAccess.Remove(indexofTileAccessCodes, 3)

            End Select

        End If

        MsgBox("AddedAccess: " & AddedAccess)
        MsgBox("RemovedTileAccess: " & RemovedTileAccess)


        'If MyListChk.Checked = False Then
        '    indexofTileAccessCodes = tileAccess.IndexOf(myList)
        '    tileAccess = tileAccess.Remove(indexofTileAccessCodes, 3)
        'Else
        '    tileAccess += myList
        'End If


    End Sub

    Private Sub SaveManageBtn_Click(sender As Object, e As EventArgs) Handles SaveManageBtn.Click
        Dim Tcode As String

        If AddedAccess <> "" Then
            For searchingTileAccess As Integer = 0 To AddedAccess.Length - 1 Step 3
                Tcode = AddedAccess.Substring(searchingTileAccess + 1, 2)
                MsgBox(ManageAccounts.userAccess & vbCrLf & Tcode & vbCrLf & ManageAccounts.UsersAutonum)
                KMDI_ACCT_ACCESS_TB_INSERT(ManageAccounts.userAccess, Tcode, "0", ManageAccounts.UsersAutonum)
            Next

        End If

        If RemovedTileAccess <> "" Then

            For searchingTileAccess As Integer = 0 To RemovedTileAccess.Length - 1 Step 3
                Tcode = RemovedTileAccess.Substring(searchingTileAccess + 1, 2)
                MsgBox(Tcode & vbCrLf & ManageAccounts.UsersAutonum)
                KMDI_ACCT_ACCESS_TB_DELETE(Tcode, ManageAccounts.UsersAutonum)
            Next

        End If

        Me.Dispose()
        ManageAccounts.Enabled = True
    End Sub

End Class