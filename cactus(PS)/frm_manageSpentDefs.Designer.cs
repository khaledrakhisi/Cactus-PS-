namespace cactus_PS_
{
    partial class frm_manageSpentDefs
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
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.spentMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pSDatabase5DataSet = new cactus_PS_.PSDatabase5DataSet();
            this.spentDefBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spentMasterTableAdapter = new cactus_PS_.PSDatabase5DataSetTableAdapters.spentMasterTableAdapter();
            this.spentDefTableAdapter = new cactus_PS_.PSDatabase5DataSetTableAdapters.spentDefTableAdapter();
            this.grp_spentsDefins = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_renameSubSpent = new System.Windows.Forms.Button();
            this.btn_defineNewSubSpent = new System.Windows.Forms.Button();
            this.lst_subSpents = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_spentKind = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_spentGroupKind = new System.Windows.Forms.ComboBox();
            this.spentGroupsTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_saveChanges = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_detailType = new System.Windows.Forms.ComboBox();
            this.btn_deleteMasterSpent = new System.Windows.Forms.Button();
            this.btn_modifyMasterSpent = new System.Windows.Forms.Button();
            this.btn_newMasterSpent = new System.Windows.Forms.Button();
            this.cmb_masterSpentName = new System.Windows.Forms.ComboBox();
            this.spentGroupsTableTableAdapter = new cactus_PS_.PSDatabase5DataSetTableAdapters.spentGroupsTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.spentMasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSDatabase5DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spentDefBindingSource)).BeginInit();
            this.grp_spentsDefins.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spentGroupsTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ok
            // 
            this.btn_ok.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_ok.Image = global::cactus_PS_.Properties.Resources.OOFL;
            this.btn_ok.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ok.Location = new System.Drawing.Point(359, 414);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(158, 36);
            this.btn_ok.TabIndex = 2;
            this.btn_ok.Text = "تائــــید";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Image = global::cactus_PS_.Properties.Resources.OOFL;
            this.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cancel.Location = new System.Drawing.Point(36, 414);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(113, 36);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "لغو";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Visible = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
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
            // spentDefBindingSource
            // 
            this.spentDefBindingSource.DataMember = "spentDef";
            this.spentDefBindingSource.DataSource = this.pSDatabase5DataSet;
            // 
            // spentMasterTableAdapter
            // 
            this.spentMasterTableAdapter.ClearBeforeFill = true;
            // 
            // spentDefTableAdapter
            // 
            this.spentDefTableAdapter.ClearBeforeFill = true;
            // 
            // grp_spentsDefins
            // 
            this.grp_spentsDefins.BackColor = System.Drawing.Color.Transparent;
            this.grp_spentsDefins.Controls.Add(this.button2);
            this.grp_spentsDefins.Controls.Add(this.btn_renameSubSpent);
            this.grp_spentsDefins.Controls.Add(this.btn_defineNewSubSpent);
            this.grp_spentsDefins.Controls.Add(this.lst_subSpents);
            this.grp_spentsDefins.Enabled = false;
            this.grp_spentsDefins.Location = new System.Drawing.Point(22, 233);
            this.grp_spentsDefins.Name = "grp_spentsDefins";
            this.grp_spentsDefins.Size = new System.Drawing.Size(510, 168);
            this.grp_spentsDefins.TabIndex = 1;
            this.grp_spentsDefins.TabStop = false;
            this.grp_spentsDefins.Text = "نوع هزینه";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Azure;
            this.button2.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(337, 116);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 36);
            this.button2.TabIndex = 2;
            this.button2.Text = "حذف";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_renameSubSpent
            // 
            this.btn_renameSubSpent.BackColor = System.Drawing.Color.Azure;
            this.btn_renameSubSpent.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_renameSubSpent.Location = new System.Drawing.Point(337, 74);
            this.btn_renameSubSpent.Name = "btn_renameSubSpent";
            this.btn_renameSubSpent.Size = new System.Drawing.Size(117, 36);
            this.btn_renameSubSpent.TabIndex = 1;
            this.btn_renameSubSpent.Text = "تغییر عنوان";
            this.btn_renameSubSpent.UseVisualStyleBackColor = false;
            this.btn_renameSubSpent.Click += new System.EventHandler(this.btn_renameSubSpent_Click);
            // 
            // btn_defineNewSubSpent
            // 
            this.btn_defineNewSubSpent.BackColor = System.Drawing.Color.Azure;
            this.btn_defineNewSubSpent.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_defineNewSubSpent.ForeColor = System.Drawing.Color.Green;
            this.btn_defineNewSubSpent.Location = new System.Drawing.Point(337, 32);
            this.btn_defineNewSubSpent.Name = "btn_defineNewSubSpent";
            this.btn_defineNewSubSpent.Size = new System.Drawing.Size(117, 36);
            this.btn_defineNewSubSpent.TabIndex = 0;
            this.btn_defineNewSubSpent.Text = "* جدید";
            this.btn_defineNewSubSpent.UseVisualStyleBackColor = false;
            this.btn_defineNewSubSpent.Click += new System.EventHandler(this.btn_defineNewSubSpent_Click);
            // 
            // lst_subSpents
            // 
            this.lst_subSpents.BackColor = System.Drawing.Color.Silver;
            this.lst_subSpents.DataSource = this.spentDefBindingSource;
            this.lst_subSpents.DisplayMember = "spentDefName";
            this.lst_subSpents.FormattingEnabled = true;
            this.lst_subSpents.ItemHeight = 26;
            this.lst_subSpents.Location = new System.Drawing.Point(57, 25);
            this.lst_subSpents.Name = "lst_subSpents";
            this.lst_subSpents.Size = new System.Drawing.Size(274, 134);
            this.lst_subSpents.TabIndex = 3;
            this.lst_subSpents.ValueMember = "spentDefID";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmb_spentKind);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cmb_spentGroupKind);
            this.groupBox2.Controls.Add(this.btn_saveChanges);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmb_detailType);
            this.groupBox2.Controls.Add(this.btn_deleteMasterSpent);
            this.groupBox2.Controls.Add(this.btn_modifyMasterSpent);
            this.groupBox2.Controls.Add(this.btn_newMasterSpent);
            this.groupBox2.Controls.Add(this.cmb_masterSpentName);
            this.groupBox2.Location = new System.Drawing.Point(22, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(510, 204);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "سرفصل ها";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 26);
            this.label4.TabIndex = 11;
            this.label4.Text = "ماهیت حساب :";
            // 
            // cmb_spentKind
            // 
            this.cmb_spentKind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_spentKind.FormattingEnabled = true;
            this.cmb_spentKind.Items.AddRange(new object[] {
            "1 - بدون ماهیت و گروه",
            "2 - بدهکار",
            "3 - بستانکار",
            "4 - بدهکار / بستانکار"});
            this.cmb_spentKind.Location = new System.Drawing.Point(12, 161);
            this.cmb_spentKind.Name = "cmb_spentKind";
            this.cmb_spentKind.Size = new System.Drawing.Size(140, 34);
            this.cmb_spentKind.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(415, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 26);
            this.label3.TabIndex = 9;
            this.label3.Text = "گروه حساب :";
            // 
            // cmb_spentGroupKind
            // 
            this.cmb_spentGroupKind.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.spentMasterBindingSource, "spentGroup_id", true));
            this.cmb_spentGroupKind.DataSource = this.spentGroupsTableBindingSource;
            this.cmb_spentGroupKind.DisplayMember = "spentGroup_name";
            this.cmb_spentGroupKind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_spentGroupKind.FormattingEnabled = true;
            this.cmb_spentGroupKind.Location = new System.Drawing.Point(253, 161);
            this.cmb_spentGroupKind.Name = "cmb_spentGroupKind";
            this.cmb_spentGroupKind.Size = new System.Drawing.Size(156, 34);
            this.cmb_spentGroupKind.TabIndex = 6;
            this.cmb_spentGroupKind.ValueMember = "spentGroup_id";
            // 
            // spentGroupsTableBindingSource
            // 
            this.spentGroupsTableBindingSource.DataMember = "spentGroupsTable";
            this.spentGroupsTableBindingSource.DataSource = this.pSDatabase5DataSet;
            // 
            // btn_saveChanges
            // 
            this.btn_saveChanges.BackColor = System.Drawing.Color.Azure;
            this.btn_saveChanges.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_saveChanges.ForeColor = System.Drawing.Color.Blue;
            this.btn_saveChanges.Location = new System.Drawing.Point(92, 31);
            this.btn_saveChanges.Name = "btn_saveChanges";
            this.btn_saveChanges.Size = new System.Drawing.Size(90, 36);
            this.btn_saveChanges.TabIndex = 2;
            this.btn_saveChanges.Text = "ثبت";
            this.btn_saveChanges.UseVisualStyleBackColor = false;
            this.btn_saveChanges.Click += new System.EventHandler(this.btn_saveChanges_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "سرفصل معین :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(326, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "سرفصل کل :";
            // 
            // cmb_detailType
            // 
            this.cmb_detailType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_detailType.FormattingEnabled = true;
            this.cmb_detailType.Items.AddRange(new object[] {
            "-بدون سرفصل معین-",
            "1 - پروژه ها",
            "2 - طرف های حساب",
            "3 - حساب های بانکی",
            "4 - پروژه ها و طرف های حساب"});
            this.cmb_detailType.Location = new System.Drawing.Point(68, 118);
            this.cmb_detailType.Name = "cmb_detailType";
            this.cmb_detailType.Size = new System.Drawing.Size(240, 34);
            this.cmb_detailType.TabIndex = 5;
            // 
            // btn_deleteMasterSpent
            // 
            this.btn_deleteMasterSpent.BackColor = System.Drawing.Color.Azure;
            this.btn_deleteMasterSpent.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_deleteMasterSpent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_deleteMasterSpent.Location = new System.Drawing.Point(23, 31);
            this.btn_deleteMasterSpent.Name = "btn_deleteMasterSpent";
            this.btn_deleteMasterSpent.Size = new System.Drawing.Size(63, 36);
            this.btn_deleteMasterSpent.TabIndex = 3;
            this.btn_deleteMasterSpent.Text = "حذف";
            this.btn_deleteMasterSpent.UseVisualStyleBackColor = false;
            this.btn_deleteMasterSpent.Click += new System.EventHandler(this.btn_deleteMasterSpent_Click);
            // 
            // btn_modifyMasterSpent
            // 
            this.btn_modifyMasterSpent.BackColor = System.Drawing.Color.Azure;
            this.btn_modifyMasterSpent.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_modifyMasterSpent.Location = new System.Drawing.Point(186, 31);
            this.btn_modifyMasterSpent.Name = "btn_modifyMasterSpent";
            this.btn_modifyMasterSpent.Size = new System.Drawing.Size(135, 36);
            this.btn_modifyMasterSpent.TabIndex = 1;
            this.btn_modifyMasterSpent.Text = "تغییر نام";
            this.btn_modifyMasterSpent.UseVisualStyleBackColor = false;
            this.btn_modifyMasterSpent.Click += new System.EventHandler(this.btn_modifyMasterSpent_Click);
            // 
            // btn_newMasterSpent
            // 
            this.btn_newMasterSpent.BackColor = System.Drawing.Color.Azure;
            this.btn_newMasterSpent.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_newMasterSpent.ForeColor = System.Drawing.Color.Green;
            this.btn_newMasterSpent.Location = new System.Drawing.Point(327, 31);
            this.btn_newMasterSpent.Name = "btn_newMasterSpent";
            this.btn_newMasterSpent.Size = new System.Drawing.Size(160, 36);
            this.btn_newMasterSpent.TabIndex = 0;
            this.btn_newMasterSpent.Text = "* سرفصل کل جدید";
            this.btn_newMasterSpent.UseVisualStyleBackColor = false;
            this.btn_newMasterSpent.Click += new System.EventHandler(this.btn_newMasterSpent_Click);
            // 
            // cmb_masterSpentName
            // 
            this.cmb_masterSpentName.DataSource = this.spentMasterBindingSource;
            this.cmb_masterSpentName.DisplayMember = "spentMasterName";
            this.cmb_masterSpentName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_masterSpentName.FormattingEnabled = true;
            this.cmb_masterSpentName.Location = new System.Drawing.Point(68, 80);
            this.cmb_masterSpentName.Name = "cmb_masterSpentName";
            this.cmb_masterSpentName.Size = new System.Drawing.Size(240, 34);
            this.cmb_masterSpentName.TabIndex = 4;
            this.cmb_masterSpentName.ValueMember = "spentMasterID";
            this.cmb_masterSpentName.SelectedIndexChanged += new System.EventHandler(this.cmb_masterSpentName_SelectedIndexChanged);
            this.cmb_masterSpentName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cmb_masterSpentName_KeyUp);
            this.cmb_masterSpentName.SelectedValueChanged += new System.EventHandler(this.cmb_masterSpentName_SelectedValueChanged);
            this.cmb_masterSpentName.DropDownClosed += new System.EventHandler(this.cmb_masterSpentName_DropDownClosed);
            // 
            // spentGroupsTableTableAdapter
            // 
            this.spentGroupsTableTableAdapter.ClearBeforeFill = true;
            // 
            // frm_manageSpentDefs
            // 
            this.AcceptButton = this.btn_ok;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::cactus_PS_.Properties.Resources.forms_template;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btn_ok;
            this.ClientSize = new System.Drawing.Size(555, 477);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grp_spentsDefins);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ok);
            this.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_manageSpentDefs";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "سرفصل های حسابداری";
            this.Load += new System.EventHandler(this.frm_manageSpentDefs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spentMasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSDatabase5DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spentDefBindingSource)).EndInit();
            this.grp_spentsDefins.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spentGroupsTableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_cancel;
        private PSDatabase5DataSet pSDatabase5DataSet;
        private System.Windows.Forms.BindingSource spentMasterBindingSource;
        private cactus_PS_.PSDatabase5DataSetTableAdapters.spentMasterTableAdapter spentMasterTableAdapter;
        private System.Windows.Forms.BindingSource spentDefBindingSource;
        private cactus_PS_.PSDatabase5DataSetTableAdapters.spentDefTableAdapter spentDefTableAdapter;
        private System.Windows.Forms.GroupBox grp_spentsDefins;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_renameSubSpent;
        private System.Windows.Forms.Button btn_defineNewSubSpent;
        private System.Windows.Forms.ListBox lst_subSpents;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_deleteMasterSpent;
        private System.Windows.Forms.Button btn_modifyMasterSpent;
        private System.Windows.Forms.Button btn_newMasterSpent;
        private System.Windows.Forms.ComboBox cmb_masterSpentName;
        private System.Windows.Forms.ComboBox cmb_detailType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_saveChanges;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_spentGroupKind;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_spentKind;
        private System.Windows.Forms.BindingSource spentGroupsTableBindingSource;
        private cactus_PS_.PSDatabase5DataSetTableAdapters.spentGroupsTableTableAdapter spentGroupsTableTableAdapter;
    }
}