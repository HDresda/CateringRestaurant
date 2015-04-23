Imports System
Imports System.Collections.Generic
Imports Catering.BLL.BE

Namespace Contrato
    Public Interface IProductoDAO

        Function ListaProductos(Optional Categoria As Integer = -1) As List(Of Producto)

    End Interface

End Namespace