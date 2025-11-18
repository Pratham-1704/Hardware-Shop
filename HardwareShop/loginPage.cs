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
    public partial class loginPage : Form
    {
        public loginPage()
        {
            InitializeComponent();
        }

        private void loginPage_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtuname.Text == "dmb")
            {
                if (txtpass.Text == "password")
                {
                    MessageBox.Show("Welcome!You Are Valid User", "Sucessfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    frmDashboard d = new frmDashboard();
                    d.Show();
                }
                else
                {
                    MessageBox.Show("!!! Invalid password !!!", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtpass.Clear();
                    txtpass.Focus();
                }
            }
            else
            {
                MessageBox.Show("Invalid User Name", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtuname.Clear();
                txtpass.Clear();
                txtuname.Focus();
            }
        }
    }
}
