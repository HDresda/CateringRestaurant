Imports System
Imports System.Collections.Generic

Imports Catering.BLL.BE
Imports Catering.BLL.BL.Contrato
Imports Catering.DL.DAO.Contrato
Imports Catering.DL.DAO.Implementacion

Namespace Implementacion


    Public Class PlatoBL
        Implements IPlatoBL

        Private _IPlatoDAO As IPlatoDAO

        Public Sub New()
            _IPlatoDAO = New PlatoDAO
        End Sub

        Public Function ListaPlatos(Categoria As Integer) As List(Of Plato) Implements IPlatoBL.ListaPlatos
            Return _IPlatoDAO.ListaPlatos(Categoria)
        End Function


    End Class
End Namespace
