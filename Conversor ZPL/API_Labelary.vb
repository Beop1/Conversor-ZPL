Imports System.IO
Imports System.Net
Imports System.Text

Module API_Labelary
    Public Enum labelary_formats
        PNG
        PDF
        Stream
    End Enum

    Structure struct_dimensoes_etiqueta
        Dim DPI As String
        Dim largura As Decimal
        Dim altura As Decimal
        Dim unidade As String
    End Structure

    Public Function Converter_ZPL_para_Stream(s As String, dimensoes As struct_dimensoes_etiqueta) As Stream
        Return Converter_ZPL(s:=s, formato:=labelary_formats.Stream, dimensoes:=dimensoes)
    End Function

    Public Function Converter_ZPL_para_Stream(s As String, pagina As Integer, dimensoes As struct_dimensoes_etiqueta) As Stream
        Return Converter_ZPL(s:=s, formato:=labelary_formats.Stream, dimensoes:=dimensoes, pagina:=pagina)
    End Function

    Public Function Converter_ZPL_para_PDF(s As String, arquivo As String, dimensoes As struct_dimensoes_etiqueta) As Boolean
        If Converter_ZPL(s:=s, formato:=labelary_formats.PDF, dimensoes:=dimensoes, arquivo:=arquivo) IsNot Nothing Then Return True Else Return False

    End Function

    Public Function Converter_ZPL_para_PNG(s As String, arquivo As String, dimensoes As struct_dimensoes_etiqueta) As Boolean
        If Converter_ZPL(s:=s, formato:=labelary_formats.PNG, dimensoes:=dimensoes, arquivo:=arquivo, pagina:=0) IsNot Nothing Then Return True Else Return False
    End Function


    'Usa a API do labelary.com
    ' Referência API Libelary: http://labelary.com/service.html#vbnet
    ' Referência linguagem ZPL: https://www.zebra.com/content/dam/zebra/manuals/printers/common/programming/zpl-zbi2-pm-en.pdf

    Public Function Converter_ZPL(s As String, formato As labelary_formats, dimensoes As struct_dimensoes_etiqueta, Optional arquivo As String = "", Optional pagina As Integer = -1) As Stream

        Dim DPIs() As Integer
        Dim DPI As Integer
        Dim W As Decimal
        Dim H As Decimal
        Dim zpl() As Byte
        Dim request As HttpWebRequest
        Dim response As HttpWebResponse
        Dim responseStream As Stream
        Dim requestStream As Stream



        DPIs = {6, 8, 12, 24}
        DPI = DPIs(dimensoes.DPI)
        W = dimensoes.largura
        H = dimensoes.altura

        Select Case dimensoes.unidade
            Case "mm"
                W = W / 25.4
                H = H / 25.4
            Case "cm"
                W = W / 2.54
                H = H / 2.54
        End Select
        W = Math.Round(W, 4)
        H = Math.Round(H, 4)

        zpl = Encoding.UTF8.GetBytes(Replace(Replace(s, vbLf, ""), vbCr, ""))

        request = WebRequest.Create(
            "http://api.labelary.com/v1/printers/" & DPI & "dpmm/labels/" &
            Replace(W.ToString(), ",", ".") & "x" &
            Replace(H.ToString(), ",", ".") & "/" & If(pagina <> -1, pagina & "/", ""))
        request.Method = "POST"
        If formato = labelary_formats.PDF Then
            request.Accept = "application/pdf"
        Else

        End If
        request.ContentType = "application/x-www-form-urlencoded"
        request.ContentLength = zpl.Length
        'request.Timeout = 5

        requestStream = request.GetRequestStream()
        requestStream.Write(zpl, 0, zpl.Length)
        requestStream.Close()

        Try
            response = request.GetResponse()
            responseStream = response.GetResponseStream()

            If formato <> labelary_formats.Stream Then
                Dim fileStream As Stream
                fileStream = File.Create(arquivo)
                responseStream.CopyTo(fileStream)
                responseStream.Close()
                fileStream.Close()
            End If
            Return responseStream
        Catch exc As WebException
            MsgBox("Erro: " & exc.Message & vbNewLine & exc.Message.ToString())
        Catch exc As Exception
            MsgBox("Erro: " & exc.Message & vbNewLine & exc.Message.ToString())
        End Try
        Return Nothing
    End Function
End Module
