<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblTitulos = New System.Windows.Forms.Label()
        Me.txtCol1 = New System.Windows.Forms.TextBox()
        Me.txtCol2 = New System.Windows.Forms.TextBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitulos
        '
        Me.lblTitulos.AutoSize = True
        Me.lblTitulos.Location = New System.Drawing.Point(186, 11)
        Me.lblTitulos.Name = "lblTitulos"
        Me.lblTitulos.Size = New System.Drawing.Size(50, 17)
        Me.lblTitulos.TabIndex = 0
        Me.lblTitulos.Text = "Titulos"
        '
        'txtCol1
        '
        Me.txtCol1.Location = New System.Drawing.Point(12, 39)
        Me.txtCol1.Name = "txtCol1"
        Me.txtCol1.Size = New System.Drawing.Size(197, 22)
        Me.txtCol1.TabIndex = 1
        '
        'txtCol2
        '
        Me.txtCol2.Location = New System.Drawing.Point(215, 39)
        Me.txtCol2.Name = "txtCol2"
        Me.txtCol2.Size = New System.Drawing.Size(203, 22)
        Me.txtCol2.TabIndex = 2
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(134, 77)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 30)
        Me.btnAceptar.TabIndex = 3
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(215, 77)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 30)
        Me.btnCancelar.TabIndex = 4
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(430, 133)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.txtCol2)
        Me.Controls.Add(Me.txtCol1)
        Me.Controls.Add(Me.lblTitulos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.Text = "Titulos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulos As Label
    Friend WithEvents txtCol1 As TextBox
    Friend WithEvents txtCol2 As TextBox
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnCancelar As Button
End Class
