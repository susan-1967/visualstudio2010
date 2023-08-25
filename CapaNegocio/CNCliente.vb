Public Class CNCliente
    Public Function listar() As DataTable
        '-1 :ERROR
        '0:NO ENCONTRO
        '1:ENCONTRO
        Dim OK As Integer = 0
        Dim Dt As DataTable
        Try
            Dim cli As New CapaDatos.CDCliente
            Dt = cli.listar()
            Return Dt
        Catch ex As Exception
            'OK = -1
        End Try
        Return Nothing
    End Function

End Class
