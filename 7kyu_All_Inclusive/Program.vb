Imports System
Imports System.Collections.Generic

Module Program
    Sub Main(args As String())
        Dim myList As New List(Of String) From {"bsjq", "qbsj", "sjqb", "twZNsslC", "jqbs"}
        Dim aaa As Boolean = ContainAllRots("bsjq", myList)

        Console.WriteLine(aaa)
        Console.ReadKey()
    End Sub

    Public Function ContainAllRots(ByVal s As String, ByVal arr As List(Of String)) As Boolean
        Dim combinations As New List(Of String)
        Dim listEntry As String = ""
        Dim suffix As String = ""

        For x = 0 To s.Length - 1

            For y = x To s.Length - 1
                listEntry &= s.Chars(y)
            Next y

            listEntry = listEntry & suffix

            If Not arr.Contains(listEntry) Then
                return False
            End If

            combinations.Add(listEntry)
            suffix &= listEntry.Chars(0)
            listEntry = ""

        Next x
        
        Return True
    End Function    
End Module
