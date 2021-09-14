namespace cactus_PS_
{
    partial class frm_InfoAddOrModify
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
            this.tbx_familyAndNAme = new System.Windows.Forms.TextBox();
            this.personsTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pSDatabase5DataSet = new cactus_PS_.PSDatabase5DataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbx_address1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbx_vehicleKind = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbx_phone2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbx_phone1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.personsTableTableAdapter = new cactus_PS_.PSDatabase5DataSetTableAdapters.personsTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.personsTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSDatabase5DataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbx_familyAndNAme
            // 
            this.tbx_familyAndNAme.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsTableBindingSource, "personFamilyAndName", true));
            this.tbx_familyAndNAme.Location = new System.Drawing.Point(12, 9);
            this.tbx_familyAndNAme.Name = "tbx_familyAndNAme";
            this.tbx_familyAndNAme.Size = new System.Drawing.Size(343, 38);
            this.tbx_familyAndNAme.TabIndex = 0;
            // 
            // personsTableBindingSource
            // 
            this.personsTableBindingSource.DataMember = "personsTable";
            this.personsTableBindingSource.DataSource = this.pSDatabase5DataSet;
            // 
            // pSDatabase5DataSet
            // 
            this.pSDatabase5DataSet.DataSetName = "PSDatabase5DataSet";
            this.pSDatabase5DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(368, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "نام خانوادگی و نام:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tbx_address1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tbx_vehicleKind);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbx_phone2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbx_phone1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbx_familyAndNAme);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(24, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 240);
            this.panel1.TabIndex = 0;
            // 
            // tbx_address1
            // 
            this.tbx_address1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsTableBindingSource, "personAddress1", true));
            this.tbx_address1.Location = new System.Drawing.Point(13, 187);
            this.tbx_address1.Name = "tbx_address1";
            this.tbx_address1.Size = new System.Drawing.Size(343, 38);
            this.tbx_address1.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(416, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 30);
            this.label7.TabIndex = 11;
            this.label7.Text = "آدرس :";
            // 
            // tbx_vehicleKind
            // 
            this.tbx_vehicleKind.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsTableBindingSource, "job", true));
            this.tbx_vehicleKind.Location = new System.Drawing.Point(13, 143);
            this.tbx_vehicleKind.Name = "tbx_vehicleKind";
            this.tbx_vehicleKind.Size = new System.Drawing.Size(343, 38);
            this.tbx_vehicleKind.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(421, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 30);
            this.label5.TabIndex = 9;
            this.label5.Text = "سمت:";
            // 
            // tbx_phone2
            // 
            this.tbx_phone2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsTableBindingSource, "personPhone2", true));
            this.tbx_phone2.Location = new System.Drawing.Point(13, 97);
            this.tbx_phone2.Name = "tbx_phone2";
            this.tbx_phone2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_phone2.Size = new System.Drawing.Size(343, 38);
            this.tbx_phone2.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(416, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = "همراه :";
            // 
            // tbx_phone1
            // 
            this.tbx_phone1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsTableBindingSource, "personPhone1", true));
            this.tbx_phone1.Location = new System.Drawing.Point(13, 53);
            this.tbx_phone1.Name = "tbx_phone1";
            this.tbx_phone1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_phone1.Size = new System.Drawing.Size(343, 38);
            this.tbx_phone1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(398, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "شماره تلفن :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btn_ok);
            this.panel2.Controls.Add(this.btn_cancel);
            this.panel2.Location = new System.Drawing.Point(28, 266);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(489, 55);
            this.panel2.TabIndex = 75;
            // 
            // btn_ok
            // 
            this.btn_ok.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_ok.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_ok.Location = new System.Drawing.Point(158, 7);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(323, 41);
            this.btn_ok.TabIndex = 1;
            this.btn_ok.Text = "تائید";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_cancel.Location = new System.Drawing.Point(6, 7);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(122, 41);
            this.btn_cancel.TabIndex = 0;
            this.btn_cancel.Text = "لغو";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // personsTableTableAdapter
            // 
            this.personsTableTableAdapter.ClearBeforeFill = true;
            // 
            // frm_InfoAddOrModify
            // 
            this.AcceptButton = this.btn_ok;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::cactus_PS_.Properties.Resources.forms_template1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(548, 341);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_InfoAddOrModify";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frm_InfoAddOrModify_Load);
            this.Shown += new System.EventHandler(this.frm_InfoAddOrModify_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.personsTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSDatabase5DataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_ok;
        private PSDatabase5DataSet pSDatabase5DataSet;
        private System.Windows.Forms.BindingSource personsTableBindingSource;
        private cactus_PS_.PSDatabase5DataSetTableAdapters.personsTableTableAdapter personsTableTableAdapter;
        public System.Windows.Forms.TextBox tbx_phone2;
        public System.Windows.Forms.TextBox tbx_vehicleKind;
        public System.Windows.Forms.TextBox tbx_address1;
        public System.Windows.Forms.TextBox tbx_familyAndNAme;
        public System.Windows.Forms.TextBox tbx_phone1;

    }
}