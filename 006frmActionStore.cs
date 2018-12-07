using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tabarak
{
    public partial class frmActionStore : Form
    {
        public frmActionStore()
        {
            InitializeComponent();
        }
        DB db = new DB();
        DataTable tblAction = new DataTable();
        int intRow = 0;

        String CustNO;
        String ItemNO;
        String StoreNO;

        DataTable Empty = new DataTable();


        private void SetCustItemOUT()
        {
            CustNO = cbxCustOUT.SelectedValue.ToString();
            ItemNO = cbxItemOUT.SelectedValue.ToString();
            StoreNO = cbxStoreOUT.SelectedValue.ToString();
        }
        private void SetCustItemIN()
        {
            CustNO = cbxCustIN.SelectedValue.ToString();
            ItemNO = cbxItemIN.SelectedValue.ToString();
            StoreNO = cbxStoreIN.SelectedValue.ToString();
        }
        
       private void AutoNum()
       {
            
            FillTblActionOUT("select max(actionno) from action_out");
           if (tblAction .Rows[0][0].ToString() == DBNull.Value.ToString())
               txtActionOUT.Text = "1";
           else
               txtActionOUT.Text = (Convert.ToUInt16(tblAction .Rows[0][0].ToString()) + 1).ToString();
               

           tblAction.Clear();
            tblAction.Columns.Clear();

            FillTblActionIN("select max(actionno) from action_in");
            if (tblAction.Rows[0][0].ToString() == DBNull.Value.ToString())
                txtActionIN.Text = "1";
            else
                txtActionIN.Text = (Convert.ToUInt16(tblAction.Rows[0][0].ToString()) + 1).ToString();
        }
       
        
       private void FillTblActionOUT(String SelectStatement = "select* from Action_Out")
       {
           tblAction .Clear();
           tblAction .Columns.Clear();
           tblAction  = db.RunReader(SelectStatement);
       }
        private void FillTblActionIN(String SelectStatement = "select* from Action_In")
        {
            tblAction.Clear();
            tblAction.Columns.Clear();
            tblAction = db.RunReader(SelectStatement);
        }
       
     private void FillCust()
     {
                 cbxCustOUT.DataSource = db.RunReader("select custno , custname from customer");
                 cbxCustOUT.DisplayMember = "custname";
                 cbxCustOUT.ValueMember = "custno";
                 cbxCustIN.DataSource = db.RunReader("select custno , custname from customer");
                 cbxCustIN.DisplayMember = "custname";
                 cbxCustIN.ValueMember = "custno";
        }
       
    private void FillItem()
    {
            cbxItemOUT.DataSource = db.RunReader("select itemno , itemname from item");
            cbxItemOUT.DisplayMember = "itemname";
            cbxItemOUT.ValueMember = "itemno";
            cbxItemIN.DataSource = db.RunReader("select itemno , itemname from item");
            cbxItemIN.DisplayMember = "itemname";
            cbxItemIN.ValueMember = "itemno";
        }
        private void FillStore()
        {
            cbxStoreOUT.DataSource = db.RunReader("select storeno , storename from store");
            cbxStoreOUT.DisplayMember = "storename";
            cbxStoreOUT.ValueMember = "storeno";
            cbxStoreIN.DataSource = db.RunReader("select storeno , storename from store");
            cbxStoreIN.DisplayMember = "storename";
            cbxStoreIN.ValueMember = "storeno";
        }
        private void ClearData()
        {
            AutoNum();
            txtDetailsOUT .Clear();
            txtDetailsIN.Clear();
            nadQTYOUT.Value = 1;
            nadQTYIN.Value = 1;
            nadPriceIN .Value = 500;
            nadPriceOUT.Value = 500;
            dtpDateOUT.Text = DateTime.Now.ToShortDateString();
            dtpDateIN.Text = DateTime.Now.ToShortDateString();
            btnUpdateIN .Enabled = false;
            btnUpdateOUT.Enabled = false;
            btnDeleteOUT.Enabled = false;
            btnDeleteIN.Enabled = false;
            btnAddOUT.Enabled = true;
            btnAddIN.Enabled = true;
            
           
           
        }


        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            CalcTotalOUT();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void frmActionStore_Load(object sender, EventArgs e)
        {
            FillCust();
            FillItem();
            FillStore();
           
            ClearData();
        }
        private void ShowDataOUT()
        {
            FillTblActionOUT ();
            txtActionOUT.Text = tblAction .Rows[intRow][0].ToString();
            cbxCustOUT.SelectedValue = tblAction .Rows[intRow][1].ToString();
            cbxItemOUT.SelectedValue = tblAction .Rows[intRow][2].ToString();
            cbxStoreOUT.SelectedValue = tblAction.Rows[intRow][3].ToString();
            
           
            nadQTYOUT.Value = Convert.ToUInt16(tblAction .Rows[intRow][4]);
            nadPriceOUT.Value = Convert.ToUInt16(tblAction .Rows[intRow][5]);
            dtpDateOUT.Text = tblAction.Rows[intRow][6].ToString();
            txtDetailsOUT.Text = tblAction.Rows[intRow][7].ToString();
            btnUpdateOUT.Enabled = true;
            btnDeleteOUT.Enabled = true;
            btnAddOUT.Enabled = false;
            SetCustItemOUT();
        }
        private void ShowDataIN()
        {
            FillTblActionIN();
            txtActionIN.Text = tblAction.Rows[intRow][0].ToString();
            cbxCustIN.SelectedValue = tblAction.Rows[intRow][1].ToString();
            cbxItemIN.SelectedValue = tblAction.Rows[intRow][2].ToString();
            cbxStoreIN.SelectedValue = tblAction.Rows[intRow][3].ToString();


            nadQTYIN.Value = Convert.ToUInt16(tblAction.Rows[intRow][4]);
            nadPriceIN.Value = Convert.ToUInt16(tblAction.Rows[intRow][5]);
            dtpDateIN.Text = tblAction.Rows[intRow][6].ToString();
            txtDetailsIN.Text = tblAction.Rows[intRow][7].ToString();
            btnUpdateIN.Enabled = true;
            btnDeleteIN.Enabled = true;
            btnAddIN.Enabled = false;
            SetCustItemIN();
        }
        private void CalcTotalOUT()
        {
            txtTotaltOUT.Text = (nadQTYOUT.Value * nadPriceOUT.Value).ToString();
        }
        private void CalcTotalIN()
        {
            txtTotaltIN.Text = (nadQTYIN.Value * nadPriceIN.Value).ToString();
        }
        private void pnlData_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlControls_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nadPriceOUT_ValueChanged(object sender, EventArgs e)
        {
            CalcTotalOUT();
        }

        private void txtTotaltOUT_TextChanged(object sender, EventArgs e)
        {

        }

        private void ttxtDetailsOUTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pnlData.Visible = false;
            pnlSearch.Location = pnlData.Location;
            pnlSearch.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            db.RunNonQuery("delete from action_in where actionno = " + txtActionIN.Text + " and custno = " + CustNO + " and itemno= " + ItemNO + " and storeno= " + StoreNO, "Action IN is deleted");
            ClearData();
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           
            db.RunNonQuery("update action_out set custno = " + cbxCustOUT.SelectedValue + " , itemno = " + cbxItemOUT.SelectedValue + " , storeno = " + cbxStoreOUT.SelectedValue +  ", QTY = " + nadQTYOUT.Value + " , price = " + nadPriceOUT.Value + " , details = '" + txtDetailsOUT.Text + "' , actiondate = '" + dtpDateOUT .Text  + "'   where actionno = " + txtActionOUT.Text + " and custno = " + CustNO + " and itemno= " + ItemNO + " and storeno= " + StoreNO, "ACTION OUT is updated");
       
            ClearData();
            
        }


        private void btnLast_Click(object sender, EventArgs e)
        {
            FillTblActionIN();
            intRow = tblAction.Rows.Count - 1;
            ShowDataIN();
        }

        private void btnUpdateIN_Click(object sender, EventArgs e)
        {
            db.RunNonQuery("update action_in set custno = " + cbxCustIN.SelectedValue + " , itemno = " + cbxItemIN.SelectedValue + " , storeno = " + cbxStoreIN.SelectedValue + ", QTY = " + nadQTYIN.Value + " , price = " + nadPriceIN.Value + " , details = '" + txtDetailsIN.Text + "' , actiondate = '" + dtpDateIN.Text + "'   where actionno = " + txtActionIN.Text + " and custno = " + CustNO + " and itemno= " + ItemNO + " and storeno= " + StoreNO, "ACTION IN is updated");

            ClearData();
        }

        private void btnClearOUT_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void btnAddOUT_Click(object sender, EventArgs e)
        {
            db.RunNonQuery("insert into action_out values( " + txtActionOUT.Text + " , " + cbxCustOUT.SelectedValue + " , " + cbxItemOUT.SelectedValue + " , " + cbxStoreOUT.SelectedValue + " ,  " + nadQTYOUT.Value + " , " + nadPriceOUT .Value + " , '" + dtpDateOUT.Text + "' , '" + txtDetailsOUT.Text + "' )", "ACTION OUT  is added");
            ClearData();
        }

        private void btnAddIN_Click(object sender, EventArgs e)
        {
            db.RunNonQuery("insert into action_in values( " + txtActionIN.Text + " , " + cbxCustIN.SelectedValue + " , " + cbxItemIN.SelectedValue + " , " + cbxStoreIN.SelectedValue + " ,  " + nadQTYIN.Value + " , " + nadPriceIN.Value + " , '" + dtpDateIN.Text + "' , '" + txtDetailsIN.Text + "' )", "ACTION IN  is added");
            ClearData();
        }

        private void btnFirstOUT_Click(object sender, EventArgs e)
        {
            intRow = 0;
            ShowDataOUT();
        }

        private void btnNextOUT_Click(object sender, EventArgs e)
        {
            if (intRow >= tblAction .Rows.Count - 1)
            {
                MessageBox.Show("THIS IS THE LAST ACTION OUY!!!!!");
            }
            else
            {
                intRow += 1;
                ShowDataOUT();
            }
        }

        private void btnPreviousOUT_Click(object sender, EventArgs e)
        {
            if (intRow == 0)
            {
                MessageBox.Show("THIS IS THE FIRST ACTION OUT!!!!");
            }
            else
            {
                intRow -= 1;
                ShowDataOUT();
            }
        }

        private void btnLastOUT_Click(object sender, EventArgs e)
        {
            FillTblActionOUT ();
            intRow = tblAction .Rows.Count - 1;
            ShowDataOUT();
        }

        private void btnFirstIN_Click(object sender, EventArgs e)
        {
            intRow = 0;
            ShowDataIN();
        }

        private void btnNextIN_Click(object sender, EventArgs e)
        {
            if (intRow >= tblAction.Rows.Count - 1)
            {
                MessageBox.Show("THIS IS THE LAST ACTION IN!!!!!");
            }
            else
            {
                intRow += 1;
                ShowDataIN();
            }
        }

        private void btnPreviousIN_Click(object sender, EventArgs e)
        {
            if (intRow == 0)
            {
                MessageBox.Show("THIS IS THE FIRST ACTION IN!!!!");
            }
            else
            {
                intRow -= 1;
                ShowDataIN();
            }
        }

        private void nadPriceIN_ValueChanged(object sender, EventArgs e)
        {
            CalcTotalIN();

        }
        private void nadQTYIN_ValueChanged(object sender, EventArgs e)
        {
            CalcTotalIN();

        }

        private void btnDeleteOUT_Click(object sender, EventArgs e)
        {
            db.RunNonQuery("delete from action_out where actionno = " + txtActionOUT.Text + " and custno = " + CustNO + " and itemno= " + ItemNO + " and storeno= " + StoreNO, "Action OUT is deleted");
            ClearData();
        }

        private void btnExitOUT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearchOUT_Click(object sender, EventArgs e)
        {
            pnlData.Visible = false;
            pnlSearch.Location = pnlData.Location;
            pnlSearch.Visible = true;
        }

        private void btnCloseSearch_Click(object sender, EventArgs e)
        {

            pnlData.Visible = true;

            pnlSearch.Visible = false;
           
            Empty.Clear();
            Empty.Columns.Clear();
            dgvSearch.DataSource = Empty;
            txtSearch.Clear();
            rbtnCustNO.Select();
           
            
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            dtpDateSearch.Visible = false;
        }

        private void btnViewOUT_Click(object sender, EventArgs e)
        {
            db.RunNonQuery("create view ActionOUTAll as select action_out.custno , custname , action_out.itemno , itemname , action_out.storeno , storename , action_out.qty , action_out.price , action_out.actiondate , action_out.details from action_out , customer , item , store where action_out.custno = customer.custno and action_out.itemno = item.itemno and action_out.storeno = store.storeno", "OK");
        }

        private void btnViewIN_Click(object sender, EventArgs e)
        {
            db.RunNonQuery("create view ActionINAll as select action_in.custno , custname , action_in.itemno , itemname , action_in.storeno , storename , action_in.qty , action_in.price , action_in.actiondate , action_in.details from action_in , customer , item , store where action_in.custno = customer.custno and action_in.itemno = item.itemno and action_in.storeno = store.storeno", "OK");
        }
        String FormName = "OUT";
        private void btnShowSearch_Click(object sender, EventArgs e)
        {
            String ColName = "";
            if (rbtnCustNO.Checked == true)
                ColName = "custno";
            else if (rbtnCustName.Checked == true)
                ColName = "custname";
            else if (rbtnItemNO.Checked == true)
                ColName = "itemno";
            else if (rbtnItemName.Checked == true)
                ColName = "itemname";
            else if (rbtnStoreNO.Checked == true)
                ColName = "storeno";
            else if (rbtnStoreName.Checked == true)
                ColName = "storename";
           
            else if (rbtnDate.Checked == true)
                ColName = "actiondate";
            else if (rbtnQTY.Checked == true)
                ColName = "qty";
            else
                ColName = "price";

           if(FormName == "IN")
                dgvSearch.DataSource = db.RunReader("select * from actionoutall where " + ColName + " like'%" + txtSearch.Text + "%'");
           else
                dgvSearch.DataSource = db.RunReader("select * from actioninall where " + ColName + " like'%" + txtSearch.Text + "%'");
        }

        private void frmOUT_MouseClick(object sender, MouseEventArgs e)
        {
           // MessageBox.Show("CLICK IN ");
           
        }

        private void frmOUT_Leave(object sender, EventArgs e)
        {
            FormName = "IN";
           // MessageBox.Show(FormName );
        }

        private void frmIN_Leave(object sender, EventArgs e)
        {
            FormName = "OUT";
           // MessageBox.Show(FormName);
        }

        private void rbtnDate_CheckedChanged(object sender, EventArgs e)
        {
            dtpDateSearch.Visible = true;
        }

        private void rbtnPrice_CheckedChanged(object sender, EventArgs e)
        {
            dtpDateSearch.Visible = false;
        }

        private void rbtnQTY_CheckedChanged(object sender, EventArgs e)
        {
            dtpDateSearch.Visible = false;
        }

        private void rbtnStoreNO_CheckedChanged(object sender, EventArgs e)
        {
            dtpDateSearch.Visible = false;
        }

        private void rbtnItemName_CheckedChanged(object sender, EventArgs e)
        {
            dtpDateSearch.Visible = false;
        }

        private void rbtnItemNO_CheckedChanged(object sender, EventArgs e)
        {
            dtpDateSearch.Visible = false;
        }

        private void rbtnCustName_CheckedChanged(object sender, EventArgs e)
        {
            dtpDateSearch.Visible = false;
        }

        private void rbtnCustNO_CheckedChanged(object sender, EventArgs e)
        {
            dtpDateSearch.Visible = false;
        }

        private void dtpDateSearch_Leave(object sender, EventArgs e)
        {
            txtSearch.Text = dtpDateSearch.Text;
        }

        private void dtpDateSearch_MouseDown(object sender, MouseEventArgs e)
        {
            txtSearch.Text = dtpDateSearch.Text;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtActionOUT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotaltIN_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
