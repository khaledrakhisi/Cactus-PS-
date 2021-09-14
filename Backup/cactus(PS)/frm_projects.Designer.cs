namespace cactus_PS_
{
    partial class frm_projects
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_projects));
            this.cmb_projectsTitle = new System.Windows.Forms.ComboBox();
            this.projectsTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pSDatabase5DataSet = new cactus_PS_.PSDatabase5DataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbx_projectType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbx_projectWorkroomNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_projectMaster = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_projectComment = new System.Windows.Forms.TextBox();
            this.btn_deleteProject = new System.Windows.Forms.Button();
            this.btn_renameProjectTitle = new System.Windows.Forms.Button();
            this.btn_newProject = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_expandForm = new System.Windows.Forms.Button();
            this.projectsTableTableAdapter = new cactus_PS_.PSDatabase5DataSetTableAdapters.projectsTableTableAdapter();
            this.tbx_projectID = new System.Windows.Forms.TextBox();
            this.personsTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personsTableTableAdapter = new cactus_PS_.PSDatabase5DataSetTableAdapters.personsTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.projectsTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSDatabase5DataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personsTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_projectsTitle
            // 
            this.cmb_projectsTitle.DataSource = this.projectsTableBindingSource;
            this.cmb_projectsTitle.DisplayMember = "projectTitle";
            this.cmb_projectsTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_projectsTitle.Font = new System.Drawing.Font("B Titr", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmb_projectsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cmb_projectsTitle.FormattingEnabled = true;
            this.cmb_projectsTitle.Location = new System.Drawing.Point(118, 42);
            this.cmb_projectsTitle.Name = "cmb_projectsTitle";
            this.cmb_projectsTitle.Size = new System.Drawing.Size(413, 45);
            this.cmb_projectsTitle.TabIndex = 0;
            this.cmb_projectsTitle.ValueMember = "projectID";
            this.cmb_projectsTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cmb_projectsTitle_MouseDown);
            this.cmb_projectsTitle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_projectsTitle_KeyPress);
            // 
            // projectsTableBindingSource
            // 
            this.projectsTableBindingSource.DataMember = "projectsTable";
            this.projectsTableBindingSource.DataSource = this.pSDatabase5DataSet;
            // 
            // pSDatabase5DataSet
            // 
            this.pSDatabase5DataSet.DataSetName = "PSDatabase5DataSet";
            this.pSDatabase5DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbx_projectType);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbx_projectWorkroomNumber);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbx_projectMaster);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbx_projectComment);
            this.groupBox1.Controls.Add(this.btn_deleteProject);
            this.groupBox1.Controls.Add(this.btn_renameProjectTitle);
            this.groupBox1.Controls.Add(this.btn_newProject);
            this.groupBox1.Location = new System.Drawing.Point(26, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(556, 321);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(470, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 28);
            this.label5.TabIndex = 12;
            this.label5.Text = "نوع کار :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbx_projectType
            // 
            this.tbx_projectType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectsTableBindingSource, "projectType", true));
            this.tbx_projectType.Location = new System.Drawing.Point(34, 153);
            this.tbx_projectType.Name = "tbx_projectType";
            this.tbx_projectType.Size = new System.Drawing.Size(412, 36);
            this.tbx_projectType.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 28);
            this.label4.TabIndex = 10;
            this.label4.Text = "شماره کارگاه :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbx_projectWorkroomNumber
            // 
            this.tbx_projectWorkroomNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectsTableBindingSource, "projectWorkRoomNumber", true));
            this.tbx_projectWorkroomNumber.Location = new System.Drawing.Point(34, 104);
            this.tbx_projectWorkroomNumber.Name = "tbx_projectWorkroomNumber";
            this.tbx_projectWorkroomNumber.Size = new System.Drawing.Size(159, 36);
            this.tbx_projectWorkroomNumber.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(452, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = "نام کارفرما :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbx_projectMaster
            // 
            this.tbx_projectMaster.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectsTableBindingSource, "projectMaster", true));
            this.tbx_projectMaster.Location = new System.Drawing.Point(298, 106);
            this.tbx_projectMaster.Name = "tbx_projectMaster";
            this.tbx_projectMaster.Size = new System.Drawing.Size(148, 36);
            this.tbx_projectMaster.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(422, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "توضیحات پروژه :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbx_projectComment
            // 
            this.tbx_projectComment.AcceptsReturn = true;
            this.tbx_projectComment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectsTableBindingSource, "projectComment", true));
            this.tbx_projectComment.Location = new System.Drawing.Point(34, 235);
            this.tbx_projectComment.Multiline = true;
            this.tbx_projectComment.Name = "tbx_projectComment";
            this.tbx_projectComment.Size = new System.Drawing.Size(492, 80);
            this.tbx_projectComment.TabIndex = 6;
            this.tbx_projectComment.Enter += new System.EventHandler(this.tbx_projectComment_Enter);
            // 
            // btn_deleteProject
            // 
            this.btn_deleteProject.BackColor = System.Drawing.Color.Azure;
            this.btn_deleteProject.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_deleteProject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_deleteProject.Location = new System.Drawing.Point(20, 35);
            this.btn_deleteProject.Name = "btn_deleteProject";
            this.btn_deleteProject.Size = new System.Drawing.Size(168, 42);
            this.btn_deleteProject.TabIndex = 2;
            this.btn_deleteProject.Text = "حذف پروژه";
            this.btn_deleteProject.UseVisualStyleBackColor = false;
            this.btn_deleteProject.Click += new System.EventHandler(this.btn_deleteProject_Click);
            // 
            // btn_renameProjectTitle
            // 
            this.btn_renameProjectTitle.BackColor = System.Drawing.Color.Azure;
            this.btn_renameProjectTitle.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_renameProjectTitle.Location = new System.Drawing.Point(194, 35);
            this.btn_renameProjectTitle.Name = "btn_renameProjectTitle";
            this.btn_renameProjectTitle.Size = new System.Drawing.Size(168, 42);
            this.btn_renameProjectTitle.TabIndex = 1;
            this.btn_renameProjectTitle.Text = "تغییر عنوان";
            this.btn_renameProjectTitle.UseVisualStyleBackColor = false;
            this.btn_renameProjectTitle.Click += new System.EventHandler(this.btn_renameProjectTitle_Click);
            // 
            // btn_newProject
            // 
            this.btn_newProject.BackColor = System.Drawing.Color.Azure;
            this.btn_newProject.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_newProject.ForeColor = System.Drawing.Color.Green;
            this.btn_newProject.Location = new System.Drawing.Point(368, 35);
            this.btn_newProject.Name = "btn_newProject";
            this.btn_newProject.Size = new System.Drawing.Size(168, 42);
            this.btn_newProject.TabIndex = 0;
            this.btn_newProject.Text = "* پروژه جدید";
            this.btn_newProject.UseVisualStyleBackColor = false;
            this.btn_newProject.Click += new System.EventHandler(this.btn_newProject_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(262, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "پروژه فعلی";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btn_ok
            // 
            this.btn_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_ok.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ok.Location = new System.Drawing.Point(180, 409);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(382, 36);
            this.btn_ok.TabIndex = 3;
            this.btn_ok.Text = "تائید";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Image = ((System.Drawing.Image)(resources.GetObject("btn_cancel.Image")));
            this.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cancel.Location = new System.Drawing.Point(38, 409);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(136, 36);
            this.btn_cancel.TabIndex = 4;
            this.btn_cancel.Text = "لغو";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_expandForm
            // 
            this.btn_expandForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_expandForm.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_expandForm.ForeColor = System.Drawing.Color.White;
            this.btn_expandForm.Location = new System.Drawing.Point(32, 60);
            this.btn_expandForm.Name = "btn_expandForm";
            this.btn_expandForm.Size = new System.Drawing.Size(80, 27);
            this.btn_expandForm.TabIndex = 1;
            this.btn_expandForm.Text = "+ امکانات";
            this.btn_expandForm.UseVisualStyleBackColor = false;
            this.btn_expandForm.Click += new System.EventHandler(this.btn_expandForm_Click);
            // 
            // projectsTableTableAdapter
            // 
            this.projectsTableTableAdapter.ClearBeforeFill = true;
            // 
            // tbx_projectID
            // 
            this.tbx_projectID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectsTableBindingSource, "projectID", true));
            this.tbx_projectID.Location = new System.Drawing.Point(537, 50);
            this.tbx_projectID.Name = "tbx_projectID";
            this.tbx_projectID.ReadOnly = true;
            this.tbx_projectID.Size = new System.Drawing.Size(40, 36);
            this.tbx_projectID.TabIndex = 9;
            this.tbx_projectID.TabStop = false;
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
            // frm_projects
            // 
            this.AcceptButton = this.btn_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::cactus_PS_.Properties.Resources.forms_template;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(609, 469);
            this.Controls.Add(this.tbx_projectID);
            this.Controls.Add(this.btn_expandForm);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_projectsTitle);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_projects";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "پروژه ها";
            this.Load += new System.EventHandler(this.frm_projects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projectsTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSDatabase5DataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personsTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_projectsTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_newProject;
        private System.Windows.Forms.Button btn_deleteProject;
        private System.Windows.Forms.Button btn_renameProjectTitle;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_projectComment;
        private System.Windows.Forms.Button btn_expandForm;
        private PSDatabase5DataSet pSDatabase5DataSet;
        public System.Windows.Forms.BindingSource projectsTableBindingSource;
        public cactus_PS_.PSDatabase5DataSetTableAdapters.projectsTableTableAdapter projectsTableTableAdapter;
        private System.Windows.Forms.TextBox tbx_projectID;
        private System.Windows.Forms.BindingSource personsTableBindingSource;
        private cactus_PS_.PSDatabase5DataSetTableAdapters.personsTableTableAdapter personsTableTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_projectMaster;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbx_projectType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbx_projectWorkroomNumber;
    }
}