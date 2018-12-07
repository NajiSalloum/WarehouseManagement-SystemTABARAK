namespace Tabarak
{
    partial class frmStore
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
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStoreName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStoreNO = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.btnSearchh = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCloseSearch = new System.Windows.Forms.Button();
            this.dgvSearch = new System.Windows.Forms.DataGridView();
            this.btnShowSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.rbtnPhone = new System.Windows.Forms.RadioButton();
            this.rbtnAdress = new System.Windows.Forms.RadioButton();
            this.rbtnStoreName = new System.Windows.Forms.RadioButton();
            this.rbtnStoreNO = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.pnlData.SuspendLayout();
            this.pnlNavication.SuspendLayout();
            this.pnlControls.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlData
            // 
            this.pnlData.BackgroundImage = global::Tabarak.Properties.Resources.bStore1;
            this.pnlData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlData.Controls.Add(this.pnlNavication);
            this.pnlData.Controls.Add(this.txtPhone);
            this.pnlData.Controls.Add(this.label6);
            this.pnlData.Controls.Add(this.txtAdress);
            this.pnlData.Controls.Add(this.label5);
            this.pnlData.Controls.Add(this.txtStoreName);
            this.pnlData.Controls.Add(this.label3);
            this.pnlData.Controls.Add(this.txtStoreNO);
            this.pnlData.Controls.Add(this.label1);
            this.pnlData.Controls.Add(this.pnlControls);
            this.pnlData.Controls.Add(this.label2);
            this.pnlData.Location = new System.Drawing.Point(14, 12);
            this.pnlData.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(863, 426);
            this.pnlData.TabIndex = 3;
            this.pnlData.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlData_Paint);
            // 
            // pnlNavication
            // 
            this.pnlNavication.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlNavication.Controls.Add(this.btnFirst);
            this.pnlNavication.Controls.Add(this.btnNext);
            this.pnlNavication.Controls.Add(this.btnPrevious);
            this.pnlNavication.Controls.Add(this.btnLast);
            this.pnlNavication.Location = new System.Drawing.Point(544, 38);
            this.pnlNavication.Name = "pnlNavication";
            this.pnlNavication.Size = new System.Drawing.Size(302, 52);
            this.pnlNavication.TabIndex = 48;
            // 
            // btnFirst
            // 
            this.btnFirst.BackgroundImage = global::Tabarak.Properties.Resources.first1;
            this.btnFirst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFirst.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirst.Location = new System.Drawing.Point(27, 13);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(54, 29);
            this.btnFirst.TabIndex = 23;
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackgroundImage = global::Tabarak.Properties.Resources.next;
            this.btnNext.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(87, 13);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(54, 29);
            this.btnNext.TabIndex = 22;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.AutoSizeChanged += new System.EventHandler(this.btnNext_AutoSizeChanged);
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
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(166, 215);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(346, 27);
            this.txtPhone.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(20, 223);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 19);
            this.label6.TabIndex = 24;
            this.label6.Text = "Phone";
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(166, 163);
            this.txtAdress.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(346, 27);
            this.txtAdress.TabIndex = 23;
            this.txtAdress.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(20, 171);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 19);
            this.label5.TabIndex = 22;
            this.label5.Text = "Adress";
            // 
            // txtStoreName
            // 
            this.txtStoreName.Location = new System.Drawing.Point(166, 107);
            this.txtStoreName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtStoreName.Name = "txtStoreName";
            this.txtStoreName.Size = new System.Drawing.Size(346, 27);
            this.txtStoreName.TabIndex = 20;
            this.txtStoreName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(20, 115);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "Store Name";
            // 
            // txtStoreNO
            // 
            this.txtStoreNO.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtStoreNO.Location = new System.Drawing.Point(166, 63);
            this.txtStoreNO.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtStoreNO.Name = "txtStoreNO";
            this.txtStoreNO.ReadOnly = true;
            this.txtStoreNO.Size = new System.Drawing.Size(164, 27);
            this.txtStoreNO.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 19);
            this.label1.TabIndex = 17;
            this.label1.Text = "Store NO";
            // 
            // pnlControls
            // 
            this.pnlControls.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlControls.Controls.Add(this.btnSearchh);
            this.pnlControls.Controls.Add(this.btnAdd);
            this.pnlControls.Controls.Add(this.btnUpdate);
            this.pnlControls.Controls.Add(this.btnSearch);
            this.pnlControls.Controls.Add(this.btnClear);
            this.pnlControls.Controls.Add(this.btnDelete);
            this.pnlControls.Controls.Add(this.btnExit);
            this.pnlControls.Location = new System.Drawing.Point(24, 343);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(608, 62);
            this.pnlControls.TabIndex = 16;
            this.pnlControls.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlControls_Paint);
            // 
            // btnSearchh
            // 
            this.btnSearchh.Location = new System.Drawing.Point(300, 16);
            this.btnSearchh.Name = "btnSearchh";
            this.btnSearchh.Size = new System.Drawing.Size(88, 29);
            this.btnSearchh.TabIndex = 49;
            this.btnSearchh.Text = "Search";
            this.btnSearchh.UseVisualStyleBackColor = true;
            this.btnSearchh.Click += new System.EventHandler(this.btnSearchh_Click);
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
            this.btnSearch.Location = new System.Drawing.Point(582, -1);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(25, 12);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "X!!X";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Visible = false;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(313, -4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 35);
            this.label2.TabIndex = 3;
            this.label2.Text = "Stor From";
            // 
            // pnlSearch
            // 
            this.pnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSearch.Controls.Add(this.groupBox1);
            this.pnlSearch.Controls.Add(this.label10);
            this.pnlSearch.Location = new System.Drawing.Point(12, 445);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(863, 421);
            this.pnlSearch.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCloseSearch);
            this.groupBox1.Controls.Add(this.dgvSearch);
            this.groupBox1.Controls.Add(this.btnShowSearch);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.rbtnPhone);
            this.groupBox1.Controls.Add(this.rbtnAdress);
            this.groupBox1.Controls.Add(this.rbtnStoreName);
            this.groupBox1.Controls.Add(this.rbtnStoreNO);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(28, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(798, 341);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search By";
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
            this.btnCloseSearch.Click += new System.EventHandler(this.btnCloseSearch_Click_1);
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
            // rbtnPhone
            // 
            this.rbtnPhone.AutoSize = true;
            this.rbtnPhone.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnPhone.Location = new System.Drawing.Point(509, 26);
            this.rbtnPhone.Name = "rbtnPhone";
            this.rbtnPhone.Size = new System.Drawing.Size(60, 17);
            this.rbtnPhone.TabIndex = 3;
            this.rbtnPhone.TabStop = true;
            this.rbtnPhone.Text = "Phone";
            this.rbtnPhone.UseVisualStyleBackColor = true;
            // 
            // rbtnAdress
            // 
            this.rbtnAdress.AutoSize = true;
            this.rbtnAdress.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnAdress.Location = new System.Drawing.Point(384, 26);
            this.rbtnAdress.Name = "rbtnAdress";
            this.rbtnAdress.Size = new System.Drawing.Size(64, 17);
            this.rbtnAdress.TabIndex = 2;
            this.rbtnAdress.TabStop = true;
            this.rbtnAdress.Text = "Adress";
            this.rbtnAdress.UseVisualStyleBackColor = true;
            // 
            // rbtnStoreName
            // 
            this.rbtnStoreName.AutoSize = true;
            this.rbtnStoreName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnStoreName.Location = new System.Drawing.Point(254, 26);
            this.rbtnStoreName.Name = "rbtnStoreName";
            this.rbtnStoreName.Size = new System.Drawing.Size(91, 17);
            this.rbtnStoreName.TabIndex = 1;
            this.rbtnStoreName.TabStop = true;
            this.rbtnStoreName.Text = "Store Name";
            this.rbtnStoreName.UseVisualStyleBackColor = true;
            // 
            // rbtnStoreNO
            // 
            this.rbtnStoreNO.AutoSize = true;
            this.rbtnStoreNO.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnStoreNO.Location = new System.Drawing.Point(125, 26);
            this.rbtnStoreNO.Name = "rbtnStoreNO";
            this.rbtnStoreNO.Size = new System.Drawing.Size(103, 17);
            this.rbtnStoreNO.TabIndex = 0;
            this.rbtnStoreNO.TabStop = true;
            this.rbtnStoreNO.Text = "Store Number";
            this.rbtnStoreNO.UseVisualStyleBackColor = true;
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
            // frmStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tabarak.Properties.Resources.bStore;
            this.ClientSize = new System.Drawing.Size(893, 750);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.pnlData);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmStore";
            this.Text = "Store Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmStore_Load);
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            this.pnlNavication.ResumeLayout(false);
            this.pnlControls.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStoreName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStoreNO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlNavication;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnSearchh;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCloseSearch;
        private System.Windows.Forms.DataGridView dgvSearch;
        private System.Windows.Forms.Button btnShowSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton rbtnPhone;
        private System.Windows.Forms.RadioButton rbtnAdress;
        private System.Windows.Forms.RadioButton rbtnStoreName;
        private System.Windows.Forms.RadioButton rbtnStoreNO;
        private System.Windows.Forms.Label label10;
    }
}