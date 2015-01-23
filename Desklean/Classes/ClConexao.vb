Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Data.SQLite

Public Class ClConexao

    Dim cx As String = "" 'connectionString
    Dim conexao As SQLiteConnection
    ' Dim comando As SqlCommand

    Private Sub conectar()

        Try
            cx = sConn
            conexao = New SQLiteConnection(cx)

        Catch ex As Exception
            Throw ex
            'conexao = New SqlConnection(DeCifra(My.Settings.StringConexao))
            MsgBox(ex.Message)
        End Try

        Try

            conexao.Open()
        Catch ex As Exception
            System.Threading.Thread.Sleep(1500)
            conexao.Open()

        End Try


    End Sub

    Protected Function _Incluir(ByVal sql As SQLiteCommand) As Integer
        Try
            conectar()
            sql.Connection = conexao

            Dim retorno As Integer = sql.ExecuteScalar
            'retorno = 0 ' conexao.LastInsertRowId()
            conexao.Close()
            Return retorno

        Catch ex As Exception
            Throw ex
            MsgBox(ex.Message, False, ex)
            conexao.Close()
            Return 0
        End Try

    End Function

    Protected Function _Alterar(ByVal sql As SQLiteCommand) As Boolean
        Try
            conectar()
            sql.Connection = conexao
            sql.ExecuteNonQuery()
            conexao.Close()
            Return True
        Catch ex As SqlException
            Throw ex
            If ex.Number = 547 Then
                MsgBox("Este item não pode ser excluído pois possui dependentes.")
            Else
                MsgBox(ex.Message, False, ex)
            End If

            conexao.Close()
            Return False
        End Try

    End Function


    Protected Function _Retorna(ByVal sql As SQLiteCommand, Optional ByVal index As Integer = 0) As DataTable

        Try
            conectar()
            sql.Connection = conexao
            Dim DA As SQLiteDataAdapter = New SQLiteDataAdapter(sql)
            Dim ds As DataSet = New DataSet
            DA.Fill(ds, "tabela")
            Dim dt As DataTable = New DataTable
            dt = ds.Tables(index)
            DA = Nothing
            conexao.Close()
            Return dt
        Catch ex As Exception
            Throw ex
            MsgBox(ex.Message, False, ex)
            conexao.Close()
            Return New DataTable
        End Try
    End Function

    Protected Overrides Sub Finalize()
        If Not IsNothing(conexao) AndAlso conexao.State <> ConnectionState.Closed Then
            Try
                conexao.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
        MyBase.Finalize()
    End Sub
End Class

