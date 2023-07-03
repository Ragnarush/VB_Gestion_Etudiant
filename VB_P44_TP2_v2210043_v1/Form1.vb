'=========================  Presentation  ========================='
'Prog.:P44_TP2_V2210043
'Desc.: application de gestion des programme scholaire et des etudiants
'Codeur: Francois Gignac v2210043
'Date: 11/11/2022
'Rev.: 0
'=========================  Presentation  ========================='

Imports System.Data.SqlClient

Public Enum Operation
    Aucune = 0
    AJOUT = 1
    MODIF = 2
End Enum

Public Class Form1

    Public frmEtu As frmEtudiant
    Public frmProg As frmProgramme
    Public frmRapEtu As frmRptEtu
    Public frmRapProg As frmRptProg
    Public frmRapEtuProg As frmRptEtuProg


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub mnuProgramme_Click(sender As Object, e As EventArgs) Handles mnuProg.Click
        Try
            If Me.Contains(frmProg) Then
                frmProg.Close()
                frmProg = New frmProgramme With {
                    .MdiParent = Me,
                    .Text = "Programmes"
                }
                frmProg.Show()
            Else
                frmProg = New frmProgramme With {
                    .MdiParent = Me,
                    .Text = "Programmes"
                }
                frmProg.Show()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub mnuEtudiants_Click(sender As Object, e As EventArgs) Handles mnuEtu.Click
        Try
            If Me.Contains(frmEtu) Then
                frmEtu.Close()
                frmEtu = New frmEtudiant With {
                    .MdiParent = Me,
                    .Text = "Etudiants"
                }
                frmEtu.Show()
            Else
                frmEtu = New frmEtudiant With {
                    .MdiParent = Me,
                    .Text = "Etudiants"
                }
                frmEtu.Show()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub mnuQuitter_Click(sender As Object, e As EventArgs) Handles mnuQuit.Click
        End
    End Sub

    '=========================  Rapports  ========================='

    Private Sub mnuListeEtu_Click(sender As Object, e As EventArgs) Handles mnuListeEtu.Click
        Try
            If Me.Contains(frmRapEtu) Then
                frmRapEtu.Close()
                frmRapEtu = New frmRptEtu With {
                    .MdiParent = Me,
                    .Text = "Rapport Etudiants"
                }
                frmRapEtu.Show()
            Else
                frmRapEtu = New frmRptEtu With {
                    .MdiParent = Me,
                    .Text = "Rapport Etudiants"
                }
                frmRapEtu.Show()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub mnuListeProg_Click(sender As Object, e As EventArgs) Handles mnuListeProg.Click
        Try
            If Me.Contains(frmRapProg) Then
                frmRapProg.Close()
                frmRapProg = New frmRptProg With {
                    .MdiParent = Me,
                    .Text = "Rapport Programmes"
                }
                frmRapProg.Show()
            Else
                frmRapProg = New frmRptProg With {
                    .MdiParent = Me,
                    .Text = "Rapport Programmes"
                }
                frmRapProg.Show()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub mnuListeEtuProg_Click(sender As Object, e As EventArgs) Handles mnuListeEtuProg.Click
        Try
            If Me.Contains(frmRapEtuProg) Then
                frmRapEtuProg.Close()
                frmRapEtuProg = New frmRptEtuProg With {
                    .MdiParent = Me,
                    .Text = "Rapport Étudiants par Programme"
                }
                frmRapEtuProg.Show()
            Else
                frmRapEtuProg = New frmRptEtuProg With {
                    .MdiParent = Me,
                    .Text = "Rapport Étudiants par Programme"
                }
                frmRapEtuProg.Show()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
