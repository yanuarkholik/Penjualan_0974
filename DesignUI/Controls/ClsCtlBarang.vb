Imports System.Data.OleDb

Public Class ClsCtlBarang : Implements IntProses
    Function kodeBaru() As String
        Dim baru As String
        Dim kodeakhir As Integer
        Try
            DTA = New OleDbDataAdapter("select max(right(kode_barang)) from Barang", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "max_kode")
            kodeakhir = Val(DTS.Tables("max_kode").Rows(0).Item(0))
            baru = "B" & Strings.Right("000" & kodeakhir + 1, 4)
            Return baru
        Catch ex As Exception
            Throw New Exception(ex.Message)

        End Try
    End Function
    Public Function InsertData(Ob As Object) As OleDbCommand Implements IntProses.InsertData
        Throw New NotImplementedException()
    End Function

    Public Function UpdateData(Ob As Object) As OleDbCommand Implements IntProses.UpdateData
        Throw New NotImplementedException()
    End Function

    Public Function DeleteData(kunci As String) As OleDbCommand Implements IntProses.DeleteData
        Throw New NotImplementedException()
    End Function

    Public Function TampilData() As DataView Implements IntProses.TampilData
        Try
            DTA = New OleDbDataAdapter("SELECT * FROM Barang", BUKAKONEKSI)

            DTS = New DataSet()
            DTA.Fill(DTS, "Tabel_Barang")
            Dim grid As New DataView(DTS.Tables("Tabel_Barang"))

            Return grid
            Throw New Exception("Ada yang salah")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            End
    End Function

    Public Function cariData(kunci As String) As DataView Implements IntProses.cariData
        Try
            DTA = New OleDbDataAdapter("select * from Barang where nama_barang" & "like '%" & kunci & "%'", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "Cari_Barang")
            Dim grid As New DataView(DTS.Tables("Cari_Barang"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Throw New NotImplementedException()
    End Function
End Class
