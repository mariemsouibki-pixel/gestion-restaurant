<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCmd
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        RdPizza = New RadioButton()
        RdBurger = New RadioButton()
        RdPates = New RadioButton()
        GrPlats = New GroupBox()
        GrSupplements = New GroupBox()
        ChkDessert = New CheckBox()
        ChkFromage = New CheckBox()
        ChkFrites = New CheckBox()
        Label1 = New Label()
        LblFacture = New Label()
        ListBoissons = New ListBox()
        BtnCommande = New Button()
        BtnAnnuler = New Button()
        GrPlats.SuspendLayout()
        GrSupplements.SuspendLayout()
        SuspendLayout()
        ' 
        ' RdPizza
        ' 
        RdPizza.AutoSize = True
        RdPizza.Location = New Point(30, 54)
        RdPizza.Name = "RdPizza"
        RdPizza.Size = New Size(64, 24)
        RdPizza.TabIndex = 0
        RdPizza.TabStop = True
        RdPizza.Text = "Pizza"
        RdPizza.UseVisualStyleBackColor = True
        ' 
        ' RdBurger
        ' 
        RdBurger.AutoSize = True
        RdBurger.Location = New Point(30, 107)
        RdBurger.Name = "RdBurger"
        RdBurger.Size = New Size(74, 24)
        RdBurger.TabIndex = 1
        RdBurger.TabStop = True
        RdBurger.Text = "Burger"
        RdBurger.UseVisualStyleBackColor = True
        ' 
        ' RdPates
        ' 
        RdPates.AutoSize = True
        RdPates.Location = New Point(30, 161)
        RdPates.Name = "RdPates"
        RdPates.Size = New Size(64, 24)
        RdPates.TabIndex = 2
        RdPates.TabStop = True
        RdPates.Text = "Pates"
        RdPates.UseVisualStyleBackColor = True
        ' 
        ' GrPlats
        ' 
        GrPlats.BackColor = Color.MistyRose
        GrPlats.Controls.Add(RdPizza)
        GrPlats.Controls.Add(RdPates)
        GrPlats.Controls.Add(RdBurger)
        GrPlats.Location = New Point(43, 25)
        GrPlats.Name = "GrPlats"
        GrPlats.Size = New Size(250, 219)
        GrPlats.TabIndex = 3
        GrPlats.TabStop = False
        GrPlats.Text = "Choix du plat"
        ' 
        ' GrSupplements
        ' 
        GrSupplements.BackColor = Color.LightSalmon
        GrSupplements.Controls.Add(ChkDessert)
        GrSupplements.Controls.Add(ChkFromage)
        GrSupplements.Controls.Add(ChkFrites)
        GrSupplements.Location = New Point(43, 270)
        GrSupplements.Name = "GrSupplements"
        GrSupplements.Size = New Size(250, 198)
        GrSupplements.TabIndex = 4
        GrSupplements.TabStop = False
        GrSupplements.Text = "Suppléments"
        ' 
        ' ChkDessert
        ' 
        ChkDessert.AutoSize = True
        ChkDessert.Location = New Point(30, 148)
        ChkDessert.Name = "ChkDessert"
        ChkDessert.Size = New Size(80, 24)
        ChkDessert.TabIndex = 7
        ChkDessert.Text = "Dessert"
        ChkDessert.UseVisualStyleBackColor = True
        ' 
        ' ChkFromage
        ' 
        ChkFromage.AutoSize = True
        ChkFromage.Location = New Point(30, 37)
        ChkFromage.Name = "ChkFromage"
        ChkFromage.Size = New Size(90, 24)
        ChkFromage.TabIndex = 5
        ChkFromage.Text = "Fromage"
        ChkFromage.UseVisualStyleBackColor = True
        ' 
        ' ChkFrites
        ' 
        ChkFrites.AutoSize = True
        ChkFrites.Location = New Point(30, 91)
        ChkFrites.Name = "ChkFrites"
        ChkFrites.Size = New Size(66, 24)
        ChkFrites.TabIndex = 6
        ChkFrites.Text = "Frites"
        ChkFrites.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Sitka Heading", 16.1999989F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Chocolate
        Label1.Location = New Point(352, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(128, 39)
        Label1.TabIndex = 5
        Label1.Text = "Boissons :"
        ' 
        ' LblFacture
        ' 
        LblFacture.AutoSize = True
        LblFacture.Font = New Font("Times New Roman", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        LblFacture.ForeColor = Color.Green
        LblFacture.Location = New Point(352, 210)
        LblFacture.Name = "LblFacture"
        LblFacture.Size = New Size(113, 34)
        LblFacture.TabIndex = 6
        LblFacture.Text = "Facture"
        ' 
        ' ListBoissons
        ' 
        ListBoissons.BackColor = Color.Moccasin
        ListBoissons.FormattingEnabled = True
        ListBoissons.Location = New Point(486, 37)
        ListBoissons.Name = "ListBoissons"
        ListBoissons.Size = New Size(243, 104)
        ListBoissons.TabIndex = 7
        ' 
        ' BtnCommande
        ' 
        BtnCommande.BackColor = SystemColors.GradientActiveCaption
        BtnCommande.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold Or FontStyle.Italic)
        BtnCommande.ForeColor = SystemColors.Highlight
        BtnCommande.Location = New Point(352, 317)
        BtnCommande.Name = "BtnCommande"
        BtnCommande.Size = New Size(171, 48)
        BtnCommande.TabIndex = 8
        BtnCommande.Text = "Commander"
        BtnCommande.UseVisualStyleBackColor = False
        ' 
        ' BtnAnnuler
        ' 
        BtnAnnuler.BackColor = SystemColors.GradientActiveCaption
        BtnAnnuler.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold Or FontStyle.Italic)
        BtnAnnuler.ForeColor = SystemColors.Highlight
        BtnAnnuler.Location = New Point(558, 317)
        BtnAnnuler.Name = "BtnAnnuler"
        BtnAnnuler.Size = New Size(171, 48)
        BtnAnnuler.TabIndex = 10
        BtnAnnuler.Text = "Annuler"
        BtnAnnuler.UseVisualStyleBackColor = False
        ' 
        ' FrmCmd
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Menu
        ClientSize = New Size(1057, 521)
        Controls.Add(BtnAnnuler)
        Controls.Add(BtnCommande)
        Controls.Add(ListBoissons)
        Controls.Add(LblFacture)
        Controls.Add(Label1)
        Controls.Add(GrSupplements)
        Controls.Add(GrPlats)
        Name = "FrmCmd"
        Text = "Commande"
        GrPlats.ResumeLayout(False)
        GrPlats.PerformLayout()
        GrSupplements.ResumeLayout(False)
        GrSupplements.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents RdPizza As RadioButton
    Friend WithEvents RdBurger As RadioButton
    Friend WithEvents RdPates As RadioButton
    Friend WithEvents GrPlats As GroupBox
    Friend WithEvents GrSupplements As GroupBox
    Friend WithEvents ChkFromage As CheckBox
    Friend WithEvents ChkFrites As CheckBox
    Friend WithEvents ChkDessert As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LblFacture As Label
    Friend WithEvents ListBoissons As ListBox
    Friend WithEvents BtnCommande As Button
    Friend WithEvents BtnAnnuler As Button

End Class
