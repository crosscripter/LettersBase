Module Module1

    Public Function ToLetters(ByVal Value As Integer) As String
        Const Base As Integer = 26
        Dim ModNum As Integer = 0
        Dim Letters As String = String.Empty

        While Value > 0
            ModNum = (Value - 1) Mod Base
            Letters = Chr(65 + ModNum) + Letters
            Value = (Value - ModNum) / Base
        End While

        Return Letters
    End Function

    Sub Main()
        Console.WriteLine(ToLetters(Integer.MaxValue))
    End Sub
End Module
