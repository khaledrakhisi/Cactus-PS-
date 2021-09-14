namespace cactus_PS_
{
    partial class frm_editAccDocEvent
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
            this.cmb_detail = new System.Windows.Forms.ComboBox();
            this.viwdetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pSDatabase5DataSet = new cactus_PS_.PSDatabase5DataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbx_indebted = new System.Windows.Forms.TextBox();
            this.tbx_creditor = new System.Windows.Forms.TextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.pnl_detail = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_detailID = new System.Windows.Forms.Label();
            this.viw_detailsTableAdapter = new cactus_PS_.PSDatabase5DataSetTableAdapters.viw_detailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.viwdetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSDatabase5DataSet)).BeginInit();
            this.pnl_detail.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_detail
            // 
            this.cmb_detail.DataSource = this.viwdetailsBindingSource;
            this.cmb_detail.DisplayMember = "fullDetailName";
            this.cmb_detail.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_detail.FormattingEnabled = true;
            this.cmb_detail.Location = new System.Drawing.Point(2, 40);
            this.cmb_detail.Name = "cmb_detail";
            this.cmb_detail.Size = new System.Drawing.Size(273, 34);
            this.cmb_detail.TabIndex = 0;
            this.cmb_detail.ValueMember = "detailID";
            this.cmb_detail.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmb_detail_MouseClick);
            this.cmb_detail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_detail_KeyPress);
            this.cmb_detail.DropDownClosed += new System.EventHandler(this.cmb_detail_DropDownClosed);
            this.cmb_detail.Click += new System.EventHandler(this.cmb_detail_Click);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(185, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 26);
            this.label2.TabIndex = 111;
            this.label2.Text = "بدهکار :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(58, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 26);
            this.label4.TabIndex = 112;
            this.label4.Text = "بستانکار :";
            // 
            // tbx_indebted
            // 
            this.tbx_indebted.Location = new System.Drawing.Point(156, 46);
            this.tbx_indebted.Name = "tbx_indebted";
            this.tbx_indebted.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_indebted.Size = new System.Drawing.Size(118, 33);
            this.tbx_indebted.TabIndex = 1;
            this.tbx_indebted.Text = "0";
            this.tbx_indebted.TextChanged += new System.EventHandler(this.tbx_indebted_TextChanged);
            // 
            // tbx_creditor
            // 
            this.tbx_creditor.Location = new System.Drawing.Point(27, 47);
            this.tbx_creditor.Name = "tbx_creditor";
            this.tbx_creditor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_creditor.Size = new System.Drawing.Size(123, 33);
            this.tbx_creditor.TabIndex = 2;
            this.tbx_creditor.Text = "0";
            this.tbx_creditor.TextChanged += new System.EventHandler(this.tbx_creditor_TextChanged);
            // 
            // btn_ok
            // 
            this.btn_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_ok.Location = new System.Drawing.Point(181, 109);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(370, 34);
            this.btn_ok.TabIndex = 3;
            this.btn_ok.Text = "تائـــیـــد";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(33, 109);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(130, 34);
            this.btn_cancel.TabIndex = 4;
            this.btn_cancel.Text = "لغو";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // pnl_detail
            // 
            this.pnl_detail.BackColor = System.Drawing.Color.Transparent;
            this.pnl_detail.Controls.Add(this.label1);
            this.pnl_detail.Controls.Add(this.cmb_detail);
            this.pnl_detail.Location = new System.Drawing.Point(280, 5);
            this.pnl_detail.Name = "pnl_detail";
            this.pnl_detail.Size = new System.Drawing.Size(278, 80);
            this.pnl_detail.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 26);
            this.label1.TabIndex = 110;
            this.label1.Text = "ســـــرفصل حسابداری";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_detailID
            // 
            this.lbl_detailID.AutoSize = true;
            this.lbl_detailID.BackColor = System.Drawing.Color.Transparent;
            this.lbl_detailID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.viwdetailsBindingSource, "detailID", true));
            this.lbl_detailID.Location = new System.Drawing.Point(590, 45);
            this.lbl_detailID.Name = "lbl_detailID";
            this.lbl_detailID.Size = new System.Drawing.Size(85, 26);
            this.lbl_detailID.TabIndex = 120;
            this.lbl_detailID.Text = "detail-id";
            // 
            // viw_detailsTableAdapter
            // 
            this.viw_detailsTableAdapter.ClearBeforeFill = true;
            // 
            // frm_editAccDocEvent
            // 
            this.AcceptButton = this.btn_ok;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::cactus_PS_.Properties.Resources.forms_template;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(584, 155);
            this.Controls.Add(this.lbl_detailID);
            this.Controls.Add(this.pnl_detail);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.tbx_creditor);
            this.Controls.Add(this.tbx_indebted);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_editAccDocEvent";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frm_editAccDocEvent_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_editAccDocEvent_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.viwdetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSDatabase5DataSet)).EndInit();
            this.pnl_detail.ResumeLayout(false);
            this.pnl_detail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_cancel;
        private PSDatabase5DataSet pSDatabase5DataSet;
        public System.Windows.Forms.TextBox tbx_indebted;
        public System.Windows.Forms.TextBox tbx_creditor;
        public System.Windows.Forms.Label lbl_detailID;
        public System.Windows.Forms.ComboBox cmb_detail;
        public System.Windows.Forms.Panel pnl_detail;
        private System.Windows.Forms.BindingSource viwdetailsBindingSource;
        private cactus_PS_.PSDatabase5DataSetTableAdapters.viw_detailsTableAdapter viw_detailsTableAdapter;
        private System.Windows.Forms.Label label1;
    }
}