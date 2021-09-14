namespace cactus_PS_
{
    partial class frm_manageSpent
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
            this.mTbx_Date = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_Event = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_comment = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_defineCheque = new System.Windows.Forms.Button();
            this.chk_byCheque = new System.Windows.Forms.CheckBox();
            this.spentsTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pSDatabase5DataSet = new cactus_PS_.PSDatabase5DataSet();
            this.spentsTableTableAdapter = new cactus_PS_.PSDatabase5DataSetTableAdapters.spentsTableTableAdapter();
            this.tbx_indebtedOrCreditorPrice = new System.Windows.Forms.TextBox();
            this.chequesTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chequesTableTableAdapter = new cactus_PS_.PSDatabase5DataSetTableAdapters.chequesTableTableAdapter();
            this.lbl_priceInChars = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.spentsTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSDatabase5DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chequesTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mTbx_Date
            // 
            this.mTbx_Date.AllowPromptAsInput = false;
            this.mTbx_Date.Location = new System.Drawing.Point(12, 12);
            this.mTbx_Date.Mask = "0000/00/00";
            this.mTbx_Date.Name = "mTbx_Date";
            this.mTbx_Date.PromptChar = ' ';
            this.mTbx_Date.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mTbx_Date.Size = new System.Drawing.Size(116, 38);
            this.mTbx_Date.TabIndex = 1;
            this.mTbx_Date.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mTbx_Date_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "تاریخ";
            // 
            // tbx_Event
            // 
            this.tbx_Event.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbx_Event.Location = new System.Drawing.Point(12, 95);
            this.tbx_Event.Multiline = true;
            this.tbx_Event.Name = "tbx_Event";
            this.tbx_Event.Size = new System.Drawing.Size(537, 63);
            this.tbx_Event.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(379, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "شـــــــــــرح :";
            // 
            // btn_Ok
            // 
            this.btn_Ok.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_Ok.Location = new System.Drawing.Point(134, 359);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(409, 35);
            this.btn_Ok.TabIndex = 6;
            this.btn_Ok.Text = "تائید";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_Cancel.Image = global::cactus_PS_.Properties.Resources.OOFL;
            this.btn_Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Cancel.Location = new System.Drawing.Point(15, 359);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(113, 35);
            this.btn_Cancel.TabIndex = 7;
            this.btn_Cancel.Text = "لغو";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Nazanin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(423, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 33);
            this.label3.TabIndex = 7;
            this.label3.Text = "مبلغ بدهکاری :";
            // 
            // tbx_comment
            // 
            this.tbx_comment.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbx_comment.Location = new System.Drawing.Point(12, 303);
            this.tbx_comment.Name = "tbx_comment";
            this.tbx_comment.Size = new System.Drawing.Size(537, 33);
            this.tbx_comment.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Nazanin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(458, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 33);
            this.label4.TabIndex = 10;
            this.label4.Text = "ملاحضات :";
            // 
            // btn_defineCheque
            // 
            this.btn_defineCheque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_defineCheque.ForeColor = System.Drawing.Color.Red;
            this.btn_defineCheque.Location = new System.Drawing.Point(259, 170);
            this.btn_defineCheque.Name = "btn_defineCheque";
            this.btn_defineCheque.Size = new System.Drawing.Size(50, 37);
            this.btn_defineCheque.TabIndex = 4;
            this.btn_defineCheque.Text = "چک";
            this.btn_defineCheque.UseVisualStyleBackColor = false;
            this.btn_defineCheque.Visible = false;
            this.btn_defineCheque.Click += new System.EventHandler(this.btn_defineCheque_Click);
            // 
            // chk_byCheque
            // 
            this.chk_byCheque.AutoSize = true;
            this.chk_byCheque.Location = new System.Drawing.Point(315, 173);
            this.chk_byCheque.Name = "chk_byCheque";
            this.chk_byCheque.Size = new System.Drawing.Size(73, 34);
            this.chk_byCheque.TabIndex = 3;
            this.chk_byCheque.Text = "با چک";
            this.chk_byCheque.UseVisualStyleBackColor = true;
            this.chk_byCheque.CheckedChanged += new System.EventHandler(this.chk_byCheque_CheckedChanged);
            // 
            // spentsTableBindingSource
            // 
            this.spentsTableBindingSource.DataMember = "spentsTable";
            this.spentsTableBindingSource.DataSource = this.pSDatabase5DataSet;
            // 
            // pSDatabase5DataSet
            // 
            this.pSDatabase5DataSet.DataSetName = "PSDatabase5DataSet";
            this.pSDatabase5DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spentsTableTableAdapter
            // 
            this.spentsTableTableAdapter.ClearBeforeFill = true;
            // 
            // tbx_indebtedOrCreditorPrice
            // 
            this.tbx_indebtedOrCreditorPrice.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbx_indebtedOrCreditorPrice.Location = new System.Drawing.Point(12, 171);
            this.tbx_indebtedOrCreditorPrice.Name = "tbx_indebtedOrCreditorPrice";
            this.tbx_indebtedOrCreditorPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_indebtedOrCreditorPrice.Size = new System.Drawing.Size(227, 33);
            this.tbx_indebtedOrCreditorPrice.TabIndex = 2;
            this.tbx_indebtedOrCreditorPrice.Text = "0";
            this.tbx_indebtedOrCreditorPrice.TextChanged += new System.EventHandler(this.tbx_indebtedOrCreditorPrice_TextChanged);
            this.tbx_indebtedOrCreditorPrice.Leave += new System.EventHandler(this.tbx_indebtedOrCreditorPrice_Leave_1);
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
            // lbl_priceInChars
            // 
            this.lbl_priceInChars.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_priceInChars.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_priceInChars.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_priceInChars.Location = new System.Drawing.Point(12, 220);
            this.lbl_priceInChars.Name = "lbl_priceInChars";
            this.lbl_priceInChars.Size = new System.Drawing.Size(537, 33);
            this.lbl_priceInChars.TabIndex = 11;
            // 
            // frm_manageSpent
            // 
            this.AcceptButton = this.btn_Ok;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.btn_Cancel;
            this.ClientSize = new System.Drawing.Size(561, 406);
            this.Controls.Add(this.lbl_priceInChars);
            this.Controls.Add(this.tbx_indebtedOrCreditorPrice);
            this.Controls.Add(this.chk_byCheque);
            this.Controls.Add(this.btn_defineCheque);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbx_comment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbx_Event);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mTbx_Date);
            this.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_manageSpent";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_manageSpent_Load);
            this.Shown += new System.EventHandler(this.frm_manageSpent_Shown);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_manageSpent_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.spentsTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSDatabase5DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chequesTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mTbx_Date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_Event;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label label3;
        private PSDatabase5DataSet pSDatabase5DataSet;
        private System.Windows.Forms.BindingSource spentsTableBindingSource;
        private cactus_PS_.PSDatabase5DataSetTableAdapters.spentsTableTableAdapter spentsTableTableAdapter;
        private System.Windows.Forms.TextBox tbx_comment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_defineCheque;
        private System.Windows.Forms.CheckBox chk_byCheque;
        private System.Windows.Forms.TextBox tbx_indebtedOrCreditorPrice;
        private System.Windows.Forms.BindingSource chequesTableBindingSource;
        private cactus_PS_.PSDatabase5DataSetTableAdapters.chequesTableTableAdapter chequesTableTableAdapter;
        private System.Windows.Forms.Label lbl_priceInChars;
    }
}