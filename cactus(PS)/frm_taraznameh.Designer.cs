namespace cactus_PS_
{
    partial class frm_taraznameh
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
            this.label1 = new System.Windows.Forms.Label();
            this.mTbx_Date = new System.Windows.Forms.MaskedTextBox();
            this.btn_showTaraznameh = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(173, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "نمایش ترازنامه منتهی به تاریخ :";
            // 
            // mTbx_Date
            // 
            this.mTbx_Date.AllowPromptAsInput = false;
            this.mTbx_Date.Location = new System.Drawing.Point(63, 28);
            this.mTbx_Date.Mask = "0000/00/00";
            this.mTbx_Date.Name = "mTbx_Date";
            this.mTbx_Date.PromptChar = ' ';
            this.mTbx_Date.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mTbx_Date.Size = new System.Drawing.Size(91, 33);
            this.mTbx_Date.TabIndex = 3;
            this.mTbx_Date.Leave += new System.EventHandler(this.mTbx_Date_Leave);
            this.mTbx_Date.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mTbx_Date_KeyPress);
            this.mTbx_Date.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mTbx_Date_KeyUp);
            // 
            // btn_showTaraznameh
            // 
            this.btn_showTaraznameh.Location = new System.Drawing.Point(141, 95);
            this.btn_showTaraznameh.Name = "btn_showTaraznameh";
            this.btn_showTaraznameh.Size = new System.Drawing.Size(254, 35);
            this.btn_showTaraznameh.TabIndex = 4;
            this.btn_showTaraznameh.Text = "نمایش ترازنامه";
            this.btn_showTaraznameh.UseVisualStyleBackColor = true;
            this.btn_showTaraznameh.Click += new System.EventHandler(this.btn_showTaraznameh_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(26, 95);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(96, 35);
            this.btn_cancel.TabIndex = 5;
            this.btn_cancel.Text = "لغو";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // frm_taraznameh
            // 
            this.AcceptButton = this.btn_showTaraznameh;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::cactus_PS_.Properties.Resources.forms_template1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(420, 146);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_showTaraznameh);
            this.Controls.Add(this.mTbx_Date);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_taraznameh";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ترازنامه";
            this.Load += new System.EventHandler(this.frm_taraznameh_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.MaskedTextBox mTbx_Date;
        private System.Windows.Forms.Button btn_showTaraznameh;
        private System.Windows.Forms.Button btn_cancel;
    }
}