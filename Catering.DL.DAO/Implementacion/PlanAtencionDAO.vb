Imports System
Imports System.Collections.Generic
Imports Catering.DL.DAO.Contrato
Imports Catering.DL.DAO.Core

Imports Catering.BLL.BE

Namespace Implementacion
    
    Public Class PlanAtencionDAO
        Inherits DataBase : Implements IPlanAtencionDAO

        Public Function obtenerPlanAtencion(Empresa As Integer, Sede As Integer, FechaAtencion As Date, Turno As Integer) As List(Of usp_ObtenerPlanAtencion_Result) Implements IPlanAtencionDAO.obtenerPlanAtencion

            Using dbContexto As CateringEntities = New CateringEntities()
                Return dbContexto.usp_ObtenerPlanAtencion(Empresa, Sede, FechaAtencion, Turno).ToList()
            End Using

        End Function
    End Class

End Namespace

