
Module Joueur
    Public Structure Joueur
        <VBFixedString(20)> Public Nom As String
        Public NbCaseDecouverteRecord As Integer
        Public TempsRecord As Integer
        Public NbPartie As Integer
        Public TmpJoué As Integer
    End Structure
    Private MJoueurs As Hashtable = New Hashtable
    Private path As String = "TextFile.txt"
    Public Sub ajouterJoueur(nom As String, nbCase As Integer, NbPartie As Integer, tmpJoué As Integer)
        If MJoueurs.ContainsKey(nom) Then
            Exit Sub
        End If
        MJoueurs.Add(nom, creerJoueur(nbCase, NbPartie, tmpJoué, nom))
    End Sub
    Public Sub joueurJoue(nom As String, tmp As Integer, decouvert As Integer)
        Dim j As Joueur = getJoueur(nom)
        j.NbPartie += 1
        j.TmpJoué += tmp
        If decouvert > j.NbCaseDecouverteRecord Or (decouvert = j.NbCaseDecouverteRecord And j.TempsRecord > tmp) Then
            j.NbCaseDecouverteRecord = decouvert
            j.TempsRecord = tmp
        End If
        MJoueurs.Remove(nom)
        MJoueurs.Add(nom, j)
    End Sub
    Public Function getNbPartie(nom As String)
        Return getJoueur(nom).NbPartie
    End Function


    Public Function getNbCaseDecouvertes(nom As String) As Integer
        Return getJoueur(nom).NbCaseDecouverteRecord
    End Function

    Public Function getTempsTotal(nom As String) As TimeSpan
        Return TimeSpan.FromSeconds(getJoueur(nom).TmpJoué)

    End Function
    Private Function creerJoueur(nbCase As Integer, NbPartie As Integer, tmpJoué As Integer, nom As String)
        Dim player As Joueur
        player.NbCaseDecouverteRecord = nbCase
        player.NbPartie = NbPartie
        player.TmpJoué = tmpJoué
        player.Nom = nom
        Return player
    End Function


    Public Sub chargerJoueur(j As Joueur)
        MJoueurs.Add(j.Nom, j)
    End Sub


    Public Function getNomsJoueurs() As String()
        Dim tNoms(MJoueurs.Keys.Count - 1) As String
        MJoueurs.Keys.CopyTo(tNoms, 0)
        Return tNoms
    End Function

    Public Function getPath() As String
        Return path
    End Function

    Public Sub changePath(str As String)
        path = str
    End Sub

    Public Function getAlPlayers() As String
        Dim str As String = ""
        Dim tmp As Joueur
        For Each s As String In MJoueurs.Keys
            tmp = MJoueurs(s)
            str = str & s & " " & tmp.TmpJoué & Chr(10) & Chr(13)
        Next
        Return str
    End Function

    Public Function getListeJoueurs() As ArrayList
        Dim l As ArrayList = New ArrayList
        For Each s As String In MJoueurs.Keys
            l.Add(MJoueurs(s))
        Next
        Return l
    End Function
    Public Function getListeJoueurTrié() As ArrayList
        Return trierPlusGrand(getListeJoueurs())
    End Function
    Private Function trierPlusGrand(liste As ArrayList) As ArrayList
        Dim min As Integer = 0
        Dim j1 As Joueur
        Dim j2 As Joueur
        For i As Integer = 0 To liste.Count - 2
            min = i
            For j As Integer = i + 1 To liste.Count - 1
                If comparaisonJoueurs(liste, j, min) Then
                    min = j
                End If
            Next
            If Not min = i Then
                j1 = liste(i)
                j2 = liste(min)
                liste.RemoveAt(i)
                liste.RemoveAt(min - 1)
                liste.Insert(i, j2)
                liste.Insert(min, j1)
            End If
        Next
        Return liste
    End Function

    Private Function comparaisonJoueurs(liste As ArrayList, j As Integer, min As Integer) As Boolean
        Dim j1 As Joueur = liste(j)
        Dim j2 As Joueur = liste(min)
        If j1.NbCaseDecouverteRecord > j2.NbCaseDecouverteRecord Then
            Return True
        ElseIf j1.NbCaseDecouverteRecord > j2.NbCaseDecouverteRecord And j1.TmpJoué > j2.TmpJoué Then
            Return True
        End If
        Return False
    End Function

    Public Function getJoueur(nom As String)
        Return MJoueurs(nom)
    End Function
End Module
