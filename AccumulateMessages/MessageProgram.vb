'Jacob Horsley
'RCET0265
'Spring 2025
'URL:https://github.com/horsjaco117/AccumulateMessages

Option Explicit On
Option Strict On

Imports System

Module MessageProgram
    Private messages As New List(Of String)() 'Stored message


    Sub Main(args As String())
        'uncomment to test interactively
        'Test.Manual()
        Test.Auto()
    End Sub

    Function UserMessages(ByVal newMessage As String, ByVal clear As Boolean) As String


        'All stored messages are deleted when clearMessage is true
        'Fulfills a few requisites of test.vb
        If clear Then
            messages.Clear()
        End If



        If Not String.IsNullOrEmpty(newMessage) AndAlso Not clear Then
            messages.Add(newMessage) 'When stuff is false it'll add message

        End If

        Return String.Join(vbNewLine, messages) & If(messages.Count > 0, vbNewLine, "")
        'The messages are stored, vbnewline is included but crossed out

    End Function


End Module
