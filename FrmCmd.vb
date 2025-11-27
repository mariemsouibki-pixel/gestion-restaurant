Public Class FrmCmd
    Dim prix As Integer
    Private Sub FrmCmd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBoissons.Items.Add("Café")
        ListBoissons.Items.Add("Jus d'orange")
        ListBoissons.Items.Add("Eau minérale")
        ListBoissons.Items.Add("Citronade")
    End Sub

    Private Sub BtnCommande_Click(sender As Object, e As EventArgs) Handles BtnCommande.Click
        Dim Commande As String
        If RdPizza.Checked Then
            Commande = "Pizza"
            prix = 10
        ElseIf RdBurger.Checked Then
            Commande = "Burger"
            prix = 8
        Else
            Commande = "Pate"
            prix = 15
        End If
        For Each ctrl In GrSupplements.Controls
            If ctrl.Checked Then
                Commande = Commande + " " + ctrl.Text
                If ctrl.Text = "Fromage" Then
                    prix += 2
                ElseIf ctrl.Text = "Frites" Then
                    prix += 2
                ElseIf ctrl.Text = "Dessert" Then
                    prix += 4
                End If
            End If
        Next
        If ListBoissons.SelectedItem = "Café" Then
            prix += 3
            Commande = Commande + " Café"
        End If
        If ListBoissons.SelectedItem = "Jus d'orange" Then
            prix += 4
            Commande = Commande + " Jus d'orange"
        End If
        If ListBoissons.SelectedItem = "Eau minérale" Then
            prix += 1
            Commande = Commande + " Eau minérale"
        End If
        If ListBoissons.SelectedItem = "Citronade" Then
            prix += 3
            Commande = Commande + " Citronade"
        End If
        Commande = Commande & " ~ "
        LblFacture.Text = Commande & " Total=" & prix
    End Sub

    Private Sub BtnAnnuler_Click(sender As Object, e As EventArgs) Handles BtnAnnuler.Click
        RdPizza.Checked = True
        RdBurger.Checked = False
        RdPates.Checked = False
        For Each ctrl As Control In GrSupplements.Controls
            If TypeOf ctrl Is CheckBox Then
                DirectCast(ctrl, CheckBox).Checked = False
            End If
        Next
        ListBoissons.SelectedIndex = -1
        prix = 0
        LblFacture.Text = "Facture"
    End Sub
End Class
