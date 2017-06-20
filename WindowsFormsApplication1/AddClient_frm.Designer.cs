namespace WindowsFormsApplication1
{
    partial class AddClient_frm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule4 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule5 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule6 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.nomTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.clientBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryDataSetOfficiel = new WindowsFormsApplication1.inventoryDataSetOfficiel();
            this.prénomTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.adressTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.date_naissanceDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.photoPictureEdit = new DevExpress.XtraEditors.PictureEdit();
            this.date_inscriptionDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.papier1TextEdit = new DevExpress.XtraEditors.TextEdit();
            this.textEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemFornom = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForprénom = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForadress = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemFordate_inscription = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemFordate_naissance = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForpaiement = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForphoto = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForpapier1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.clientTableAdapter1 = new WindowsFormsApplication1.inventoryDataSetOfficielTableAdapters.ClientTableAdapter();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.paiementTextEdit = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nomTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSetOfficiel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prénomTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adressTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_naissanceDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_naissanceDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_inscriptionDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_inscriptionDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.papier1TextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemFornom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForprénom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForadress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemFordate_inscription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemFordate_naissance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForpaiement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForphoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForpapier1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paiementTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.nomTextEdit);
            this.dataLayoutControl1.Controls.Add(this.prénomTextEdit);
            this.dataLayoutControl1.Controls.Add(this.adressTextEdit);
            this.dataLayoutControl1.Controls.Add(this.date_naissanceDateEdit);
            this.dataLayoutControl1.Controls.Add(this.photoPictureEdit);
            this.dataLayoutControl1.Controls.Add(this.date_inscriptionDateEdit);
            this.dataLayoutControl1.Controls.Add(this.papier1TextEdit);
            this.dataLayoutControl1.Controls.Add(this.textEdit1);
            this.dataLayoutControl1.Controls.Add(this.paiementTextEdit);
            this.dataLayoutControl1.DataSource = this.clientBindingSource5;
            this.dataLayoutControl1.Location = new System.Drawing.Point(3, 1);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(503, 416);
            this.dataLayoutControl1.TabIndex = 10;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // nomTextEdit
            // 
            this.nomTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.clientBindingSource5, "nom", true));
            this.nomTextEdit.Location = new System.Drawing.Point(103, 12);
            this.nomTextEdit.Name = "nomTextEdit";
            this.nomTextEdit.Properties.Mask.EditMask = "\\p{Lu}\\p{Ll}*(\\s+\\p{Lu}\\p{Ll}*)*";
            this.nomTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.nomTextEdit.Size = new System.Drawing.Size(388, 20);
            this.nomTextEdit.StyleController = this.dataLayoutControl1;
            this.nomTextEdit.TabIndex = 4;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Entrez une valeur !";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProvider1.SetValidationRule(this.nomTextEdit, conditionValidationRule1);
            this.nomTextEdit.Validating += new System.ComponentModel.CancelEventHandler(this.nomTextEdit_Validating);
            // 
            // clientBindingSource5
            // 
            this.clientBindingSource5.DataMember = "Client";
            this.clientBindingSource5.DataSource = this.inventoryDataSetOfficiel;
            // 
            // inventoryDataSetOfficiel
            // 
            this.inventoryDataSetOfficiel.DataSetName = "inventoryDataSetOfficiel";
            this.inventoryDataSetOfficiel.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prénomTextEdit
            // 
            this.prénomTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.clientBindingSource5, "prénom", true));
            this.prénomTextEdit.Location = new System.Drawing.Point(103, 36);
            this.prénomTextEdit.Name = "prénomTextEdit";
            this.prénomTextEdit.Properties.Mask.EditMask = "\\p{Lu}\\p{Ll}*(\\s+\\p{Lu}\\p{Ll}*)*";
            this.prénomTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.prénomTextEdit.Size = new System.Drawing.Size(388, 20);
            this.prénomTextEdit.StyleController = this.dataLayoutControl1;
            this.prénomTextEdit.TabIndex = 5;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Entrez une valeur !";
            this.dxValidationProvider1.SetValidationRule(this.prénomTextEdit, conditionValidationRule2);
            // 
            // adressTextEdit
            // 
            this.adressTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.clientBindingSource5, "adress", true));
            this.adressTextEdit.Location = new System.Drawing.Point(103, 60);
            this.adressTextEdit.Name = "adressTextEdit";
            this.adressTextEdit.Size = new System.Drawing.Size(388, 20);
            this.adressTextEdit.StyleController = this.dataLayoutControl1;
            this.adressTextEdit.TabIndex = 6;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "Entrez une valeur !";
            this.dxValidationProvider1.SetValidationRule(this.adressTextEdit, conditionValidationRule3);
            // 
            // date_naissanceDateEdit
            // 
            this.date_naissanceDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.clientBindingSource5, "date_naissance", true));
            this.date_naissanceDateEdit.EditValue = null;
            this.date_naissanceDateEdit.Location = new System.Drawing.Point(103, 108);
            this.date_naissanceDateEdit.Name = "date_naissanceDateEdit";
            this.date_naissanceDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_naissanceDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_naissanceDateEdit.Properties.DisplayFormat.FormatString = "";
            this.date_naissanceDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.date_naissanceDateEdit.Properties.EditFormat.FormatString = "";
            this.date_naissanceDateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.date_naissanceDateEdit.Properties.Mask.EditMask = "(0?[1-9]|1[012])/([012]?[1-9]|[123]0|31)/([123][0-9])?[0-9][0-9]";
            this.date_naissanceDateEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.date_naissanceDateEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.date_naissanceDateEdit.Size = new System.Drawing.Size(388, 20);
            this.date_naissanceDateEdit.StyleController = this.dataLayoutControl1;
            this.date_naissanceDateEdit.TabIndex = 8;
            conditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule4.ErrorText = "This value is not valid";
            this.dxValidationProvider1.SetValidationRule(this.date_naissanceDateEdit, conditionValidationRule4);
            // 
            // photoPictureEdit
            // 
            this.photoPictureEdit.Cursor = System.Windows.Forms.Cursors.Default;
            this.photoPictureEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.clientBindingSource5, "photo", true));
            this.photoPictureEdit.EditValue = global::WindowsFormsApplication1.Properties.Resources.man0;
            this.photoPictureEdit.Location = new System.Drawing.Point(103, 156);
            this.photoPictureEdit.Name = "photoPictureEdit";
            this.photoPictureEdit.Properties.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray;
            this.photoPictureEdit.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.photoPictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.photoPictureEdit.Properties.ZoomAccelerationFactor = 1D;
            this.photoPictureEdit.Size = new System.Drawing.Size(222, 248);
            this.photoPictureEdit.StyleController = this.dataLayoutControl1;
            this.photoPictureEdit.TabIndex = 15;
            // 
            // date_inscriptionDateEdit
            // 
            this.date_inscriptionDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.clientBindingSource5, "date_inscription", true));
            this.date_inscriptionDateEdit.EditValue = null;
            this.date_inscriptionDateEdit.Location = new System.Drawing.Point(103, 84);
            this.date_inscriptionDateEdit.Name = "date_inscriptionDateEdit";
            this.date_inscriptionDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_inscriptionDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_inscriptionDateEdit.Properties.DisplayFormat.FormatString = "";
            this.date_inscriptionDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.date_inscriptionDateEdit.Properties.EditFormat.FormatString = "";
            this.date_inscriptionDateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.date_inscriptionDateEdit.Properties.Mask.EditMask = "(0?[1-9]|1[012])/([012]?[1-9]|[123]0|31)/([123][0-9])?[0-9][0-9]";
            this.date_inscriptionDateEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.date_inscriptionDateEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.date_inscriptionDateEdit.Properties.ValidateOnEnterKey = true;
            this.date_inscriptionDateEdit.Size = new System.Drawing.Size(388, 20);
            this.date_inscriptionDateEdit.StyleController = this.dataLayoutControl1;
            this.date_inscriptionDateEdit.TabIndex = 7;
            conditionValidationRule5.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule5.ErrorText = "Entrez une valeur !";
            conditionValidationRule5.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProvider1.SetValidationRule(this.date_inscriptionDateEdit, conditionValidationRule5);
            // 
            // papier1TextEdit
            // 
            this.papier1TextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.clientBindingSource5, "papier1", true));
            this.papier1TextEdit.Location = new System.Drawing.Point(420, 156);
            this.papier1TextEdit.Name = "papier1TextEdit";
            this.papier1TextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.papier1TextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.papier1TextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.papier1TextEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.papier1TextEdit.Properties.Mask.EditMask = "d";
            this.papier1TextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.papier1TextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.papier1TextEdit.Size = new System.Drawing.Size(71, 20);
            this.papier1TextEdit.StyleController = this.dataLayoutControl1;
            this.papier1TextEdit.TabIndex = 12;
            conditionValidationRule6.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule6.ErrorText = "Entrez le numero du dossier";
            this.dxValidationProvider1.SetValidationRule(this.papier1TextEdit, conditionValidationRule6);
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(420, 180);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textEdit1.Properties.Items.AddRange(new object[] {
            "Male",
            "Femelle"});
            this.textEdit1.Size = new System.Drawing.Size(71, 20);
            this.textEdit1.StyleController = this.dataLayoutControl1;
            this.textEdit1.TabIndex = 16;
            this.textEdit1.EditValueChanged += new System.EventHandler(this.textEdit1_EditValueChanged);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(503, 416);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemFornom,
            this.ItemForprénom,
            this.ItemForadress,
            this.ItemFordate_inscription,
            this.ItemFordate_naissance,
            this.ItemForpaiement,
            this.ItemForphoto,
            this.ItemForpapier1,
            this.layoutControlItem1});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(483, 396);
            // 
            // ItemFornom
            // 
            this.ItemFornom.Control = this.nomTextEdit;
            this.ItemFornom.Location = new System.Drawing.Point(0, 0);
            this.ItemFornom.Name = "ItemFornom";
            this.ItemFornom.Size = new System.Drawing.Size(483, 24);
            this.ItemFornom.Text = "Nom";
            this.ItemFornom.TextSize = new System.Drawing.Size(88, 13);
            // 
            // ItemForprénom
            // 
            this.ItemForprénom.Control = this.prénomTextEdit;
            this.ItemForprénom.Location = new System.Drawing.Point(0, 24);
            this.ItemForprénom.Name = "ItemForprénom";
            this.ItemForprénom.Size = new System.Drawing.Size(483, 24);
            this.ItemForprénom.Text = "Prénom";
            this.ItemForprénom.TextSize = new System.Drawing.Size(88, 13);
            // 
            // ItemForadress
            // 
            this.ItemForadress.Control = this.adressTextEdit;
            this.ItemForadress.Location = new System.Drawing.Point(0, 48);
            this.ItemForadress.Name = "ItemForadress";
            this.ItemForadress.Size = new System.Drawing.Size(483, 24);
            this.ItemForadress.Text = "Adresse";
            this.ItemForadress.TextSize = new System.Drawing.Size(88, 13);
            // 
            // ItemFordate_inscription
            // 
            this.ItemFordate_inscription.Control = this.date_inscriptionDateEdit;
            this.ItemFordate_inscription.Location = new System.Drawing.Point(0, 72);
            this.ItemFordate_inscription.Name = "ItemFordate_inscription";
            this.ItemFordate_inscription.Size = new System.Drawing.Size(483, 24);
            this.ItemFordate_inscription.Text = "Date d\'inscription";
            this.ItemFordate_inscription.TextSize = new System.Drawing.Size(88, 13);
            // 
            // ItemFordate_naissance
            // 
            this.ItemFordate_naissance.Control = this.date_naissanceDateEdit;
            this.ItemFordate_naissance.Location = new System.Drawing.Point(0, 96);
            this.ItemFordate_naissance.Name = "ItemFordate_naissance";
            this.ItemFordate_naissance.Size = new System.Drawing.Size(483, 24);
            this.ItemFordate_naissance.Text = "Date de naissance";
            this.ItemFordate_naissance.TextSize = new System.Drawing.Size(88, 13);
            // 
            // ItemForpaiement
            // 
            this.ItemForpaiement.Control = this.paiementTextEdit;
            this.ItemForpaiement.Location = new System.Drawing.Point(0, 120);
            this.ItemForpaiement.Name = "ItemForpaiement";
            this.ItemForpaiement.Size = new System.Drawing.Size(483, 24);
            this.ItemForpaiement.Text = "Paiement";
            this.ItemForpaiement.TextSize = new System.Drawing.Size(88, 13);
            // 
            // ItemForphoto
            // 
            this.ItemForphoto.Control = this.photoPictureEdit;
            this.ItemForphoto.Location = new System.Drawing.Point(0, 144);
            this.ItemForphoto.Name = "ItemForphoto";
            this.ItemForphoto.Size = new System.Drawing.Size(317, 252);
            this.ItemForphoto.StartNewLine = true;
            this.ItemForphoto.Text = "Photo";
            this.ItemForphoto.TextSize = new System.Drawing.Size(88, 13);
            // 
            // ItemForpapier1
            // 
            this.ItemForpapier1.Control = this.papier1TextEdit;
            this.ItemForpapier1.Location = new System.Drawing.Point(317, 144);
            this.ItemForpapier1.Name = "ItemForpapier1";
            this.ItemForpapier1.Size = new System.Drawing.Size(166, 24);
            this.ItemForpapier1.Text = "N° du dossier";
            this.ItemForpapier1.TextSize = new System.Drawing.Size(88, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.textEdit1;
            this.layoutControlItem1.Location = new System.Drawing.Point(317, 168);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(166, 228);
            this.layoutControlItem1.Text = "Sexe";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(88, 13);
            // 
            // clientTableAdapter1
            // 
            this.clientTableAdapter1.ClearBeforeFill = true;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageUri.Uri = "Apply;Colored";
            this.simpleButton1.Location = new System.Drawing.Point(282, 429);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(103, 45);
            this.simpleButton1.TabIndex = 12;
            this.simpleButton1.Text = "Valider";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageUri.Uri = "Cancel;Colored";
            this.simpleButton2.Location = new System.Drawing.Point(391, 429);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(103, 45);
            this.simpleButton2.TabIndex = 13;
            this.simpleButton2.Text = "Annuler";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // paiementTextEdit
            // 
            this.paiementTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.clientBindingSource5, "paiement", true));
            this.paiementTextEdit.Location = new System.Drawing.Point(103, 132);
            this.paiementTextEdit.Name = "paiementTextEdit";
            this.paiementTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.paiementTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.paiementTextEdit.Properties.Mask.EditMask = "\\d?\\d?\\d?\\d-\\d\\d-\\d\\d-\\d\\d?";
            this.paiementTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.paiementTextEdit.Size = new System.Drawing.Size(388, 20);
            this.paiementTextEdit.StyleController = this.dataLayoutControl1;
            this.paiementTextEdit.TabIndex = 9;
            // 
            // AddClient_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(524, 486);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.dataLayoutControl1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddClient_frm";
            this.Text = "AddClient_frm";
            this.Load += new System.EventHandler(this.AddClient_frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nomTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSetOfficiel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prénomTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adressTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_naissanceDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_naissanceDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_inscriptionDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_inscriptionDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.papier1TextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemFornom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForprénom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForadress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemFordate_inscription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemFordate_naissance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForpaiement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForphoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForpapier1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paiementTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ns1.BunifuElipse bunifuElipse1;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit nomTextEdit;
        private DevExpress.XtraEditors.TextEdit prénomTextEdit;
        private DevExpress.XtraEditors.TextEdit adressTextEdit;
        private DevExpress.XtraEditors.DateEdit date_naissanceDateEdit;
        private DevExpress.XtraEditors.PictureEdit photoPictureEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemFornom;
        private DevExpress.XtraLayout.LayoutControlItem ItemForprénom;
        private DevExpress.XtraLayout.LayoutControlItem ItemForadress;
        private DevExpress.XtraLayout.LayoutControlItem ItemFordate_inscription;
        private DevExpress.XtraLayout.LayoutControlItem ItemFordate_naissance;
        private DevExpress.XtraLayout.LayoutControlItem ItemForpaiement;
        private DevExpress.XtraLayout.LayoutControlItem ItemForpapier1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForphoto;
        private inventoryDataSetOfficiel inventoryDataSetOfficiel;
        private System.Windows.Forms.BindingSource clientBindingSource5;
        private inventoryDataSetOfficielTableAdapters.ClientTableAdapter clientTableAdapter1;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.DateEdit date_inscriptionDateEdit;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
        private DevExpress.XtraEditors.TextEdit papier1TextEdit;
        private DevExpress.XtraEditors.ComboBoxEdit textEdit1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.TextEdit paiementTextEdit;
    }
}