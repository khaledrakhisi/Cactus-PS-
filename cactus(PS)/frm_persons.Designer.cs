namespace cactus_PS_
{
    partial class frm_persons
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
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_familyAndName = new System.Windows.Forms.ComboBox();
            this.personsTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pSDatabase5DataSet = new cactus_PS_.PSDatabase5DataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_modifyPersonProperties = new System.Windows.Forms.Button();
            this.btn_deletePerson = new System.Windows.Forms.Button();
            this.btn_renamePerosn = new System.Windows.Forms.Button();
            this.btn_newPerson = new System.Windows.Forms.Button();
            this.tab_Person = new System.Windows.Forms.TabControl();
            this.pag_general = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.tbx_address2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbx_address1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbx_phone2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbx_phone1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbx_Born = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbx_NO = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbx_fatherName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbx_job = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_nationalNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_personelNumber = new System.Windows.Forms.TextBox();
            this.pag_money = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.cmb_projectsTitle = new System.Windows.Forms.ComboBox();
            this.projectsTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_beforeRemainMoneyPrompt = new System.Windows.Forms.Label();
            this.tbx_indebtedOrCreditorPrice = new System.Windows.Forms.TextBox();
            this.grp_RadioButtons = new System.Windows.Forms.GroupBox();
            this.rdu_creditorBefore = new System.Windows.Forms.RadioButton();
            this.rdu_indebtedBefore = new System.Windows.Forms.RadioButton();
            this.rdu_NoBeforeMoney = new System.Windows.Forms.RadioButton();
            this.personsTableTableAdapter = new cactus_PS_.PSDatabase5DataSetTableAdapters.personsTableTableAdapter();
            this.tbx_personID = new System.Windows.Forms.TextBox();
            this.tbx_beforeRemainMoney = new System.Windows.Forms.TextBox();
            this.tbx_beforeType = new System.Windows.Forms.TextBox();
            this.projectsTableTableAdapter = new cactus_PS_.PSDatabase5DataSetTableAdapters.projectsTableTableAdapter();
            this.projectsPersonsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectsPersonsTableAdapter = new cactus_PS_.PSDatabase5DataSetTableAdapters.projectsPersonsTableAdapter();
            this.btn_viewAllPersons = new System.Windows.Forms.Button();
            this.btn_ejectPersonFromCurrentProject = new System.Windows.Forms.Button();
            this.pic_personFace = new System.Windows.Forms.PictureBox();
            this.btn_choosePic = new System.Windows.Forms.Button();
            this.btn_deletePic = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.personsTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSDatabase5DataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tab_Person.SuspendLayout();
            this.pag_general.SuspendLayout();
            this.pag_money.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectsTableBindingSource)).BeginInit();
            this.grp_RadioButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectsPersonsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_personFace)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_cancel.Image = global::cactus_PS_.Properties.Resources.OOFL;
            this.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cancel.Location = new System.Drawing.Point(41, 541);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(136, 36);
            this.btn_cancel.TabIndex = 8;
            this.btn_cancel.Text = "لغو";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_ok
            // 
            this.btn_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_ok.Location = new System.Drawing.Point(214, 541);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(484, 36);
            this.btn_ok.TabIndex = 7;
            this.btn_ok.Text = "تائید";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(353, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "نام خانوادگی و نام طرف حساب";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmb_familyAndName
            // 
            this.cmb_familyAndName.DataSource = this.personsTableBindingSource;
            this.cmb_familyAndName.DisplayMember = "personFamilyAndName";
            this.cmb_familyAndName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_familyAndName.FormattingEnabled = true;
            this.cmb_familyAndName.Location = new System.Drawing.Point(250, 96);
            this.cmb_familyAndName.MaxDropDownItems = 10;
            this.cmb_familyAndName.Name = "cmb_familyAndName";
            this.cmb_familyAndName.Size = new System.Drawing.Size(393, 32);
            this.cmb_familyAndName.TabIndex = 0;
            this.cmb_familyAndName.ValueMember = "personID";
            this.cmb_familyAndName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_familyAndName_KeyPress);
            // 
            // personsTableBindingSource
            // 
            this.personsTableBindingSource.DataMember = "personsTable";
            this.personsTableBindingSource.DataSource = this.pSDatabase5DataSet;
            this.personsTableBindingSource.CurrentChanged += new System.EventHandler(this.personsTableBindingSource_CurrentChanged);
            // 
            // pSDatabase5DataSet
            // 
            this.pSDatabase5DataSet.DataSetName = "PSDatabase5DataSet";
            this.pSDatabase5DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btn_modifyPersonProperties);
            this.groupBox1.Controls.Add(this.btn_deletePerson);
            this.groupBox1.Controls.Add(this.btn_renamePerosn);
            this.groupBox1.Controls.Add(this.btn_newPerson);
            this.groupBox1.Location = new System.Drawing.Point(25, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(689, 79);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // btn_modifyPersonProperties
            // 
            this.btn_modifyPersonProperties.BackColor = System.Drawing.Color.Azure;
            this.btn_modifyPersonProperties.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_modifyPersonProperties.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_modifyPersonProperties.Location = new System.Drawing.Point(177, 26);
            this.btn_modifyPersonProperties.Name = "btn_modifyPersonProperties";
            this.btn_modifyPersonProperties.Size = new System.Drawing.Size(168, 45);
            this.btn_modifyPersonProperties.TabIndex = 2;
            this.btn_modifyPersonProperties.Text = "اصلاح مشخصات";
            this.btn_modifyPersonProperties.UseVisualStyleBackColor = false;
            this.btn_modifyPersonProperties.Click += new System.EventHandler(this.btn_modifyPersonProperties_Click);
            // 
            // btn_deletePerson
            // 
            this.btn_deletePerson.BackColor = System.Drawing.Color.Azure;
            this.btn_deletePerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_deletePerson.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_deletePerson.Location = new System.Drawing.Point(9, 26);
            this.btn_deletePerson.Name = "btn_deletePerson";
            this.btn_deletePerson.Size = new System.Drawing.Size(168, 45);
            this.btn_deletePerson.TabIndex = 3;
            this.btn_deletePerson.Text = "حذف طرف حساب";
            this.btn_deletePerson.UseVisualStyleBackColor = false;
            this.btn_deletePerson.Click += new System.EventHandler(this.btn_deletePerson_Click);
            // 
            // btn_renamePerosn
            // 
            this.btn_renamePerosn.BackColor = System.Drawing.Color.Azure;
            this.btn_renamePerosn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_renamePerosn.Location = new System.Drawing.Point(345, 26);
            this.btn_renamePerosn.Name = "btn_renamePerosn";
            this.btn_renamePerosn.Size = new System.Drawing.Size(168, 45);
            this.btn_renamePerosn.TabIndex = 1;
            this.btn_renamePerosn.Text = "تغییر نام";
            this.btn_renamePerosn.UseVisualStyleBackColor = false;
            this.btn_renamePerosn.Click += new System.EventHandler(this.btn_renamePerosn_Click);
            // 
            // btn_newPerson
            // 
            this.btn_newPerson.BackColor = System.Drawing.Color.Azure;
            this.btn_newPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_newPerson.ForeColor = System.Drawing.Color.Green;
            this.btn_newPerson.Location = new System.Drawing.Point(513, 26);
            this.btn_newPerson.Name = "btn_newPerson";
            this.btn_newPerson.Size = new System.Drawing.Size(168, 45);
            this.btn_newPerson.TabIndex = 0;
            this.btn_newPerson.Text = "* طرف حساب جدید";
            this.btn_newPerson.UseVisualStyleBackColor = false;
            this.btn_newPerson.Click += new System.EventHandler(this.btn_newPerson_Click);
            // 
            // tab_Person
            // 
            this.tab_Person.Controls.Add(this.pag_general);
            this.tab_Person.Controls.Add(this.pag_money);
            this.tab_Person.Location = new System.Drawing.Point(25, 210);
            this.tab_Person.Name = "tab_Person";
            this.tab_Person.SelectedIndex = 0;
            this.tab_Person.Size = new System.Drawing.Size(689, 325);
            this.tab_Person.TabIndex = 6;
            // 
            // pag_general
            // 
            this.pag_general.Controls.Add(this.label11);
            this.pag_general.Controls.Add(this.tbx_address2);
            this.pag_general.Controls.Add(this.label10);
            this.pag_general.Controls.Add(this.tbx_address1);
            this.pag_general.Controls.Add(this.label9);
            this.pag_general.Controls.Add(this.tbx_phone2);
            this.pag_general.Controls.Add(this.label8);
            this.pag_general.Controls.Add(this.tbx_phone1);
            this.pag_general.Controls.Add(this.label7);
            this.pag_general.Controls.Add(this.tbx_Born);
            this.pag_general.Controls.Add(this.label6);
            this.pag_general.Controls.Add(this.tbx_NO);
            this.pag_general.Controls.Add(this.label5);
            this.pag_general.Controls.Add(this.tbx_fatherName);
            this.pag_general.Controls.Add(this.label4);
            this.pag_general.Controls.Add(this.tbx_job);
            this.pag_general.Controls.Add(this.label3);
            this.pag_general.Controls.Add(this.tbx_nationalNumber);
            this.pag_general.Controls.Add(this.label2);
            this.pag_general.Controls.Add(this.tbx_personelNumber);
            this.pag_general.Location = new System.Drawing.Point(4, 33);
            this.pag_general.Name = "pag_general";
            this.pag_general.Padding = new System.Windows.Forms.Padding(3);
            this.pag_general.Size = new System.Drawing.Size(681, 288);
            this.pag_general.TabIndex = 0;
            this.pag_general.Text = "اطلاعات شخصی";
            this.pag_general.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(581, 189);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 24);
            this.label11.TabIndex = 28;
            this.label11.Text = "آدرس منزل";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbx_address2
            // 
            this.tbx_address2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsTableBindingSource, "personAddress2", true));
            this.tbx_address2.Location = new System.Drawing.Point(6, 231);
            this.tbx_address2.Name = "tbx_address2";
            this.tbx_address2.Size = new System.Drawing.Size(569, 29);
            this.tbx_address2.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(575, 234);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 24);
            this.label10.TabIndex = 26;
            this.label10.Text = "آدرس محل کار";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbx_address1
            // 
            this.tbx_address1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsTableBindingSource, "personAddress1", true));
            this.tbx_address1.Location = new System.Drawing.Point(6, 189);
            this.tbx_address1.Name = "tbx_address1";
            this.tbx_address1.Size = new System.Drawing.Size(569, 29);
            this.tbx_address1.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(262, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 24);
            this.label9.TabIndex = 24;
            this.label9.Text = "همراه";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbx_phone2
            // 
            this.tbx_phone2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsTableBindingSource, "personPhone2", true));
            this.tbx_phone2.Location = new System.Drawing.Point(6, 140);
            this.tbx_phone2.Name = "tbx_phone2";
            this.tbx_phone2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_phone2.Size = new System.Drawing.Size(187, 29);
            this.tbx_phone2.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(209, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 24);
            this.label8.TabIndex = 22;
            this.label8.Text = "تلفن منزل و محل کار";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbx_phone1
            // 
            this.tbx_phone1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsTableBindingSource, "personPhone1", true));
            this.tbx_phone1.Location = new System.Drawing.Point(6, 98);
            this.tbx_phone1.Name = "tbx_phone1";
            this.tbx_phone1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_phone1.Size = new System.Drawing.Size(187, 29);
            this.tbx_phone1.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(240, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 24);
            this.label7.TabIndex = 20;
            this.label7.Text = "صادره از ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbx_Born
            // 
            this.tbx_Born.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsTableBindingSource, "personBorn", true));
            this.tbx_Born.Location = new System.Drawing.Point(6, 56);
            this.tbx_Born.Name = "tbx_Born";
            this.tbx_Born.Size = new System.Drawing.Size(187, 29);
            this.tbx_Born.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(218, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 24);
            this.label6.TabIndex = 18;
            this.label6.Text = "شماره شناسنامه";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbx_NO
            // 
            this.tbx_NO.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsTableBindingSource, "personNO", true));
            this.tbx_NO.Location = new System.Drawing.Point(6, 14);
            this.tbx_NO.Name = "tbx_NO";
            this.tbx_NO.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_NO.Size = new System.Drawing.Size(187, 29);
            this.tbx_NO.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(602, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "نام پدر";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbx_fatherName
            // 
            this.tbx_fatherName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsTableBindingSource, "fatherName", true));
            this.tbx_fatherName.Location = new System.Drawing.Point(388, 143);
            this.tbx_fatherName.Name = "tbx_fatherName";
            this.tbx_fatherName.Size = new System.Drawing.Size(187, 29);
            this.tbx_fatherName.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(602, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "سمت";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbx_job
            // 
            this.tbx_job.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsTableBindingSource, "job", true));
            this.tbx_job.Location = new System.Drawing.Point(388, 99);
            this.tbx_job.Name = "tbx_job";
            this.tbx_job.Size = new System.Drawing.Size(187, 29);
            this.tbx_job.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(602, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "کد ملی";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbx_nationalNumber
            // 
            this.tbx_nationalNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsTableBindingSource, "nationalNumber", true));
            this.tbx_nationalNumber.Location = new System.Drawing.Point(388, 55);
            this.tbx_nationalNumber.Name = "tbx_nationalNumber";
            this.tbx_nationalNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_nationalNumber.Size = new System.Drawing.Size(187, 29);
            this.tbx_nationalNumber.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(581, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "شماره پرسنلی";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbx_personelNumber
            // 
            this.tbx_personelNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsTableBindingSource, "personelNumber", true));
            this.tbx_personelNumber.Location = new System.Drawing.Point(388, 11);
            this.tbx_personelNumber.Name = "tbx_personelNumber";
            this.tbx_personelNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_personelNumber.Size = new System.Drawing.Size(187, 29);
            this.tbx_personelNumber.TabIndex = 0;
            // 
            // pag_money
            // 
            this.pag_money.Controls.Add(this.label12);
            this.pag_money.Controls.Add(this.cmb_projectsTitle);
            this.pag_money.Controls.Add(this.lbl_beforeRemainMoneyPrompt);
            this.pag_money.Controls.Add(this.tbx_indebtedOrCreditorPrice);
            this.pag_money.Controls.Add(this.grp_RadioButtons);
            this.pag_money.Location = new System.Drawing.Point(4, 33);
            this.pag_money.Name = "pag_money";
            this.pag_money.Padding = new System.Windows.Forms.Padding(3);
            this.pag_money.Size = new System.Drawing.Size(681, 288);
            this.pag_money.TabIndex = 1;
            this.pag_money.Text = "اطلاعات مالی و کاری";
            this.pag_money.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(413, 179);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(200, 24);
            this.label12.TabIndex = 21;
            this.label12.Text = "پروژه ای که در آن فعالیت دارد";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmb_projectsTitle
            // 
            this.cmb_projectsTitle.DataSource = this.projectsTableBindingSource;
            this.cmb_projectsTitle.DisplayMember = "projectTitle";
            this.cmb_projectsTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_projectsTitle.FormattingEnabled = true;
            this.cmb_projectsTitle.Location = new System.Drawing.Point(66, 176);
            this.cmb_projectsTitle.Name = "cmb_projectsTitle";
            this.cmb_projectsTitle.Size = new System.Drawing.Size(321, 32);
            this.cmb_projectsTitle.TabIndex = 20;
            this.cmb_projectsTitle.ValueMember = "projectID";
            // 
            // projectsTableBindingSource
            // 
            this.projectsTableBindingSource.DataMember = "projectsTable";
            this.projectsTableBindingSource.DataSource = this.pSDatabase5DataSet;
            // 
            // lbl_beforeRemainMoneyPrompt
            // 
            this.lbl_beforeRemainMoneyPrompt.AutoSize = true;
            this.lbl_beforeRemainMoneyPrompt.Location = new System.Drawing.Point(252, 49);
            this.lbl_beforeRemainMoneyPrompt.Name = "lbl_beforeRemainMoneyPrompt";
            this.lbl_beforeRemainMoneyPrompt.Size = new System.Drawing.Size(92, 24);
            this.lbl_beforeRemainMoneyPrompt.TabIndex = 19;
            this.lbl_beforeRemainMoneyPrompt.Text = "مبلغ بدهکاری";
            this.lbl_beforeRemainMoneyPrompt.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbx_indebtedOrCreditorPrice
            // 
            this.tbx_indebtedOrCreditorPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsTableBindingSource, "beforeRemainMoney", true));
            this.tbx_indebtedOrCreditorPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbx_indebtedOrCreditorPrice.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbx_indebtedOrCreditorPrice.Location = new System.Drawing.Point(16, 46);
            this.tbx_indebtedOrCreditorPrice.Name = "tbx_indebtedOrCreditorPrice";
            this.tbx_indebtedOrCreditorPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_indebtedOrCreditorPrice.Size = new System.Drawing.Size(230, 26);
            this.tbx_indebtedOrCreditorPrice.TabIndex = 1;
            this.tbx_indebtedOrCreditorPrice.TextChanged += new System.EventHandler(this.tbx_indebtedOrCreditorPrice_TextChanged);
            // 
            // grp_RadioButtons
            // 
            this.grp_RadioButtons.Controls.Add(this.rdu_creditorBefore);
            this.grp_RadioButtons.Controls.Add(this.rdu_indebtedBefore);
            this.grp_RadioButtons.Controls.Add(this.rdu_NoBeforeMoney);
            this.grp_RadioButtons.Location = new System.Drawing.Point(381, 16);
            this.grp_RadioButtons.Name = "grp_RadioButtons";
            this.grp_RadioButtons.Size = new System.Drawing.Size(283, 87);
            this.grp_RadioButtons.TabIndex = 0;
            this.grp_RadioButtons.TabStop = false;
            this.grp_RadioButtons.Text = "مانده قبلی";
            // 
            // rdu_creditorBefore
            // 
            this.rdu_creditorBefore.AutoSize = true;
            this.rdu_creditorBefore.Location = new System.Drawing.Point(16, 31);
            this.rdu_creditorBefore.Name = "rdu_creditorBefore";
            this.rdu_creditorBefore.Size = new System.Drawing.Size(77, 28);
            this.rdu_creditorBefore.TabIndex = 2;
            this.rdu_creditorBefore.TabStop = true;
            this.rdu_creditorBefore.Text = "بستانکار";
            this.rdu_creditorBefore.UseVisualStyleBackColor = true;
            this.rdu_creditorBefore.CheckedChanged += new System.EventHandler(this.rdu_creditorBefore_CheckedChanged);
            // 
            // rdu_indebtedBefore
            // 
            this.rdu_indebtedBefore.AutoSize = true;
            this.rdu_indebtedBefore.Location = new System.Drawing.Point(103, 31);
            this.rdu_indebtedBefore.Name = "rdu_indebtedBefore";
            this.rdu_indebtedBefore.Size = new System.Drawing.Size(68, 28);
            this.rdu_indebtedBefore.TabIndex = 1;
            this.rdu_indebtedBefore.TabStop = true;
            this.rdu_indebtedBefore.Text = "بدهکار";
            this.rdu_indebtedBefore.UseVisualStyleBackColor = true;
            this.rdu_indebtedBefore.CheckedChanged += new System.EventHandler(this.rdu_indebtedBefore_CheckedChanged);
            // 
            // rdu_NoBeforeMoney
            // 
            this.rdu_NoBeforeMoney.AutoSize = true;
            this.rdu_NoBeforeMoney.Location = new System.Drawing.Point(182, 31);
            this.rdu_NoBeforeMoney.Name = "rdu_NoBeforeMoney";
            this.rdu_NoBeforeMoney.Size = new System.Drawing.Size(87, 28);
            this.rdu_NoBeforeMoney.TabIndex = 0;
            this.rdu_NoBeforeMoney.TabStop = true;
            this.rdu_NoBeforeMoney.Text = "بی حساب";
            this.rdu_NoBeforeMoney.UseVisualStyleBackColor = true;
            this.rdu_NoBeforeMoney.CheckedChanged += new System.EventHandler(this.rdu_NoBeforeMoney_CheckedChanged);
            // 
            // personsTableTableAdapter
            // 
            this.personsTableTableAdapter.ClearBeforeFill = true;
            // 
            // tbx_personID
            // 
            this.tbx_personID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsTableBindingSource, "personID", true));
            this.tbx_personID.Location = new System.Drawing.Point(765, 67);
            this.tbx_personID.Name = "tbx_personID";
            this.tbx_personID.ReadOnly = true;
            this.tbx_personID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_personID.Size = new System.Drawing.Size(48, 29);
            this.tbx_personID.TabIndex = 15;
            // 
            // tbx_beforeRemainMoney
            // 
            this.tbx_beforeRemainMoney.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsTableBindingSource, "beforeRemainMoney", true));
            this.tbx_beforeRemainMoney.Location = new System.Drawing.Point(765, -17);
            this.tbx_beforeRemainMoney.Name = "tbx_beforeRemainMoney";
            this.tbx_beforeRemainMoney.ReadOnly = true;
            this.tbx_beforeRemainMoney.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_beforeRemainMoney.Size = new System.Drawing.Size(48, 29);
            this.tbx_beforeRemainMoney.TabIndex = 16;
            this.tbx_beforeRemainMoney.TabStop = false;
            // 
            // tbx_beforeType
            // 
            this.tbx_beforeType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsTableBindingSource, "beforeType", true));
            this.tbx_beforeType.Location = new System.Drawing.Point(765, 25);
            this.tbx_beforeType.Name = "tbx_beforeType";
            this.tbx_beforeType.ReadOnly = true;
            this.tbx_beforeType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_beforeType.Size = new System.Drawing.Size(48, 29);
            this.tbx_beforeType.TabIndex = 17;
            this.tbx_beforeType.TabStop = false;
            this.tbx_beforeType.TextChanged += new System.EventHandler(this.tbx_beforeType_TextChanged);
            // 
            // projectsTableTableAdapter
            // 
            this.projectsTableTableAdapter.ClearBeforeFill = true;
            // 
            // projectsPersonsBindingSource
            // 
            this.projectsPersonsBindingSource.DataMember = "projectsPersons";
            this.projectsPersonsBindingSource.DataSource = this.pSDatabase5DataSet;
            // 
            // projectsPersonsTableAdapter
            // 
            this.projectsPersonsTableAdapter.ClearBeforeFill = true;
            // 
            // btn_viewAllPersons
            // 
            this.btn_viewAllPersons.Image = global::cactus_PS_.Properties.Resources.CRDFLE13;
            this.btn_viewAllPersons.Location = new System.Drawing.Point(649, 54);
            this.btn_viewAllPersons.Name = "btn_viewAllPersons";
            this.btn_viewAllPersons.Size = new System.Drawing.Size(55, 36);
            this.btn_viewAllPersons.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btn_viewAllPersons, "اضافه کردن طرف حساب از دیگر پروژه های موجود");
            this.btn_viewAllPersons.UseVisualStyleBackColor = true;
            this.btn_viewAllPersons.Click += new System.EventHandler(this.btn_viewAllPersons_Click);
            // 
            // btn_ejectPersonFromCurrentProject
            // 
            this.btn_ejectPersonFromCurrentProject.Image = global::cactus_PS_.Properties.Resources.ERASE02;
            this.btn_ejectPersonFromCurrentProject.Location = new System.Drawing.Point(649, 96);
            this.btn_ejectPersonFromCurrentProject.Name = "btn_ejectPersonFromCurrentProject";
            this.btn_ejectPersonFromCurrentProject.Size = new System.Drawing.Size(55, 36);
            this.btn_ejectPersonFromCurrentProject.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btn_ejectPersonFromCurrentProject, "اخراج طرف حساب از پروژه فعلی");
            this.btn_ejectPersonFromCurrentProject.UseVisualStyleBackColor = true;
            this.btn_ejectPersonFromCurrentProject.Click += new System.EventHandler(this.btn_ejectPersonFromCurrentProject_Click);
            // 
            // pic_personFace
            // 
            this.pic_personFace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_personFace.Location = new System.Drawing.Point(37, 31);
            this.pic_personFace.Name = "pic_personFace";
            this.pic_personFace.Size = new System.Drawing.Size(104, 101);
            this.pic_personFace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_personFace.TabIndex = 20;
            this.pic_personFace.TabStop = false;
            // 
            // btn_choosePic
            // 
            this.btn_choosePic.Enabled = false;
            this.btn_choosePic.Location = new System.Drawing.Point(147, 54);
            this.btn_choosePic.Name = "btn_choosePic";
            this.btn_choosePic.Size = new System.Drawing.Size(97, 39);
            this.btn_choosePic.TabIndex = 3;
            this.btn_choosePic.Text = "انتخاب عکس";
            this.toolTip1.SetToolTip(this.btn_choosePic, "تخصیص عکس برای طرف حساب");
            this.btn_choosePic.UseVisualStyleBackColor = true;
            this.btn_choosePic.Click += new System.EventHandler(this.btn_choosePic_Click);
            // 
            // btn_deletePic
            // 
            this.btn_deletePic.Enabled = false;
            this.btn_deletePic.Location = new System.Drawing.Point(147, 96);
            this.btn_deletePic.Name = "btn_deletePic";
            this.btn_deletePic.Size = new System.Drawing.Size(97, 36);
            this.btn_deletePic.TabIndex = 4;
            this.btn_deletePic.Text = "حذف عکس";
            this.toolTip1.SetToolTip(this.btn_deletePic, "حذف عکس اختصاص داده شده برای طرف حساب");
            this.btn_deletePic.UseVisualStyleBackColor = true;
            this.btn_deletePic.Click += new System.EventHandler(this.btn_deletePic_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frm_persons
            // 
            this.AcceptButton = this.btn_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::cactus_PS_.Properties.Resources.forms_template1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(741, 603);
            this.Controls.Add(this.btn_deletePic);
            this.Controls.Add(this.btn_choosePic);
            this.Controls.Add(this.pic_personFace);
            this.Controls.Add(this.btn_ejectPersonFromCurrentProject);
            this.Controls.Add(this.btn_viewAllPersons);
            this.Controls.Add(this.tbx_beforeType);
            this.Controls.Add(this.tbx_beforeRemainMoney);
            this.Controls.Add(this.tbx_personID);
            this.Controls.Add(this.tab_Person);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_familyAndName);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_persons";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "طرف های حساب";
            this.Load += new System.EventHandler(this.frm_persons_Load);
            this.Shown += new System.EventHandler(this.frm_persons_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_persons_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.personsTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSDatabase5DataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tab_Person.ResumeLayout(false);
            this.pag_general.ResumeLayout(false);
            this.pag_general.PerformLayout();
            this.pag_money.ResumeLayout(false);
            this.pag_money.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectsTableBindingSource)).EndInit();
            this.grp_RadioButtons.ResumeLayout(false);
            this.grp_RadioButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectsPersonsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_personFace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_familyAndName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_deletePerson;
        private System.Windows.Forms.Button btn_renamePerosn;
        private System.Windows.Forms.Button btn_newPerson;
        private System.Windows.Forms.Button btn_modifyPersonProperties;
        private System.Windows.Forms.TabControl tab_Person;
        private System.Windows.Forms.TabPage pag_general;
        private System.Windows.Forms.TabPage pag_money;
        private System.Windows.Forms.TextBox tbx_personelNumber;
        private PSDatabase5DataSet pSDatabase5DataSet;
        private System.Windows.Forms.BindingSource personsTableBindingSource;
        private cactus_PS_.PSDatabase5DataSetTableAdapters.personsTableTableAdapter personsTableTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_nationalNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbx_job;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbx_fatherName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbx_NO;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbx_Born;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbx_phone2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbx_phone1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbx_address1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbx_address2;
        private System.Windows.Forms.GroupBox grp_RadioButtons;
        private System.Windows.Forms.RadioButton rdu_NoBeforeMoney;
        private System.Windows.Forms.RadioButton rdu_creditorBefore;
        private System.Windows.Forms.RadioButton rdu_indebtedBefore;
        private System.Windows.Forms.Label lbl_beforeRemainMoneyPrompt;
        private System.Windows.Forms.TextBox tbx_indebtedOrCreditorPrice;
        private System.Windows.Forms.TextBox tbx_personID;
        private System.Windows.Forms.TextBox tbx_beforeRemainMoney;
        private System.Windows.Forms.TextBox tbx_beforeType;
        private System.Windows.Forms.ComboBox cmb_projectsTitle;
        private System.Windows.Forms.BindingSource projectsTableBindingSource;
        private cactus_PS_.PSDatabase5DataSetTableAdapters.projectsTableTableAdapter projectsTableTableAdapter;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.BindingSource projectsPersonsBindingSource;
        private cactus_PS_.PSDatabase5DataSetTableAdapters.projectsPersonsTableAdapter projectsPersonsTableAdapter;
        private System.Windows.Forms.Button btn_viewAllPersons;
        private System.Windows.Forms.Button btn_ejectPersonFromCurrentProject;
        private System.Windows.Forms.PictureBox pic_personFace;
        private System.Windows.Forms.Button btn_choosePic;
        private System.Windows.Forms.Button btn_deletePic;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}