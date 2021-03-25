Public Class Main

    Public Sub New(Numero As UInteger)
        Me.Numero = Numero
    End Sub



    Private _numero As UInteger
    Public Property Numero() As UInteger
        Get
            Return _numero
        End Get
        Set(ByVal value As UInteger)
            _numero = value
        End Set
    End Property

End Class
