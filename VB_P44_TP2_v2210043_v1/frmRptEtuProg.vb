﻿'=========================  Presentation  ========================='
'Prog.:P44_TP2_V2210043
'Desc.: application de gestion des programme scholaire et des etudiants
'Codeur: Francois Gignac v2210043
'Date: 11/11/2022
'Rev.: 0
'=========================  Presentation  ========================='

Public Class frmRptEtuProg

    Private Sub frmRptEtuProg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            daRapEtuProg.Fill(DsRapEtuProg1.T_etudiants)
            Dim rpt As New rapport_etuParProg()
            rpt.SetDataSource(DsRapEtuProg1)
            crv.ReportSource = rpt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class