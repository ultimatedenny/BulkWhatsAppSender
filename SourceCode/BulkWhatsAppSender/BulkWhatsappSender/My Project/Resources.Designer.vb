﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("BulkWhatsappSender.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to (function(){var StatusCode={STALE_ELEMENT_REFERENCE:10,UNKNOWN_ERROR:13,};var NodeType={ELEMENT:1,DOCUMENT:9,};var ELEMENT_KEY=&apos;ELEMENT&apos;;var w3cEnabled=!1;var SHADOW_DOM_ENABLED=typeof ShadowRoot===&apos;function&apos;;function generateUUID(){var array=new Uint8Array(16);window.crypto.getRandomValues(array);array[6]=0x40|(array[6]&amp;0x0f);array[8]=0x80|(array[8]&amp;0x3f);var UUID=&quot;&quot;;for(var i=0;i&lt;16;i++){var temp=array[i].toString(16);if(temp.length&lt;2)
        '''temp=&quot;0&quot;+temp;UUID+=temp;if(i==3||i==5||i==7||i==9)
        '''UUID+=&quot;-&quot;}
        '''retu [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property JavaScriptInject() As String
            Get
                Return ResourceManager.GetString("JavaScriptInject", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to document.getElementsByClassName(&quot;ZP8RM&quot;)[0].innerHTML=&quot;&lt;a href=&apos;#&apos; id=&apos;sender&apos; class=&apos;executor&apos;&gt;.&lt;/a&gt;&quot;.
        '''</summary>
        Friend ReadOnly Property JsExec() As String
            Get
                Return ResourceManager.GetString("JsExec", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property logo() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("logo", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &lt;!DOCTYPE html&gt;
        '''&lt;!-- saved from url=(0089)file:///C:/Users/khillo_baz/Desktop/New%20folder%20(7)/WindowsApplication1/UpgradeLog.htm --&gt;
        '''&lt;html xmlns:msxsl=&quot;urn:schemas-microsoft-com:xslt&quot;&gt;
        '''   &lt;head&gt;
        '''      &lt;meta http-equiv=&quot;Content-Type&quot; content=&quot;text/html; charset=UTF-16LE&quot;&gt;
        '''      &lt;meta content=&quot;en-us&quot; http-equiv=&quot;Content-Language&quot;&gt;
        '''      &lt;title _locid=&quot;ConversionReport0&quot;&gt;
        '''         Bulk WhatsApp Sender - Report
        '''      &lt;/title&gt;
        '''      &lt;style&gt; 
        '''         /* Body style, for the entire document */
        '''       [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property Report() As String
            Get
                Return ResourceManager.GetString("Report", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property Screenshot_4() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Screenshot_4", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to (function() { // Copyright (c) 2012 The Chromium Authors. All rights reserved.
        '''// Use of this source code is governed by a BSD-style license that can be
        '''// found in the LICENSE file.
        '''
        '''/**
        ''' * Enum for WebDriver status codes.
        ''' * @enum {number}
        ''' */
        '''var StatusCode = {
        '''  STALE_ELEMENT_REFERENCE: 10,
        '''  UNKNOWN_ERROR: 13,
        '''};
        '''
        '''/**
        ''' * Enum for node types.
        ''' * @enum {number}
        ''' */
        '''var NodeType = {
        '''  ELEMENT: 1,
        '''  DOCUMENT: 9,
        '''};
        '''
        '''/**
        ''' * Dictionary key to use for holding an element ID.
        ''' * @const
        ''' [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property test() As String
            Get
                Return ResourceManager.GetString("test", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to /**
        ''' * This script contains WAPI functions that need to be run in the context of the webpage
        ''' */
        '''
        '''/**
        ''' * Auto discovery the webpack object references of instances that contains all functions used by the WAPI
        ''' * functions and creates the Store object.
        ''' */
        '''if (!window.Store) {
        '''    (function () {
        '''        function getStore(modules) {
        '''            let foundCount = 0;
        '''            let neededObjects = [
        '''                { id: &quot;Store&quot;, conditions: (module) =&gt; (module.Chat &amp;&amp; module.Msg) ? module : null }, [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property WhatsAppApi() As String
            Get
                Return ResourceManager.GetString("WhatsAppApi", resourceCulture)
            End Get
        End Property
    End Module
End Namespace
