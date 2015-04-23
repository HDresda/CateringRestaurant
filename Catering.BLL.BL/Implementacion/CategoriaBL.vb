Imports System
Imports System.Collections.Generic

Imports Catering.BLL.BE
Imports Catering.BLL.BL.Contrato
Imports Catering.DL.DAO.Contrato
Imports Catering.DL.DAO.Implementacion

Namespace Implementacion


    Public Class CategoriaBL
        Implements ICategoriaBL

        Private _ICategoriaDAO As ICategoriaDAO

        Public Sub New()
            _ICategoriaDAO = New CategoriaDAO
        End Sub

        Public Function ListaCategorias() As List(Of Categoria) Implements ICategoriaBL.ListaCategorias
            Return _ICategoriaDAO.ListaCategorias()
        End Function


    End Class
End Namespace
