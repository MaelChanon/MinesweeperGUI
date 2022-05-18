Public Class Réglages
    Private longueur As Integer = 15
    Private largeur As Integer = 15
    Private nbMines As Integer = 10
    Private timer As Integer = 60
    Private Sub Réglages_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Lecteur.getConfig()
        initChamps()
        Me.MaximumSize = New Size(Me.Width, Me.Height)
        Me.MinimumSize = New Size(Me.Width, Me.Height)
    End Sub

    Private Sub initChamps()
        HScrollBarLargeur.Value = Lecteur.getLargeur
        HScrollBarLongueur.Value = Lecteur.getLongueur
        HScrollBarMine.Value = Lecteur.getNbMines
        LabelMine.Text = "Mines : " & Lecteur.getNbMines
        LabelLongueur.Text = "Longueur : " & Lecteur.getLongueur
        LabelLargeur.Text = "Largeur : " & Lecteur.getLargeur
        TextBoxTimer.Text = Lecteur.getTimer
        If Lecteur.getTimer = -1 Then
            CheckBoxTimer.Checked = False
            TextBoxTimer.Visible = False
            TextBoxTimer.Text = ""

        Else
            CheckBoxTimer.Checked = True
            TextBoxTimer.Visible = True
        End If

        If Lecteur.getTheme = 0 Then
            RadioBasique.Checked = True
        Else
            Radiomc.Checked = True
        End If

    End Sub

    Private Sub HScrollBarLongueur_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBarLongueur.Scroll
        verifMine()
        LabelLongueur.Text = "Longueur : " & HScrollBarLongueur.Value
    End Sub

    Private Sub HScrollBarLargeur_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBarLargeur.Scroll
        verifMine()
        LabelLargeur.Text = "Largeur : " & HScrollBarLargeur.Value
    End Sub

    Private Sub HScrollBarMine_Scroll(sender As Object, e As EventArgs) Handles HScrollBarMine.ValueChanged

        LabelMine.Text = "Mines : " & HScrollBarMine.Value
        verifMine()
    End Sub

    'Verifie que le nombre de mines ne depasse pas le nombre de cases
    Private Sub verifMine()
        If HScrollBarMine.Value >= (HScrollBarLargeur.Value * HScrollBarLongueur.Value) Then
            HScrollBarMine.Value = HScrollBarLargeur.Value * HScrollBarLongueur.Value - 1
        End If
    End Sub

    Private Sub ButtonValidation_Click(sender As Object, e As EventArgs) Handles ButtonValidation.Click
        Dim tmp As Integer = -1
        If CheckBoxTimer.Checked Then
            tmp = Convert.ToInt32(TextBoxTimer.Text)
        End If
        If tmp > 3600 Then
            MsgBox("le décompte est trop long")
            TextBoxTimer.Focus()
            Exit Sub
        End If
        enregistrer(tmp)
        Me.Close()
        Lancement.Show()
    End Sub


    Private Sub enregistrer(tmp As Integer)
        If CheckBoxTimer.Checked Then
            Lecteur.setTimer(tmp)
        Else
            Lecteur.setTimer(-1)
        End If
        Lecteur.setLongueur(HScrollBarLongueur.Value)
        Lecteur.setLargeur(HScrollBarLargeur.Value)
        Lecteur.setNbMines(HScrollBarMine.Value)
        If RadioBasique.Checked Then
            Lecteur.setTheme(0)
        Else
            Lecteur.setTheme(1)
        End If
        Lecteur.saveConfig()
    End Sub
    Private Sub CheckTimer_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxTimer.CheckedChanged
        TextBoxTimer.Visible = Not TextBoxTimer.Visible
    End Sub

    Private Sub TextBoxTimer_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxTimer.KeyPress
        If Char.IsControl(e.KeyChar) Or Char.IsDigit(e.KeyChar) Then
            Exit Sub
        End If
        e.Handled = True
    End Sub
End Class