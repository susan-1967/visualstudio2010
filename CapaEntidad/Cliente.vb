Public Class Cliente
    Private M_IDCCLIENTE As String

    Public Property IDCCLIENTE() As String
        Get
            Return M_IDCCLIENTE
        End Get
        Set(ByVal value As String)
            M_IDCCLIENTE = value
        End Set
    End Property

    Private M_NNOMBRE As String

    Public Property NNOMBRE() As String
        Get
            Return M_NNOMBRE
        End Get
        Set(ByVal value As String)
            M_NNOMBRE = value
        End Set
    End Property

    Private M_TELEFONO As String

    Public Property TELEFONO() As String
        Get
            Return M_TELEFONO
        End Get
        Set(ByVal value As String)
            M_TELEFONO = value
        End Set
    End Property





End Class
