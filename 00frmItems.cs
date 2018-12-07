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
    public partial class frmItems : Form
    {
        public frmItems()
        {
            InitializeComponent();
        }
        DataTable tblItem = new DataTable();
        int intRow =  0;
        private void FillTblItem(String SelectSattement="select * from item")
        {
            tblItem.Clear();
            tblItem.Columns.Clear();
            tblItem = db.RunReader(SelectSattement );
        }

        private void AutoNum()
        {
            FillTblItem("select max(itemno) from item");
            if (tblItem .Rows[0][0].ToString() == DBNull.Value.ToString())
                txtItemNO .Text = "1";
            else
                txtItemNO.Text = (Convert.ToUInt16(tblItem.Rows[0][0].ToString()) + 1).ToString(); 
          
        }
        private void ClearData()
        {
            AutoNum();
            txtItemName.Clear();
            txtSymbol.Clear();
            nadPrice.Value = 500;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnAdd.Enabled = true;


        }
        private void ShowData()
        {
            FillTblItem();
            txtItemNO.Text = tblItem.Rows[intRow ][0].ToString(); 
            txtItemName.Text = tblItem.Rows[intRow][1].ToString();
            txtSymbol.Text = tblItem.Rows[intRow][2].ToString();
            nadPrice .Value  = Convert.ToUInt64(tblItem.Rows[intRow][3]);
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnAdd.Enabled = false;
        }
        DB db = new DB();
        private void pnlData_Paint(object sender, PaintEventArgs e)
        {

        }

        private void _00frmItems_Load(object sender, EventArgs e)
        {
            ClearData();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            db.RunNonQuery("insert into item values(" + txtItemNO.Text + " , '" + txtItemName.Text + "' , '" + txtSymbol.Text + "' , " + nadPrice.Value + ")", "item is added");
            ClearData();
        }

        private void txtAdress_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
           intRow  = 0;
            ShowData();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            FillTblItem();
            intRow = tblItem .Rows.Count - 1;
            ShowData();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (intRow >= tblItem .Rows.Count - 1)
            {
                MessageBox.Show("THIS IS THE LAST ITEM!!!!!");
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
                MessageBox.Show("THIS IS THE FIRST ITEM!!!!");
            }
            else
            {
                intRow -= 1;
                ShowData();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            db.RunNonQuery("update Item set ItemName= '" + txtItemName.Text + "' , Symbol= '" + txtSymbol.Text + "' , PriceT= " + nadPrice.Value + " where ItemNO= " + txtItemNO.Text   , "item is updated");
            ClearData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            db.RunNonQuery("delete from item where ItemNO= " + txtItemNO.Text, "item is deleted");
            ClearData();
        }

        private void btnShowSearch_Click(object sender, EventArgs e)
        {
            String ColName = "";
            if (rbtnItemNO.Checked == true)
                ColName = "itemno";
            else if (rbtnItemName.Checked == true)
                ColName = "itemname";
            else if (rbtnSymbol.Checked == true)
                ColName = "symbol";
            else
                ColName = "pricet";
            FillTblItem("select itemno as  Num, itemname as Name, symbol as Symbol, pricet as Price from item where " + ColName + " like'%" + txtSearch.Text + "%'");
            dgvSearch.DataSource = tblItem ;
        }

        private void btnCloseSearch_Click(object sender, EventArgs e)
        {
            pnlData.Visible = true;
            
            pnlSearch.Visible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            pnlData.Visible = false;
            pnlSearch.Location = pnlData.Location;
            pnlSearch.Visible = true;
        }

        private void nadPrice_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
