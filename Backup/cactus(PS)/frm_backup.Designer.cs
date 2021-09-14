namespace cactus_PS_
{
    partial class frm_backup
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
            this.ofd_backup = new System.Windows.Forms.OpenFileDialog();
            this.tbx_backup = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_provideBackup = new System.Windows.Forms.Button();
            this.btn_saveBackup = new System.Windows.Forms.Button();
            this.grp_restore = new System.Windows.Forms.GroupBox();
            this.btn_restore = new System.Windows.Forms.Button();
            this.btn_browseBackup = new System.Windows.Forms.Button();
            this.tbx_restore = new System.Windows.Forms.TextBox();
            this.sfd_backup = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.grp_restore.SuspendLayout();
            this.SuspendLayout();
            // 
            // ofd_backup
            // 
            this.ofd_backup.FileName = "openFileDialog1";
            // 
            // tbx_backup
            // 
            this.tbx_backup.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbx_backup.Location = new System.Drawing.Point(6, 35);
            this.tbx_backup.Name = "tbx_backup";
            this.tbx_backup.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_backup.Size = new System.Drawing.Size(494, 26);
            this.tbx_backup.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btn_provideBackup);
            this.groupBox1.Controls.Add(this.btn_saveBackup);
            this.groupBox1.Controls.Add(this.tbx_backup);
            this.groupBox1.Location = new System.Drawing.Point(29, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(567, 119);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "تهیه نسخه پشتیبان";
            // 
            // btn_provideBackup
            // 
            this.btn_provideBackup.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_provideBackup.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_provideBackup.Location = new System.Drawing.Point(18, 67);
            this.btn_provideBackup.Name = "btn_provideBackup";
            this.btn_provideBackup.Size = new System.Drawing.Size(195, 38);
            this.btn_provideBackup.TabIndex = 2;
            this.btn_provideBackup.Text = "تهیه نسخه پشتیبان";
            this.btn_provideBackup.UseVisualStyleBackColor = false;
            this.btn_provideBackup.Click += new System.EventHandler(this.btn_provideBackup_Click);
            // 
            // btn_saveBackup
            // 
            this.btn_saveBackup.Location = new System.Drawing.Point(506, 35);
            this.btn_saveBackup.Name = "btn_saveBackup";
            this.btn_saveBackup.Size = new System.Drawing.Size(45, 37);
            this.btn_saveBackup.TabIndex = 1;
            this.btn_saveBackup.Text = "...";
            this.btn_saveBackup.UseVisualStyleBackColor = true;
            this.btn_saveBackup.Click += new System.EventHandler(this.btn_saveBackup_Click);
            // 
            // grp_restore
            // 
            this.grp_restore.BackColor = System.Drawing.Color.Transparent;
            this.grp_restore.Controls.Add(this.btn_restore);
            this.grp_restore.Controls.Add(this.btn_browseBackup);
            this.grp_restore.Controls.Add(this.tbx_restore);
            this.grp_restore.Location = new System.Drawing.Point(29, 148);
            this.grp_restore.Name = "grp_restore";
            this.grp_restore.Size = new System.Drawing.Size(567, 118);
            this.grp_restore.TabIndex = 2;
            this.grp_restore.TabStop = false;
            this.grp_restore.Text = "بازیابی نسخه پشتیبان";
            // 
            // btn_restore
            // 
            this.btn_restore.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_restore.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_restore.Location = new System.Drawing.Point(18, 67);
            this.btn_restore.Name = "btn_restore";
            this.btn_restore.Size = new System.Drawing.Size(195, 38);
            this.btn_restore.TabIndex = 2;
            this.btn_restore.Text = "بازیابی نسخه پشتیبان";
            this.btn_restore.UseVisualStyleBackColor = false;
            this.btn_restore.Click += new System.EventHandler(this.btn_restore_Click);
            // 
            // btn_browseBackup
            // 
            this.btn_browseBackup.Location = new System.Drawing.Point(506, 35);
            this.btn_browseBackup.Name = "btn_browseBackup";
            this.btn_browseBackup.Size = new System.Drawing.Size(45, 38);
            this.btn_browseBackup.TabIndex = 1;
            this.btn_browseBackup.Text = "...";
            this.btn_browseBackup.UseVisualStyleBackColor = true;
            this.btn_browseBackup.Click += new System.EventHandler(this.btn_browseBackup_Click);
            // 
            // tbx_restore
            // 
            this.tbx_restore.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbx_restore.Location = new System.Drawing.Point(6, 35);
            this.tbx_restore.Name = "tbx_restore";
            this.tbx_restore.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_restore.Size = new System.Drawing.Size(494, 26);
            this.tbx_restore.TabIndex = 0;
            // 
            // frm_backup
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::cactus_PS_.Properties.Resources.forms_template1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(625, 286);
            this.Controls.Add(this.grp_restore);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_backup";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "پشتیبانی";
            this.Load += new System.EventHandler(this.frm_backup_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grp_restore.ResumeLayout(false);
            this.grp_restore.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofd_backup;
        private System.Windows.Forms.TextBox tbx_backup;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_saveBackup;
        private System.Windows.Forms.Button btn_provideBackup;
        private System.Windows.Forms.Button btn_restore;
        private System.Windows.Forms.Button btn_browseBackup;
        private System.Windows.Forms.TextBox tbx_restore;
        private System.Windows.Forms.SaveFileDialog sfd_backup;
        public System.Windows.Forms.GroupBox grp_restore;
    }
}