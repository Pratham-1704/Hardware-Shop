using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HardwareShop
{
    public partial class frmStock_info : Form
    {
        SqlConnection cn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\PRASAD\\Documents\\HardwareShop.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        public frmStock_info()
        {
            InitializeComponent();
        }
        public void displaygrid()
        {
            cmd = new SqlCommand("select * from stockinfo", cn);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "stockinfo");
            dataGridView1.DataSource = ds.Tables["stockinfo"];
        }
        public void txtclear()
        {
            txtproductid.Clear();
        }
        public void autoproid()
        {
            cmd = new SqlCommand("select max(pro_id) from Products_info", cn);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "max");
            int max = Convert.ToInt32(ds.Tables["max"].Rows[0][0].ToString());
            txtproductid.Text = Convert.ToString(max + 1);
        }
        public void display_product()
        {
            cmd = new SqlCommand("select * from Products_info", cn);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "Products_info");

            cmbproname.DataSource = ds.Tables["Products_info"];
            cmbproname.ValueMember = "pro_id";
            cmbproname.DisplayMember = "Pro_name";
        }

        private void frmStock_info_Load(object sender, EventArgs e)
        {
            displaygrid();
            txtclear();
            autoproid();
            display_product();
            txtsearch.Focus();
            btnsave.Enabled = true;
            btndelete.Enabled = false;
            btnupdate.Enabled = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtproductid.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["pro_id"].Value);
            txtqty.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["qty"].Value);
        }

        private void cmbproname_Leave(object sender, EventArgs e)
        {
            try
            {
                txtproductid.Text = cmbproname.SelectedValue.ToString();

                cmd = new SqlCommand("select pro_price from Price_info where pro_id=" + txtproductid.Text, cn);
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds, "pro_price");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void txtproductid_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch) == true)
            {
                e.Handled = false;
            }
            else if (ch == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void txtqty_KeyPress(object sender, KeyPressEventArgs e)
        {

            char ch = e.KeyChar;
            if (char.IsDigit(ch) == true)
            {
                e.Handled = false;
            }
            else if (ch == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void txtsearch_KeyPress(object sender, KeyPressEventArgs e)
        {

            char ch = e.KeyChar;
            if (char.IsDigit(ch) == true)
            {
                e.Handled = false;
            }
            else if (ch == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void cmbproname_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsLetter(ch) == true)
            {
                e.Handled = false;
            }
            else if (ch == 8)
            {
                e.Handled = false;
            }
            else if (ch == 32)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("select pro_id from stockinfo where pro_id=" + txtproductid.Text, cn);
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds, "pro_id");

                int s = ds.Tables["pro_id"].Rows.Count;
                if (s > 0)
                {
                    MessageBox.Show("Already Exits product id ,See Below", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    if (txtproductid.Text == "")
                    {
                        MessageBox.Show("Please,Enter Product Id", "Record Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (txtqty.Text == "")
                    {
                        MessageBox.Show("Please,Enter Quantity", "Record Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        cmd = new SqlCommand("insert into stockinfo values(" + txtproductid.Text + "," + txtqty.Text + ")", cn);
                        da = new SqlDataAdapter(cmd);
                        ds = new DataSet();
                        da.Fill(ds, "insert");
                        MessageBox.Show("Record Successfuly inserted", "Successfuly", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmStock_info_Load(sender, e);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtproductid.Text == "")
                {
                    MessageBox.Show("Please,Enter Product Id", "Record Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txtqty.Text == "")
                {
                    MessageBox.Show("Please,Enter Quanitity", "Record Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    cmd = new SqlCommand("update stockinfo set qty=" + txtqty.Text + " where pro_id=" + txtproductid.Text, cn);
                    da = new SqlDataAdapter(cmd);
                    ds = new DataSet();
                    da.Fill(ds, "update");
                    MessageBox.Show("Record Successfuly updated", "Successfuly", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmStock_info_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            frmStock_info_Load(sender, e);
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtproductid.Text == "")
                {
                    MessageBox.Show("Please,Enter Product Id", "Record Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txtqty.Text == "")
                {
                    MessageBox.Show("Please,Enter Quantity", "Record Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    cmd = new SqlCommand("delete from stockinfo where pro_id=" + txtproductid.Text, cn);
                    da = new SqlDataAdapter(cmd);
                    ds = new DataSet();
                    da.Fill(ds, "delete");
                    MessageBox.Show("Record Successfuly deleted", "Successfuly", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmStock_info_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtsearch.Text == "")
                {
                    MessageBox.Show("Please,Enter Product Id", "Record Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    cmd = new SqlCommand("select * from stockinfo where pro_id=" + Convert.ToInt32(txtsearch.Text), cn);
                    da = new SqlDataAdapter(cmd);
                    ds = new DataSet();
                    da.Fill(ds, "search");
                    MessageBox.Show("Record searched", "Successfuly", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = ds.Tables["search"];
                    btnsave.Enabled = false;
                    btndelete.Enabled = true;
                    btnupdate.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbproname_SelectedValueChanged(object sender, EventArgs e)
        {
            txtproductid.Text = cmbproname.SelectedValue.ToString();

        }
    }
}
