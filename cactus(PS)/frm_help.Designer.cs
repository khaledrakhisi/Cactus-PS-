namespace cactus_PS_
{
    partial class frm_help
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_hints = new System.Windows.Forms.Label();
            this.tmr_move = new System.Windows.Forms.Timer(this.components);
            this.chk_dontShowAgain = new System.Windows.Forms.CheckBox();
            this.viw_detailsTableAdapter = new cactus_PS_.PSDatabase5DataSetTableAdapters.viw_detailsTableAdapter();
            this.viwdetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pSDatabase5DataSet = new cactus_PS_.PSDatabase5DataSet();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viwdetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSDatabase5DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("B Titr", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "به راهنمای جامع نرم افزار خوش آمدید";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbl_hints);
            this.panel1.Location = new System.Drawing.Point(11, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 335);
            this.panel1.TabIndex = 1;
            // 
            // lbl_hints
            // 
            this.lbl_hints.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_hints.Location = new System.Drawing.Point(11, 11);
            this.lbl_hints.Name = "lbl_hints";
            this.lbl_hints.Size = new System.Drawing.Size(318, 311);
            this.lbl_hints.TabIndex = 0;
            // 
            // tmr_move
            // 
            this.tmr_move.Enabled = true;
            this.tmr_move.Interval = 500;
            this.tmr_move.Tick += new System.EventHandler(this.tmr_move_Tick);
            // 
            // chk_dontShowAgain
            // 
            this.chk_dontShowAgain.AutoSize = true;
            this.chk_dontShowAgain.BackColor = System.Drawing.Color.Transparent;
            this.chk_dontShowAgain.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.chk_dontShowAgain.Location = new System.Drawing.Point(27, 395);
            this.chk_dontShowAgain.Name = "chk_dontShowAgain";
            this.chk_dontShowAgain.Size = new System.Drawing.Size(313, 30);
            this.chk_dontShowAgain.TabIndex = 2;
            this.chk_dontShowAgain.Text = "بار دیگر هنگام اجرا کردن برنامه این کادر ظاهر نشود";
            this.chk_dontShowAgain.UseVisualStyleBackColor = false;
            this.chk_dontShowAgain.CheckedChanged += new System.EventHandler(this.chk_dontShowAgain_CheckedChanged);
            // 
            // viw_detailsTableAdapter
            // 
            this.viw_detailsTableAdapter.ClearBeforeFill = true;
            // 
            // viwdetailsBindingSource
            // 
            this.viwdetailsBindingSource.DataMember = "viw_details";
            // 
            // pSDatabase5DataSet
            // 
            this.pSDatabase5DataSet.DataSetName = "PSDatabase5DataSet";
            this.pSDatabase5DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frm_help
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::cactus_PS_.Properties.Resources.Kuantum_1024_768;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(366, 437);
            this.Controls.Add(this.chk_dontShowAgain);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frm_help";
            this.Opacity = 0.85;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "راهنمای جامع نرم افزار";
            this.TopMost = true;
            this.Deactivate += new System.EventHandler(this.frm_help_Deactivate);
            this.Load += new System.EventHandler(this.frm_help_Load);
            this.Activated += new System.EventHandler(this.frm_help_Activated);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_help_KeyDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.viwdetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSDatabase5DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer tmr_move;
        private System.Windows.Forms.Label lbl_hints;
        private cactus_PS_.PSDatabase5DataSetTableAdapters.viw_detailsTableAdapter viw_detailsTableAdapter;
        private System.Windows.Forms.BindingSource viwdetailsBindingSource;
        private PSDatabase5DataSet pSDatabase5DataSet;
        public System.Windows.Forms.CheckBox chk_dontShowAgain;
    }
}