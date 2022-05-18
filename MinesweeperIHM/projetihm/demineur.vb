Public Class demineur
    Private longueur As Integer
    Private largeur As Integer
    Private Tmines(0) As Integer
    Private Tdecouvert As ArrayList
    Private Tmarqué As ArrayList

    Public Sub New(largeur As Integer, longueur As Integer, mine As Integer)
        Me.longueur = longueur
        Me.largeur = largeur
        ReDim Tmines(mine - 1)
        initMines(Me.largeur * Me.longueur, mine)
        Tdecouvert = New ArrayList
        Tmarqué = New ArrayList
    End Sub

    Private Sub initMines(max As Integer, nbMines As Integer)
        Dim r As Random = New Random
        Dim save As Integer
        Dim randomNumber As Integer
        Dim tab(max - 1)
        For i As Integer = 0 To nbMines - 1
            tab(i) = 1
        Next
        For i As Integer = 0 To 10 * max
            randomNumber = r.Next(0, max)
            save = tab(i Mod max)
            tab(i Mod max) = tab(randomNumber)
            tab(randomNumber) = save
        Next
        save = 0
        For i As Integer = 0 To max - 1
            If tab(i) = 1 Then
                Tmines(save) = i
                save += 1
            End If
        Next
    End Sub

    Public Function isBomb(nb As Integer) As Boolean
        Return Tmines.Contains(nb)
    End Function

    Public Function getTmines() As Integer()
        Return Tmines.Clone()
    End Function
    Public Sub decouvrir(nb As Integer)
        If Not Tdecouvert.Contains(nb) Then
            Tdecouvert.Add(nb)
        End If
    End Sub
    Public Function getCasesNearby(nb As Integer) As ArrayList

        Dim x As Integer = nb Mod longueur
        Dim y As Integer = nb \ longueur
        Dim list As ArrayList = New ArrayList
        For i As Integer = -1 To 1
            For j As Integer = -1 To 1
                If x + j >= 0 And y + i >= 0 And x + j < longueur And y + i < largeur Then
                    list.Add((y + i) * longueur + (x + j))
                End If
            Next
        Next
        Return list
    End Function
    Public Function isWin() As Boolean
        Return Tdecouvert.Count = (longueur * largeur - Tmines.Count)
    End Function
    Public Function getNbBombesNearby(list As ArrayList) As Integer
        Dim nbBombe As Integer = 0
        For Each i As Integer In list
            If Tmines.Contains(i) Then
                nbBombe += 1
            End If
        Next
        Return nbBombe
    End Function

    Public Function getLongueur() As Integer
        Return longueur
    End Function

    Public Function getLargeur() As Integer
        Return largeur
    End Function

    Public Sub marquer(val As Integer)
        Tmarqué.Add(val)
    End Sub
    Public Sub enleverMarquer(val As Integer)
        Tmarqué.Remove(val)
    End Sub
    Public Function marquévalide() As Boolean
        Dim tmp As ArrayList = New ArrayList
        For Each i As Integer In Tmarqué
            If Not Tmines.Contains(i) Then
                Return False
            End If
        Next
        Return True
    End Function

    Public Function getVraiMarqués() As ArrayList
        Dim lst As ArrayList = New ArrayList
        For Each i As Integer In Tmarqué
            If Tmines.Contains(i) Then
                lst.Add(i)
            End If
        Next
        Return lst
    End Function
    Public Function getCaseLibre() As Integer
        Dim r As New Random
        Dim lstrand As ArrayList = New ArrayList
        Dim position As Integer = 0
        For i As Integer = 0 To longueur * largeur - 1
            If Tdecouvert.Contains(i) Then
                position = caseDécouvrable(i)
                If Not position = -1 Then
                    Return position
                End If
            End If
            If Not ((Tmines.Contains(i)) Or Tdecouvert.Contains(i)) Then
                lstrand.Add(i)
            End If
        Next
        Return lstrand(r.Next(0, lstrand.Count))
    End Function

    Public Function getDrapeauClickable() As Integer
        Dim position As Integer = -1
        For i As Integer = 0 To longueur * largeur - 1
            If Tdecouvert.Contains(i) Then
                position = caseMarquable(i)

                If Not position = -1 Then
                    Return position
                End If
            End If
        Next
        Return -1
    End Function
    Private Function caseDécouvrable(val As Integer) As Integer

        Dim mineAutours As Integer = 0
        Dim position As Integer = -1
        Dim tpostion As ArrayList = getCasesNearby(val)
        Dim tVraiMarqué = getVraiMarqués()

        For Each i As Integer In tpostion
            If tVraiMarqué.Contains(i) Then
                mineAutours += 1
            ElseIf Not Tdecouvert.Contains(i) Then
                position = i
            End If
        Next
        If getNbBombesNearby(tpostion) = tpostion.Count - mineAutours Then
            Return position
        Else
            Return -1
        End If
    End Function

    Private Function caseMarquable(val As Integer) As Integer
        Dim tpostion As ArrayList = getCasesNearby(val)
        Dim nbMarqués As Integer = 0
        Dim position As Integer = -1
        Dim tVraiMarqué = getVraiMarqués()

        For Each i As Integer In getCasesNearby(val)
            If tVraiMarqué.Contains(i) Then
                nbMarqués += 1
            ElseIf Not Tdecouvert.Contains(i) Then
                position = i
            End If
        Next
        If getNbBombesNearby(tpostion) - nbMarqués = 1 Then
            Return position
        End If
        Return -1
    End Function

    Public Function getTmarqués() As ArrayList
        Return Tmarqué
    End Function

    Public Function getNbCaseDécouvertes() As Integer
        Return Tdecouvert.Count
    End Function

End Class
