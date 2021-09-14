namespace cactus_PS_
{
    partial class frm_spents
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
            this.cmb_spentType = new System.Windows.Forms.ComboBox();
            this.spentMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pSDatabase5DataSet = new cactus_PS_.PSDatabase5DataSet();
            this.btn_ok = new System.Windows.Forms.Button();
            this.grp_totals = new System.Windows.Forms.GroupBox();
            this.lbl_totalRemainINCHARS = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbx_remainTotalPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_creditorTotalPrice = new System.Windows.Forms.TextBox();
            this.tbx_indebtedTotalPrice = new System.Windows.Forms.TextBox();
            this.grid_spents = new System.Windows.Forms.DataGridView();
            this.lbl_chequesNumbers = new System.Windows.Forms.Label();
            this.pnl_buttons = new System.Windows.Forms.Panel();
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_deleteRecord = new System.Windows.Forms.Button();
            this.btn_modifyRecord = new System.Windows.Forms.Button();
            this.btn_addRecord = new System.Windows.Forms.Button();
            this.pnl_spentSubGroup = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_spentSubGroup = new System.Windows.Forms.ComboBox();
            this.spentDefBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spentsTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spentsTableTableAdapter = new cactus_PS_.PSDatabase5DataSetTableAdapters.spentsTableTableAdapter();
            this.chequesTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chequesTableTableAdapter = new cactus_PS_.PSDatabase5DataSetTableAdapters.chequesTableTableAdapter();
            this.spentMasterTableAdapter = new cactus_PS_.PSDatabase5DataSetTableAdapters.spentMasterTableAdapter();
            this.spentDefTableAdapter = new cactus_PS_.PSDatabase5DataSetTableAdapters.spentDefTableAdapter();
            this.lbl_subSpentID = new System.Windows.Forms.Label();
            this.chk_chooseSubSpent = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.spentMasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSDatabase5DataSet)).BeginInit();
            this.grp_totals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_spents)).BeginInit();
            this.pnl_buttons.SuspendLayout();
            this.pnl_spentSubGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spentDefBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spentsTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chequesTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_spentType
            // 
            this.cmb_spentType.DataSource = this.spentMasterBindingSource;
            this.cmb_spentType.DisplayMember = "spentMasterName";
            this.cmb_spentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_spentType.FormattingEnabled = true;
            this.cmb_spentType.Location = new System.Drawing.Point(29, 6);
            this.cmb_spentType.Name = "cmb_spentType";
            this.cmb_spentType.Size = new System.Drawing.Size(193, 38);
            this.cmb_spentType.TabIndex = 0;
            this.cmb_spentType.ValueMember = "spentMasterID";
            this.cmb_spentType.SelectionChangeCommitted += new System.EventHandler(this.cmb_spentType_SelectionChangeCommitted);
            this.cmb_spentType.SelectedIndexChanged += new System.EventHandler(this.cmb_spentType_SelectedIndexChanged);
            this.cmb_spentType.SelectedValueChanged += new System.EventHandler(this.cmb_spentType_SelectedValueChanged);
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
            // btn_ok
            // 
            this.btn_ok.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_ok.Font = new System.Drawing.Font("B Titr", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_ok.Image = global::cactus_PS_.Properties.Resources.OOFL;
            this.btn_ok.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ok.Location = new System.Drawing.Point(12, 573);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(131, 39);
            this.btn_ok.TabIndex = 3;
            this.btn_ok.Text = "بستن";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // grp_totals
            // 
            this.grp_totals.Controls.Add(this.lbl_totalRemainINCHARS);
            this.grp_totals.Controls.Add(this.label4);
            this.grp_totals.Controls.Add(this.tbx_remainTotalPrice);
            this.grp_totals.Controls.Add(this.label3);
            this.grp_totals.Controls.Add(this.label2);
            this.grp_totals.Controls.Add(this.tbx_creditorTotalPrice);
            this.grp_totals.Controls.Add(this.tbx_indebtedTotalPrice);
            this.grp_totals.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grp_totals.Location = new System.Drawing.Point(173, 494);
            this.grp_totals.Name = "grp_totals";
            this.grp_totals.Size = new System.Drawing.Size(664, 115);
            this.grp_totals.TabIndex = 8;
            this.grp_totals.TabStop = false;
            this.grp_totals.Text = "جمع";
            // 
            // lbl_totalRemainINCHARS
            // 
            this.lbl_totalRemainINCHARS.Font = new System.Drawing.Font("B Titr", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_totalRemainINCHARS.ForeColor = System.Drawing.Color.Red;
            this.lbl_totalRemainINCHARS.Location = new System.Drawing.Point(6, 76);
            this.lbl_totalRemainINCHARS.Name = "lbl_totalRemainINCHARS";
            this.lbl_totalRemainINCHARS.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_totalRemainINCHARS.Size = new System.Drawing.Size(647, 30);
            this.lbl_totalRemainINCHARS.TabIndex = 23;
            this.lbl_totalRemainINCHARS.Text = "بدهکاری";
            this.lbl_totalRemainINCHARS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 30);
            this.label4.TabIndex = 13;
            this.label4.Text = "مانده";
            // 
            // tbx_remainTotalPrice
            // 
            this.tbx_remainTotalPrice.Location = new System.Drawing.Point(6, 37);
            this.tbx_remainTotalPrice.Name = "tbx_remainTotalPrice";
            this.tbx_remainTotalPrice.ReadOnly = true;
            this.tbx_remainTotalPrice.Size = new System.Drawing.Size(132, 38);
            this.tbx_remainTotalPrice.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(588, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 30);
            this.label3.TabIndex = 11;
            this.label3.Text = "بدهکاری";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 30);
            this.label2.TabIndex = 10;
            this.label2.Text = "بستانکاری";
            // 
            // tbx_creditorTotalPrice
            // 
            this.tbx_creditorTotalPrice.Location = new System.Drawing.Point(213, 37);
            this.tbx_creditorTotalPrice.Name = "tbx_creditorTotalPrice";
            this.tbx_creditorTotalPrice.ReadOnly = true;
            this.tbx_creditorTotalPrice.Size = new System.Drawing.Size(132, 38);
            this.tbx_creditorTotalPrice.TabIndex = 9;
            // 
            // tbx_indebtedTotalPrice
            // 
            this.tbx_indebtedTotalPrice.Location = new System.Drawing.Point(450, 37);
            this.tbx_indebtedTotalPrice.Name = "tbx_indebtedTotalPrice";
            this.tbx_indebtedTotalPrice.ReadOnly = true;
            this.tbx_indebtedTotalPrice.Size = new System.Drawing.Size(132, 38);
            this.tbx_indebtedTotalPrice.TabIndex = 8;
            // 
            // grid_spents
            // 
            this.grid_spents.AllowUserToAddRows = false;
            this.grid_spents.AllowUserToDeleteRows = false;
            this.grid_spents.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.grid_spents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_spents.GridColor = System.Drawing.Color.DimGray;
            this.grid_spents.Location = new System.Drawing.Point(12, 104);
            this.grid_spents.Name = "grid_spents";
            this.grid_spents.ReadOnly = true;
            this.grid_spents.RowTemplate.Height = 30;
            this.grid_spents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_spents.Size = new System.Drawing.Size(830, 395);
            this.grid_spents.StandardTab = true;
            this.grid_spents.TabIndex = 2;
            this.grid_spents.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_spents_RowEnter);
            this.grid_spents.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_spents_CellDoubleClick);
            this.grid_spents.MouseUp += new System.Windows.Forms.MouseEventHandler(this.grid_spents_MouseUp);
            this.grid_spents.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grid_spents_KeyDown);
            this.grid_spents.SelectionChanged += new System.EventHandler(this.grid_spents_SelectionChanged);
            this.grid_spents.KeyUp += new System.Windows.Forms.KeyEventHandler(this.grid_spents_KeyUp);
            // 
            // lbl_chequesNumbers
            // 
            this.lbl_chequesNumbers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_chequesNumbers.Location = new System.Drawing.Point(313, 65);
            this.lbl_chequesNumbers.Name = "lbl_chequesNumbers";
            this.lbl_chequesNumbers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_chequesNumbers.Size = new System.Drawing.Size(524, 36);
            this.lbl_chequesNumbers.TabIndex = 15;
            this.lbl_chequesNumbers.Text = "----";
            this.lbl_chequesNumbers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_chequesNumbers.Click += new System.EventHandler(this.lbl_chequesNumbers_Click);
            // 
            // pnl_buttons
            // 
            this.pnl_buttons.Controls.Add(this.btn_print);
            this.pnl_buttons.Controls.Add(this.btn_deleteRecord);
            this.pnl_buttons.Controls.Add(this.btn_modifyRecord);
            this.pnl_buttons.Controls.Add(this.btn_addRecord);
            this.pnl_buttons.Location = new System.Drawing.Point(382, 12);
            this.pnl_buttons.Name = "pnl_buttons";
            this.pnl_buttons.Size = new System.Drawing.Size(460, 60);
            this.pnl_buttons.TabIndex = 3;
            // 
            // btn_print
            // 
            this.btn_print.BackColor = System.Drawing.Color.Azure;
            this.btn_print.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_print.ForeColor = System.Drawing.Color.DarkViolet;
            this.btn_print.Location = new System.Drawing.Point(9, 9);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(106, 41);
            this.btn_print.TabIndex = 3;
            this.btn_print.Text = "چاپ";
            this.btn_print.UseVisualStyleBackColor = false;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // btn_deleteRecord
            // 
            this.btn_deleteRecord.BackColor = System.Drawing.Color.Azure;
            this.btn_deleteRecord.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_deleteRecord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_deleteRecord.Location = new System.Drawing.Point(121, 9);
            this.btn_deleteRecord.Name = "btn_deleteRecord";
            this.btn_deleteRecord.Size = new System.Drawing.Size(106, 41);
            this.btn_deleteRecord.TabIndex = 2;
            this.btn_deleteRecord.Text = "حذف سطر";
            this.btn_deleteRecord.UseVisualStyleBackColor = false;
            this.btn_deleteRecord.Click += new System.EventHandler(this.btn_deleteRecord_Click);
            // 
            // btn_modifyRecord
            // 
            this.btn_modifyRecord.BackColor = System.Drawing.Color.Azure;
            this.btn_modifyRecord.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_modifyRecord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_modifyRecord.Location = new System.Drawing.Point(233, 9);
            this.btn_modifyRecord.Name = "btn_modifyRecord";
            this.btn_modifyRecord.Size = new System.Drawing.Size(106, 41);
            this.btn_modifyRecord.TabIndex = 1;
            this.btn_modifyRecord.Text = "اصلاح سطر";
            this.btn_modifyRecord.UseVisualStyleBackColor = false;
            this.btn_modifyRecord.Click += new System.EventHandler(this.btn_modifyRecord_Click);
            // 
            // btn_addRecord
            // 
            this.btn_addRecord.BackColor = System.Drawing.Color.Azure;
            this.btn_addRecord.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_addRecord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_addRecord.Location = new System.Drawing.Point(345, 9);
            this.btn_addRecord.Name = "btn_addRecord";
            this.btn_addRecord.Size = new System.Drawing.Size(106, 41);
            this.btn_addRecord.TabIndex = 0;
            this.btn_addRecord.Text = "* سطر جدید";
            this.btn_addRecord.UseVisualStyleBackColor = false;
            this.btn_addRecord.Click += new System.EventHandler(this.btn_addRecord_Click);
            // 
            // pnl_spentSubGroup
            // 
            this.pnl_spentSubGroup.Controls.Add(this.label5);
            this.pnl_spentSubGroup.Controls.Add(this.cmb_spentSubGroup);
            this.pnl_spentSubGroup.Location = new System.Drawing.Point(12, 50);
            this.pnl_spentSubGroup.Name = "pnl_spentSubGroup";
            this.pnl_spentSubGroup.Size = new System.Drawing.Size(295, 51);
            this.pnl_spentSubGroup.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(224, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 30);
            this.label5.TabIndex = 20;
            this.label5.Text = "زیر گروه";
            // 
            // cmb_spentSubGroup
            // 
            this.cmb_spentSubGroup.DataSource = this.spentDefBindingSource;
            this.cmb_spentSubGroup.DisplayMember = "spentDefName";
            this.cmb_spentSubGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_spentSubGroup.FormattingEnabled = true;
            this.cmb_spentSubGroup.Location = new System.Drawing.Point(17, 3);
            this.cmb_spentSubGroup.Name = "cmb_spentSubGroup";
            this.cmb_spentSubGroup.Size = new System.Drawing.Size(193, 38);
            this.cmb_spentSubGroup.TabIndex = 0;
            this.cmb_spentSubGroup.ValueMember = "spentDefID";
            this.cmb_spentSubGroup.SelectionChangeCommitted += new System.EventHandler(this.cmb_spentSubGroup_SelectionChangeCommitted);
            this.cmb_spentSubGroup.SelectedValueChanged += new System.EventHandler(this.cmb_spentSubGroup_SelectedValueChanged);
            // 
            // spentDefBindingSource
            // 
            this.spentDefBindingSource.DataMember = "spentDef";
            this.spentDefBindingSource.DataSource = this.pSDatabase5DataSet;
            // 
            // spentsTableBindingSource
            // 
            this.spentsTableBindingSource.DataMember = "spentsTable";
            this.spentsTableBindingSource.DataSource = this.pSDatabase5DataSet;
            // 
            // spentsTableTableAdapter
            // 
            this.spentsTableTableAdapter.ClearBeforeFill = true;
            // 
            // chequesTableBindingSource
            // 
            this.chequesTableBindingSource.DataMember = "chequesTable";
            this.chequesTableBindingSource.DataSource = this.pSDatabase5DataSet;
            // 
            // chequesTableTableAdapter
            // 
            this.chequesTableTableAdapter.ClearBeforeFill = true;
            // 
            // spentMasterTableAdapter
            // 
            this.spentMasterTableAdapter.ClearBeforeFill = true;
            // 
            // spentDefTableAdapter
            // 
            this.spentDefTableAdapter.ClearBeforeFill = true;
            // 
            // lbl_subSpentID
            // 
            this.lbl_subSpentID.AutoSize = true;
            this.lbl_subSpentID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spentDefBindingSource, "spentDefID", true));
            this.lbl_subSpentID.Location = new System.Drawing.Point(65, 119);
            this.lbl_subSpentID.Name = "lbl_subSpentID";
            this.lbl_subSpentID.Size = new System.Drawing.Size(68, 30);
            this.lbl_subSpentID.TabIndex = 21;
            this.lbl_subSpentID.Text = "زیر گروه";
            this.lbl_subSpentID.TextChanged += new System.EventHandler(this.lbl_subSpentID_TextChanged);
            this.lbl_subSpentID.Click += new System.EventHandler(this.lbl_subSpentID_Click);
            // 
            // chk_chooseSubSpent
            // 
            this.chk_chooseSubSpent.AutoSize = true;
            this.chk_chooseSubSpent.Checked = true;
            this.chk_chooseSubSpent.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_chooseSubSpent.Location = new System.Drawing.Point(228, 6);
            this.chk_chooseSubSpent.Name = "chk_chooseSubSpent";
            this.chk_chooseSubSpent.Size = new System.Drawing.Size(97, 34);
            this.chk_chooseSubSpent.TabIndex = 22;
            this.chk_chooseSubSpent.Text = "نوع هزینه";
            this.chk_chooseSubSpent.UseVisualStyleBackColor = true;
            this.chk_chooseSubSpent.CheckedChanged += new System.EventHandler(this.chk_chooseSubSpent_CheckedChanged);
            // 
            // frm_spents
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.btn_ok;
            this.ClientSize = new System.Drawing.Size(854, 621);
            this.Controls.Add(this.lbl_chequesNumbers);
            this.Controls.Add(this.chk_chooseSubSpent);
            this.Controls.Add(this.pnl_spentSubGroup);
            this.Controls.Add(this.pnl_buttons);
            this.Controls.Add(this.grid_spents);
            this.Controls.Add(this.grp_totals);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.cmb_spentType);
            this.Controls.Add(this.lbl_subSpentID);
            this.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(10, 10);
            this.Name = "frm_spents";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "هزینه های پروژه";
            this.Load += new System.EventHandler(this.frm_spents_Load);
            this.Shown += new System.EventHandler(this.frm_spents_Shown);
            this.Resize += new System.EventHandler(this.frm_spents_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.spentMasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSDatabase5DataSet)).EndInit();
            this.grp_totals.ResumeLayout(false);
            this.grp_totals.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_spents)).EndInit();
            this.pnl_buttons.ResumeLayout(false);
            this.pnl_spentSubGroup.ResumeLayout(false);
            this.pnl_spentSubGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spentDefBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spentsTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chequesTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_spentType;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.GroupBox grp_totals;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_creditorTotalPrice;
        private System.Windows.Forms.TextBox tbx_indebtedTotalPrice;
        private PSDatabase5DataSet pSDatabase5DataSet;
        private System.Windows.Forms.BindingSource spentsTableBindingSource;
        private cactus_PS_.PSDatabase5DataSetTableAdapters.spentsTableTableAdapter spentsTableTableAdapter;
        private System.Windows.Forms.DataGridView grid_spents;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbx_remainTotalPrice;
        private System.Windows.Forms.BindingSource chequesTableBindingSource;
        private cactus_PS_.PSDatabase5DataSetTableAdapters.chequesTableTableAdapter chequesTableTableAdapter;
        private System.Windows.Forms.Label lbl_chequesNumbers;
        private System.Windows.Forms.Panel pnl_buttons;
        private System.Windows.Forms.Button btn_deleteRecord;
        private System.Windows.Forms.Button btn_modifyRecord;
        private System.Windows.Forms.Button btn_addRecord;
        private System.Windows.Forms.Panel pnl_spentSubGroup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_spentSubGroup;
        private System.Windows.Forms.BindingSource spentMasterBindingSource;
        private cactus_PS_.PSDatabase5DataSetTableAdapters.spentMasterTableAdapter spentMasterTableAdapter;
        private System.Windows.Forms.BindingSource spentDefBindingSource;
        private cactus_PS_.PSDatabase5DataSetTableAdapters.spentDefTableAdapter spentDefTableAdapter;
        private System.Windows.Forms.Label lbl_subSpentID;
        private System.Windows.Forms.CheckBox chk_chooseSubSpent;
        private System.Windows.Forms.Label lbl_totalRemainINCHARS;
        private System.Windows.Forms.Button btn_print;
    }
}