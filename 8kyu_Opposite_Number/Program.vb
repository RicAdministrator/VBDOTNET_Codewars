Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine(Number(1))
        Console.ReadKey()
    End Sub

    Public Function Number(ByVal num As Double)
        Return If(num < 0, Math.Abs(num), -Math.Abs(num))
    End Function
End Module
