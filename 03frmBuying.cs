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
    public partial class frmBuying : Form
    {
        public frmBuying()
        {
            InitializeComponent();
        }
        DB db = new DB();
        DataTable tblBuy = new DataTable();
        int intRow = 0;

        String CustNO;
        String ItemNO;

        private void SetCustItem()
        {
            CustNO = cbxCust.SelectedValue.ToString ();
            ItemNO = cbxItem .SelectedValue.ToString();
        }

        private void AutoNum()
        {
            FillTblBuy("select max(buyno) from buying");
            if (tblBuy.Rows[0][0].ToString() == DBNull.Value.ToString())
                txtActionNo.Text = "1";
            else
            txtActionNo .Text = (Convert.ToUInt16(tblBuy .Rows[0][0].ToString()) + 1).ToString();

        }
        private void FillTblBuy(String SelectStatement = "select* from buying")
        {
            tblBuy.Clear();
            tblBuy.Columns.Clear();
            tblBuy = db.RunReader(SelectStatement );
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pnlData_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            CalcTotal();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void FillCust()
        {
            cbxCust.DataSource = db.RunReader("select custno , custname from customer");
            cbxCust.DisplayMember = "custname";
            cbxCust.ValueMember = "custno";
        }
        private void FillItem()
        {
            cbxItem.DataSource = db.RunReader("select itemno , itemname from item");
            cbxItem.DisplayMember = "itemname";
            cbxItem.ValueMember = "itemno";
        }
        int DayNO;
        private void SetDay()
        {
            String strDayOfWeek = DateTime.Now.Date.DayOfWeek.ToString();
            if (strDayOfWeek == "Sunday")
                DayNO = 0;
            else if (strDayOfWeek == "Monday")
                DayNO = 1;
            else if (strDayOfWeek == "Tuesday")
                DayNO = 2;
            else if (strDayOfWeek == "Wednesday")
                DayNO = 3;
            else if (strDayOfWeek == "Thursday")
                DayNO = 4;
            else if (strDayOfWeek == "Friday")
                DayNO = 5;
            else 
                DayNO = 6;
 
        }

        private void frmBuying_Load(object sender, EventArgs e)
        {
            
            FillCust();
            FillItem();
            cbxDay.SelectedIndex = 0;
            dtpDate.Text = DateTime.Now.ToShortDateString();
            cbxCust.Enabled = true;
            cbxItem.Enabled = true;
            
            ClearData();
        }
        private void CalcTotal()
        {
            txtTotalt.Text = (nadQTY.Value * nadPraice.Value).ToString ();
        }

        private void nadQTY_ValueChanged(object sender, EventArgs e)
        {
            CalcTotal();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
          
        }
        private void ClearData()
        {
            AutoNum();
            txtDetails.Clear();
            nadQTY.Value = 1;
            nadPraice.Value = 500;
            dtpDate.Text = DateTime.Now.ToShortDateString();
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnAdd.Enabled = true;
            cbxCust.Enabled = true;
            cbxItem.Enabled = true;
            SetDay();
            cbxDay.SelectedIndex = DayNO;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            db.RunNonQuery("insert into buying values( " + txtActionNo.Text  + " , " + cbxCust.SelectedValue + " , " + cbxItem.SelectedValue + " , '" + (cbxDay.SelectedIndex + 1).ToString() + "' , '" + dtpDate.Text + "' ," + nadQTY .Value + " , " + nadPraice.Value + " , '" + txtDetails.Text + "' )", "Buying is added");
            ClearData();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            pnlData.Visible = false;
            pnlSearch.Location = pnlData.Location;
            pnlSearch.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            db.RunNonQuery("update buying set custno = " + cbxCust .SelectedValue + " , itemno = " + cbxItem.SelectedValue + " , dayno = '" + (cbxDay.SelectedIndex + 1).ToString() + "' , buydate = '" + dtpDate.Text + "' , QTY = " + nadQTY.Value + " , price = " + nadPraice.Value + " , details = '" + txtDetails.Text + "'  where buyno = " + txtActionNo.Text + " and custno = " + CustNO  + " and itemno= " + ItemNO  , "Buying is updated");
            
            ClearData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            db.RunNonQuery("delete from buying where buyno = " + txtActionNo.Text + " and custno = " + CustNO  + " and itemno= " + ItemNO , "Buying is deleted");
            ClearData();
        }
        private void ShowData()
        {
            FillTblBuy();
            txtActionNo .Text = tblBuy.Rows[intRow][0].ToString();
            cbxCust.SelectedValue = tblBuy.Rows[intRow][1].ToString();
            cbxItem.SelectedValue = tblBuy.Rows[intRow][2].ToString();
            cbxDay.SelectedIndex  = Convert .ToUInt16(tblBuy.Rows[intRow][3]) - 1;
            dtpDate.Text  = tblBuy.Rows[intRow][4].ToString();
            nadQTY.Value = Convert.ToUInt16(tblBuy.Rows[intRow][5]);
            nadPraice.Value = Convert.ToUInt16(tblBuy.Rows[intRow][6]);
            txtDetails .Text  = tblBuy.Rows[intRow][7].ToString();
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnAdd.Enabled = false;
           // cbxCust.Enabled = false;
            //cbxItem.Enabled = false;
            SetCustItem();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            intRow = 0;
            ShowData();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (intRow >= tblBuy .Rows.Count - 1)
            {
                MessageBox.Show("THIS IS THE LAST Buying!!!!!");
            }
            else
            {
                intRow += 1;
                ShowData();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (intRow == 0)
            {
                MessageBox.Show("THIS IS THE FIRST Buying!!!!");
            }
            else
            {
                intRow -= 1;
                ShowData();
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            FillTblBuy();
            intRow = tblBuy .Rows.Count - 1;
            ShowData();
        }

        private void cbxItem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtActionNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnShowSearch_Click(object sender, EventArgs e)
        {
                 String ColName = "";
                 if (rbtnCustNO.Checked == true)
                     ColName = "custno";
                 else if (rbtnCustName.Checked == true)
                     ColName = "custname";
                 else   if (rbtnItemNO.Checked == true)
                     ColName = "itemno";
                 else if (rbtnItemName.Checked == true)
                     ColName = "itemname";
                 else if (rbtnDay .Checked == true)
                     ColName = "dayname";
                 else if (rbtnDate .Checked == true)
                     ColName = "buydate";
                 else if (rbtnQTY.Checked == true)
                     ColName = "qty";
                 else
                     ColName = "price";
                    
            dgvSearch.DataSource = db.RunReader("select * from buyall where " + ColName + " like'%" + txtSearch.Text + "%'");

            
           // dgvSearch.DataSource = db.RunReader("select * from buyall where custno like'%" + txtSearch.Text + "%'");
                 
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.RunNonQuery("create view BuyAll as select buying.custno , custname , buying.itemno , itemname , buying.dayno , dayname , buydate , qty , price , details from buying , customer , item , days where buying.custno = customer.custno and buying.itemno = item.itemno and buying.dayno = days.dayno", "OK");
        }

        private void rbtnCustName_CheckedChanged(object sender, EventArgs e)
        {
            dtpDateSearch.Visible = false;
        }

        private void rbtnItemNO_CheckedChanged(object sender, EventArgs e)
        {
            dtpDateSearch.Visible = false;
        }

        private void rbtnCustNO_CheckedChanged(object sender, EventArgs e)
        {
            dtpDateSearch.Visible = false;
        }

        private void btnCloseSearch_Click(object sender, EventArgs e)
        {
            pnlData.Visible = true;

            pnlSearch.Visible = false;
        }

        private void dgvSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pnlSearch_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void rbtnDate_CheckedChanged(object sender, EventArgs e)
        {
            dtpDateSearch.Visible = true;
        }

        private void rbtnItemName_CheckedChanged(object sender, EventArgs e)
        {
            dtpDateSearch.Visible = false;
        }

        private void rbtnDay_CheckedChanged(object sender, EventArgs e)
        {
            dtpDateSearch.Visible = false;
        }

        private void rbtnQTY_CheckedChanged(object sender, EventArgs e)
        {
            dtpDateSearch.Visible = false;
        }

        private void rbtnPrice_CheckedChanged(object sender, EventArgs e)
        {
            dtpDateSearch.Visible = false;
        }

        private void dtpDateSearch_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void dtpDateSearch_DropDown(object sender, EventArgs e)
        {
          //  txtSearch.Text = dtpDateSearch.Text;
        }

        private void dtpDateSearch_DragLeave(object sender, EventArgs e)
        {
          //  txtSearch.Text = dtpDateSearch.Text;
        }

        private void dtpDateSearch_Leave(object sender, EventArgs e)
        {
            txtSearch.Text = dtpDateSearch.Text;
        }

        private void dtpDateSearch_MouseEnter(object sender, EventArgs e)
        {
            txtSearch.Text = dtpDateSearch.Text;
        }

        private void txtTotalt_TextChanged(object sender, EventArgs e)
        {
            txtSearch.Text = dtpDateSearch.Text;
        }

        private void dtpDateSearch_Leave_1(object sender, EventArgs e)
        {
            txtSearch.Text = dtpDateSearch.Text;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pnlControls_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlNavication_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbxDay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtDetails_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
