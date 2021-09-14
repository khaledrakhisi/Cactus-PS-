namespace cactus_PS_
{
    partial class frm_manageCheques
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
            this.btn_newCheque = new System.Windows.Forms.Button();
            this.btn_deleteCheque = new System.Windows.Forms.Button();
            this.btn_nextCheque = new System.Windows.Forms.Button();
            this.btn_priorCheque = new System.Windows.Forms.Button();
            this.lbl_currentChequePosition = new System.Windows.Forms.Label();
            this.tbx_chequesTotal = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.grp_properties = new System.Windows.Forms.GroupBox();
            this.tbx_account_number = new System.Windows.Forms.TextBox();
            this.chequesTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pSDatabase5DataSet = new cactus_PS_.PSDatabase5DataSet();
            this.pnl_chapterProperties = new System.Windows.Forms.Panel();
            this.tbx_chapterNO = new System.Windows.Forms.TextBox();
            this.accountsTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbx_chapter = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmb_payor = new System.Windows.Forms.ComboBox();
            this.personsTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cmb_receiver = new System.Windows.Forms.ComboBox();
            this.personsTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmb_banksName = new System.Windows.Forms.ComboBox();
            this.banksTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbx_price = new System.Windows.Forms.TextBox();
            this.lbl_senderOrReceiverPrompt = new System.Windows.Forms.Label();
            this.lbl_priceInChars = new System.Windows.Forms.Label();
            this.cmb_accountNumber = new System.Windows.Forms.ComboBox();
            this.lbl_accountNumberPrompt = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_chequeNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mTbx_issuanceDate = new System.Windows.Forms.MaskedTextBox();
            this.mTbx_usanceDate = new System.Windows.Forms.MaskedTextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.accountsTableTableAdapter = new cactus_PS_.PSDatabase5DataSetTableAdapters.AccountsTableTableAdapter();
            this.chequesTableTableAdapter = new cactus_PS_.PSDatabase5DataSetTableAdapters.chequesTableTableAdapter();
            this.btn_saveChanges = new System.Windows.Forms.Button();
            this.banksTableTableAdapter = new cactus_PS_.PSDatabase5DataSetTableAdapters.BanksTableTableAdapter();
            this.lbl_bankID = new System.Windows.Forms.Label();
            this.personsTableTableAdapter = new cactus_PS_.PSDatabase5DataSetTableAdapters.personsTableTableAdapter();
            this.pnl_navigation = new System.Windows.Forms.Panel();
            this.grp_properties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chequesTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSDatabase5DataSet)).BeginInit();
            this.pnl_chapterProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountsTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banksTableBindingSource)).BeginInit();
            this.pnl_navigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_newCheque
            // 
            this.btn_newCheque.BackColor = System.Drawing.Color.Azure;
            this.btn_newCheque.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_newCheque.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_newCheque.Location = new System.Drawing.Point(567, 23);
            this.btn_newCheque.Name = "btn_newCheque";
            this.btn_newCheque.Size = new System.Drawing.Size(80, 35);
            this.btn_newCheque.TabIndex = 0;
            this.btn_newCheque.Text = "* جدید";
            this.btn_newCheque.UseVisualStyleBackColor = false;
            this.btn_newCheque.Click += new System.EventHandler(this.btn_newCheque_Click);
            // 
            // btn_deleteCheque
            // 
            this.btn_deleteCheque.BackColor = System.Drawing.Color.Azure;
            this.btn_deleteCheque.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_deleteCheque.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_deleteCheque.Location = new System.Drawing.Point(481, 23);
            this.btn_deleteCheque.Name = "btn_deleteCheque";
            this.btn_deleteCheque.Size = new System.Drawing.Size(80, 35);
            this.btn_deleteCheque.TabIndex = 1;
            this.btn_deleteCheque.Text = "حذف";
            this.btn_deleteCheque.UseVisualStyleBackColor = false;
            this.btn_deleteCheque.Click += new System.EventHandler(this.btn_deleteCheque_Click);
            // 
            // btn_nextCheque
            // 
            this.btn_nextCheque.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_nextCheque.Location = new System.Drawing.Point(198, 9);
            this.btn_nextCheque.Name = "btn_nextCheque";
            this.btn_nextCheque.Size = new System.Drawing.Size(73, 34);
            this.btn_nextCheque.TabIndex = 0;
            this.btn_nextCheque.Text = "<   بعدی";
            this.btn_nextCheque.UseVisualStyleBackColor = true;
            this.btn_nextCheque.Click += new System.EventHandler(this.btn_nextCheque_Click);
            // 
            // btn_priorCheque
            // 
            this.btn_priorCheque.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_priorCheque.Location = new System.Drawing.Point(116, 8);
            this.btn_priorCheque.Name = "btn_priorCheque";
            this.btn_priorCheque.Size = new System.Drawing.Size(73, 35);
            this.btn_priorCheque.TabIndex = 1;
            this.btn_priorCheque.Text = "قبلی  >";
            this.btn_priorCheque.UseVisualStyleBackColor = true;
            this.btn_priorCheque.Click += new System.EventHandler(this.btn_priorCheque_Click);
            // 
            // lbl_currentChequePosition
            // 
            this.lbl_currentChequePosition.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_currentChequePosition.Font = new System.Drawing.Font("B Zar", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_currentChequePosition.ForeColor = System.Drawing.Color.Black;
            this.lbl_currentChequePosition.Location = new System.Drawing.Point(12, 9);
            this.lbl_currentChequePosition.Name = "lbl_currentChequePosition";
            this.lbl_currentChequePosition.Size = new System.Drawing.Size(98, 34);
            this.lbl_currentChequePosition.TabIndex = 11;
            // 
            // tbx_chequesTotal
            // 
            this.tbx_chequesTotal.Location = new System.Drawing.Point(206, 328);
            this.tbx_chequesTotal.Name = "tbx_chequesTotal";
            this.tbx_chequesTotal.ReadOnly = true;
            this.tbx_chequesTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_chequesTotal.Size = new System.Drawing.Size(198, 38);
            this.tbx_chequesTotal.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label12.Location = new System.Drawing.Point(410, 334);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 26);
            this.label12.TabIndex = 27;
            this.label12.Text = "جمع مبالغ چک ها :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label13.Location = new System.Drawing.Point(164, 334);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 26);
            this.label13.TabIndex = 28;
            this.label13.Text = "ريال";
            // 
            // grp_properties
            // 
            this.grp_properties.BackColor = System.Drawing.Color.Transparent;
            this.grp_properties.Controls.Add(this.tbx_account_number);
            this.grp_properties.Controls.Add(this.pnl_chapterProperties);
            this.grp_properties.Controls.Add(this.cmb_payor);
            this.grp_properties.Controls.Add(this.cmb_receiver);
            this.grp_properties.Controls.Add(this.cmb_banksName);
            this.grp_properties.Controls.Add(this.tbx_price);
            this.grp_properties.Controls.Add(this.lbl_senderOrReceiverPrompt);
            this.grp_properties.Controls.Add(this.lbl_priceInChars);
            this.grp_properties.Controls.Add(this.cmb_accountNumber);
            this.grp_properties.Controls.Add(this.lbl_accountNumberPrompt);
            this.grp_properties.Controls.Add(this.label8);
            this.grp_properties.Controls.Add(this.label7);
            this.grp_properties.Controls.Add(this.label6);
            this.grp_properties.Controls.Add(this.label5);
            this.grp_properties.Controls.Add(this.label3);
            this.grp_properties.Controls.Add(this.tbx_chequeNumber);
            this.grp_properties.Controls.Add(this.label2);
            this.grp_properties.Controls.Add(this.label1);
            this.grp_properties.Controls.Add(this.mTbx_issuanceDate);
            this.grp_properties.Controls.Add(this.mTbx_usanceDate);
            this.grp_properties.Enabled = false;
            this.grp_properties.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.grp_properties.Location = new System.Drawing.Point(31, 60);
            this.grp_properties.Name = "grp_properties";
            this.grp_properties.Size = new System.Drawing.Size(639, 258);
            this.grp_properties.TabIndex = 4;
            this.grp_properties.TabStop = false;
            this.grp_properties.Text = "مشخصات چک";
            // 
            // tbx_account_number
            // 
            this.tbx_account_number.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.chequesTableBindingSource, "isTo", true));
            this.tbx_account_number.Location = new System.Drawing.Point(359, 201);
            this.tbx_account_number.Name = "tbx_account_number";
            this.tbx_account_number.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_account_number.Size = new System.Drawing.Size(166, 33);
            this.tbx_account_number.TabIndex = 7;
            // 
            // chequesTableBindingSource
            // 
            this.chequesTableBindingSource.DataMember = "chequesTable";
            this.chequesTableBindingSource.DataSource = this.pSDatabase5DataSet;
            // 
            // pSDatabase5DataSet
            // 
            this.pSDatabase5DataSet.DataSetName = "PSDatabase5DataSet";
            this.pSDatabase5DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pnl_chapterProperties
            // 
            this.pnl_chapterProperties.Controls.Add(this.tbx_chapterNO);
            this.pnl_chapterProperties.Controls.Add(this.tbx_chapter);
            this.pnl_chapterProperties.Controls.Add(this.label10);
            this.pnl_chapterProperties.Controls.Add(this.label9);
            this.pnl_chapterProperties.Location = new System.Drawing.Point(15, 191);
            this.pnl_chapterProperties.Name = "pnl_chapterProperties";
            this.pnl_chapterProperties.Size = new System.Drawing.Size(321, 52);
            this.pnl_chapterProperties.TabIndex = 9;
            // 
            // tbx_chapterNO
            // 
            this.tbx_chapterNO.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountsTableBindingSource, "account_chapterNo", true));
            this.tbx_chapterNO.Location = new System.Drawing.Point(9, 10);
            this.tbx_chapterNO.Name = "tbx_chapterNO";
            this.tbx_chapterNO.ReadOnly = true;
            this.tbx_chapterNO.Size = new System.Drawing.Size(65, 33);
            this.tbx_chapterNO.TabIndex = 1;
            // 
            // accountsTableBindingSource
            // 
            this.accountsTableBindingSource.DataMember = "AccountsTable";
            this.accountsTableBindingSource.DataSource = this.pSDatabase5DataSet;
            // 
            // tbx_chapter
            // 
            this.tbx_chapter.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountsTableBindingSource, "account_chapterName", true));
            this.tbx_chapter.Location = new System.Drawing.Point(161, 10);
            this.tbx_chapter.Name = "tbx_chapter";
            this.tbx_chapter.ReadOnly = true;
            this.tbx_chapter.Size = new System.Drawing.Size(79, 33);
            this.tbx_chapter.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(80, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 26);
            this.label10.TabIndex = 60;
            this.label10.Text = "کد شعبه :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(268, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 26);
            this.label9.TabIndex = 58;
            this.label9.Text = "شعبه :";
            // 
            // cmb_payor
            // 
            this.cmb_payor.DataSource = this.personsTableBindingSource1;
            this.cmb_payor.DisplayMember = "personFamilyAndName";
            this.cmb_payor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_payor.Enabled = false;
            this.cmb_payor.FormattingEnabled = true;
            this.cmb_payor.Location = new System.Drawing.Point(24, 150);
            this.cmb_payor.Name = "cmb_payor";
            this.cmb_payor.Size = new System.Drawing.Size(231, 34);
            this.cmb_payor.TabIndex = 6;
            this.cmb_payor.ValueMember = "personID";
            // 
            // personsTableBindingSource1
            // 
            this.personsTableBindingSource1.DataMember = "personsTable";
            this.personsTableBindingSource1.DataSource = this.pSDatabase5DataSet;
            // 
            // cmb_receiver
            // 
            this.cmb_receiver.DataSource = this.personsTableBindingSource;
            this.cmb_receiver.DisplayMember = "personFamilyAndName";
            this.cmb_receiver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_receiver.Enabled = false;
            this.cmb_receiver.FormattingEnabled = true;
            this.cmb_receiver.Location = new System.Drawing.Point(303, 64);
            this.cmb_receiver.Name = "cmb_receiver";
            this.cmb_receiver.Size = new System.Drawing.Size(222, 34);
            this.cmb_receiver.TabIndex = 3;
            this.cmb_receiver.ValueMember = "personID";
            // 
            // personsTableBindingSource
            // 
            this.personsTableBindingSource.DataMember = "personsTable";
            this.personsTableBindingSource.DataSource = this.pSDatabase5DataSet;
            // 
            // cmb_banksName
            // 
            this.cmb_banksName.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.chequesTableBindingSource, "bankID", true));
            this.cmb_banksName.DataSource = this.banksTableBindingSource;
            this.cmb_banksName.DisplayMember = "bankName";
            this.cmb_banksName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_banksName.FormattingEnabled = true;
            this.cmb_banksName.Location = new System.Drawing.Point(359, 150);
            this.cmb_banksName.Name = "cmb_banksName";
            this.cmb_banksName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmb_banksName.Size = new System.Drawing.Size(166, 34);
            this.cmb_banksName.TabIndex = 5;
            this.cmb_banksName.ValueMember = "bankID";
            this.cmb_banksName.SelectedIndexChanged += new System.EventHandler(this.cmb_banksName_SelectedIndexChanged);
            this.cmb_banksName.SelectedValueChanged += new System.EventHandler(this.cmb_banksName_SelectedValueChanged);
            this.cmb_banksName.Click += new System.EventHandler(this.cmb_banksName_Click);
            // 
            // banksTableBindingSource
            // 
            this.banksTableBindingSource.DataMember = "BanksTable";
            this.banksTableBindingSource.DataSource = this.pSDatabase5DataSet;
            // 
            // tbx_price
            // 
            this.tbx_price.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.chequesTableBindingSource, "chequePrice", true));
            this.tbx_price.Location = new System.Drawing.Point(13, 64);
            this.tbx_price.Name = "tbx_price";
            this.tbx_price.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_price.Size = new System.Drawing.Size(233, 33);
            this.tbx_price.TabIndex = 4;
            this.tbx_price.Text = "0";
            this.tbx_price.TextChanged += new System.EventHandler(this.tbx_price_TextChanged);
            this.tbx_price.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbx_price_KeyUp);
            // 
            // lbl_senderOrReceiverPrompt
            // 
            this.lbl_senderOrReceiverPrompt.AutoSize = true;
            this.lbl_senderOrReceiverPrompt.Location = new System.Drawing.Point(256, 153);
            this.lbl_senderOrReceiverPrompt.Name = "lbl_senderOrReceiverPrompt";
            this.lbl_senderOrReceiverPrompt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_senderOrReceiverPrompt.Size = new System.Drawing.Size(97, 26);
            this.lbl_senderOrReceiverPrompt.TabIndex = 65;
            this.lbl_senderOrReceiverPrompt.Text = "پرداخت کننده :";
            // 
            // lbl_priceInChars
            // 
            this.lbl_priceInChars.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_priceInChars.Font = new System.Drawing.Font("B Zar", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_priceInChars.ForeColor = System.Drawing.Color.Brown;
            this.lbl_priceInChars.Location = new System.Drawing.Point(13, 101);
            this.lbl_priceInChars.Name = "lbl_priceInChars";
            this.lbl_priceInChars.Size = new System.Drawing.Size(512, 35);
            this.lbl_priceInChars.TabIndex = 32;
            this.lbl_priceInChars.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_accountNumber
            // 
            this.cmb_accountNumber.DataSource = this.accountsTableBindingSource;
            this.cmb_accountNumber.DisplayMember = "account_number";
            this.cmb_accountNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_accountNumber.FormattingEnabled = true;
            this.cmb_accountNumber.Location = new System.Drawing.Point(359, 202);
            this.cmb_accountNumber.Name = "cmb_accountNumber";
            this.cmb_accountNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmb_accountNumber.Size = new System.Drawing.Size(166, 34);
            this.cmb_accountNumber.TabIndex = 8;
            this.cmb_accountNumber.ValueMember = "accountID";
            // 
            // lbl_accountNumberPrompt
            // 
            this.lbl_accountNumberPrompt.AutoSize = true;
            this.lbl_accountNumberPrompt.Location = new System.Drawing.Point(529, 205);
            this.lbl_accountNumberPrompt.Name = "lbl_accountNumberPrompt";
            this.lbl_accountNumberPrompt.Size = new System.Drawing.Size(92, 26);
            this.lbl_accountNumberPrompt.TabIndex = 62;
            this.lbl_accountNumberPrompt.Text = "شماره حساب :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(547, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 26);
            this.label8.TabIndex = 57;
            this.label8.Text = "در وجه :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(531, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 26);
            this.label7.TabIndex = 55;
            this.label7.Text = "مبلغ به حروف :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(252, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 26);
            this.label6.TabIndex = 53;
            this.label6.Text = "مبلغ :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(531, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 26);
            this.label5.TabIndex = 52;
            this.label5.Text = "نام بانک :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(119, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 26);
            this.label3.TabIndex = 50;
            this.label3.Text = "شماره چک:";
            // 
            // tbx_chequeNumber
            // 
            this.tbx_chequeNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.chequesTableBindingSource, "chequeNumber", true));
            this.tbx_chequeNumber.Location = new System.Drawing.Point(13, 21);
            this.tbx_chequeNumber.Name = "tbx_chequeNumber";
            this.tbx_chequeNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_chequeNumber.Size = new System.Drawing.Size(100, 33);
            this.tbx_chequeNumber.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 26);
            this.label2.TabIndex = 48;
            this.label2.Text = "تاریخ سررسید :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(531, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 26);
            this.label1.TabIndex = 47;
            this.label1.Text = "تاریخ صدور :";
            // 
            // mTbx_issuanceDate
            // 
            this.mTbx_issuanceDate.AllowPromptAsInput = false;
            this.mTbx_issuanceDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.chequesTableBindingSource, "issuanceDate", true));
            this.mTbx_issuanceDate.Location = new System.Drawing.Point(424, 22);
            this.mTbx_issuanceDate.Mask = "0000/00/00";
            this.mTbx_issuanceDate.Name = "mTbx_issuanceDate";
            this.mTbx_issuanceDate.PromptChar = ' ';
            this.mTbx_issuanceDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mTbx_issuanceDate.Size = new System.Drawing.Size(101, 33);
            this.mTbx_issuanceDate.TabIndex = 0;
            this.mTbx_issuanceDate.Leave += new System.EventHandler(this.mTbx_issuanceDate_Leave);
            this.mTbx_issuanceDate.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mTbx_issuanceDate_KeyUp);
            // 
            // mTbx_usanceDate
            // 
            this.mTbx_usanceDate.AllowPromptAsInput = false;
            this.mTbx_usanceDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.chequesTableBindingSource, "usanceDate", true));
            this.mTbx_usanceDate.Location = new System.Drawing.Point(209, 23);
            this.mTbx_usanceDate.Mask = "0000/00/00";
            this.mTbx_usanceDate.Name = "mTbx_usanceDate";
            this.mTbx_usanceDate.PromptChar = ' ';
            this.mTbx_usanceDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mTbx_usanceDate.Size = new System.Drawing.Size(101, 33);
            this.mTbx_usanceDate.TabIndex = 1;
            this.mTbx_usanceDate.Leave += new System.EventHandler(this.mTbx_usanceDate_Leave);
            this.mTbx_usanceDate.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mTbx_usanceDate_KeyUp);
            // 
            // btn_ok
            // 
            this.btn_ok.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_ok.Location = new System.Drawing.Point(215, 387);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(433, 38);
            this.btn_ok.TabIndex = 6;
            this.btn_ok.Text = "تائیـــــــد";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_cancel.Image = global::cactus_PS_.Properties.Resources.OOFL;
            this.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cancel.Location = new System.Drawing.Point(43, 386);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(159, 41);
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "لغو";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.button6_Click);
            // 
            // accountsTableTableAdapter
            // 
            this.accountsTableTableAdapter.ClearBeforeFill = true;
            // 
            // chequesTableTableAdapter
            // 
            this.chequesTableTableAdapter.ClearBeforeFill = true;
            // 
            // btn_saveChanges
            // 
            this.btn_saveChanges.BackColor = System.Drawing.Color.Azure;
            this.btn_saveChanges.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_saveChanges.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_saveChanges.Location = new System.Drawing.Point(347, 24);
            this.btn_saveChanges.Name = "btn_saveChanges";
            this.btn_saveChanges.Size = new System.Drawing.Size(128, 34);
            this.btn_saveChanges.TabIndex = 2;
            this.btn_saveChanges.Text = "اصلاح مشخصات";
            this.btn_saveChanges.UseVisualStyleBackColor = false;
            this.btn_saveChanges.Click += new System.EventHandler(this.btn_saveChanges_Click);
            // 
            // banksTableTableAdapter
            // 
            this.banksTableTableAdapter.ClearBeforeFill = true;
            // 
            // lbl_bankID
            // 
            this.lbl_bankID.AutoSize = true;
            this.lbl_bankID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.banksTableBindingSource, "bankID", true));
            this.lbl_bankID.ForeColor = System.Drawing.Color.Black;
            this.lbl_bankID.Location = new System.Drawing.Point(784, 196);
            this.lbl_bankID.Name = "lbl_bankID";
            this.lbl_bankID.Size = new System.Drawing.Size(49, 30);
            this.lbl_bankID.TabIndex = 70;
            this.lbl_bankID.Text = "----";
            this.lbl_bankID.TextChanged += new System.EventHandler(this.lbl_bankID_TextChanged);
            // 
            // personsTableTableAdapter
            // 
            this.personsTableTableAdapter.ClearBeforeFill = true;
            // 
            // pnl_navigation
            // 
            this.pnl_navigation.BackColor = System.Drawing.Color.Transparent;
            this.pnl_navigation.Controls.Add(this.lbl_currentChequePosition);
            this.pnl_navigation.Controls.Add(this.btn_priorCheque);
            this.pnl_navigation.Controls.Add(this.btn_nextCheque);
            this.pnl_navigation.Location = new System.Drawing.Point(31, 12);
            this.pnl_navigation.Name = "pnl_navigation";
            this.pnl_navigation.Size = new System.Drawing.Size(287, 57);
            this.pnl_navigation.TabIndex = 3;
            // 
            // frm_manageCheques
            // 
            this.AcceptButton = this.btn_ok;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::cactus_PS_.Properties.Resources.forms_template;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(698, 449);
            this.Controls.Add(this.pnl_navigation);
            this.Controls.Add(this.lbl_bankID);
            this.Controls.Add(this.btn_saveChanges);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.grp_properties);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbx_chequesTotal);
            this.Controls.Add(this.btn_deleteCheque);
            this.Controls.Add(this.btn_newCheque);
            this.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_manageCheques";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "چـــــــــــــــــــــک ...";
            this.Load += new System.EventHandler(this.frm_manageCheques_Load);
            this.Shown += new System.EventHandler(this.frm_manageCheques_Shown);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_manageCheques_FormClosing);
            this.grp_properties.ResumeLayout(false);
            this.grp_properties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chequesTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSDatabase5DataSet)).EndInit();
            this.pnl_chapterProperties.ResumeLayout(false);
            this.pnl_chapterProperties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountsTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banksTableBindingSource)).EndInit();
            this.pnl_navigation.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_newCheque;
        private System.Windows.Forms.Button btn_deleteCheque;
        private System.Windows.Forms.Button btn_nextCheque;
        private System.Windows.Forms.Button btn_priorCheque;
        private System.Windows.Forms.Label lbl_currentChequePosition;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox grp_properties;
        private System.Windows.Forms.ComboBox cmb_accountNumber;
        private System.Windows.Forms.Label lbl_accountNumberPrompt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_chequeNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mTbx_issuanceDate;
        private System.Windows.Forms.MaskedTextBox mTbx_usanceDate;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lbl_priceInChars;
        private PSDatabase5DataSet pSDatabase5DataSet;
        private System.Windows.Forms.BindingSource accountsTableBindingSource;
        private cactus_PS_.PSDatabase5DataSetTableAdapters.AccountsTableTableAdapter accountsTableTableAdapter;
        private System.Windows.Forms.BindingSource chequesTableBindingSource;
        private cactus_PS_.PSDatabase5DataSetTableAdapters.chequesTableTableAdapter chequesTableTableAdapter;
        private System.Windows.Forms.Label lbl_senderOrReceiverPrompt;
        private System.Windows.Forms.Button btn_saveChanges;
        private System.Windows.Forms.TextBox tbx_price;
        public System.Windows.Forms.TextBox tbx_chequesTotal;
        private System.Windows.Forms.ComboBox cmb_banksName;
        private System.Windows.Forms.BindingSource banksTableBindingSource;
        private cactus_PS_.PSDatabase5DataSetTableAdapters.BanksTableTableAdapter banksTableTableAdapter;
        private System.Windows.Forms.TextBox tbx_chapterNO;
        private System.Windows.Forms.TextBox tbx_chapter;
        private System.Windows.Forms.Label lbl_bankID;
        private System.Windows.Forms.ComboBox cmb_receiver;
        private System.Windows.Forms.BindingSource personsTableBindingSource;
        private cactus_PS_.PSDatabase5DataSetTableAdapters.personsTableTableAdapter personsTableTableAdapter;
        private System.Windows.Forms.ComboBox cmb_payor;
        private System.Windows.Forms.BindingSource personsTableBindingSource1;
        private System.Windows.Forms.Panel pnl_chapterProperties;
        private System.Windows.Forms.TextBox tbx_account_number;
        private System.Windows.Forms.Panel pnl_navigation;
    }
}