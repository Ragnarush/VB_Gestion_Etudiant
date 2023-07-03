<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptProg
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRptProg))
        Me.crv = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.cn = New System.Data.SqlClient.SqlConnection()
        Me.daRapProg = New System.Data.SqlClient.SqlDataAdapter()
        Me.DsRapProg1 = New VB_P44_TP2_v2210043_v1.dsRapProg()
        Me.SqlUpdateCommand = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand = New System.Data.SqlClient.SqlCommand()
        CType(Me.DsRapProg1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.crv.Size = New System.Drawing.Size(1413, 783)
        Me.crv.TabIndex = 0
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT        T_programme.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            T_programme"
        Me.SqlSelectCommand1.Connection = Me.cn
        '
        'cn
        '
        Me.cn.ConnectionString = "Data Source=RAGNAROCK\SQLEXPRESS;Initial Catalog=tp_p44;Integrated Security=True"
        Me.cn.FireInfoMessageEventOnUserErrors = False
        '
        'daRapProg
        '
        Me.daRapProg.DeleteCommand = Me.SqlDeleteCommand
        Me.daRapProg.SelectCommand = Me.SqlSelectCommand1
        Me.daRapProg.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "T_programme", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("pro_no", "pro_no"), New System.Data.Common.DataColumnMapping("pro_nom", "pro_nom"), New System.Data.Common.DataColumnMapping("pro_nbr_unites", "pro_nbr_unites"), New System.Data.Common.DataColumnMapping("pro_nbr_heures", "pro_nbr_heures")})})
        Me.daRapProg.UpdateCommand = Me.SqlUpdateCommand
        '
        'DsRapProg1
        '
        Me.DsRapProg1.DataSetName = "dsRapProg"
        Me.DsRapProg1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SqlUpdateCommand
        '
        Me.SqlUpdateCommand.CommandText = resources.GetString("SqlUpdateCommand.CommandText")
        Me.SqlUpdateCommand.Connection = Me.cn
        Me.SqlUpdateCommand.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@pro_no", System.Data.SqlDbType.VarChar, 0, "pro_no"), New System.Data.SqlClient.SqlParameter("@pro_nom", System.Data.SqlDbType.VarChar, 0, "pro_nom"), New System.Data.SqlClient.SqlParameter("@pro_nbr_unites", System.Data.SqlDbType.Float, 0, "pro_nbr_unites"), New System.Data.SqlClient.SqlParameter("@pro_nbr_heures", System.Data.SqlDbType.Int, 0, "pro_nbr_heures"), New System.Data.SqlClient.SqlParameter("@Original_pro_no", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pro_no", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_pro_nom", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pro_nom", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_pro_nbr_unites", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pro_nbr_unites", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_pro_nbr_heures", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "pro_nbr_heures", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_pro_nbr_heures", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pro_nbr_heures", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDeleteCommand
        '
        Me.SqlDeleteCommand.CommandText = resources.GetString("SqlDeleteCommand.CommandText")
        Me.SqlDeleteCommand.Connection = Me.cn
        Me.SqlDeleteCommand.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_pro_no", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pro_no", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_pro_nom", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pro_nom", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_pro_nbr_unites", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pro_nbr_unites", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_pro_nbr_heures", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "pro_nbr_heures", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_pro_nbr_heures", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pro_nbr_heures", System.Data.DataRowVersion.Original, Nothing)})
        '
        'frmRptProg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1413, 783)
        Me.Controls.Add(Me.crv)
        Me.Name = "frmRptProg"
        Me.Text = "frmRptProg"
        CType(Me.DsRapProg1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents crv As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
    Friend WithEvents cn As SqlClient.SqlConnection
    Friend WithEvents daRapProg As SqlClient.SqlDataAdapter
    Friend WithEvents DsRapProg1 As dsRapProg
    Friend WithEvents SqlDeleteCommand As SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand As SqlClient.SqlCommand
End Class
