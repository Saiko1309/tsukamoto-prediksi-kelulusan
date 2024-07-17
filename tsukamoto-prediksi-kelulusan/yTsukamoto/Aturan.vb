Public Class Aturan
    Public aturan() As Char = Nothing
    Public irapor1 As Double = 0
    Public irapor2 As Double = 0
    Public irapor3 As Double = 0
    Public irapor4 As Double = 0
    Public irapor5 As Double = 0
    Public frapor1 As Double = 0
    Public frapor2 As Double = 0
    Public frapor3 As Double = 0
    Public frapor4 As Double = 0
    Public frapor5 As Double = 0
    Public pred As Double = 0
    Public z As Double = 0

    Public Sub New(ByVal x As Integer)
        setAturan(x)
    End Sub

    Public Sub setAturan(ByVal x As Integer)
        Select Case x
            Case 1
                aturan = {"T", "T", "T", "T", "T", "Y"}
            Case 2
                aturan = {"R", "T", "T", "T", "T", "Y"}
            Case 3
                aturan = {"T", "R", "T", "T", "T", "Y"}
            Case 4
                aturan = {"T", "T", "R", "T", "T", "Y"}
            Case 5
                aturan = {"T", "T", "T", "R", "T", "Y"}
            Case 6
                aturan = {"T", "T", "T", "T", "R", "Y"}
        End Select
    End Sub

    Public Sub hitungSemuaAturan()
        frapor1 = hitungFuzzyInput(aturan(0), irapor1)
        frapor2 = hitungFuzzyInput(aturan(1), irapor2)
        frapor3 = hitungFuzzyInput(aturan(2), irapor3)
        frapor4 = hitungFuzzyInput(aturan(3), irapor4)
        frapor5 = hitungFuzzyInput(aturan(4), irapor5)

        pred = Math.Min(frapor1, frapor2)
        pred = Math.Min(pred, frapor3)
        pred = Math.Min(pred, frapor4)
        pred = Math.Min(pred, frapor5)

        z = hitungFuzzyOutput(aturan(5), pred)
    End Sub

    Public Function hitungFuzzyInput(ByVal anggota As Char, ByVal x As Double) As Double
        If anggota = "R" Then
            hitungFuzzyInput = raporRendah(x)
        ElseIf anggota = "T" Then
            hitungFuzzyInput = raporTinggi(x)
        End If
    End Function

    Public Function hitungFuzzyOutput(ByVal anggota As Char, ByVal x As Double) As Double
        If anggota = "N" Then
            hitungFuzzyOutput = zTLulus(x)
        ElseIf anggota = "Y" Then
            hitungFuzzyOutput = zLulus(x)
        End If
    End Function

    Private Function raporRendah(ByVal x As Double) As Double
        Select Case x
            Case Is <= 0
                raporRendah = 1
            Case Is >= 50
                raporRendah = 0
            Case 1 To 49
                raporRendah = (50 - x) / (50 - 0)
        End Select
    End Function
    Private Function raporTinggi(ByVal x As Double) As Double
        Select Case x
            Case Is <= 40
                raporTinggi = 0
            Case Is >= 100
                raporTinggi = 1
            Case 41 To 99
                raporTinggi = (x - 40) / (100 - 40)
        End Select
    End Function

    Private Function zTLulus(ByVal x As Double) As Double
        zTLulus = -(pred * (60 - 0) - 60)
    End Function
    Private Function zLulus(ByVal x As Double) As Double
        zLulus = pred * (100 - 40) + 40
    End Function
End Class
