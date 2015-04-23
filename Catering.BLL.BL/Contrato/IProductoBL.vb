Imports System
Imports System.Collections.Generic

Imports Catering.BLL.BE

Namespace Contrato

    Public Interface IProductoBL

        Function ListaProducto(Optional Categoria As Integer = -1) As List(Of Producto)

    End Interface
End Namespace
