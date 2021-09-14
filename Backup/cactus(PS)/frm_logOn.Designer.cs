namespace cactus_PS_
{
    partial class frm_logOn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_logOn));
            this.listView_users = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lbx_users = new System.Windows.Forms.ListBox();
            this.usersTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pSDatabase5DataSet = new cactus_PS_.PSDatabase5DataSet();
            this.usersTableTableAdapter = new cactus_PS_.PSDatabase5DataSetTableAdapters.usersTableTableAdapter();
            this.tbx_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.pnl_Password = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_userName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usersTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSDatabase5DataSet)).BeginInit();
            this.pnl_Password.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView_users
            // 
            this.listView_users.BackColor = System.Drawing.SystemColors.Window;
            this.listView_users.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.listView_users.LargeImageList = this.imageList1;
            this.listView_users.Location = new System.Drawing.Point(33, 56);
            this.listView_users.MultiSelect = false;
            this.listView_users.Name = "listView_users";
            this.listView_users.Size = new System.Drawing.Size(557, 136);
            this.listView_users.TabIndex = 0;
            this.listView_users.UseCompatibleStateImageBehavior = false;
            this.listView_users.SelectedIndexChanged += new System.EventHandler(this.listView_users_SelectedIndexChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "monji");
            this.imageList1.Images.SetKeyName(1, "bird.jpg");
            this.imageList1.Images.SetKeyName(2, "car1.jpg");
            this.imageList1.Images.SetKeyName(3, "eagle.jpg");
            this.imageList1.Images.SetKeyName(4, "fish.jpg");
            this.imageList1.Images.SetKeyName(5, "hourse.jpg");
            this.imageList1.Images.SetKeyName(6, "killer.jpg");
            this.imageList1.Images.SetKeyName(7, "linux.png");
            this.imageList1.Images.SetKeyName(8, "nature1.jpg");
            // 
            // lbx_users
            // 
            this.lbx_users.DataSource = this.usersTableBindingSource;
            this.lbx_users.DisplayMember = "user_name";
            this.lbx_users.FormattingEnabled = true;
            this.lbx_users.ItemHeight = 20;
            this.lbx_users.Location = new System.Drawing.Point(100, 107);
            this.lbx_users.Name = "lbx_users";
            this.lbx_users.Size = new System.Drawing.Size(120, 24);
            this.lbx_users.TabIndex = 16;
            this.lbx_users.TabStop = false;
            this.lbx_users.ValueMember = "user_id";
            // 
            // usersTableBindingSource
            // 
            this.usersTableBindingSource.DataMember = "usersTable";
            this.usersTableBindingSource.DataSource = this.pSDatabase5DataSet;
            // 
            // pSDatabase5DataSet
            // 
            this.pSDatabase5DataSet.DataSetName = "PSDatabase5DataSet";
            this.pSDatabase5DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersTableTableAdapter
            // 
            this.usersTableTableAdapter.ClearBeforeFill = true;
            // 
            // tbx_password
            // 
            this.tbx_password.Location = new System.Drawing.Point(3, 3);
            this.tbx_password.Name = "tbx_password";
            this.tbx_password.PasswordChar = '*';
            this.tbx_password.Size = new System.Drawing.Size(254, 26);
            this.tbx_password.TabIndex = 0;
            this.tbx_password.TextChanged += new System.EventHandler(this.tbx_password_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(279, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "گذرواژه";
            // 
            // btn_ok
            // 
            this.btn_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_ok.Enabled = false;
            this.btn_ok.Location = new System.Drawing.Point(211, 297);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(371, 41);
            this.btn_ok.TabIndex = 3;
            this.btn_ok.Text = "ورود به برنامه";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(40, 297);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(151, 41);
            this.btn_cancel.TabIndex = 4;
            this.btn_cancel.Text = "بستن برنامه";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // pnl_Password
            // 
            this.pnl_Password.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Password.Controls.Add(this.label2);
            this.pnl_Password.Controls.Add(this.tbx_password);
            this.pnl_Password.Location = new System.Drawing.Point(142, 249);
            this.pnl_Password.Name = "pnl_Password";
            this.pnl_Password.Size = new System.Drawing.Size(339, 42);
            this.pnl_Password.TabIndex = 2;
            this.pnl_Password.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(406, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "نام کاربری";
            // 
            // tbx_userName
            // 
            this.tbx_userName.Location = new System.Drawing.Point(145, 210);
            this.tbx_userName.Name = "tbx_userName";
            this.tbx_userName.Size = new System.Drawing.Size(255, 26);
            this.tbx_userName.TabIndex = 1;
            this.tbx_userName.TextChanged += new System.EventHandler(this.tbx_userName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(240, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 24);
            this.label3.TabIndex = 26;
            this.label3.Text = "بسم الله الرحمن الرحیم";
            // 
            // frm_logOn
            // 
            this.AcceptButton = this.btn_ok;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::cactus_PS_.Properties.Resources.forms_template;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(628, 382);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_userName);
            this.Controls.Add(this.pnl_Password);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.listView_users);
            this.Controls.Add(this.lbx_users);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_logOn";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "خوش آمدید";
            this.Load += new System.EventHandler(this.frm_logOn_Load);
            this.Activated += new System.EventHandler(this.frm_logOn_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_logOn_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.usersTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSDatabase5DataSet)).EndInit();
            this.pnl_Password.ResumeLayout(false);
            this.pnl_Password.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_users;
        private System.Windows.Forms.ListBox lbx_users;
        private PSDatabase5DataSet pSDatabase5DataSet;
        private System.Windows.Forms.BindingSource usersTableBindingSource;
        private cactus_PS_.PSDatabase5DataSetTableAdapters.usersTableTableAdapter usersTableTableAdapter;
        private System.Windows.Forms.TextBox tbx_password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Panel pnl_Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_userName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ImageList imageList1;
    }
}