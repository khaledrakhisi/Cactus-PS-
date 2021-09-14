namespace cactus_PS_
{
    partial class frm_projectsSmallLedger
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
            this.cmb_projects = new System.Windows.Forms.ComboBox();
            this.projectsTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pSDatabase5DataSet = new cactus_PS_.PSDatabase5DataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnl_betweenIDs = new System.Windows.Forms.Panel();
            this.tbx_toID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_fromID = new System.Windows.Forms.TextBox();
            this.pnl_betweenDates = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.mTbx_fromDate = new System.Windows.Forms.MaskedTextBox();
            this.mTbx_toDate = new System.Windows.Forms.MaskedTextBox();
            this.mTbx_inDate = new System.Windows.Forms.MaskedTextBox();
            this.rdu_showBetweenAccDoc_ids = new System.Windows.Forms.RadioButton();
            this.rdu_showBetweenDates = new System.Windows.Forms.RadioButton();
            this.rdu_showAll = new System.Windows.Forms.RadioButton();
            this.rdu_showInDate = new System.Windows.Forms.RadioButton();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.projectsTableTableAdapter = new cactus_PS_.PSDatabase5DataSetTableAdapters.projectsTableTableAdapter();
            this.tbx_projectID = new System.Windows.Forms.TextBox();
            this.spentMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spentMasterTableAdapter = new cactus_PS_.PSDatabase5DataSetTableAdapters.spentMasterTableAdapter();
            this.pnl_ledger = new System.Windows.Forms.Panel();
            this.tbx_ledgerCode = new System.Windows.Forms.TextBox();
            this.cmb_masterSpentName = new System.Windows.Forms.ComboBox();
            this.chk_filterLedger = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.projectsTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSDatabase5DataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.pnl_betweenIDs.SuspendLayout();
            this.pnl_betweenDates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spentMasterBindingSource)).BeginInit();
            this.pnl_ledger.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_projects
            // 
            this.cmb_projects.DataSource = this.projectsTableBindingSource;
            this.cmb_projects.DisplayMember = "projectTitle";
            this.cmb_projects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_projects.FormattingEnabled = true;
            this.cmb_projects.Location = new System.Drawing.Point(80, 48);
            this.cmb_projects.Name = "cmb_projects";
            this.cmb_projects.Size = new System.Drawing.Size(315, 34);
            this.cmb_projects.TabIndex = 0;
            this.cmb_projects.ValueMember = "projectID";
            this.cmb_projects.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_persons_KeyPress);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(199, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "پـــــروژه";
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
            this.groupBox1.Location = new System.Drawing.Point(28, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 230);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "شروط";
            // 
            // pnl_betweenIDs
            // 
            this.pnl_betweenIDs.Controls.Add(this.tbx_toID);
            this.pnl_betweenIDs.Controls.Add(this.label2);
            this.pnl_betweenIDs.Controls.Add(this.tbx_fromID);
            this.pnl_betweenIDs.Enabled = false;
            this.pnl_betweenIDs.Location = new System.Drawing.Point(0, 169);
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
            this.pnl_betweenDates.Controls.Add(this.label3);
            this.pnl_betweenDates.Controls.Add(this.mTbx_fromDate);
            this.pnl_betweenDates.Controls.Add(this.mTbx_toDate);
            this.pnl_betweenDates.Enabled = false;
            this.pnl_betweenDates.Location = new System.Drawing.Point(0, 116);
            this.pnl_betweenDates.Name = "pnl_betweenDates";
            this.pnl_betweenDates.Size = new System.Drawing.Size(232, 47);
            this.pnl_betweenDates.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 26);
            this.label3.TabIndex = 100;
            this.label3.Text = "تا";
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
            // mTbx_inDate
            // 
            this.mTbx_inDate.AllowPromptAsInput = false;
            this.mTbx_inDate.Location = new System.Drawing.Point(128, 71);
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
            this.rdu_showBetweenAccDoc_ids.Location = new System.Drawing.Point(230, 174);
            this.rdu_showBetweenAccDoc_ids.Name = "rdu_showBetweenAccDoc_ids";
            this.rdu_showBetweenAccDoc_ids.Size = new System.Drawing.Size(224, 30);
            this.rdu_showBetweenAccDoc_ids.TabIndex = 5;
            this.rdu_showBetweenAccDoc_ids.Text = "نمایش دفتر ما بین شماره سند های ";
            this.rdu_showBetweenAccDoc_ids.UseVisualStyleBackColor = false;
            this.rdu_showBetweenAccDoc_ids.CheckedChanged += new System.EventHandler(this.rdu_showBetweenAccDoc_ids_CheckedChanged);
            // 
            // rdu_showBetweenDates
            // 
            this.rdu_showBetweenDates.AutoSize = true;
            this.rdu_showBetweenDates.BackColor = System.Drawing.Color.Transparent;
            this.rdu_showBetweenDates.Location = new System.Drawing.Point(262, 126);
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
            this.rdu_showAll.Location = new System.Drawing.Point(336, 30);
            this.rdu_showAll.Name = "rdu_showAll";
            this.rdu_showAll.Size = new System.Drawing.Size(118, 30);
            this.rdu_showAll.TabIndex = 0;
            this.rdu_showAll.Text = "نمایش کل دفتر .";
            this.rdu_showAll.UseVisualStyleBackColor = false;
            // 
            // rdu_showInDate
            // 
            this.rdu_showInDate.AutoSize = true;
            this.rdu_showInDate.BackColor = System.Drawing.Color.Transparent;
            this.rdu_showInDate.Checked = true;
            this.rdu_showInDate.Location = new System.Drawing.Point(312, 78);
            this.rdu_showInDate.Name = "rdu_showInDate";
            this.rdu_showInDate.Size = new System.Drawing.Size(142, 30);
            this.rdu_showInDate.TabIndex = 1;
            this.rdu_showInDate.TabStop = true;
            this.rdu_showInDate.Text = "نمایش دفتر در تاریخ";
            this.rdu_showInDate.UseVisualStyleBackColor = false;
            this.rdu_showInDate.CheckedChanged += new System.EventHandler(this.rdu_showInDate_CheckedChanged);
            // 
            // btn_close
            // 
            this.btn_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_close.Location = new System.Drawing.Point(38, 372);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(117, 35);
            this.btn_close.TabIndex = 6;
            this.btn_close.Text = "بستن";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(161, 372);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(321, 35);
            this.btn_ok.TabIndex = 5;
            this.btn_ok.Text = "نمایش دفتر معین";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // projectsTableTableAdapter
            // 
            this.projectsTableTableAdapter.ClearBeforeFill = true;
            // 
            // tbx_projectID
            // 
            this.tbx_projectID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectsTableBindingSource, "projectID", true));
            this.tbx_projectID.Location = new System.Drawing.Point(401, 48);
            this.tbx_projectID.Name = "tbx_projectID";
            this.tbx_projectID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_projectID.Size = new System.Drawing.Size(40, 33);
            this.tbx_projectID.TabIndex = 1;
            this.tbx_projectID.TabStop = false;
            // 
            // spentMasterBindingSource
            // 
            this.spentMasterBindingSource.DataMember = "spentMaster";
            this.spentMasterBindingSource.DataSource = this.pSDatabase5DataSet;
            // 
            // spentMasterTableAdapter
            // 
            this.spentMasterTableAdapter.ClearBeforeFill = true;
            // 
            // pnl_ledger
            // 
            this.pnl_ledger.BackColor = System.Drawing.Color.Transparent;
            this.pnl_ledger.Controls.Add(this.tbx_ledgerCode);
            this.pnl_ledger.Controls.Add(this.cmb_masterSpentName);
            this.pnl_ledger.Enabled = false;
            this.pnl_ledger.Location = new System.Drawing.Point(80, 88);
            this.pnl_ledger.Name = "pnl_ledger";
            this.pnl_ledger.Size = new System.Drawing.Size(218, 52);
            this.pnl_ledger.TabIndex = 3;
            // 
            // tbx_ledgerCode
            // 
            this.tbx_ledgerCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spentMasterBindingSource, "spentMasterID", true));
            this.tbx_ledgerCode.Location = new System.Drawing.Point(175, 11);
            this.tbx_ledgerCode.Name = "tbx_ledgerCode";
            this.tbx_ledgerCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_ledgerCode.Size = new System.Drawing.Size(35, 33);
            this.tbx_ledgerCode.TabIndex = 1;
            // 
            // cmb_masterSpentName
            // 
            this.cmb_masterSpentName.DataSource = this.spentMasterBindingSource;
            this.cmb_masterSpentName.DisplayMember = "spentMasterName";
            this.cmb_masterSpentName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_masterSpentName.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmb_masterSpentName.FormattingEnabled = true;
            this.cmb_masterSpentName.Location = new System.Drawing.Point(7, 11);
            this.cmb_masterSpentName.Name = "cmb_masterSpentName";
            this.cmb_masterSpentName.Size = new System.Drawing.Size(162, 32);
            this.cmb_masterSpentName.TabIndex = 0;
            this.cmb_masterSpentName.ValueMember = "spentMasterID";
            this.cmb_masterSpentName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_masterSpentName_KeyPress);
            // 
            // chk_filterLedger
            // 
            this.chk_filterLedger.AutoSize = true;
            this.chk_filterLedger.BackColor = System.Drawing.Color.Transparent;
            this.chk_filterLedger.Location = new System.Drawing.Point(304, 102);
            this.chk_filterLedger.Name = "chk_filterLedger";
            this.chk_filterLedger.Size = new System.Drawing.Size(137, 30);
            this.chk_filterLedger.TabIndex = 2;
            this.chk_filterLedger.Text = "فقط نمایش حساب :";
            this.chk_filterLedger.UseVisualStyleBackColor = false;
            this.chk_filterLedger.CheckedChanged += new System.EventHandler(this.chk_filterLedger_CheckedChanged);
            // 
            // frm_projectsSmallLedger
            // 
            this.AcceptButton = this.btn_ok;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::cactus_PS_.Properties.Resources.forms_template1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btn_close;
            this.ClientSize = new System.Drawing.Size(520, 428);
            this.Controls.Add(this.pnl_ledger);
            this.Controls.Add(this.chk_filterLedger);
            this.Controls.Add(this.tbx_projectID);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_projects);
            this.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_projectsSmallLedger";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مـــعیـــن پروژه ها";
            this.Load += new System.EventHandler(this.frm_personsSmallLedger_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projectsTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSDatabase5DataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnl_betweenIDs.ResumeLayout(false);
            this.pnl_betweenIDs.PerformLayout();
            this.pnl_betweenDates.ResumeLayout(false);
            this.pnl_betweenDates.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spentMasterBindingSource)).EndInit();
            this.pnl_ledger.ResumeLayout(false);
            this.pnl_ledger.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_projects;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel pnl_betweenIDs;
        private System.Windows.Forms.TextBox tbx_toID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_fromID;
        private System.Windows.Forms.Panel pnl_betweenDates;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mTbx_fromDate;
        private System.Windows.Forms.MaskedTextBox mTbx_toDate;
        private System.Windows.Forms.MaskedTextBox mTbx_inDate;
        private System.Windows.Forms.RadioButton rdu_showBetweenAccDoc_ids;
        private System.Windows.Forms.RadioButton rdu_showBetweenDates;
        private System.Windows.Forms.RadioButton rdu_showAll;
        private System.Windows.Forms.RadioButton rdu_showInDate;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_ok;
        private PSDatabase5DataSet pSDatabase5DataSet;
        private System.Windows.Forms.BindingSource projectsTableBindingSource;
        private cactus_PS_.PSDatabase5DataSetTableAdapters.projectsTableTableAdapter projectsTableTableAdapter;
        private System.Windows.Forms.TextBox tbx_projectID;
        private System.Windows.Forms.BindingSource spentMasterBindingSource;
        private cactus_PS_.PSDatabase5DataSetTableAdapters.spentMasterTableAdapter spentMasterTableAdapter;
        private System.Windows.Forms.Panel pnl_ledger;
        private System.Windows.Forms.TextBox tbx_ledgerCode;
        private System.Windows.Forms.ComboBox cmb_masterSpentName;
        private System.Windows.Forms.CheckBox chk_filterLedger;
    }
}