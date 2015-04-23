Imports System
Imports System.Collections.Generic
Imports Catering.BLL.BE

Namespace Contrato
    Public Interface IPlanAtencionDAO

        Function obtenerPlanAtencion(Empresa As Integer, Sede As Integer, FechaAtencion As Date, Turno As Integer) As List(Of usp_ObtenerPlanAtencion_Result)

    End Interface

End Namespace
