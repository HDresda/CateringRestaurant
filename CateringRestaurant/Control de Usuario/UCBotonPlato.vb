
Public Class UCBotonPlato
#Region "Propiedasdes"

    Private _Categoria As Integer
    Private _IdPlato As Integer
    Private _NombrePlato As String
    Private _ImagenPlato As String
    Private _PrecioVenta As Double
    Private _Cantidad As Integer

    Public Property IdPlato() As Integer
        Get
            Return _IdPlato
        End Get
        Set(ByVal value As Integer)
            _IdPlato = value
        End Set
    End Property

    Public Property NombrePlato() As String
        Get
            Return _NombrePlato
        End Get
        Set(ByVal value As String)
            _NombrePlato = value
        End Set
    End Property

    Public Property ImagenPlato() As String
        Get
            Return _ImagenPlato
        End Get
        Set(ByVal value As String)
            _ImagenPlato = value
        End Set
    End Property

    Public Property Categoria() As Integer
        Get
            Return _Categoria
        End Get
        Set(ByVal value As Integer)
            _Categoria = value
        End Set
    End Property

    Public Property PrecioVenta() As Double
        Get
            Return _PrecioVenta
        End Get
        Set(ByVal value As Double)
            _PrecioVenta = value
        End Set
    End Property

    Public Property Cantidad() As Integer
        Get
            Return _Cantidad
        End Get
        Set(ByVal value As Integer)
            _Cantidad = value
        End Set
    End Property

#End Region

    Public Shadows Event UCBotonPlato_Click As EventHandler


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub


    Public Sub onActualizarTitulo()
        btnItem.Text = NombrePlato & vbCrLf & "Cantidad:" & Cantidad & vbCrLf & "Precio:S/." & PrecioVenta.ToString("#0.0")
    End Sub

    Private Sub btnItem_Click(sender As Object, e As EventArgs) Handles btnItem.Click
        RaiseEvent UCBotonPlato_Click(Me, e)
    End Sub
End Class
