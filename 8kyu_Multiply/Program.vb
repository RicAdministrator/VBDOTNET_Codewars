Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine(Multiply(1, 1))
    End Sub

    Public Function Multiply(ByVal a As Integer, ByVal b As Integer) As Integer
        Return a * b
    End Function
End Module