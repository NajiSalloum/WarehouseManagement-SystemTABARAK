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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            frmHome home = new frmHome();
            home.MdiParent = this;
            home.Show();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmHome frm = new frmHome();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            frmBackup frm = new frmBackup();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmCustomer frm = new frmCustomer();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            frmSelling frm = new frmSelling();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            frmStatictics frm = new frmStatictics();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            frmItems frm = new frmItems();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripSeparator3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSeparator12_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            frmActionStore frm = new frmActionStore();
            frm.MdiParent = this;
            frm.Show();
        }
       
        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sbtnBuy_Click(object sender, EventArgs e)
        {
            frmBuying frm = new frmBuying();
            frm.MdiParent = this;
            frm.Show();
        }

        private void sbtnStore_Click(object sender, EventArgs e)
        {
            frmStore frm = new frmStore();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripSeparator8_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
