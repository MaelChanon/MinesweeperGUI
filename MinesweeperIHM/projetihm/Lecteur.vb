Imports System.IO
Module Lecteur
    Private config(4) As Integer

    'PARTIE CONFIGURATION
    Public Sub getConfig()
        Dim num As Integer = FreeFile()
        Dim line() As String
        Dim readText() As String = File.ReadAllLines("save/config.txt")
        For i As Integer = 1 To readText.Count - 1
            line = readText(i).Split(" ")
            config(i - 1) = Convert.ToInt32(line(2))
        Next
    End Sub
    Public Function getLongueur() As Integer
        Return config(0)
    End Function
    Public Function getLargeur() As Integer
        Return config(1)
    End Function
    Public Function getNbMines() As Integer
        Return config(2)
    End Function
    Public Function getTimer() As Integer
        Return config(3)
    End Function
    Public Function getTheme() As Integer
        Return config(4)
    End Function

    Public Sub setLongueur(nb As Integer)
        config(0) = nb
    End Sub
    Public Sub setLargeur(nb As Integer)
        config(1) = nb
    End Sub
    Public Sub setNbMines(nb As Integer)
        config(2) = nb
    End Sub
    Public Sub setTimer(nb As Integer)
        config(3) = nb
    End Sub
    Public Sub setTheme(nb As Integer)
        config(4) = nb
    End Sub
    Public Sub saveConfig()
        Dim text(5) As String
        Dim num As Integer = FreeFile()
        text(0) = "ATTENTION UNE MAUVAISE CONFIGURATION PEUT MENER A UN DIFONCTIONNEMENT DU LOGICIEL"
        text(1) = "longueur : " & config(0)
        text(2) = "largeur : " & config(1)
        text(3) = "mines : " & config(2)
        text(4) = "timer : " & config(3)
        text(5) = "theme : " & config(4)
        Dim saveg As String = ""
        For Each s As String In text
            saveg = saveg & s & Chr(13)
        Next
        File.WriteAllText("save/config.txt", saveg)
    End Sub

    'PARTIE SAVEGARDE JOUEURS
    Public Sub getsave()
        Dim num As Integer = FreeFile()
        Dim j As Joueur.Joueur
        Dim i As Integer = 1
        FileOpen(num, "Sauver", OpenMode.Random, OpenAccess.Default, OpenShare.Default, Len(j))
        While Not EOF(num)
            FileGet(num, j, i)
            j.Nom = Trim(j.Nom)
            Joueur.chargerJoueur(j)
            i += 1
        End While
        FileClose()
    End Sub

    Public Sub sauvegarder()
        Dim num As Integer = FreeFile()
        Dim s As String = ""
        Dim liste As ArrayList = Joueur.getListeJoueurs
        Dim i As Integer = 1
        Dim record = Len(liste(0))
        FileOpen(num, "Sauver", OpenMode.Random, OpenAccess.Write, OpenShare.Default, record)
        For Each j As Joueur.Joueur In liste
            FilePut(num, j, i)
            i += 1
        Next
        FileClose()
    End Sub

    'PARTIE TEXTURES 
    Public Function getFakeBomb() As Image
        Select Case getTheme()
            Case 0
                Return System.Drawing.Image.FromFile("images\cases\format25\fakebomb.jpg")
            Case 1
                Return System.Drawing.Image.FromFile("images\minecraft\vrai\fakebomb.jpg")
        End Select
    End Function

    Public Function getBomb() As Image
        Select Case getTheme()
            Case 0
                Return System.Drawing.Image.FromFile("images\cases\format25\bomb.jpg")
            Case 1
                Return System.Drawing.Image.FromFile("images\minecraft\vrai\bomb.jpg")
        End Select
    End Function
    Public Function getflag() As Image
        Select Case getTheme()
            Case 0
                Return System.Drawing.Image.FromFile("images\cases\format25\flagged.jpg")
            Case 1
                Return System.Drawing.Image.FromFile("images\minecraft\vrai\flagged.jpg")
        End Select
    End Function
    Public Function getFacingDown() As Image
        Select Case getTheme()
            Case 0
                Return System.Drawing.Image.FromFile("images\cases\format25\facingDown.jpg")
            Case 1
                Return System.Drawing.Image.FromFile("images\minecraft\vrai\facingDown.jpg")
        End Select

    End Function
    Public Function get0() As Image
        Select Case getTheme()
            Case 0
                Return System.Drawing.Image.FromFile("images\cases\format25\0.jpg")
            Case 1
                Return System.Drawing.Image.FromFile("images\minecraft\vrai\0.jpg")
        End Select
    End Function
    Public Function get1() As Image
        Select Case getTheme()
            Case 0
                Return System.Drawing.Image.FromFile("images\cases\format25\1.jpg")
            Case 1
                Return System.Drawing.Image.FromFile("images\minecraft\vrai\1.jpg")
        End Select
    End Function
    Public Function get2() As Image
        Select Case getTheme()
            Case 0
                Return System.Drawing.Image.FromFile("images\cases\format25\2.jpg")
            Case 1
                Return System.Drawing.Image.FromFile("images\minecraft\vrai\2.jpg")
        End Select
    End Function
    Public Function get3() As Image
        Select Case getTheme()
            Case 0
                Return System.Drawing.Image.FromFile("images\cases\format25\3.jpg")
            Case 1
                Return System.Drawing.Image.FromFile("images\minecraft\vrai\3.jpg")
        End Select
    End Function
    Public Function get4() As Image
        Select Case getTheme()
            Case 0
                Return System.Drawing.Image.FromFile("images\cases\format25\4.jpg")
            Case 1
                Return System.Drawing.Image.FromFile("images\minecraft\vrai\4.jpg")
        End Select
    End Function
    Public Function get5() As Image
        Select Case getTheme()
            Case 0
                Return System.Drawing.Image.FromFile("images\cases\format25\5.jpg")
            Case 1
                Return System.Drawing.Image.FromFile("images\minecraft\vrai\5.jpg")
        End Select
    End Function
    Public Function get6() As Image
        Select Case getTheme()
            Case 0
                Return System.Drawing.Image.FromFile("images\cases\format25\6.jpg")
            Case 1
                Return System.Drawing.Image.FromFile("images\minecraft\vrai\6.jpg")
        End Select
    End Function
    Public Function get7() As Image
        Select Case getTheme()
            Case 0
                Return System.Drawing.Image.FromFile("images\cases\format25\7.jpg")
            Case 1
                Return System.Drawing.Image.FromFile("images\minecraft\vrai\7.jpg")
        End Select
    End Function
    Public Function get8() As Image
        Select Case getTheme()
            Case 0
                Return System.Drawing.Image.FromFile("images\cases\format25\8.jpg")
            Case 1
                Return System.Drawing.Image.FromFile("images\minecraft\vrai\8.jpg")
        End Select
    End Function
End Module
