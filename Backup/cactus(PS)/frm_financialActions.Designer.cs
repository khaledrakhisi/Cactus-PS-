namespace cactus_PS_
{
    partial class frm_financialActions
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
            this.grp_actions = new System.Windows.Forms.GroupBox();
            this.pnl_banks = new System.Windows.Forms.Panel();
            this.cmb_accountNumber = new System.Windows.Forms.ComboBox();
            this.docsTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pSDatabase5DataSet = new cactus_PS_.PSDatabase5DataSet();
            this.accountsTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_accountNumberPrompt = new System.Windows.Forms.Label();
            this.cmb_banksName = new System.Windows.Forms.ComboBox();
            this.banksTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.rdu_receiveAnCheque = new System.Windows.Forms.RadioButton();
            this.rdu_issuanceAnCheque = new System.Windows.Forms.RadioButton();
            this.lbl_personID = new System.Windows.Forms.Label();
            this.personsTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.docsTableTableAdapter = new cactus_PS_.PSDatabase5DataSetTableAdapters.docsTableTableAdapter();
            this.personsTableTableAdapter = new cactus_PS_.PSDatabase5DataSetTableAdapters.personsTableTableAdapter();
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_saveChanges = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.pnl_person = new System.Windows.Forms.Panel();
            this.lbl_currentPosition = new System.Windows.Forms.Label();
            this.btn_returnPrior = new System.Windows.Forms.Button();
            this.btn_goNext = new System.Windows.Forms.Button();
            this.mTbx_Date = new System.Windows.Forms.MaskedTextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tbx_ID = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cmb_familyAndName = new System.Windows.Forms.ComboBox();
            this.pnl_price = new System.Windows.Forms.Panel();
            this.lbl_priceInChars = new System.Windows.Forms.Label();
            this.tbx_price = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_event = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.banksTableTableAdapter = new cactus_PS_.PSDatabase5DataSetTableAdapters.BanksTableTableAdapter();
            this.accountsTableTableAdapter = new cactus_PS_.PSDatabase5DataSetTableAdapters.AccountsTableTableAdapter();
            this.grp_actions.SuspendLayout();
            this.pnl_banks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.docsTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSDatabase5DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banksTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsTableBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnl_person.SuspendLayout();
            this.pnl_price.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_actions
            // 
            this.grp_actions.BackColor = System.Drawing.Color.Transparent;
            this.grp_actions.Controls.Add(this.pnl_banks);
            this.grp_actions.Controls.Add(this.rdu_receiveAnCheque);
            this.grp_actions.Controls.Add(this.rdu_issuanceAnCheque);
            this.grp_actions.Location = new System.Drawing.Point(35, 171);
            this.grp_actions.Name = "grp_actions";
            this.grp_actions.Size = new System.Drawing.Size(631, 128);
            this.grp_actions.TabIndex = 0;
            this.grp_actions.TabStop = false;
            this.grp_actions.Text = "عملیات";
            // 
            // pnl_banks
            // 
            this.pnl_banks.Controls.Add(this.cmb_accountNumber);
            this.pnl_banks.Controls.Add(this.lbl_accountNumberPrompt);
            this.pnl_banks.Controls.Add(this.cmb_banksName);
            this.pnl_banks.Controls.Add(this.label5);
            this.pnl_banks.Enabled = false;
            this.pnl_banks.Location = new System.Drawing.Point(20, 70);
            this.pnl_banks.Name = "pnl_banks";
            this.pnl_banks.Size = new System.Drawing.Size(586, 50);
            this.pnl_banks.TabIndex = 65;
            // 
            // cmb_accountNumber
            // 
            this.cmb_accountNumber.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.docsTableBindingSource, "accountID", true));
            this.cmb_accountNumber.DataSource = this.accountsTableBindingSource;
            this.cmb_accountNumber.DisplayMember = "account_number";
            this.cmb_accountNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_accountNumber.FormattingEnabled = true;
            this.cmb_accountNumber.Location = new System.Drawing.Point(23, 6);
            this.cmb_accountNumber.Name = "cmb_accountNumber";
            this.cmb_accountNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmb_accountNumber.Size = new System.Drawing.Size(166, 38);
            this.cmb_accountNumber.TabIndex = 63;
            this.cmb_accountNumber.ValueMember = "accountID";
            // 
            // docsTableBindingSource
            // 
            this.docsTableBindingSource.DataMember = "docsTable";
            this.docsTableBindingSource.DataSource = this.pSDatabase5DataSet;
            // 
            // pSDatabase5DataSet
            // 
            this.pSDatabase5DataSet.DataSetName = "PSDatabase5DataSet";
            this.pSDatabase5DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accountsTableBindingSource
            // 
            this.accountsTableBindingSource.DataMember = "AccountsTable";
            this.accountsTableBindingSource.DataSource = this.pSDatabase5DataSet;
            // 
            // lbl_accountNumberPrompt
            // 
            this.lbl_accountNumberPrompt.AutoSize = true;
            this.lbl_accountNumberPrompt.Location = new System.Drawing.Point(193, 9);
            this.lbl_accountNumberPrompt.Name = "lbl_accountNumberPrompt";
            this.lbl_accountNumberPrompt.Size = new System.Drawing.Size(106, 30);
            this.lbl_accountNumberPrompt.TabIndex = 64;
            this.lbl_accountNumberPrompt.Text = "شماره حساب :";
            // 
            // cmb_banksName
            // 
            this.cmb_banksName.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.docsTableBindingSource, "bankID", true));
            this.cmb_banksName.DataSource = this.banksTableBindingSource;
            this.cmb_banksName.DisplayMember = "bankName";
            this.cmb_banksName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_banksName.FormattingEnabled = true;
            this.cmb_banksName.Location = new System.Drawing.Point(324, 6);
            this.cmb_banksName.Name = "cmb_banksName";
            this.cmb_banksName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmb_banksName.Size = new System.Drawing.Size(166, 38);
            this.cmb_banksName.TabIndex = 53;
            this.cmb_banksName.ValueMember = "bankID";
            // 
            // banksTableBindingSource
            // 
            this.banksTableBindingSource.DataMember = "BanksTable";
            this.banksTableBindingSource.DataSource = this.pSDatabase5DataSet;
            this.banksTableBindingSource.CurrentChanged += new System.EventHandler(this.banksTableBindingSource_CurrentChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(496, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 30);
            this.label5.TabIndex = 54;
            this.label5.Text = "نام بانک :";
            // 
            // rdu_receiveAnCheque
            // 
            this.rdu_receiveAnCheque.AutoSize = true;
            this.rdu_receiveAnCheque.Font = new System.Drawing.Font("B Titr", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdu_receiveAnCheque.ForeColor = System.Drawing.Color.Indigo;
            this.rdu_receiveAnCheque.Location = new System.Drawing.Point(167, 28);
            this.rdu_receiveAnCheque.Name = "rdu_receiveAnCheque";
            this.rdu_receiveAnCheque.Size = new System.Drawing.Size(131, 37);
            this.rdu_receiveAnCheque.TabIndex = 1;
            this.rdu_receiveAnCheque.Text = "واریز به حساب";
            this.rdu_receiveAnCheque.UseVisualStyleBackColor = true;
            this.rdu_receiveAnCheque.KeyUp += new System.Windows.Forms.KeyEventHandler(this.rdu_receiveAnCheque_KeyUp);
            this.rdu_receiveAnCheque.CheckedChanged += new System.EventHandler(this.rdu_receiveAnCheque_CheckedChanged);
            this.rdu_receiveAnCheque.MouseUp += new System.Windows.Forms.MouseEventHandler(this.rdu_receiveAnCheque_MouseUp);
            // 
            // rdu_issuanceAnCheque
            // 
            this.rdu_issuanceAnCheque.AutoSize = true;
            this.rdu_issuanceAnCheque.Font = new System.Drawing.Font("B Titr", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdu_issuanceAnCheque.ForeColor = System.Drawing.Color.Indigo;
            this.rdu_issuanceAnCheque.Location = new System.Drawing.Point(319, 28);
            this.rdu_issuanceAnCheque.Name = "rdu_issuanceAnCheque";
            this.rdu_issuanceAnCheque.Size = new System.Drawing.Size(148, 37);
            this.rdu_issuanceAnCheque.TabIndex = 0;
            this.rdu_issuanceAnCheque.Text = "برداشت از حساب";
            this.rdu_issuanceAnCheque.UseVisualStyleBackColor = true;
            this.rdu_issuanceAnCheque.KeyUp += new System.Windows.Forms.KeyEventHandler(this.rdu_issuanceAnCheque_KeyUp);
            this.rdu_issuanceAnCheque.CheckedChanged += new System.EventHandler(this.rdu_issuanceAnCheque_CheckedChanged);
            this.rdu_issuanceAnCheque.MouseUp += new System.Windows.Forms.MouseEventHandler(this.rdu_issuanceAnCheque_MouseUp);
            // 
            // lbl_personID
            // 
            this.lbl_personID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_personID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsTableBindingSource, "personID", true));
            this.lbl_personID.Location = new System.Drawing.Point(719, 8);
            this.lbl_personID.Name = "lbl_personID";
            this.lbl_personID.Size = new System.Drawing.Size(72, 30);
            this.lbl_personID.TabIndex = 85;
            this.lbl_personID.TextChanged += new System.EventHandler(this.lbl_personID_TextChanged);
            // 
            // personsTableBindingSource
            // 
            this.personsTableBindingSource.DataMember = "personsTable";
            this.personsTableBindingSource.DataSource = this.pSDatabase5DataSet;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btn_cancel);
            this.panel1.Location = new System.Drawing.Point(28, 453);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(631, 48);
            this.panel1.TabIndex = 74;
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_cancel.Location = new System.Drawing.Point(23, 3);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(213, 41);
            this.btn_cancel.TabIndex = 74;
            this.btn_cancel.Text = "بستن";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // docsTableTableAdapter
            // 
            this.docsTableTableAdapter.ClearBeforeFill = true;
            // 
            // personsTableTableAdapter
            // 
            this.personsTableTableAdapter.ClearBeforeFill = true;
            // 
            // btn_print
            // 
            this.btn_print.BackColor = System.Drawing.Color.Azure;
            this.btn_print.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_print.ForeColor = System.Drawing.Color.DarkViolet;
            this.btn_print.Location = new System.Drawing.Point(114, 75);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(112, 40);
            this.btn_print.TabIndex = 95;
            this.btn_print.Text = "چاپ رسید";
            this.btn_print.UseVisualStyleBackColor = false;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // btn_saveChanges
            // 
            this.btn_saveChanges.BackColor = System.Drawing.Color.Azure;
            this.btn_saveChanges.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_saveChanges.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_saveChanges.Location = new System.Drawing.Point(350, 76);
            this.btn_saveChanges.Name = "btn_saveChanges";
            this.btn_saveChanges.Size = new System.Drawing.Size(112, 39);
            this.btn_saveChanges.TabIndex = 94;
            this.btn_saveChanges.Text = "ثبت سند";
            this.btn_saveChanges.UseVisualStyleBackColor = false;
            this.btn_saveChanges.Click += new System.EventHandler(this.btn_saveChanges_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Azure;
            this.btn_delete.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_delete.Location = new System.Drawing.Point(232, 76);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(112, 39);
            this.btn_delete.TabIndex = 93;
            this.btn_delete.Text = "حذف سند";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_new
            // 
            this.btn_new.BackColor = System.Drawing.Color.Azure;
            this.btn_new.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_new.ForeColor = System.Drawing.Color.Green;
            this.btn_new.Location = new System.Drawing.Point(468, 75);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(112, 40);
            this.btn_new.TabIndex = 92;
            this.btn_new.Text = "* سند جدید";
            this.btn_new.UseVisualStyleBackColor = false;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // pnl_person
            // 
            this.pnl_person.BackColor = System.Drawing.Color.Transparent;
            this.pnl_person.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_person.Controls.Add(this.lbl_currentPosition);
            this.pnl_person.Controls.Add(this.btn_returnPrior);
            this.pnl_person.Controls.Add(this.btn_goNext);
            this.pnl_person.Controls.Add(this.mTbx_Date);
            this.pnl_person.Controls.Add(this.label19);
            this.pnl_person.Controls.Add(this.tbx_ID);
            this.pnl_person.Controls.Add(this.label18);
            this.pnl_person.Location = new System.Drawing.Point(32, 121);
            this.pnl_person.Name = "pnl_person";
            this.pnl_person.Size = new System.Drawing.Size(631, 47);
            this.pnl_person.TabIndex = 97;
            // 
            // lbl_currentPosition
            // 
            this.lbl_currentPosition.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_currentPosition.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_currentPosition.Location = new System.Drawing.Point(319, 6);
            this.lbl_currentPosition.Name = "lbl_currentPosition";
            this.lbl_currentPosition.Size = new System.Drawing.Size(139, 36);
            this.lbl_currentPosition.TabIndex = 100;
            this.lbl_currentPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_returnPrior
            // 
            this.btn_returnPrior.Location = new System.Drawing.Point(463, 7);
            this.btn_returnPrior.Name = "btn_returnPrior";
            this.btn_returnPrior.Size = new System.Drawing.Size(77, 34);
            this.btn_returnPrior.TabIndex = 99;
            this.btn_returnPrior.Text = "قبلی >";
            this.btn_returnPrior.UseVisualStyleBackColor = true;
            this.btn_returnPrior.Click += new System.EventHandler(this.btn_returnPrior_Click);
            // 
            // btn_goNext
            // 
            this.btn_goNext.Location = new System.Drawing.Point(546, 7);
            this.btn_goNext.Name = "btn_goNext";
            this.btn_goNext.Size = new System.Drawing.Size(78, 34);
            this.btn_goNext.TabIndex = 98;
            this.btn_goNext.Text = " < بعدی";
            this.btn_goNext.UseVisualStyleBackColor = true;
            this.btn_goNext.Click += new System.EventHandler(this.btn_goNext_Click);
            // 
            // mTbx_Date
            // 
            this.mTbx_Date.AllowPromptAsInput = false;
            this.mTbx_Date.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.docsTableBindingSource, "dDate", true));
            this.mTbx_Date.Location = new System.Drawing.Point(135, 3);
            this.mTbx_Date.Mask = "0000/00/00";
            this.mTbx_Date.Name = "mTbx_Date";
            this.mTbx_Date.PromptChar = ' ';
            this.mTbx_Date.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mTbx_Date.Size = new System.Drawing.Size(115, 38);
            this.mTbx_Date.TabIndex = 97;
            this.mTbx_Date.Leave += new System.EventHandler(this.mTbx_Date_Leave);
            this.mTbx_Date.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mTbx_Date_KeyUp);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(70, 7);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(59, 30);
            this.label19.TabIndex = 96;
            this.label19.Text = "شماره :";
            // 
            // tbx_ID
            // 
            this.tbx_ID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.docsTableBindingSource, "docID", true));
            this.tbx_ID.Location = new System.Drawing.Point(3, 3);
            this.tbx_ID.Name = "tbx_ID";
            this.tbx_ID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_ID.Size = new System.Drawing.Size(68, 38);
            this.tbx_ID.TabIndex = 95;
            this.tbx_ID.Text = "0";
            this.tbx_ID.TextChanged += new System.EventHandler(this.tbx_ID_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(247, 9);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(56, 30);
            this.label18.TabIndex = 94;
            this.label18.Text = "تاریخ :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Location = new System.Drawing.Point(415, 34);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 30);
            this.label17.TabIndex = 93;
            this.label17.Text = "طرف حساب :";
            // 
            // cmb_familyAndName
            // 
            this.cmb_familyAndName.DataSource = this.personsTableBindingSource;
            this.cmb_familyAndName.DisplayMember = "personFamilyAndName";
            this.cmb_familyAndName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_familyAndName.FormattingEnabled = true;
            this.cmb_familyAndName.Location = new System.Drawing.Point(179, 31);
            this.cmb_familyAndName.MaxDropDownItems = 10;
            this.cmb_familyAndName.Name = "cmb_familyAndName";
            this.cmb_familyAndName.Size = new System.Drawing.Size(230, 38);
            this.cmb_familyAndName.TabIndex = 92;
            this.cmb_familyAndName.ValueMember = "personID";
            this.cmb_familyAndName.SelectedIndexChanged += new System.EventHandler(this.cmb_familyAndName_SelectedIndexChanged);
            this.cmb_familyAndName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_familyAndName_KeyPress_1);
            // 
            // pnl_price
            // 
            this.pnl_price.BackColor = System.Drawing.Color.Transparent;
            this.pnl_price.Controls.Add(this.lbl_priceInChars);
            this.pnl_price.Controls.Add(this.tbx_price);
            this.pnl_price.Controls.Add(this.label1);
            this.pnl_price.Font = new System.Drawing.Font("B Titr", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.pnl_price.Location = new System.Drawing.Point(35, 308);
            this.pnl_price.Name = "pnl_price";
            this.pnl_price.Size = new System.Drawing.Size(631, 97);
            this.pnl_price.TabIndex = 98;
            // 
            // lbl_priceInChars
            // 
            this.lbl_priceInChars.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_priceInChars.ForeColor = System.Drawing.Color.Green;
            this.lbl_priceInChars.Location = new System.Drawing.Point(32, 53);
            this.lbl_priceInChars.Name = "lbl_priceInChars";
            this.lbl_priceInChars.Size = new System.Drawing.Size(549, 33);
            this.lbl_priceInChars.TabIndex = 84;
            this.lbl_priceInChars.Text = "مبلغ :";
            this.lbl_priceInChars.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbx_price
            // 
            this.tbx_price.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.docsTableBindingSource, "price", true));
            this.tbx_price.Font = new System.Drawing.Font("B Nazanin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbx_price.Location = new System.Drawing.Point(32, 9);
            this.tbx_price.Name = "tbx_price";
            this.tbx_price.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_price.Size = new System.Drawing.Size(498, 41);
            this.tbx_price.TabIndex = 80;
            this.tbx_price.Text = "0";
            this.tbx_price.TextChanged += new System.EventHandler(this.tbx_price_TextChanged);
            this.tbx_price.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbx_price_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(536, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 26);
            this.label1.TabIndex = 79;
            this.label1.Text = "مبلغ :";
            // 
            // tbx_event
            // 
            this.tbx_event.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.docsTableBindingSource, "docComment", true));
            this.tbx_event.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbx_event.Location = new System.Drawing.Point(67, 412);
            this.tbx_event.Name = "tbx_event";
            this.tbx_event.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbx_event.Size = new System.Drawing.Size(513, 33);
            this.tbx_event.TabIndex = 84;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(586, 415);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 26);
            this.label2.TabIndex = 84;
            this.label2.Text = "توضیحات :";
            // 
            // banksTableTableAdapter
            // 
            this.banksTableTableAdapter.ClearBeforeFill = true;
            // 
            // accountsTableTableAdapter
            // 
            this.accountsTableTableAdapter.ClearBeforeFill = true;
            // 
            // frm_financialActions
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::cactus_PS_.Properties.Resources.forms_template1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(694, 521);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbx_event);
            this.Controls.Add(this.pnl_price);
            this.Controls.Add(this.pnl_person);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.btn_saveChanges);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.lbl_personID);
            this.Controls.Add(this.cmb_familyAndName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grp_actions);
            this.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_financialActions";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "عــــمــــلیات مـــالــــی";
            this.Load += new System.EventHandler(this.frm_financialActions_Load);
            this.Shown += new System.EventHandler(this.frm_financialActions_Shown);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_financialActions_FormClosing);
            this.grp_actions.ResumeLayout(false);
            this.grp_actions.PerformLayout();
            this.pnl_banks.ResumeLayout(false);
            this.pnl_banks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.docsTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSDatabase5DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banksTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsTableBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnl_person.ResumeLayout(false);
            this.pnl_person.PerformLayout();
            this.pnl_price.ResumeLayout(false);
            this.pnl_price.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_actions;
        private System.Windows.Forms.RadioButton rdu_receiveAnCheque;
        private System.Windows.Forms.RadioButton rdu_issuanceAnCheque;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_cancel;
        private PSDatabase5DataSet pSDatabase5DataSet;
        private System.Windows.Forms.BindingSource docsTableBindingSource;
        private cactus_PS_.PSDatabase5DataSetTableAdapters.docsTableTableAdapter docsTableTableAdapter;
        private System.Windows.Forms.BindingSource personsTableBindingSource;
        private cactus_PS_.PSDatabase5DataSetTableAdapters.personsTableTableAdapter personsTableTableAdapter;
        private System.Windows.Forms.Label lbl_personID;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Button btn_saveChanges;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Panel pnl_person;
        private System.Windows.Forms.Label lbl_currentPosition;
        private System.Windows.Forms.Button btn_returnPrior;
        private System.Windows.Forms.Button btn_goNext;
        private System.Windows.Forms.MaskedTextBox mTbx_Date;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tbx_ID;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cmb_familyAndName;
        private System.Windows.Forms.Panel pnl_price;
        private System.Windows.Forms.TextBox tbx_price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_event;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_priceInChars;
        private System.Windows.Forms.ComboBox cmb_banksName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_accountNumber;
        private System.Windows.Forms.Label lbl_accountNumberPrompt;
        private System.Windows.Forms.BindingSource banksTableBindingSource;
        private cactus_PS_.PSDatabase5DataSetTableAdapters.BanksTableTableAdapter banksTableTableAdapter;
        private System.Windows.Forms.BindingSource accountsTableBindingSource;
        private cactus_PS_.PSDatabase5DataSetTableAdapters.AccountsTableTableAdapter accountsTableTableAdapter;
        private System.Windows.Forms.Panel pnl_banks;
    }
}