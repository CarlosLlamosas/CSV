Imports System.IO
Imports iTextSharp

Imports iTextSharp.text.pdf

Public Class frmCSV
    Private Sub frmCSV_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        If OpenFileDialog1.ShowDialog Then
            dgvDatos.Columns.Clear()

            Dim Cab As String = IO.File.ReadLines(OpenFileDialog1.FileName)(0)
            Dim Col As String() = Cab.Split(";")
            dgvDatos.ColumnCount = Col.Count
            For j = 0 To Col.Count - 1
                Dim head As String() = IO.File.ReadLines(OpenFileDialog1.FileName)(0).Split(";")
                dgvDatos.Columns(j).HeaderText = head(j)
            Next

            For i = 1 To Col.Count
                Dim fila As String() = IO.File.ReadLines(OpenFileDialog1.FileName)(i).Split(";")
                dgvDatos.Rows.Add(fila)
            Next
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        SaveFileDialog1.DefaultExt = ".csv"
        If SaveFileDialog1.ShowDialog Then
            Dim cantCol As Integer = dgvDatos.Columns.Count
            Dim Cab As String = String.Empty
            For i = 0 To cantCol - 2
                Cab += dgvDatos.Columns(i).HeaderText & ";"
            Next
            Cab += dgvDatos.Columns(cantCol - 1).Name & vbCrLf
            My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, Cab, False)

            Dim cantFila As Integer = dgvDatos.Rows.Count
            Dim texto As String = String.Empty
            For a = 0 To cantFila - 2
                For b = 0 To cantCol - 2
                    texto += dgvDatos.Item(b, a).Value & ";"
                Next
                texto += dgvDatos.Item(cantCol - 1, a).Value & vbCrLf
            Next
            My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, texto, True)

            MsgBox("Archivo Guardado", MessageBoxIcon.Asterisk, MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        dgvDatos.ColumnCount = 3
        dgvDatos.Columns(2).Visible = False
        Form2.ShowDialog()
        Form2.limpiar()
    End Sub

    Private Sub btnPDF_Click(sender As Object, e As EventArgs) Handles btnPDF.Click
        If SaveFileDialog2.ShowDialog Then
            Dim ruta As String = SaveFileDialog2.FileName
            SaveFileDialog2.Filter = "Archivo pdf (*.pdf)|*.pdf"
            Dim cantFila As Integer = dgvDatos.Rows.Count

            For a = 0 To cantFila - 2
                Try
                    Dim doc As New iTextSharp.text.Document(pageSize:= )
                    Dim escr As PdfWriter = PdfWriter.GetInstance(doc, New System.IO.FileStream(ruta, System.IO.FileMode.Create))
                    escr.ViewerPreferences = PdfWriter.PageLayoutSinglePage
                    doc.Open()
                    Dim cb As PdfContentByte = escr.DirectContent
                    Dim bf As BaseFont = BaseFont.CreateFont(BaseFont.COURIER_BOLD, BaseFont.CP1252, BaseFont.NOT_EMBEDDED)
                    cb.SetFontAndSize(bf, 10)
                    cb.BeginText()
                    cb.ShowText(dgvDatos.Item(0, a).Value)
                    cb.EndText()
                    doc.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Next

        End If
    End Sub

    'Private Sub btnPDF_Click(sender As Object, e As EventArgs) Handles btnPDF.Click
    '    Dim save As SaveFileDialog
    '    save.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
    '    save.Filter = "Archivo pdf (*.pdf)|*.pdf"
    '    Dim ruta As String
    '    Dim cantFila As Integer = dgvDatos.Rows.Count

    '    If save.ShowDialog = System.Windows.Forms.DialogResult.OK Then
    '        ruta = save.FileName
    '        For a = 0 To cantFila - 2
    '            save.FileName = dgvDatos.Item(0, a).Value
    '            Try
    '                Dim document As New iTextSharp.text.Document()
    '                document.PageSize.Rotate()
    '                document.AddAuthor("Andrés Martínez")
    '                document.AddTitle("Crear pdf")
    '                Dim writer As PdfWriter = PdfWriter.GetInstance(document, New System.IO.FileStream(ruta, System.IO.FileMode.Create))
    '                writer.ViewerPreferences = PdfWriter.PageLayoutSinglePage
    '                document.Open()
    '                Dim cb As PdfContentByte = writer.DirectContent
    '                Dim bf As BaseFont = BaseFont.CreateFont(BaseFont.COURIER_BOLD, BaseFont.CP1252, BaseFont.NOT_EMBEDDED)
    '                cb.SetFontAndSize(bf, 10)
    '                cb.BeginText()

    '                cb.SetTextMatrix(50, 790)
    '                cb.ShowText("Dirigida al deudor: "(0))
    '                cb.EndText()
    '                document.Close()
    '            Catch ex As Exception
    '                MessageBox.Show("Error en la creacion de la nota", "MarioSoft", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '            End Try
    '        Next
    '    Else
    '        ruta = vbEmpty
    '        MsgBox("No existe Ruta")
    '    End If


    'End Sub


End Class
