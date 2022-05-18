Public Class Form1
    Private liste As ArrayList
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        liste = Joueur.getListeJoueurTrié
        chargerComboBox()
        chargerListes()
    End Sub
    Private Sub chargerComboBox()
        Dim src As AutoCompleteStringCollection = New AutoCompleteStringCollection
        For Each j As Joueur.Joueur In liste
            src.Add(j.Nom)
        Next
        ComboBoxRecherche.AutoCompleteSource = AutoCompleteSource.CustomSource
        ComboBoxRecherche.AutoCompleteCustomSource = src
        ComboBoxRecherche.AutoCompleteMode = AutoCompleteMode.Suggest
    End Sub


    Private Sub chargerListes()
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        For Each j As Joueur.Joueur In liste
            ListBox1.Items.Add(j.Nom)
            ListBox2.Items.Add(j.NbCaseDecouverteRecord)
            ListBox3.Items.Add(TimeSpan.FromMinutes(j.TempsRecord))
        Next
    End Sub
    Private Sub FindStringButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged, ListBox2.SelectedIndexChanged, ListBox3.SelectedIndexChanged
        Dim lb As ListBox = sender
        MsgBox(lb.SelectedIndex)
    End Sub

    Private Sub ButtonInverser_Click(sender As Object, e As EventArgs) Handles ButtonInverser.Click
        liste.Reverse()
        chargerListes()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxRecherche.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonRecherche.Click
        Dim j As Joueur.Joueur = Joueur.getJoueur(ComboBoxRecherche.Text)
        If j.Nom = "" Then
            MsgBox("Joueur inconnu")
            Exit Sub
        End If
        MsgBox("fez")
    End Sub
End Class
