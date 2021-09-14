namespace cactus_PS_
{
    partial class frm_pensionsForm
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
            this.pnl_wholeForm = new System.Windows.Forms.Panel();
            this.label28 = new System.Windows.Forms.Label();
            this.grid_Detractions = new System.Windows.Forms.DataGridView();
            this.detractNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detractValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pensionDefBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pSDatabase5DataSet = new cactus_PS_.PSDatabase5DataSet();
            this.grid_Pension = new System.Windows.Forms.DataGridView();
            this.pensionNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pensionValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_detractionsTotal = new System.Windows.Forms.Label();
            this.lbl_pensionsTotal = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.tbx_overtimePensionPrice = new System.Windows.Forms.TextBox();
            this.pensionsTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label27 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.tbx_insuranceDetractPrice = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.tbx_taxDetractPrice = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.tbx_basePensionPrice = new System.Windows.Forms.TextBox();
            this.btn_deleteDetractDef = new System.Windows.Forms.Button();
            this.btn_addDetractDef = new System.Windows.Forms.Button();
            this.btn_deletePensionDef = new System.Windows.Forms.Button();
            this.btn_addPension = new System.Windows.Forms.Button();
            this.lbl_purePensionINDigit = new System.Windows.Forms.Label();
            this.lbl_purePensionINChars = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbx_overtimeHours = new System.Windows.Forms.TextBox();
            this.tbx_workedDays = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.tbx_currentProjectTitle = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbx_job = new System.Windows.Forms.TextBox();
            this.personsTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.tbx_personalNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbx_father = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbx_nationalNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbx_familyAndNAme = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.cmb_familyAndName = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.btn_newPensionForm = new System.Windows.Forms.Button();
            this.btn_deletePensionForm = new System.Windows.Forms.Button();
            this.btn_saveChanges = new System.Windows.Forms.Button();
            this.mTbx_pensionDate = new System.Windows.Forms.MaskedTextBox();
            this.projectsTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_nextPensionForm = new System.Windows.Forms.Button();
            this.btn_priorPensionForm = new System.Windows.Forms.Button();
            this.lbl_currentPosition = new System.Windows.Forms.Label();
            this.lbl_personID = new System.Windows.Forms.Label();
            this.btn_printForm = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbx_pensionFormID = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.projectsTableTableAdapter = new cactus_PS_.PSDatabase5DataSetTableAdapters.projectsTableTableAdapter();
            this.pensionDefTableAdapter = new cactus_PS_.PSDatabase5DataSetTableAdapters.pensionDefTableAdapter();
            this.personsTableTableAdapter = new cactus_PS_.PSDatabase5DataSetTableAdapters.personsTableTableAdapter();
            this.pensionsTableTableAdapter = new cactus_PS_.PSDatabase5DataSetTableAdapters.pensionsTableTableAdapter();
            this.tableAdapterManager = new cactus_PS_.PSDatabase5DataSetTableAdapters.TableAdapterManager();
            this.pnl_wholeForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Detractions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pensionDefBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSDatabase5DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Pension)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pensionsTableBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personsTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsTableBindingSource)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_wholeForm
            // 
            this.pnl_wholeForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_wholeForm.Controls.Add(this.label28);
            this.pnl_wholeForm.Controls.Add(this.grid_Detractions);
            this.pnl_wholeForm.Controls.Add(this.grid_Pension);
            this.pnl_wholeForm.Controls.Add(this.lbl_detractionsTotal);
            this.pnl_wholeForm.Controls.Add(this.lbl_pensionsTotal);
            this.pnl_wholeForm.Controls.Add(this.label26);
            this.pnl_wholeForm.Controls.Add(this.tbx_overtimePensionPrice);
            this.pnl_wholeForm.Controls.Add(this.label27);
            this.pnl_wholeForm.Controls.Add(this.label25);
            this.pnl_wholeForm.Controls.Add(this.label24);
            this.pnl_wholeForm.Controls.Add(this.tbx_insuranceDetractPrice);
            this.pnl_wholeForm.Controls.Add(this.label22);
            this.pnl_wholeForm.Controls.Add(this.tbx_taxDetractPrice);
            this.pnl_wholeForm.Controls.Add(this.label23);
            this.pnl_wholeForm.Controls.Add(this.label20);
            this.pnl_wholeForm.Controls.Add(this.tbx_basePensionPrice);
            this.pnl_wholeForm.Controls.Add(this.btn_deleteDetractDef);
            this.pnl_wholeForm.Controls.Add(this.btn_addDetractDef);
            this.pnl_wholeForm.Controls.Add(this.btn_deletePensionDef);
            this.pnl_wholeForm.Controls.Add(this.btn_addPension);
            this.pnl_wholeForm.Controls.Add(this.lbl_purePensionINDigit);
            this.pnl_wholeForm.Controls.Add(this.lbl_purePensionINChars);
            this.pnl_wholeForm.Controls.Add(this.panel2);
            this.pnl_wholeForm.Controls.Add(this.label10);
            this.pnl_wholeForm.Controls.Add(this.label1);
            this.pnl_wholeForm.Controls.Add(this.label13);
            this.pnl_wholeForm.Controls.Add(this.label12);
            this.pnl_wholeForm.Controls.Add(this.label11);
            this.pnl_wholeForm.Controls.Add(this.panel1);
            this.pnl_wholeForm.Controls.Add(this.label3);
            this.pnl_wholeForm.Controls.Add(this.label2);
            this.pnl_wholeForm.Controls.Add(this.label14);
            this.pnl_wholeForm.Controls.Add(this.label21);
            this.pnl_wholeForm.Location = new System.Drawing.Point(12, 68);
            this.pnl_wholeForm.Name = "pnl_wholeForm";
            this.pnl_wholeForm.Size = new System.Drawing.Size(960, 445);
            this.pnl_wholeForm.TabIndex = 21;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.Silver;
            this.label28.Location = new System.Drawing.Point(9, 401);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(42, 24);
            this.label28.TabIndex = 53;
            this.label28.Text = "ریال";
            // 
            // grid_Detractions
            // 
            this.grid_Detractions.AllowUserToAddRows = false;
            this.grid_Detractions.AllowUserToDeleteRows = false;
            this.grid_Detractions.AllowUserToResizeColumns = false;
            this.grid_Detractions.AllowUserToResizeRows = false;
            this.grid_Detractions.AutoGenerateColumns = false;
            this.grid_Detractions.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grid_Detractions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Detractions.ColumnHeadersVisible = false;
            this.grid_Detractions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.detractNameDataGridViewTextBoxColumn,
            this.detractValueDataGridViewTextBoxColumn});
            this.grid_Detractions.DataSource = this.pensionDefBindingSource;
            this.grid_Detractions.Location = new System.Drawing.Point(179, 159);
            this.grid_Detractions.Name = "grid_Detractions";
            this.grid_Detractions.RowHeadersVisible = false;
            this.grid_Detractions.Size = new System.Drawing.Size(227, 185);
            this.grid_Detractions.TabIndex = 26;
            this.grid_Detractions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_Detractions_CellContentClick);
            // 
            // detractNameDataGridViewTextBoxColumn
            // 
            this.detractNameDataGridViewTextBoxColumn.DataPropertyName = "detractName";
            this.detractNameDataGridViewTextBoxColumn.HeaderText = "detractName";
            this.detractNameDataGridViewTextBoxColumn.Name = "detractNameDataGridViewTextBoxColumn";
            // 
            // detractValueDataGridViewTextBoxColumn
            // 
            this.detractValueDataGridViewTextBoxColumn.DataPropertyName = "detractValue";
            this.detractValueDataGridViewTextBoxColumn.HeaderText = "detractValue";
            this.detractValueDataGridViewTextBoxColumn.Name = "detractValueDataGridViewTextBoxColumn";
            this.detractValueDataGridViewTextBoxColumn.Width = 123;
            // 
            // pensionDefBindingSource
            // 
            this.pensionDefBindingSource.DataMember = "pensionDef";
            this.pensionDefBindingSource.DataSource = this.pSDatabase5DataSet;
            // 
            // pSDatabase5DataSet
            // 
            this.pSDatabase5DataSet.DataSetName = "PSDatabase5DataSet";
            this.pSDatabase5DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grid_Pension
            // 
            this.grid_Pension.AllowUserToAddRows = false;
            this.grid_Pension.AllowUserToDeleteRows = false;
            this.grid_Pension.AllowUserToResizeColumns = false;
            this.grid_Pension.AllowUserToResizeRows = false;
            this.grid_Pension.AutoGenerateColumns = false;
            this.grid_Pension.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grid_Pension.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Pension.ColumnHeadersVisible = false;
            this.grid_Pension.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pensionNameDataGridViewTextBoxColumn,
            this.pensionValueDataGridViewTextBoxColumn});
            this.grid_Pension.DataSource = this.pensionDefBindingSource;
            this.grid_Pension.Location = new System.Drawing.Point(402, 159);
            this.grid_Pension.Name = "grid_Pension";
            this.grid_Pension.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grid_Pension.RowHeadersVisible = false;
            this.grid_Pension.Size = new System.Drawing.Size(247, 185);
            this.grid_Pension.TabIndex = 52;
            this.grid_Pension.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_Pension_CellContentClick_1);
            // 
            // pensionNameDataGridViewTextBoxColumn
            // 
            this.pensionNameDataGridViewTextBoxColumn.DataPropertyName = "pensionName";
            this.pensionNameDataGridViewTextBoxColumn.HeaderText = "pensionName";
            this.pensionNameDataGridViewTextBoxColumn.Name = "pensionNameDataGridViewTextBoxColumn";
            this.pensionNameDataGridViewTextBoxColumn.Width = 116;
            // 
            // pensionValueDataGridViewTextBoxColumn
            // 
            this.pensionValueDataGridViewTextBoxColumn.DataPropertyName = "pensionValue";
            this.pensionValueDataGridViewTextBoxColumn.HeaderText = "pensionValue";
            this.pensionValueDataGridViewTextBoxColumn.Name = "pensionValueDataGridViewTextBoxColumn";
            this.pensionValueDataGridViewTextBoxColumn.Width = 128;
            // 
            // lbl_detractionsTotal
            // 
            this.lbl_detractionsTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_detractionsTotal.Location = new System.Drawing.Point(187, 353);
            this.lbl_detractionsTotal.Name = "lbl_detractionsTotal";
            this.lbl_detractionsTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_detractionsTotal.Size = new System.Drawing.Size(118, 32);
            this.lbl_detractionsTotal.TabIndex = 51;
            this.lbl_detractionsTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_pensionsTotal
            // 
            this.lbl_pensionsTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_pensionsTotal.Location = new System.Drawing.Point(413, 353);
            this.lbl_pensionsTotal.Name = "lbl_pensionsTotal";
            this.lbl_pensionsTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_pensionsTotal.Size = new System.Drawing.Size(118, 32);
            this.lbl_pensionsTotal.TabIndex = 50;
            this.lbl_pensionsTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(554, 124);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(105, 24);
            this.label26.TabIndex = 48;
            this.label26.Text = "اضافه کاری :";
            // 
            // tbx_overtimePensionPrice
            // 
            this.tbx_overtimePensionPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbx_overtimePensionPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_overtimePensionPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pensionsTableBindingSource, "overtimePension", true));
            this.tbx_overtimePensionPrice.Location = new System.Drawing.Point(405, 122);
            this.tbx_overtimePensionPrice.Name = "tbx_overtimePensionPrice";
            this.tbx_overtimePensionPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_overtimePensionPrice.Size = new System.Drawing.Size(126, 29);
            this.tbx_overtimePensionPrice.TabIndex = 47;
            this.tbx_overtimePensionPrice.Text = "0";
            this.tbx_overtimePensionPrice.TextChanged += new System.EventHandler(this.tbx_overtimePensionPrice_TextChanged);
            // 
            // pensionsTableBindingSource
            // 
            this.pensionsTableBindingSource.DataMember = "pensionsTable";
            this.pensionsTableBindingSource.DataSource = this.pSDatabase5DataSet;
            // 
            // label27
            // 
            this.label27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label27.Location = new System.Drawing.Point(405, 122);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(243, 38);
            this.label27.TabIndex = 49;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(327, 127);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(73, 24);
            this.label25.TabIndex = 46;
            this.label25.Text = "حق بیمه:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(337, 88);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(66, 24);
            this.label24.TabIndex = 45;
            this.label24.Text = "مالیات :";
            // 
            // tbx_insuranceDetractPrice
            // 
            this.tbx_insuranceDetractPrice.BackColor = System.Drawing.SystemColors.Control;
            this.tbx_insuranceDetractPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_insuranceDetractPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pensionsTableBindingSource, "insuranceDetraction", true));
            this.tbx_insuranceDetractPrice.Location = new System.Drawing.Point(179, 123);
            this.tbx_insuranceDetractPrice.Name = "tbx_insuranceDetractPrice";
            this.tbx_insuranceDetractPrice.ReadOnly = true;
            this.tbx_insuranceDetractPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_insuranceDetractPrice.Size = new System.Drawing.Size(126, 29);
            this.tbx_insuranceDetractPrice.TabIndex = 43;
            this.tbx_insuranceDetractPrice.TabStop = false;
            this.tbx_insuranceDetractPrice.Text = "0";
            this.tbx_insuranceDetractPrice.TextChanged += new System.EventHandler(this.tbx_insuranceDetractPrice_TextChanged);
            // 
            // label22
            // 
            this.label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label22.Location = new System.Drawing.Point(179, 123);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(227, 38);
            this.label22.TabIndex = 44;
            // 
            // tbx_taxDetractPrice
            // 
            this.tbx_taxDetractPrice.BackColor = System.Drawing.SystemColors.Control;
            this.tbx_taxDetractPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_taxDetractPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pensionsTableBindingSource, "taxDetraction", true));
            this.tbx_taxDetractPrice.Location = new System.Drawing.Point(179, 86);
            this.tbx_taxDetractPrice.Name = "tbx_taxDetractPrice";
            this.tbx_taxDetractPrice.ReadOnly = true;
            this.tbx_taxDetractPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_taxDetractPrice.Size = new System.Drawing.Size(126, 29);
            this.tbx_taxDetractPrice.TabIndex = 40;
            this.tbx_taxDetractPrice.TabStop = false;
            this.tbx_taxDetractPrice.Text = "0";
            this.tbx_taxDetractPrice.TextChanged += new System.EventHandler(this.tbx_taxDetractPrice_TextChanged);
            // 
            // label23
            // 
            this.label23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label23.Location = new System.Drawing.Point(179, 86);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(227, 38);
            this.label23.TabIndex = 42;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(554, 88);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(91, 24);
            this.label20.TabIndex = 38;
            this.label20.Text = "پایه حقوق :";
            // 
            // tbx_basePensionPrice
            // 
            this.tbx_basePensionPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbx_basePensionPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_basePensionPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pensionsTableBindingSource, "basePension", true));
            this.tbx_basePensionPrice.Location = new System.Drawing.Point(405, 86);
            this.tbx_basePensionPrice.Name = "tbx_basePensionPrice";
            this.tbx_basePensionPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_basePensionPrice.Size = new System.Drawing.Size(126, 29);
            this.tbx_basePensionPrice.TabIndex = 37;
            this.tbx_basePensionPrice.Text = "0";
            this.tbx_basePensionPrice.TextChanged += new System.EventHandler(this.tbx_basePensionPrice_TextChanged);
            // 
            // btn_deleteDetractDef
            // 
            this.btn_deleteDetractDef.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_deleteDetractDef.ForeColor = System.Drawing.Color.Red;
            this.btn_deleteDetractDef.Location = new System.Drawing.Point(192, 5);
            this.btn_deleteDetractDef.Name = "btn_deleteDetractDef";
            this.btn_deleteDetractDef.Size = new System.Drawing.Size(45, 28);
            this.btn_deleteDetractDef.TabIndex = 36;
            this.btn_deleteDetractDef.Text = "حذف";
            this.btn_deleteDetractDef.UseVisualStyleBackColor = true;
            this.btn_deleteDetractDef.Click += new System.EventHandler(this.btn_deleteDetractDef_Click);
            // 
            // btn_addDetractDef
            // 
            this.btn_addDetractDef.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_addDetractDef.ForeColor = System.Drawing.Color.Green;
            this.btn_addDetractDef.Location = new System.Drawing.Point(243, 5);
            this.btn_addDetractDef.Name = "btn_addDetractDef";
            this.btn_addDetractDef.Size = new System.Drawing.Size(151, 28);
            this.btn_addDetractDef.TabIndex = 35;
            this.btn_addDetractDef.Text = "اضافه کردن گزینه";
            this.btn_addDetractDef.UseVisualStyleBackColor = true;
            this.btn_addDetractDef.Click += new System.EventHandler(this.btn_addDetractDef_Click);
            // 
            // btn_deletePensionDef
            // 
            this.btn_deletePensionDef.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_deletePensionDef.ForeColor = System.Drawing.Color.Red;
            this.btn_deletePensionDef.Location = new System.Drawing.Point(418, 5);
            this.btn_deletePensionDef.Name = "btn_deletePensionDef";
            this.btn_deletePensionDef.Size = new System.Drawing.Size(48, 28);
            this.btn_deletePensionDef.TabIndex = 23;
            this.btn_deletePensionDef.Text = "حذف";
            this.btn_deletePensionDef.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_deletePensionDef.UseVisualStyleBackColor = true;
            this.btn_deletePensionDef.Click += new System.EventHandler(this.btn_deletePensionDef_Click);
            // 
            // btn_addPension
            // 
            this.btn_addPension.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_addPension.ForeColor = System.Drawing.Color.Green;
            this.btn_addPension.Location = new System.Drawing.Point(472, 5);
            this.btn_addPension.Name = "btn_addPension";
            this.btn_addPension.Size = new System.Drawing.Size(170, 28);
            this.btn_addPension.TabIndex = 22;
            this.btn_addPension.Text = "اضافه کردن گزینه";
            this.btn_addPension.UseVisualStyleBackColor = true;
            this.btn_addPension.Click += new System.EventHandler(this.btn_addPension_Click);
            // 
            // lbl_purePensionINDigit
            // 
            this.lbl_purePensionINDigit.BackColor = System.Drawing.Color.LightGray;
            this.lbl_purePensionINDigit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_purePensionINDigit.Location = new System.Drawing.Point(53, 401);
            this.lbl_purePensionINDigit.Name = "lbl_purePensionINDigit";
            this.lbl_purePensionINDigit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_purePensionINDigit.Size = new System.Drawing.Size(135, 29);
            this.lbl_purePensionINDigit.TabIndex = 34;
            // 
            // lbl_purePensionINChars
            // 
            this.lbl_purePensionINChars.BackColor = System.Drawing.Color.LightGray;
            this.lbl_purePensionINChars.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_purePensionINChars.Location = new System.Drawing.Point(209, 401);
            this.lbl_purePensionINChars.Name = "lbl_purePensionINChars";
            this.lbl_purePensionINChars.Size = new System.Drawing.Size(625, 29);
            this.lbl_purePensionINChars.TabIndex = 33;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.tbx_overtimeHours);
            this.panel2.Controls.Add(this.tbx_workedDays);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Location = new System.Drawing.Point(3, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(177, 258);
            this.panel2.TabIndex = 28;
            // 
            // tbx_overtimeHours
            // 
            this.tbx_overtimeHours.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbx_overtimeHours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_overtimeHours.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pensionsTableBindingSource, "overtimeHours", true));
            this.tbx_overtimeHours.Location = new System.Drawing.Point(-1, 36);
            this.tbx_overtimeHours.Name = "tbx_overtimeHours";
            this.tbx_overtimeHours.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_overtimeHours.Size = new System.Drawing.Size(53, 29);
            this.tbx_overtimeHours.TabIndex = 7;
            this.tbx_overtimeHours.Text = "0";
            // 
            // tbx_workedDays
            // 
            this.tbx_workedDays.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbx_workedDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_workedDays.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pensionsTableBindingSource, "workedDays", true));
            this.tbx_workedDays.Location = new System.Drawing.Point(-1, -1);
            this.tbx_workedDays.Name = "tbx_workedDays";
            this.tbx_workedDays.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_workedDays.Size = new System.Drawing.Size(53, 29);
            this.tbx_workedDays.TabIndex = 5;
            this.tbx_workedDays.Text = "0";
            // 
            // label15
            // 
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.Location = new System.Drawing.Point(7, 36);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(169, 38);
            this.label15.TabIndex = 8;
            this.label15.Text = "اضافه کاری :";
            // 
            // label16
            // 
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label16.Location = new System.Drawing.Point(7, -1);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(169, 38);
            this.label16.TabIndex = 6;
            this.label16.Text = "روز های کارکرد:";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Silver;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(3, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(177, 47);
            this.label10.TabIndex = 27;
            this.label10.Text = "عملکرد           ساعت کارکرد";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(647, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 47);
            this.label1.TabIndex = 21;
            this.label1.Text = "مشخصات پرسنلی";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(179, 347);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(227, 44);
            this.label13.TabIndex = 31;
            this.label13.Text = "جمع کسورات :";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(405, 347);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(243, 44);
            this.label12.TabIndex = 29;
            this.label12.Text = "جمع حقوق و مزایا :";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Location = new System.Drawing.Point(3, 347);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(950, 44);
            this.label11.TabIndex = 30;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.tbx_currentProjectTitle);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.tbx_job);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tbx_personalNumber);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tbx_father);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbx_nationalNumber);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbx_familyAndNAme);
            this.panel1.Location = new System.Drawing.Point(647, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 258);
            this.panel1.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(157, 220);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 25);
            this.label9.TabIndex = 16;
            this.label9.Text = "محل خدمت :";
            // 
            // tbx_currentProjectTitle
            // 
            this.tbx_currentProjectTitle.BackColor = System.Drawing.SystemColors.Control;
            this.tbx_currentProjectTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_currentProjectTitle.Location = new System.Drawing.Point(8, 219);
            this.tbx_currentProjectTitle.Name = "tbx_currentProjectTitle";
            this.tbx_currentProjectTitle.ReadOnly = true;
            this.tbx_currentProjectTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbx_currentProjectTitle.Size = new System.Drawing.Size(143, 22);
            this.tbx_currentProjectTitle.TabIndex = 15;
            this.tbx_currentProjectTitle.TabStop = false;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(157, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "سمت :";
            // 
            // tbx_job
            // 
            this.tbx_job.BackColor = System.Drawing.SystemColors.Control;
            this.tbx_job.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_job.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsTableBindingSource, "job", true));
            this.tbx_job.Location = new System.Drawing.Point(8, 175);
            this.tbx_job.Name = "tbx_job";
            this.tbx_job.ReadOnly = true;
            this.tbx_job.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbx_job.Size = new System.Drawing.Size(143, 22);
            this.tbx_job.TabIndex = 13;
            this.tbx_job.TabStop = false;
            // 
            // personsTableBindingSource
            // 
            this.personsTableBindingSource.DataMember = "personsTable";
            this.personsTableBindingSource.DataSource = this.pSDatabase5DataSet;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(157, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "شماره پرسنلی :";
            // 
            // tbx_personalNumber
            // 
            this.tbx_personalNumber.BackColor = System.Drawing.SystemColors.Control;
            this.tbx_personalNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_personalNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsTableBindingSource, "personelNumber", true));
            this.tbx_personalNumber.Location = new System.Drawing.Point(8, 6);
            this.tbx_personalNumber.Name = "tbx_personalNumber";
            this.tbx_personalNumber.ReadOnly = true;
            this.tbx_personalNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbx_personalNumber.Size = new System.Drawing.Size(143, 22);
            this.tbx_personalNumber.TabIndex = 11;
            this.tbx_personalNumber.TabStop = false;
            this.tbx_personalNumber.TextChanged += new System.EventHandler(this.tbx_personalNumber_TextChanged);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(157, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "نام پدر :";
            // 
            // tbx_father
            // 
            this.tbx_father.BackColor = System.Drawing.SystemColors.Control;
            this.tbx_father.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_father.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsTableBindingSource, "fatherName", true));
            this.tbx_father.Location = new System.Drawing.Point(8, 87);
            this.tbx_father.Name = "tbx_father";
            this.tbx_father.ReadOnly = true;
            this.tbx_father.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbx_father.Size = new System.Drawing.Size(143, 22);
            this.tbx_father.TabIndex = 9;
            this.tbx_father.TabStop = false;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(157, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "کد ملی :";
            // 
            // tbx_nationalNumber
            // 
            this.tbx_nationalNumber.BackColor = System.Drawing.SystemColors.Control;
            this.tbx_nationalNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_nationalNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsTableBindingSource, "nationalNumber", true));
            this.tbx_nationalNumber.Location = new System.Drawing.Point(8, 43);
            this.tbx_nationalNumber.Name = "tbx_nationalNumber";
            this.tbx_nationalNumber.ReadOnly = true;
            this.tbx_nationalNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbx_nationalNumber.Size = new System.Drawing.Size(143, 22);
            this.tbx_nationalNumber.TabIndex = 7;
            this.tbx_nationalNumber.TabStop = false;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(158, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "نام و نام خانوادگی :";
            // 
            // tbx_familyAndNAme
            // 
            this.tbx_familyAndNAme.BackColor = System.Drawing.SystemColors.Control;
            this.tbx_familyAndNAme.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_familyAndNAme.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsTableBindingSource, "personFamilyAndName", true));
            this.tbx_familyAndNAme.Location = new System.Drawing.Point(8, 129);
            this.tbx_familyAndNAme.Name = "tbx_familyAndNAme";
            this.tbx_familyAndNAme.ReadOnly = true;
            this.tbx_familyAndNAme.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbx_familyAndNAme.Size = new System.Drawing.Size(143, 22);
            this.tbx_familyAndNAme.TabIndex = 5;
            this.tbx_familyAndNAme.TabStop = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(177, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 47);
            this.label3.TabIndex = 23;
            this.label3.Text = "کسورات                           مبلغ به ریال";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(401, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 47);
            this.label2.TabIndex = 22;
            this.label2.Text = "حقوق و مزایا                      مبلغ به ریال";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Silver;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.Location = new System.Drawing.Point(3, 394);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(950, 44);
            this.label14.TabIndex = 32;
            this.label14.Text = "خالص پرداختی :";
            // 
            // label21
            // 
            this.label21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label21.Location = new System.Drawing.Point(405, 86);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(243, 38);
            this.label21.TabIndex = 39;
            // 
            // cmb_familyAndName
            // 
            this.cmb_familyAndName.DataSource = this.personsTableBindingSource;
            this.cmb_familyAndName.DisplayMember = "personFamilyAndName";
            this.cmb_familyAndName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_familyAndName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmb_familyAndName.FormattingEnabled = true;
            this.cmb_familyAndName.Location = new System.Drawing.Point(670, 7);
            this.cmb_familyAndName.MaxDropDownItems = 10;
            this.cmb_familyAndName.Name = "cmb_familyAndName";
            this.cmb_familyAndName.Size = new System.Drawing.Size(182, 32);
            this.cmb_familyAndName.TabIndex = 1;
            this.cmb_familyAndName.ValueMember = "personID";
            this.cmb_familyAndName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_familyAndName_KeyPress);
            this.cmb_familyAndName.SelectedValueChanged += new System.EventHandler(this.cmb_familyAndName_SelectedValueChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Location = new System.Drawing.Point(858, 12);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(108, 24);
            this.label17.TabIndex = 23;
            this.label17.Text = "طرف حساب :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Location = new System.Drawing.Point(108, 12);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(95, 24);
            this.label18.TabIndex = 25;
            this.label18.Text = "تاریخ فیش :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Location = new System.Drawing.Point(268, 10);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(97, 24);
            this.label19.TabIndex = 27;
            this.label19.Text = "شماره فیش :";
            // 
            // btn_newPensionForm
            // 
            this.btn_newPensionForm.BackColor = System.Drawing.Color.Azure;
            this.btn_newPensionForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_newPensionForm.ForeColor = System.Drawing.Color.Green;
            this.btn_newPensionForm.Location = new System.Drawing.Point(828, 520);
            this.btn_newPensionForm.Name = "btn_newPensionForm";
            this.btn_newPensionForm.Size = new System.Drawing.Size(112, 40);
            this.btn_newPensionForm.TabIndex = 1;
            this.btn_newPensionForm.Text = "* فیش جدید";
            this.btn_newPensionForm.UseVisualStyleBackColor = false;
            this.btn_newPensionForm.Click += new System.EventHandler(this.btn_newPensionForm_Click);
            // 
            // btn_deletePensionForm
            // 
            this.btn_deletePensionForm.BackColor = System.Drawing.Color.Azure;
            this.btn_deletePensionForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_deletePensionForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_deletePensionForm.Location = new System.Drawing.Point(528, 520);
            this.btn_deletePensionForm.Name = "btn_deletePensionForm";
            this.btn_deletePensionForm.Size = new System.Drawing.Size(112, 39);
            this.btn_deletePensionForm.TabIndex = 3;
            this.btn_deletePensionForm.Text = "حذف فیش";
            this.btn_deletePensionForm.UseVisualStyleBackColor = false;
            this.btn_deletePensionForm.Click += new System.EventHandler(this.btn_deletePensionForm_Click);
            // 
            // btn_saveChanges
            // 
            this.btn_saveChanges.BackColor = System.Drawing.Color.Azure;
            this.btn_saveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_saveChanges.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_saveChanges.Location = new System.Drawing.Point(646, 520);
            this.btn_saveChanges.Name = "btn_saveChanges";
            this.btn_saveChanges.Size = new System.Drawing.Size(176, 39);
            this.btn_saveChanges.TabIndex = 2;
            this.btn_saveChanges.Text = "ثبت فیش";
            this.btn_saveChanges.UseVisualStyleBackColor = false;
            this.btn_saveChanges.Click += new System.EventHandler(this.btn_saveChanges_Click);
            // 
            // mTbx_pensionDate
            // 
            this.mTbx_pensionDate.AllowPromptAsInput = false;
            this.mTbx_pensionDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pensionsTableBindingSource, "dDate", true));
            this.mTbx_pensionDate.Location = new System.Drawing.Point(9, 7);
            this.mTbx_pensionDate.Mask = "0000/00";
            this.mTbx_pensionDate.Name = "mTbx_pensionDate";
            this.mTbx_pensionDate.PromptChar = ' ';
            this.mTbx_pensionDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mTbx_pensionDate.Size = new System.Drawing.Size(90, 29);
            this.mTbx_pensionDate.TabIndex = 4;
            this.mTbx_pensionDate.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mTbx_pensionDate_KeyUp);
            // 
            // btn_nextPensionForm
            // 
            this.btn_nextPensionForm.Location = new System.Drawing.Point(582, 10);
            this.btn_nextPensionForm.Name = "btn_nextPensionForm";
            this.btn_nextPensionForm.Size = new System.Drawing.Size(82, 34);
            this.btn_nextPensionForm.TabIndex = 2;
            this.btn_nextPensionForm.Text = " < بعدی";
            this.btn_nextPensionForm.UseVisualStyleBackColor = true;
            this.btn_nextPensionForm.Click += new System.EventHandler(this.btn_nextPensionForm_Click);
            // 
            // btn_priorPensionForm
            // 
            this.btn_priorPensionForm.Location = new System.Drawing.Point(494, 10);
            this.btn_priorPensionForm.Name = "btn_priorPensionForm";
            this.btn_priorPensionForm.Size = new System.Drawing.Size(82, 34);
            this.btn_priorPensionForm.TabIndex = 3;
            this.btn_priorPensionForm.Text = "قبلی >";
            this.btn_priorPensionForm.UseVisualStyleBackColor = true;
            this.btn_priorPensionForm.Click += new System.EventHandler(this.btn_priorPensionForm_Click);
            // 
            // lbl_currentPosition
            // 
            this.lbl_currentPosition.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_currentPosition.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_currentPosition.Location = new System.Drawing.Point(372, 7);
            this.lbl_currentPosition.Name = "lbl_currentPosition";
            this.lbl_currentPosition.Size = new System.Drawing.Size(116, 36);
            this.lbl_currentPosition.TabIndex = 53;
            this.lbl_currentPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_personID
            // 
            this.lbl_personID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_personID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsTableBindingSource, "personID", true));
            this.lbl_personID.Location = new System.Drawing.Point(1005, 15);
            this.lbl_personID.Name = "lbl_personID";
            this.lbl_personID.Size = new System.Drawing.Size(38, 36);
            this.lbl_personID.TabIndex = 54;
            this.lbl_personID.TextChanged += new System.EventHandler(this.lbl_personID_TextChanged);
            this.lbl_personID.Click += new System.EventHandler(this.lbl_personID_Click);
            // 
            // btn_printForm
            // 
            this.btn_printForm.BackColor = System.Drawing.Color.Azure;
            this.btn_printForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_printForm.ForeColor = System.Drawing.Color.DarkViolet;
            this.btn_printForm.Location = new System.Drawing.Point(410, 519);
            this.btn_printForm.Name = "btn_printForm";
            this.btn_printForm.Size = new System.Drawing.Size(112, 40);
            this.btn_printForm.TabIndex = 4;
            this.btn_printForm.Text = "چاپ فیش";
            this.btn_printForm.UseVisualStyleBackColor = false;
            this.btn_printForm.Click += new System.EventHandler(this.btn_printForm_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Image = global::cactus_PS_.Properties.Resources.OOFL;
            this.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cancel.Location = new System.Drawing.Point(15, 519);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(135, 40);
            this.btn_cancel.TabIndex = 56;
            this.btn_cancel.Text = "بستن";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel4.BackgroundImage = global::cactus_PS_.Properties.Resources.head21;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.tbx_pensionFormID);
            this.panel4.Controls.Add(this.lbl_currentPosition);
            this.panel4.Controls.Add(this.btn_priorPensionForm);
            this.panel4.Controls.Add(this.btn_nextPensionForm);
            this.panel4.Controls.Add(this.mTbx_pensionDate);
            this.panel4.Controls.Add(this.label19);
            this.panel4.Controls.Add(this.label18);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Controls.Add(this.cmb_familyAndName);
            this.panel4.Location = new System.Drawing.Point(12, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(960, 54);
            this.panel4.TabIndex = 0;
            // 
            // tbx_pensionFormID
            // 
            this.tbx_pensionFormID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pensionsTableBindingSource, "pensionID", true));
            this.tbx_pensionFormID.Location = new System.Drawing.Point(206, 7);
            this.tbx_pensionFormID.Name = "tbx_pensionFormID";
            this.tbx_pensionFormID.ReadOnly = true;
            this.tbx_pensionFormID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_pensionFormID.Size = new System.Drawing.Size(56, 29);
            this.tbx_pensionFormID.TabIndex = 56;
            this.tbx_pensionFormID.TabStop = false;
            this.tbx_pensionFormID.Text = "0";
            this.tbx_pensionFormID.TextChanged += new System.EventHandler(this.tbx_pensionFormID_TextChanged);
            this.tbx_pensionFormID.Click += new System.EventHandler(this.tbx_pensionFormID_Click);
            // 
            // projectsTableTableAdapter
            // 
            this.projectsTableTableAdapter.ClearBeforeFill = true;
            // 
            // pensionDefTableAdapter
            // 
            this.pensionDefTableAdapter.ClearBeforeFill = true;
            // 
            // personsTableTableAdapter
            // 
            this.personsTableTableAdapter.ClearBeforeFill = true;
            // 
            // pensionsTableTableAdapter
            // 
            this.pensionsTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.accDocEventsTableTableAdapter = null;
            this.tableAdapterManager.AccountingDocsTableAdapter = null;
            this.tableAdapterManager.AccountsTableTableAdapter = null;
            this.tableAdapterManager.accountTypesTableTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BanksTableTableAdapter = null;
            this.tableAdapterManager.chequesTableTableAdapter = null;
            this.tableAdapterManager.detailsTableTableAdapter = null;
            this.tableAdapterManager.detractDefTableAdapter = null;
            this.tableAdapterManager.docsTableTableAdapter = null;
            this.tableAdapterManager.freeFormsTableTableAdapter = null;
            this.tableAdapterManager.invoiceItemsTableTableAdapter = null;
            this.tableAdapterManager.invoicesTableTableAdapter = null;
            this.tableAdapterManager.pensionDefTableAdapter = this.pensionDefTableAdapter;
            this.tableAdapterManager.pensionsTableTableAdapter = this.pensionsTableTableAdapter;
            this.tableAdapterManager.personsTableTableAdapter = this.personsTableTableAdapter;
            this.tableAdapterManager.projectsPersonsTableAdapter = null;
            this.tableAdapterManager.projectsTableTableAdapter = this.projectsTableTableAdapter;
            this.tableAdapterManager.spentDefTableAdapter = null;
            this.tableAdapterManager.spentGroupsTableTableAdapter = null;
            this.tableAdapterManager.spentMasterTableAdapter = null;
            this.tableAdapterManager.TaraznamehTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = cactus_PS_.PSDatabase5DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableTableAdapter = null;
            // 
            // frm_pensionsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(981, 568);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_printForm);
            this.Controls.Add(this.lbl_personID);
            this.Controls.Add(this.btn_saveChanges);
            this.Controls.Add(this.btn_deletePensionForm);
            this.Controls.Add(this.btn_newPensionForm);
            this.Controls.Add(this.pnl_wholeForm);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_pensionsForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.frm_pensionsForm_Load);
            this.Shown += new System.EventHandler(this.frm_pensionsForm_Shown);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_pensionsForm_FormClosed);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_pensionsForm_FormClosing);
            this.pnl_wholeForm.ResumeLayout(false);
            this.pnl_wholeForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Detractions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pensionDefBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSDatabase5DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Pension)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pensionsTableBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personsTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsTableBindingSource)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_wholeForm;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbx_overtimeHours;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbx_workedDays;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView grid_Detractions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbx_currentProjectTitle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbx_job;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbx_personalNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbx_father;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbx_nationalNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbx_familyAndNAme;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbl_purePensionINChars;
        private System.Windows.Forms.Label lbl_purePensionINDigit;
        private System.Windows.Forms.Button btn_addPension;
        private System.Windows.Forms.Button btn_deletePensionDef;
        private System.Windows.Forms.Button btn_deleteDetractDef;
        private System.Windows.Forms.Button btn_addDetractDef;
        private System.Windows.Forms.ComboBox cmb_familyAndName;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btn_newPensionForm;
        private System.Windows.Forms.Button btn_deletePensionForm;
        private System.Windows.Forms.Button btn_saveChanges;
        private System.Windows.Forms.TextBox tbx_basePensionPrice;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox tbx_taxDetractPrice;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox tbx_insuranceDetractPrice;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox tbx_overtimePensionPrice;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.MaskedTextBox mTbx_pensionDate;
        private System.Windows.Forms.BindingSource projectsTableBindingSource;
        private cactus_PS_.PSDatabase5DataSetTableAdapters.projectsTableTableAdapter projectsTableTableAdapter;
        private System.Windows.Forms.Button btn_nextPensionForm;
        private System.Windows.Forms.Button btn_priorPensionForm;
        private System.Windows.Forms.Label lbl_currentPosition;
        private System.Windows.Forms.Label lbl_personID;
        private System.Windows.Forms.Label lbl_pensionsTotal;
        private System.Windows.Forms.Label lbl_detractionsTotal;
        private System.Windows.Forms.DataGridView grid_Pension;
        private System.Windows.Forms.Button btn_printForm;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Panel panel4;
        private PSDatabase5DataSet pSDatabase5DataSet;
        private System.Windows.Forms.BindingSource pensionDefBindingSource;
        private cactus_PS_.PSDatabase5DataSetTableAdapters.pensionDefTableAdapter pensionDefTableAdapter;
        private System.Windows.Forms.BindingSource personsTableBindingSource;
        private cactus_PS_.PSDatabase5DataSetTableAdapters.personsTableTableAdapter personsTableTableAdapter;
        private System.Windows.Forms.BindingSource pensionsTableBindingSource;
        private cactus_PS_.PSDatabase5DataSetTableAdapters.pensionsTableTableAdapter pensionsTableTableAdapter;
        private cactus_PS_.PSDatabase5DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn detractNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detractValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pensionNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pensionValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox tbx_pensionFormID;

    }
}