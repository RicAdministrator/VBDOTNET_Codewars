Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine(Summation(2))
        Console.ReadKey()
    End Sub

    Public Function Summation(ByVal n As Integer) As Integer
        Dim output As Integer = 0

        For x = 1 To n
            output += x
        Next x            

        return output
    End Function
End Module
