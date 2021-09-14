namespace cactus_PS_
{
    partial class frm_info
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
            this.btn_saveChanges = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.pSDatabase5DataSet = new cactus_PS_.PSDatabase5DataSet();
            this.personsTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personsTableTableAdapter = new cactus_PS_.PSDatabase5DataSetTableAdapters.personsTableTableAdapter();
            this.grid_main = new System.Windows.Forms.DataGridView();
            this.personFamilyAndNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personPhone1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personPhone2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personAddress1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_doSearch = new System.Windows.Forms.Button();
            this.tbx_key = new System.Windows.Forms.TextBox();
            this.btn_showAll = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmb_searchBy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pSDatabase5DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_main)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_saveChanges
            // 
            this.btn_saveChanges.BackColor = System.Drawing.Color.Azure;
            this.btn_saveChanges.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_saveChanges.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_saveChanges.Location = new System.Drawing.Point(346, 23);
            this.btn_saveChanges.Name = "btn_saveChanges";
            this.btn_saveChanges.Size = new System.Drawing.Size(112, 39);
            this.btn_saveChanges.TabIndex = 2;
            this.btn_saveChanges.Text = "اصلاح";
            this.btn_saveChanges.UseVisualStyleBackColor = false;
            this.btn_saveChanges.Click += new System.EventHandler(this.btn_saveChanges_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Azure;
            this.btn_delete.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_delete.Location = new System.Drawing.Point(157, 23);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(175, 39);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "حذف";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_new
            // 
            this.btn_new.BackColor = System.Drawing.Color.Azure;
            this.btn_new.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_new.ForeColor = System.Drawing.Color.Green;
            this.btn_new.Location = new System.Drawing.Point(472, 22);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(175, 40);
            this.btn_new.TabIndex = 1;
            this.btn_new.Text = "* جدید";
            this.btn_new.UseVisualStyleBackColor = false;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // pSDatabase5DataSet
            // 
            this.pSDatabase5DataSet.DataSetName = "PSDatabase5DataSet";
            this.pSDatabase5DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personsTableBindingSource
            // 
            this.personsTableBindingSource.DataMember = "personsTable";
            this.personsTableBindingSource.DataSource = this.pSDatabase5DataSet;
            // 
            // personsTableTableAdapter
            // 
            this.personsTableTableAdapter.ClearBeforeFill = true;
            // 
            // grid_main
            // 
            this.grid_main.AllowUserToAddRows = false;
            this.grid_main.AllowUserToDeleteRows = false;
            this.grid_main.AutoGenerateColumns = false;
            this.grid_main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_main.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personFamilyAndNameDataGridViewTextBoxColumn,
            this.personPhone1DataGridViewTextBoxColumn,
            this.personPhone2DataGridViewTextBoxColumn,
            this.jobDataGridViewTextBoxColumn,
            this.personAddress1DataGridViewTextBoxColumn});
            this.grid_main.DataSource = this.personsTableBindingSource;
            this.grid_main.Location = new System.Drawing.Point(38, 134);
            this.grid_main.Name = "grid_main";
            this.grid_main.ReadOnly = true;
            this.grid_main.RowTemplate.Height = 30;
            this.grid_main.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_main.Size = new System.Drawing.Size(738, 286);
            this.grid_main.StandardTab = true;
            this.grid_main.TabIndex = 4;
            this.grid_main.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_main_CellDoubleClick);
            this.grid_main.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grid_main_KeyDown);
            // 
            // personFamilyAndNameDataGridViewTextBoxColumn
            // 
            this.personFamilyAndNameDataGridViewTextBoxColumn.DataPropertyName = "personFamilyAndName";
            this.personFamilyAndNameDataGridViewTextBoxColumn.HeaderText = "نام و نام خانوادگی";
            this.personFamilyAndNameDataGridViewTextBoxColumn.Name = "personFamilyAndNameDataGridViewTextBoxColumn";
            this.personFamilyAndNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.personFamilyAndNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // personPhone1DataGridViewTextBoxColumn
            // 
            this.personPhone1DataGridViewTextBoxColumn.DataPropertyName = "personPhone1";
            this.personPhone1DataGridViewTextBoxColumn.HeaderText = "تلفن";
            this.personPhone1DataGridViewTextBoxColumn.Name = "personPhone1DataGridViewTextBoxColumn";
            this.personPhone1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personPhone2DataGridViewTextBoxColumn
            // 
            this.personPhone2DataGridViewTextBoxColumn.DataPropertyName = "personPhone2";
            this.personPhone2DataGridViewTextBoxColumn.HeaderText = "همراه";
            this.personPhone2DataGridViewTextBoxColumn.Name = "personPhone2DataGridViewTextBoxColumn";
            this.personPhone2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jobDataGridViewTextBoxColumn
            // 
            this.jobDataGridViewTextBoxColumn.DataPropertyName = "job";
            this.jobDataGridViewTextBoxColumn.HeaderText = "سمت";
            this.jobDataGridViewTextBoxColumn.Name = "jobDataGridViewTextBoxColumn";
            this.jobDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personAddress1DataGridViewTextBoxColumn
            // 
            this.personAddress1DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.personAddress1DataGridViewTextBoxColumn.DataPropertyName = "personAddress1";
            this.personAddress1DataGridViewTextBoxColumn.HeaderText = "آدرس";
            this.personAddress1DataGridViewTextBoxColumn.Name = "personAddress1DataGridViewTextBoxColumn";
            this.personAddress1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // btn_doSearch
            // 
            this.btn_doSearch.BackColor = System.Drawing.Color.Azure;
            this.btn_doSearch.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_doSearch.ForeColor = System.Drawing.Color.Black;
            this.btn_doSearch.Location = new System.Drawing.Point(138, 4);
            this.btn_doSearch.Name = "btn_doSearch";
            this.btn_doSearch.Size = new System.Drawing.Size(93, 39);
            this.btn_doSearch.TabIndex = 2;
            this.btn_doSearch.Text = "پیدا کن";
            this.btn_doSearch.UseVisualStyleBackColor = false;
            this.btn_doSearch.Click += new System.EventHandler(this.btn_doSearch_Click);
            // 
            // tbx_key
            // 
            this.tbx_key.Location = new System.Drawing.Point(499, 4);
            this.tbx_key.Name = "tbx_key";
            this.tbx_key.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbx_key.Size = new System.Drawing.Size(195, 38);
            this.tbx_key.TabIndex = 0;
            this.tbx_key.TextChanged += new System.EventHandler(this.tbx_key_TextChanged);
            this.tbx_key.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbx_key_KeyDown);
            // 
            // btn_showAll
            // 
            this.btn_showAll.BackColor = System.Drawing.Color.Azure;
            this.btn_showAll.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_showAll.ForeColor = System.Drawing.Color.Black;
            this.btn_showAll.Location = new System.Drawing.Point(6, 4);
            this.btn_showAll.Name = "btn_showAll";
            this.btn_showAll.Size = new System.Drawing.Size(91, 39);
            this.btn_showAll.TabIndex = 3;
            this.btn_showAll.Text = "نمایش همه";
            this.btn_showAll.UseVisualStyleBackColor = false;
            this.btn_showAll.Click += new System.EventHandler(this.btn_showAll_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.cmb_searchBy);
            this.panel1.Controls.Add(this.btn_showAll);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_doSearch);
            this.panel1.Controls.Add(this.tbx_key);
            this.panel1.Location = new System.Drawing.Point(52, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(701, 47);
            this.panel1.TabIndex = 0;
            // 
            // cmb_searchBy
            // 
            this.cmb_searchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_searchBy.FormattingEnabled = true;
            this.cmb_searchBy.Items.AddRange(new object[] {
            "نام و نام خانوادگی",
            "شماره تلفن",
            "همراه",
            "سمت",
            "آدرس"});
            this.cmb_searchBy.Location = new System.Drawing.Point(237, 4);
            this.cmb_searchBy.Name = "cmb_searchBy";
            this.cmb_searchBy.Size = new System.Drawing.Size(164, 38);
            this.cmb_searchBy.TabIndex = 1;
            this.cmb_searchBy.SelectionChangeCommitted += new System.EventHandler(this.cmb_searchBy_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(407, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 30);
            this.label1.TabIndex = 103;
            this.label1.Text = "را  براساس :";
            // 
            // frm_info
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::cactus_PS_.Properties.Resources.forms_template1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(804, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grid_main);
            this.Controls.Add(this.btn_saveChanges);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_new);
            this.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_info";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "دفترچه تلفن";
            this.Load += new System.EventHandler(this.frm_info_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_info_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pSDatabase5DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_main)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_saveChanges;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_new;
        private PSDatabase5DataSet pSDatabase5DataSet;
        private System.Windows.Forms.BindingSource personsTableBindingSource;
        private cactus_PS_.PSDatabase5DataSetTableAdapters.personsTableTableAdapter personsTableTableAdapter;
        private System.Windows.Forms.DataGridView grid_main;
        private System.Windows.Forms.Button btn_doSearch;
        private System.Windows.Forms.TextBox tbx_key;
        private System.Windows.Forms.Button btn_showAll;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_searchBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn personFamilyAndNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personPhone1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personPhone2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personAddress1DataGridViewTextBoxColumn;
    }
}