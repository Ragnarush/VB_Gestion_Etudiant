<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRptEtu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRptEtu))
        Me.crv = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.daRapEtu = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlInsertCommand = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand = New System.Data.SqlClient.SqlCommand()
        Me.cnRapEtu = New System.Data.SqlClient.SqlConnection()
        Me.DsRapEtu1 = New VB_P44_TP2_v2210043_v1.dsRapEtu()
        CType(Me.DsRapEtu1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.crv.Size = New System.Drawing.Size(1578, 812)
        Me.crv.TabIndex = 0
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT        etu_da, pro_no, etu_nom, etu_prenom, etu_sexe, etu_adresse, etu_vil" &
    "le, etu_province, etu_telephone, etu_codepostal" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            T_etudiants"
        Me.SqlSelectCommand1.Connection = Me.cnRapEtu
        '
        'daRapEtu
        '
        Me.daRapEtu.DeleteCommand = Me.SqlDeleteCommand
        Me.daRapEtu.InsertCommand = Me.SqlInsertCommand
        Me.daRapEtu.SelectCommand = Me.SqlSelectCommand1
        Me.daRapEtu.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "T_etudiants", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("etu_da", "etu_da"), New System.Data.Common.DataColumnMapping("pro_no", "pro_no"), New System.Data.Common.DataColumnMapping("etu_nom", "etu_nom"), New System.Data.Common.DataColumnMapping("etu_prenom", "etu_prenom"), New System.Data.Common.DataColumnMapping("etu_sexe", "etu_sexe"), New System.Data.Common.DataColumnMapping("etu_adresse", "etu_adresse"), New System.Data.Common.DataColumnMapping("etu_ville", "etu_ville"), New System.Data.Common.DataColumnMapping("etu_province", "etu_province"), New System.Data.Common.DataColumnMapping("etu_telephone", "etu_telephone"), New System.Data.Common.DataColumnMapping("etu_codepostal", "etu_codepostal")})})
        Me.daRapEtu.UpdateCommand = Me.SqlUpdateCommand
        '
        'SqlInsertCommand
        '
        Me.SqlInsertCommand.CommandText = resources.GetString("SqlInsertCommand.CommandText")
        Me.SqlInsertCommand.Connection = Me.cnRapEtu
        Me.SqlInsertCommand.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@etu_da", System.Data.SqlDbType.VarChar, 0, "etu_da"), New System.Data.SqlClient.SqlParameter("@pro_no", System.Data.SqlDbType.VarChar, 0, "pro_no"), New System.Data.SqlClient.SqlParameter("@etu_nom", System.Data.SqlDbType.VarChar, 0, "etu_nom"), New System.Data.SqlClient.SqlParameter("@etu_prenom", System.Data.SqlDbType.VarChar, 0, "etu_prenom"), New System.Data.SqlClient.SqlParameter("@etu_sexe", System.Data.SqlDbType.[Char], 0, "etu_sexe"), New System.Data.SqlClient.SqlParameter("@etu_adresse", System.Data.SqlDbType.VarChar, 0, "etu_adresse"), New System.Data.SqlClient.SqlParameter("@etu_ville", System.Data.SqlDbType.VarChar, 0, "etu_ville"), New System.Data.SqlClient.SqlParameter("@etu_province", System.Data.SqlDbType.VarChar, 0, "etu_province"), New System.Data.SqlClient.SqlParameter("@etu_telephone", System.Data.SqlDbType.VarChar, 0, "etu_telephone"), New System.Data.SqlClient.SqlParameter("@etu_codepostal", System.Data.SqlDbType.VarChar, 0, "etu_codepostal")})
        '
        'SqlUpdateCommand
        '
        Me.SqlUpdateCommand.CommandText = resources.GetString("SqlUpdateCommand.CommandText")
        Me.SqlUpdateCommand.Connection = Me.cnRapEtu
        Me.SqlUpdateCommand.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@etu_da", System.Data.SqlDbType.VarChar, 0, "etu_da"), New System.Data.SqlClient.SqlParameter("@pro_no", System.Data.SqlDbType.VarChar, 0, "pro_no"), New System.Data.SqlClient.SqlParameter("@etu_nom", System.Data.SqlDbType.VarChar, 0, "etu_nom"), New System.Data.SqlClient.SqlParameter("@etu_prenom", System.Data.SqlDbType.VarChar, 0, "etu_prenom"), New System.Data.SqlClient.SqlParameter("@etu_sexe", System.Data.SqlDbType.[Char], 0, "etu_sexe"), New System.Data.SqlClient.SqlParameter("@etu_adresse", System.Data.SqlDbType.VarChar, 0, "etu_adresse"), New System.Data.SqlClient.SqlParameter("@etu_ville", System.Data.SqlDbType.VarChar, 0, "etu_ville"), New System.Data.SqlClient.SqlParameter("@etu_province", System.Data.SqlDbType.VarChar, 0, "etu_province"), New System.Data.SqlClient.SqlParameter("@etu_telephone", System.Data.SqlDbType.VarChar, 0, "etu_telephone"), New System.Data.SqlClient.SqlParameter("@etu_codepostal", System.Data.SqlDbType.VarChar, 0, "etu_codepostal"), New System.Data.SqlClient.SqlParameter("@Original_etu_da", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_da", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_pro_no", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pro_no", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_etu_nom", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_nom", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_etu_prenom", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_prenom", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_etu_sexe", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "etu_sexe", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_etu_sexe", System.Data.SqlDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_sexe", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_etu_adresse", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "etu_adresse", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_etu_adresse", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_adresse", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_etu_ville", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "etu_ville", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_etu_ville", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_ville", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_etu_province", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "etu_province", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_etu_province", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_province", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_etu_telephone", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "etu_telephone", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_etu_telephone", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_telephone", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_etu_codepostal", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "etu_codepostal", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_etu_codepostal", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_codepostal", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDeleteCommand
        '
        Me.SqlDeleteCommand.CommandText = resources.GetString("SqlDeleteCommand.CommandText")
        Me.SqlDeleteCommand.Connection = Me.cnRapEtu
        Me.SqlDeleteCommand.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_etu_da", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_da", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_pro_no", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pro_no", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_etu_nom", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_nom", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_etu_prenom", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_prenom", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_etu_sexe", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "etu_sexe", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_etu_sexe", System.Data.SqlDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_sexe", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_etu_adresse", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "etu_adresse", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_etu_adresse", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_adresse", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_etu_ville", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "etu_ville", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_etu_ville", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_ville", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_etu_province", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "etu_province", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_etu_province", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_province", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_etu_telephone", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "etu_telephone", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_etu_telephone", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_telephone", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_etu_codepostal", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "etu_codepostal", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_etu_codepostal", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_codepostal", System.Data.DataRowVersion.Original, Nothing)})
        '
        'cnRapEtu
        '
        Me.cnRapEtu.ConnectionString = "Data Source=RAGNAROCK\SQLEXPRESS;Initial Catalog=tp_p44;Integrated Security=True"
        Me.cnRapEtu.FireInfoMessageEventOnUserErrors = False
        '
        'DsRapEtu1
        '
        Me.DsRapEtu1.DataSetName = "dsRapEtu"
        Me.DsRapEtu1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'frmRptEtu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1578, 812)
        Me.Controls.Add(Me.crv)
        Me.Name = "frmRptEtu"
        Me.Text = "frmRapport"
        CType(Me.DsRapEtu1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents crv As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
    Friend WithEvents daRapEtu As SqlClient.SqlDataAdapter
    Friend WithEvents SqlDeleteCommand As SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand As SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand As SqlClient.SqlCommand
    Friend WithEvents cnRapEtu As SqlClient.SqlConnection
    Friend WithEvents DsRapEtu1 As dsRapEtu
End Class
