Public Class MDIPrincipal

#Region "Declaración de variables"

#End Region

#Region "Eventos del formulario"
    Private Sub MDIPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

   

    Private Sub btnPuntoVenta_Click_1(sender As Object, e As EventArgs) Handles btnPuntoVenta.Click
        Dim oForm As New FrmPuntoVenta

        oForm.TopLevel = False
        oForm.Parent = SplitPrincipal.Panel2
        oForm.Show()
    End Sub

#End Region

#Region "Procedimientos del formulario"

#End Region


    
    
End Class
