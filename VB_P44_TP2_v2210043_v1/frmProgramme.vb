'=========================  Presentation  ========================='
'Prog.:P44_TP2_V2210043
'Desc.: application de gestion des programme scholaire et des etudiants
'Codeur: Francois Gignac v2210043
'Date: 11/11/2022
'Rev.: 0
'=========================  Presentation  ========================='


Imports System.Configuration
Imports System.Data.SqlClient

Public Class frmProgramme

    Dim Action As Operation = Operation.Aucune

    '========================================================================'
    '===========================    EVENEMENTS     =========================='
    '========================================================================'

    Private Sub frmProgramme_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Barrer(True, grpProg, btnOk, btnAnnuler)
            Barrer(False, btnNouveau, btnModifier, btnEnlever)

            daProg.Fill(DsProg1.T_programme)

            ''verifier si nous avons des etudiants
            If DsProg1.T_programme.Rows.Count > 0 Then
                btnModifier.Enabled = True
            End If

            dgProg.Focus()
            AddHandler dgProg.SelectionChanged, AddressOf dgProg_SelectionChanged
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub dgProg_SelectionChanged(sender As Object, e As EventArgs) 'Handles dgProg.SelectionChanged
        Try
            If dgProg.SelectedRows.Count > 0 Then
                Remplir_Etudiants()
                If Action = Operation.Aucune And dgProg.SelectedRows.Count > 0 Then
                    Barrer((DsEtu1.T_etudiants.Rows.Count <> 0), btnEnlever) 'j'utilise <> 0 a cause de la negation dans Barrer()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    '========================================================================'
    '=======================    EVENEMENTS - CLICK    ======================='
    '========================================================================'

    Private Sub btnNouveau_Click(sender As Object, e As EventArgs) Handles btnNouveau.Click
        Action = Operation.AJOUT

        Barrer(True, dgProg, dgEtu, btnNouveau, btnModifier, btnEnlever)
        Barrer(False, btnOk, btnAnnuler, grpProg)

        'permet de vider l'ecran ...
        bsProg.AddNew()
        numUnits.Value = 0
        numHeures.Value = 0
        mskNo.Focus()
    End Sub

    Private Sub btnModifier_Click(sender As Object, e As EventArgs) Handles btnModifier.Click
        Action = Operation.MODIF
        Barrer(True, dgProg, dgEtu, btnNouveau, btnModifier, btnEnlever)
        Barrer(False, btnOk, btnAnnuler, grpProg)
    End Sub

    Private Sub btnEnlever_Click(sender As Object, e As EventArgs) Handles btnEnlever.Click

        Try  'Verification que nous avons aucun etudiant dans le programme et Confirmation avant Suppression
            If (MessageBox.Show($"voulez-vous enlever ce programme ?", "Confirmation",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes) Then
                'suppression dans le dataset
                bsProg.RemoveCurrent()
                'transferer les changement a la 'vraie' BD
                daProg.Update(DsProg1.T_programme)
                'informer l'utilisateur
                MsgBox("Programme enlevé avec succès...")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnAnnuler_Click(sender As Object, e As EventArgs) Handles btnAnnuler.Click
        Action = Operation.Aucune
        bsProg.CancelEdit()
        Barrer(True, btnOk, btnAnnuler, grpProg)
        Barrer(False, dgProg, dgEtu, btnNouveau, btnModifier, btnEnlever)
        'se repositionner
        bsProg.MoveFirst()
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Try
            bsProg.EndEdit()
            daProg.Update(DsProg1.T_programme)

            Barrer(True, grpProg, btnOk, btnAnnuler)
            Barrer(False, dgEtu, dgProg, btnNouveau, btnModifier, btnEnlever)

            If Action = Operation.AJOUT Then
                MsgBox("Programme ajouté avec succès")
                'se repositionner ...
                bsProg.MoveLast()
            Else
                MsgBox("Programme modifié avec succès")
            End If
            Action = Operation.Aucune
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    '========================================================================'
    '====================    EVENEMENTS - KeyPress     ======================'
    '========================================================================'

    Private Sub txtNom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNom.KeyPress
        'Si on veux des numero de programme, on utilisera les chiffre romain
        If Char.IsDigit(e.KeyChar) = True Then
            e.KeyChar = ""
        ElseIf Char.IsNumber(e.KeyChar) = True Then
            e.KeyChar = ""
        End If
    End Sub


    '========================================================================'
    '==========================    PROCEDURES     ==========================='
    '========================================================================'

    Private Sub Remplir_Etudiants()
        Try
            'vider le contenu du dataset
            DsEtu1.T_etudiants.Clear()
            'specifier le parametre (NoProg)
            daEtuProg.SelectCommand.Parameters("@NoProg").Value = mskNo.Text.ToString()
            'remplir la table des etudiants
            daEtuProg.Fill(DsEtu1.T_etudiants)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Barrer(truth As Boolean, ParamArray ctrl() As Control)
        truth = If((truth = False), True, False)
        For Each c As Control In ctrl
            c.Enabled = truth
            If truth = True Then
                c.BackColor = Color.Gold
            Else
                c.BackColor = Color.IndianRed
            End If
        Next
    End Sub

End Class