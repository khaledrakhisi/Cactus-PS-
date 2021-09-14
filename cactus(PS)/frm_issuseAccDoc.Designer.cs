namespace cactus_PS_
{
    partial class frm_issuseAccDoc
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.num_accDocNumber = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.mTbx_Date = new System.Windows.Forms.MaskedTextBox();
            this.pSDatabase5DataSet = new cactus_PS_.PSDatabase5DataSet();
            this.tbx_indebtedPrice = new System.Windows.Forms.TextBox();
            this.accDocEventsTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbx_creditorPrice = new System.Windows.Forms.TextBox();
            this.btn_defineCheque = new System.Windows.Forms.Button();
            this.lbl_priceInChars = new System.Windows.Forms.Label();
            this.tbx_comment = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.accDocEventsTableTableAdapter = new cactus_PS_.PSDatabase5DataSetTableAdapters.accDocEventsTableTableAdapter();
            this.accountingDocsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountingDocsTableAdapter = new cactus_PS_.PSDatabase5DataSetTableAdapters.AccountingDocsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.num_accDocNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSDatabase5DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accDocEventsTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingDocsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(341, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "شماره سند :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(118, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "تاریخ سند :";
            // 
            // num_accDocNumber
            // 
            this.num_accDocNumber.Location = new System.Drawing.Point(239, 28);
            this.num_accDocNumber.Maximum = new decimal(new int[] {
            5000000,
            0,
            0,
            0});
            this.num_accDocNumber.Name = "num_accDocNumber";
            this.num_accDocNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.num_accDocNumber.Size = new System.Drawing.Size(78, 33);
            this.num_accDocNumber.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(19, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(405, 87);
            this.label3.TabIndex = 4;
            this.label3.Text = "* شماره سند حسابداری بعدی یک رقم افزایش پیدا می کند\r\n* اصلاح سند صادر شده به صورت" +
                " خودکار انجام می شود\r\n* حذف سند نیز به صورت خودکار انجام می شود\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(154, 340);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(260, 39);
            this.btn_ok.TabIndex = 7;
            this.btn_ok.Text = "ثبت سند";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(31, 340);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(117, 39);
            this.btn_cancel.TabIndex = 8;
            this.btn_cancel.Text = "لغو";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // mTbx_Date
            // 
            this.mTbx_Date.AllowPromptAsInput = false;
            this.mTbx_Date.Location = new System.Drawing.Point(19, 27);
            this.mTbx_Date.Mask = "0000/00/00";
            this.mTbx_Date.Name = "mTbx_Date";
            this.mTbx_Date.PromptChar = ' ';
            this.mTbx_Date.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mTbx_Date.Size = new System.Drawing.Size(93, 33);
            this.mTbx_Date.TabIndex = 2;
            this.mTbx_Date.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mTbx_Date_KeyDown);
            this.mTbx_Date.Leave += new System.EventHandler(this.mTbx_Date_Leave);
            // 
            // pSDatabase5DataSet
            // 
            this.pSDatabase5DataSet.DataSetName = "PSDatabase5DataSet";
            this.pSDatabase5DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbx_indebtedPrice
            // 
            this.tbx_indebtedPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accDocEventsTableBindingSource, "accDocEvent_indebted", true));
            this.tbx_indebtedPrice.Location = new System.Drawing.Point(19, 67);
            this.tbx_indebtedPrice.Name = "tbx_indebtedPrice";
            this.tbx_indebtedPrice.ReadOnly = true;
            this.tbx_indebtedPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_indebtedPrice.Size = new System.Drawing.Size(242, 33);
            this.tbx_indebtedPrice.TabIndex = 3;
            this.tbx_indebtedPrice.Text = "0";
            this.tbx_indebtedPrice.TextChanged += new System.EventHandler(this.tbx_indebtedPrice_TextChanged);
            // 
            // accDocEventsTableBindingSource
            // 
            this.accDocEventsTableBindingSource.DataMember = "accDocEventsTable";
            this.accDocEventsTableBindingSource.DataSource = this.pSDatabase5DataSet;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(326, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 26);
            this.label4.TabIndex = 100;
            this.label4.Text = "مبلغ بدهکاری :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(323, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 26);
            this.label5.TabIndex = 102;
            this.label5.Text = "مبلغ بستانکاری :";
            // 
            // tbx_creditorPrice
            // 
            this.tbx_creditorPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accDocEventsTableBindingSource, "accDocEvent_creditor", true));
            this.tbx_creditorPrice.Location = new System.Drawing.Point(19, 107);
            this.tbx_creditorPrice.Name = "tbx_creditorPrice";
            this.tbx_creditorPrice.ReadOnly = true;
            this.tbx_creditorPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_creditorPrice.Size = new System.Drawing.Size(242, 33);
            this.tbx_creditorPrice.TabIndex = 5;
            this.tbx_creditorPrice.Text = "0";
            this.tbx_creditorPrice.TextChanged += new System.EventHandler(this.tbx_creditorPrice_TextChanged);
            // 
            // btn_defineCheque
            // 
            this.btn_defineCheque.BackColor = System.Drawing.Color.Transparent;
            this.btn_defineCheque.ForeColor = System.Drawing.Color.Red;
            this.btn_defineCheque.Location = new System.Drawing.Point(267, 105);
            this.btn_defineCheque.Name = "btn_defineCheque";
            this.btn_defineCheque.Size = new System.Drawing.Size(50, 37);
            this.btn_defineCheque.TabIndex = 4;
            this.btn_defineCheque.Text = "چک";
            this.btn_defineCheque.UseVisualStyleBackColor = false;
            this.btn_defineCheque.Click += new System.EventHandler(this.btn_defineCheque_Click);
            // 
            // lbl_priceInChars
            // 
            this.lbl_priceInChars.BackColor = System.Drawing.Color.Transparent;
            this.lbl_priceInChars.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_priceInChars.ForeColor = System.Drawing.Color.Green;
            this.lbl_priceInChars.Location = new System.Drawing.Point(19, 155);
            this.lbl_priceInChars.Name = "lbl_priceInChars";
            this.lbl_priceInChars.Size = new System.Drawing.Size(405, 26);
            this.lbl_priceInChars.TabIndex = 105;
            this.lbl_priceInChars.Text = "صفر ریال";
            // 
            // tbx_comment
            // 
            this.tbx_comment.Location = new System.Drawing.Point(19, 189);
            this.tbx_comment.Name = "tbx_comment";
            this.tbx_comment.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbx_comment.Size = new System.Drawing.Size(298, 33);
            this.tbx_comment.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(323, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 26);
            this.label6.TabIndex = 107;
            this.label6.Text = "توضیحات سند :";
            // 
            // accDocEventsTableTableAdapter
            // 
            this.accDocEventsTableTableAdapter.ClearBeforeFill = true;
            // 
            // accountingDocsBindingSource
            // 
            this.accountingDocsBindingSource.DataMember = "AccountingDocs";
            this.accountingDocsBindingSource.DataSource = this.pSDatabase5DataSet;
            // 
            // accountingDocsTableAdapter
            // 
            this.accountingDocsTableAdapter.ClearBeforeFill = true;
            // 
            // frm_issuseAccDoc
            // 
            this.AcceptButton = this.btn_ok;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::cactus_PS_.Properties.Resources.forms_template1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(444, 397);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbx_comment);
            this.Controls.Add(this.lbl_priceInChars);
            this.Controls.Add(this.btn_defineCheque);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbx_creditorPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbx_indebtedPrice);
            this.Controls.Add(this.mTbx_Date);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.num_accDocNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_issuseAccDoc";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "صدور سند حسابداری";
            this.Load += new System.EventHandler(this.frm_issuseAccDoc_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_issuseAccDoc_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.num_accDocNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSDatabase5DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accDocEventsTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingDocsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_cancel;
        public System.Windows.Forms.NumericUpDown num_accDocNumber;
        public System.Windows.Forms.MaskedTextBox mTbx_Date;
        private System.Windows.Forms.TextBox tbx_indebtedPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbx_creditorPrice;
        private System.Windows.Forms.Button btn_defineCheque;
        private System.Windows.Forms.Label lbl_priceInChars;
        private PSDatabase5DataSet pSDatabase5DataSet;
        private System.Windows.Forms.BindingSource accDocEventsTableBindingSource;
        private cactus_PS_.PSDatabase5DataSetTableAdapters.accDocEventsTableTableAdapter accDocEventsTableTableAdapter;
        private System.Windows.Forms.TextBox tbx_comment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource accountingDocsBindingSource;
        private cactus_PS_.PSDatabase5DataSetTableAdapters.AccountingDocsTableAdapter accountingDocsTableAdapter;
    }
}