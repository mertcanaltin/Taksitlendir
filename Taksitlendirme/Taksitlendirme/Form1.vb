Public Class Form1

    Private Sub TaksitlendirButton_Click(sender As Object, e As EventArgs) Handles TaksitlendirButton.Click
        Dim Fiyat, KDV, KDVliFiyat, TaksitTutari, ToplamOdenen As Decimal
        Dim TaksitSayisi As Byte
        Fiyat = CDec(FiyatTextBox.Text)
        KDV = CDec(KDVTextBox.Text)
        TaksitSayisi = CByte(TaksitSayisiTextBox.Text)

        KDVliFiyat = Fiyat + Fiyat * KDV
        KDVliFiyat = Math.Round(KDVliFiyat, 2)
        TaksitTutari = KDVliFiyat / TaksitSayisi

        TaksitTutari = Math.Round(TaksitTutari, 2)

        KDVliFiyatTextBox.Text = KDVliFiyat
        ToplamOdenen = TaksitTutari * TaksitSayisi
        TaksitlerListBox.Items.Clear()
        For i = 1 To TaksitSayisi
            If i = 1 Then
                TaksitlerListBox.Items.Add(TaksitTutari - (ToplamOdenen - KDVliFiyat))
            Else
                TaksitlerListBox.Items.Add(TaksitTutari)
            End If

        Next
        'ToplamOdenenLabel.Text =top
    End Sub
End Class
