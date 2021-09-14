namespace cactus_PS_
{
    partial class frm_addInvoiceItems
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
            this.cmb_masterSpent = new System.Windows.Forms.ComboBox();
            this.spentMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pSDatabase5DataSet = new cactus_PS_.PSDatabase5DataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_subSpent = new System.Windows.Forms.ComboBox();
            this.spentDefBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_amount = new System.Windows.Forms.TextBox();
            this.tbx_phi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.spentMasterTableAdapter = new cactus_PS_.PSDatabase5DataSetTableAdapters.spentMasterTableAdapter();
            this.spentDefTableAdapter = new cactus_PS_.PSDatabase5DataSetTableAdapters.spentDefTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_spentDefID = new System.Windows.Forms.Label();
            this.pnl_projectName = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_projectName = new System.Windows.Forms.ComboBox();
            this.projectsTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_projectID = new System.Windows.Forms.Label();
            this.projectsTableTableAdapter = new cactus_PS_.PSDatabase5DataSetTableAdapters.projectsTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.spentMasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSDatabase5DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spentDefBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.pnl_projectName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectsTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_masterSpent
            // 
            this.cmb_masterSpent.DataSource = this.spentMasterBindingSource;
            this.cmb_masterSpent.DisplayMember = "spentMasterName";
            this.cmb_masterSpent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_masterSpent.FormattingEnabled = true;
            this.cmb_masterSpent.Location = new System.Drawing.Point(28, 75);
            this.cmb_masterSpent.Name = "cmb_masterSpent";
            this.cmb_masterSpent.Size = new System.Drawing.Size(244, 34);
            this.cmb_masterSpent.TabIndex = 0;
            this.cmb_masterSpent.ValueMember = "spentMasterID";
            // 
            // spentMasterBindingSource
            // 
            this.spentMasterBindingSource.DataMember = "spentMaster";
            this.spentMasterBindingSource.DataSource = this.pSDatabase5DataSet;
            this.spentMasterBindingSource.CurrentChanged += new System.EventHandler(this.spentMasterBindingSource_CurrentChanged);
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
            this.label1.Location = new System.Drawing.Point(289, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "گروه هزینه";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(277, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "هزینه";
            // 
            // cmb_subSpent
            // 
            this.cmb_subSpent.DataSource = this.spentDefBindingSource;
            this.cmb_subSpent.DisplayMember = "spentDefName";
            this.cmb_subSpent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_subSpent.FormattingEnabled = true;
            this.cmb_subSpent.Location = new System.Drawing.Point(28, 115);
            this.cmb_subSpent.Name = "cmb_subSpent";
            this.cmb_subSpent.Size = new System.Drawing.Size(231, 34);
            this.cmb_subSpent.TabIndex = 2;
            this.cmb_subSpent.ValueMember = "spentDefID";
            // 
            // spentDefBindingSource
            // 
            this.spentDefBindingSource.DataMember = "spentDef";
            this.spentDefBindingSource.DataSource = this.pSDatabase5DataSet;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(249, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "مقدار یا تعداد";
            // 
            // tbx_amount
            // 
            this.tbx_amount.Location = new System.Drawing.Point(44, 29);
            this.tbx_amount.Name = "tbx_amount";
            this.tbx_amount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_amount.Size = new System.Drawing.Size(161, 33);
            this.tbx_amount.TabIndex = 5;
            this.tbx_amount.Text = "0";
            this.tbx_amount.TextChanged += new System.EventHandler(this.tbx_amount_TextChanged);
            // 
            // tbx_phi
            // 
            this.tbx_phi.Location = new System.Drawing.Point(44, 71);
            this.tbx_phi.Name = "tbx_phi";
            this.tbx_phi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_phi.Size = new System.Drawing.Size(161, 33);
            this.tbx_phi.TabIndex = 7;
            this.tbx_phi.Text = "0";
            this.tbx_phi.TextChanged += new System.EventHandler(this.tbx_phi_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(277, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "فی";
            // 
            // btn_ok
            // 
            this.btn_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_ok.Location = new System.Drawing.Point(125, 278);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(214, 35);
            this.btn_ok.TabIndex = 8;
            this.btn_ok.Text = "تائید";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(38, 278);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(81, 35);
            this.btn_cancel.TabIndex = 9;
            this.btn_cancel.Text = "انصراف";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // spentMasterTableAdapter
            // 
            this.spentMasterTableAdapter.ClearBeforeFill = true;
            // 
            // spentDefTableAdapter
            // 
            this.spentDefTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.tbx_phi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbx_amount);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(22, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 117);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // lbl_spentDefID
            // 
            this.lbl_spentDefID.AutoSize = true;
            this.lbl_spentDefID.BackColor = System.Drawing.Color.Transparent;
            this.lbl_spentDefID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spentDefBindingSource, "spentDefID", true));
            this.lbl_spentDefID.Location = new System.Drawing.Point(425, 102);
            this.lbl_spentDefID.Name = "lbl_spentDefID";
            this.lbl_spentDefID.Size = new System.Drawing.Size(111, 26);
            this.lbl_spentDefID.TabIndex = 11;
            this.lbl_spentDefID.Text = "spentDefID";
            // 
            // pnl_projectName
            // 
            this.pnl_projectName.BackColor = System.Drawing.Color.Transparent;
            this.pnl_projectName.Controls.Add(this.label7);
            this.pnl_projectName.Controls.Add(this.cmb_projectName);
            this.pnl_projectName.Location = new System.Drawing.Point(73, 26);
            this.pnl_projectName.Name = "pnl_projectName";
            this.pnl_projectName.Size = new System.Drawing.Size(232, 43);
            this.pnl_projectName.TabIndex = 119;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(165, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 26);
            this.label7.TabIndex = 112;
            this.label7.Text = "نام پروژه :";
            // 
            // cmb_projectName
            // 
            this.cmb_projectName.DataSource = this.projectsTableBindingSource;
            this.cmb_projectName.DisplayMember = "projectTitle";
            this.cmb_projectName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_projectName.ForeColor = System.Drawing.Color.Red;
            this.cmb_projectName.FormattingEnabled = true;
            this.cmb_projectName.Location = new System.Drawing.Point(3, 3);
            this.cmb_projectName.Name = "cmb_projectName";
            this.cmb_projectName.Size = new System.Drawing.Size(156, 34);
            this.cmb_projectName.TabIndex = 111;
            this.cmb_projectName.ValueMember = "projectID";
            // 
            // projectsTableBindingSource
            // 
            this.projectsTableBindingSource.DataMember = "projectsTable";
            this.projectsTableBindingSource.DataSource = this.pSDatabase5DataSet;
            // 
            // lbl_projectID
            // 
            this.lbl_projectID.AutoSize = true;
            this.lbl_projectID.BackColor = System.Drawing.Color.Transparent;
            this.lbl_projectID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectsTableBindingSource, "projectID", true));
            this.lbl_projectID.Location = new System.Drawing.Point(425, 128);
            this.lbl_projectID.Name = "lbl_projectID";
            this.lbl_projectID.Size = new System.Drawing.Size(92, 26);
            this.lbl_projectID.TabIndex = 120;
            this.lbl_projectID.Text = "projectID";
            // 
            // projectsTableTableAdapter
            // 
            this.projectsTableTableAdapter.ClearBeforeFill = true;
            // 
            // frm_addInvoiceItems
            // 
            this.AcceptButton = this.btn_ok;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::cactus_PS_.Properties.Resources.forms_template1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(380, 333);
            this.Controls.Add(this.lbl_projectID);
            this.Controls.Add(this.pnl_projectName);
            this.Controls.Add(this.lbl_spentDefID);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_subSpent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_masterSpent);
            this.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_addInvoiceItems";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frm_addInvoiceItems_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_addInvoiceItems_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.spentMasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSDatabase5DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spentDefBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnl_projectName.ResumeLayout(false);
            this.pnl_projectName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectsTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_cancel;
        private PSDatabase5DataSet pSDatabase5DataSet;
        private System.Windows.Forms.BindingSource spentMasterBindingSource;
        private cactus_PS_.PSDatabase5DataSetTableAdapters.spentMasterTableAdapter spentMasterTableAdapter;
        private System.Windows.Forms.BindingSource spentDefBindingSource;
        private cactus_PS_.PSDatabase5DataSetTableAdapters.spentDefTableAdapter spentDefTableAdapter;
        public System.Windows.Forms.TextBox tbx_amount;
        public System.Windows.Forms.TextBox tbx_phi;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label lbl_spentDefID;
        private System.Windows.Forms.ComboBox cmb_masterSpent;
        private System.Windows.Forms.ComboBox cmb_subSpent;
        private System.Windows.Forms.Panel pnl_projectName;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label lbl_projectID;
        private cactus_PS_.PSDatabase5DataSetTableAdapters.projectsTableTableAdapter projectsTableTableAdapter;
        private System.Windows.Forms.ComboBox cmb_projectName;
        public System.Windows.Forms.BindingSource projectsTableBindingSource;
    }
}