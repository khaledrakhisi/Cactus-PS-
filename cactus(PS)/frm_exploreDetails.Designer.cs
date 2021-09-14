namespace cactus_PS_
{
    partial class frm_exploreDetails
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
            this.rdu_all = new System.Windows.Forms.RadioButton();
            this.rdu_ledgers = new System.Windows.Forms.RadioButton();
            this.rdu_details = new System.Windows.Forms.RadioButton();
            this.rdu_detailsByFilter = new System.Windows.Forms.RadioButton();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.pnl_ledgerGroup = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_masterSpent = new System.Windows.Forms.Panel();
            this.tbx_ledgerCode = new System.Windows.Forms.TextBox();
            this.spentMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pSDatabase5DataSet = new cactus_PS_.PSDatabase5DataSet();
            this.cmb_masterSpentName = new System.Windows.Forms.ComboBox();
            this.spentMasterTableAdapter = new cactus_PS_.PSDatabase5DataSetTableAdapters.spentMasterTableAdapter();
            this.pnl_ledgerGroup.SuspendLayout();
            this.pnl_masterSpent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spentMasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSDatabase5DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // rdu_all
            // 
            this.rdu_all.AutoSize = true;
            this.rdu_all.BackColor = System.Drawing.Color.Transparent;
            this.rdu_all.Checked = true;
            this.rdu_all.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdu_all.ForeColor = System.Drawing.Color.Red;
            this.rdu_all.Location = new System.Drawing.Point(180, 28);
            this.rdu_all.Name = "rdu_all";
            this.rdu_all.Size = new System.Drawing.Size(168, 34);
            this.rdu_all.TabIndex = 0;
            this.rdu_all.TabStop = true;
            this.rdu_all.Text = "نمایش کلیه حساب ها";
            this.rdu_all.UseVisualStyleBackColor = false;
            // 
            // rdu_ledgers
            // 
            this.rdu_ledgers.AutoSize = true;
            this.rdu_ledgers.BackColor = System.Drawing.Color.Transparent;
            this.rdu_ledgers.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdu_ledgers.ForeColor = System.Drawing.Color.Red;
            this.rdu_ledgers.Location = new System.Drawing.Point(177, 68);
            this.rdu_ledgers.Name = "rdu_ledgers";
            this.rdu_ledgers.Size = new System.Drawing.Size(171, 34);
            this.rdu_ledgers.TabIndex = 1;
            this.rdu_ledgers.Text = "نمایش حساب های کل";
            this.rdu_ledgers.UseVisualStyleBackColor = false;
            // 
            // rdu_details
            // 
            this.rdu_details.AutoSize = true;
            this.rdu_details.BackColor = System.Drawing.Color.Transparent;
            this.rdu_details.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdu_details.ForeColor = System.Drawing.Color.Red;
            this.rdu_details.Location = new System.Drawing.Point(162, 108);
            this.rdu_details.Name = "rdu_details";
            this.rdu_details.Size = new System.Drawing.Size(186, 34);
            this.rdu_details.TabIndex = 2;
            this.rdu_details.Text = "نمایش حساب های معین";
            this.rdu_details.UseVisualStyleBackColor = false;
            // 
            // rdu_detailsByFilter
            // 
            this.rdu_detailsByFilter.AutoSize = true;
            this.rdu_detailsByFilter.BackColor = System.Drawing.Color.Transparent;
            this.rdu_detailsByFilter.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdu_detailsByFilter.ForeColor = System.Drawing.Color.Red;
            this.rdu_detailsByFilter.Location = new System.Drawing.Point(64, 148);
            this.rdu_detailsByFilter.Name = "rdu_detailsByFilter";
            this.rdu_detailsByFilter.Size = new System.Drawing.Size(284, 34);
            this.rdu_detailsByFilter.TabIndex = 3;
            this.rdu_detailsByFilter.Text = "نمایش حساب های معین یک حساب کل";
            this.rdu_detailsByFilter.UseVisualStyleBackColor = false;
            this.rdu_detailsByFilter.CheckedChanged += new System.EventHandler(this.rdu_detailsByFilter_CheckedChanged);
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(115, 244);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(237, 36);
            this.btn_ok.TabIndex = 5;
            this.btn_ok.Text = "نــــمایــــش";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(18, 244);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(91, 36);
            this.btn_cancel.TabIndex = 6;
            this.btn_cancel.Text = "بستن";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // pnl_ledgerGroup
            // 
            this.pnl_ledgerGroup.BackColor = System.Drawing.Color.Transparent;
            this.pnl_ledgerGroup.Controls.Add(this.label1);
            this.pnl_ledgerGroup.Controls.Add(this.pnl_masterSpent);
            this.pnl_ledgerGroup.Enabled = false;
            this.pnl_ledgerGroup.Location = new System.Drawing.Point(31, 186);
            this.pnl_ledgerGroup.Name = "pnl_ledgerGroup";
            this.pnl_ledgerGroup.Size = new System.Drawing.Size(308, 51);
            this.pnl_ledgerGroup.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "حساب کل:";
            // 
            // pnl_masterSpent
            // 
            this.pnl_masterSpent.Controls.Add(this.tbx_ledgerCode);
            this.pnl_masterSpent.Controls.Add(this.cmb_masterSpentName);
            this.pnl_masterSpent.Location = new System.Drawing.Point(3, 3);
            this.pnl_masterSpent.Name = "pnl_masterSpent";
            this.pnl_masterSpent.Size = new System.Drawing.Size(224, 43);
            this.pnl_masterSpent.TabIndex = 0;
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
            // pSDatabase5DataSet
            // 
            this.pSDatabase5DataSet.DataSetName = "PSDatabase5DataSet";
            this.pSDatabase5DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // spentMasterTableAdapter
            // 
            this.spentMasterTableAdapter.ClearBeforeFill = true;
            // 
            // frm_exploreDetails
            // 
            this.AcceptButton = this.btn_ok;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::cactus_PS_.Properties.Resources.forms_template1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(370, 295);
            this.Controls.Add(this.pnl_ledgerGroup);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.rdu_detailsByFilter);
            this.Controls.Add(this.rdu_details);
            this.Controls.Add(this.rdu_ledgers);
            this.Controls.Add(this.rdu_all);
            this.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_exploreDetails";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نـــمایش کــــد حسابـــــها";
            this.Load += new System.EventHandler(this.frm_exploreDetails_Load);
            this.pnl_ledgerGroup.ResumeLayout(false);
            this.pnl_ledgerGroup.PerformLayout();
            this.pnl_masterSpent.ResumeLayout(false);
            this.pnl_masterSpent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spentMasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSDatabase5DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.RadioButton rdu_all;
        public System.Windows.Forms.RadioButton rdu_ledgers;
        public System.Windows.Forms.RadioButton rdu_details;
        public System.Windows.Forms.RadioButton rdu_detailsByFilter;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Panel pnl_ledgerGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_masterSpent;
        private System.Windows.Forms.TextBox tbx_ledgerCode;
        private System.Windows.Forms.ComboBox cmb_masterSpentName;
        private PSDatabase5DataSet pSDatabase5DataSet;
        private System.Windows.Forms.BindingSource spentMasterBindingSource;
        private cactus_PS_.PSDatabase5DataSetTableAdapters.spentMasterTableAdapter spentMasterTableAdapter;
    }
}