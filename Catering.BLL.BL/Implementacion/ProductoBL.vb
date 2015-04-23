Imports System
Imports System.Collections.Generic

Imports Catering.BLL.BE
Imports Catering.BLL.BL.Contrato
Imports Catering.DL.DAO.Contrato
Imports Catering.DL.DAO.Implementacion

Namespace Implementacion


    Public Class ProductoBL
        Implements IProductoBL

        Private _IProductoDAO As IProductoDAO

        Public Sub New()
            _IProductoDAO = New ProductoDAO
        End Sub

        Public Function ListaProducto(Optional Categoria As Integer = -1) As List(Of Producto) Implements IProductoBL.ListaProducto
            Return _IProductoDAO.ListaProductos(Categoria)
        End Function


    End Class
End Namespace

