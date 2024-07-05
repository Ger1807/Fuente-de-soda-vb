Public Class Form1
    'programamos el evento al hacer click en el boton
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btn_print.Click
        Dim Compra As New Punto(tbx_nombre.Text, tbx_apellido.Text, tbx_cedula.Text, tbx_fecha.Text, cb_nombre_item.Text, tbx_precio_item.Text)
        'mostramos la factura a travez de un message box usando vbCrLf para dar saltos de linea y "  " para dar espacios entre palabras
        MessageBox.Show("--------------------------------------------" & vbCrLf & Compra.Fecha & vbCrLf & "--------------------------------------------" & vbCrLf & Compra.Nombre & " " & Compra.Apellido & vbCrLf & "--------------------------------------------" & vbCrLf & Compra.NombreProducto & "-------------------------" & Compra.PrecioItem & vbCrLf & "--------------------------------------------" & vbCrLf & "Total:" & "                                        " & Compra.PrecioItem & vbCrLf & "--------------------------------------------")
    End Sub

End Class