
<Serializable>
Public Class ClDatabase

    Function retConf() As Configuracao
        Return New Configuracao
    End Function

    Function retGrupos() As List(Of Grupo)

        Dim lista As New List(Of Grupo)

        Dim g As New Grupo(1, "Documentos")
        g.Extensoes.Add(New ExtensoesGrupo("pdf"))
        g.Extensoes.Add(New ExtensoesGrupo("doc"))
        g.Extensoes.Add(New ExtensoesGrupo("docx"))
        g.Extensoes.Add(New ExtensoesGrupo("xls"))
        g.Extensoes.Add(New ExtensoesGrupo("xlsx"))
        g.Extensoes.Add(New ExtensoesGrupo("txt"))
        g.Extensoes.Add(New ExtensoesGrupo("rtf"))
        g.Extensoes.Add(New ExtensoesGrupo("csv"))
        g.Extensoes.Add(New ExtensoesGrupo("log"))

        lista.Add(g)

        g = New Grupo(2, "Imagens")
        g.Extensoes.Add(New ExtensoesGrupo("jpg"))
        g.Extensoes.Add(New ExtensoesGrupo("jpeg"))
        g.Extensoes.Add(New ExtensoesGrupo("png"))
        g.Extensoes.Add(New ExtensoesGrupo("gif"))
        g.Extensoes.Add(New ExtensoesGrupo("psd"))
        g.Extensoes.Add(New ExtensoesGrupo("ico"))
        g.Extensoes.Add(New ExtensoesGrupo("ai"))

        lista.Add(g)

        g = New Grupo(3, "Zips")
        g.Extensoes.Add(New ExtensoesGrupo("rar"))
        g.Extensoes.Add(New ExtensoesGrupo("zip"))
        g.Extensoes.Add(New ExtensoesGrupo("7zip"))
        g.Extensoes.Add(New ExtensoesGrupo("7z"))

        lista.Add(g)

        g = New Grupo(4, "DLLs")
        g.Extensoes.Add(New ExtensoesGrupo("dll"))
        g.Extensoes.Add(New ExtensoesGrupo("apk"))

        lista.Add(g)

        g = New Grupo(5, "Databases")
        g.Extensoes.Add(New ExtensoesGrupo("sql"))
        g.Extensoes.Add(New ExtensoesGrupo("s3db"))

        lista.Add(g)

        g = New Grupo(6, "Setups")
        g.Extensoes.Add(New ExtensoesGrupo("exe"))
        g.Extensoes.Add(New ExtensoesGrupo("msi"))

        lista.Add(g)

        g = New Grupo(7, "Web")
        g.Extensoes.Add(New ExtensoesGrupo("html"))
        g.Extensoes.Add(New ExtensoesGrupo("css"))

        lista.Add(g)


        Return lista
    End Function

End Class
