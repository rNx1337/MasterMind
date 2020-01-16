Public Class form1

    Private chave As String 'Permite guardar a chave gerada

    Function Verificar(ByVal ch As String, ByVal t As String) As String
        Dim aCh(3) As Char
        Dim aT(3) As Char
        Dim i, j As Integer
        Dim stV As String = ""
        'Preencher arrays com o cars das string
        For i = 0 To 3
            aCh(i) = ch(i)
            aT(i) = t(i)
        Next
        'Procurar P's (caracteres iguais na mesma posicao relativa

        For i = 0 To 3
            If aCh(i) = aT(i) Then
                stV = stV & "P"
                aCh(i) = "?"
                aT(i) = "@"
            End If
        Next

        'Procurar B's (cars iguais em posicao diferente)

        For i = 0 To 3
            If aCh(i) = "?" Then Continue For
            For j = 0 To 3
                If aCh(i) = aT(j) Then
                    stV = stV & "B"
                    aT(j) = "@"
                    Exit For
                End If
            Next
        Next
        Return stV
    End Function

    Sub GerarChave(ByRef ch As String)
        Dim i As Integer
        ch = ""
        For i = 1 To 4
            ch = ch & Int(Rnd() * 6) + 1
        Next
    End Sub

    Private Sub form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cbt1.SelectedIndex = 0
        cbt2.SelectedIndex = 0
        cbt3.SelectedIndex = 0
        cbt4.SelectedIndex = 0
        Randomize()
    End Sub

    Private Sub butnova_Click(sender As System.Object, e As System.EventArgs) Handles butnova.Click
        GerarChave(chave)
        txtchave.Text = chave 'Isto e só para testar 
    End Sub

    Private Sub butverificar_Click(sender As System.Object, e As System.EventArgs) Handles butverificar.Click
        Dim tenta As String
        tenta = cbt1.Text & cbt2.Text & cbt3.Text & cbt4.Text
        txtverificacao.Text = Verificar(chave, tenta)
    End Sub
End Class
