<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRptEtuProg
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
        Me.crv = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.cnRapEtuProg = New System.Data.SqlClient.SqlConnection()
        Me.daRapEtuProg = New System.Data.SqlClient.SqlDataAdapter()
        Me.DsRapEtuProg1 = New VB_P44_TP2_v2210043_v1.dsRapEtuProg()
        CType(Me.DsRapEtuProg1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'crv
        '
        Me.crv.ActiveViewIndex = -1
        Me.crv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crv.Cursor = System.Windows.Forms.Cursors.Default
        Me.crv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crv.Location = New System.Drawing.Point(0, 0)
        Me.crv.Name = "crv"
        Me.crv.Size = New System.Drawing.Size(1536, 715)
        Me.crv.TabIndex = 0
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT        T_etudiants.*, T_programme.pro_no AS Expr1, T_programme.pro_nom" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FR" &
    "OM            T_etudiants INNER JOIN" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                         T_programme ON T_" &
    "etudiants.pro_no = T_programme.pro_no"
        Me.SqlSelectCommand1.Connection = Me.cnRapEtuProg
        '
        'cnRapEtuProg
        '
        Me.cnRapEtuProg.ConnectionString = "Data Source=RAGNAROCK\SQLEXPRESS;Initial Catalog=tp_p44;Integrated Security=True"
        Me.cnRapEtuProg.FireInfoMessageEventOnUserErrors = False
        '
        'daRapEtuProg
        '
        Me.daRapEtuProg.SelectCommand = Me.SqlSelectCommand1
        Me.daRapEtuProg.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "T_etudiants", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("etu_da", "etu_da"), New System.Data.Common.DataColumnMapping("pro_no", "pro_no"), New System.Data.Common.DataColumnMapping("etu_nom", "etu_nom"), New System.Data.Common.DataColumnMapping("etu_prenom", "etu_prenom"), New System.Data.Common.DataColumnMapping("etu_sexe", "etu_sexe"), New System.Data.Common.DataColumnMapping("etu_adresse", "etu_adresse"), New System.Data.Common.DataColumnMapping("etu_ville", "etu_ville"), New System.Data.Common.DataColumnMapping("etu_province", "etu_province"), New System.Data.Common.DataColumnMapping("etu_telephone", "etu_telephone"), New System.Data.Common.DataColumnMapping("etu_codepostal", "etu_codepostal"), New System.Data.Common.DataColumnMapping("Expr1", "Expr1"), New System.Data.Common.DataColumnMapping("pro_nom", "pro_nom")})})
        '
        'DsRapEtuProg1
        '
        Me.DsRapEtuProg1.DataSetName = "dsRapEtuProg"
        Me.DsRapEtuProg1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'frmRptEtuProg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1536, 715)
        Me.Controls.Add(Me.crv)
        Me.Name = "frmRptEtuProg"
        Me.Text = "frmRptEtuProg"
        CType(Me.DsRapEtuProg1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents crv As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
    Friend WithEvents cnRapEtuProg As SqlClient.SqlConnection
    Friend WithEvents daRapEtuProg As SqlClient.SqlDataAdapter
    Friend WithEvents DsRapEtuProg1 As dsRapEtuProg
End Class
