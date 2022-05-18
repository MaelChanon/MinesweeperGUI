Public Class Lancement
    Private Sub ButtonLeave_Click(sender As Object, e As EventArgs) Handles ButtonLeave.Click
        If MsgBox("êtes-vous sûr de vouloir partir?", vbYesNo) = vbYes Then
            MsgBox(Joueur.getAlPlayers)
            Lecteur.sauvegarder()

            Me.Close()
        End If
    End Sub

    Private Sub minecraft()
        Me.BackgroundImage = New Bitmap(Application.StartupPath & "\images\minecraft\background.jpg")
        Me.Width = 960
        Me.Height = 540
        ComboBoxJoueurs.Width = Me.Width / 3
        ComboBoxJoueurs.BackColor = Color.Gray
    End Sub
    Private Sub Lancement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Lecteur.getConfig()
        Lecteur.getsave()
        ComboBoxJoueurs.Items.AddRange(Joueur.getNomsJoueurs)
        Dim pfc As Drawing.Text.PrivateFontCollection = New Drawing.Text.PrivateFontCollection
        pfc.AddFontFile(Application.StartupPath + "\font\kongtext.ttf")
        For Each c As Control In Me.Controls
            c.Font = New Font(pfc.Families(0), 9)
        Next
        Me.Text = "Minesweaper"
        minecraft()
    End Sub


    Private Sub ButtonNG_Click(sender As Object, e As EventArgs) Handles ButtonNG.Click

        Joueur.ajouterJoueur(Trim(ComboBoxJoueurs.Text), 0, 0, 0)
        Me.Hide()
        jeu.ShowDialog()
    End Sub
    Private Sub ButtonParam_Click(sender As Object, e As EventArgs) Handles ButtonParam.Click
        Me.Hide()
        Réglages.ShowDialog()
    End Sub

    Private Sub Buttontab_Click(sender As Object, e As EventArgs) Handles Buttontab.Click
        Me.Hide()
        Form1.ShowDialog()
    End Sub


End Class
