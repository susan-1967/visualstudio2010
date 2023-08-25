Public Class _Default
    Inherits System.Web.UI.Page
    Dim servidor As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim dt As New CapaNegocio.CNCliente
        Me.GridView1.DataSource = dt.listar
        Me.GridView1.DataBind()
    End Sub
    Public Function codigo() As String

        If Not servidor Is Nothing AndAlso Not servidor.Equals(String.Empty) Then
            servidor = "exitoso"
        End If

        Dim O_MONE As String = IIf(servidor = "NUEVOS SOLES", "SOL", "DOL")

        Return "hola mundo"
    End Function
End Class