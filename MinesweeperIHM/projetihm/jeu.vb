#Disable Warning BC42104 ' La variable est utilisée avant de se voir attribuer une valeur
Public Class jeu
    Private Const button_Widht As Integer = 25
    Private Const button_Height As Integer = 25
    Private plateau As demineur 'plateau de jeu
    Private duration As Double
    Private fini As Boolean = False 'permet de mettre en pause le timer

    Private animation As Button 'animation cible le bouton à animer, et cas représente l'animation à faire
    Private cas As cases
    Private Sub jeu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initParam()
        initTimers(sender, e)
    End Sub
    '----------------------------------Initalisation de la fenetre-------------------------------------
    Private Sub initParam()
        fini = Lecteur.getTimer = -1
        animation = Nothing
        duration = Lecteur.getTimer
        LabelNom.Text = Lancement.ComboBoxJoueurs.Text
        initPlateau(Lecteur.getLongueur, Lecteur.getLargeur)
        plateau = New demineur(Lecteur.getLargeur, Lecteur.getLongueur, Lecteur.getNbMines)
        If Lecteur.getTimer = -1 Then
            Me.Text = "Demineur"
        End If
    End Sub

    Private Sub placerElem()
        Me.Width = PanelPlateau.Width + 100
        Me.Height = PanelPlateau.Height + 200
        Me.MaximumSize = New Size(Me.Width, Me.Height)
        Me.MinimumSize = New Size(Me.Width, Me.Height)

        ButtonAide.Location = New Point(PanelPlateau.Location.X, PanelPlateau.Location.Y - 50)
        ButtonAbandon.Location = New Point(PanelPlateau.Location.X + PanelPlateau.Width - ButtonAbandon.Width, PanelPlateau.Location.Y - 50)
    End Sub
    Private Function get_button()
        Dim btn As New Button
        btn.Padding = New Padding(0)
        btn.Margin = New Padding(0)
        btn.Width = button_Widht
        btn.Height = button_Height
        btn.ImageAlign = ContentAlignment.MiddleCenter
        btn.FlatStyle = FlatStyle.Flat
        setBackground(btn, cases.caché)
        btn.FlatAppearance.BorderSize = 0
        AddHandler btn.MouseDown, AddressOf CliqueSurCase
        Return btn
    End Function
    Private Sub initPlateau(longueur As Integer, largueur As Integer)
        PanelPlateau.Width = longueur * button_Widht
        PanelPlateau.Height = largueur * button_Height
        placerElem()
        Dim location As New Point(0, 0)
        Dim btn As Button
        For i As Integer = 0 To largueur - 1
            For j As Integer = 0 To longueur - 1
                btn = get_button()
                btn.Name = i * longueur + j
                btn.Location = New Point(location.X, location.Y)
                PanelPlateau.Controls.Add(btn)

                location.X += btn.Width
            Next
            location.Y += btn.Height
            location.X = 0
        Next
    End Sub

    '-------------------------------HORLOGE----------------------------------
    Private Sub initTimers(sender As Object, e As EventArgs)
        monTimer.Interval = 1000
        monTimer.Start()

        TimerAffichage.Interval = 500
        afficheHeure(sender, e)
        animationCase(sender, e)
    End Sub
    Private Sub afficheHeure(sender As System.Object, e As System.EventArgs) Handles monTimer.Tick
        If fini Then 'Mise en pause du timer
            Exit Sub
        End If
        duration -= 1
        Me.Text = TimeSpan.FromSeconds(duration).ToString
        If duration = 0 Then
            msgFin("partie perdue, temps écoulé")
            fermer()
        End If
    End Sub
    '-----------------Animation se déclanche si le joueur demande de l'aide------------------
    Private Sub animationCase(sender As System.Object, e As System.EventArgs) Handles TimerAffichage.Tick
        'Premier cas = cases révélée clignotante
        If cas = cases.caché Then
            Select Case animation.Tag
                Case cases.case0
                    setBackground(animation, cases.caché)
                Case cases.caché
                    setBackground(animation, cases.case0)
            End Select
            'Deuxième cas = drapeau clignotant
        ElseIf cas = cases.flag Then
            Select Case animation.Tag
                Case cases.caché
                    setBackground(animation, cases.flag)
                Case cases.flag
                    setBackground(animation, cases.caché)
            End Select
        End If

    End Sub

    Private Sub terminerAnimation()
        TimerAffichage.Stop()
        setBackground(animation, cases.caché)
        animation = Nothing
        cas = Nothing
    End Sub

    '-----------------------Fonctionnement du jeu------------------------
    Private Sub CliqueSurCase(sender As Object, e As MouseEventArgs)
        If TypeOf sender Is Button Then
            Dim btn As Button = sender
            If animation IsNot Nothing Then
                terminerAnimation()
            End If
            If e.Button = System.Windows.Forms.MouseButtons.Right Then
                If Not activé(btn) Then
                    Exit Sub
                End If
                'Clique droit sur une case cachée donne un drapeau
                If btn.Tag = cases.caché Then
                    setBackground(btn, cases.flag)
                    plateau.marquer(Convert.ToInt32(btn.Name))
                Else
                    'dans le cas contraire cela significe que l'on démarqué 
                    plateau.enleverMarquer(Convert.ToInt32(btn.Name))
                    setBackground(btn, cases.caché)
                End If
                'condition de defaite = case déminé est un mine, drapeau marqué non valide,
            ElseIf ((plateau.isBomb(Convert.ToInt32(btn.Name)) Or Not plateau.marquévalide()) And btn.Tag = cases.caché) OrElse (animation IsNot Nothing And cas = cases.caché) Then
                revelerMines()
                msgFin("perdu")
                fermer()
            ElseIf btn.Tag = cases.caché Then
                Dim test As ArrayList = New ArrayList()
                test.Add(Convert.ToInt32(btn.Name))
                While Not test.Count = 0
                    determiner(test)
                End While
            End If

        End If
        If plateau.isWin() Then
            msgFin("bien joué tu as gagné avant le temps imparti.")
            fermer()
        End If
    End Sub

    Private Sub revelerMines()
        For Each i As Integer In plateau.getTmines()
            setBackground(PanelPlateau.Controls.Item(i), cases.bomb)
        Next
        Dim tvraiMarqué As ArrayList = plateau.getVraiMarqués()
        For Each i As Integer In plateau.getTmarqués
            If Not tvraiMarqué.Contains(i) Then
                setBackground(PanelPlateau.Controls.Item(i), cases.fakebomb)
            End If
        Next
    End Sub
    Private Sub determiner(tab As ArrayList)
        plateau.decouvrir(tab(0))
        Dim list As ArrayList = plateau.getCasesNearby(tab(0))
        Dim nbBombe As Integer = plateau.getNbBombesNearby(list)
        Dim btn As Button = PanelPlateau.Controls.Item(tab(0))
        If nbBombe > 0 Then
            setBackground(btn, nbBombe)

        Else
            setBackground(btn, cases.case0)
            ajouterCases(tab, list)
        End If
        tab.RemoveAt(0)
    End Sub

    Private Sub ajouterCases(tab As ArrayList, tab2 As ArrayList)
        For Each element As Integer In tab2
            If activé(PanelPlateau.Controls.Item(element)) And Not tab.Contains(element) Then
                tab.Add(element)
            End If
        Next
    End Sub

    Private Function activé(btn As Button) As Boolean
        Return btn.Tag = cases.caché Or btn.Tag = cases.flag
    End Function
    Private Sub ButtonAbandon_Click(sender As Object, e As EventArgs) Handles ButtonAbandon.Click
        fini = True
        If MsgBox("êtes-vous sûr de vouloir abandonner?", vbYesNo) = vbYes Then
            msgFin("perdu")
            fermer()
            Exit Sub
        End If
        fini = False
    End Sub
    Private Sub reinitCase()
        Me.MaximumSize = New Size(0, 0)
        Me.MinimumSize = New Size(0, 0)
        PanelPlateau.Controls.Clear()

    End Sub

    Private Sub fermer()
        Joueur.joueurJoue(Lancement.ComboBoxJoueurs.Text, getDuration(), plateau.getNbCaseDécouvertes())
        reinitCase()
        Me.Close()
        Lancement.Show()
    End Sub

    Private Function getDuration() As Integer
        If duration < 0 Then
            Return TimeSpan.FromSeconds(-duration + 1).TotalSeconds
        Else
            Return Lecteur.getTimer() - TimeSpan.FromSeconds(duration).TotalSeconds
        End If
    End Function


    Private Sub ButtonAide_Click(sender As Object, e As EventArgs) Handles ButtonAide.Click
        Dim position = plateau.getDrapeauClickable()
        If position = -1 Then
            animation = PanelPlateau.Controls.Item(plateau.getCaseLibre())
            cas = cases.caché
        Else
            animation = PanelPlateau.Controls.Item(position)
            setBackground(animation, cases.flag)
            cas = cases.flag
        End If
        TimerAffichage.Start()
    End Sub

    Private Function getMineTimer() As String
        Return "vous avez découvert " & plateau.getNbCaseDécouvertes() & " mines en " & getDuration() & " secondes."
    End Function

    Private Sub msgFin(msg As String)
        fini = True
        MsgBox(msg & " " & getMineTimer())
    End Sub

    Private Sub setBackground(btn As Button, i As cases)
        btn.Tag = i
        Select Case i
            Case cases.fakebomb
                btn.Image = Lecteur.getFakeBomb
            Case cases.bomb
                btn.Image = Lecteur.getBomb
            Case cases.caché
                btn.Image = Lecteur.getFacingDown
            Case cases.flag
                btn.Image = Lecteur.getflag
            Case cases.case0
                btn.Image = Lecteur.get0
            Case cases.case1
                btn.Image = Lecteur.get1
            Case cases.case2
                btn.Image = Lecteur.get2
            Case cases.case3
                btn.Image = Lecteur.get3
            Case cases.case4
                btn.Image = Lecteur.get4
            Case cases.case5
                btn.Image = Lecteur.get5
            Case cases.case6
                btn.Image = Lecteur.get6
            Case cases.case7
                btn.Image = Lecteur.get7
            Case cases.case8
                btn.Image = Lecteur.get8
        End Select

    End Sub

    Private Enum cases
        fakebomb = -4
        bomb = -3
        flag = -2
        caché = -1
        case0 = 0
        case1 = 1
        case2 = 2
        case3 = 3
        case4 = 4
        case5 = 5
        case6 = 6
        case7 = 7
        case8 = 8
    End Enum

End Class