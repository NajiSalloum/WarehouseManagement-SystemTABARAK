namespace Tabarak
{
    partial class frmCustomer
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
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCloseSearch = new System.Windows.Forms.Button();
            this.dgvSearch = new System.Windows.Forms.DataGridView();
            this.btnShowSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.rbtnAdress = new System.Windows.Forms.RadioButton();
            this.rbtnEmail = new System.Windows.Forms.RadioButton();
            this.rbtnStartDate = new System.Windows.Forms.RadioButton();
            this.rbtnCustName = new System.Windows.Forms.RadioButton();
            this.rbtnCustNO = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.pnlData = new System.Windows.Forms.Panel();
            this.pnlNavication = new System.Windows.Forms.Panel();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.pnlPhones = new System.Windows.Forms.Panel();
            this.dgvPhones = new System.Windows.Forms.DataGridView();
            this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddPhone = new System.Windows.Forms.Button();
            this.btnDelAll = new System.Windows.Forms.Button();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustNO = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlSearch.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
            this.pnlData.SuspendLayout();
            this.pnlNavication.SuspendLayout();
            this.pnlPhones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhones)).BeginInit();
            this.pnlControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSearch
            // 
            this.pnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSearch.Controls.Add(this.groupBox1);
            this.pnlSearch.Controls.Add(this.label10);
            this.pnlSearch.Location = new System.Drawing.Point(20, 457);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(856, 421);
            this.pnlSearch.TabIndex = 1;
            this.pnlSearch.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_2);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCloseSearch);
            this.groupBox1.Controls.Add(this.dgvSearch);
            this.groupBox1.Controls.Add(this.btnShowSearch);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.rbtnAdress);
            this.groupBox1.Controls.Add(this.rbtnEmail);
            this.groupBox1.Controls.Add(this.rbtnStartDate);
            this.groupBox1.Controls.Add(this.rbtnCustName);
            this.groupBox1.Controls.Add(this.rbtnCustNO);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(28, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(798, 341);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search By";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnCloseSearch
            // 
            this.btnCloseSearch.BackColor = System.Drawing.Color.Red;
            this.btnCloseSearch.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCloseSearch.Location = new System.Drawing.Point(764, 11);
            this.btnCloseSearch.Name = "btnCloseSearch";
            this.btnCloseSearch.Size = new System.Drawing.Size(28, 23);
            this.btnCloseSearch.TabIndex = 14;
            this.btnCloseSearch.Text = "X";
            this.btnCloseSearch.UseVisualStyleBackColor = false;
            this.btnCloseSearch.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dgvSearch
            // 
            this.dgvSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSearch.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSearch.BackgroundColor = System.Drawing.Color.Aqua;
            this.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearch.Location = new System.Drawing.Point(6, 113);
            this.dgvSearch.Name = "dgvSearch";
            this.dgvSearch.ReadOnly = true;
            this.dgvSearch.Size = new System.Drawing.Size(768, 201);
            this.dgvSearch.TabIndex = 13;
            // 
            // btnShowSearch
            // 
            this.btnShowSearch.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowSearch.Location = new System.Drawing.Point(704, 64);
            this.btnShowSearch.Name = "btnShowSearch";
            this.btnShowSearch.Size = new System.Drawing.Size(70, 29);
            this.btnShowSearch.TabIndex = 12;
            this.btnShowSearch.Text = "Search";
            this.btnShowSearch.UseVisualStyleBackColor = true;
            this.btnShowSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(119, 70);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(544, 23);
            this.txtSearch.TabIndex = 11;
            this.txtSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(14, 72);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "search word";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // rbtnAdress
            // 
            this.rbtnAdress.AutoSize = true;
            this.rbtnAdress.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnAdress.Location = new System.Drawing.Point(609, 26);
            this.rbtnAdress.Name = "rbtnAdress";
            this.rbtnAdress.Size = new System.Drawing.Size(64, 17);
            this.rbtnAdress.TabIndex = 4;
            this.rbtnAdress.TabStop = true;
            this.rbtnAdress.Text = "Adress";
            this.rbtnAdress.UseVisualStyleBackColor = true;
            this.rbtnAdress.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // rbtnEmail
            // 
            this.rbtnEmail.AutoSize = true;
            this.rbtnEmail.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnEmail.Location = new System.Drawing.Point(509, 26);
            this.rbtnEmail.Name = "rbtnEmail";
            this.rbtnEmail.Size = new System.Drawing.Size(55, 17);
            this.rbtnEmail.TabIndex = 3;
            this.rbtnEmail.TabStop = true;
            this.rbtnEmail.Text = "Email";
            this.rbtnEmail.UseVisualStyleBackColor = true;
            this.rbtnEmail.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // rbtnStartDate
            // 
            this.rbtnStartDate.AutoSize = true;
            this.rbtnStartDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnStartDate.Location = new System.Drawing.Point(384, 26);
            this.rbtnStartDate.Name = "rbtnStartDate";
            this.rbtnStartDate.Size = new System.Drawing.Size(81, 17);
            this.rbtnStartDate.TabIndex = 2;
            this.rbtnStartDate.TabStop = true;
            this.rbtnStartDate.Text = "StartDate";
            this.rbtnStartDate.UseVisualStyleBackColor = true;
            this.rbtnStartDate.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rbtnCustName
            // 
            this.rbtnCustName.AutoSize = true;
            this.rbtnCustName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnCustName.Location = new System.Drawing.Point(254, 26);
            this.rbtnCustName.Name = "rbtnCustName";
            this.rbtnCustName.Size = new System.Drawing.Size(82, 17);
            this.rbtnCustName.TabIndex = 1;
            this.rbtnCustName.TabStop = true;
            this.rbtnCustName.Text = "CustName";
            this.rbtnCustName.UseVisualStyleBackColor = true;
            this.rbtnCustName.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbtnCustNO
            // 
            this.rbtnCustNO.AutoSize = true;
            this.rbtnCustNO.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnCustNO.Location = new System.Drawing.Point(125, 26);
            this.rbtnCustNO.Name = "rbtnCustNO";
            this.rbtnCustNO.Size = new System.Drawing.Size(65, 17);
            this.rbtnCustNO.TabIndex = 0;
            this.rbtnCustNO.TabStop = true;
            this.rbtnCustNO.Text = "CustNO";
            this.rbtnCustNO.UseVisualStyleBackColor = true;
            this.rbtnCustNO.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(315, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(199, 35);
            this.label10.TabIndex = 4;
            this.label10.Text = "Search From";
            // 
            // pnlData
            // 
            this.pnlData.BackgroundImage = global::Tabarak.Properties.Resources.bCustomer;
            this.pnlData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlData.Controls.Add(this.pnlNavication);
            this.pnlData.Controls.Add(this.pnlPhones);
            this.pnlData.Controls.Add(this.label7);
            this.pnlData.Controls.Add(this.pnlControls);
            this.pnlData.Controls.Add(this.dtpStartDate);
            this.pnlData.Controls.Add(this.txtAdress);
            this.pnlData.Controls.Add(this.label6);
            this.pnlData.Controls.Add(this.txtEmail);
            this.pnlData.Controls.Add(this.label5);
            this.pnlData.Controls.Add(this.label4);
            this.pnlData.Controls.Add(this.txtCustName);
            this.pnlData.Controls.Add(this.label3);
            this.pnlData.Controls.Add(this.label2);
            this.pnlData.Controls.Add(this.txtCustNO);
            this.pnlData.Controls.Add(this.label1);
            this.pnlData.Location = new System.Drawing.Point(20, 18);
            this.pnlData.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(856, 421);
            this.pnlData.TabIndex = 0;
            this.pnlData.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pnlNavication
            // 
            this.pnlNavication.BackColor = System.Drawing.Color.White;
            this.pnlNavication.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNavication.Controls.Add(this.btnFirst);
            this.pnlNavication.Controls.Add(this.btnNext);
            this.pnlNavication.Controls.Add(this.btnPrevious);
            this.pnlNavication.Controls.Add(this.btnLast);
            this.pnlNavication.Location = new System.Drawing.Point(549, 63);
            this.pnlNavication.Name = "pnlNavication";
            this.pnlNavication.Size = new System.Drawing.Size(302, 52);
            this.pnlNavication.TabIndex = 16;
            // 
            // btnFirst
            // 
            this.btnFirst.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirst.Location = new System.Drawing.Point(27, 14);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(54, 29);
            this.btnFirst.TabIndex = 23;
            this.btnFirst.Text = "First";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(87, 14);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(54, 29);
            this.btnNext.TabIndex = 22;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Location = new System.Drawing.Point(147, 13);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(65, 29);
            this.btnPrevious.TabIndex = 21;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnLast
            // 
            this.btnLast.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast.Location = new System.Drawing.Point(222, 13);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(54, 29);
            this.btnLast.TabIndex = 20;
            this.btnLast.Text = "Last";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // pnlPhones
            // 
            this.pnlPhones.BackColor = System.Drawing.Color.White;
            this.pnlPhones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlPhones.Controls.Add(this.dgvPhones);
            this.pnlPhones.Controls.Add(this.btnAddPhone);
            this.pnlPhones.Controls.Add(this.btnDelAll);
            this.pnlPhones.Controls.Add(this.cbxType);
            this.pnlPhones.Controls.Add(this.label9);
            this.pnlPhones.Controls.Add(this.txtPhone);
            this.pnlPhones.Controls.Add(this.label8);
            this.pnlPhones.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlPhones.Location = new System.Drawing.Point(166, 224);
            this.pnlPhones.Name = "pnlPhones";
            this.pnlPhones.Size = new System.Drawing.Size(470, 112);
            this.pnlPhones.TabIndex = 15;
            this.pnlPhones.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPhones_Paint);
            // 
            // dgvPhones
            // 
            this.dgvPhones.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPhone,
            this.colType});
            this.dgvPhones.Location = new System.Drawing.Point(220, -2);
            this.dgvPhones.Name = "dgvPhones";
            this.dgvPhones.Size = new System.Drawing.Size(241, 112);
            this.dgvPhones.TabIndex = 9;
            this.dgvPhones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // colPhone
            // 
            this.colPhone.HeaderText = "Phone";
            this.colPhone.Name = "colPhone";
            // 
            // colType
            // 
            this.colType.HeaderText = "Type";
            this.colType.Name = "colType";
            this.colType.Width = 120;
            // 
            // btnAddPhone
            // 
            this.btnAddPhone.Location = new System.Drawing.Point(50, 68);
            this.btnAddPhone.Name = "btnAddPhone";
            this.btnAddPhone.Size = new System.Drawing.Size(56, 29);
            this.btnAddPhone.TabIndex = 8;
            this.btnAddPhone.Text = "Add";
            this.btnAddPhone.UseVisualStyleBackColor = true;
            this.btnAddPhone.Click += new System.EventHandler(this.btnAddPhone_Click);
            // 
            // btnDelAll
            // 
            this.btnDelAll.Location = new System.Drawing.Point(163, 68);
            this.btnDelAll.Name = "btnDelAll";
            this.btnDelAll.Size = new System.Drawing.Size(51, 29);
            this.btnDelAll.TabIndex = 7;
            this.btnDelAll.Text = "Delete";
            this.btnDelAll.UseVisualStyleBackColor = true;
            this.btnDelAll.Click += new System.EventHandler(this.btnDelAll_Click);
            // 
            // cbxType
            // 
            this.cbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Items.AddRange(new object[] {
            "Etisalat",
            "Vodafone",
            "Mobinil",
            "Phone",
            "Fax"});
            this.cbxType.Location = new System.Drawing.Point(50, 31);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(164, 21);
            this.cbxType.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 34);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Type";
            // 
            // txtPhone
            // 
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Location = new System.Drawing.Point(50, 3);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(164, 21);
            this.txtPhone.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 6);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Phone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(24, 224);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "Phones";
            // 
            // pnlControls
            // 
            this.pnlControls.BackColor = System.Drawing.Color.White;
            this.pnlControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlControls.Controls.Add(this.btnAdd);
            this.pnlControls.Controls.Add(this.btnUpdate);
            this.pnlControls.Controls.Add(this.btnSearch);
            this.pnlControls.Controls.Add(this.btnClear);
            this.pnlControls.Controls.Add(this.btnDelete);
            this.pnlControls.Controls.Add(this.btnExit);
            this.pnlControls.Location = new System.Drawing.Point(28, 354);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(608, 62);
            this.pnlControls.TabIndex = 13;
            this.pnlControls.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(27, 16);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(88, 29);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(118, 16);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(88, 29);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(302, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(88, 29);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(394, 16);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(88, 29);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(213, 16);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 29);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(488, 16);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 29);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(166, 112);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(164, 27);
            this.dtpStartDate.TabIndex = 12;
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(166, 181);
            this.txtAdress.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(346, 27);
            this.txtAdress.TabIndex = 11;
            this.txtAdress.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(24, 189);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Adress";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(166, 146);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(346, 27);
            this.txtEmail.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(24, 154);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Email";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(24, 120);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Start Date";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtCustName
            // 
            this.txtCustName.Location = new System.Drawing.Point(166, 78);
            this.txtCustName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(346, 27);
            this.txtCustName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(24, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Customer Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(302, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 35);
            this.label2.TabIndex = 3;
            this.label2.Text = "Customer From";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // txtCustNO
            // 
            this.txtCustNO.BackColor = System.Drawing.Color.White;
            this.txtCustNO.Location = new System.Drawing.Point(166, 43);
            this.txtCustNO.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtCustNO.Name = "txtCustNO";
            this.txtCustNO.ReadOnly = true;
            this.txtCustNO.Size = new System.Drawing.Size(164, 27);
            this.txtCustNO.TabIndex = 2;
            this.txtCustNO.TextChanged += new System.EventHandler(this.txtCustNO_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer NO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(894, 750);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.pnlData);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmCustomer";
            this.Text = "Customer Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).EndInit();
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            this.pnlNavication.ResumeLayout(false);
            this.pnlPhones.ResumeLayout(false);
            this.pnlPhones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhones)).EndInit();
            this.pnlControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustNO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlPhones;
        private System.Windows.Forms.DataGridView dgvPhones;
        private System.Windows.Forms.Button btnAddPhone;
        private System.Windows.Forms.Button btnDelAll;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.Panel pnlNavication;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnCustNO;
        private System.Windows.Forms.RadioButton rbtnAdress;
        private System.Windows.Forms.RadioButton rbtnEmail;
        private System.Windows.Forms.RadioButton rbtnStartDate;
        private System.Windows.Forms.RadioButton rbtnCustName;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnShowSearch;
        private System.Windows.Forms.DataGridView dgvSearch;
        private System.Windows.Forms.Button btnCloseSearch;
    }
}