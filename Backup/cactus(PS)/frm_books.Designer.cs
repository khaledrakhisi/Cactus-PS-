namespace cactus_PS_
{
    partial class frm_books
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
            this.rdu_showAll = new System.Windows.Forms.RadioButton();
            this.rdu_showInDate = new System.Windows.Forms.RadioButton();
            this.rdu_showBetweenDates = new System.Windows.Forms.RadioButton();
            this.rdu_showBetweenAccDoc_ids = new System.Windows.Forms.RadioButton();
            this.mTbx_inDate = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnl_betweenIDs = new System.Windows.Forms.Panel();
            this.tbx_toID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_fromID = new System.Windows.Forms.TextBox();
            this.pnl_betweenDates = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.mTbx_fromDate = new System.Windows.Forms.MaskedTextBox();
            this.mTbx_toDate = new System.Windows.Forms.MaskedTextBox();
            this.grp_bookKind = new System.Windows.Forms.GroupBox();
            this.pnl_detail = new System.Windows.Forms.Panel();
            this.tbx_detailCode = new System.Windows.Forms.TextBox();
            this.viwdetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pSDatabase5DataSet = new cactus_PS_.PSDatabase5DataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_detail = new System.Windows.Forms.ComboBox();
            this.pnl_masterSpent = new System.Windows.Forms.Panel();
            this.tbx_ledgerCode = new System.Windows.Forms.TextBox();
            this.spentMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmb_masterSpentName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rdu_smallJournal = new System.Windows.Forms.RadioButton();
            this.rdu_bigJournal = new System.Windows.Forms.RadioButton();
            this.rdu_journal = new System.Windows.Forms.RadioButton();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.spentMasterTableAdapter = new cactus_PS_.PSDatabase5DataSetTableAdapters.spentMasterTableAdapter();
            this.viw_detailsTableAdapter = new cactus_PS_.PSDatabase5DataSetTableAdapters.viw_detailsTableAdapter();
            this.groupBox1.SuspendLayout();
            this.pnl_betweenIDs.SuspendLayout();
            this.pnl_betweenDates.SuspendLayout();
            this.grp_bookKind.SuspendLayout();
            this.pnl_detail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viwdetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSDatabase5DataSet)).BeginInit();
            this.pnl_masterSpent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spentMasterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rdu_showAll
            // 
            this.rdu_showAll.AutoSize = true;
            this.rdu_showAll.BackColor = System.Drawing.Color.Transparent;
            this.rdu_showAll.Location = new System.Drawing.Point(405, 23);
            this.rdu_showAll.Name = "rdu_showAll";
            this.rdu_showAll.Size = new System.Drawing.Size(118, 30);
            this.rdu_showAll.TabIndex = 0;
            this.rdu_showAll.Text = "نمایش کل دفتر .";
            this.rdu_showAll.UseVisualStyleBackColor = false;
            this.rdu_showAll.CheckedChanged += new System.EventHandler(this.rdu_showAll_CheckedChanged);
            // 
            // rdu_showInDate
            // 
            this.rdu_showInDate.AutoSize = true;
            this.rdu_showInDate.BackColor = System.Drawing.Color.Transparent;
            this.rdu_showInDate.Checked = true;
            this.rdu_showInDate.Location = new System.Drawing.Point(381, 68);
            this.rdu_showInDate.Name = "rdu_showInDate";
            this.rdu_showInDate.Size = new System.Drawing.Size(142, 30);
            this.rdu_showInDate.TabIndex = 1;
            this.rdu_showInDate.TabStop = true;
            this.rdu_showInDate.Text = "نمایش دفتر در تاریخ";
            this.rdu_showInDate.UseVisualStyleBackColor = false;
            this.rdu_showInDate.CheckedChanged += new System.EventHandler(this.rdu_showInDate_CheckedChanged);
            // 
            // rdu_showBetweenDates
            // 
            this.rdu_showBetweenDates.AutoSize = true;
            this.rdu_showBetweenDates.BackColor = System.Drawing.Color.Transparent;
            this.rdu_showBetweenDates.Location = new System.Drawing.Point(330, 121);
            this.rdu_showBetweenDates.Name = "rdu_showBetweenDates";
            this.rdu_showBetweenDates.Size = new System.Drawing.Size(192, 30);
            this.rdu_showBetweenDates.TabIndex = 3;
            this.rdu_showBetweenDates.Text = "نمایش دفتر ما بین تاریخ های ";
            this.rdu_showBetweenDates.UseVisualStyleBackColor = false;
            this.rdu_showBetweenDates.CheckedChanged += new System.EventHandler(this.rdu_showBetweenDates_CheckedChanged);
            // 
            // rdu_showBetweenAccDoc_ids
            // 
            this.rdu_showBetweenAccDoc_ids.AutoSize = true;
            this.rdu_showBetweenAccDoc_ids.BackColor = System.Drawing.Color.Transparent;
            this.rdu_showBetweenAccDoc_ids.Location = new System.Drawing.Point(299, 170);
            this.rdu_showBetweenAccDoc_ids.Name = "rdu_showBetweenAccDoc_ids";
            this.rdu_showBetweenAccDoc_ids.Size = new System.Drawing.Size(224, 30);
            this.rdu_showBetweenAccDoc_ids.TabIndex = 5;
            this.rdu_showBetweenAccDoc_ids.Text = "نمایش دفتر ما بین شماره سند های ";
            this.rdu_showBetweenAccDoc_ids.UseVisualStyleBackColor = false;
            this.rdu_showBetweenAccDoc_ids.CheckedChanged += new System.EventHandler(this.rdu_showBetweenAccDoc_ids_CheckedChanged);
            // 
            // mTbx_inDate
            // 
            this.mTbx_inDate.AllowPromptAsInput = false;
            this.mTbx_inDate.Location = new System.Drawing.Point(158, 67);
            this.mTbx_inDate.Mask = "0000/00/00";
            this.mTbx_inDate.Name = "mTbx_inDate";
            this.mTbx_inDate.PromptChar = ' ';
            this.mTbx_inDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mTbx_inDate.Size = new System.Drawing.Size(91, 33);
            this.mTbx_inDate.TabIndex = 2;
            this.mTbx_inDate.Leave += new System.EventHandler(this.mTbx_inDate_Leave);
            this.mTbx_inDate.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mTbx_inDate_KeyUp);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.pnl_betweenIDs);
            this.groupBox1.Controls.Add(this.pnl_betweenDates);
            this.groupBox1.Controls.Add(this.mTbx_inDate);
            this.groupBox1.Controls.Add(this.rdu_showBetweenAccDoc_ids);
            this.groupBox1.Controls.Add(this.rdu_showBetweenDates);
            this.groupBox1.Controls.Add(this.rdu_showAll);
            this.groupBox1.Controls.Add(this.rdu_showInDate);
            this.groupBox1.Location = new System.Drawing.Point(21, 174);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(546, 223);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "شروط";
            // 
            // pnl_betweenIDs
            // 
            this.pnl_betweenIDs.Controls.Add(this.tbx_toID);
            this.pnl_betweenIDs.Controls.Add(this.label2);
            this.pnl_betweenIDs.Controls.Add(this.tbx_fromID);
            this.pnl_betweenIDs.Enabled = false;
            this.pnl_betweenIDs.Location = new System.Drawing.Point(30, 165);
            this.pnl_betweenIDs.Name = "pnl_betweenIDs";
            this.pnl_betweenIDs.Size = new System.Drawing.Size(232, 44);
            this.pnl_betweenIDs.TabIndex = 6;
            // 
            // tbx_toID
            // 
            this.tbx_toID.Location = new System.Drawing.Point(8, 5);
            this.tbx_toID.Name = "tbx_toID";
            this.tbx_toID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_toID.Size = new System.Drawing.Size(91, 33);
            this.tbx_toID.TabIndex = 1;
            this.tbx_toID.Text = "500";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 26);
            this.label2.TabIndex = 102;
            this.label2.Text = "تا";
            // 
            // tbx_fromID
            // 
            this.tbx_fromID.Location = new System.Drawing.Point(128, 6);
            this.tbx_fromID.Name = "tbx_fromID";
            this.tbx_fromID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_fromID.Size = new System.Drawing.Size(91, 33);
            this.tbx_fromID.TabIndex = 0;
            this.tbx_fromID.Text = "1";
            // 
            // pnl_betweenDates
            // 
            this.pnl_betweenDates.Controls.Add(this.label1);
            this.pnl_betweenDates.Controls.Add(this.mTbx_fromDate);
            this.pnl_betweenDates.Controls.Add(this.mTbx_toDate);
            this.pnl_betweenDates.Enabled = false;
            this.pnl_betweenDates.Location = new System.Drawing.Point(30, 112);
            this.pnl_betweenDates.Name = "pnl_betweenDates";
            this.pnl_betweenDates.Size = new System.Drawing.Size(232, 47);
            this.pnl_betweenDates.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 26);
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
            this.mTbx_fromDate.Size = new System.Drawing.Size(91, 33);
            this.mTbx_fromDate.TabIndex = 0;
            this.mTbx_fromDate.Leave += new System.EventHandler(this.mTbx_fromDate_Leave);
            this.mTbx_fromDate.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mTbx_fromDate_KeyUp);
            // 
            // mTbx_toDate
            // 
            this.mTbx_toDate.AllowPromptAsInput = false;
            this.mTbx_toDate.Location = new System.Drawing.Point(8, 6);
            this.mTbx_toDate.Mask = "0000/00/00";
            this.mTbx_toDate.Name = "mTbx_toDate";
            this.mTbx_toDate.PromptChar = ' ';
            this.mTbx_toDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mTbx_toDate.Size = new System.Drawing.Size(91, 33);
            this.mTbx_toDate.TabIndex = 1;
            this.mTbx_toDate.Leave += new System.EventHandler(this.mTbx_toDate_Leave);
            this.mTbx_toDate.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mTbx_toDate_KeyUp);
            // 
            // grp_bookKind
            // 
            this.grp_bookKind.BackColor = System.Drawing.Color.Transparent;
            this.grp_bookKind.Controls.Add(this.pnl_detail);
            this.grp_bookKind.Controls.Add(this.pnl_masterSpent);
            this.grp_bookKind.Controls.Add(this.rdu_smallJournal);
            this.grp_bookKind.Controls.Add(this.rdu_bigJournal);
            this.grp_bookKind.Controls.Add(this.rdu_journal);
            this.grp_bookKind.Location = new System.Drawing.Point(21, 22);
            this.grp_bookKind.Name = "grp_bookKind";
            this.grp_bookKind.Size = new System.Drawing.Size(546, 146);
            this.grp_bookKind.TabIndex = 0;
            this.grp_bookKind.TabStop = false;
            this.grp_bookKind.Text = "نوع دفتر حسابداری";
            // 
            // pnl_detail
            // 
            this.pnl_detail.Controls.Add(this.tbx_detailCode);
            this.pnl_detail.Controls.Add(this.label4);
            this.pnl_detail.Controls.Add(this.cmb_detail);
            this.pnl_detail.Enabled = false;
            this.pnl_detail.Location = new System.Drawing.Point(9, 66);
            this.pnl_detail.Name = "pnl_detail";
            this.pnl_detail.Size = new System.Drawing.Size(295, 74);
            this.pnl_detail.TabIndex = 4;
            // 
            // tbx_detailCode
            // 
            this.tbx_detailCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.viwdetailsBindingSource, "detailID", true));
            this.tbx_detailCode.Location = new System.Drawing.Point(247, 31);
            this.tbx_detailCode.Name = "tbx_detailCode";
            this.tbx_detailCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_detailCode.Size = new System.Drawing.Size(45, 33);
            this.tbx_detailCode.TabIndex = 0;
            // 
            // viwdetailsBindingSource
            // 
            this.viwdetailsBindingSource.DataMember = "viw_details";
            this.viwdetailsBindingSource.DataSource = this.pSDatabase5DataSet;
            // 
            // pSDatabase5DataSet
            // 
            this.pSDatabase5DataSet.DataSetName = "PSDatabase5DataSet";
            this.pSDatabase5DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 26);
            this.label4.TabIndex = 107;
            this.label4.Text = "سرفصل معین :";
            // 
            // cmb_detail
            // 
            this.cmb_detail.DataSource = this.viwdetailsBindingSource;
            this.cmb_detail.DisplayMember = "fullDetailName";
            this.cmb_detail.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_detail.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmb_detail.FormattingEnabled = true;
            this.cmb_detail.Location = new System.Drawing.Point(5, 32);
            this.cmb_detail.Name = "cmb_detail";
            this.cmb_detail.Size = new System.Drawing.Size(238, 32);
            this.cmb_detail.TabIndex = 1;
            this.cmb_detail.ValueMember = "detailID";
            this.cmb_detail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_detail_KeyPress);
            // 
            // pnl_masterSpent
            // 
            this.pnl_masterSpent.Controls.Add(this.tbx_ledgerCode);
            this.pnl_masterSpent.Controls.Add(this.cmb_masterSpentName);
            this.pnl_masterSpent.Controls.Add(this.label3);
            this.pnl_masterSpent.Enabled = false;
            this.pnl_masterSpent.Location = new System.Drawing.Point(307, 66);
            this.pnl_masterSpent.Name = "pnl_masterSpent";
            this.pnl_masterSpent.Size = new System.Drawing.Size(233, 74);
            this.pnl_masterSpent.TabIndex = 3;
            // 
            // tbx_ledgerCode
            // 
            this.tbx_ledgerCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spentMasterBindingSource, "spentMasterID", true));
            this.tbx_ledgerCode.Location = new System.Drawing.Point(195, 29);
            this.tbx_ledgerCode.Name = "tbx_ledgerCode";
            this.tbx_ledgerCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_ledgerCode.Size = new System.Drawing.Size(35, 33);
            this.tbx_ledgerCode.TabIndex = 0;
            // 
            // spentMasterBindingSource
            // 
            this.spentMasterBindingSource.DataMember = "spentMaster";
            this.spentMasterBindingSource.DataSource = this.pSDatabase5DataSet;
            this.spentMasterBindingSource.CurrentChanged += new System.EventHandler(this.spentMasterBindingSource_CurrentChanged);
            // 
            // cmb_masterSpentName
            // 
            this.cmb_masterSpentName.DataSource = this.spentMasterBindingSource;
            this.cmb_masterSpentName.DisplayMember = "spentMasterName";
            this.cmb_masterSpentName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_masterSpentName.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmb_masterSpentName.FormattingEnabled = true;
            this.cmb_masterSpentName.Location = new System.Drawing.Point(13, 29);
            this.cmb_masterSpentName.Name = "cmb_masterSpentName";
            this.cmb_masterSpentName.Size = new System.Drawing.Size(176, 32);
            this.cmb_masterSpentName.TabIndex = 1;
            this.cmb_masterSpentName.ValueMember = "spentMasterID";
            this.cmb_masterSpentName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_masterSpentName_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "سرفصل کل :";
            // 
            // rdu_smallJournal
            // 
            this.rdu_smallJournal.AutoSize = true;
            this.rdu_smallJournal.BackColor = System.Drawing.Color.Transparent;
            this.rdu_smallJournal.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdu_smallJournal.ForeColor = System.Drawing.Color.Red;
            this.rdu_smallJournal.Location = new System.Drawing.Point(106, 23);
            this.rdu_smallJournal.Name = "rdu_smallJournal";
            this.rdu_smallJournal.Size = new System.Drawing.Size(99, 34);
            this.rdu_smallJournal.TabIndex = 2;
            this.rdu_smallJournal.Text = "دفتر معین";
            this.rdu_smallJournal.UseVisualStyleBackColor = false;
            this.rdu_smallJournal.CheckedChanged += new System.EventHandler(this.rdu_smallJournal_CheckedChanged);
            // 
            // rdu_bigJournal
            // 
            this.rdu_bigJournal.AutoSize = true;
            this.rdu_bigJournal.BackColor = System.Drawing.Color.Transparent;
            this.rdu_bigJournal.Font = new System.Drawing.Font("B Nazanin", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdu_bigJournal.ForeColor = System.Drawing.Color.Red;
            this.rdu_bigJournal.Location = new System.Drawing.Point(217, 18);
            this.rdu_bigJournal.Name = "rdu_bigJournal";
            this.rdu_bigJournal.Size = new System.Drawing.Size(101, 42);
            this.rdu_bigJournal.TabIndex = 1;
            this.rdu_bigJournal.Text = "دفتر کل";
            this.rdu_bigJournal.UseVisualStyleBackColor = false;
            this.rdu_bigJournal.CheckedChanged += new System.EventHandler(this.rdu_bigJournal_CheckedChanged);
            // 
            // rdu_journal
            // 
            this.rdu_journal.AutoSize = true;
            this.rdu_journal.BackColor = System.Drawing.Color.Transparent;
            this.rdu_journal.Checked = true;
            this.rdu_journal.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdu_journal.ForeColor = System.Drawing.Color.Red;
            this.rdu_journal.Location = new System.Drawing.Point(330, 23);
            this.rdu_journal.Name = "rdu_journal";
            this.rdu_journal.Size = new System.Drawing.Size(110, 34);
            this.rdu_journal.TabIndex = 0;
            this.rdu_journal.TabStop = true;
            this.rdu_journal.Text = "دفتر روزنامه";
            this.rdu_journal.UseVisualStyleBackColor = false;
            this.rdu_journal.CheckedChanged += new System.EventHandler(this.rdu_journal_CheckedChanged);
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(168, 407);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(379, 35);
            this.btn_ok.TabIndex = 2;
            this.btn_ok.Text = "نمایش دفتر";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_close
            // 
            this.btn_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_close.Location = new System.Drawing.Point(45, 407);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(117, 35);
            this.btn_close.TabIndex = 3;
            this.btn_close.Text = "بستن";
            this.btn_close.UseVisualStyleBackColor = true;
            // 
            // spentMasterTableAdapter
            // 
            this.spentMasterTableAdapter.ClearBeforeFill = true;
            // 
            // viw_detailsTableAdapter
            // 
            this.viw_detailsTableAdapter.ClearBeforeFill = true;
            // 
            // frm_books
            // 
            this.AcceptButton = this.btn_ok;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::cactus_PS_.Properties.Resources.forms_template1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btn_close;
            this.ClientSize = new System.Drawing.Size(593, 464);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.grp_bookKind);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_books";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "دفاتر حسابداری";
            this.Load += new System.EventHandler(this.frm_books_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_books_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnl_betweenIDs.ResumeLayout(false);
            this.pnl_betweenIDs.PerformLayout();
            this.pnl_betweenDates.ResumeLayout(false);
            this.pnl_betweenDates.PerformLayout();
            this.grp_bookKind.ResumeLayout(false);
            this.grp_bookKind.PerformLayout();
            this.pnl_detail.ResumeLayout(false);
            this.pnl_detail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viwdetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSDatabase5DataSet)).EndInit();
            this.pnl_masterSpent.ResumeLayout(false);
            this.pnl_masterSpent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spentMasterBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rdu_showBetweenAccDoc_ids;
        private System.Windows.Forms.RadioButton rdu_showBetweenDates;
        private System.Windows.Forms.RadioButton rdu_showInDate;
        private System.Windows.Forms.RadioButton rdu_showAll;
        private System.Windows.Forms.MaskedTextBox mTbx_inDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mTbx_fromDate;
        private System.Windows.Forms.MaskedTextBox mTbx_toDate;
        private System.Windows.Forms.TextBox tbx_toID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_fromID;
        private System.Windows.Forms.GroupBox grp_bookKind;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Panel pnl_betweenIDs;
        private System.Windows.Forms.Panel pnl_betweenDates;
        public System.Windows.Forms.RadioButton rdu_smallJournal;
        public System.Windows.Forms.RadioButton rdu_bigJournal;
        public System.Windows.Forms.RadioButton rdu_journal;
        private PSDatabase5DataSet pSDatabase5DataSet;
        private System.Windows.Forms.BindingSource spentMasterBindingSource;
        private cactus_PS_.PSDatabase5DataSetTableAdapters.spentMasterTableAdapter spentMasterTableAdapter;
        private System.Windows.Forms.ComboBox cmb_detail;
        private System.Windows.Forms.Panel pnl_detail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnl_masterSpent;
        private System.Windows.Forms.TextBox tbx_ledgerCode;
        private System.Windows.Forms.ComboBox cmb_masterSpentName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource viwdetailsBindingSource;
        private cactus_PS_.PSDatabase5DataSetTableAdapters.viw_detailsTableAdapter viw_detailsTableAdapter;
        private System.Windows.Forms.TextBox tbx_detailCode;
    }
}