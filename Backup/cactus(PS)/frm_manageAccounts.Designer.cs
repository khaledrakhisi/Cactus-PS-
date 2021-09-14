namespace cactus_PS_
{
    partial class frm_manageAccounts
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
            this.banksTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pSDatabase5DataSet = new cactus_PS_.PSDatabase5DataSet();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmb_accountTypes_Title = new System.Windows.Forms.ComboBox();
            this.accountsTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountTypesTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.tbx_chapterNO = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmb_bankName = new System.Windows.Forms.ComboBox();
            this.tbx_chapterName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbx_account_amount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_accounts = new System.Windows.Forms.ComboBox();
            this.btn_deleteAccount = new System.Windows.Forms.Button();
            this.btn_saveAccountChanges = new System.Windows.Forms.Button();
            this.btn_modifyAccount = new System.Windows.Forms.Button();
            this.btn_defineNewAccount = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.banksTableTableAdapter = new cactus_PS_.PSDatabase5DataSetTableAdapters.BanksTableTableAdapter();
            this.accountsTableTableAdapter = new cactus_PS_.PSDatabase5DataSetTableAdapters.AccountsTableTableAdapter();
            this.accountTypesTableTableAdapter = new cactus_PS_.PSDatabase5DataSetTableAdapters.accountTypesTableTableAdapter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.banksTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSDatabase5DataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountsTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountTypesTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // banksTableBindingSource
            // 
            this.banksTableBindingSource.DataMember = "BanksTable";
            this.banksTableBindingSource.DataSource = this.pSDatabase5DataSet;
            // 
            // pSDatabase5DataSet
            // 
            this.pSDatabase5DataSet.DataSetName = "PSDatabase5DataSet";
            this.pSDatabase5DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.cmb_accountTypes_Title);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.tbx_chapterNO);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cmb_bankName);
            this.groupBox2.Controls.Add(this.tbx_chapterName);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tbx_account_amount);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(31, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(596, 136);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "مشخصات حساب";
            // 
            // cmb_accountTypes_Title
            // 
            this.cmb_accountTypes_Title.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.accountsTableBindingSource, "accountType_id", true));
            this.cmb_accountTypes_Title.DataSource = this.accountTypesTableBindingSource;
            this.cmb_accountTypes_Title.DisplayMember = "accountType_Title";
            this.cmb_accountTypes_Title.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_accountTypes_Title.Enabled = false;
            this.cmb_accountTypes_Title.FormattingEnabled = true;
            this.cmb_accountTypes_Title.Location = new System.Drawing.Point(19, 82);
            this.cmb_accountTypes_Title.Name = "cmb_accountTypes_Title";
            this.cmb_accountTypes_Title.Size = new System.Drawing.Size(107, 34);
            this.cmb_accountTypes_Title.TabIndex = 4;
            this.cmb_accountTypes_Title.ValueMember = "accountType_id";
            // 
            // accountsTableBindingSource
            // 
            this.accountsTableBindingSource.DataMember = "AccountsTable";
            this.accountsTableBindingSource.DataSource = this.pSDatabase5DataSet;
            // 
            // accountTypesTableBindingSource
            // 
            this.accountTypesTableBindingSource.DataMember = "accountTypesTable";
            this.accountTypesTableBindingSource.DataSource = this.pSDatabase5DataSet;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(132, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 26);
            this.label11.TabIndex = 19;
            this.label11.Text = "نوع حساب :";
            // 
            // tbx_chapterNO
            // 
            this.tbx_chapterNO.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountsTableBindingSource, "account_chapterNo", true));
            this.tbx_chapterNO.Location = new System.Drawing.Point(214, 82);
            this.tbx_chapterNO.Name = "tbx_chapterNO";
            this.tbx_chapterNO.ReadOnly = true;
            this.tbx_chapterNO.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_chapterNO.Size = new System.Drawing.Size(82, 33);
            this.tbx_chapterNO.TabIndex = 3;
            this.tbx_chapterNO.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbx_chapterNO_KeyDown);
            this.tbx_chapterNO.Enter += new System.EventHandler(this.tbx_chapterNO_Enter);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(301, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 26);
            this.label10.TabIndex = 17;
            this.label10.Text = "شماره شعبه :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(532, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 26);
            this.label9.TabIndex = 15;
            this.label9.Text = "بانک :";
            // 
            // cmb_bankName
            // 
            this.cmb_bankName.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.accountsTableBindingSource, "bankID", true));
            this.cmb_bankName.DataSource = this.banksTableBindingSource;
            this.cmb_bankName.DisplayMember = "bankName";
            this.cmb_bankName.Enabled = false;
            this.cmb_bankName.FormattingEnabled = true;
            this.cmb_bankName.Location = new System.Drawing.Point(333, 28);
            this.cmb_bankName.Name = "cmb_bankName";
            this.cmb_bankName.Size = new System.Drawing.Size(193, 34);
            this.cmb_bankName.TabIndex = 0;
            this.cmb_bankName.ValueMember = "bankID";
            this.cmb_bankName.Leave += new System.EventHandler(this.cmb_bankName_Leave);
            this.cmb_bankName.Enter += new System.EventHandler(this.cmb_bankName_Enter);
            this.cmb_bankName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb_bankName_KeyDown);
            // 
            // tbx_chapterName
            // 
            this.tbx_chapterName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountsTableBindingSource, "account_chapterName", true));
            this.tbx_chapterName.Location = new System.Drawing.Point(391, 82);
            this.tbx_chapterName.Name = "tbx_chapterName";
            this.tbx_chapterName.ReadOnly = true;
            this.tbx_chapterName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbx_chapterName.Size = new System.Drawing.Size(114, 33);
            this.tbx_chapterName.TabIndex = 2;
            this.tbx_chapterName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbx_chapterName_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(510, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 26);
            this.label8.TabIndex = 13;
            this.label8.Text = "نام شعبه :";
            // 
            // tbx_account_amount
            // 
            this.tbx_account_amount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountsTableBindingSource, "account_amount", true));
            this.tbx_account_amount.Enabled = false;
            this.tbx_account_amount.Location = new System.Drawing.Point(20, 29);
            this.tbx_account_amount.Name = "tbx_account_amount";
            this.tbx_account_amount.ReadOnly = true;
            this.tbx_account_amount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_account_amount.Size = new System.Drawing.Size(165, 33);
            this.tbx_account_amount.TabIndex = 1;
            this.tbx_account_amount.TextChanged += new System.EventHandler(this.tbx_account_amount_TextChanged);
            this.tbx_account_amount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbx_account_amount_KeyDown);
            this.tbx_account_amount.Enter += new System.EventHandler(this.tbx_account_amount_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(192, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 26);
            this.label5.TabIndex = 11;
            this.label5.Text = "موجودی اولیه حساب :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(283, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "شماره حساب :";
            // 
            // cmb_accounts
            // 
            this.cmb_accounts.DataSource = this.accountsTableBindingSource;
            this.cmb_accounts.DisplayMember = "account_number";
            this.cmb_accounts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_accounts.FormattingEnabled = true;
            this.cmb_accounts.Location = new System.Drawing.Point(189, 47);
            this.cmb_accounts.Name = "cmb_accounts";
            this.cmb_accounts.Size = new System.Drawing.Size(280, 34);
            this.cmb_accounts.TabIndex = 0;
            this.cmb_accounts.ValueMember = "accountID";
            // 
            // btn_deleteAccount
            // 
            this.btn_deleteAccount.BackColor = System.Drawing.Color.Azure;
            this.btn_deleteAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_deleteAccount.Location = new System.Drawing.Point(63, 90);
            this.btn_deleteAccount.Name = "btn_deleteAccount";
            this.btn_deleteAccount.Size = new System.Drawing.Size(119, 34);
            this.btn_deleteAccount.TabIndex = 4;
            this.btn_deleteAccount.Text = "حذف حساب";
            this.btn_deleteAccount.UseVisualStyleBackColor = false;
            this.btn_deleteAccount.Click += new System.EventHandler(this.btn_deleteAccount_Click);
            // 
            // btn_saveAccountChanges
            // 
            this.btn_saveAccountChanges.BackColor = System.Drawing.Color.Azure;
            this.btn_saveAccountChanges.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_saveAccountChanges.Location = new System.Drawing.Point(187, 90);
            this.btn_saveAccountChanges.Name = "btn_saveAccountChanges";
            this.btn_saveAccountChanges.Size = new System.Drawing.Size(127, 34);
            this.btn_saveAccountChanges.TabIndex = 3;
            this.btn_saveAccountChanges.Text = "اصلاح مشخصات";
            this.btn_saveAccountChanges.UseVisualStyleBackColor = false;
            this.btn_saveAccountChanges.Click += new System.EventHandler(this.btn_saveAccountChanges_Click);
            // 
            // btn_modifyAccount
            // 
            this.btn_modifyAccount.BackColor = System.Drawing.Color.Azure;
            this.btn_modifyAccount.Location = new System.Drawing.Point(319, 90);
            this.btn_modifyAccount.Name = "btn_modifyAccount";
            this.btn_modifyAccount.Size = new System.Drawing.Size(136, 34);
            this.btn_modifyAccount.TabIndex = 2;
            this.btn_modifyAccount.Text = "اصلاح شماره حساب";
            this.btn_modifyAccount.UseVisualStyleBackColor = false;
            this.btn_modifyAccount.Click += new System.EventHandler(this.btn_modifyAccount_Click);
            // 
            // btn_defineNewAccount
            // 
            this.btn_defineNewAccount.BackColor = System.Drawing.Color.Azure;
            this.btn_defineNewAccount.ForeColor = System.Drawing.Color.Green;
            this.btn_defineNewAccount.Location = new System.Drawing.Point(460, 90);
            this.btn_defineNewAccount.Name = "btn_defineNewAccount";
            this.btn_defineNewAccount.Size = new System.Drawing.Size(136, 34);
            this.btn_defineNewAccount.TabIndex = 1;
            this.btn_defineNewAccount.Text = "* حساب جدید";
            this.btn_defineNewAccount.UseVisualStyleBackColor = false;
            this.btn_defineNewAccount.Click += new System.EventHandler(this.btn_defineNewAccount_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_ok.Location = new System.Drawing.Point(160, 277);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(446, 40);
            this.btn_ok.TabIndex = 6;
            this.btn_ok.Text = "تائــــــید";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_cancel.Image = global::cactus_PS_.Properties.Resources.OOFL;
            this.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cancel.Location = new System.Drawing.Point(52, 277);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(102, 40);
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "بستن";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // banksTableTableAdapter
            // 
            this.banksTableTableAdapter.ClearBeforeFill = true;
            // 
            // accountsTableTableAdapter
            // 
            this.accountsTableTableAdapter.ClearBeforeFill = true;
            // 
            // accountTypesTableTableAdapter
            // 
            this.accountTypesTableTableAdapter.ClearBeforeFill = true;
            // 
            // frm_manageAccounts
            // 
            this.AcceptButton = this.btn_defineNewAccount;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::cactus_PS_.Properties.Resources.forms_template;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(659, 333);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_deleteAccount);
            this.Controls.Add(this.btn_defineNewAccount);
            this.Controls.Add(this.btn_modifyAccount);
            this.Controls.Add(this.btn_saveAccountChanges);
            this.Controls.Add(this.cmb_accounts);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_manageAccounts";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "حساب های بانکی";
            this.Load += new System.EventHandler(this.frm_manageAccounts_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_manageAccounts_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.banksTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSDatabase5DataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountsTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountTypesTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PSDatabase5DataSet pSDatabase5DataSet;
        private System.Windows.Forms.BindingSource banksTableBindingSource;
        private cactus_PS_.PSDatabase5DataSetTableAdapters.BanksTableTableAdapter banksTableTableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_accounts;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_modifyAccount;
        private System.Windows.Forms.Button btn_defineNewAccount;
        private System.Windows.Forms.BindingSource accountsTableBindingSource;
        private cactus_PS_.PSDatabase5DataSetTableAdapters.AccountsTableTableAdapter accountsTableTableAdapter;
        private System.Windows.Forms.TextBox tbx_account_amount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_saveAccountChanges;
        private System.Windows.Forms.Button btn_deleteAccount;
        private System.Windows.Forms.TextBox tbx_chapterName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmb_bankName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbx_chapterNO;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmb_accountTypes_Title;
        private System.Windows.Forms.BindingSource accountTypesTableBindingSource;
        private cactus_PS_.PSDatabase5DataSetTableAdapters.accountTypesTableTableAdapter accountTypesTableTableAdapter;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}