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
    public partial class frm_productsinfo : Form
    {
        SqlConnection cn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\PRASAD\\Documents\\HardwareShop.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        // int index;

        public void displaygrid()
        {
            cmd = new SqlCommand("select * from Products_info", cn);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "Products_info");
            dataGridView1.DataSource = ds.Tables["Products_info"];

        }
        public frm_productsinfo()
        {
            InitializeComponent();
        }
        public void txtclear()
        {
            txtproductname.Clear();
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

        private void btnsave_Click(object sender, EventArgs e)
        {
              try
            {
               
                cmd = new SqlCommand("select pro_id from Products_info where pro_id=" + txtproductid.Text, cn);
                da=new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds, "s");
                int pro_id = ds.Tables["s"].Rows.Count;
                if(pro_id > 0)
                {
                    MessageBox.Show("Already Exits product id,See Below", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (txtproductid.Text == "")
                    {
                        MessageBox.Show("Please,Enter Product Id", "Record Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (txtproductname.Text == "")
                    {
                        MessageBox.Show("Please,Enter Productname", "Record Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        cmd = new SqlCommand("insert into Products_info values(" + txtproductid.Text + ",'" + txtproductname.Text + "')", cn);
                        da = new SqlDataAdapter(cmd);
                        ds = new DataSet();
                        da.Fill(ds, "insert");
                        MessageBox.Show("Record Successfuly inserted", "Successfuly", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frm_productsinfo_Load(sender, e);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frm_productsinfo_Load(object sender, EventArgs e)
        {
            autoproid();
            displaygrid();
            txtclear();
            txtsearch.Focus();
            btnsave.Enabled = true;
            btndelete.Enabled = true;
            btnupdate.Enabled = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
                txtproductid.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["pro_id"].Value);
                txtproductname.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["pro_name"].Value);
            
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtproductid.Text == "")
                {
                    MessageBox.Show("Please,Enter Product Id", "Record Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txtproductname.Text == "")
                {
                    MessageBox.Show("Please,Enter Productname", "Record Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    cmd = new SqlCommand("update Products_info set pro_name='" + txtproductname.Text + "' where pro_id=" + txtproductid.Text, cn);
                    da = new SqlDataAdapter(cmd);
                    ds = new DataSet();
                    da.Fill(ds, "update");
                    MessageBox.Show("Record Successfuly updated", "Successfuly", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frm_productsinfo_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtsearch.Clear();
            frm_productsinfo_Load(sender, e);
        }

        private void btndelete_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtproductid.Text == "")
                {
                    MessageBox.Show("Please,Enter Product Id", "Record Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txtproductname.Text == "")
                {
                    MessageBox.Show("Please,Enter Productname", "Record Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    cmd = new SqlCommand("delete from Products_info where pro_id=" + txtproductid.Text, cn);
                    da = new SqlDataAdapter(cmd);
                    ds = new DataSet();
                    da.Fill(ds, "delete");
                    MessageBox.Show("Record Successfuly deleted", "Successfuly", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frm_productsinfo_Load(sender, e);
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

                if (txtproductid.Text == "")
                {
                    MessageBox.Show("Please,Enter Product Id", "Record Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    cmd = new SqlCommand("select * from Products_info where pro_id=" + Convert.ToInt32(txtsearch.Text), cn);
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

        private void txtproductname_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtproductname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
