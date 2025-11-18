using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HardwareShop
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void customerBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            frmC_billtable l1 = new frmC_billtable();
            l1.ShowDialog();
        }

        private void customerBillInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 s1 = new Form1();
            //s1.MdiParent = this;
            s1.Show();
           
        }

        private void dealerRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DealerReg s2 = new DealerReg();
            s2.ShowDialog();
           // s2.Show();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginPage l1 = new loginPage();
            l1.ShowDialog();
        }

        private void customerBillInformationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           // this.Hide();
            Customerbillinfo l1 = new Customerbillinfo();
            l1.ShowDialog();
        }

        private void productInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            frm_productsinfo l1 = new frm_productsinfo();
            l1.ShowDialog();
        }

        private void priceInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
           frm_Priceinfo l1 = new frm_Priceinfo();
            l1.ShowDialog();
        }

        private void dealerBillTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmD_billtable l1 = new frmD_billtable();
            l1.ShowDialog();
        }

        private void dealerBillInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DealerBillInfo l1 = new DealerBillInfo();
            l1.ShowDialog();
        }

        private void stockInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStock_info l1 = new frmStock_info();
            l1.ShowDialog();
        }
    }
}
