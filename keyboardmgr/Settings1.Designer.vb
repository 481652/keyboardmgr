﻿'------------------------------------------------------------------------------
' <auto-generated>
'     此代码由工具生成。
'     运行时版本:4.0.30319.42000
'
'     对此文件的更改可能会导致不正确的行为，并且如果
'     重新生成代码，这些更改将会丢失。
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On



<Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
 Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")>  _
Partial Friend NotInheritable Class Settings1
    Inherits Global.System.Configuration.ApplicationSettingsBase
    
    Private Shared defaultInstance As Settings1 = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New Settings1()),Settings1)
    
    Public Shared ReadOnly Property [Default]() As Settings1
        Get
            Return defaultInstance
        End Get
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("10")>  _
    Public Property clicktime() As Decimal
        Get
            Return CType(Me("clicktime"),Decimal)
        End Get
        Set
            Me("clicktime") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
    Public Property dodarkmode() As Boolean
        Get
            Return CType(Me("dodarkmode"),Boolean)
        End Get
        Set
            Me("dodarkmode") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
    Public Property doAutochange() As Boolean
        Get
            Return CType(Me("doAutochange"),Boolean)
        End Get
        Set
            Me("doAutochange") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("1")>  _
    Public Property startpage() As Integer
        Get
            Return CType(Me("startpage"),Integer)
        End Get
        Set
            Me("startpage") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("10")>  _
    Public Property sendtime() As Decimal
        Get
            Return CType(Me("sendtime"),Decimal)
        End Get
        Set
            Me("sendtime") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("键盘管家")>  _
    Public Property title() As String
        Get
            Return CType(Me("title"),String)
        End Get
        Set
            Me("title") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
    Public Property doforceclose() As Boolean
        Get
            Return CType(Me("doforceclose"),Boolean)
        End Get
        Set
            Me("doforceclose") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("10")>  _
    Public Property imgsendtime() As Decimal
        Get
            Return CType(Me("imgsendtime"),Decimal)
        End Get
        Set
            Me("imgsendtime") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
    Public Property doopendevelopingfeatures() As Boolean
        Get
            Return CType(Me("doopendevelopingfeatures"),Boolean)
        End Get
        Set
            Me("doopendevelopingfeatures") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
    Public Property dostartup() As Boolean
        Get
            Return CType(Me("dostartup"),Boolean)
        End Get
        Set
            Me("dostartup") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("1000")>  _
    Public Property listsendtime() As Decimal
        Get
            Return CType(Me("listsendtime"),Decimal)
        End Get
        Set
            Me("listsendtime") = value
        End Set
    End Property
End Class
