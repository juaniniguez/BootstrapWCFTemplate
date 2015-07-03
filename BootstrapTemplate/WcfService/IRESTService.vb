Imports System.ServiceModel
Imports System.ServiceModel.Web
Imports System.IO
Imports System.ServiceModel.Activation


<ServiceContract()>
Public Interface IRESTService

    <OperationContract()> _
    <WebInvoke(Method:="GET", ResponseFormat:=WebMessageFormat.Xml, BodyStyle:=WebMessageBodyStyle.Wrapped, UriTemplate:="xml/{id}")> _
    Function XMLData(ByVal id As String) As String


    <OperationContract()> _
    <WebInvoke(Method:="GET", ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare, UriTemplate:="json/{id}")> _
    Function JSONData(ByVal id As String) As String


End Interface



