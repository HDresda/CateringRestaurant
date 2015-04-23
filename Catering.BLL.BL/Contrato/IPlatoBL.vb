Imports System
Imports System.Collections.Generic

Imports Catering.BLL.BE

Namespace Contrato

    Public Interface IPlatoBL

        Function ListaPlatos(Categoria As Integer) As List(Of Plato)

    End Interface
End Namespace
