﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código fue generado por una herramienta.
'     Versión de runtime:4.0.30319.42000
'
'     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
'     se vuelve a generar el código.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'StronglyTypedResourceBuilder generó automáticamente esta clase
    'a través de una herramienta como ResGen o Visual Studio.
    'Para agregar o quitar un miembro, edite el archivo .ResX y, a continuación, vuelva a ejecutar ResGen
    'con la opción /str o recompile su proyecto de VS.
    '''<summary>
    '''  Clase de recurso fuertemente tipado, para buscar cadenas traducidas, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Class Recurso3
        
        Private Shared resourceMan As Global.System.Resources.ResourceManager
        
        Private Shared resourceCulture As Global.System.Globalization.CultureInfo
        
        <Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")>  _
        Friend Sub New()
            MyBase.New
        End Sub
        
        '''<summary>
        '''  Devuelve la instancia de ResourceManager almacenada en caché utilizada por esta clase.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Shared ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("UI.Recurso3", GetType(Recurso3).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Reemplaza la propiedad CurrentUICulture del subproceso actual para todas las
        '''  búsquedas de recursos mediante esta clase de recurso fuertemente tipado.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Shared Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Busca una cadena traducida similar a Alta.
        '''</summary>
        Friend Shared ReadOnly Property Button1() As String
            Get
                Return ResourceManager.GetString("Button1", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Busca una cadena traducida similar a Modificacion.
        '''</summary>
        Friend Shared ReadOnly Property Button2() As String
            Get
                Return ResourceManager.GetString("Button2", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Busca una cadena traducida similar a Eliminar.
        '''</summary>
        Friend Shared ReadOnly Property Button3() As String
            Get
                Return ResourceManager.GetString("Button3", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Busca una cadena traducida similar a Verificar Regex.
        '''</summary>
        Friend Shared ReadOnly Property Button4() As String
            Get
                Return ResourceManager.GetString("Button4", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Busca una cadena traducida similar a ABM viaje.
        '''</summary>
        Friend Shared ReadOnly Property GroupBox1() As String
            Get
                Return ResourceManager.GetString("GroupBox1", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Busca una cadena traducida similar a Codigo Viaje.
        '''</summary>
        Friend Shared ReadOnly Property Label1() As String
            Get
                Return ResourceManager.GetString("Label1", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Busca una cadena traducida similar a Codigo Cliente.
        '''</summary>
        Friend Shared ReadOnly Property Label2() As String
            Get
                Return ResourceManager.GetString("Label2", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Busca una cadena traducida similar a Codigo Destino.
        '''</summary>
        Friend Shared ReadOnly Property Label3() As String
            Get
                Return ResourceManager.GetString("Label3", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Busca una cadena traducida similar a Fecha.
        '''</summary>
        Friend Shared ReadOnly Property Label4() As String
            Get
                Return ResourceManager.GetString("Label4", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Busca una cadena traducida similar a Dias.
        '''</summary>
        Friend Shared ReadOnly Property Label5() As String
            Get
                Return ResourceManager.GetString("Label5", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Busca una cadena traducida similar a Precio.
        '''</summary>
        Friend Shared ReadOnly Property Label6() As String
            Get
                Return ResourceManager.GetString("Label6", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Busca una cadena traducida similar a Tipo.
        '''</summary>
        Friend Shared ReadOnly Property Label7() As String
            Get
                Return ResourceManager.GetString("Label7", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Busca una cadena traducida similar a Primero = 10 x km     Economica = 5 x km.
        '''</summary>
        Friend Shared ReadOnly Property Label8() As String
            Get
                Return ResourceManager.GetString("Label8", resourceCulture)
            End Get
        End Property
    End Class
End Namespace
