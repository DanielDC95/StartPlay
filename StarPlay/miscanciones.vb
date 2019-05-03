Public Class miscanciones
    Dim wnombre As String
    Dim wruta As String




    Public Property pnombre As String
        Get
            Return wnombre
        End Get
        Set(ByVal value As String)
            wnombre = value
        End Set
    End Property

    Public Property pruta As String
        Get
            Return wruta
        End Get
        Set(ByVal value As String)
            wruta = value
        End Set
    End Property
End Class