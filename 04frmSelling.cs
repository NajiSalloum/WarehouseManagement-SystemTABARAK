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
    public partial class frmSelling : Form
    {
        public frmSelling()
        {
            InitializeComponent();
        }
        DB db = new DB();
        DataTable tblSale = new DataTable();
        int intRow = 0;

        String CustNO;
        String ItemNO;

        private void label2_Click(object sender, EventArgs e)
        {

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
        private void AutoNum()
        {
            FillTblSale("select max(saleno) from selling");
            if (tblSale.Rows[0][0].ToString() == DBNull.Value.ToString())
                txtActionNo.Text = "1";
            else
                txtActionNo.Text = (Convert.ToUInt16(tblSale.Rows[0][0].ToString()) + 1).ToString();

        }
        private void FillTblSale(String SelectStatement = "select* from selling")
        {
            tblSale.Clear();
            tblSale.Columns.Clear();
            tblSale = db.RunReader(SelectStatement);
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
        private void CalcTotal()
        {
            txtTotalt.Text = (nadQTY.Value * nadPraice.Value).ToString();
        }

        private void frmSelling_Load(object sender, EventArgs e)
        {

            FillCust();
            FillItem();
            cbxDay.SelectedIndex = 0;
            dtpDate.Text = DateTime.Now.ToShortDateString();
            cbxCust.Enabled = true;
            cbxItem.Enabled = true;

            ClearData();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private bool CheckPrice()
        {
            int Price = Convert.ToInt16(db.RunReader("select pricet from item where itemno =" + cbxItem .SelectedValue ).Rows [0][0]);
            if (nadPraice.Value < Price)
                return false;
            else
                return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CheckPrice())
            {
                db.RunNonQuery("insert into selling values( " + txtActionNo.Text + " , " + cbxCust.SelectedValue + " , " + cbxItem.SelectedValue + " , '" + (cbxDay.SelectedIndex + 1).ToString() + "' , '" + dtpDate.Text + "' ," + nadQTY.Value + " , " + nadPraice.Value + " , '" + txtDetails.Text + "' )", "Selling is added");
                ClearData();
            }
            else
                MessageBox.Show("DET GÅR INTE MED VINSTEN !!!!!!!!!");
           
        }
        private void ShowData()
        {
            FillTblSale();
            txtActionNo.Text = tblSale.Rows[intRow][0].ToString();
            cbxCust.SelectedValue = tblSale.Rows[intRow][1].ToString();
            cbxItem.SelectedValue = tblSale.Rows[intRow][2].ToString();
            cbxDay.SelectedIndex = Convert.ToUInt16(tblSale.Rows[intRow][3]) - 1;
            dtpDate.Text = tblSale.Rows[intRow][4].ToString();
            nadQTY.Value = Convert.ToUInt16(tblSale.Rows[intRow][5]);
            nadPraice.Value = Convert.ToUInt16(tblSale.Rows[intRow][6]);
            txtDetails.Text = tblSale.Rows[intRow][7].ToString();
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnAdd.Enabled = false;
            // cbxCust.Enabled = false;
            //cbxItem.Enabled = false;
            SetCustItem();
        }
        private void SetCustItem()
        {
            CustNO = cbxCust.SelectedValue.ToString();
            ItemNO = cbxItem.SelectedValue.ToString();
        }

        private void txtActionNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void nadQTY_ValueChanged(object sender, EventArgs e)
        {
            CalcTotal();
        }

        private void nadPraice_ValueChanged(object sender, EventArgs e)
        {
            CalcTotal();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            db.RunNonQuery("update selling set custno = " + cbxCust.SelectedValue + " , itemno = " + cbxItem.SelectedValue + " , dayno = '" + (cbxDay.SelectedIndex + 1).ToString() + "' , saldate = '" + dtpDate.Text + "' , QTY = " + nadQTY.Value + " , price = " + nadPraice.Value + " , details = '" + txtDetails.Text + "'  where saleno = " + txtActionNo.Text + " and custno = " + CustNO + " and itemno= " + ItemNO, "Selling is updated");

            ClearData();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            intRow = 0;
            ShowData();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (intRow >= tblSale .Rows.Count - 1)
            {
                MessageBox.Show("THIS IS THE LAST Selling!!!!!");
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
                MessageBox.Show("THIS IS THE FIRST Selling!!!!");
            }
            else
            {
                intRow -= 1;
                ShowData();
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            FillTblSale();
            intRow = tblSale .Rows.Count - 1;
            ShowData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            db.RunNonQuery("delete from selling where saleno = " + txtActionNo.Text + " and custno = " + CustNO + " and itemno= " + ItemNO, "Selling is deleted");
            ClearData();
        }

        private void btnCreateView_Click(object sender, EventArgs e)
        {
            
            db.RunNonQuery("create view SaleAll as select selling.custno , custname , selling.itemno , itemname , selling.dayno , dayname , Saldate , qty , price , details from selling , customer , item , days where selling.custno = customer.custno and selling.itemno = item.itemno and selling.dayno = days.dayno", "OK");
            // db.RunNonQuery("create view BuyAll as select buying.custno , custname , buying.itemno , itemname , buying.dayno , dayname , buydate , qty , price , details from buying , customer , item , days where buying.custno = customer.custno and buying.itemno = item.itemno and buying.dayno = days.dayno", "OK");
        }

        private void rbtnDate_CheckedChanged(object sender, EventArgs e)
        {
            dtpDateSearch.Visible = true;
        }

        private void rbtnPrice_CheckedChanged(object sender, EventArgs e)
        {
          dtpDateSearch.Visible = false;
        }

        private void rbtnPrice_CheckedChanged_1(object sender, EventArgs e)
        {
            dtpDateSearch.Visible = false;
        }

        private void rbtnQTY_CheckedChanged(object sender, EventArgs e)
        {
            dtpDateSearch.Visible = false;
        }

        private void rbtnDay_CheckedChanged(object sender, EventArgs e)
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
            else if (rbtnDay.Checked == true)
                ColName = "dayname";
            else if (rbtnDate.Checked == true)
                ColName = "saldate";
            else if (rbtnQTY.Checked == true)
                ColName = "qty";
            else
                ColName = "price";

            dgvSearch.DataSource = db.RunReader("select * from Saleall where " + ColName + " like'%" + txtSearch.Text + "%'");

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            pnlData.Visible = false;
            pnlSearch.Location = pnlData.Location;
            pnlSearch.Visible = true;
        }

        private void btnCloseSearch_Click(object sender, EventArgs e)
        {
            pnlData.Visible = true;

            pnlSearch.Visible = false;
        }

        private void dtpDateSearch_MouseEnter(object sender, EventArgs e)
        {
         //   txtSearch.Text = dtpDateSearch.Text;
        }

        private void dtpDateSearch_Leave(object sender, EventArgs e)
        {
        //    txtSearch.Text = dtpDateSearch.Text;
        }

        private void dtpDateSearch_ValueChanged(object sender, EventArgs e)
        {
            txtSearch.Text = dtpDateSearch.Text;
        }

        private void dtpDateSearch1_ValueChanged(object sender, EventArgs e)
        {
            txtSearch.Text = dtpDateSearch.Text;
        }

        private void rbtnDate_CheckedChanged_1(object sender, EventArgs e)
        {
            dtpDateSearch.Visible = true;
        }

        private void dtpDateSearch_MouseDown(object sender, MouseEventArgs e)
        {
            txtSearch.Text = dtpDateSearch.Text;
        }

        private void dtpDateSearch_Leave_1(object sender, EventArgs e)
        {
            txtSearch.Text = dtpDateSearch.Text;
        }

        private void pnlData_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
