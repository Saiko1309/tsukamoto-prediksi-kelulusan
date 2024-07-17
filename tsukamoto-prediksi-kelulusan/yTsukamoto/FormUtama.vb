Public Class FormUtama

    Private Sub btnPrediksi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrediksi.Click
        Dim aturans As List(Of Aturan) = New List(Of Aturan)
        Dim totalAtas As Double = 0
        Dim totalPred As Double = 0

        Dim irapor1 As Double = CDbl(Val(txtRapor1.Text))
        Dim irapor2 As Double = CDbl(Val(txtRapor2.Text))
        Dim irapor3 As Double = CDbl(Val(txtRapor3.Text))
        Dim irapor4 As Double = CDbl(Val(txtRapor4.Text))
        Dim irapor5 As Double = CDbl(Val(txtRapor5.Text))

        aturans.Add(Nothing)
        For i = 1 To 6
            Dim aturan As New Aturan(i)
            aturan.irapor1 = irapor1
            aturan.irapor2 = irapor2
            aturan.irapor3 = irapor3
            aturan.irapor4 = irapor4
            aturan.irapor5 = irapor5
            aturan.hitungSemuaAturan()

            aturans.Add(aturan)
            totalAtas += (aturans(i).pred * aturans(i).z)
            totalPred += aturans(i).z

            MsgBox(i & " " & aturans(i).pred & " " & aturans(i).z)
        Next

        Dim hasil As Double = totalAtas / totalPred

        lblHasil.Text = hasil
    End Sub

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
End Class
