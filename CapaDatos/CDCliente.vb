Public Class CDCliente
    Public Function listar() As DataTable
        '-1 :ERROR
        '0:NO ENCONTRO
        '1:ENCONTRO
        Dim OK As Integer = 0
        Dim Dt As New DataTable
        Try
            'Dim xCadena As String = "SELECT COUNT(ID_RENE) AS TOTAL FROM CBM_RE_SOLICITUD " _
            '                      & " WHERE ID_RENE=" & _ID_RENEGOCIACION & " AND ID_DRENE=" & _ID_DRENE & " AND ID_CRITE =" & _ID_CRITE
            '_Cadena = xCadena
            'Dt = Ejecutar_DL()
            'If CInt(Dt.Rows(0)("TOTAL").ToString) = 0 Then
            '    OK = 0
            'Else
            '    OK = 1
            'End If
            Dt.Columns.Add("M_IDCCLIENTE", GetType(String))
            Dt.Columns.Add("M_NNOMBRE", GetType(String))
            Dt.Columns.Add("M_TELEFONO", GetType(String))

            ' Add five rows with those columns filled in the DataTable.
            Dt.Rows.Add("101231", "Pedro tamayo", "10")
            Dt.Rows.Add("101232", "Richar Duran", "50")
            Dt.Rows.Add("101233", "Carlos Manu", "51")
            Dt.Rows.Add("101234", "Ricardo Laos", "52")
            Dt.Rows.Add("101235", "Luis Raur", "11")
            Return Dt

        Catch ex As Exception
            OK = -1
        End Try
        Return Nothing
    End Function
End Class
