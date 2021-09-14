namespace cactus_PS_
{
    partial class frm_buyInvoices
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
            this.pnl_public = new System.Windows.Forms.Panel();
            this.lbl_currentPosition = new System.Windows.Forms.Label();
            this.btn_returnPrior = new System.Windows.Forms.Button();
            this.btn_goNext = new System.Windows.Forms.Button();
            this.mTbx_Date = new System.Windows.Forms.MaskedTextBox();
            this.invoicesTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pSDatabase5DataSet = new cactus_PS_.PSDatabase5DataSet();
            this.label19 = new System.Windows.Forms.Label();
            this.tbx_ID = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_saveChanges = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.viwinvoiceItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_addItem = new System.Windows.Forms.Button();
            this.btn_removeItem = new System.Windows.Forms.Button();
            this.pnl_addRemove = new System.Windows.Forms.Panel();
            this.tbx_invoiceTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_invoiceTotalInChars = new System.Windows.Forms.Label();
            this.tbx_invoiceComment = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnl_comment = new System.Windows.Forms.Panel();
            this.pnl_total = new System.Windows.Forms.Panel();
            this.viw_invoiceItemsTableAdapter = new cactus_PS_.PSDatabase5DataSetTableAdapters.viw_invoiceItemsTableAdapter();
            this.invoicesTableTableAdapter = new cactus_PS_.PSDatabase5DataSetTableAdapters.invoicesTableTableAdapter();
            this.projectsTableTableAdapter = new cactus_PS_.PSDatabase5DataSetTableAdapters.projectsTableTableAdapter();
            this.btn_close = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_persons = new System.Windows.Forms.ComboBox();
            this.personsTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personsTableTableAdapter = new cactus_PS_.PSDatabase5DataSetTableAdapters.personsTableTableAdapter();
            this.invoiceItemrowDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spentDefNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceItemamountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceItemphiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceItemtotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_persons = new System.Windows.Forms.Panel();
            this.pnl_public.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSDatabase5DataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viwinvoiceItemsBindingSource)).BeginInit();
            this.pnl_addRemove.SuspendLayout();
            this.pnl_comment.SuspendLayout();
            this.pnl_total.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personsTableBindingSource)).BeginInit();
            this.pnl_persons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_public
            // 
            this.pnl_public.BackColor = System.Drawing.Color.Transparent;
            this.pnl_public.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_public.Controls.Add(this.lbl_currentPosition);
            this.pnl_public.Controls.Add(this.btn_returnPrior);
            this.pnl_public.Controls.Add(this.btn_goNext);
            this.pnl_public.Controls.Add(this.mTbx_Date);
            this.pnl_public.Controls.Add(this.label19);
            this.pnl_public.Controls.Add(this.tbx_ID);
            this.pnl_public.Controls.Add(this.label18);
            this.pnl_public.Location = new System.Drawing.Point(36, 81);
            this.pnl_public.Name = "pnl_public";
            this.pnl_public.Size = new System.Drawing.Size(652, 41);
            this.pnl_public.TabIndex = 98;
            // 
            // lbl_currentPosition
            // 
            this.lbl_currentPosition.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_currentPosition.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_currentPosition.Location = new System.Drawing.Point(359, 1);
            this.lbl_currentPosition.Name = "lbl_currentPosition";
            this.lbl_currentPosition.Size = new System.Drawing.Size(120, 36);
            this.lbl_currentPosition.TabIndex = 100;
            this.lbl_currentPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_returnPrior
            // 
            this.btn_returnPrior.Location = new System.Drawing.Point(483, 3);
            this.btn_returnPrior.Name = "btn_returnPrior";
            this.btn_returnPrior.Size = new System.Drawing.Size(77, 34);
            this.btn_returnPrior.TabIndex = 99;
            this.btn_returnPrior.Text = "قبلی >";
            this.btn_returnPrior.UseVisualStyleBackColor = true;
            this.btn_returnPrior.Click += new System.EventHandler(this.btn_returnPrior_Click);
            // 
            // btn_goNext
            // 
            this.btn_goNext.Location = new System.Drawing.Point(566, 3);
            this.btn_goNext.Name = "btn_goNext";
            this.btn_goNext.Size = new System.Drawing.Size(78, 34);
            this.btn_goNext.TabIndex = 98;
            this.btn_goNext.Text = " < بعدی";
            this.btn_goNext.UseVisualStyleBackColor = true;
            this.btn_goNext.Click += new System.EventHandler(this.btn_goNext_Click);
            // 
            // mTbx_Date
            // 
            this.mTbx_Date.AllowPromptAsInput = false;
            this.mTbx_Date.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesTableBindingSource, "invoice_date", true));
            this.mTbx_Date.Location = new System.Drawing.Point(170, 4);
            this.mTbx_Date.Mask = "0000/00/00";
            this.mTbx_Date.Name = "mTbx_Date";
            this.mTbx_Date.PromptChar = ' ';
            this.mTbx_Date.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mTbx_Date.Size = new System.Drawing.Size(91, 33);
            this.mTbx_Date.TabIndex = 97;
            this.mTbx_Date.Leave += new System.EventHandler(this.mTbx_Date_Leave);
            // 
            // invoicesTableBindingSource
            // 
            this.invoicesTableBindingSource.DataMember = "invoicesTable";
            this.invoicesTableBindingSource.DataSource = this.pSDatabase5DataSet;
            // 
            // pSDatabase5DataSet
            // 
            this.pSDatabase5DataSet.DataSetName = "PSDatabase5DataSet";
            this.pSDatabase5DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(77, 7);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(87, 26);
            this.label19.TabIndex = 96;
            this.label19.Text = "شماره فاکتور:";
            // 
            // tbx_ID
            // 
            this.tbx_ID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesTableBindingSource, "invoice_id", true));
            this.tbx_ID.Location = new System.Drawing.Point(3, 3);
            this.tbx_ID.Name = "tbx_ID";
            this.tbx_ID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_ID.Size = new System.Drawing.Size(68, 33);
            this.tbx_ID.TabIndex = 95;
            this.tbx_ID.Text = "0";
            this.tbx_ID.TextChanged += new System.EventHandler(this.tbx_ID_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(267, 7);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(86, 26);
            this.label18.TabIndex = 94;
            this.label18.Text = "تاریخ فاکتور :";
            // 
            // btn_print
            // 
            this.btn_print.BackColor = System.Drawing.Color.Azure;
            this.btn_print.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_print.ForeColor = System.Drawing.Color.DarkViolet;
            this.btn_print.Location = new System.Drawing.Point(3, 3);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(112, 40);
            this.btn_print.TabIndex = 102;
            this.btn_print.Text = "چاپ فاکتور";
            this.btn_print.UseVisualStyleBackColor = false;
            // 
            // btn_saveChanges
            // 
            this.btn_saveChanges.BackColor = System.Drawing.Color.Azure;
            this.btn_saveChanges.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_saveChanges.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_saveChanges.Location = new System.Drawing.Point(239, 4);
            this.btn_saveChanges.Name = "btn_saveChanges";
            this.btn_saveChanges.Size = new System.Drawing.Size(112, 39);
            this.btn_saveChanges.TabIndex = 101;
            this.btn_saveChanges.Text = "ثبت فاکتور";
            this.btn_saveChanges.UseVisualStyleBackColor = false;
            this.btn_saveChanges.Click += new System.EventHandler(this.btn_saveChanges_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Azure;
            this.btn_delete.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_delete.Location = new System.Drawing.Point(121, 4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(112, 39);
            this.btn_delete.TabIndex = 100;
            this.btn_delete.Text = "حذف فاکتور";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_new
            // 
            this.btn_new.BackColor = System.Drawing.Color.Azure;
            this.btn_new.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_new.ForeColor = System.Drawing.Color.Green;
            this.btn_new.Location = new System.Drawing.Point(357, 3);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(112, 40);
            this.btn_new.TabIndex = 99;
            this.btn_new.Text = "*فاکتور جدید";
            this.btn_new.UseVisualStyleBackColor = false;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btn_print);
            this.panel1.Controls.Add(this.btn_new);
            this.panel1.Controls.Add(this.btn_saveChanges);
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Location = new System.Drawing.Point(125, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 48);
            this.panel1.TabIndex = 103;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.invoiceItemrowDataGridViewTextBoxColumn,
            this.spentDefNameDataGridViewTextBoxColumn,
            this.projectTitle,
            this.invoiceItemamountDataGridViewTextBoxColumn,
            this.invoiceItemphiDataGridViewTextBoxColumn,
            this.invoiceItemtotalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.viwinvoiceItemsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(38, 178);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 10;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(648, 220);
            this.dataGridView1.TabIndex = 104;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // viwinvoiceItemsBindingSource
            // 
            this.viwinvoiceItemsBindingSource.DataMember = "viw_invoiceItems";
            this.viwinvoiceItemsBindingSource.DataSource = this.pSDatabase5DataSet;
            // 
            // btn_addItem
            // 
            this.btn_addItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_addItem.ForeColor = System.Drawing.Color.Green;
            this.btn_addItem.Location = new System.Drawing.Point(73, 3);
            this.btn_addItem.Name = "btn_addItem";
            this.btn_addItem.Size = new System.Drawing.Size(143, 31);
            this.btn_addItem.TabIndex = 105;
            this.btn_addItem.Text = "+ اضافه کردن هزینه";
            this.btn_addItem.UseVisualStyleBackColor = true;
            this.btn_addItem.Click += new System.EventHandler(this.btn_addItem_Click);
            // 
            // btn_removeItem
            // 
            this.btn_removeItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_removeItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_removeItem.Location = new System.Drawing.Point(3, 3);
            this.btn_removeItem.Name = "btn_removeItem";
            this.btn_removeItem.Size = new System.Drawing.Size(64, 31);
            this.btn_removeItem.TabIndex = 106;
            this.btn_removeItem.Text = "- حذف";
            this.btn_removeItem.UseVisualStyleBackColor = true;
            this.btn_removeItem.Click += new System.EventHandler(this.btn_removeItem_Click);
            // 
            // pnl_addRemove
            // 
            this.pnl_addRemove.BackColor = System.Drawing.Color.Transparent;
            this.pnl_addRemove.Controls.Add(this.btn_removeItem);
            this.pnl_addRemove.Controls.Add(this.btn_addItem);
            this.pnl_addRemove.Location = new System.Drawing.Point(456, 136);
            this.pnl_addRemove.Name = "pnl_addRemove";
            this.pnl_addRemove.Size = new System.Drawing.Size(220, 37);
            this.pnl_addRemove.TabIndex = 107;
            // 
            // tbx_invoiceTotal
            // 
            this.tbx_invoiceTotal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesTableBindingSource, "invoice_total", true));
            this.tbx_invoiceTotal.Location = new System.Drawing.Point(358, 2);
            this.tbx_invoiceTotal.Name = "tbx_invoiceTotal";
            this.tbx_invoiceTotal.ReadOnly = true;
            this.tbx_invoiceTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_invoiceTotal.Size = new System.Drawing.Size(158, 33);
            this.tbx_invoiceTotal.TabIndex = 108;
            this.tbx_invoiceTotal.Text = "0";
            this.tbx_invoiceTotal.TextChanged += new System.EventHandler(this.tbx_invoiceTotal_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(532, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 26);
            this.label1.TabIndex = 101;
            this.label1.Text = "جمع کل:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(316, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 26);
            this.label2.TabIndex = 109;
            this.label2.Text = "ریال";
            // 
            // lbl_invoiceTotalInChars
            // 
            this.lbl_invoiceTotalInChars.BackColor = System.Drawing.Color.Transparent;
            this.lbl_invoiceTotalInChars.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_invoiceTotalInChars.ForeColor = System.Drawing.Color.Green;
            this.lbl_invoiceTotalInChars.Location = new System.Drawing.Point(4, 4);
            this.lbl_invoiceTotalInChars.Name = "lbl_invoiceTotalInChars";
            this.lbl_invoiceTotalInChars.Size = new System.Drawing.Size(294, 30);
            this.lbl_invoiceTotalInChars.TabIndex = 110;
            this.lbl_invoiceTotalInChars.Text = "صفر ریال";
            // 
            // tbx_invoiceComment
            // 
            this.tbx_invoiceComment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesTableBindingSource, "invoice_comment", true));
            this.tbx_invoiceComment.Location = new System.Drawing.Point(4, 3);
            this.tbx_invoiceComment.Name = "tbx_invoiceComment";
            this.tbx_invoiceComment.Size = new System.Drawing.Size(512, 33);
            this.tbx_invoiceComment.TabIndex = 114;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(530, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 26);
            this.label3.TabIndex = 115;
            this.label3.Text = "توضیحات :";
            // 
            // pnl_comment
            // 
            this.pnl_comment.BackColor = System.Drawing.Color.Transparent;
            this.pnl_comment.Controls.Add(this.label3);
            this.pnl_comment.Controls.Add(this.tbx_invoiceComment);
            this.pnl_comment.Location = new System.Drawing.Point(56, 447);
            this.pnl_comment.Name = "pnl_comment";
            this.pnl_comment.Size = new System.Drawing.Size(612, 43);
            this.pnl_comment.TabIndex = 116;
            // 
            // pnl_total
            // 
            this.pnl_total.BackColor = System.Drawing.Color.Transparent;
            this.pnl_total.Controls.Add(this.lbl_invoiceTotalInChars);
            this.pnl_total.Controls.Add(this.label2);
            this.pnl_total.Controls.Add(this.label1);
            this.pnl_total.Controls.Add(this.tbx_invoiceTotal);
            this.pnl_total.Location = new System.Drawing.Point(56, 404);
            this.pnl_total.Name = "pnl_total";
            this.pnl_total.Size = new System.Drawing.Size(612, 41);
            this.pnl_total.TabIndex = 117;
            // 
            // viw_invoiceItemsTableAdapter
            // 
            this.viw_invoiceItemsTableAdapter.ClearBeforeFill = true;
            // 
            // invoicesTableTableAdapter
            // 
            this.invoicesTableTableAdapter.ClearBeforeFill = true;
            // 
            // projectsTableTableAdapter
            // 
            this.projectsTableTableAdapter.ClearBeforeFill = true;
            // 
            // btn_close
            // 
            this.btn_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_close.Location = new System.Drawing.Point(39, 497);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(196, 36);
            this.btn_close.TabIndex = 118;
            this.btn_close.Text = "بستن";
            this.btn_close.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(235, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 26);
            this.label4.TabIndex = 119;
            this.label4.Text = "خرید از :";
            // 
            // cmb_persons
            // 
            this.cmb_persons.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.invoicesTableBindingSource, "personID", true));
            this.cmb_persons.DataSource = this.personsTableBindingSource;
            this.cmb_persons.DisplayMember = "personFamilyAndName";
            this.cmb_persons.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_persons.FormattingEnabled = true;
            this.cmb_persons.Location = new System.Drawing.Point(23, 6);
            this.cmb_persons.Name = "cmb_persons";
            this.cmb_persons.Size = new System.Drawing.Size(206, 34);
            this.cmb_persons.TabIndex = 120;
            this.cmb_persons.ValueMember = "personID";
            this.cmb_persons.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_persons_KeyPress);
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
            // invoiceItemrowDataGridViewTextBoxColumn
            // 
            this.invoiceItemrowDataGridViewTextBoxColumn.DataPropertyName = "invoiceItem_row";
            this.invoiceItemrowDataGridViewTextBoxColumn.HeaderText = "ردیف";
            this.invoiceItemrowDataGridViewTextBoxColumn.Name = "invoiceItemrowDataGridViewTextBoxColumn";
            this.invoiceItemrowDataGridViewTextBoxColumn.ReadOnly = true;
            this.invoiceItemrowDataGridViewTextBoxColumn.Width = 50;
            // 
            // spentDefNameDataGridViewTextBoxColumn
            // 
            this.spentDefNameDataGridViewTextBoxColumn.DataPropertyName = "spentDefName";
            this.spentDefNameDataGridViewTextBoxColumn.HeaderText = "هزینه";
            this.spentDefNameDataGridViewTextBoxColumn.Name = "spentDefNameDataGridViewTextBoxColumn";
            this.spentDefNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // projectTitle
            // 
            this.projectTitle.DataPropertyName = "projectTitle";
            this.projectTitle.HeaderText = "پروژه";
            this.projectTitle.Name = "projectTitle";
            this.projectTitle.ReadOnly = true;
            this.projectTitle.Width = 120;
            // 
            // invoiceItemamountDataGridViewTextBoxColumn
            // 
            this.invoiceItemamountDataGridViewTextBoxColumn.DataPropertyName = "invoiceItem_amount";
            this.invoiceItemamountDataGridViewTextBoxColumn.HeaderText = "مقدار/تعداد";
            this.invoiceItemamountDataGridViewTextBoxColumn.Name = "invoiceItemamountDataGridViewTextBoxColumn";
            this.invoiceItemamountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // invoiceItemphiDataGridViewTextBoxColumn
            // 
            this.invoiceItemphiDataGridViewTextBoxColumn.DataPropertyName = "invoiceItem_phi";
            this.invoiceItemphiDataGridViewTextBoxColumn.HeaderText = "فی";
            this.invoiceItemphiDataGridViewTextBoxColumn.Name = "invoiceItemphiDataGridViewTextBoxColumn";
            this.invoiceItemphiDataGridViewTextBoxColumn.ReadOnly = true;
            this.invoiceItemphiDataGridViewTextBoxColumn.Width = 120;
            // 
            // invoiceItemtotalDataGridViewTextBoxColumn
            // 
            this.invoiceItemtotalDataGridViewTextBoxColumn.DataPropertyName = "invoiceItem_total";
            this.invoiceItemtotalDataGridViewTextBoxColumn.HeaderText = "جمع";
            this.invoiceItemtotalDataGridViewTextBoxColumn.Name = "invoiceItemtotalDataGridViewTextBoxColumn";
            this.invoiceItemtotalDataGridViewTextBoxColumn.ReadOnly = true;
            this.invoiceItemtotalDataGridViewTextBoxColumn.Width = 120;
            // 
            // pnl_persons
            // 
            this.pnl_persons.BackColor = System.Drawing.Color.Transparent;
            this.pnl_persons.Controls.Add(this.cmb_persons);
            this.pnl_persons.Controls.Add(this.label4);
            this.pnl_persons.Location = new System.Drawing.Point(36, 133);
            this.pnl_persons.Name = "pnl_persons";
            this.pnl_persons.Size = new System.Drawing.Size(310, 45);
            this.pnl_persons.TabIndex = 121;
            // 
            // frm_buyInvoices
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::cactus_PS_.Properties.Resources.forms_template1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(724, 559);
            this.Controls.Add(this.pnl_persons);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.pnl_total);
            this.Controls.Add(this.pnl_comment);
            this.Controls.Add(this.pnl_addRemove);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_public);
            this.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_buyInvoices";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فاکتور های خرید";
            this.Load += new System.EventHandler(this.frm_buyInvoices_Load);
            this.pnl_public.ResumeLayout(false);
            this.pnl_public.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSDatabase5DataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viwinvoiceItemsBindingSource)).EndInit();
            this.pnl_addRemove.ResumeLayout(false);
            this.pnl_comment.ResumeLayout(false);
            this.pnl_comment.PerformLayout();
            this.pnl_total.ResumeLayout(false);
            this.pnl_total.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personsTableBindingSource)).EndInit();
            this.pnl_persons.ResumeLayout(false);
            this.pnl_persons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_public;
        private System.Windows.Forms.Label lbl_currentPosition;
        private System.Windows.Forms.Button btn_returnPrior;
        private System.Windows.Forms.Button btn_goNext;
        private System.Windows.Forms.MaskedTextBox mTbx_Date;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tbx_ID;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Button btn_saveChanges;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_addItem;
        private System.Windows.Forms.Button btn_removeItem;
        private PSDatabase5DataSet pSDatabase5DataSet;
        private System.Windows.Forms.BindingSource viwinvoiceItemsBindingSource;
        private cactus_PS_.PSDatabase5DataSetTableAdapters.viw_invoiceItemsTableAdapter viw_invoiceItemsTableAdapter;
        private System.Windows.Forms.Panel pnl_addRemove;
        private System.Windows.Forms.BindingSource invoicesTableBindingSource;
        private cactus_PS_.PSDatabase5DataSetTableAdapters.invoicesTableTableAdapter invoicesTableTableAdapter;
        private System.Windows.Forms.TextBox tbx_invoiceTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_invoiceTotalInChars;
        private cactus_PS_.PSDatabase5DataSetTableAdapters.projectsTableTableAdapter projectsTableTableAdapter;
        private System.Windows.Forms.TextBox tbx_invoiceComment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnl_comment;
        private System.Windows.Forms.Panel pnl_total;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_persons;
        private System.Windows.Forms.BindingSource personsTableBindingSource;
        private cactus_PS_.PSDatabase5DataSetTableAdapters.personsTableTableAdapter personsTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceItemrowDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spentDefNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceItemamountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceItemphiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceItemtotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel pnl_persons;
    }
}