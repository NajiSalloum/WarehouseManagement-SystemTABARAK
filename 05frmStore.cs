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
    public partial class frmStore : Form
    {
        public frmStore()
        {
            InitializeComponent();
        }
        DB db = new DB();
        DataTable tblStore = new DataTable();
        int intRow = 0;

        private void FillTblStore(String SelectSattement = "select * from store")
        {
            tblStore .Clear();
            tblStore .Columns.Clear();
            tblStore  = db.RunReader(SelectSattement);
        }

        private void AutoNum()
        {
            FillTblStore("select max(storeno) from store");
            if (tblStore.Rows[0][0].ToString() == DBNull.Value.ToString())
                txtStoreNO.Text = "1";
            else
                txtStoreNO.Text = (Convert.ToInt16(tblStore.Rows[0][0].ToString()) + 1).ToString();
        }

        private void ClearData()
        {




            AutoNum();
            txtStoreName .Clear();
            txtAdress.Clear();
            txtPhone.Clear();
            
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnAdd.Enabled = true;
        }


        private void frmStore_Load(object sender, EventArgs e)
        {
            ClearData();
        }

        private void pnlData_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            db.RunNonQuery("insert into store values(" + txtStoreNO.Text + " , '" + txtStoreName.Text + "' , '" + txtAdress.Text + "' ,'" + txtPhone.Text  + "' )", "Store is added");
            ClearData();
        }
        private void ShowData()
        {
            
            FillTblStore();
            txtStoreNO.Text = tblStore.Rows[intRow][0].ToString();
            txtStoreName.Text = tblStore.Rows[intRow][1].ToString();
            
            txtAdress.Text = tblStore.Rows[intRow][2].ToString();
            txtPhone.Text = tblStore.Rows[intRow][3].ToString();
          
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnAdd.Enabled = false;
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            intRow = 0;
            ShowData();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            FillTblStore();
            intRow = tblStore .Rows.Count - 1;
            ShowData();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (intRow >= tblStore .Rows.Count - 1)
            {
                MessageBox.Show("THIS IS THE LAST STORE!!!!!");
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
                MessageBox.Show("THIS IS THE FIRST STORE!!!!");
            }
            else
            {
                intRow -= 1;
                ShowData();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            db.RunNonQuery("update store set storename= '" + txtStoreName.Text + "' , adress= '" + txtAdress.Text + "' , phone= '" + txtPhone.Text + "'  where StoreNO= " + txtStoreNO.Text, "Store is updated");
            ClearData();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            db.RunNonQuery("delete from store where StoreNO= " + txtStoreNO.Text, "Store is deleted");
            ClearData();
        }

        private void btnSearchh_Click(object sender, EventArgs e)
        {
            pnlData.Visible = false;
            pnlSearch.Location = pnlData.Location;
            pnlSearch.Visible = true;
        }

        private void btnCloseSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnCloseSearch_Click_1(object sender, EventArgs e)
        {
            pnlData.Visible = true;

            pnlSearch.Visible = false;
        }

        private void btnShowSearch_Click(object sender, EventArgs e)
        {
          
            String ColName = "";
            if (rbtnStoreNO.Checked == true)
                ColName = "storeno";
            else if (rbtnStoreName.Checked == true)
                ColName = "storename";
            else if (rbtnAdress.Checked == true)
                ColName = "adress";
            else
                ColName = "phone";
            FillTblStore("select storeno as  Num, storename as Name, adress as Adress, phone as Phone from store where " + ColName + " like'%" + txtSearch.Text + "%'");
            dgvSearch.DataSource = tblStore ;

            /*
          FillTblStore("select storeno as  Number, storename as Name, adress as Adress, phone as Phone from store");
          dgvSearch.DataSource = tblStore;
          */
        }

        private void pnlControls_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNext_AutoSizeChanged(object sender, EventArgs e)
        {

        }
    }
}
