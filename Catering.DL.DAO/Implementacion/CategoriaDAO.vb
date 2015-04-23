
Imports System
Imports System.Collections.Generic
Imports Catering.DL.DAO.Contrato
Imports Catering.DL.DAO.Core

Imports Catering.BLL.BE

Namespace Implementacion

    Public Class CategoriaDAO
        Inherits DataBase : Implements ICategoriaDAO

        Public Function ListaCategorias() As List(Of Categoria) Implements ICategoriaDAO.ListaCategorias


            Using db As CateringEntities = New CateringEntities()
                Return db.Categoria.ToList()
            End Using

        End Function

    End Class

End Namespace