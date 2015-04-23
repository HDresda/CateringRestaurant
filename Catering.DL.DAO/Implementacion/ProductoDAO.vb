Imports System
Imports System.Collections.Generic
Imports Catering.DL.DAO.Contrato
Imports Catering.DL.DAO.Core

Imports Catering.BLL.BE

Namespace Implementacion


    Public Class ProductoDAO
        Inherits DataBase : Implements IProductoDAO

        Public Function ListaProductos(Optional Categoria As Integer = -1) As List(Of Producto) Implements IProductoDAO.ListaProductos

            Using dbContexto As CateringEntities = New CateringEntities()
                If Categoria = -1 Then
                    Return dbContexto.Producto.AsNoTracking.ToList()
                Else
                    Return dbContexto.Producto.AsNoTracking.ToList().Where(Function(p) p.id_Categoria_Producto = Categoria).ToList()
                End If

            End Using

        End Function
    End Class

End Namespace
