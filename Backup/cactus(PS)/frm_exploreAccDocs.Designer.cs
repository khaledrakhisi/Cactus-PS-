namespace cactus_PS_
{
    partial class frm_exploreAccDocs
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.pag_viaDocNumber = new System.Windows.Forms.TabPage();
            this.rdu_allAccDocs = new System.Windows.Forms.RadioButton();
            this.rdu_betweensNumber = new System.Windows.Forms.RadioButton();
            this.rdu_equalsToNumber = new System.Windows.Forms.RadioButton();
            this.rdu_moreThanNumber = new System.Windows.Forms.RadioButton();
            this.rdu_lessThanNumber = new System.Windows.Forms.RadioButton();
            this.num_toNumber = new System.Windows.Forms.NumericUpDown();
            this.pnl_rangeNumber = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.num_fromNumber = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pag_viaDocDate = new System.Windows.Forms.TabPage();
            this.pnl_rangeDate = new System.Windows.Forms.Panel();
            this.mTbx_fromDate = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mTbx_toDate = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rdu_betweensDate = new System.Windows.Forms.RadioButton();
            this.rdu_equalsToDate = new System.Windows.Forms.RadioButton();
            this.rdu_moreThanDate = new System.Windows.Forms.RadioButton();
            this.rdu_lessThanDate = new System.Windows.Forms.RadioButton();
            this.pag_viaDocPrice = new System.Windows.Forms.TabPage();
            this.lbl_priceInChars = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbx_accDocPrice = new System.Windows.Forms.TextBox();
            this.pag_viaDocComment = new System.Windows.Forms.TabPage();
            this.tbx_AccDocComment = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pSDatabase5DataSet = new cactus_PS_.PSDatabase5DataSet();
            this.btn_provideReport = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.pag_viaDocNumber.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_toNumber)).BeginInit();
            this.pnl_rangeNumber.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_fromNumber)).BeginInit();
            this.pag_viaDocDate.SuspendLayout();
            this.pnl_rangeDate.SuspendLayout();
            this.pag_viaDocPrice.SuspendLayout();
            this.pag_viaDocComment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pSDatabase5DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.pag_viaDocNumber);
            this.tabControl1.Controls.Add(this.pag_viaDocDate);
            this.tabControl1.Controls.Add(this.pag_viaDocPrice);
            this.tabControl1.Controls.Add(this.pag_viaDocComment);
            this.tabControl1.Location = new System.Drawing.Point(23, 23);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(475, 190);
            this.tabControl1.TabIndex = 0;
            // 
            // pag_viaDocNumber
            // 
            this.pag_viaDocNumber.Controls.Add(this.rdu_allAccDocs);
            this.pag_viaDocNumber.Controls.Add(this.rdu_betweensNumber);
            this.pag_viaDocNumber.Controls.Add(this.rdu_equalsToNumber);
            this.pag_viaDocNumber.Controls.Add(this.rdu_moreThanNumber);
            this.pag_viaDocNumber.Controls.Add(this.rdu_lessThanNumber);
            this.pag_viaDocNumber.Controls.Add(this.num_toNumber);
            this.pag_viaDocNumber.Controls.Add(this.pnl_rangeNumber);
            this.pag_viaDocNumber.Controls.Add(this.label5);
            this.pag_viaDocNumber.Location = new System.Drawing.Point(4, 35);
            this.pag_viaDocNumber.Name = "pag_viaDocNumber";
            this.pag_viaDocNumber.Padding = new System.Windows.Forms.Padding(3);
            this.pag_viaDocNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pag_viaDocNumber.Size = new System.Drawing.Size(467, 151);
            this.pag_viaDocNumber.TabIndex = 0;
            this.pag_viaDocNumber.Text = "شماره سند";
            this.pag_viaDocNumber.UseVisualStyleBackColor = true;
            // 
            // rdu_allAccDocs
            // 
            this.rdu_allAccDocs.AutoSize = true;
            this.rdu_allAccDocs.Location = new System.Drawing.Point(9, 6);
            this.rdu_allAccDocs.Name = "rdu_allAccDocs";
            this.rdu_allAccDocs.Size = new System.Drawing.Size(86, 30);
            this.rdu_allAccDocs.TabIndex = 5;
            this.rdu_allAccDocs.Text = "همه اسناد";
            this.rdu_allAccDocs.UseVisualStyleBackColor = true;
            this.rdu_allAccDocs.CheckedChanged += new System.EventHandler(this.rdu_allAccDocs_CheckedChanged);
            // 
            // rdu_betweensNumber
            // 
            this.rdu_betweensNumber.AutoSize = true;
            this.rdu_betweensNumber.Location = new System.Drawing.Point(112, 6);
            this.rdu_betweensNumber.Name = "rdu_betweensNumber";
            this.rdu_betweensNumber.Size = new System.Drawing.Size(64, 30);
            this.rdu_betweensNumber.TabIndex = 4;
            this.rdu_betweensNumber.Text = "ما بین";
            this.rdu_betweensNumber.UseVisualStyleBackColor = true;
            this.rdu_betweensNumber.CheckedChanged += new System.EventHandler(this.rdu_betweensNumber_CheckedChanged);
            // 
            // rdu_equalsToNumber
            // 
            this.rdu_equalsToNumber.AutoSize = true;
            this.rdu_equalsToNumber.Checked = true;
            this.rdu_equalsToNumber.Location = new System.Drawing.Point(193, 6);
            this.rdu_equalsToNumber.Name = "rdu_equalsToNumber";
            this.rdu_equalsToNumber.Size = new System.Drawing.Size(69, 30);
            this.rdu_equalsToNumber.TabIndex = 3;
            this.rdu_equalsToNumber.TabStop = true;
            this.rdu_equalsToNumber.Text = "مساوی";
            this.rdu_equalsToNumber.UseVisualStyleBackColor = true;
            // 
            // rdu_moreThanNumber
            // 
            this.rdu_moreThanNumber.AutoSize = true;
            this.rdu_moreThanNumber.Location = new System.Drawing.Point(280, 6);
            this.rdu_moreThanNumber.Name = "rdu_moreThanNumber";
            this.rdu_moreThanNumber.Size = new System.Drawing.Size(77, 30);
            this.rdu_moreThanNumber.TabIndex = 2;
            this.rdu_moreThanNumber.Text = "بزرگتر از";
            this.rdu_moreThanNumber.UseVisualStyleBackColor = true;
            // 
            // rdu_lessThanNumber
            // 
            this.rdu_lessThanNumber.AutoSize = true;
            this.rdu_lessThanNumber.Location = new System.Drawing.Point(373, 6);
            this.rdu_lessThanNumber.Name = "rdu_lessThanNumber";
            this.rdu_lessThanNumber.Size = new System.Drawing.Size(85, 30);
            this.rdu_lessThanNumber.TabIndex = 1;
            this.rdu_lessThanNumber.Text = "کوچکتر از";
            this.rdu_lessThanNumber.UseVisualStyleBackColor = true;
            // 
            // num_toNumber
            // 
            this.num_toNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.num_toNumber.Location = new System.Drawing.Point(16, 53);
            this.num_toNumber.Maximum = new decimal(new int[] {
            5000000,
            0,
            0,
            0});
            this.num_toNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_toNumber.Name = "num_toNumber";
            this.num_toNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.num_toNumber.Size = new System.Drawing.Size(121, 33);
            this.num_toNumber.TabIndex = 0;
            this.num_toNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // pnl_rangeNumber
            // 
            this.pnl_rangeNumber.Controls.Add(this.label2);
            this.pnl_rangeNumber.Controls.Add(this.num_fromNumber);
            this.pnl_rangeNumber.Controls.Add(this.label1);
            this.pnl_rangeNumber.Location = new System.Drawing.Point(140, 94);
            this.pnl_rangeNumber.Name = "pnl_rangeNumber";
            this.pnl_rangeNumber.Size = new System.Drawing.Size(318, 51);
            this.pnl_rangeNumber.TabIndex = 4;
            this.pnl_rangeNumber.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "تا شماره ی";
            // 
            // num_fromNumber
            // 
            this.num_fromNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.num_fromNumber.Location = new System.Drawing.Point(87, 4);
            this.num_fromNumber.Maximum = new decimal(new int[] {
            5000000,
            0,
            0,
            0});
            this.num_fromNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_fromNumber.Name = "num_fromNumber";
            this.num_fromNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.num_fromNumber.Size = new System.Drawing.Size(127, 33);
            this.num_fromNumber.TabIndex = 1;
            this.num_fromNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "از شماره ی";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(143, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 26);
            this.label5.TabIndex = 6;
            this.label5.Text = "شماره سند :";
            // 
            // pag_viaDocDate
            // 
            this.pag_viaDocDate.Controls.Add(this.pnl_rangeDate);
            this.pag_viaDocDate.Controls.Add(this.mTbx_toDate);
            this.pag_viaDocDate.Controls.Add(this.label6);
            this.pag_viaDocDate.Controls.Add(this.rdu_betweensDate);
            this.pag_viaDocDate.Controls.Add(this.rdu_equalsToDate);
            this.pag_viaDocDate.Controls.Add(this.rdu_moreThanDate);
            this.pag_viaDocDate.Controls.Add(this.rdu_lessThanDate);
            this.pag_viaDocDate.Location = new System.Drawing.Point(4, 35);
            this.pag_viaDocDate.Name = "pag_viaDocDate";
            this.pag_viaDocDate.Padding = new System.Windows.Forms.Padding(3);
            this.pag_viaDocDate.Size = new System.Drawing.Size(467, 151);
            this.pag_viaDocDate.TabIndex = 1;
            this.pag_viaDocDate.Text = "تاریخ سند";
            this.pag_viaDocDate.UseVisualStyleBackColor = true;
            // 
            // pnl_rangeDate
            // 
            this.pnl_rangeDate.Controls.Add(this.mTbx_fromDate);
            this.pnl_rangeDate.Controls.Add(this.label3);
            this.pnl_rangeDate.Controls.Add(this.label4);
            this.pnl_rangeDate.Location = new System.Drawing.Point(166, 94);
            this.pnl_rangeDate.Name = "pnl_rangeDate";
            this.pnl_rangeDate.Size = new System.Drawing.Size(228, 51);
            this.pnl_rangeDate.TabIndex = 12;
            this.pnl_rangeDate.Visible = false;
            // 
            // mTbx_fromDate
            // 
            this.mTbx_fromDate.AllowPromptAsInput = false;
            this.mTbx_fromDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mTbx_fromDate.Culture = new System.Globalization.CultureInfo("");
            this.mTbx_fromDate.Location = new System.Drawing.Point(68, 2);
            this.mTbx_fromDate.Mask = "0000/00/00";
            this.mTbx_fromDate.Name = "mTbx_fromDate";
            this.mTbx_fromDate.PromptChar = ' ';
            this.mTbx_fromDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mTbx_fromDate.Size = new System.Drawing.Size(95, 33);
            this.mTbx_fromDate.TabIndex = 3;
            this.mTbx_fromDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mTbx_fromDate_KeyDown);
            this.mTbx_fromDate.Leave += new System.EventHandler(this.mTbx_fromDate_Leave);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "تا تاریخ";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "از تاریخ";
            // 
            // mTbx_toDate
            // 
            this.mTbx_toDate.Location = new System.Drawing.Point(46, 58);
            this.mTbx_toDate.Mask = "0000/00/00";
            this.mTbx_toDate.Name = "mTbx_toDate";
            this.mTbx_toDate.PromptChar = ' ';
            this.mTbx_toDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mTbx_toDate.Size = new System.Drawing.Size(105, 33);
            this.mTbx_toDate.TabIndex = 15;
            this.mTbx_toDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mTbx_toDate_KeyDown);
            this.mTbx_toDate.Leave += new System.EventHandler(this.mTbx_toDate_Leave);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(166, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 26);
            this.label6.TabIndex = 14;
            this.label6.Text = "تاریخ سند :";
            // 
            // rdu_betweensDate
            // 
            this.rdu_betweensDate.AutoSize = true;
            this.rdu_betweensDate.Location = new System.Drawing.Point(55, 6);
            this.rdu_betweensDate.Name = "rdu_betweensDate";
            this.rdu_betweensDate.Size = new System.Drawing.Size(64, 30);
            this.rdu_betweensDate.TabIndex = 11;
            this.rdu_betweensDate.Text = "ما بین";
            this.rdu_betweensDate.UseVisualStyleBackColor = true;
            this.rdu_betweensDate.CheckedChanged += new System.EventHandler(this.rdu_betweensDate_CheckedChanged);
            // 
            // rdu_equalsToDate
            // 
            this.rdu_equalsToDate.AutoSize = true;
            this.rdu_equalsToDate.Checked = true;
            this.rdu_equalsToDate.Location = new System.Drawing.Point(139, 6);
            this.rdu_equalsToDate.Name = "rdu_equalsToDate";
            this.rdu_equalsToDate.Size = new System.Drawing.Size(69, 30);
            this.rdu_equalsToDate.TabIndex = 10;
            this.rdu_equalsToDate.TabStop = true;
            this.rdu_equalsToDate.Text = "مساوی";
            this.rdu_equalsToDate.UseVisualStyleBackColor = true;
            // 
            // rdu_moreThanDate
            // 
            this.rdu_moreThanDate.AutoSize = true;
            this.rdu_moreThanDate.Location = new System.Drawing.Point(228, 6);
            this.rdu_moreThanDate.Name = "rdu_moreThanDate";
            this.rdu_moreThanDate.Size = new System.Drawing.Size(77, 30);
            this.rdu_moreThanDate.TabIndex = 9;
            this.rdu_moreThanDate.Text = "بزرگتر از";
            this.rdu_moreThanDate.UseVisualStyleBackColor = true;
            // 
            // rdu_lessThanDate
            // 
            this.rdu_lessThanDate.AutoSize = true;
            this.rdu_lessThanDate.Location = new System.Drawing.Point(325, 6);
            this.rdu_lessThanDate.Name = "rdu_lessThanDate";
            this.rdu_lessThanDate.Size = new System.Drawing.Size(85, 30);
            this.rdu_lessThanDate.TabIndex = 8;
            this.rdu_lessThanDate.Text = "کوچکتر از";
            this.rdu_lessThanDate.UseVisualStyleBackColor = true;
            // 
            // pag_viaDocPrice
            // 
            this.pag_viaDocPrice.Controls.Add(this.lbl_priceInChars);
            this.pag_viaDocPrice.Controls.Add(this.label8);
            this.pag_viaDocPrice.Controls.Add(this.tbx_accDocPrice);
            this.pag_viaDocPrice.Location = new System.Drawing.Point(4, 35);
            this.pag_viaDocPrice.Name = "pag_viaDocPrice";
            this.pag_viaDocPrice.Padding = new System.Windows.Forms.Padding(3);
            this.pag_viaDocPrice.Size = new System.Drawing.Size(467, 151);
            this.pag_viaDocPrice.TabIndex = 2;
            this.pag_viaDocPrice.Text = "مبلغ سند";
            this.pag_viaDocPrice.UseVisualStyleBackColor = true;
            // 
            // lbl_priceInChars
            // 
            this.lbl_priceInChars.AllowDrop = true;
            this.lbl_priceInChars.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_priceInChars.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbl_priceInChars.Location = new System.Drawing.Point(16, 72);
            this.lbl_priceInChars.Name = "lbl_priceInChars";
            this.lbl_priceInChars.Size = new System.Drawing.Size(433, 31);
            this.lbl_priceInChars.TabIndex = 2;
            this.lbl_priceInChars.Text = "صفر ریال";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(324, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 26);
            this.label8.TabIndex = 1;
            this.label8.Text = "مبلغ :";
            // 
            // tbx_accDocPrice
            // 
            this.tbx_accDocPrice.Location = new System.Drawing.Point(97, 25);
            this.tbx_accDocPrice.Name = "tbx_accDocPrice";
            this.tbx_accDocPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbx_accDocPrice.Size = new System.Drawing.Size(221, 33);
            this.tbx_accDocPrice.TabIndex = 0;
            this.tbx_accDocPrice.Text = "0";
            this.tbx_accDocPrice.TextChanged += new System.EventHandler(this.tbx_accDocPrice_TextChanged);
            // 
            // pag_viaDocComment
            // 
            this.pag_viaDocComment.Controls.Add(this.tbx_AccDocComment);
            this.pag_viaDocComment.Controls.Add(this.label7);
            this.pag_viaDocComment.Location = new System.Drawing.Point(4, 35);
            this.pag_viaDocComment.Name = "pag_viaDocComment";
            this.pag_viaDocComment.Padding = new System.Windows.Forms.Padding(3);
            this.pag_viaDocComment.Size = new System.Drawing.Size(467, 151);
            this.pag_viaDocComment.TabIndex = 3;
            this.pag_viaDocComment.Text = "توضیحات سند";
            this.pag_viaDocComment.UseVisualStyleBackColor = true;
            // 
            // tbx_AccDocComment
            // 
            this.tbx_AccDocComment.Location = new System.Drawing.Point(17, 71);
            this.tbx_AccDocComment.Name = "tbx_AccDocComment";
            this.tbx_AccDocComment.Size = new System.Drawing.Size(433, 33);
            this.tbx_AccDocComment.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(165, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 26);
            this.label7.TabIndex = 1;
            this.label7.Text = "توضیحات سند شامل :";
            // 
            // pSDatabase5DataSet
            // 
            this.pSDatabase5DataSet.DataSetName = "PSDatabase5DataSet";
            this.pSDatabase5DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_provideReport
            // 
            this.btn_provideReport.Location = new System.Drawing.Point(151, 221);
            this.btn_provideReport.Name = "btn_provideReport";
            this.btn_provideReport.Size = new System.Drawing.Size(325, 39);
            this.btn_provideReport.TabIndex = 1;
            this.btn_provideReport.Text = "تهیه گزارش";
            this.btn_provideReport.UseVisualStyleBackColor = true;
            this.btn_provideReport.Click += new System.EventHandler(this.btn_provideReport_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(43, 221);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(102, 39);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Text = "لغو";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // frm_exploreAccDocs
            // 
            this.AcceptButton = this.btn_provideReport;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::cactus_PS_.Properties.Resources.forms_template;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(519, 279);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_provideReport);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_exploreAccDocs";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "مرور اسناد";
            this.Load += new System.EventHandler(this.frm_exploreAccDocs_Load);
            this.tabControl1.ResumeLayout(false);
            this.pag_viaDocNumber.ResumeLayout(false);
            this.pag_viaDocNumber.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_toNumber)).EndInit();
            this.pnl_rangeNumber.ResumeLayout(false);
            this.pnl_rangeNumber.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_fromNumber)).EndInit();
            this.pag_viaDocDate.ResumeLayout(false);
            this.pag_viaDocDate.PerformLayout();
            this.pnl_rangeDate.ResumeLayout(false);
            this.pnl_rangeDate.PerformLayout();
            this.pag_viaDocPrice.ResumeLayout(false);
            this.pag_viaDocPrice.PerformLayout();
            this.pag_viaDocComment.ResumeLayout(false);
            this.pag_viaDocComment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pSDatabase5DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage pag_viaDocNumber;
        private System.Windows.Forms.TabPage pag_viaDocDate;
        private System.Windows.Forms.TabPage pag_viaDocPrice;
        private System.Windows.Forms.TabPage pag_viaDocComment;
        private System.Windows.Forms.Panel pnl_rangeNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown num_fromNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown num_toNumber;
        private System.Windows.Forms.RadioButton rdu_betweensNumber;
        private System.Windows.Forms.RadioButton rdu_equalsToNumber;
        private System.Windows.Forms.RadioButton rdu_moreThanNumber;
        private System.Windows.Forms.RadioButton rdu_lessThanNumber;
        private System.Windows.Forms.RadioButton rdu_betweensDate;
        private System.Windows.Forms.RadioButton rdu_equalsToDate;
        private System.Windows.Forms.RadioButton rdu_moreThanDate;
        private System.Windows.Forms.RadioButton rdu_lessThanDate;
        private System.Windows.Forms.Panel pnl_rangeDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.MaskedTextBox mTbx_fromDate;
        private System.Windows.Forms.Button btn_provideReport;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbx_AccDocComment;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mTbx_toDate;
        private System.Windows.Forms.RadioButton rdu_allAccDocs;
        private PSDatabase5DataSet pSDatabase5DataSet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbx_accDocPrice;
        private System.Windows.Forms.Label lbl_priceInChars;

    }
}