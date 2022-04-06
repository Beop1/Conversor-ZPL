Imports System.IO
Imports iText.Kernel.Pdf
Imports iText.Kernel.Utils

Module API_PDF

    Public Function Merge_PDF_Files(ByVal input_files As List(Of String), ByVal output_file As String) As Boolean
        Dim Input_Document As PdfDocument = Nothing
        Dim Output_Document As PdfDocument = Nothing
        Dim Merger As PdfMerger

        Try
            Output_Document = New iText.Kernel.Pdf.PdfDocument(New iText.Kernel.Pdf.PdfWriter(output_file))
            'Create the output file (Document) from a Merger stream
            Merger = New PdfMerger(Output_Document)

            'Merge each input PDF file to the output document
            For Each file As String In input_files
                Input_Document = New PdfDocument(New PdfReader(file))
                Merger.Merge(Input_Document, 1, Input_Document.GetNumberOfPages())
                Input_Document.Close()
            Next

            Output_Document.Close()
            Return True
        Catch ex As Exception
            'catch Exception if needed
            If Input_Document IsNot Nothing Then Input_Document.Close()
            If Output_Document IsNot Nothing Then Output_Document.Close()
            File.Delete(output_file)

            Return False
        End Try
    End Function



End Module
