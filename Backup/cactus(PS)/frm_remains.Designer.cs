namespace cactus_PS_
{
    partial class frm_remains
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
            this.grp_bookKind = new System.Windows.Forms.GroupBox();
            this.pnl_projects = new System.Windows.Forms.Panel();
            this.tbx_projectID = new System.Windows.Forms.TextBox();
            this.projectsTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pSDatabase5DataSet = new cactus_PS_.PSDatabase5DataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_projects = new System.Windows.Forms.ComboBox();
            this.pnl_detailRemains = new System.Windows.Forms.Panel();
            this.chk_filterByLedger = new System.Windows.Forms.CheckBox();
            this.pnl_masterSpent = new System.Windows.Forms.Panel();
            this.tbx_ledgerCode = new System.Windows.Forms.TextBox();
            this.spentMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmb_masterSpentName = new System.Windows.Forms.ComboBox();
            this.rdu_showProjectsRemains = new System.Windows.Forms.RadioButton();
            this.rdu_showDetailRemains = new System.Windows.Forms.RadioButton();
            this.rdu_showLedgerRemains = new System.Windows.Forms.RadioButton();
            this.spentMasterTableAdapter = new cactus_PS_.PSDatabase5DataSetTableAdapters.spentMasterTableAdapter();
            this.grp_conditions = new System.Windows.Forms.GroupBox();
            this.pnl_toPrice = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_toPrice = new System.Windows.Forms.TextBox();
            this.tbx_fromPrice = new System.Windows.Forms.TextBox();
            this.rdu_allCases = new System.Windows.Forms.RadioButton();
            this.rdu_betweenPrice = new System.Windows.Forms.RadioButton();
            this.rdu_equalsPrice = new System.Windows.Forms.RadioButton();
            this.rdu_moreThanPrice = new System.Windows.Forms.RadioButton();
            this.rdu_lessThanPrice = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_conditionKind = new System.Windows.Forms.ComboBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.projectsTableTableAdapter = new cactus_PS_.PSDatabase5DataSetTableAdapters.projectsTableTableAdapter();
            this.grp_dateConditions = new System.Windows.Forms.GroupBox();
            this.pnl_betweenIDs = new System.Windows.Forms.Panel();
            this.tbx_toID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbx_fromID = new System.Windows.Forms.TextBox();
            this.pnl_betweenDates = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.mTbx_fromDate = new System.Windows.Forms.MaskedTextBox();
            this.mTbx_toDate = new System.Windows.Forms.MaskedTextBox();
            this.mTbx_inDate = new System.Windows.Forms.MaskedTextBox();
            this.rdu_showBetweenAccDoc_ids = new System.Windows.Forms.RadioButton();
            this.rdu_showBetweenDates = new System.Windows.Forms.RadioButton();
            this.rdu_showAll = new System.Windows.Forms.RadioButton();
            this.rdu_showInDate = new System.Windows.Forms.RadioButton();
            this.grp_bookKind.SuspendLayout();
            this.pnl_projects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectsTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSDatabase5DataSet)).BeginInit();
            this.pnl_detailRemains.SuspendLayout();
            this.pnl_masterSpent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spentMasterBindingSource)).BeginInit();
            this.grp_conditions.SuspendLayout();
            this.pnl_toPrice.SuspendLayout();
            this.grp_dateConditions.SuspendLayout();
            this.pnl_betweenIDs.SuspendLayout();
            this.pnl_betweenDates.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_bookKind
            // 
            this.grp_bookKind.BackColor = System.Drawing.Color.Transparent;
            this.grp_bookKind.Controls.Add(this.pnl_projects);
            this.grp_bookKind.Controls.Add(this.pnl_detailRemains);
            this.grp_bookKind.Controls.Add(this.rdu_showProjectsRemains);
            this.grp_bookKind.Controls.Add(this.rdu_showDetailRemains);
            this.grp_bookKind.Controls.Add(this.rdu_showLedgerRemains);
            this.grp_bookKind.Location = new System.Drawing.Point(21, 20);
            this.grp_bookKind.Name = "grp_bookKind";
            this.grp_bookKind.Size = new System.Drawing.Size(570, 178);
            this.grp_bookKind.TabIndex = 0;
            this.grp_bookKind.TabStop = false;
            this.grp_bookKind.Text = "نوع مانده";
            // 
            // pnl_projects
            // 
            this.pnl_projects.Controls.Add(this.tbx_projectID);
            this.pnl_projects.Controls.Add(this.label3);
            this.pnl_projects.Controls.Add(this.cmb_projects);
            this.pnl_projects.Enabled = false;
            this.pnl_projects.Location = new System.Drawing.Point(122, 129);
            this.pnl_projects.Name = "pnl_projects";
            this.pnl_projects.Size = new System.Drawing.Size(318, 43);
            this.pnl_projects.TabIndex = 4;
            // 
            // tbx_projectID
            // 
            this.tbx_projectID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectsTableBindingSource, "projectID", true));
            this.tbx_projectID.Location = new System.Drawing.Point(184, 3);
            this.tbx_projectID.Name = "tbx_projectID";
            this.tbx_projectID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_projectID.Size = new System.Drawing.Size(40, 33);
            this.tbx_projectID.TabIndex = 0;
            this.tbx_projectID.TabStop = false;
            // 
            // projectsTableBindingSource
            // 
            this.projectsTableBindingSource.DataMember = "projectsTable";
            this.projectsTableBindingSource.DataSource = this.pSDatabase5DataSet;
            // 
            // pSDatabase5DataSet
            // 
            this.pSDatabase5DataSet.DataSetName = "PSDatabase5DataSet";
            this.pSDatabase5DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(230, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 26);
            this.label3.TabIndex = 10;
            this.label3.Text = "پـــــروژه :";
            // 
            // cmb_projects
            // 
            this.cmb_projects.DataSource = this.projectsTableBindingSource;
            this.cmb_projects.DisplayMember = "projectTitle";
            this.cmb_projects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_projects.FormattingEnabled = true;
            this.cmb_projects.Location = new System.Drawing.Point(3, 3);
            this.cmb_projects.Name = "cmb_projects";
            this.cmb_projects.Size = new System.Drawing.Size(176, 34);
            this.cmb_projects.TabIndex = 1;
            this.cmb_projects.ValueMember = "projectID";
            this.cmb_projects.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_projects_KeyPress);
            // 
            // pnl_detailRemains
            // 
            this.pnl_detailRemains.Controls.Add(this.chk_filterByLedger);
            this.pnl_detailRemains.Controls.Add(this.pnl_masterSpent);
            this.pnl_detailRemains.Enabled = false;
            this.pnl_detailRemains.Location = new System.Drawing.Point(14, 78);
            this.pnl_detailRemains.Name = "pnl_detailRemains";
            this.pnl_detailRemains.Size = new System.Drawing.Size(362, 46);
            this.pnl_detailRemains.TabIndex = 2;
            // 
            // chk_filterByLedger
            // 
            this.chk_filterByLedger.AutoSize = true;
            this.chk_filterByLedger.Location = new System.Drawing.Point(229, 8);
            this.chk_filterByLedger.Name = "chk_filterByLedger";
            this.chk_filterByLedger.Size = new System.Drawing.Size(125, 30);
            this.chk_filterByLedger.TabIndex = 0;
            this.chk_filterByLedger.Text = "فقط حساب های :";
            this.chk_filterByLedger.UseVisualStyleBackColor = true;
            this.chk_filterByLedger.CheckedChanged += new System.EventHandler(this.chk_filterByLedger_CheckedChanged);
            // 
            // pnl_masterSpent
            // 
            this.pnl_masterSpent.Controls.Add(this.tbx_ledgerCode);
            this.pnl_masterSpent.Controls.Add(this.cmb_masterSpentName);
            this.pnl_masterSpent.Enabled = false;
            this.pnl_masterSpent.Location = new System.Drawing.Point(3, 3);
            this.pnl_masterSpent.Name = "pnl_masterSpent";
            this.pnl_masterSpent.Size = new System.Drawing.Size(224, 39);
            this.pnl_masterSpent.TabIndex = 1;
            // 
            // tbx_ledgerCode
            // 
            this.tbx_ledgerCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spentMasterBindingSource, "spentMasterID", true));
            this.tbx_ledgerCode.Location = new System.Drawing.Point(185, 3);
            this.tbx_ledgerCode.Name = "tbx_ledgerCode";
            this.tbx_ledgerCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_ledgerCode.Size = new System.Drawing.Size(35, 33);
            this.tbx_ledgerCode.TabIndex = 0;
            // 
            // spentMasterBindingSource
            // 
            this.spentMasterBindingSource.DataMember = "spentMaster";
            this.spentMasterBindingSource.DataSource = this.pSDatabase5DataSet;
            // 
            // cmb_masterSpentName
            // 
            this.cmb_masterSpentName.DataSource = this.spentMasterBindingSource;
            this.cmb_masterSpentName.DisplayMember = "spentMasterName";
            this.cmb_masterSpentName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_masterSpentName.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmb_masterSpentName.FormattingEnabled = true;
            this.cmb_masterSpentName.Location = new System.Drawing.Point(3, 3);
            this.cmb_masterSpentName.Name = "cmb_masterSpentName";
            this.cmb_masterSpentName.Size = new System.Drawing.Size(176, 32);
            this.cmb_masterSpentName.TabIndex = 1;
            this.cmb_masterSpentName.ValueMember = "spentMasterID";
            this.cmb_masterSpentName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_masterSpentName_KeyPress);
            // 
            // rdu_showProjectsRemains
            // 
            this.rdu_showProjectsRemains.AutoSize = true;
            this.rdu_showProjectsRemains.BackColor = System.Drawing.Color.Transparent;
            this.rdu_showProjectsRemains.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdu_showProjectsRemains.ForeColor = System.Drawing.Color.Red;
            this.rdu_showProjectsRemains.Location = new System.Drawing.Point(441, 129);
            this.rdu_showProjectsRemains.Name = "rdu_showProjectsRemains";
            this.rdu_showProjectsRemains.Size = new System.Drawing.Size(120, 34);
            this.rdu_showProjectsRemains.TabIndex = 3;
            this.rdu_showProjectsRemains.Text = "مانده پروژه ها";
            this.rdu_showProjectsRemains.UseVisualStyleBackColor = false;
            this.rdu_showProjectsRemains.CheckedChanged += new System.EventHandler(this.rdu_showProjectsRemains_CheckedChanged);
            // 
            // rdu_showDetailRemains
            // 
            this.rdu_showDetailRemains.AutoSize = true;
            this.rdu_showDetailRemains.BackColor = System.Drawing.Color.Transparent;
            this.rdu_showDetailRemains.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdu_showDetailRemains.ForeColor = System.Drawing.Color.Red;
            this.rdu_showDetailRemains.Location = new System.Drawing.Point(382, 80);
            this.rdu_showDetailRemains.Name = "rdu_showDetailRemains";
            this.rdu_showDetailRemains.Size = new System.Drawing.Size(179, 34);
            this.rdu_showDetailRemains.TabIndex = 1;
            this.rdu_showDetailRemains.Text = "مانده حساب های معین";
            this.rdu_showDetailRemains.UseVisualStyleBackColor = false;
            this.rdu_showDetailRemains.CheckedChanged += new System.EventHandler(this.rdu_showDetailRemains_CheckedChanged);
            // 
            // rdu_showLedgerRemains
            // 
            this.rdu_showLedgerRemains.AutoSize = true;
            this.rdu_showLedgerRemains.BackColor = System.Drawing.Color.Transparent;
            this.rdu_showLedgerRemains.Checked = true;
            this.rdu_showLedgerRemains.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdu_showLedgerRemains.ForeColor = System.Drawing.Color.Red;
            this.rdu_showLedgerRemains.Location = new System.Drawing.Point(396, 32);
            this.rdu_showLedgerRemains.Name = "rdu_showLedgerRemains";
            this.rdu_showLedgerRemains.Size = new System.Drawing.Size(165, 34);
            this.rdu_showLedgerRemains.TabIndex = 0;
            this.rdu_showLedgerRemains.TabStop = true;
            this.rdu_showLedgerRemains.Text = "مانده حساب هاب کل";
            this.rdu_showLedgerRemains.UseVisualStyleBackColor = false;
            this.rdu_showLedgerRemains.CheckedChanged += new System.EventHandler(this.rdu_showLedgerRemains_CheckedChanged);
            // 
            // spentMasterTableAdapter
            // 
            this.spentMasterTableAdapter.ClearBeforeFill = true;
            // 
            // grp_conditions
            // 
            this.grp_conditions.BackColor = System.Drawing.Color.Transparent;
            this.grp_conditions.Controls.Add(this.pnl_toPrice);
            this.grp_conditions.Controls.Add(this.tbx_fromPrice);
            this.grp_conditions.Controls.Add(this.rdu_allCases);
            this.grp_conditions.Controls.Add(this.rdu_betweenPrice);
            this.grp_conditions.Controls.Add(this.rdu_equalsPrice);
            this.grp_conditions.Controls.Add(this.rdu_moreThanPrice);
            this.grp_conditions.Controls.Add(this.rdu_lessThanPrice);
            this.grp_conditions.Controls.Add(this.label1);
            this.grp_conditions.Controls.Add(this.cmb_conditionKind);
            this.grp_conditions.Location = new System.Drawing.Point(22, 204);
            this.grp_conditions.Name = "grp_conditions";
            this.grp_conditions.Size = new System.Drawing.Size(568, 206);
            this.grp_conditions.TabIndex = 1;
            this.grp_conditions.TabStop = false;
            this.grp_conditions.Text = "شروط";
            // 
            // pnl_toPrice
            // 
            this.pnl_toPrice.Controls.Add(this.label2);
            this.pnl_toPrice.Controls.Add(this.tbx_toPrice);
            this.pnl_toPrice.Location = new System.Drawing.Point(95, 132);
            this.pnl_toPrice.Name = "pnl_toPrice";
            this.pnl_toPrice.Size = new System.Drawing.Size(203, 42);
            this.pnl_toPrice.TabIndex = 7;
            this.pnl_toPrice.Visible = false;
            this.pnl_toPrice.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 26);
            this.label2.TabIndex = 10;
            this.label2.Text = "تا";
            // 
            // tbx_toPrice
            // 
            this.tbx_toPrice.Location = new System.Drawing.Point(3, 2);
            this.tbx_toPrice.Name = "tbx_toPrice";
            this.tbx_toPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_toPrice.Size = new System.Drawing.Size(170, 33);
            this.tbx_toPrice.TabIndex = 0;
            this.tbx_toPrice.Text = "0";
            // 
            // tbx_fromPrice
            // 
            this.tbx_fromPrice.Enabled = false;
            this.tbx_fromPrice.Location = new System.Drawing.Point(300, 134);
            this.tbx_fromPrice.Name = "tbx_fromPrice";
            this.tbx_fromPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_fromPrice.Size = new System.Drawing.Size(173, 33);
            this.tbx_fromPrice.TabIndex = 6;
            this.tbx_fromPrice.Text = "0";
            // 
            // rdu_allCases
            // 
            this.rdu_allCases.AutoSize = true;
            this.rdu_allCases.Checked = true;
            this.rdu_allCases.Location = new System.Drawing.Point(77, 97);
            this.rdu_allCases.Name = "rdu_allCases";
            this.rdu_allCases.Size = new System.Drawing.Size(84, 30);
            this.rdu_allCases.TabIndex = 5;
            this.rdu_allCases.TabStop = true;
            this.rdu_allCases.Text = "همه موارد";
            this.rdu_allCases.UseVisualStyleBackColor = true;
            this.rdu_allCases.CheckedChanged += new System.EventHandler(this.rdu_allCases_CheckedChanged);
            // 
            // rdu_betweenPrice
            // 
            this.rdu_betweenPrice.AutoSize = true;
            this.rdu_betweenPrice.Location = new System.Drawing.Point(170, 97);
            this.rdu_betweenPrice.Name = "rdu_betweenPrice";
            this.rdu_betweenPrice.Size = new System.Drawing.Size(64, 30);
            this.rdu_betweenPrice.TabIndex = 4;
            this.rdu_betweenPrice.Text = "ما بین";
            this.rdu_betweenPrice.UseVisualStyleBackColor = true;
            this.rdu_betweenPrice.CheckedChanged += new System.EventHandler(this.rdu_betweenPrice_CheckedChanged);
            // 
            // rdu_equalsPrice
            // 
            this.rdu_equalsPrice.AutoSize = true;
            this.rdu_equalsPrice.Location = new System.Drawing.Point(243, 96);
            this.rdu_equalsPrice.Name = "rdu_equalsPrice";
            this.rdu_equalsPrice.Size = new System.Drawing.Size(69, 30);
            this.rdu_equalsPrice.TabIndex = 3;
            this.rdu_equalsPrice.Text = "مساوی";
            this.rdu_equalsPrice.UseVisualStyleBackColor = true;
            // 
            // rdu_moreThanPrice
            // 
            this.rdu_moreThanPrice.AutoSize = true;
            this.rdu_moreThanPrice.Location = new System.Drawing.Point(321, 97);
            this.rdu_moreThanPrice.Name = "rdu_moreThanPrice";
            this.rdu_moreThanPrice.Size = new System.Drawing.Size(77, 30);
            this.rdu_moreThanPrice.TabIndex = 2;
            this.rdu_moreThanPrice.Text = "بزرگتر از";
            this.rdu_moreThanPrice.UseVisualStyleBackColor = true;
            // 
            // rdu_lessThanPrice
            // 
            this.rdu_lessThanPrice.AutoSize = true;
            this.rdu_lessThanPrice.Location = new System.Drawing.Point(407, 97);
            this.rdu_lessThanPrice.Name = "rdu_lessThanPrice";
            this.rdu_lessThanPrice.Size = new System.Drawing.Size(85, 30);
            this.rdu_lessThanPrice.TabIndex = 1;
            this.rdu_lessThanPrice.Text = "کوچکتر از";
            this.rdu_lessThanPrice.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(367, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "شرط مانده :";
            // 
            // cmb_conditionKind
            // 
            this.cmb_conditionKind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_conditionKind.FormattingEnabled = true;
            this.cmb_conditionKind.Items.AddRange(new object[] {
            "مانده بدهکاری",
            "مانده بستانکاری"});
            this.cmb_conditionKind.Location = new System.Drawing.Point(115, 26);
            this.cmb_conditionKind.Name = "cmb_conditionKind";
            this.cmb_conditionKind.Size = new System.Drawing.Size(247, 34);
            this.cmb_conditionKind.TabIndex = 0;
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(145, 416);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(433, 37);
            this.btn_ok.TabIndex = 2;
            this.btn_ok.Text = "نــــمایـــش";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(35, 416);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(104, 37);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "بستن";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // projectsTableTableAdapter
            // 
            this.projectsTableTableAdapter.ClearBeforeFill = true;
            // 
            // grp_dateConditions
            // 
            this.grp_dateConditions.BackColor = System.Drawing.Color.Transparent;
            this.grp_dateConditions.Controls.Add(this.pnl_betweenIDs);
            this.grp_dateConditions.Controls.Add(this.pnl_betweenDates);
            this.grp_dateConditions.Controls.Add(this.mTbx_inDate);
            this.grp_dateConditions.Controls.Add(this.rdu_showBetweenAccDoc_ids);
            this.grp_dateConditions.Controls.Add(this.rdu_showBetweenDates);
            this.grp_dateConditions.Controls.Add(this.rdu_showAll);
            this.grp_dateConditions.Controls.Add(this.rdu_showInDate);
            this.grp_dateConditions.Location = new System.Drawing.Point(610, 204);
            this.grp_dateConditions.Name = "grp_dateConditions";
            this.grp_dateConditions.Size = new System.Drawing.Size(568, 206);
            this.grp_dateConditions.TabIndex = 5;
            this.grp_dateConditions.TabStop = false;
            this.grp_dateConditions.Text = "شروط";
            this.grp_dateConditions.Visible = false;
            // 
            // pnl_betweenIDs
            // 
            this.pnl_betweenIDs.Controls.Add(this.tbx_toID);
            this.pnl_betweenIDs.Controls.Add(this.label4);
            this.pnl_betweenIDs.Controls.Add(this.tbx_fromID);
            this.pnl_betweenIDs.Enabled = false;
            this.pnl_betweenIDs.Location = new System.Drawing.Point(73, 154);
            this.pnl_betweenIDs.Name = "pnl_betweenIDs";
            this.pnl_betweenIDs.Size = new System.Drawing.Size(214, 43);
            this.pnl_betweenIDs.TabIndex = 6;
            // 
            // tbx_toID
            // 
            this.tbx_toID.Location = new System.Drawing.Point(5, 4);
            this.tbx_toID.Name = "tbx_toID";
            this.tbx_toID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_toID.Size = new System.Drawing.Size(85, 33);
            this.tbx_toID.TabIndex = 1;
            this.tbx_toID.Text = "500";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 26);
            this.label4.TabIndex = 102;
            this.label4.Text = "تا";
            // 
            // tbx_fromID
            // 
            this.tbx_fromID.Location = new System.Drawing.Point(125, 5);
            this.tbx_fromID.Name = "tbx_fromID";
            this.tbx_fromID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_fromID.Size = new System.Drawing.Size(85, 33);
            this.tbx_fromID.TabIndex = 0;
            this.tbx_fromID.Text = "1";
            // 
            // pnl_betweenDates
            // 
            this.pnl_betweenDates.Controls.Add(this.label5);
            this.pnl_betweenDates.Controls.Add(this.mTbx_fromDate);
            this.pnl_betweenDates.Controls.Add(this.mTbx_toDate);
            this.pnl_betweenDates.Enabled = false;
            this.pnl_betweenDates.Location = new System.Drawing.Point(73, 108);
            this.pnl_betweenDates.Name = "pnl_betweenDates";
            this.pnl_betweenDates.Size = new System.Drawing.Size(216, 39);
            this.pnl_betweenDates.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(98, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 26);
            this.label5.TabIndex = 100;
            this.label5.Text = "تا";
            // 
            // mTbx_fromDate
            // 
            this.mTbx_fromDate.AllowPromptAsInput = false;
            this.mTbx_fromDate.Location = new System.Drawing.Point(123, 3);
            this.mTbx_fromDate.Mask = "0000/00/00";
            this.mTbx_fromDate.Name = "mTbx_fromDate";
            this.mTbx_fromDate.PromptChar = ' ';
            this.mTbx_fromDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mTbx_fromDate.Size = new System.Drawing.Size(91, 33);
            this.mTbx_fromDate.TabIndex = 0;
            this.mTbx_fromDate.Leave += new System.EventHandler(this.mTbx_fromDate_Leave);
            this.mTbx_fromDate.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mTbx_fromDate_KeyUp);
            // 
            // mTbx_toDate
            // 
            this.mTbx_toDate.AllowPromptAsInput = false;
            this.mTbx_toDate.Location = new System.Drawing.Point(5, 3);
            this.mTbx_toDate.Mask = "0000/00/00";
            this.mTbx_toDate.Name = "mTbx_toDate";
            this.mTbx_toDate.PromptChar = ' ';
            this.mTbx_toDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mTbx_toDate.Size = new System.Drawing.Size(91, 33);
            this.mTbx_toDate.TabIndex = 1;
            this.mTbx_toDate.Leave += new System.EventHandler(this.mTbx_toDate_Leave);
            this.mTbx_toDate.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mTbx_toDate_KeyUp);
            // 
            // mTbx_inDate
            // 
            this.mTbx_inDate.AllowPromptAsInput = false;
            this.mTbx_inDate.Enabled = false;
            this.mTbx_inDate.Location = new System.Drawing.Point(196, 66);
            this.mTbx_inDate.Mask = "0000/00/00";
            this.mTbx_inDate.Name = "mTbx_inDate";
            this.mTbx_inDate.PromptChar = ' ';
            this.mTbx_inDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mTbx_inDate.Size = new System.Drawing.Size(91, 33);
            this.mTbx_inDate.TabIndex = 2;
            this.mTbx_inDate.Leave += new System.EventHandler(this.mTbx_inDate_Leave);
            this.mTbx_inDate.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mTbx_inDate_KeyUp);
            // 
            // rdu_showBetweenAccDoc_ids
            // 
            this.rdu_showBetweenAccDoc_ids.AutoSize = true;
            this.rdu_showBetweenAccDoc_ids.BackColor = System.Drawing.Color.Transparent;
            this.rdu_showBetweenAccDoc_ids.Location = new System.Drawing.Point(301, 161);
            this.rdu_showBetweenAccDoc_ids.Name = "rdu_showBetweenAccDoc_ids";
            this.rdu_showBetweenAccDoc_ids.Size = new System.Drawing.Size(187, 30);
            this.rdu_showBetweenAccDoc_ids.TabIndex = 5;
            this.rdu_showBetweenAccDoc_ids.Text = "نمایش دفتر ما بین سند های ";
            this.rdu_showBetweenAccDoc_ids.UseVisualStyleBackColor = false;
            this.rdu_showBetweenAccDoc_ids.CheckedChanged += new System.EventHandler(this.rdu_showBetweenAccDoc_ids_CheckedChanged);
            // 
            // rdu_showBetweenDates
            // 
            this.rdu_showBetweenDates.AutoSize = true;
            this.rdu_showBetweenDates.BackColor = System.Drawing.Color.Transparent;
            this.rdu_showBetweenDates.Location = new System.Drawing.Point(296, 111);
            this.rdu_showBetweenDates.Name = "rdu_showBetweenDates";
            this.rdu_showBetweenDates.Size = new System.Drawing.Size(192, 30);
            this.rdu_showBetweenDates.TabIndex = 3;
            this.rdu_showBetweenDates.Text = "نمایش دفتر ما بین تاریخ های ";
            this.rdu_showBetweenDates.UseVisualStyleBackColor = false;
            this.rdu_showBetweenDates.CheckedChanged += new System.EventHandler(this.rdu_showBetweenDates_CheckedChanged);
            // 
            // rdu_showAll
            // 
            this.rdu_showAll.AutoSize = true;
            this.rdu_showAll.BackColor = System.Drawing.Color.Transparent;
            this.rdu_showAll.Checked = true;
            this.rdu_showAll.Location = new System.Drawing.Point(370, 25);
            this.rdu_showAll.Name = "rdu_showAll";
            this.rdu_showAll.Size = new System.Drawing.Size(118, 30);
            this.rdu_showAll.TabIndex = 0;
            this.rdu_showAll.TabStop = true;
            this.rdu_showAll.Text = "نمایش کل دفتر .";
            this.rdu_showAll.UseVisualStyleBackColor = false;
            // 
            // rdu_showInDate
            // 
            this.rdu_showInDate.AutoSize = true;
            this.rdu_showInDate.BackColor = System.Drawing.Color.Transparent;
            this.rdu_showInDate.Location = new System.Drawing.Point(346, 64);
            this.rdu_showInDate.Name = "rdu_showInDate";
            this.rdu_showInDate.Size = new System.Drawing.Size(142, 30);
            this.rdu_showInDate.TabIndex = 1;
            this.rdu_showInDate.Text = "نمایش دفتر در تاریخ";
            this.rdu_showInDate.UseVisualStyleBackColor = false;
            this.rdu_showInDate.CheckedChanged += new System.EventHandler(this.rdu_showInDate_CheckedChanged);
            // 
            // frm_remains
            // 
            this.AcceptButton = this.btn_ok;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::cactus_PS_.Properties.Resources.forms_template1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(612, 477);
            this.Controls.Add(this.grp_dateConditions);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.grp_conditions);
            this.Controls.Add(this.grp_bookKind);
            this.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_remains";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مــــــانده حـــســـاب ها";
            this.Load += new System.EventHandler(this.frm_remains_Load);
            this.grp_bookKind.ResumeLayout(false);
            this.grp_bookKind.PerformLayout();
            this.pnl_projects.ResumeLayout(false);
            this.pnl_projects.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectsTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSDatabase5DataSet)).EndInit();
            this.pnl_detailRemains.ResumeLayout(false);
            this.pnl_detailRemains.PerformLayout();
            this.pnl_masterSpent.ResumeLayout(false);
            this.pnl_masterSpent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spentMasterBindingSource)).EndInit();
            this.grp_conditions.ResumeLayout(false);
            this.grp_conditions.PerformLayout();
            this.pnl_toPrice.ResumeLayout(false);
            this.pnl_toPrice.PerformLayout();
            this.grp_dateConditions.ResumeLayout(false);
            this.grp_dateConditions.PerformLayout();
            this.pnl_betweenIDs.ResumeLayout(false);
            this.pnl_betweenIDs.PerformLayout();
            this.pnl_betweenDates.ResumeLayout(false);
            this.pnl_betweenDates.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_bookKind;
        private System.Windows.Forms.Panel pnl_masterSpent;
        private System.Windows.Forms.TextBox tbx_ledgerCode;
        private System.Windows.Forms.ComboBox cmb_masterSpentName;
        public System.Windows.Forms.RadioButton rdu_showLedgerRemains;
        public System.Windows.Forms.RadioButton rdu_showDetailRemains;
        private System.Windows.Forms.CheckBox chk_filterByLedger;
        private PSDatabase5DataSet pSDatabase5DataSet;
        private System.Windows.Forms.BindingSource spentMasterBindingSource;
        private cactus_PS_.PSDatabase5DataSetTableAdapters.spentMasterTableAdapter spentMasterTableAdapter;
        public System.Windows.Forms.RadioButton rdu_showProjectsRemains;
        private System.Windows.Forms.GroupBox grp_conditions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_conditionKind;
        private System.Windows.Forms.RadioButton rdu_allCases;
        private System.Windows.Forms.RadioButton rdu_betweenPrice;
        private System.Windows.Forms.RadioButton rdu_equalsPrice;
        private System.Windows.Forms.RadioButton rdu_moreThanPrice;
        private System.Windows.Forms.RadioButton rdu_lessThanPrice;
        private System.Windows.Forms.TextBox tbx_toPrice;
        private System.Windows.Forms.Panel pnl_toPrice;
        private System.Windows.Forms.TextBox tbx_fromPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Panel pnl_detailRemains;
        private System.Windows.Forms.TextBox tbx_projectID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_projects;
        private System.Windows.Forms.Panel pnl_projects;
        private System.Windows.Forms.BindingSource projectsTableBindingSource;
        private cactus_PS_.PSDatabase5DataSetTableAdapters.projectsTableTableAdapter projectsTableTableAdapter;
        private System.Windows.Forms.GroupBox grp_dateConditions;
        private System.Windows.Forms.Panel pnl_betweenIDs;
        private System.Windows.Forms.TextBox tbx_toID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbx_fromID;
        private System.Windows.Forms.Panel pnl_betweenDates;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mTbx_fromDate;
        private System.Windows.Forms.MaskedTextBox mTbx_toDate;
        private System.Windows.Forms.MaskedTextBox mTbx_inDate;
        private System.Windows.Forms.RadioButton rdu_showBetweenAccDoc_ids;
        private System.Windows.Forms.RadioButton rdu_showBetweenDates;
        private System.Windows.Forms.RadioButton rdu_showAll;
        private System.Windows.Forms.RadioButton rdu_showInDate;
    }
}