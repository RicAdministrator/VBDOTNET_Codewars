Imports System

Module Program
    Sub Main(args As String())
        Dim stripCommentsSolution As New StripCommentsSolution()
        'Console.WriteLine(stripCommentsSolution.StripComments("apples, pears # and bananas\ngrapes\nbananas !apples", { "#", "!" }))
        ' Console.WriteLine(stripCommentsSolution.StripComments(
        '     "apples, pears" & vbLf & "grapes" & vbLf & "bananas", "apples, pears # and bananas" & vbLf & "grapes" & vbLf & "bananas !apples",
        '     New String() {"#", "!"})
        ' )

        '"apples, pears # and bananas" & vbLf & "grapes" & vbLf & "bananas !apples",
        Console.WriteLine(stripCommentsSolution.StripComments(
            "a # a" & vbLf & "grapes",
            New String() {"#", "!"}
        ))            
    End Sub

 
    Public Class StripCommentsSolution
        Public Shared Function StripComments(ByVal text As String, ByVal commentSymbols As String()) As String
            Dim newStr As String = ""
            Dim addChar As Boolean = True
            Dim commentSymbolFound As Boolean = False
            Dim myChar As Char = CChar(vbLf)

            'Console.WriteLine(text)

            For Each c As Char In text
                'Console.WriteLine(c)

                For Each commentSymbol As String In commentSymbols
                    If CStr(c) = commentSymbol Then
                        commentSymbolFound = True
                        Exit For
                    End If
                Next

                'If c = ControlChars.Cr OrElse c = ControlChars.Lf Then
                If c = Chr(13) OrElse c = Chr(10) Then
                    ' Console.WriteLine("CR or LF detected")
                    commentSymbolFound = False
                    addChar = True
                End If

                If commentSymbolFound Then
                    newStr.TrimEnd()

                    addChar = False                        
                End If 

                If addChar Then
                    ' Console.WriteLine("add char")
                    ' If c = ControlChars.Cr OrElse c = ControlChars.Lf Then

                    If c = Chr(13) Then
                        'Console.WriteLine("Adding CR")
                        newStr &= ControlChars.Cr
                    ElseIf c = Chr(10) Then
                        'Console.WriteLine("Adding LF")
                        newStr &= ControlChars.Lf    
                    Else
                        newStr &= c
                    'Console.WriteLine(c)
                    End If
                End If

                ' Console.WriteLine(c)
                ' Console.WriteLine(newStr)
                ' Console.WriteLine("------------------")

            Next
            
            Return newStr

        End Function
        
    End Class
End Module
