Imports System.Data.OleDb
Public Interface IntProses
    Function InsertData(Ob As Object) As OleDbCommand
    Function UpdateData(Ob As Object) As OleDbCommand
    Function DeleteData(kunci As String) As OleDbCommand
    Function TampilData() As DataView
    Function cariData(kunci As String) As DataView
End Interface
