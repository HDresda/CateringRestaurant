Imports System.Windows.Forms
Imports System.Drawing

Public Class ButtonBase
    Inherits System.Windows.Forms.Button

    Public Sub New()

        Me.TextAlign = Drawing.ContentAlignment.BottomCenter
        Me.Width = 105
        Me.Height = 112
        Me.Font = New Drawing.Font("Microsoft Sans Serif", 10, Drawing.FontStyle.Bold)
        Me.ImageAlign = Drawing.ContentAlignment.TopCenter
        Me.BackColor = Color.FromArgb(8, 20, 40)


    End Sub
End Class
