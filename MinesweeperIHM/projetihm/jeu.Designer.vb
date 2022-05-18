<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class jeu
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(jeu))
        Me.PanelPlateau = New System.Windows.Forms.Panel()
        Me.LabelNom = New System.Windows.Forms.Label()
        Me.ButtonAbandon = New System.Windows.Forms.Button()
        Me.monTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ButtonAide = New System.Windows.Forms.Button()
        Me.TimerAffichage = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'PanelPlateau
        '
        Me.PanelPlateau.Location = New System.Drawing.Point(29, 80)
        Me.PanelPlateau.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PanelPlateau.Name = "PanelPlateau"
        Me.PanelPlateau.Size = New System.Drawing.Size(547, 239)
        Me.PanelPlateau.TabIndex = 0
        '
        'LabelNom
        '
        Me.LabelNom.AutoSize = True
        Me.LabelNom.Location = New System.Drawing.Point(44, 41)
        Me.LabelNom.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelNom.Name = "LabelNom"
        Me.LabelNom.Size = New System.Drawing.Size(39, 13)
        Me.LabelNom.TabIndex = 1
        Me.LabelNom.Text = "Label1"
        '
        'ButtonAbandon
        '
        Me.ButtonAbandon.Location = New System.Drawing.Point(419, 23)
        Me.ButtonAbandon.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ButtonAbandon.Name = "ButtonAbandon"
        Me.ButtonAbandon.Size = New System.Drawing.Size(76, 49)
        Me.ButtonAbandon.TabIndex = 2
        Me.ButtonAbandon.Text = "Abandonner"
        Me.ButtonAbandon.UseVisualStyleBackColor = True
        '
        'monTimer
        '
        '
        'ButtonAide
        '
        Me.ButtonAide.Location = New System.Drawing.Point(309, 23)
        Me.ButtonAide.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ButtonAide.Name = "ButtonAide"
        Me.ButtonAide.Size = New System.Drawing.Size(62, 49)
        Me.ButtonAide.TabIndex = 3
        Me.ButtonAide.Text = "Aide"
        Me.ButtonAide.UseVisualStyleBackColor = True
        '
        'jeu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.ButtonAide)
        Me.Controls.Add(Me.ButtonAbandon)
        Me.Controls.Add(Me.LabelNom)
        Me.Controls.Add(Me.PanelPlateau)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "jeu"
        Me.Text = "jeu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelPlateau As Panel
    Friend WithEvents LabelNom As Label
    Friend WithEvents ButtonAbandon As Button
    Friend WithEvents monTimer As Timer
    Friend WithEvents ButtonAide As Button
    Friend WithEvents TimerAffichage As Timer
End Class
