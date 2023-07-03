<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FormulaireEtudiantsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProg = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEtu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuQuit = New System.Windows.Forms.ToolStripMenuItem()
        Me.RapportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuListeProg = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuListeEtu = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuListeEtuProg = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FormulaireEtudiantsToolStripMenuItem, Me.RapportToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1823, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FormulaireEtudiantsToolStripMenuItem
        '
        Me.FormulaireEtudiantsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuProg, Me.mnuEtu, Me.ToolStripMenuItem1, Me.mnuQuit})
        Me.FormulaireEtudiantsToolStripMenuItem.Name = "FormulaireEtudiantsToolStripMenuItem"
        Me.FormulaireEtudiantsToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.FormulaireEtudiantsToolStripMenuItem.Text = "&Gestion"
        '
        'mnuProg
        '
        Me.mnuProg.Name = "mnuProg"
        Me.mnuProg.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.mnuProg.Size = New System.Drawing.Size(184, 22)
        Me.mnuProg.Text = "&Programmes"
        '
        'mnuEtu
        '
        Me.mnuEtu.Name = "mnuEtu"
        Me.mnuEtu.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F2), System.Windows.Forms.Keys)
        Me.mnuEtu.Size = New System.Drawing.Size(184, 22)
        Me.mnuEtu.Text = "&Etudiants"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(181, 6)
        '
        'mnuQuit
        '
        Me.mnuQuit.Name = "mnuQuit"
        Me.mnuQuit.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.mnuQuit.Size = New System.Drawing.Size(184, 22)
        Me.mnuQuit.Text = "&Quitter"
        '
        'RapportToolStripMenuItem
        '
        Me.RapportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuListeProg, Me.mnuListeEtu, Me.mnuListeEtuProg})
        Me.RapportToolStripMenuItem.Name = "RapportToolStripMenuItem"
        Me.RapportToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.RapportToolStripMenuItem.Text = "&Rapport"
        '
        'mnuListeProg
        '
        Me.mnuListeProg.Name = "mnuListeProg"
        Me.mnuListeProg.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F5), System.Windows.Forms.Keys)
        Me.mnuListeProg.Size = New System.Drawing.Size(299, 22)
        Me.mnuListeProg.Text = "&Liste des Programmes"
        '
        'mnuListeEtu
        '
        Me.mnuListeEtu.Name = "mnuListeEtu"
        Me.mnuListeEtu.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F6), System.Windows.Forms.Keys)
        Me.mnuListeEtu.Size = New System.Drawing.Size(299, 22)
        Me.mnuListeEtu.Text = "L&iste des Etudiants"
        '
        'mnuListeEtuProg
        '
        Me.mnuListeEtuProg.Name = "mnuListeEtuProg"
        Me.mnuListeEtuProg.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F7), System.Windows.Forms.Keys)
        Me.mnuListeEtuProg.Size = New System.Drawing.Size(299, 22)
        Me.mnuListeEtuProg.Text = "Li&ste des Etudiants par Programme"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1823, 971)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FormulaireEtudiantsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuProg As ToolStripMenuItem
    Friend WithEvents mnuEtu As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents mnuQuit As ToolStripMenuItem
    Friend WithEvents RapportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuListeProg As ToolStripMenuItem
    Friend WithEvents mnuListeEtu As ToolStripMenuItem
    Friend WithEvents mnuListeEtuProg As ToolStripMenuItem
End Class
