Public Class Form1

    Private Property angka1 As Double
    Private Property angka2 As Double
    Private Property operasi As Char

    Private Sub Inputan(x As Char, pindah As Boolean)
        Txt1.Text = Txt1.Text + x
        If pindah Then
            angka1 = Val(Txt1.Text)
        Else
            angka2 = Val(Txt1.Text)
        End If
    End Sub

    Private Sub B1_Click(sender As System.Object, e As System.EventArgs) Handles B1.Click
        Txt1.Text = Txt1.Text + "1"
        angka1 = Val(Txt1.Text)
    End Sub

    Private Sub B2_Click(sender As System.Object, e As System.EventArgs) Handles B2.Click
        Txt1.Text = Txt1.Text + "2"
        angka1 = Val(Txt1.Text)
    End Sub

    Private Sub B3_Click(sender As System.Object, e As System.EventArgs) Handles B3.Click
        Txt1.Text = Txt1.Text + "3"
        angka1 = Val(Txt1.Text)
    End Sub

    Private Sub B4_Click(sender As System.Object, e As System.EventArgs) Handles B4.Click
        Txt1.Text = Txt1.Text + "4"
        angka1 = Val(Txt1.Text)
    End Sub

    Private Sub B5_Click(sender As System.Object, e As System.EventArgs) Handles B5.Click
        Txt1.Text = Txt1.Text + "5"
        angka1 = Val(Txt1.Text)
    End Sub

    Private Sub B6_Click(sender As System.Object, e As System.EventArgs) Handles B6.Click
        Txt1.Text = Txt1.Text + "6"
        angka1 = Val(Txt1.Text)
    End Sub

    Private Sub B7_Click(sender As System.Object, e As System.EventArgs) Handles B7.Click
        Txt1.Text = Txt1.Text + "7"
        angka1 = Val(Txt1.Text)
    End Sub

    Private Sub B8_Click(sender As System.Object, e As System.EventArgs) Handles B8.Click
        Txt1.Text = Txt1.Text + "8"
        angka1 = Val(Txt1.Text)
    End Sub

    Private Sub B9_Click(sender As System.Object, e As System.EventArgs) Handles B9.Click
        Txt1.Text = Txt1.Text + "9"
        angka1 = Val(Txt1.Text)
    End Sub

    Private Sub B0_Click(sender As System.Object, e As System.EventArgs) Handles B0.Click
        Txt1.Text = Txt1.Text + "0"
        angka1 = Val(Txt1.Text)
    End Sub

    Private Sub B00_Click(sender As System.Object, e As System.EventArgs) Handles B00.Click
        Txt1.Text = Txt1.Text + "00"
        angka1 = Val(Txt1.Text)
    End Sub

    Private Sub Bdot_Click(sender As System.Object, e As System.EventArgs) Handles Bdot.Click
        Dim at As Integer
        If Txt1.Text <> "" Then
            at = Txt1.Text.LastIndexOfAny(".")
            If at = -1 Then
                Txt1.Text = Txt1.Text + "."
            End If
        Else
            Txt1.Text = Txt1.Text + "0."
        End If
        angka1 = Val(Txt1.Text)
        
    End Sub

    Private Sub BDif_Click(sender As System.Object, e As System.EventArgs) Handles BDif.Click
        Txt1.Text = ""
        If angka1 <> 0 And angka2 = 0 Then
            angka2 = angka1
            angka1 = 0
        End If
        operasi = "/"
    End Sub

    Private Sub Button20_Click(sender As System.Object, e As System.EventArgs) Handles Button20.Click
        Select Case operasi
            Case "/" : angka2 = angka2 / angka1
            Case "*" : angka2 = angka2 * angka1
            Case "-" : angka2 = angka2 - angka1
            Case "+" : angka2 = angka2 + angka1
            Case "Mo" : angka2 = angka2 Mod angka1
            Case Else : angka2 = 0
        End Select
        angka1 = 0
        Txt1.Text = angka2
    End Sub

    Private Sub BMul_Click(sender As System.Object, e As System.EventArgs) Handles BMul.Click
        Txt1.Text = ""
        If angka1 <> 0 And angka2 = 0 Then
            angka2 = angka1
            angka1 = 0
        End If
        operasi = "*"
    End Sub

    Private Sub BMin_Click(sender As System.Object, e As System.EventArgs) Handles BMin.Click
        Txt1.Text = ""
        If angka1 <> 0 And angka2 = 0 Then
            angka2 = angka1
            angka1 = 0
        End If
        operasi = "-"
    End Sub

    Private Sub BPlu_Click(sender As System.Object, e As System.EventArgs) Handles BPlu.Click
        Txt1.Text = ""
        If angka1 <> 0 And angka2 = 0 Then
            angka2 = angka1
            angka1 = 0
        End If
        operasi = "+"
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Txt1.Text = ""
        If angka1 <> 0 And angka2 = 0 Then
            angka2 = angka1
            angka1 = 0
        End If
        operasi = "Mo"
    End Sub

    Private Sub Button15_Click(sender As System.Object, e As System.EventArgs) Handles Button15.Click
        Txt1.Text = ""
        angka1 = 0
        angka2 = 0
    End Sub

    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        If Txt1.Text <> "" Then
            Txt1.Text = Txt1.Text.Substring(0, Txt1.Text.Length - 1)
        End If
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Txt1.Text = ""
    End Sub
End Class
