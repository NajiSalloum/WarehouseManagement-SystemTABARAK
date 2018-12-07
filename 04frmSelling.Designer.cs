namespace Tabarak
{
    partial class frmSelling
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
            this.pnlData = new System.Windows.Forms.Panel();
            this.pnlNavication = new System.Windows.Forms.Panel();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.txtActionNo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTotalt = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nadQTY = new System.Windows.Forms.NumericUpDown();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxDay = new System.Windows.Forms.ComboBox();
            this.cbxItem = new System.Windows.Forms.ComboBox();
            this.cbxCust = new System.Windows.Forms.ComboBox();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.nadPraice = new System.Windows.Forms.NumericUpDown();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpDateSearch = new System.Windows.Forms.DateTimePicker();
            this.rbtnDate = new System.Windows.Forms.RadioButton();
            this.btnCreateView = new System.Windows.Forms.Button();
            this.rbtnQTY = new System.Windows.Forms.RadioButton();
            this.rbtnPrice = new System.Windows.Forms.RadioButton();
            this.rbtnDay = new System.Windows.Forms.RadioButton();
            this.rbtnItemName = new System.Windows.Forms.RadioButton();
            this.rbtnItemNO = new System.Windows.Forms.RadioButton();
            this.btnCloseSearch = new System.Windows.Forms.Button();
            this.dgvSearch = new System.Windows.Forms.DataGridView();
            this.btnShowSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.rbtnCustName = new System.Windows.Forms.RadioButton();
            this.rbtnCustNO = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.pnlData.SuspendLayout();
            this.pnlNavication.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nadQTY)).BeginInit();
            this.pnlControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nadPraice)).BeginInit();
            this.pnlSearch.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlData
            // 
            this.pnlData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlData.Controls.Add(this.pnlNavication);
            this.pnlData.Controls.Add(this.txtActionNo);
            this.pnlData.Controls.Add(this.label9);
            this.pnlData.Controls.Add(this.txtTotalt);
            this.pnlData.Controls.Add(this.label16);
            this.pnlData.Controls.Add(this.label8);
            this.pnlData.Controls.Add(this.nadQTY);
            this.pnlData.Controls.Add(this.dtpDate);
            this.pnlData.Controls.Add(this.label7);
            this.pnlData.Controls.Add(this.cbxDay);
            this.pnlData.Controls.Add(this.cbxItem);
            this.pnlData.Controls.Add(this.cbxCust);
            this.pnlData.Controls.Add(this.pnlControls);
            this.pnlData.Controls.Add(this.nadPraice);
            this.pnlData.Controls.Add(this.txtDetails);
            this.pnlData.Controls.Add(this.label6);
            this.pnlData.Controls.Add(this.label5);
            this.pnlData.Controls.Add(this.label4);
            this.pnlData.Controls.Add(this.label3);
            this.pnlData.Controls.Add(this.label2);
            this.pnlData.Controls.Add(this.label1);
            this.pnlData.Location = new System.Drawing.Point(14, 13);
            this.pnlData.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(863, 426);
            this.pnlData.TabIndex = 3;
            this.pnlData.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlData_Paint);
            // 
            // pnlNavication
            // 
            this.pnlNavication.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlNavication.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNavication.Controls.Add(this.btnFirst);
            this.pnlNavication.Controls.Add(this.btnNext);
            this.pnlNavication.Controls.Add(this.btnPrevious);
            this.pnlNavication.Controls.Add(this.btnLast);
            this.pnlNavication.Location = new System.Drawing.Point(537, 47);
            this.pnlNavication.Name = "pnlNavication";
            this.pnlNavication.Size = new System.Drawing.Size(302, 52);
            this.pnlNavication.TabIndex = 47;
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
            // txtActionNo
            // 
            this.txtActionNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtActionNo.Location = new System.Drawing.Point(166, 45);
            this.txtActionNo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtActionNo.Name = "txtActionNo";
            this.txtActionNo.ReadOnly = true;
            this.txtActionNo.Size = new System.Drawing.Size(164, 27);
            this.txtActionNo.TabIndex = 46;
            this.txtActionNo.TextChanged += new System.EventHandler(this.txtActionNo_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 54);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 19);
            this.label9.TabIndex = 45;
            this.label9.Text = "ActionNO";
            // 
            // txtTotalt
            // 
            this.txtTotalt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtTotalt.Location = new System.Drawing.Point(166, 258);
            this.txtTotalt.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtTotalt.Name = "txtTotalt";
            this.txtTotalt.ReadOnly = true;
            this.txtTotalt.Size = new System.Drawing.Size(466, 27);
            this.txtTotalt.TabIndex = 41;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(20, 266);
            this.label16.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 19);
            this.label16.TabIndex = 40;
            this.label16.Text = "Totalt";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(404, 226);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 19);
            this.label8.TabIndex = 23;
            this.label8.Text = "QTY";
            // 
            // nadQTY
            // 
            this.nadQTY.DecimalPlaces = 3;
            this.nadQTY.Location = new System.Drawing.Point(468, 224);
            this.nadQTY.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nadQTY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nadQTY.Name = "nadQTY";
            this.nadQTY.Size = new System.Drawing.Size(164, 27);
            this.nadQTY.TabIndex = 22;
            this.nadQTY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nadQTY.ValueChanged += new System.EventHandler(this.nadQTY_ValueChanged);
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(166, 181);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(164, 27);
            this.dtpDate.TabIndex = 21;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 189);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 19);
            this.label7.TabIndex = 20;
            this.label7.Text = "Date";
            // 
            // cbxDay
            // 
            this.cbxDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDay.FormattingEnabled = true;
            this.cbxDay.Items.AddRange(new object[] {
            "Söndag",
            "måndag",
            "tisdag",
            "onsdag",
            "torsdag",
            "fredag",
            "lördag"});
            this.cbxDay.Location = new System.Drawing.Point(166, 145);
            this.cbxDay.Name = "cbxDay";
            this.cbxDay.Size = new System.Drawing.Size(164, 27);
            this.cbxDay.TabIndex = 19;
            // 
            // cbxItem
            // 
            this.cbxItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxItem.FormattingEnabled = true;
            this.cbxItem.Location = new System.Drawing.Point(166, 112);
            this.cbxItem.Name = "cbxItem";
            this.cbxItem.Size = new System.Drawing.Size(164, 27);
            this.cbxItem.TabIndex = 18;
            // 
            // cbxCust
            // 
            this.cbxCust.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCust.FormattingEnabled = true;
            this.cbxCust.Location = new System.Drawing.Point(166, 79);
            this.cbxCust.Name = "cbxCust";
            this.cbxCust.Size = new System.Drawing.Size(164, 27);
            this.cbxCust.TabIndex = 17;
            // 
            // pnlControls
            // 
            this.pnlControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlControls.Controls.Add(this.btnAdd);
            this.pnlControls.Controls.Add(this.btnUpdate);
            this.pnlControls.Controls.Add(this.btnSearch);
            this.pnlControls.Controls.Add(this.btnClear);
            this.pnlControls.Controls.Add(this.btnDelete);
            this.pnlControls.Controls.Add(this.btnExit);
            this.pnlControls.Location = new System.Drawing.Point(24, 359);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(608, 62);
            this.pnlControls.TabIndex = 16;
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
            this.btnSearch.Location = new System.Drawing.Point(300, 16);
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
            this.btnDelete.Location = new System.Drawing.Point(206, 16);
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
            // nadPraice
            // 
            this.nadPraice.DecimalPlaces = 2;
            this.nadPraice.Location = new System.Drawing.Point(166, 222);
            this.nadPraice.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.nadPraice.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nadPraice.Name = "nadPraice";
            this.nadPraice.Size = new System.Drawing.Size(164, 27);
            this.nadPraice.TabIndex = 15;
            this.nadPraice.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nadPraice.ValueChanged += new System.EventHandler(this.nadPraice_ValueChanged);
            // 
            // txtDetails
            // 
            this.txtDetails.Location = new System.Drawing.Point(166, 293);
            this.txtDetails.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDetails.Size = new System.Drawing.Size(466, 59);
            this.txtDetails.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 310);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Details";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 230);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 153);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Day";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 120);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Item ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(302, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 35);
            this.label2.TabIndex = 3;
            this.label2.Text = "Selling From";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer";
            // 
            // pnlSearch
            // 
            this.pnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSearch.Controls.Add(this.groupBox1);
            this.pnlSearch.Controls.Add(this.label10);
            this.pnlSearch.Location = new System.Drawing.Point(14, 446);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(856, 421);
            this.pnlSearch.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpDateSearch);
            this.groupBox1.Controls.Add(this.rbtnDate);
            this.groupBox1.Controls.Add(this.btnCreateView);
            this.groupBox1.Controls.Add(this.rbtnQTY);
            this.groupBox1.Controls.Add(this.rbtnPrice);
            this.groupBox1.Controls.Add(this.rbtnDay);
            this.groupBox1.Controls.Add(this.rbtnItemName);
            this.groupBox1.Controls.Add(this.rbtnItemNO);
            this.groupBox1.Controls.Add(this.btnCloseSearch);
            this.groupBox1.Controls.Add(this.dgvSearch);
            this.groupBox1.Controls.Add(this.btnShowSearch);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.rbtnCustName);
            this.groupBox1.Controls.Add(this.rbtnCustNO);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(28, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(798, 341);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search By";
            // 
            // dtpDateSearch
            // 
            this.dtpDateSearch.CalendarFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateSearch.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateSearch.Location = new System.Drawing.Point(672, 26);
            this.dtpDateSearch.Name = "dtpDateSearch";
            this.dtpDateSearch.Size = new System.Drawing.Size(102, 23);
            this.dtpDateSearch.TabIndex = 24;
            this.dtpDateSearch.Visible = false;
            this.dtpDateSearch.Leave += new System.EventHandler(this.dtpDateSearch_Leave_1);
            this.dtpDateSearch.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dtpDateSearch_MouseDown);
            // 
            // rbtnDate
            // 
            this.rbtnDate.AutoSize = true;
            this.rbtnDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnDate.Location = new System.Drawing.Point(604, 26);
            this.rbtnDate.Name = "rbtnDate";
            this.rbtnDate.Size = new System.Drawing.Size(52, 17);
            this.rbtnDate.TabIndex = 23;
            this.rbtnDate.TabStop = true;
            this.rbtnDate.Text = "Date";
            this.rbtnDate.UseVisualStyleBackColor = true;
            this.rbtnDate.CheckedChanged += new System.EventHandler(this.rbtnDate_CheckedChanged_1);
            // 
            // btnCreateView
            // 
            this.btnCreateView.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateView.Location = new System.Drawing.Point(650, 64);
            this.btnCreateView.Name = "btnCreateView";
            this.btnCreateView.Size = new System.Drawing.Size(45, 29);
            this.btnCreateView.TabIndex = 21;
            this.btnCreateView.Text = "View";
            this.btnCreateView.UseVisualStyleBackColor = true;
            this.btnCreateView.Visible = false;
            this.btnCreateView.Click += new System.EventHandler(this.btnCreateView_Click);
            // 
            // rbtnQTY
            // 
            this.rbtnQTY.AutoSize = true;
            this.rbtnQTY.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnQTY.Location = new System.Drawing.Point(502, 26);
            this.rbtnQTY.Name = "rbtnQTY";
            this.rbtnQTY.Size = new System.Drawing.Size(47, 17);
            this.rbtnQTY.TabIndex = 20;
            this.rbtnQTY.TabStop = true;
            this.rbtnQTY.Text = "QTY";
            this.rbtnQTY.UseVisualStyleBackColor = true;
            this.rbtnQTY.CheckedChanged += new System.EventHandler(this.rbtnQTY_CheckedChanged);
            // 
            // rbtnPrice
            // 
            this.rbtnPrice.AutoSize = true;
            this.rbtnPrice.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnPrice.Location = new System.Drawing.Point(551, 26);
            this.rbtnPrice.Name = "rbtnPrice";
            this.rbtnPrice.Size = new System.Drawing.Size(53, 17);
            this.rbtnPrice.TabIndex = 19;
            this.rbtnPrice.TabStop = true;
            this.rbtnPrice.Text = "Price";
            this.rbtnPrice.UseVisualStyleBackColor = true;
            this.rbtnPrice.CheckedChanged += new System.EventHandler(this.rbtnPrice_CheckedChanged_1);
            // 
            // rbtnDay
            // 
            this.rbtnDay.AutoSize = true;
            this.rbtnDay.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnDay.Location = new System.Drawing.Point(449, 26);
            this.rbtnDay.Name = "rbtnDay";
            this.rbtnDay.Size = new System.Drawing.Size(47, 17);
            this.rbtnDay.TabIndex = 17;
            this.rbtnDay.TabStop = true;
            this.rbtnDay.Text = "Day";
            this.rbtnDay.UseVisualStyleBackColor = true;
            this.rbtnDay.CheckedChanged += new System.EventHandler(this.rbtnDay_CheckedChanged);
            // 
            // rbtnItemName
            // 
            this.rbtnItemName.AutoSize = true;
            this.rbtnItemName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnItemName.Location = new System.Drawing.Point(358, 26);
            this.rbtnItemName.Name = "rbtnItemName";
            this.rbtnItemName.Size = new System.Drawing.Size(85, 17);
            this.rbtnItemName.TabIndex = 16;
            this.rbtnItemName.TabStop = true;
            this.rbtnItemName.Text = "ItemName";
            this.rbtnItemName.UseVisualStyleBackColor = true;
            this.rbtnItemName.CheckedChanged += new System.EventHandler(this.rbtnItemName_CheckedChanged);
            // 
            // rbtnItemNO
            // 
            this.rbtnItemNO.AutoSize = true;
            this.rbtnItemNO.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnItemNO.Location = new System.Drawing.Point(284, 26);
            this.rbtnItemNO.Name = "rbtnItemNO";
            this.rbtnItemNO.Size = new System.Drawing.Size(68, 17);
            this.rbtnItemNO.TabIndex = 15;
            this.rbtnItemNO.TabStop = true;
            this.rbtnItemNO.Text = "ItemNO";
            this.rbtnItemNO.UseVisualStyleBackColor = true;
            this.rbtnItemNO.CheckedChanged += new System.EventHandler(this.rbtnItemNO_CheckedChanged);
            // 
            // btnCloseSearch
            // 
            this.btnCloseSearch.BackColor = System.Drawing.Color.Red;
            this.btnCloseSearch.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCloseSearch.Location = new System.Drawing.Point(770, 6);
            this.btnCloseSearch.Name = "btnCloseSearch";
            this.btnCloseSearch.Size = new System.Drawing.Size(28, 23);
            this.btnCloseSearch.TabIndex = 14;
            this.btnCloseSearch.Text = "X";
            this.btnCloseSearch.UseVisualStyleBackColor = false;
            this.btnCloseSearch.Click += new System.EventHandler(this.btnCloseSearch_Click);
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
            this.btnShowSearch.Location = new System.Drawing.Point(701, 64);
            this.btnShowSearch.Name = "btnShowSearch";
            this.btnShowSearch.Size = new System.Drawing.Size(73, 29);
            this.btnShowSearch.TabIndex = 12;
            this.btnShowSearch.Text = "Search";
            this.btnShowSearch.UseVisualStyleBackColor = true;
            this.btnShowSearch.Click += new System.EventHandler(this.btnShowSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(119, 70);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(544, 23);
            this.txtSearch.TabIndex = 11;
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
            // 
            // rbtnCustName
            // 
            this.rbtnCustName.AutoSize = true;
            this.rbtnCustName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnCustName.Location = new System.Drawing.Point(196, 26);
            this.rbtnCustName.Name = "rbtnCustName";
            this.rbtnCustName.Size = new System.Drawing.Size(82, 17);
            this.rbtnCustName.TabIndex = 1;
            this.rbtnCustName.TabStop = true;
            this.rbtnCustName.Text = "CustName";
            this.rbtnCustName.UseVisualStyleBackColor = true;
            this.rbtnCustName.CheckedChanged += new System.EventHandler(this.rbtnCustName_CheckedChanged);
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
            this.rbtnCustNO.CheckedChanged += new System.EventHandler(this.rbtnCustNO_CheckedChanged);
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
            // frmSelling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 750);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.pnlData);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmSelling";
            this.Text = "Selling Form";
            this.Load += new System.EventHandler(this.frmSelling_Load);
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            this.pnlNavication.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nadQTY)).EndInit();
            this.pnlControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nadPraice)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nadQTY;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxDay;
        private System.Windows.Forms.ComboBox cbxItem;
        private System.Windows.Forms.ComboBox cbxCust;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.NumericUpDown nadPraice;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotalt;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtActionNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pnlNavication;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCreateView;
        private System.Windows.Forms.RadioButton rbtnQTY;
        private System.Windows.Forms.RadioButton rbtnPrice;
        private System.Windows.Forms.RadioButton rbtnDay;
        private System.Windows.Forms.RadioButton rbtnItemName;
        private System.Windows.Forms.RadioButton rbtnItemNO;
        private System.Windows.Forms.Button btnCloseSearch;
        private System.Windows.Forms.DataGridView dgvSearch;
        private System.Windows.Forms.Button btnShowSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton rbtnCustName;
        private System.Windows.Forms.RadioButton rbtnCustNO;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpDateSearch;
        private System.Windows.Forms.RadioButton rbtnDate;
    }
}