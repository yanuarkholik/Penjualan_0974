﻿Imports System.Data.OleDb
Module ModKoneksiDB
    Public DTR As OleDbDataReader
    Public CMD As New OleDbCommand
    Public DTA As New OleDbDataAdapter
    Public DTS As New DataSet
    Public DTT As New DataTable
    Public DTGrid As New DataTable
    Public strKon = "Provider=SQLNCLI11;Integrated Security=SSPI;Data Source=DESKTOP-II560R6\SQLEXPRESS;Initial Catalogue=Penjualan"

    Public koneksi As New OleDbConnection(strKon)
    Public Function BUKAKONEKSI() As OleDbConnection
        Try
            If koneksi.State = ConnectionState.Closed Then koneksi.Open()
        Catch ex As Exception

        End Try
        Return koneksi
    End Function
    Public Function TUTUPKONEKSI() As OleDbConnection
        koneksi.Close()
        Return koneksi
    End Function
End Module
