Imports System
Imports System.Collections.Generic
Imports Catering.BLL.BE

Namespace Contrato
    Public Interface IPlatoDAO

        Function ListaPlatos(Categoria As Integer) As List(Of Plato)

    End Interface

End Namespace
