namespace cactus_PS_
{
    partial class frm_balance
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
            this.rdu_fourColumnsBalance = new System.Windows.Forms.RadioButton();
            this.rdu_TwoColumnsBalance = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnl_betweenIDs = new System.Windows.Forms.Panel();
            this.tbx_toID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_fromID = new System.Windows.Forms.TextBox();
            this.pnl_betweenDates = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.mTbx_fromDate = new System.Windows.Forms.MaskedTextBox();
            this.mTbx_toDate = new System.Windows.Forms.MaskedTextBox();
            this.mTbx_tilDate = new System.Windows.Forms.MaskedTextBox();
            this.rdu_showBetweenAccDoc_ids = new System.Windows.Forms.RadioButton();
            this.rdu_showBetweenDates = new System.Windows.Forms.RadioButton();
            this.rdu_showInDate = new System.Windows.Forms.RadioButton();
            this.rdu_onlyShowDetailBalance = new System.Windows.Forms.RadioButton();
            this.rdu_onlyShowLedgerBalance = new System.Windows.Forms.RadioButton();
            this.chk_ledger = new System.Windows.Forms.CheckBox();
            this.cmb_masterSpentName = new System.Windows.Forms.ComboBox();
            this.spentMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pSDatabase5DataSet = new cactus_PS_.PSDatabase5DataSet();
            this.pnl_showDetailBalance = new System.Windows.Forms.Panel();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.pnl_ledgerSelection = new System.Windows.Forms.Panel();
            this.spentMasterTableAdapter = new cactus_PS_.PSDatabase5DataSetTableAdapters.spentMasterTableAdapter();
            this.groupBox1.SuspendLayout();
            this.pnl_betweenIDs.SuspendLayout();
            this.pnl_betweenDates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spentMasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSDatabase5DataSet)).BeginInit();
            this.pnl_showDetailBalance.SuspendLayout();
            this.pnl_ledgerSelection.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdu_fourColumnsBalance
            // 
            this.rdu_fourColumnsBalance.AutoSize = true;
            this.rdu_fourColumnsBalance.BackColor = System.Drawing.Color.Transparent;
            this.rdu_fourColumnsBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdu_fourColumnsBalance.ForeColor = System.Drawing.Color.Red;
            this.rdu_fourColumnsBalance.Location = new System.Drawing.Point(90, 30);
            this.rdu_fourColumnsBalance.Name = "rdu_fourColumnsBalance";
            this.rdu_fourColumnsBalance.Size = new System.Drawing.Size(124, 29);
            this.rdu_fourColumnsBalance.TabIndex = 4;
            this.rdu_fourColumnsBalance.Text = "چهار ستونی";
            this.rdu_fourColumnsBalance.UseVisualStyleBackColor = false;
            this.rdu_fourColumnsBalance.CheckedChanged += new System.EventHandler(this.rdu_fourColumnsBalance_CheckedChanged);
            // 
            // rdu_TwoColumnsBalance
            // 
            this.rdu_TwoColumnsBalance.AutoSize = true;
            this.rdu_TwoColumnsBalance.BackColor = System.Drawing.Color.Transparent;
            this.rdu_TwoColumnsBalance.Checked = true;
            this.rdu_TwoColumnsBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdu_TwoColumnsBalance.ForeColor = System.Drawing.Color.Red;
            this.rdu_TwoColumnsBalance.Location = new System.Drawing.Point(261, 30);
            this.rdu_TwoColumnsBalance.Name = "rdu_TwoColumnsBalance";
            this.rdu_TwoColumnsBalance.Size = new System.Drawing.Size(104, 29);
            this.rdu_TwoColumnsBalance.TabIndex = 3;
            this.rdu_TwoColumnsBalance.TabStop = true;
            this.rdu_TwoColumnsBalance.Text = "دو ستونی";
            this.rdu_TwoColumnsBalance.UseVisualStyleBackColor = false;
            this.rdu_TwoColumnsBalance.CheckedChanged += new System.EventHandler(this.rdu_TwoColumnsBalance_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.pnl_betweenIDs);
            this.groupBox1.Controls.Add(this.pnl_betweenDates);
            this.groupBox1.Controls.Add(this.mTbx_tilDate);
            this.groupBox1.Controls.Add(this.rdu_showBetweenAccDoc_ids);
            this.groupBox1.Controls.Add(this.rdu_showBetweenDates);
            this.groupBox1.Controls.Add(this.rdu_showInDate);
            this.groupBox1.Location = new System.Drawing.Point(21, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 180);
            this.groupBox1.TabIndex = 100;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "شروط";
            // 
            // pnl_betweenIDs
            // 
            this.pnl_betweenIDs.Controls.Add(this.tbx_toID);
            this.pnl_betweenIDs.Controls.Add(this.label2);
            this.pnl_betweenIDs.Controls.Add(this.tbx_fromID);
            this.pnl_betweenIDs.Enabled = false;
            this.pnl_betweenIDs.Location = new System.Drawing.Point(6, 126);
            this.pnl_betweenIDs.Name = "pnl_betweenIDs";
            this.pnl_betweenIDs.Size = new System.Drawing.Size(232, 44);
            this.pnl_betweenIDs.TabIndex = 105;
            // 
            // tbx_toID
            // 
            this.tbx_toID.Location = new System.Drawing.Point(8, 5);
            this.tbx_toID.Name = "tbx_toID";
            this.tbx_toID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_toID.Size = new System.Drawing.Size(91, 26);
            this.tbx_toID.TabIndex = 103;
            this.tbx_toID.Text = "500";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 20);
            this.label2.TabIndex = 102;
            this.label2.Text = "تا";
            // 
            // tbx_fromID
            // 
            this.tbx_fromID.Location = new System.Drawing.Point(128, 6);
            this.tbx_fromID.Name = "tbx_fromID";
            this.tbx_fromID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_fromID.Size = new System.Drawing.Size(91, 26);
            this.tbx_fromID.TabIndex = 101;
            this.tbx_fromID.Text = "1";
            // 
            // pnl_betweenDates
            // 
            this.pnl_betweenDates.Controls.Add(this.label1);
            this.pnl_betweenDates.Controls.Add(this.mTbx_fromDate);
            this.pnl_betweenDates.Controls.Add(this.mTbx_toDate);
            this.pnl_betweenDates.Enabled = false;
            this.pnl_betweenDates.Location = new System.Drawing.Point(6, 73);
            this.pnl_betweenDates.Name = "pnl_betweenDates";
            this.pnl_betweenDates.Size = new System.Drawing.Size(232, 47);
            this.pnl_betweenDates.TabIndex = 104;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 20);
            this.label1.TabIndex = 100;
            this.label1.Text = "تا";
            // 
            // mTbx_fromDate
            // 
            this.mTbx_fromDate.AllowPromptAsInput = false;
            this.mTbx_fromDate.Location = new System.Drawing.Point(128, 6);
            this.mTbx_fromDate.Mask = "0000/00/00";
            this.mTbx_fromDate.Name = "mTbx_fromDate";
            this.mTbx_fromDate.PromptChar = ' ';
            this.mTbx_fromDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mTbx_fromDate.Size = new System.Drawing.Size(91, 26);
            this.mTbx_fromDate.TabIndex = 100;
            this.mTbx_fromDate.Leave += new System.EventHandler(this.mTbx_fromDate_Leave);
            // 
            // mTbx_toDate
            // 
            this.mTbx_toDate.AllowPromptAsInput = false;
            this.mTbx_toDate.Location = new System.Drawing.Point(8, 6);
            this.mTbx_toDate.Mask = "0000/00/00";
            this.mTbx_toDate.Name = "mTbx_toDate";
            this.mTbx_toDate.PromptChar = ' ';
            this.mTbx_toDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mTbx_toDate.Size = new System.Drawing.Size(91, 26);
            this.mTbx_toDate.TabIndex = 99;
            this.mTbx_toDate.Leave += new System.EventHandler(this.mTbx_toDate_Leave);
            // 
            // mTbx_tilDate
            // 
            this.mTbx_tilDate.AllowPromptAsInput = false;
            this.mTbx_tilDate.Location = new System.Drawing.Point(134, 28);
            this.mTbx_tilDate.Mask = "0000/00/00";
            this.mTbx_tilDate.Name = "mTbx_tilDate";
            this.mTbx_tilDate.PromptChar = ' ';
            this.mTbx_tilDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mTbx_tilDate.Size = new System.Drawing.Size(91, 26);
            this.mTbx_tilDate.TabIndex = 98;
            this.mTbx_tilDate.Leave += new System.EventHandler(this.mTbx_tilDate_Leave);
            // 
            // rdu_showBetweenAccDoc_ids
            // 
            this.rdu_showBetweenAccDoc_ids.AutoSize = true;
            this.rdu_showBetweenAccDoc_ids.BackColor = System.Drawing.Color.Transparent;
            this.rdu_showBetweenAccDoc_ids.Location = new System.Drawing.Point(259, 133);
            this.rdu_showBetweenAccDoc_ids.Name = "rdu_showBetweenAccDoc_ids";
            this.rdu_showBetweenAccDoc_ids.Size = new System.Drawing.Size(155, 24);
            this.rdu_showBetweenAccDoc_ids.TabIndex = 3;
            this.rdu_showBetweenAccDoc_ids.Text = "تراز ما بین سند های ";
            this.rdu_showBetweenAccDoc_ids.UseVisualStyleBackColor = false;
            this.rdu_showBetweenAccDoc_ids.CheckedChanged += new System.EventHandler(this.rdu_showBetweenAccDoc_ids_CheckedChanged);
            // 
            // rdu_showBetweenDates
            // 
            this.rdu_showBetweenDates.AutoSize = true;
            this.rdu_showBetweenDates.BackColor = System.Drawing.Color.Transparent;
            this.rdu_showBetweenDates.Location = new System.Drawing.Point(254, 81);
            this.rdu_showBetweenDates.Name = "rdu_showBetweenDates";
            this.rdu_showBetweenDates.Size = new System.Drawing.Size(168, 24);
            this.rdu_showBetweenDates.TabIndex = 2;
            this.rdu_showBetweenDates.Text = "تراز ما بین تاریخ های ";
            this.rdu_showBetweenDates.UseVisualStyleBackColor = false;
            this.rdu_showBetweenDates.CheckedChanged += new System.EventHandler(this.rdu_showBetweenDates_CheckedChanged);
            // 
            // rdu_showInDate
            // 
            this.rdu_showInDate.AutoSize = true;
            this.rdu_showInDate.BackColor = System.Drawing.Color.Transparent;
            this.rdu_showInDate.Checked = true;
            this.rdu_showInDate.Location = new System.Drawing.Point(267, 28);
            this.rdu_showInDate.Name = "rdu_showInDate";
            this.rdu_showInDate.Size = new System.Drawing.Size(150, 24);
            this.rdu_showInDate.TabIndex = 1;
            this.rdu_showInDate.TabStop = true;
            this.rdu_showInDate.Text = "تراز منتهی به تاریخ";
            this.rdu_showInDate.UseVisualStyleBackColor = false;
            this.rdu_showInDate.CheckedChanged += new System.EventHandler(this.rdu_showInDate_CheckedChanged);
            // 
            // rdu_onlyShowDetailBalance
            // 
            this.rdu_onlyShowDetailBalance.AutoSize = true;
            this.rdu_onlyShowDetailBalance.BackColor = System.Drawing.Color.Transparent;
            this.rdu_onlyShowDetailBalance.Location = new System.Drawing.Point(217, 35);
            this.rdu_onlyShowDetailBalance.Name = "rdu_onlyShowDetailBalance";
            this.rdu_onlyShowDetailBalance.Size = new System.Drawing.Size(197, 24);
            this.rdu_onlyShowDetailBalance.TabIndex = 107;
            this.rdu_onlyShowDetailBalance.Text = "نمایش تراز حساب های معین";
            this.rdu_onlyShowDetailBalance.UseVisualStyleBackColor = false;
            this.rdu_onlyShowDetailBalance.CheckedChanged += new System.EventHandler(this.rdu_showDetailBalance_CheckedChanged);
            // 
            // rdu_onlyShowLedgerBalance
            // 
            this.rdu_onlyShowLedgerBalance.AutoSize = true;
            this.rdu_onlyShowLedgerBalance.BackColor = System.Drawing.Color.Transparent;
            this.rdu_onlyShowLedgerBalance.Checked = true;
            this.rdu_onlyShowLedgerBalance.Location = new System.Drawing.Point(230, 3);
            this.rdu_onlyShowLedgerBalance.Name = "rdu_onlyShowLedgerBalance";
            this.rdu_onlyShowLedgerBalance.Size = new System.Drawing.Size(186, 24);
            this.rdu_onlyShowLedgerBalance.TabIndex = 106;
            this.rdu_onlyShowLedgerBalance.TabStop = true;
            this.rdu_onlyShowLedgerBalance.Text = "نمایش تراز حساب های کل";
            this.rdu_onlyShowLedgerBalance.UseVisualStyleBackColor = false;
            // 
            // chk_ledger
            // 
            this.chk_ledger.AutoSize = true;
            this.chk_ledger.BackColor = System.Drawing.Color.Transparent;
            this.chk_ledger.Checked = true;
            this.chk_ledger.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_ledger.Location = new System.Drawing.Point(191, 5);
            this.chk_ledger.Name = "chk_ledger";
            this.chk_ledger.Size = new System.Drawing.Size(131, 24);
            this.chk_ledger.TabIndex = 110;
            this.chk_ledger.Text = "فقط نمایش معین :";
            this.chk_ledger.UseVisualStyleBackColor = false;
            this.chk_ledger.CheckedChanged += new System.EventHandler(this.chk_ledger_CheckedChanged);
            // 
            // cmb_masterSpentName
            // 
            this.cmb_masterSpentName.DataSource = this.spentMasterBindingSource;
            this.cmb_masterSpentName.DisplayMember = "spentMasterName";
            this.cmb_masterSpentName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_masterSpentName.FormattingEnabled = true;
            this.cmb_masterSpentName.Location = new System.Drawing.Point(3, 3);
            this.cmb_masterSpentName.Name = "cmb_masterSpentName";
            this.cmb_masterSpentName.Size = new System.Drawing.Size(164, 28);
            this.cmb_masterSpentName.TabIndex = 111;
            this.cmb_masterSpentName.ValueMember = "spentMasterID";
            this.cmb_masterSpentName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_masterSpentName_KeyPress);
            // 
            // spentMasterBindingSource
            // 
            this.spentMasterBindingSource.DataMember = "spentMaster";
            this.spentMasterBindingSource.DataSource = this.pSDatabase5DataSet;
            // 
            // pSDatabase5DataSet
            // 
            this.pSDatabase5DataSet.DataSetName = "PSDatabase5DataSet";
            this.pSDatabase5DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pnl_showDetailBalance
            // 
            this.pnl_showDetailBalance.BackColor = System.Drawing.Color.Transparent;
            this.pnl_showDetailBalance.Controls.Add(this.cmb_masterSpentName);
            this.pnl_showDetailBalance.Controls.Add(this.chk_ledger);
            this.pnl_showDetailBalance.Enabled = false;
            this.pnl_showDetailBalance.Location = new System.Drawing.Point(18, 71);
            this.pnl_showDetailBalance.Name = "pnl_showDetailBalance";
            this.pnl_showDetailBalance.Size = new System.Drawing.Size(366, 49);
            this.pnl_showDetailBalance.TabIndex = 112;
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(155, 393);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(269, 36);
            this.btn_ok.TabIndex = 113;
            this.btn_ok.Text = "نـــمایش تـــــراز";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(37, 393);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(102, 35);
            this.btn_cancel.TabIndex = 114;
            this.btn_cancel.Text = "بستن فرم";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // pnl_ledgerSelection
            // 
            this.pnl_ledgerSelection.BackColor = System.Drawing.Color.Transparent;
            this.pnl_ledgerSelection.Controls.Add(this.pnl_showDetailBalance);
            this.pnl_ledgerSelection.Controls.Add(this.rdu_onlyShowDetailBalance);
            this.pnl_ledgerSelection.Controls.Add(this.rdu_onlyShowLedgerBalance);
            this.pnl_ledgerSelection.Location = new System.Drawing.Point(21, 252);
            this.pnl_ledgerSelection.Name = "pnl_ledgerSelection";
            this.pnl_ledgerSelection.Size = new System.Drawing.Size(422, 135);
            this.pnl_ledgerSelection.TabIndex = 115;
            // 
            // spentMasterTableAdapter
            // 
            this.spentMasterTableAdapter.ClearBeforeFill = true;
            // 
            // frm_balance
            // 
            this.AcceptButton = this.btn_ok;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::cactus_PS_.Properties.Resources.forms_template1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(456, 449);
            this.Controls.Add(this.pnl_ledgerSelection);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rdu_fourColumnsBalance);
            this.Controls.Add(this.rdu_TwoColumnsBalance);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_balance";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "تـــراز آزمــــایـــشـــی";
            this.Load += new System.EventHandler(this.frm_balance_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnl_betweenIDs.ResumeLayout(false);
            this.pnl_betweenIDs.PerformLayout();
            this.pnl_betweenDates.ResumeLayout(false);
            this.pnl_betweenDates.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spentMasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSDatabase5DataSet)).EndInit();
            this.pnl_showDetailBalance.ResumeLayout(false);
            this.pnl_showDetailBalance.PerformLayout();
            this.pnl_ledgerSelection.ResumeLayout(false);
            this.pnl_ledgerSelection.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.RadioButton rdu_fourColumnsBalance;
        public System.Windows.Forms.RadioButton rdu_TwoColumnsBalance;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel pnl_betweenIDs;
        private System.Windows.Forms.TextBox tbx_toID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_fromID;
        private System.Windows.Forms.Panel pnl_betweenDates;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mTbx_fromDate;
        private System.Windows.Forms.MaskedTextBox mTbx_toDate;
        private System.Windows.Forms.MaskedTextBox mTbx_tilDate;
        private System.Windows.Forms.RadioButton rdu_showBetweenAccDoc_ids;
        private System.Windows.Forms.RadioButton rdu_showBetweenDates;
        private System.Windows.Forms.RadioButton rdu_showInDate;
        private System.Windows.Forms.RadioButton rdu_onlyShowDetailBalance;
        private System.Windows.Forms.RadioButton rdu_onlyShowLedgerBalance;
        private System.Windows.Forms.CheckBox chk_ledger;
        private System.Windows.Forms.ComboBox cmb_masterSpentName;
        private System.Windows.Forms.Panel pnl_showDetailBalance;
        private PSDatabase5DataSet pSDatabase5DataSet;
        private System.Windows.Forms.BindingSource spentMasterBindingSource;
        private cactus_PS_.PSDatabase5DataSetTableAdapters.spentMasterTableAdapter spentMasterTableAdapter;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Panel pnl_ledgerSelection;
    }
}