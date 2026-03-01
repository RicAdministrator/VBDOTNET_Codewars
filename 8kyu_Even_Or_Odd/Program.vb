Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine(EvenOrOdd(1))
    End Sub

    Public Function EvenOrOdd(ByVal number As Integer) As String
        Return If(number Mod 2 = 0, "Even", "Odd")
    End Function
End Module