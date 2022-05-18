<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lancement
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Lancement))
        Me.ComboBoxJoueurs = New System.Windows.Forms.ComboBox()
        Me.LabelList = New System.Windows.Forms.Label()
        Me.ButtonNG = New System.Windows.Forms.Button()
        Me.Buttontab = New System.Windows.Forms.Button()
        Me.ButtonLeave = New System.Windows.Forms.Button()
        Me.ButtonParam = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ComboBoxJoueurs
        '
        Me.ComboBoxJoueurs.FormattingEnabled = True
        Me.ComboBoxJoueurs.Location = New System.Drawing.Point(211, 80)
        Me.ComboBoxJoueurs.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ComboBoxJoueurs.Name = "ComboBoxJoueurs"
        Me.ComboBoxJoueurs.Size = New System.Drawing.Size(138, 21)
        Me.ComboBoxJoueurs.TabIndex = 0
        '
        'LabelList
        '
        Me.LabelList.AutoSize = True
        Me.LabelList.Location = New System.Drawing.Point(174, 53)
        Me.LabelList.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelList.Name = "LabelList"
        Me.LabelList.Size = New System.Drawing.Size(94, 13)
        Me.LabelList.TabIndex = 1
        Me.LabelList.Text = "Rentrez votre nom"
        '
        'ButtonNG
        '
        Me.ButtonNG.Location = New System.Drawing.Point(232, 196)
        Me.ButtonNG.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ButtonNG.Name = "ButtonNG"
        Me.ButtonNG.Size = New System.Drawing.Size(117, 60)
        Me.ButtonNG.TabIndex = 2
        Me.ButtonNG.Text = "Nouvelle Partie"
        Me.ButtonNG.UseVisualStyleBackColor = True
        '
        'Buttontab
        '
        Me.Buttontab.Location = New System.Drawing.Point(85, 196)
        Me.Buttontab.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Buttontab.Name = "Buttontab"
        Me.Buttontab.Size = New System.Drawing.Size(120, 60)
        Me.Buttontab.TabIndex = 3
        Me.Buttontab.Text = "Tableau des scores"
        Me.Buttontab.UseVisualStyleBackColor = True
        '
        'ButtonLeave
        '
        Me.ButtonLeave.Location = New System.Drawing.Point(383, 196)
        Me.ButtonLeave.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ButtonLeave.Name = "ButtonLeave"
        Me.ButtonLeave.Size = New System.Drawing.Size(119, 60)
        Me.ButtonLeave.TabIndex = 4
        Me.ButtonLeave.Text = "Quitter"
        Me.ButtonLeave.UseVisualStyleBackColor = True
        '
        'ButtonParam
        '
        Me.ButtonParam.Location = New System.Drawing.Point(232, 278)
        Me.ButtonParam.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ButtonParam.Name = "ButtonParam"
        Me.ButtonParam.Size = New System.Drawing.Size(117, 58)
        Me.ButtonParam.TabIndex = 5
        Me.ButtonParam.Text = "Réglages"
        Me.ButtonParam.UseVisualStyleBackColor = True
        '
        'Lancement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.ButtonParam)
        Me.Controls.Add(Me.ButtonLeave)
        Me.Controls.Add(Me.Buttontab)
        Me.Controls.Add(Me.ButtonNG)
        Me.Controls.Add(Me.LabelList)
        Me.Controls.Add(Me.ComboBoxJoueurs)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Lancement"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBoxJoueurs As ComboBox
    Friend WithEvents LabelList As Label
    Friend WithEvents ButtonNG As Button
    Friend WithEvents Buttontab As Button
    Friend WithEvents ButtonLeave As Button
    Friend WithEvents ButtonParam As Button
End Class
