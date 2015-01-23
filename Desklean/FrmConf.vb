Imports System.IO

Public Class FrmConf

    Dim cl As New ClDatabase
    Dim grupos As New List(Of Grupo)

    Private Sub FrmConf_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblText.Text = Me.Text

        grupos = cl.retGrupos

        For Each g As Grupo In grupos
            Dim u As New UserGrupo(g.Grupo, g.Extensoes)
            flGrupos.Controls.Add(u)
        Next

        txtSulfixo.Text = config.SulfixoNomesArquivos

        'Limpeza em Tempo Real
        rdTempoRealAtivado.Checked = config.ProcessarTempoReal
        rdTempoRealDesativado.Checked = Not config.ProcessarTempoReal

        'Limpeza Automática
        rdLimpezaAtivado.Checked = config.LimpezaAutomatica
        rdLimpezaDesativado.Checked = Not config.LimpezaAutomatica

        'Processar arquivos na pasta outros
        rdOutrosAtivado.Checked = config.PastaOutros
        rdOutrosDesativado.Checked = Not config.PastaOutros

    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Serialize(Path.GetDirectoryName(Application.ExecutablePath) & "\config.desk", config)
        Me.Close()
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub rdOutrosAtivado_CheckedChanged(sender As Object, e As EventArgs) Handles rdOutrosAtivado.CheckedChanged

        If rdOutrosAtivado.Checked = True Then
            config.PastaOutros = True
        Else
            config.PastaOutros = False
        End If

    End Sub

End Class