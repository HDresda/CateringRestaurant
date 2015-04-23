Imports System
Imports System.Collections.Generic
Imports Catering.DL.DAO.Contrato
Imports Catering.DL.DAO.Core

Imports Catering.BLL.BE

Namespace Implementacion


    Public Class PlatoDAO
        Inherits DataBase : Implements IPlatoDAO

        Public Function ListaPlatos(Categoria As Integer) As List(Of Plato) Implements IPlatoDAO.ListaPlatos

            Using dbContexto As CateringEntities = New CateringEntities()
                Return dbContexto.Plato.AsNoTracking.ToList().Where(Function(p) p.id_Categoria_Plato = Categoria).ToList()
            End Using

        End Function
    End Class

End Namespace
