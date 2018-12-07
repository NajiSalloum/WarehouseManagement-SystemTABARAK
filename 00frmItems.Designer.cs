namespace Tabarak
{
    partial class frmItems
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
            this.pnlControls = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.nadPrice = new System.Windows.Forms.NumericUpDown();
            this.txtSymbol = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtItemNO = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCloseSearch = new System.Windows.Forms.Button();
            this.dgvSearch = new System.Windows.Forms.DataGridView();
            this.btnShowSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.rbtnPrice = new System.Windows.Forms.RadioButton();
            this.rbtnSymbol = new System.Windows.Forms.RadioButton();
            this.rbtnItemName = new System.Windows.Forms.RadioButton();
            this.rbtnItemNO = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.pnlData.SuspendLayout();
            this.pnlNavication.SuspendLayout();
            this.pnlControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nadPrice)).BeginInit();
            this.pnlSearch.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlData
            // 
            this.pnlData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlData.Controls.Add(this.pnlNavication);
            this.pnlData.Controls.Add(this.pnlControls);
            this.pnlData.Controls.Add(this.nadPrice);
            this.pnlData.Controls.Add(this.txtSymbol);
            this.pnlData.Controls.Add(this.label5);
            this.pnlData.Controls.Add(this.label4);
            this.pnlData.Controls.Add(this.txtItemName);
            this.pnlData.Controls.Add(this.label3);
            this.pnlData.Controls.Add(this.label2);
            this.pnlData.Controls.Add(this.txtItemNO);
            this.pnlData.Controls.Add(this.label1);
            this.pnlData.Location = new System.Drawing.Point(14, 13);
            this.pnlData.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(863, 426);
            this.pnlData.TabIndex = 1;
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
            this.pnlNavication.Location = new System.Drawing.Point(556, 62);
            this.pnlNavication.Name = "pnlNavication";
            this.pnlNavication.Size = new System.Drawing.Size(302, 52);
            this.pnlNavication.TabIndex = 17;
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
            // nadPrice
            // 
            this.nadPrice.DecimalPlaces = 2;
            this.nadPrice.Location = new System.Drawing.Point(166, 210);
            this.nadPrice.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.nadPrice.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nadPrice.Name = "nadPrice";
            this.nadPrice.Size = new System.Drawing.Size(164, 27);
            this.nadPrice.TabIndex = 15;
            this.nadPrice.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nadPrice.ValueChanged += new System.EventHandler(this.nadPrice_ValueChanged);
            // 
            // txtSymbol
            // 
            this.txtSymbol.Location = new System.Drawing.Point(166, 156);
            this.txtSymbol.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtSymbol.Name = "txtSymbol";
            this.txtSymbol.Size = new System.Drawing.Size(346, 27);
            this.txtSymbol.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 218);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 164);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Symbol";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(166, 106);
            this.txtItemName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(346, 27);
            this.txtItemName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Item Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(302, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 35);
            this.label2.TabIndex = 3;
            this.label2.Text = "Items From";
            // 
            // txtItemNO
            // 
            this.txtItemNO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtItemNO.Location = new System.Drawing.Point(166, 62);
            this.txtItemNO.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtItemNO.Name = "txtItemNO";
            this.txtItemNO.ReadOnly = true;
            this.txtItemNO.Size = new System.Drawing.Size(164, 27);
            this.txtItemNO.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Item NO";
            // 
            // pnlSearch
            // 
            this.pnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSearch.Controls.Add(this.groupBox1);
            this.pnlSearch.Controls.Add(this.label10);
            this.pnlSearch.Location = new System.Drawing.Point(14, 441);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(863, 421);
            this.pnlSearch.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCloseSearch);
            this.groupBox1.Controls.Add(this.dgvSearch);
            this.groupBox1.Controls.Add(this.btnShowSearch);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.rbtnPrice);
            this.groupBox1.Controls.Add(this.rbtnSymbol);
            this.groupBox1.Controls.Add(this.rbtnItemName);
            this.groupBox1.Controls.Add(this.rbtnItemNO);
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
            // rbtnPrice
            // 
            this.rbtnPrice.AutoSize = true;
            this.rbtnPrice.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnPrice.Location = new System.Drawing.Point(509, 26);
            this.rbtnPrice.Name = "rbtnPrice";
            this.rbtnPrice.Size = new System.Drawing.Size(53, 17);
            this.rbtnPrice.TabIndex = 3;
            this.rbtnPrice.TabStop = true;
            this.rbtnPrice.Text = "Price";
            this.rbtnPrice.UseVisualStyleBackColor = true;
            // 
            // rbtnSymbol
            // 
            this.rbtnSymbol.AutoSize = true;
            this.rbtnSymbol.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnSymbol.Location = new System.Drawing.Point(384, 26);
            this.rbtnSymbol.Name = "rbtnSymbol";
            this.rbtnSymbol.Size = new System.Drawing.Size(67, 17);
            this.rbtnSymbol.TabIndex = 2;
            this.rbtnSymbol.TabStop = true;
            this.rbtnSymbol.Text = "Symbol";
            this.rbtnSymbol.UseVisualStyleBackColor = true;
            // 
            // rbtnItemName
            // 
            this.rbtnItemName.AutoSize = true;
            this.rbtnItemName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnItemName.Location = new System.Drawing.Point(254, 26);
            this.rbtnItemName.Name = "rbtnItemName";
            this.rbtnItemName.Size = new System.Drawing.Size(85, 17);
            this.rbtnItemName.TabIndex = 1;
            this.rbtnItemName.TabStop = true;
            this.rbtnItemName.Text = "ItemName";
            this.rbtnItemName.UseVisualStyleBackColor = true;
            // 
            // rbtnItemNO
            // 
            this.rbtnItemNO.AutoSize = true;
            this.rbtnItemNO.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnItemNO.Location = new System.Drawing.Point(125, 26);
            this.rbtnItemNO.Name = "rbtnItemNO";
            this.rbtnItemNO.Size = new System.Drawing.Size(68, 17);
            this.rbtnItemNO.TabIndex = 0;
            this.rbtnItemNO.TabStop = true;
            this.rbtnItemNO.Text = "ItemNO";
            this.rbtnItemNO.UseVisualStyleBackColor = true;
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
            // frmItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 750);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.pnlData);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmItems";
            this.Text = "Items Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this._00frmItems_Load);
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            this.pnlNavication.ResumeLayout(false);
            this.pnlControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nadPrice)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtItemNO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nadPrice;
        private System.Windows.Forms.TextBox txtSymbol;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlNavication;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCloseSearch;
        private System.Windows.Forms.DataGridView dgvSearch;
        private System.Windows.Forms.Button btnShowSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton rbtnPrice;
        private System.Windows.Forms.RadioButton rbtnSymbol;
        private System.Windows.Forms.RadioButton rbtnItemName;
        private System.Windows.Forms.RadioButton rbtnItemNO;
        private System.Windows.Forms.Label label10;
    }
}