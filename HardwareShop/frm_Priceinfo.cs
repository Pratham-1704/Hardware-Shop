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
    public partial class frm_Priceinfo : Form
    {
        SqlConnection cn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\PRASAD\\Documents\\HardwareShop.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        public frm_Priceinfo()
        {
            InitializeComponent();
        }
        public void displaygrid()
        {
            cmd = new SqlCommand("select * from Price_info", cn);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "Price_info");
            dataGridView1.DataSource = ds.Tables["Price_info"];
        }
        public void txtclear()
        {
            txtproductprice.Clear();
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

        public void displayProduct()
        {
            cmd = new SqlCommand("select * from Products_info", cn);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "Products_info");

            cmbproname.DataSource = ds.Tables["Products_info"];
            cmbproname.ValueMember = "pro_id";
            cmbproname.DisplayMember = "pro_name";
            
        }

        private void frm_Priceinfo_Load(object sender, EventArgs e)
        {
            displaygrid();
            txtclear();
            // autoproid();
            displayProduct();
            txtsearch.Focus();
            btnsave.Enabled = true;
            btndelete.Enabled = false;
            btnupdate.Enabled = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtproductid.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["pro_id"].Value);
            txtproductprice.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["pro_price"].Value);
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                //cn.Open();
                cmd = new SqlCommand("select pro_id from Price_info where pro_id=" + txtproductid.Text, cn);
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds, "s");

                int pro_id = ds.Tables["s"].Rows.Count;
                //cn.Close();
                if (pro_id > 0)
                {
                    MessageBox.Show("Already Exits product id ,See Below", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (txtproductid.Text == "")
                    {
                        MessageBox.Show("Please,Enter Product id", "Record Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (txtproductprice.Text == "")
                    {
                        MessageBox.Show("Please,Enter Product price", "Record Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (Convert.ToInt32(txtproductprice.Text) > 0)
                        {
                            cmd = new SqlCommand("insert into Price_info values(" + txtproductid.Text + "," + txtproductprice.Text + ")", cn);
                            da = new SqlDataAdapter(cmd);
                            ds = new DataSet();
                            da.Fill(ds, "insert");
                            MessageBox.Show("Record Successfuly inserted", "Successfuly", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frm_Priceinfo_Load(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Enter valid price");
                        }
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
                    MessageBox.Show("Please,Enter Product id", "Record Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txtproductprice.Text == "")
                {
                    MessageBox.Show("Please,Enter Product price", "Record Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    cmd = new SqlCommand("update Price_info set pro_price=" + txtproductprice.Text + " where  pro_id = " + txtproductid.Text, cn);
                    da = new SqlDataAdapter(cmd);
                    ds = new DataSet();
                    da.Fill(ds, "update");
                    MessageBox.Show("Record Successfuly updated", "Successfuly", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frm_Priceinfo_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            frm_Priceinfo_Load(sender, e);
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtproductid.Text == "")
                {
                    MessageBox.Show("Please,Enter Product id", "Record Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txtproductprice.Text == "")
                {
                    MessageBox.Show("Please,Enter Product price", "Record Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    cmd = new SqlCommand("delete from Price_info where pro_id=" + txtproductid.Text, cn);
                    da = new SqlDataAdapter(cmd);
                    ds = new DataSet();
                    da.Fill(ds, "delete");
                    MessageBox.Show("Record Successfuly deleted", "Successfuly", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frm_Priceinfo_Load(sender, e);
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
                    MessageBox.Show("Please,Enter Product price id", "Record Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Record search", "Record Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmd = new SqlCommand("select * from Price_info where pro_id=" + Convert.ToInt32(txtsearch.Text), cn);
                    da = new SqlDataAdapter(cmd);
                    ds = new DataSet();
                    da.Fill(ds, "search");
                    int s = ds.Tables[0].Rows.Count;
                    if (s == 0)
                    {
                        MessageBox.Show("Product id does not exits", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtsearch.Clear();
                    }
                    else
                    {
                        // MessageBox.Show("Record Searched", "Successfuly", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView1.DataSource = ds.Tables["search"];
                        btnsave.Enabled = false;
                        btndelete.Enabled = true;
                        btnupdate.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbproname_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtproductprice_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cmbproname_SelectedIndexChanged(object sender, EventArgs e)
        {
            
               // int selectedValue = (int)cmbproname.SelectedValue;
                // Do something with the selected value
            
        }

        private void cmbproname_SelectedValueChanged(object sender, EventArgs e)
        {
            txtproductid.Text = cmbproname.SelectedValue.ToString();
        }
    }
}
