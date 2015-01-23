Public Class UserGrupo

    Sub New(NomeGrupo As String, Extensoes As List(Of ExtensoesGrupo))

        ' This call is required by the designer.
        InitializeComponent()
        lblGrupo.Text = NomeGrupo

        Dim s As String = ""
        For Each e As ExtensoesGrupo In Extensoes
            s &= e.Extensao & vbCrLf
        Next

        Dim tool As New ToolTip
        tool.SetToolTip(picExt, s)
        tool.SetToolTip(Me, s)
        tool.SetToolTip(PictureBox2, s)
        tool.SetToolTip(lblGrupo, s)

        ' Add any initialization after the InitializeComponent() call.

    End Sub

End Class
