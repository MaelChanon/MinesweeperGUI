<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Réglages
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Réglages))
        Me.HScrollBarLongueur = New System.Windows.Forms.HScrollBar()
        Me.LabelLongueur = New System.Windows.Forms.Label()
        Me.LabelLargeur = New System.Windows.Forms.Label()
        Me.HScrollBarLargeur = New System.Windows.Forms.HScrollBar()
        Me.LabelMine = New System.Windows.Forms.Label()
        Me.HScrollBarMine = New System.Windows.Forms.HScrollBar()
        Me.ButtonValidation = New System.Windows.Forms.Button()
        Me.CheckBoxTimer = New System.Windows.Forms.CheckBox()
        Me.TextBoxTimer = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Radiomc = New System.Windows.Forms.RadioButton()
        Me.RadioBasique = New System.Windows.Forms.RadioButton()
        Me.LabelTexture = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'HScrollBarLongueur
        '
        Me.HScrollBarLongueur.Location = New System.Drawing.Point(249, 148)
        Me.HScrollBarLongueur.Maximum = 69
        Me.HScrollBarLongueur.Minimum = 8
        Me.HScrollBarLongueur.Name = "HScrollBarLongueur"
        Me.HScrollBarLongueur.Size = New System.Drawing.Size(291, 25)
        Me.HScrollBarLongueur.TabIndex = 0
        Me.HScrollBarLongueur.Value = 8
        '
        'LabelLongueur
        '
        Me.LabelLongueur.AutoSize = True
        Me.LabelLongueur.Location = New System.Drawing.Point(347, 95)
        Me.LabelLongueur.Name = "LabelLongueur"
        Me.LabelLongueur.Size = New System.Drawing.Size(51, 17)
        Me.LabelLongueur.TabIndex = 1
        Me.LabelLongueur.Text = "Label1"
        '
        'LabelLargeur
        '
        Me.LabelLargeur.AutoSize = True
        Me.LabelLargeur.Location = New System.Drawing.Point(347, 191)
        Me.LabelLargeur.Name = "LabelLargeur"
        Me.LabelLargeur.Size = New System.Drawing.Size(51, 17)
        Me.LabelLargeur.TabIndex = 3
        Me.LabelLargeur.Text = "Label1"
        '
        'HScrollBarLargeur
        '
        Me.HScrollBarLargeur.Location = New System.Drawing.Point(255, 239)
        Me.HScrollBarLargeur.Maximum = 35
        Me.HScrollBarLargeur.Minimum = 8
        Me.HScrollBarLargeur.Name = "HScrollBarLargeur"
        Me.HScrollBarLargeur.Size = New System.Drawing.Size(291, 25)
        Me.HScrollBarLargeur.TabIndex = 2
        Me.HScrollBarLargeur.Value = 8
        '
        'LabelMine
        '
        Me.LabelMine.AutoSize = True
        Me.LabelMine.Location = New System.Drawing.Point(347, 299)
        Me.LabelMine.Name = "LabelMine"
        Me.LabelMine.Size = New System.Drawing.Size(51, 17)
        Me.LabelMine.TabIndex = 4
        Me.LabelMine.Text = "Label1"
        '
        'HScrollBarMine
        '
        Me.HScrollBarMine.Location = New System.Drawing.Point(249, 338)
        Me.HScrollBarMine.Maximum = 109
        Me.HScrollBarMine.Minimum = 1
        Me.HScrollBarMine.Name = "HScrollBarMine"
        Me.HScrollBarMine.Size = New System.Drawing.Size(291, 25)
        Me.HScrollBarMine.TabIndex = 5
        Me.HScrollBarMine.Value = 1
        '
        'ButtonValidation
        '
        Me.ButtonValidation.Location = New System.Drawing.Point(309, 537)
        Me.ButtonValidation.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonValidation.Name = "ButtonValidation"
        Me.ButtonValidation.Size = New System.Drawing.Size(117, 71)
        Me.ButtonValidation.TabIndex = 6
        Me.ButtonValidation.Text = "Valider"
        Me.ButtonValidation.UseVisualStyleBackColor = True
        '
        'CheckBoxTimer
        '
        Me.CheckBoxTimer.AutoSize = True
        Me.CheckBoxTimer.Checked = True
        Me.CheckBoxTimer.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxTimer.Location = New System.Drawing.Point(255, 398)
        Me.CheckBoxTimer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckBoxTimer.Name = "CheckBoxTimer"
        Me.CheckBoxTimer.Size = New System.Drawing.Size(66, 21)
        Me.CheckBoxTimer.TabIndex = 7
        Me.CheckBoxTimer.Text = "Timer"
        Me.CheckBoxTimer.UseVisualStyleBackColor = True
        '
        'TextBoxTimer
        '
        Me.TextBoxTimer.Location = New System.Drawing.Point(429, 398)
        Me.TextBoxTimer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBoxTimer.Name = "TextBoxTimer"
        Me.TextBoxTimer.Size = New System.Drawing.Size(117, 22)
        Me.TextBoxTimer.TabIndex = 8
        Me.TextBoxTimer.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Radiomc)
        Me.Panel1.Controls.Add(Me.RadioBasique)
        Me.Panel1.Location = New System.Drawing.Point(429, 450)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(117, 73)
        Me.Panel1.TabIndex = 9
        '
        'Radiomc
        '
        Me.Radiomc.AutoSize = True
        Me.Radiomc.Location = New System.Drawing.Point(3, 49)
        Me.Radiomc.Name = "Radiomc"
        Me.Radiomc.Size = New System.Drawing.Size(87, 21)
        Me.Radiomc.TabIndex = 1
        Me.Radiomc.TabStop = True
        Me.Radiomc.Text = "Minecraft"
        Me.Radiomc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Radiomc.UseVisualStyleBackColor = True
        '
        'RadioBasique
        '
        Me.RadioBasique.AutoSize = True
        Me.RadioBasique.Location = New System.Drawing.Point(3, 3)
        Me.RadioBasique.Name = "RadioBasique"
        Me.RadioBasique.Size = New System.Drawing.Size(80, 21)
        Me.RadioBasique.TabIndex = 0
        Me.RadioBasique.TabStop = True
        Me.RadioBasique.Text = "Basique"
        Me.RadioBasique.UseVisualStyleBackColor = True
        '
        'LabelTexture
        '
        Me.LabelTexture.AutoSize = True
        Me.LabelTexture.Location = New System.Drawing.Point(261, 488)
        Me.LabelTexture.Name = "LabelTexture"
        Me.LabelTexture.Size = New System.Drawing.Size(52, 17)
        Me.LabelTexture.TabIndex = 10
        Me.LabelTexture.Text = "Theme"
        '
        'Réglages
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 709)
        Me.Controls.Add(Me.LabelTexture)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TextBoxTimer)
        Me.Controls.Add(Me.CheckBoxTimer)
        Me.Controls.Add(Me.ButtonValidation)
        Me.Controls.Add(Me.HScrollBarMine)
        Me.Controls.Add(Me.LabelMine)
        Me.Controls.Add(Me.LabelLargeur)
        Me.Controls.Add(Me.HScrollBarLargeur)
        Me.Controls.Add(Me.LabelLongueur)
        Me.Controls.Add(Me.HScrollBarLongueur)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Réglages"
        Me.Text = "Réglages"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HScrollBarLongueur As HScrollBar
    Friend WithEvents LabelLongueur As Label
    Friend WithEvents LabelLargeur As Label
    Friend WithEvents HScrollBarLargeur As HScrollBar
    Friend WithEvents LabelMine As Label
    Friend WithEvents HScrollBarMine As HScrollBar
    Friend WithEvents ButtonValidation As Button
    Friend WithEvents CheckBoxTimer As CheckBox
    Friend WithEvents TextBoxTimer As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents RadioBasique As RadioButton
    Friend WithEvents Radiomc As RadioButton
    Friend WithEvents LabelTexture As Label
End Class
