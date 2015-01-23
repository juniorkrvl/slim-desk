
<Serializable>
Public Class Grupo

    Dim cl As New ClDatabase

    Sub New(IdGrupo As Integer, Grupo As String)
        Me.IdGrupo = IdGrupo
        Me.Grupo = Grupo
        'Extensoes = cl.retExtensoes(Me)
        Extensoes = New List(Of ExtensoesGrupo)
    End Sub

    Public Property IdGrupo As Integer
    Public Property Grupo As String
    Public Property Extensoes As List(Of ExtensoesGrupo)

End Class
