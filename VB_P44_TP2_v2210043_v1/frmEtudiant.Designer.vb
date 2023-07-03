<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEtudiant
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEtudiant))
        Me.rbUnspecified = New System.Windows.Forms.RadioButton()
        Me.rbMasculin = New System.Windows.Forms.RadioButton()
        Me.rbFeminin = New System.Windows.Forms.RadioButton()
        Me.bsEtu = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsEtu1 = New VB_P44_TP2_v2210043_v1.dsEtu()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mskPhone = New System.Windows.Forms.MaskedTextBox()
        Me.mskZip = New System.Windows.Forms.MaskedTextBox()
        Me.cbProvince = New System.Windows.Forms.ComboBox()
        Me.txtVille = New System.Windows.Forms.TextBox()
        Me.txtAdresse = New System.Windows.Forms.TextBox()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblZip = New System.Windows.Forms.Label()
        Me.lblProvince = New System.Windows.Forms.Label()
        Me.btnEnlever = New System.Windows.Forms.Button()
        Me.grpEtudiant = New System.Windows.Forms.GroupBox()
        Me.mskSex = New System.Windows.Forms.MaskedTextBox()
        Me.grpSexe = New System.Windows.Forms.GroupBox()
        Me.lblVille = New System.Windows.Forms.Label()
        Me.lblAdresse = New System.Windows.Forms.Label()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.txtPrenom = New System.Windows.Forms.TextBox()
        Me.cbNoProg = New System.Windows.Forms.ComboBox()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.lblPrenom = New System.Windows.Forms.Label()
        Me.lblNoProg = New System.Windows.Forms.Label()
        Me.mskDa = New System.Windows.Forms.MaskedTextBox()
        Me.lblDa = New System.Windows.Forms.Label()
        Me.btnModifier = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnAnnuler = New System.Windows.Forms.Button()
        Me.btnNouveau = New System.Windows.Forms.Button()
        Me.erp = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.dgEtu1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cnEtu = New System.Data.SqlClient.SqlConnection()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.daEtu = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.daProg = New System.Data.SqlClient.SqlDataAdapter()
        CType(Me.bsEtu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsEtu1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpEtudiant.SuspendLayout()
        Me.grpSexe.SuspendLayout()
        CType(Me.erp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgEtu1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rbUnspecified
        '
        Me.rbUnspecified.AutoSize = True
        Me.rbUnspecified.Location = New System.Drawing.Point(250, 18)
        Me.rbUnspecified.Margin = New System.Windows.Forms.Padding(4)
        Me.rbUnspecified.Name = "rbUnspecified"
        Me.rbUnspecified.Size = New System.Drawing.Size(111, 24)
        Me.rbUnspecified.TabIndex = 2
        Me.rbUnspecified.TabStop = True
        Me.rbUnspecified.Text = "Unspecified"
        Me.rbUnspecified.UseVisualStyleBackColor = True
        '
        'rbMasculin
        '
        Me.rbMasculin.AutoSize = True
        Me.rbMasculin.Location = New System.Drawing.Point(122, 18)
        Me.rbMasculin.Margin = New System.Windows.Forms.Padding(4)
        Me.rbMasculin.Name = "rbMasculin"
        Me.rbMasculin.Size = New System.Drawing.Size(89, 24)
        Me.rbMasculin.TabIndex = 1
        Me.rbMasculin.TabStop = True
        Me.rbMasculin.Text = "Masculin"
        Me.rbMasculin.UseVisualStyleBackColor = True
        '
        'rbFeminin
        '
        Me.rbFeminin.AutoSize = True
        Me.rbFeminin.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.bsEtu, "etu_sexe", True))
        Me.rbFeminin.Location = New System.Drawing.Point(8, 18)
        Me.rbFeminin.Margin = New System.Windows.Forms.Padding(4)
        Me.rbFeminin.Name = "rbFeminin"
        Me.rbFeminin.Size = New System.Drawing.Size(83, 24)
        Me.rbFeminin.TabIndex = 0
        Me.rbFeminin.TabStop = True
        Me.rbFeminin.Text = "Feminin"
        Me.rbFeminin.UseVisualStyleBackColor = True
        '
        'bsEtu
        '
        Me.bsEtu.DataMember = "T_etudiants"
        Me.bsEtu.DataSource = Me.DsEtu1
        '
        'DsEtu1
        '
        Me.DsEtu1.DataSetName = "dsEtu"
        Me.DsEtu1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(27, 230)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 32)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Sexe:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'mskPhone
        '
        Me.mskPhone.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsEtu, "etu_telephone", True))
        Me.mskPhone.Location = New System.Drawing.Point(1130, 230)
        Me.mskPhone.Margin = New System.Windows.Forms.Padding(4)
        Me.mskPhone.Mask = "(000) 000-0000"
        Me.mskPhone.Name = "mskPhone"
        Me.mskPhone.Size = New System.Drawing.Size(288, 26)
        Me.mskPhone.TabIndex = 18
        '
        'mskZip
        '
        Me.mskZip.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsEtu, "etu_codepostal", True))
        Me.mskZip.Location = New System.Drawing.Point(1130, 178)
        Me.mskZip.Margin = New System.Windows.Forms.Padding(4)
        Me.mskZip.Mask = ">L0L-0L0"
        Me.mskZip.Name = "mskZip"
        Me.mskZip.Size = New System.Drawing.Size(288, 26)
        Me.mskZip.TabIndex = 17
        '
        'cbProvince
        '
        Me.cbProvince.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.bsEtu, "etu_province", True))
        Me.cbProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProvince.FormattingEnabled = True
        Me.cbProvince.Items.AddRange(New Object() {"Québec", "Ontario", "Manitoba", "Saskatchewan", "Alberta", "Colombie-Britannique", "Nouveau-Brunswick", "Nouvelle-Ecosse", "Ile-du-Prince-Edouard", "Terre-Neuve", "Nunavik", "Territoire du N-O", "Yukon"})
        Me.cbProvince.Location = New System.Drawing.Point(1130, 130)
        Me.cbProvince.Margin = New System.Windows.Forms.Padding(4)
        Me.cbProvince.Name = "cbProvince"
        Me.cbProvince.Size = New System.Drawing.Size(620, 28)
        Me.cbProvince.TabIndex = 16
        '
        'txtVille
        '
        Me.txtVille.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsEtu, "etu_ville", True))
        Me.txtVille.Location = New System.Drawing.Point(1130, 78)
        Me.txtVille.Margin = New System.Windows.Forms.Padding(4)
        Me.txtVille.MaxLength = 50
        Me.txtVille.Name = "txtVille"
        Me.txtVille.Size = New System.Drawing.Size(620, 26)
        Me.txtVille.TabIndex = 15
        '
        'txtAdresse
        '
        Me.txtAdresse.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsEtu, "etu_adresse", True))
        Me.txtAdresse.Location = New System.Drawing.Point(1130, 28)
        Me.txtAdresse.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAdresse.MaxLength = 100
        Me.txtAdresse.Name = "txtAdresse"
        Me.txtAdresse.Size = New System.Drawing.Size(620, 26)
        Me.txtAdresse.TabIndex = 14
        '
        'lblPhone
        '
        Me.lblPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPhone.Location = New System.Drawing.Point(896, 230)
        Me.lblPhone.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(196, 30)
        Me.lblPhone.TabIndex = 13
        Me.lblPhone.Text = "Telephone:"
        Me.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblZip
        '
        Me.lblZip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblZip.Location = New System.Drawing.Point(896, 178)
        Me.lblZip.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblZip.Name = "lblZip"
        Me.lblZip.Size = New System.Drawing.Size(196, 30)
        Me.lblZip.TabIndex = 12
        Me.lblZip.Text = "Code Postal:"
        Me.lblZip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblProvince
        '
        Me.lblProvince.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProvince.Location = New System.Drawing.Point(896, 128)
        Me.lblProvince.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblProvince.Name = "lblProvince"
        Me.lblProvince.Size = New System.Drawing.Size(196, 31)
        Me.lblProvince.TabIndex = 11
        Me.lblProvince.Text = "Province:"
        Me.lblProvince.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnEnlever
        '
        Me.btnEnlever.BackColor = System.Drawing.Color.YellowGreen
        Me.btnEnlever.Location = New System.Drawing.Point(1691, 749)
        Me.btnEnlever.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEnlever.Name = "btnEnlever"
        Me.btnEnlever.Size = New System.Drawing.Size(100, 102)
        Me.btnEnlever.TabIndex = 19
        Me.btnEnlever.Text = "Enlever"
        Me.btnEnlever.UseVisualStyleBackColor = False
        '
        'grpEtudiant
        '
        Me.grpEtudiant.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.grpEtudiant.Controls.Add(Me.mskSex)
        Me.grpEtudiant.Controls.Add(Me.Label1)
        Me.grpEtudiant.Controls.Add(Me.mskPhone)
        Me.grpEtudiant.Controls.Add(Me.mskZip)
        Me.grpEtudiant.Controls.Add(Me.cbProvince)
        Me.grpEtudiant.Controls.Add(Me.txtVille)
        Me.grpEtudiant.Controls.Add(Me.txtAdresse)
        Me.grpEtudiant.Controls.Add(Me.lblPhone)
        Me.grpEtudiant.Controls.Add(Me.grpSexe)
        Me.grpEtudiant.Controls.Add(Me.lblZip)
        Me.grpEtudiant.Controls.Add(Me.lblProvince)
        Me.grpEtudiant.Controls.Add(Me.lblVille)
        Me.grpEtudiant.Controls.Add(Me.lblAdresse)
        Me.grpEtudiant.Controls.Add(Me.txtNom)
        Me.grpEtudiant.Controls.Add(Me.txtPrenom)
        Me.grpEtudiant.Controls.Add(Me.cbNoProg)
        Me.grpEtudiant.Controls.Add(Me.lblNom)
        Me.grpEtudiant.Controls.Add(Me.lblPrenom)
        Me.grpEtudiant.Controls.Add(Me.lblNoProg)
        Me.grpEtudiant.Controls.Add(Me.mskDa)
        Me.grpEtudiant.Controls.Add(Me.lblDa)
        Me.grpEtudiant.ForeColor = System.Drawing.Color.Black
        Me.grpEtudiant.Location = New System.Drawing.Point(17, 15)
        Me.grpEtudiant.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.grpEtudiant.Name = "grpEtudiant"
        Me.grpEtudiant.Padding = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.grpEtudiant.Size = New System.Drawing.Size(1774, 284)
        Me.grpEtudiant.TabIndex = 14
        Me.grpEtudiant.TabStop = False
        Me.grpEtudiant.Text = "Etudiant"
        '
        'mskSex
        '
        Me.mskSex.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsEtu, "etu_sexe", True))
        Me.mskSex.Location = New System.Drawing.Point(259, 234)
        Me.mskSex.Mask = ">?"
        Me.mskSex.Name = "mskSex"
        Me.mskSex.Size = New System.Drawing.Size(102, 26)
        Me.mskSex.TabIndex = 21
        Me.mskSex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grpSexe
        '
        Me.grpSexe.Controls.Add(Me.rbUnspecified)
        Me.grpSexe.Controls.Add(Me.rbMasculin)
        Me.grpSexe.Controls.Add(Me.rbFeminin)
        Me.grpSexe.ForeColor = System.Drawing.Color.Black
        Me.grpSexe.Location = New System.Drawing.Point(480, 210)
        Me.grpSexe.Margin = New System.Windows.Forms.Padding(4)
        Me.grpSexe.Name = "grpSexe"
        Me.grpSexe.Padding = New System.Windows.Forms.Padding(4)
        Me.grpSexe.Size = New System.Drawing.Size(385, 52)
        Me.grpSexe.TabIndex = 8
        Me.grpSexe.TabStop = False
        '
        'lblVille
        '
        Me.lblVille.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblVille.Location = New System.Drawing.Point(896, 74)
        Me.lblVille.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVille.Name = "lblVille"
        Me.lblVille.Size = New System.Drawing.Size(196, 32)
        Me.lblVille.TabIndex = 10
        Me.lblVille.Text = "Ville:"
        Me.lblVille.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAdresse
        '
        Me.lblAdresse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAdresse.Location = New System.Drawing.Point(896, 28)
        Me.lblAdresse.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAdresse.Name = "lblAdresse"
        Me.lblAdresse.Size = New System.Drawing.Size(196, 30)
        Me.lblAdresse.TabIndex = 9
        Me.lblAdresse.Text = "Adresse:"
        Me.lblAdresse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNom
        '
        Me.txtNom.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsEtu, "etu_nom", True))
        Me.txtNom.Location = New System.Drawing.Point(259, 178)
        Me.txtNom.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNom.MaxLength = 20
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(606, 26)
        Me.txtNom.TabIndex = 7
        '
        'txtPrenom
        '
        Me.txtPrenom.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsEtu, "etu_prenom", True))
        Me.txtPrenom.Location = New System.Drawing.Point(259, 128)
        Me.txtPrenom.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPrenom.MaxLength = 20
        Me.txtPrenom.Name = "txtPrenom"
        Me.txtPrenom.Size = New System.Drawing.Size(606, 26)
        Me.txtPrenom.TabIndex = 6
        '
        'cbNoProg
        '
        Me.cbNoProg.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsEtu, "pro_no", True))
        Me.cbNoProg.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.bsEtu, "pro_no", True))
        Me.cbNoProg.DataSource = Me.DsEtu1
        Me.cbNoProg.DisplayMember = "T_programme.pro_no"
        Me.cbNoProg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbNoProg.FormattingEnabled = True
        Me.cbNoProg.Location = New System.Drawing.Point(259, 76)
        Me.cbNoProg.Margin = New System.Windows.Forms.Padding(4)
        Me.cbNoProg.MaxLength = 6
        Me.cbNoProg.Name = "cbNoProg"
        Me.cbNoProg.Size = New System.Drawing.Size(164, 28)
        Me.cbNoProg.TabIndex = 5
        Me.cbNoProg.ValueMember = "T_programme.pro_no"
        '
        'lblNom
        '
        Me.lblNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNom.Location = New System.Drawing.Point(27, 175)
        Me.lblNom.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(196, 32)
        Me.lblNom.TabIndex = 4
        Me.lblNom.Text = "Nom:"
        Me.lblNom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPrenom
        '
        Me.lblPrenom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPrenom.Location = New System.Drawing.Point(27, 124)
        Me.lblPrenom.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPrenom.Name = "lblPrenom"
        Me.lblPrenom.Size = New System.Drawing.Size(196, 32)
        Me.lblPrenom.TabIndex = 3
        Me.lblPrenom.Text = "Prenom:"
        Me.lblPrenom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNoProg
        '
        Me.lblNoProg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNoProg.Location = New System.Drawing.Point(27, 78)
        Me.lblNoProg.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNoProg.Name = "lblNoProg"
        Me.lblNoProg.Size = New System.Drawing.Size(196, 30)
        Me.lblNoProg.TabIndex = 2
        Me.lblNoProg.Text = "No Prog.:"
        Me.lblNoProg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'mskDa
        '
        Me.mskDa.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsEtu, "etu_da", True))
        Me.mskDa.Location = New System.Drawing.Point(259, 28)
        Me.mskDa.Margin = New System.Windows.Forms.Padding(4)
        Me.mskDa.Mask = "0000000"
        Me.mskDa.Name = "mskDa"
        Me.mskDa.Size = New System.Drawing.Size(164, 26)
        Me.mskDa.TabIndex = 1
        '
        'lblDa
        '
        Me.lblDa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDa.Location = New System.Drawing.Point(27, 28)
        Me.lblDa.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDa.Name = "lblDa"
        Me.lblDa.Size = New System.Drawing.Size(196, 30)
        Me.lblDa.TabIndex = 0
        Me.lblDa.Text = "DA:"
        Me.lblDa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnModifier
        '
        Me.btnModifier.BackColor = System.Drawing.Color.YellowGreen
        Me.btnModifier.Location = New System.Drawing.Point(1691, 642)
        Me.btnModifier.Margin = New System.Windows.Forms.Padding(4)
        Me.btnModifier.Name = "btnModifier"
        Me.btnModifier.Size = New System.Drawing.Size(100, 102)
        Me.btnModifier.TabIndex = 18
        Me.btnModifier.Text = "Modifier"
        Me.btnModifier.UseVisualStyleBackColor = False
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.Color.YellowGreen
        Me.btnOk.Location = New System.Drawing.Point(1691, 420)
        Me.btnOk.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(100, 102)
        Me.btnOk.TabIndex = 16
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = False
        '
        'btnAnnuler
        '
        Me.btnAnnuler.BackColor = System.Drawing.Color.YellowGreen
        Me.btnAnnuler.Location = New System.Drawing.Point(1691, 531)
        Me.btnAnnuler.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAnnuler.Name = "btnAnnuler"
        Me.btnAnnuler.Size = New System.Drawing.Size(100, 102)
        Me.btnAnnuler.TabIndex = 17
        Me.btnAnnuler.Text = "Annuler"
        Me.btnAnnuler.UseVisualStyleBackColor = False
        '
        'btnNouveau
        '
        Me.btnNouveau.BackColor = System.Drawing.Color.YellowGreen
        Me.btnNouveau.Location = New System.Drawing.Point(1691, 309)
        Me.btnNouveau.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNouveau.Name = "btnNouveau"
        Me.btnNouveau.Size = New System.Drawing.Size(100, 102)
        Me.btnNouveau.TabIndex = 15
        Me.btnNouveau.Text = "Nouveau"
        Me.btnNouveau.UseVisualStyleBackColor = False
        '
        'erp
        '
        Me.erp.ContainerControl = Me
        '
        'dgEtu1
        '
        Me.dgEtu1.AllowUserToAddRows = False
        Me.dgEtu1.AllowUserToDeleteRows = False
        Me.dgEtu1.AutoGenerateColumns = False
        Me.dgEtu1.BackgroundColor = System.Drawing.Color.DarkSeaGreen
        Me.dgEtu1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgEtu1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgEtu1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn8})
        Me.dgEtu1.DataSource = Me.bsEtu
        Me.dgEtu1.Location = New System.Drawing.Point(17, 309)
        Me.dgEtu1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgEtu1.MultiSelect = False
        Me.dgEtu1.Name = "dgEtu1"
        Me.dgEtu1.ReadOnly = True
        Me.dgEtu1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgEtu1.Size = New System.Drawing.Size(1667, 542)
        Me.dgEtu1.TabIndex = 20
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "etu_da"
        Me.DataGridViewTextBoxColumn1.HeaderText = "DA"
        Me.DataGridViewTextBoxColumn1.MaxInputLength = 7
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "pro_no"
        Me.DataGridViewTextBoxColumn2.HeaderText = "No Prog."
        Me.DataGridViewTextBoxColumn2.MaxInputLength = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "etu_prenom"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Prénom"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 225
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "etu_nom"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Nom"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 225
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "etu_sexe"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Sexe"
        Me.DataGridViewTextBoxColumn5.MaxInputLength = 1
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 80
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "etu_adresse"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Adresse"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 250
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "etu_ville"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Ville"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 200
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "etu_codepostal"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Code Postal"
        Me.DataGridViewTextBoxColumn10.MaxInputLength = 7
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 120
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "etu_telephone"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Téléphone"
        Me.DataGridViewTextBoxColumn9.MaxInputLength = 14
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 150
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "etu_province"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Province"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 200
        '
        'cnEtu
        '
        Me.cnEtu.ConnectionString = "Data Source=RAGNAROCK\SQLEXPRESS;Initial Catalog=tp_p44;Integrated Security=True"
        Me.cnEtu.FireInfoMessageEventOnUserErrors = False
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT        etu_da, pro_no, etu_nom, etu_prenom, etu_sexe, etu_adresse, etu_vil" &
    "le, etu_province, etu_telephone, etu_codepostal" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            T_etudiants"
        Me.SqlSelectCommand1.Connection = Me.cnEtu
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.cnEtu
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@etu_da", System.Data.SqlDbType.VarChar, 0, "etu_da"), New System.Data.SqlClient.SqlParameter("@pro_no", System.Data.SqlDbType.VarChar, 0, "pro_no"), New System.Data.SqlClient.SqlParameter("@etu_nom", System.Data.SqlDbType.VarChar, 0, "etu_nom"), New System.Data.SqlClient.SqlParameter("@etu_prenom", System.Data.SqlDbType.VarChar, 0, "etu_prenom"), New System.Data.SqlClient.SqlParameter("@etu_sexe", System.Data.SqlDbType.[Char], 0, "etu_sexe"), New System.Data.SqlClient.SqlParameter("@etu_adresse", System.Data.SqlDbType.VarChar, 0, "etu_adresse"), New System.Data.SqlClient.SqlParameter("@etu_ville", System.Data.SqlDbType.VarChar, 0, "etu_ville"), New System.Data.SqlClient.SqlParameter("@etu_province", System.Data.SqlDbType.VarChar, 0, "etu_province"), New System.Data.SqlClient.SqlParameter("@etu_telephone", System.Data.SqlDbType.VarChar, 0, "etu_telephone"), New System.Data.SqlClient.SqlParameter("@etu_codepostal", System.Data.SqlDbType.VarChar, 0, "etu_codepostal")})
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.cnEtu
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@etu_da", System.Data.SqlDbType.VarChar, 0, "etu_da"), New System.Data.SqlClient.SqlParameter("@pro_no", System.Data.SqlDbType.VarChar, 0, "pro_no"), New System.Data.SqlClient.SqlParameter("@etu_nom", System.Data.SqlDbType.VarChar, 0, "etu_nom"), New System.Data.SqlClient.SqlParameter("@etu_prenom", System.Data.SqlDbType.VarChar, 0, "etu_prenom"), New System.Data.SqlClient.SqlParameter("@etu_sexe", System.Data.SqlDbType.[Char], 0, "etu_sexe"), New System.Data.SqlClient.SqlParameter("@etu_adresse", System.Data.SqlDbType.VarChar, 0, "etu_adresse"), New System.Data.SqlClient.SqlParameter("@etu_ville", System.Data.SqlDbType.VarChar, 0, "etu_ville"), New System.Data.SqlClient.SqlParameter("@etu_province", System.Data.SqlDbType.VarChar, 0, "etu_province"), New System.Data.SqlClient.SqlParameter("@etu_telephone", System.Data.SqlDbType.VarChar, 0, "etu_telephone"), New System.Data.SqlClient.SqlParameter("@etu_codepostal", System.Data.SqlDbType.VarChar, 0, "etu_codepostal"), New System.Data.SqlClient.SqlParameter("@Original_etu_da", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_da", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_pro_no", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pro_no", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_etu_nom", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_nom", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_etu_prenom", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_prenom", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_etu_sexe", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "etu_sexe", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_etu_sexe", System.Data.SqlDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_sexe", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_etu_adresse", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "etu_adresse", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_etu_adresse", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_adresse", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_etu_ville", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "etu_ville", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_etu_ville", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_ville", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_etu_province", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "etu_province", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_etu_province", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_province", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_etu_telephone", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "etu_telephone", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_etu_telephone", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_telephone", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_etu_codepostal", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "etu_codepostal", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_etu_codepostal", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_codepostal", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.cnEtu
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_etu_da", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_da", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_pro_no", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pro_no", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_etu_nom", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_nom", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_etu_prenom", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_prenom", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_etu_sexe", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "etu_sexe", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_etu_sexe", System.Data.SqlDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_sexe", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_etu_adresse", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "etu_adresse", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_etu_adresse", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_adresse", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_etu_ville", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "etu_ville", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_etu_ville", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_ville", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_etu_province", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "etu_province", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_etu_province", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_province", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_etu_telephone", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "etu_telephone", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_etu_telephone", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_telephone", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_etu_codepostal", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "etu_codepostal", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_etu_codepostal", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_codepostal", System.Data.DataRowVersion.Original, Nothing)})
        '
        'daEtu
        '
        Me.daEtu.DeleteCommand = Me.SqlDeleteCommand1
        Me.daEtu.InsertCommand = Me.SqlInsertCommand1
        Me.daEtu.SelectCommand = Me.SqlSelectCommand1
        Me.daEtu.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "T_etudiants", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("etu_da", "etu_da"), New System.Data.Common.DataColumnMapping("pro_no", "pro_no"), New System.Data.Common.DataColumnMapping("etu_nom", "etu_nom"), New System.Data.Common.DataColumnMapping("etu_prenom", "etu_prenom"), New System.Data.Common.DataColumnMapping("etu_sexe", "etu_sexe"), New System.Data.Common.DataColumnMapping("etu_adresse", "etu_adresse"), New System.Data.Common.DataColumnMapping("etu_ville", "etu_ville"), New System.Data.Common.DataColumnMapping("etu_province", "etu_province"), New System.Data.Common.DataColumnMapping("etu_telephone", "etu_telephone"), New System.Data.Common.DataColumnMapping("etu_codepostal", "etu_codepostal")})})
        Me.daEtu.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "select pro_no from T_programme"
        Me.SqlSelectCommand2.Connection = Me.cnEtu
        '
        'daProg
        '
        Me.daProg.SelectCommand = Me.SqlSelectCommand2
        Me.daProg.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "T_programme", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("pro_no", "pro_no")})})
        '
        'frmEtudiant
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1804, 868)
        Me.Controls.Add(Me.dgEtu1)
        Me.Controls.Add(Me.btnEnlever)
        Me.Controls.Add(Me.grpEtudiant)
        Me.Controls.Add(Me.btnModifier)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnAnnuler)
        Me.Controls.Add(Me.btnNouveau)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmEtudiant"
        Me.Text = "frmEtudiant"
        CType(Me.bsEtu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsEtu1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpEtudiant.ResumeLayout(False)
        Me.grpEtudiant.PerformLayout()
        Me.grpSexe.ResumeLayout(False)
        Me.grpSexe.PerformLayout()
        CType(Me.erp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgEtu1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rbUnspecified As RadioButton
    Friend WithEvents rbMasculin As RadioButton
    Friend WithEvents rbFeminin As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents mskPhone As MaskedTextBox
    Friend WithEvents mskZip As MaskedTextBox
    Friend WithEvents cbProvince As ComboBox
    Friend WithEvents txtVille As TextBox
    Friend WithEvents txtAdresse As TextBox
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblZip As Label
    Friend WithEvents lblProvince As Label
    Friend WithEvents btnEnlever As Button
    Friend WithEvents grpEtudiant As GroupBox
    Friend WithEvents lblVille As Label
    Friend WithEvents lblAdresse As Label
    Friend WithEvents grpSexe As GroupBox
    Friend WithEvents txtNom As TextBox
    Friend WithEvents txtPrenom As TextBox
    Friend WithEvents lblNom As Label
    Friend WithEvents lblPrenom As Label
    Friend WithEvents lblNoProg As Label
    Friend WithEvents mskDa As MaskedTextBox
    Friend WithEvents lblDa As Label
    Friend WithEvents btnModifier As Button
    Friend WithEvents btnOk As Button
    Friend WithEvents btnAnnuler As Button
    Friend WithEvents btnNouveau As Button
    Friend WithEvents EtudaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PronoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EtunomDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EtuprenomDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EtusexeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EtuadresseDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EtuvilleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EtuprovinceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EtutelephoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EtucodepostalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents erp As ErrorProvider
    Friend WithEvents dgEtu1 As DataGridView
    Public WithEvents cbNoProg As ComboBox
    Friend WithEvents cnEtu As SqlClient.SqlConnection
    Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As SqlClient.SqlCommand
    Friend WithEvents daEtu As SqlClient.SqlDataAdapter
    Friend WithEvents bsEtu As BindingSource
    Friend WithEvents DsEtu1 As dsEtu
    Friend WithEvents SqlSelectCommand2 As SqlClient.SqlCommand
    Friend WithEvents daProg As SqlClient.SqlDataAdapter
    Friend WithEvents mskSex As MaskedTextBox
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
End Class
