
<Serializable>
Public Class Configuracao

    Public Property SulfixoNomesArquivos As String
    Public Property LimpezaAutomatica As Boolean
    Public Property ProcessarTempoReal As Boolean
    Public Property EnderecoPasta As String
    Public Property PastaOutros As Boolean

    Public Property Grupos As List(Of Grupo)


End Class
