<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProgramme
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProgramme))
        Me.mskNo = New System.Windows.Forms.MaskedTextBox()
        Me.bsProg = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsProg1 = New VB_P44_TP2_v2210043_v1.dsProg()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.lblHeures = New System.Windows.Forms.Label()
        Me.lblUnit = New System.Windows.Forms.Label()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.lblNo = New System.Windows.Forms.Label()
        Me.btnModifier = New System.Windows.Forms.Button()
        Me.btnAnnuler = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnNouveau = New System.Windows.Forms.Button()
        Me.grpProg = New System.Windows.Forms.GroupBox()
        Me.numHeures = New System.Windows.Forms.NumericUpDown()
        Me.numUnits = New System.Windows.Forms.NumericUpDown()
        Me.btnEnlever = New System.Windows.Forms.Button()
        Me.dgProg = New System.Windows.Forms.DataGridView()
        Me.PronoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PronomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PronbrunitesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PronbrheuresDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.err = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.dgEtu = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PronoDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DsEtu1 = New VB_P44_TP2_v2210043_v1.dsEtu()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.daProg = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.daEtuProg = New System.Data.SqlClient.SqlDataAdapter()
        Me.cnProg = New System.Data.SqlClient.SqlConnection()
        CType(Me.bsProg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProg1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpProg.SuspendLayout()
        CType(Me.numHeures, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numUnits, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgProg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.err, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgEtu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsEtu1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mskNo
        '
        Me.mskNo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsProg, "pro_no", True))
        Me.mskNo.Location = New System.Drawing.Point(218, 34)
        Me.mskNo.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.mskNo.Mask = ">LLL.0L"
        Me.mskNo.Name = "mskNo"
        Me.mskNo.Size = New System.Drawing.Size(81, 29)
        Me.mskNo.TabIndex = 5
        '
        'bsProg
        '
        Me.bsProg.DataMember = "T_programme"
        Me.bsProg.DataSource = Me.DsProg1
        '
        'DsProg1
        '
        Me.DsProg1.DataSetName = "dsProg"
        Me.DsProg1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtNom
        '
        Me.txtNom.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsProg, "pro_nom", True))
        Me.txtNom.Location = New System.Drawing.Point(218, 84)
        Me.txtNom.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.txtNom.MaxLength = 50
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(329, 29)
        Me.txtNom.TabIndex = 4
        '
        'lblHeures
        '
        Me.lblHeures.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHeures.Location = New System.Drawing.Point(25, 185)
        Me.lblHeures.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.lblHeures.Name = "lblHeures"
        Me.lblHeures.Size = New System.Drawing.Size(165, 29)
        Me.lblHeures.TabIndex = 3
        Me.lblHeures.Text = "Nombre d'heures"
        Me.lblHeures.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblUnit
        '
        Me.lblUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblUnit.Location = New System.Drawing.Point(25, 135)
        Me.lblUnit.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.lblUnit.Name = "lblUnit"
        Me.lblUnit.Size = New System.Drawing.Size(165, 29)
        Me.lblUnit.TabIndex = 2
        Me.lblUnit.Text = "Nombre d'unites:"
        Me.lblUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNom
        '
        Me.lblNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNom.Location = New System.Drawing.Point(25, 84)
        Me.lblNom.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(165, 29)
        Me.lblNom.TabIndex = 1
        Me.lblNom.Text = "Nom:"
        Me.lblNom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNo
        '
        Me.lblNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNo.Location = New System.Drawing.Point(25, 34)
        Me.lblNo.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.lblNo.Name = "lblNo"
        Me.lblNo.Size = New System.Drawing.Size(165, 29)
        Me.lblNo.TabIndex = 0
        Me.lblNo.Text = "No:"
        Me.lblNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnModifier
        '
        Me.btnModifier.BackColor = System.Drawing.Color.Gold
        Me.btnModifier.Location = New System.Drawing.Point(595, 64)
        Me.btnModifier.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.btnModifier.Name = "btnModifier"
        Me.btnModifier.Size = New System.Drawing.Size(339, 46)
        Me.btnModifier.TabIndex = 28
        Me.btnModifier.Text = "Modifier"
        Me.btnModifier.UseVisualStyleBackColor = False
        '
        'btnAnnuler
        '
        Me.btnAnnuler.BackColor = System.Drawing.Color.Gold
        Me.btnAnnuler.Location = New System.Drawing.Point(595, 161)
        Me.btnAnnuler.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.btnAnnuler.Name = "btnAnnuler"
        Me.btnAnnuler.Size = New System.Drawing.Size(339, 46)
        Me.btnAnnuler.TabIndex = 27
        Me.btnAnnuler.Text = "Annuler"
        Me.btnAnnuler.UseVisualStyleBackColor = False
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.Color.Gold
        Me.btnOk.Location = New System.Drawing.Point(595, 208)
        Me.btnOk.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(339, 46)
        Me.btnOk.TabIndex = 26
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = False
        '
        'btnNouveau
        '
        Me.btnNouveau.BackColor = System.Drawing.Color.Gold
        Me.btnNouveau.Location = New System.Drawing.Point(595, 15)
        Me.btnNouveau.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.btnNouveau.Name = "btnNouveau"
        Me.btnNouveau.Size = New System.Drawing.Size(339, 46)
        Me.btnNouveau.TabIndex = 25
        Me.btnNouveau.Text = "Nouveau"
        Me.btnNouveau.UseVisualStyleBackColor = False
        '
        'grpProg
        '
        Me.grpProg.BackColor = System.Drawing.Color.Wheat
        Me.grpProg.Controls.Add(Me.numHeures)
        Me.grpProg.Controls.Add(Me.numUnits)
        Me.grpProg.Controls.Add(Me.mskNo)
        Me.grpProg.Controls.Add(Me.txtNom)
        Me.grpProg.Controls.Add(Me.lblHeures)
        Me.grpProg.Controls.Add(Me.lblUnit)
        Me.grpProg.Controls.Add(Me.lblNom)
        Me.grpProg.Controls.Add(Me.lblNo)
        Me.grpProg.Font = New System.Drawing.Font("Algerian", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpProg.ForeColor = System.Drawing.Color.Black
        Me.grpProg.Location = New System.Drawing.Point(17, 15)
        Me.grpProg.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.grpProg.Name = "grpProg"
        Me.grpProg.Padding = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.grpProg.Size = New System.Drawing.Size(569, 239)
        Me.grpProg.TabIndex = 24
        Me.grpProg.TabStop = False
        Me.grpProg.Text = "Programme"
        '
        'numHeures
        '
        Me.numHeures.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.bsProg, "pro_nbr_heures", True))
        Me.numHeures.Location = New System.Drawing.Point(218, 185)
        Me.numHeures.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.numHeures.Name = "numHeures"
        Me.numHeures.Size = New System.Drawing.Size(81, 29)
        Me.numHeures.TabIndex = 9
        '
        'numUnits
        '
        Me.numUnits.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.bsProg, "pro_nbr_unites", True))
        Me.numUnits.DecimalPlaces = 2
        Me.numUnits.Location = New System.Drawing.Point(218, 135)
        Me.numUnits.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.numUnits.Name = "numUnits"
        Me.numUnits.Size = New System.Drawing.Size(81, 29)
        Me.numUnits.TabIndex = 8
        '
        'btnEnlever
        '
        Me.btnEnlever.BackColor = System.Drawing.Color.Gold
        Me.btnEnlever.Location = New System.Drawing.Point(595, 112)
        Me.btnEnlever.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.btnEnlever.Name = "btnEnlever"
        Me.btnEnlever.Size = New System.Drawing.Size(339, 46)
        Me.btnEnlever.TabIndex = 29
        Me.btnEnlever.Text = "Enlever"
        Me.btnEnlever.UseVisualStyleBackColor = False
        '
        'dgProg
        '
        Me.dgProg.AutoGenerateColumns = False
        Me.dgProg.BackgroundColor = System.Drawing.Color.Moccasin
        Me.dgProg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgProg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PronoDataGridViewTextBoxColumn, Me.PronomDataGridViewTextBoxColumn, Me.PronbrunitesDataGridViewTextBoxColumn, Me.PronbrheuresDataGridViewTextBoxColumn})
        Me.dgProg.DataSource = Me.bsProg
        Me.dgProg.Location = New System.Drawing.Point(17, 263)
        Me.dgProg.MultiSelect = False
        Me.dgProg.Name = "dgProg"
        Me.dgProg.ReadOnly = True
        Me.dgProg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgProg.Size = New System.Drawing.Size(917, 347)
        Me.dgProg.TabIndex = 30
        '
        'PronoDataGridViewTextBoxColumn
        '
        Me.PronoDataGridViewTextBoxColumn.DataPropertyName = "pro_no"
        Me.PronoDataGridViewTextBoxColumn.HeaderText = "No"
        Me.PronoDataGridViewTextBoxColumn.MaxInputLength = 6
        Me.PronoDataGridViewTextBoxColumn.Name = "PronoDataGridViewTextBoxColumn"
        Me.PronoDataGridViewTextBoxColumn.ReadOnly = True
        Me.PronoDataGridViewTextBoxColumn.Width = 150
        '
        'PronomDataGridViewTextBoxColumn
        '
        Me.PronomDataGridViewTextBoxColumn.DataPropertyName = "pro_nom"
        Me.PronomDataGridViewTextBoxColumn.HeaderText = "Nom"
        Me.PronomDataGridViewTextBoxColumn.Name = "PronomDataGridViewTextBoxColumn"
        Me.PronomDataGridViewTextBoxColumn.ReadOnly = True
        Me.PronomDataGridViewTextBoxColumn.Width = 425
        '
        'PronbrunitesDataGridViewTextBoxColumn
        '
        Me.PronbrunitesDataGridViewTextBoxColumn.DataPropertyName = "pro_nbr_unites"
        Me.PronbrunitesDataGridViewTextBoxColumn.HeaderText = "Nbr. Unités"
        Me.PronbrunitesDataGridViewTextBoxColumn.Name = "PronbrunitesDataGridViewTextBoxColumn"
        Me.PronbrunitesDataGridViewTextBoxColumn.ReadOnly = True
        Me.PronbrunitesDataGridViewTextBoxColumn.Width = 150
        '
        'PronbrheuresDataGridViewTextBoxColumn
        '
        Me.PronbrheuresDataGridViewTextBoxColumn.DataPropertyName = "pro_nbr_heures"
        Me.PronbrheuresDataGridViewTextBoxColumn.HeaderText = "Nbr. Heures"
        Me.PronbrheuresDataGridViewTextBoxColumn.Name = "PronbrheuresDataGridViewTextBoxColumn"
        Me.PronbrheuresDataGridViewTextBoxColumn.ReadOnly = True
        Me.PronbrheuresDataGridViewTextBoxColumn.Width = 150
        '
        'err
        '
        Me.err.ContainerControl = Me
        '
        'dgEtu
        '
        Me.dgEtu.AutoGenerateColumns = False
        Me.dgEtu.BackgroundColor = System.Drawing.Color.Moccasin
        Me.dgEtu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgEtu.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.PronoDataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.dgEtu.DataMember = "T_etudiants"
        Me.dgEtu.DataSource = Me.DsEtu1
        Me.dgEtu.Location = New System.Drawing.Point(945, 15)
        Me.dgEtu.Name = "dgEtu"
        Me.dgEtu.ReadOnly = True
        Me.dgEtu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgEtu.Size = New System.Drawing.Size(810, 595)
        Me.dgEtu.TabIndex = 31
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "etu_da"
        Me.DataGridViewTextBoxColumn1.HeaderText = "DA"
        Me.DataGridViewTextBoxColumn1.MaxInputLength = 7
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 115
        '
        'PronoDataGridViewTextBoxColumn2
        '
        Me.PronoDataGridViewTextBoxColumn2.DataPropertyName = "pro_no"
        Me.PronoDataGridViewTextBoxColumn2.HeaderText = "No Prog."
        Me.PronoDataGridViewTextBoxColumn2.Name = "PronoDataGridViewTextBoxColumn2"
        Me.PronoDataGridViewTextBoxColumn2.ReadOnly = True
        Me.PronoDataGridViewTextBoxColumn2.Width = 115
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "etu_prenom"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Prénom"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 275
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "etu_nom"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nom"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 275
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "etu_sexe"
        Me.DataGridViewTextBoxColumn4.HeaderText = "etu_sexe"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "etu_adresse"
        Me.DataGridViewTextBoxColumn5.HeaderText = "etu_adresse"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "etu_ville"
        Me.DataGridViewTextBoxColumn6.HeaderText = "etu_ville"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Visible = False
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "etu_province"
        Me.DataGridViewTextBoxColumn7.HeaderText = "etu_province"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "etu_telephone"
        Me.DataGridViewTextBoxColumn8.HeaderText = "etu_telephone"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "etu_codepostal"
        Me.DataGridViewTextBoxColumn9.HeaderText = "etu_codepostal"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Visible = False
        '
        'DsEtu1
        '
        Me.DsEtu1.DataSetName = "dsEtu"
        Me.DsEtu1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT pro_no, pro_nom, pro_nbr_unites, pro_nbr_heures" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM   T_programme"
        Me.SqlSelectCommand1.Connection = Me.cnProg
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.cnProg
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@pro_no", System.Data.SqlDbType.VarChar, 0, "pro_no"), New System.Data.SqlClient.SqlParameter("@pro_nom", System.Data.SqlDbType.VarChar, 0, "pro_nom"), New System.Data.SqlClient.SqlParameter("@pro_nbr_unites", System.Data.SqlDbType.Float, 0, "pro_nbr_unites"), New System.Data.SqlClient.SqlParameter("@pro_nbr_heures", System.Data.SqlDbType.Int, 0, "pro_nbr_heures")})
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.cnProg
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@pro_no", System.Data.SqlDbType.VarChar, 0, "pro_no"), New System.Data.SqlClient.SqlParameter("@pro_nom", System.Data.SqlDbType.VarChar, 0, "pro_nom"), New System.Data.SqlClient.SqlParameter("@pro_nbr_unites", System.Data.SqlDbType.Float, 0, "pro_nbr_unites"), New System.Data.SqlClient.SqlParameter("@pro_nbr_heures", System.Data.SqlDbType.Int, 0, "pro_nbr_heures"), New System.Data.SqlClient.SqlParameter("@Original_pro_no", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pro_no", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_pro_nom", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pro_nom", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_pro_nbr_unites", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pro_nbr_unites", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_pro_nbr_heures", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "pro_nbr_heures", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_pro_nbr_heures", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pro_nbr_heures", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.cnProg
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_pro_no", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pro_no", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_pro_nom", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pro_nom", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_pro_nbr_unites", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pro_nbr_unites", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_pro_nbr_heures", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "pro_nbr_heures", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_pro_nbr_heures", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pro_nbr_heures", System.Data.DataRowVersion.Original, Nothing)})
        '
        'daProg
        '
        Me.daProg.DeleteCommand = Me.SqlDeleteCommand1
        Me.daProg.InsertCommand = Me.SqlInsertCommand1
        Me.daProg.SelectCommand = Me.SqlSelectCommand1
        Me.daProg.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "T_programme", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("pro_no", "pro_no"), New System.Data.Common.DataColumnMapping("pro_nom", "pro_nom"), New System.Data.Common.DataColumnMapping("pro_nbr_unites", "pro_nbr_unites"), New System.Data.Common.DataColumnMapping("pro_nbr_heures", "pro_nbr_heures")})})
        Me.daProg.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "select * from T_etudiants" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "inner join T_programme" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "on T_etudiants.pro_no = T_prog" &
    "ramme.pro_no" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "where T_etudiants.pro_no = @Noprog"
        Me.SqlSelectCommand2.Connection = Me.cnProg
        Me.SqlSelectCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Noprog", System.Data.SqlDbType.VarChar, 6, "pro_no")})
        '
        'daEtuProg
        '
        Me.daEtuProg.SelectCommand = Me.SqlSelectCommand2
        Me.daEtuProg.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "T_etudiants", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("etu_da", "etu_da"), New System.Data.Common.DataColumnMapping("pro_no", "pro_no"), New System.Data.Common.DataColumnMapping("etu_nom", "etu_nom"), New System.Data.Common.DataColumnMapping("etu_prenom", "etu_prenom"), New System.Data.Common.DataColumnMapping("etu_sexe", "etu_sexe"), New System.Data.Common.DataColumnMapping("etu_adresse", "etu_adresse"), New System.Data.Common.DataColumnMapping("etu_ville", "etu_ville"), New System.Data.Common.DataColumnMapping("etu_province", "etu_province"), New System.Data.Common.DataColumnMapping("etu_telephone", "etu_telephone"), New System.Data.Common.DataColumnMapping("etu_codepostal", "etu_codepostal"), New System.Data.Common.DataColumnMapping("pro_no1", "pro_no1"), New System.Data.Common.DataColumnMapping("pro_nom", "pro_nom"), New System.Data.Common.DataColumnMapping("pro_nbr_unites", "pro_nbr_unites"), New System.Data.Common.DataColumnMapping("pro_nbr_heures", "pro_nbr_heures")})})
        '
        'cnProg
        '
        Me.cnProg.ConnectionString = "Data Source=RAGNAROCK\SQLEXPRESS;Initial Catalog=tp_p44;Integrated Security=True"
        Me.cnProg.FireInfoMessageEventOnUserErrors = False
        '
        'frmProgramme
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1773, 622)
        Me.Controls.Add(Me.dgEtu)
        Me.Controls.Add(Me.dgProg)
        Me.Controls.Add(Me.btnModifier)
        Me.Controls.Add(Me.btnAnnuler)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnNouveau)
        Me.Controls.Add(Me.grpProg)
        Me.Controls.Add(Me.btnEnlever)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmProgramme"
        Me.Text = "frmProgramme"
        CType(Me.bsProg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProg1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpProg.ResumeLayout(False)
        Me.grpProg.PerformLayout()
        CType(Me.numHeures, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numUnits, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgProg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.err, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgEtu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsEtu1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents mskNo As MaskedTextBox
    Friend WithEvents txtNom As TextBox
    Friend WithEvents lblHeures As Label
    Friend WithEvents lblUnit As Label
    Friend WithEvents lblNom As Label
    Friend WithEvents lblNo As Label
    Friend WithEvents btnModifier As Button
    Friend WithEvents btnAnnuler As Button
    Friend WithEvents btnOk As Button
    Friend WithEvents btnNouveau As Button
    Friend WithEvents grpProg As GroupBox
    Friend WithEvents btnEnlever As Button
    Friend WithEvents numHeures As NumericUpDown
    Friend WithEvents numUnits As NumericUpDown
    Friend WithEvents EtudaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PronoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents EtuprenomDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EtunomDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EtusexeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EtuadresseDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EtuvilleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EtuprovinceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EtutelephoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EtucodepostalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Expr1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PronomDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents PronbrunitesDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents PronbrheuresDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents dgProg As DataGridView
    Friend WithEvents dgEtu As DataGridView
    Friend WithEvents err As ErrorProvider
    Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As SqlClient.SqlCommand
    Friend WithEvents daProg As SqlClient.SqlDataAdapter
    Friend WithEvents bsProg As BindingSource
    Friend WithEvents DsProg1 As dsProg
    Friend WithEvents SqlSelectCommand2 As SqlClient.SqlCommand
    Friend WithEvents daEtuProg As SqlClient.SqlDataAdapter
    Friend WithEvents DsEtu1 As dsEtu
    Friend WithEvents PronoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PronomDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PronbrunitesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PronbrheuresDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents PronoDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents cnProg As SqlClient.SqlConnection
End Class
