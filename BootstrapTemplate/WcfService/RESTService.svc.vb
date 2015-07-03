Imports System.ServiceModel
Imports System.ServiceModel.Web
Imports System.IO
Imports System.ServiceModel.Activation
Imports System.Web.Script.Serialization
Imports System.Collections.Generic


Public Class RESTService
    Implements IRESTService

    ''' <summary>
    ''' Obtener datos como xml
    ''' </summary>
    ''' <param name="id">identificador</param>
    ''' <returns>Cadena xml</returns>
    ''' <remarks></remarks>
    Public Function XMLData(ByVal id As String) As String _
        Implements IRESTService.XMLData

        Return "XML " & id

    End Function

    ''' <summary>
    ''' Obtener datos como json
    ''' </summary>
    ''' <param name="id">Identificador</param>
    ''' <returns>Cadena json</returns>
    ''' <remarks></remarks>
    Public Function JSONData(ByVal id As String) As String _
        Implements IRESTService.JSONData

        Dim json As New JavaScriptSerializer()
        Dim l As New List(Of Employee)

        Dim e As Employee
        For i As Integer = 0 To 10
            e = New Employee
            e.Id = i.ToString
            e.FirstName = i.ToString + "firstname"
            e.LastName = i.ToString + " lastname"
            l.Add(e)
        Next i

        Dim jsonMessage As String = json.Serialize(l.ToArray())
        Return jsonMessage


    End Function

End Class

