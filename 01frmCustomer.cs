using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Tabarak
{
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + Application.StartupPath + @"\Tbarak.accdb; Jet OLEDB:Database Password=123;");
        OleDbCommand cmd = new OleDbCommand();
        DataTable tbleCust = new DataTable();
        DataTable tblePhones = new DataTable();
        int introw = 0;
        private void AutoNum()
        {
            FillTblCust("select max(custno) from customer");
            if (tbleCust.Rows[0][0].ToString() == DBNull.Value.ToString())
                txtCustNO .Text = "1";
            else
                txtCustNO.Text = (Convert.ToInt16(tbleCust.Rows[0][0].ToString()) + 1).ToString();
        }
        private void FillTblCust(String strSelect = "select * from customer")
        {
            tbleCust.Clear();
            tbleCust.Columns.Clear();
            cmd.Connection = conn;
            cmd.CommandText = strSelect ;
            conn.Open();
            tbleCust.Load(cmd.ExecuteReader());
            conn.Close();
        }
        private void ShowData()
        {
            //show customer
            FillTblCust();
            txtCustNO.Text = tbleCust.Rows[introw][0].ToString();
            txtCustName.Text  = tbleCust.Rows[introw][1].ToString();
            dtpStartDate.Text = tbleCust.Rows[introw][2].ToString();
            txtEmail.Text = tbleCust.Rows[introw][3].ToString();
            txtAdress.Text = tbleCust.Rows[introw][4].ToString();
            //show phones
            tblePhones.Clear();
            cmd.Connection = conn;
            cmd.CommandText = "select phone , type from phone_customer where custno=" + txtCustNO.Text;
            conn.Open();
            tblePhones.Load(cmd.ExecuteReader());
            conn.Close();
            dgvPhones.Rows.Clear();
            foreach (DataRow row in tblePhones.Rows )
            {
                dgvPhones.Rows.Add(1);
                int newRowIndex = dgvPhones.Rows.Count - 2;
                dgvPhones.Rows[newRowIndex].Cells[0].Value = row[0];
                dgvPhones.Rows[newRowIndex].Cells[1].Value = row[1];
            }
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnAdd.Enabled = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            AutoNum();
        

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

    

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddPhone_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dgvPhones.Rows)
            {
                if (txtPhone.Text==(String)row.Cells[0].Value) {
                    MessageBox.Show("NUMMERT STÅR REDAN I LISTAN!!!!! ");
                    return;
                }
            }
            dgvPhones.Rows.Add(1);
            int newRowIndex = dgvPhones.Rows.Count - 2;
            dgvPhones.Rows[newRowIndex].Cells[0].Value = txtPhone.Text;
            dgvPhones.Rows[newRowIndex].Cells[1].Value = cbxType.Text;
        }

        private void btnDelAll_Click(object sender, EventArgs e)
        {
            dgvPhones.Rows.Clear();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //uppdate customer


            cmd.Connection = conn;
            cmd.CommandText = "update customer set custname='" + txtCustName.Text + "', startdate= '" + dtpStartDate.Text + "',email='" + txtEmail.Text + "',adress='" + txtAdress.Text + "' where custno=" + txtCustNO.Text ;
            conn.Open();
            cmd.ExecuteNonQuery();
            

            //delete all phones for this customer
           
            cmd.CommandText = "delete from phone_customer where custno=" + txtCustNO.Text ;
       
            cmd.ExecuteNonQuery();


            //add phones
            // conn.Open();
            foreach (DataGridViewRow row in dgvPhones.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    cmd.CommandText = "insert into Phone_Customer values(" + txtCustNO.Text + ", '" + (String)row.Cells[0].Value + "' , '" + (String)row.Cells[1].Value + "')";
                    cmd.ExecuteNonQuery();

                }

            }
            conn.Close();
            MessageBox.Show("Customer is updated");
            ClearData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            pnlData.Visible = false;
            pnlSearch.Location = pnlData.Location;
            pnlSearch.Visible = true;

        }
        private void ClearData()
        {
         
       

          
            AutoNum();
            txtCustName.Clear();

            dtpStartDate.Text = DateTime.Now.Date.ToShortDateString();
            txtEmail.Clear();
            txtAdress.Clear();
            txtPhone.Clear();
            dgvPhones.Rows.Clear();
            btnUpdate.Enabled = false ;
            btnDelete.Enabled = false ;
            btnAdd.Enabled = true ;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearData();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //add customer
           
            
            cmd.Connection = conn;
            cmd.CommandText = "insert into customer values(" + txtCustNO.Text + ", '" + txtCustName.Text + "' , '" + dtpStartDate.Text + "' , '" + txtEmail.Text + "' , '" + txtAdress.Text + "' )";
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
           
            //add phones
            conn.Open();
            foreach (DataGridViewRow row in dgvPhones.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    cmd.CommandText = "insert into Phone_Customer values(" + txtCustNO.Text + ", '" + (String)row.Cells[0].Value + "' , '" + (String)row.Cells[1].Value + "')";
                    cmd.ExecuteNonQuery();

                }

            }
            conn.Close();
            MessageBox.Show("Customer is added");
            ClearData();

        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            introw = 0;
            ShowData();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            FillTblCust();
            introw = tbleCust.Rows.Count - 1;
            ShowData();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (introw >= tbleCust.Rows.Count - 1)
            {
                MessageBox.Show("THIS IS THE LAST CUSTOMER");
            }
            else
            {
                introw += 1;
                ShowData();
            }
            
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (introw ==0)
            {
                MessageBox.Show("THIS IS THE FIRST CUSTOMER");
            }
            else
            {
                introw -= 1;
                ShowData();
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           
            cmd.Connection = conn;
            
            cmd.CommandText = "delete from phone_customer where custno=" + txtCustNO.Text;
            conn.Open();
            cmd.ExecuteNonQuery();
            cmd.CommandText = "delete from customer where custno=" + txtCustNO.Text ;
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("customer is deleted");
            ClearData();


        }

        private void txtCustNO_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String ColName = "";
            if(rbtnCustNO .Checked == true)
             ColName = "custno";
            else if (rbtnCustName .Checked == true)
                ColName = "custname";
            else if (rbtnStartDate.Checked == true)
                ColName = "startdate";
            else if (rbtnEmail.Checked == true)
                ColName = "email";
            else 
                ColName = "adress";
            FillTblCust("select custno as  Num, custname as Name, startdate as StartDate, email as Email, adress as Adress from customer where " + ColName + " like'%" + txtSearch.Text + "%'" );
            dgvSearch.DataSource = tbleCust;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            pnlData.Visible = true;
            
            pnlSearch.Visible = false;

        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pnlPhones_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
