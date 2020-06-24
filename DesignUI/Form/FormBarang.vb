Public Class FormBarang
    Dim modeProses As Integer
    Dim baris As Integer
    Private Sub AturButton(st As Boolean)
        BtnTambah.Enabled = st
        BtnUbah.Enabled = st
        BtnDelete.Enabled = st
        BtnSimpan.Enabled = Not st
        BtnBatal.Enabled = Not st


        GroupBox1.Enabled = Not st
        GroupBox3.Enabled = st
        GroupBox4.Enabled = st
    End Sub
    Private Sub IsiBox(br As Integer)
        If br < DTGrid.Rows.Count Then
            With DGBarang.Rows(br)
                TxtKdBrg.Text = .Cells(0).Value.ToString
                TxtNmBrg.Text = .Cells(0).Value.ToString
                TxtHrgBrg.Text = .Cells(0).Value.ToString
                TxtStok.Text = .Cells(0).Value.ToString
            End With
            LblBaris.Text = "Data ke-" & br + 1 & " dari " & DGBarang.RowCount - 1 & " data "
        End If
    End Sub
    Private Sub RefreshGrid()
        DTGrid = KontrolBarang.TampilData.ToTable
        DGBarang.DataSource = DTGrid

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGBarang.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGBarang.CurrentCell = DGBarang.Item(1, baris)
            AturButton(True)
            IsiBox(baris)
        End If

    End Sub
    Private Sub TampilCari(kunci As String)
        DTGrid = KontrolBarang.cariData(kunci).ToTable

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGBarang.DataSource = DTGrid
            DGBarang.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGBarang.CurrentCell = DGBarang.Item(1, baris)
            IsiBox(baris)
        Else
            MsgBox("Data tidak ditemukan")
            RefreshGrid()
        End If

    End Sub
    Private Sub FormBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call RefreshGrid()
        TxtKdBrg.Enabled = False
    End Sub
    Private Sub BtnSelesai_Click(sender As Object, e As EventArgs) Handles BtnSelesai.Click
        Me.Close()
    End Sub
    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        AturButton(False)
        modeProses = 1

    End Sub
    Private Sub BtnUbah_Click(sender As Object, e As EventArgs) Handles BtnUbah.Click

    End Sub
    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        RefreshGrid()
        AturButton(True)
        modeProses = 0
    End Sub
    Private Sub DGBarang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGBarang.CellClick
        If modeProses = 0 Then
            baris = e.RowIndex
            DGBarang.Rows(baris).Selected = True
            IsiBox(baris)
        End If
    End Sub
    Private Sub BtnAkhir_Click(sender As Object, e As EventArgs) Handles BtnLast.Click
        DGBarang.ClearSelection()
        baris = 0
        DGBarang.Rows(baris).Selected = True
        IsiBox(baris)
    End Sub
    Private Sub BtnCari_CLick(sender As Object, e As EventArgs) Handles BtnCari.Click
        If TxtCari.Text = "" Then
            Call Refresh()
        Else
            Call TampilCari(TxtCari.Text)
            TxtCari.Focus()
        End If
    End Sub
End Class
