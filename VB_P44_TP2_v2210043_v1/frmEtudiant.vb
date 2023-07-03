'=========================  Presentation  ========================='
'Prog.:P44_TP2_V2210043
'Desc.: application de gestion des programme scholaire et des etudiants
'Codeur: Francois Gignac v2210043
'Date: 11/11/2022
'Rev.: 0
'=================================================================='


Public Class frmEtudiant

    Dim Action As Operation = Operation.Aucune
    Dim Sexe As String = "X"
    '========================================================================'
    '===========================    EVENEMENTS     =========================='
    '========================================================================'


    Private Sub frmEtudiants_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Barrer(True, grpEtudiant, btnOk, btnAnnuler)
            Barrer(False, btnNouveau, btnModifier, btnEnlever)

            daProg.Fill(DsEtu1.T_programme)
            daEtu.Fill(DsEtu1.T_etudiants)
            dgEtu1.Focus()
            ''verifier si nous avons des etudiants
            If DsEtu1.T_etudiants.Rows.Count > 0 Then
                btnModifier.Enabled = True
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgEtu1_SelectionChanged(sender As Object, e As EventArgs) Handles dgEtu1.SelectionChanged
        Try
            'If mskSex.Text = "F" Then
            '    rbFeminin.Checked = True
            'ElseIf mskSex.Text = "M" Then
            '    rbMasculin.Checked = True
            'Else
            '    rbUnspecified.Checked = True
            'End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    '========================================================================'
    '=======================    EVENEMENTS - CLICK    ======================='
    '========================================================================'

    Private Sub btnNouveau_Click(sender As Object, e As EventArgs) Handles btnNouveau.Click
        Action = Operation.AJOUT

        Barrer(False, btnOk, btnAnnuler, grpEtudiant)
        Barrer(True, dgEtu1, btnNouveau, btnModifier, btnEnlever, mskDa)

        'permet de vider l'ecran ...
        bsEtu.AddNew()
        txtPrenom.Focus()
        NewDA()
    End Sub

    Private Sub btnModifier_Click(sender As Object, e As EventArgs) Handles btnModifier.Click
        Action = Operation.MODIF
        Barrer(False, btnOk, btnAnnuler, grpEtudiant)
        Barrer(True, dgEtu1, btnNouveau, btnModifier, btnEnlever, mskDa)
    End Sub

    Private Sub btnEnlever_Click(sender As Object, e As EventArgs) Handles btnEnlever.Click

        Try  'Verification que nous avons aucun etudiant dans le programme et Confirmation avant Suppression
            If (MessageBox.Show($"voulez-vous enlever cet étudiant ?", "Confirmation",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes) Then
                'suppression dans le dataset
                bsEtu.RemoveCurrent()
                'transferer les changement a la 'vraie' BD
                daEtu.Update(DsEtu1.T_etudiants)
                'informer l'utilisateur
                MsgBox("Étudiant enlevé avec succès...")
                Barrer(False, dgEtu1, btnNouveau, btnModifier)
                Barrer(True, grpEtudiant, btnOk, btnAnnuler, btnEnlever)
                bsEtu.MoveNext()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnAnnuler_Click(sender As Object, e As EventArgs) Handles btnAnnuler.Click
        Action = Operation.Aucune
        bsEtu.CancelEdit()
        Barrer(True, btnOk, btnAnnuler, grpEtudiant)
        Barrer(False, dgEtu1, btnNouveau, btnModifier, btnEnlever)
        bsEtu.MoveFirst()
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Try
            bsEtu.EndEdit()
            daEtu.Update(DsEtu1.T_etudiants)
            Barrer(True, grpEtudiant, btnOk, btnAnnuler)
            Barrer(False, dgEtu1, btnNouveau, btnModifier, btnEnlever)

            If Action = Operation.AJOUT Then
                MsgBox("Étudiant ajouté avec succès")
                bsEtu.MoveLast()
            Else
                MsgBox("Étudiant modifié avec succès")
            End If

            Action = Operation.Aucune
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    '========================================================================'
    '======================    EVENEMENTS - KEYPRESS    ====================='
    '========================================================================'

    Private Sub txtPrenom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrenom.KeyPress
        NameValidation(e)
    End Sub

    Private Sub txtNom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNom.KeyPress
        NameValidation(e)
    End Sub

    Private Sub txtVille_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtVille.KeyPress
        NameValidation(e)
    End Sub



    '========================================================================'
    '==========================    PROCEDURES     ==========================='
    '========================================================================'


    Private Sub Barrer(truth As Boolean, ParamArray ctrl() As Control)
        truth = If((truth = False), True, False)
        For Each c As Control In ctrl
            c.Enabled = truth
            If truth = True Then
                c.BackColor = Color.DarkSeaGreen
            Else
                c.BackColor = Color.IndianRed
            End If
        Next
    End Sub

    Private Sub NewDA()
        mskDa.Text = DsEtu1.T_etudiants.Rows(DsEtu1.T_etudiants.Rows.Count - 1).Item(0) + 1
    End Sub

    Private Sub NameValidation(e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) = True Then
            e.KeyChar = ""
        ElseIf Char.IsNumber(e.KeyChar) = True Then
            e.KeyChar = ""
        End If
    End Sub


End Class