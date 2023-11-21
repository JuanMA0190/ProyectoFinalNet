Imports System.Data.OleDb
Imports System.Data



Public Class frm_Reporte
    'Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    Dim connDB As New OleDbConnection
    '    Dim oDataAdapter As OleDbDataAdapter
    '    Dim oDataSet As New DataSet
    '    Dim exists As Boolean
    '    Dim cmd, con, base As String
    '    Dim fileReader As System.IO.StreamReader
    '    exists = System.IO.File.Exists(My.Application.Info.DirectoryPath & "\base.wel")
    '    If exists = False Then
    '        frmBuscarBase.Show()
    '    Else
    '        fileReader = My.Computer.FileSystem.OpenTextFileReader(My.Application.Info.DirectoryPath & "\base.wel")
    '        Dim stringReader As String
    '        stringReader = fileReader.ReadLine()
    '        base = stringReader
    '        Try
    '            con = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & base
    '            connDB = New OleDbConnection(con)
    '            ''''***
    '            connDB.Open()
    '            cmd = "SELECT * FROM Clientes ORDER BY Id_Clientes ASC"
    '            oDataAdapter = New OleDbDataAdapter(cmd, connDB)
    '            oDataSet.Clear()
    '            oDataAdapter.Fill(oDataSet, "Clientes")
    '            If (oDataSet.Tables("Clientes").Rows.Count() <> 0) Then
    '                Dim i As Integer
    '                For i = 0 To oDataSet.Tables("Clientes").Rows.Count - 1
    '                    lstView.Items.Add(oDataSet.Tables("Clientes").Rows(i)("Id_Clientes"))
    '                    lstView.Items(i).SubItems.Add(oDataSet.Tables("Clientes").Rows(i)("Nomb_Cli"))
    '                    lstView.Items(i).SubItems.Add(oDataSet.Tables("Clientes").Rows(i)("Ape_Cli"))
    '                    lstView.Items(i).SubItems.Add(oDataSet.Tables("Clientes").Rows(i)("Dni_Cli"))
    '                    lstView.Items(i).SubItems.Add(oDataSet.Tables("Clientes").Rows(i)("Sexo_Cli"))
    '                    lstView.Items(i).SubItems.Add(oDataSet.Tables("Clientes").Rows(i)("FechaNac_Cli"))
    '                    lstView.Items(i).SubItems.Add(oDataSet.Tables("Clientes").Rows(i)("Tel_Cli"))
    '                    lstView.Items(i).SubItems.Add(oDataSet.Tables("Clientes").Rows(i)("Direcc_Cli"))
    '                    lstView.Items(i).SubItems.Add(oDataSet.Tables("Clientes").Rows(i)("Estado_Cli"))
    '                    lstView.Items(i).SubItems.Add(oDataSet.Tables("Clientes").Rows(i)("FechaReg_Cli"))
    '                    lstView.Items(i).SubItems.Add(oDataSet.Tables("Clientes").Rows(i)("HoraReg_Cli"))
    '                Next
    '            End If
    '            connDB.Close()

    '        Catch ea As Exception
    '            MsgBox("Error. Contacte al servicio técnico.", vbCritical, "Error")
    '            connDB.Close()
    '        End Try
    '    End If

    'End Sub

    'Private Sub cmdPrint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdPrint.Click
    '    If lstView.Items.Count > 0 Then
    '        PrintDocument1.Print()
    '        MsgBox("Pdf creado Correctamente")
    '    Else
    '        MsgBox("Agregar datos a la lista.", vbCritical, "Error")
    '    End If
    'End Sub


    'Private Sub PrintDocument1_PrintPage(ByVal sender As Object, ByVal e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
    '    Dim i, m, idcli As Integer
    '    Dim nomcli, apecli, dnicli, telcli, direcli, estado, sexo, fechaNac, fechaReg, HorReg As String
    '    For i = 0 To lstView.Items.Count - 1
    '        If i = 0 Then
    '            m = 140
    '            Dim prFon = New Font("Arial", 25, FontStyle.Underline)
    '            e.Graphics.DrawString("Compra Superior S.R.L", prFon, Brushes.YellowGreen,
    '           250, 30)
    '            Dim prFonttt = New Font("Arial", 13, FontStyle.Underline)
    '            e.Graphics.DrawString("Lista de Clientes", prFonttt, Brushes.OliveDrab,
    '           360, 80)
    '            Dim prFont = New Font("Arial", 10, FontStyle.Bold)
    '            e.Graphics.DrawString("Nombre", prFont, Brushes.Black, 10, 110)
    '            e.Graphics.DrawString("Apellido", prFont, Brushes.Black, 80, 110)
    '            e.Graphics.DrawString("DNI", prFont, Brushes.Black, 175, 110)
    '            e.Graphics.DrawString("Sexo", prFont, Brushes.Black, 260, 110)
    '            e.Graphics.DrawString("Fecha Nac.", prFont, Brushes.Black, 330, 110)
    '            e.Graphics.DrawString("Telefono", prFont, Brushes.Black, 433, 110)
    '            e.Graphics.DrawString("Dirección", prFont, Brushes.Black, 520, 110)
    '            e.Graphics.DrawString("Estado", prFont, Brushes.Black, 615, 110)
    '            e.Graphics.DrawString("Fecha Reg.", prFont, Brushes.Black, 675, 110)
    '            e.Graphics.DrawString("Hora Reg.", prFont, Brushes.Black, 767, 110)
    '            ''''
    '            idcli = lstView.Items.Item(0).Text
    '            nomcli = lstView.Items(i).SubItems(1).Text
    '            apecli = lstView.Items(i).SubItems(2).Text
    '            dnicli = lstView.Items(i).SubItems(3).Text
    '            sexo = lstView.Items(i).SubItems(4).Text
    '            fechaNac = lstView.Items(i).SubItems(5).Text
    '            telcli = lstView.Items(i).SubItems(6).Text
    '            direcli = lstView.Items(i).SubItems(7).Text
    '            estado = lstView.Items(i).SubItems(8).Text
    '            fechaReg = lstView.Items(i).SubItems(9).Text
    '            HorReg = lstView.Items(i).SubItems(10).Text

    '            Dim prFontt = New Font("Arial", 9, FontStyle.Regular)
    '            e.Graphics.DrawString(nomcli, prFontt, Brushes.Black, 10, m)
    '            e.Graphics.DrawString(apecli, prFontt, Brushes.Black, 80, m)
    '            e.Graphics.DrawString(dnicli, prFontt, Brushes.Black, 170, m)
    '            e.Graphics.DrawString(sexo, prFontt, Brushes.Black, 250, m)
    '            e.Graphics.DrawString(fechaNac, prFontt, Brushes.Black, 334, m)
    '            e.Graphics.DrawString(telcli, prFontt, Brushes.Black, 430, m)
    '            e.Graphics.DrawString(direcli, prFontt, Brushes.Black, 517, m)
    '            e.Graphics.DrawString(estado, prFontt, Brushes.Black, 615, m)
    '            e.Graphics.DrawString(fechaReg, prFontt, Brushes.Black, 677, m)
    '            e.Graphics.DrawString(HorReg, prFontt, Brushes.Black, 780, m)
    '        Else
    '            If (i = 0) Or (i > 0) Then
    '                m = m + 30
    '                idcli = lstView.Items.Item(0).Text
    '                nomcli = lstView.Items(i).SubItems(1).Text
    '                apecli = lstView.Items(i).SubItems(2).Text
    '                dnicli = lstView.Items(i).SubItems(3).Text
    '                sexo = lstView.Items(i).SubItems(4).Text
    '                fechaNac = lstView.Items(i).SubItems(5).Text
    '                telcli = lstView.Items(i).SubItems(6).Text
    '                direcli = lstView.Items(i).SubItems(7).Text
    '                estado = lstView.Items(i).SubItems(8).Text
    '                fechaReg = lstView.Items(i).SubItems(9).Text
    '                HorReg = lstView.Items(i).SubItems(10).Text

    '                Dim prFontt = New Font("Arial", 9, FontStyle.Regular)
    '                e.Graphics.DrawString(nomcli, prFontt, Brushes.Black, 10, m)
    '                e.Graphics.DrawString(apecli, prFontt, Brushes.Black, 80, m)
    '                e.Graphics.DrawString(dnicli, prFontt, Brushes.Black, 170, m)
    '                e.Graphics.DrawString(sexo, prFontt, Brushes.Black, 250, m)
    '                e.Graphics.DrawString(fechaNac, prFontt, Brushes.Black, 334, m)
    '                e.Graphics.DrawString(telcli, prFontt, Brushes.Black, 430, m)
    '                e.Graphics.DrawString(direcli, prFontt, Brushes.Black, 517, m)
    '                e.Graphics.DrawString(estado, prFontt, Brushes.Black, 615, m)
    '                e.Graphics.DrawString(fechaReg, prFontt, Brushes.Black, 677, m)
    '                e.Graphics.DrawString(HorReg, prFontt, Brushes.Black, 780, m)
    '            End If
    '        End If
    '        e.HasMorePages = False
    '    Next i
    'End Sub

    'Private Sub btt_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btt_Salir.Click
    '    frm_Principal.Show()
    '    Me.Close()
    'End Sub
End Class