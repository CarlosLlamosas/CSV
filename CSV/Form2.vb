Imports CSV.frmCSV
Public Class Form2
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If (txtCol1.Text <> "") And (txtCol2.Text <> "") Then
            frmCSV.dgvDatos.Columns(0).HeaderText = txtCol1.Text.Trim
            frmCSV.dgvDatos.Columns(1).HeaderText = txtCol2.Text.Trim
            Me.Close()
        Else
            MsgBox("Datos Incompletos", MessageBoxIcon.Error, MessageBoxButtons.OK)
            limpiar()
            txtCol1.Focus()
        End If
    End Sub

    Sub limpiar()
        txtCol1.Text = ""
        txtCol2.Text = ""
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        limpiar()
        Me.Close()
    End Sub
End Class
