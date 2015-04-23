Imports System
Imports System.Collections.Generic

Imports Catering.BLL.BE
Imports Catering.BLL.BL.Contrato
Imports Catering.DL.DAO.Contrato
Imports Catering.DL.DAO.Implementacion

Namespace Implementacion


    Public Class PlanAtencionBL
        Implements IPlanAtencionBL

        Private _IPlanAtencionDAO As IPlanAtencionDAO

        Public Sub New()
            _IPlanAtencionDAO = New PlanAtencionDAO
        End Sub

        Public Function obtenerPlanAtencion(Empresa As Integer, Sede As Integer, FechaAtencion As Date, Turno As Integer) As List(Of usp_ObtenerPlanAtencion_Result) Implements IPlanAtencionBL.obtenerPlanAtencion
            Return _IPlanAtencionDAO.obtenerPlanAtencion(Empresa, Sede, FechaAtencion, Turno)
        End Function


    End Class
End Namespace


