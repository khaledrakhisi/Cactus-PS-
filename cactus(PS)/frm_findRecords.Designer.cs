namespace cactus_PS_
{
    partial class frm_findRecords
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
            this.lst_FoundRecords = new System.Windows.Forms.ListBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.tbx_Key = new System.Windows.Forms.TextBox();
            this.psDatabase5DataSet1 = new cactus_PS_.PSDatabase5DataSet();
            this.tbx_ID = new System.Windows.Forms.TextBox();
            this.chk_doInnerSearch = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.psDatabase5DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // lst_FoundRecords
            // 
            this.lst_FoundRecords.DataSource = this.bindingSource1;
            this.lst_FoundRecords.FormattingEnabled = true;
            this.lst_FoundRecords.ItemHeight = 28;
            this.lst_FoundRecords.Location = new System.Drawing.Point(21, 64);
            this.lst_FoundRecords.Name = "lst_FoundRecords";
            this.lst_FoundRecords.Size = new System.Drawing.Size(247, 256);
            this.lst_FoundRecords.TabIndex = 0;
            this.lst_FoundRecords.SelectedIndexChanged += new System.EventHandler(this.lst_FoundRecords_SelectedIndexChanged);
            this.lst_FoundRecords.DoubleClick += new System.EventHandler(this.lst_FoundRecords_DoubleClick);
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(119, 326);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(138, 35);
            this.btn_ok.TabIndex = 1;
            this.btn_ok.Text = "تائید";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(31, 326);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(82, 35);
            this.btn_Cancel.TabIndex = 2;
            this.btn_Cancel.Text = "لغو";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // tbx_Key
            // 
            this.tbx_Key.BackColor = System.Drawing.Color.AliceBlue;
            this.tbx_Key.Location = new System.Drawing.Point(21, 22);
            this.tbx_Key.Name = "tbx_Key";
            this.tbx_Key.Size = new System.Drawing.Size(196, 36);
            this.tbx_Key.TabIndex = 0;
            this.tbx_Key.TextChanged += new System.EventHandler(this.tbx_Key_TextChanged);
            this.tbx_Key.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbx_Key_KeyDown);
            // 
            // psDatabase5DataSet1
            // 
            this.psDatabase5DataSet1.DataSetName = "PSDatabase5DataSet";
            this.psDatabase5DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbx_ID
            // 
            this.tbx_ID.Location = new System.Drawing.Point(322, 65);
            this.tbx_ID.Name = "tbx_ID";
            this.tbx_ID.ReadOnly = true;
            this.tbx_ID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_ID.Size = new System.Drawing.Size(54, 36);
            this.tbx_ID.TabIndex = 3;
            this.tbx_ID.TabStop = false;
            // 
            // chk_doInnerSearch
            // 
            this.chk_doInnerSearch.Appearance = System.Windows.Forms.Appearance.Button;
            this.chk_doInnerSearch.Checked = true;
            this.chk_doInnerSearch.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_doInnerSearch.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.chk_doInnerSearch.Location = new System.Drawing.Point(223, 24);
            this.chk_doInnerSearch.Name = "chk_doInnerSearch";
            this.chk_doInnerSearch.Size = new System.Drawing.Size(45, 34);
            this.chk_doInnerSearch.TabIndex = 4;
            this.chk_doInnerSearch.Text = " @";
            this.toolTip1.SetToolTip(this.chk_doInnerSearch, "جستجو در کل رکورد -- F2");
            this.chk_doInnerSearch.UseVisualStyleBackColor = true;
            this.chk_doInnerSearch.Click += new System.EventHandler(this.chk_doInnerSearch_Click);
            this.chk_doInnerSearch.CheckedChanged += new System.EventHandler(this.chk_doInnerSearch_CheckedChanged);
            // 
            // frm_findRecords
            // 
            this.AcceptButton = this.btn_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::cactus_PS_.Properties.Resources.forms_template;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btn_Cancel;
            this.ClientSize = new System.Drawing.Size(288, 383);
            this.Controls.Add(this.chk_doInnerSearch);
            this.Controls.Add(this.tbx_ID);
            this.Controls.Add(this.tbx_Key);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.lst_FoundRecords);
            this.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_findRecords";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "جست و جو ...";
            this.Load += new System.EventHandler(this.frm_findRecords_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_findRecords_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_findRecords_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.psDatabase5DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.TextBox tbx_Key;
        public System.Windows.Forms.ListBox lst_FoundRecords;
        public System.Windows.Forms.BindingSource bindingSource1;
        public PSDatabase5DataSet psDatabase5DataSet1;
        private System.Windows.Forms.TextBox tbx_ID;
        private System.Windows.Forms.CheckBox chk_doInnerSearch;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}