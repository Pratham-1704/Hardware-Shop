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
    public partial class DealerBillInfo : Form
    {   
        SqlConnection cn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\PRASAD\\Documents\\HardwareShop.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        public DealerBillInfo()
        {
            InitializeComponent();
        }
        public void displaygrid()
        {
            cmd = new SqlCommand("select * from D_billinfo", cn);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "D_billinfo");
            dataGridView1.DataSource = ds.Tables["D_billinfo"];
        }
        public void txtclear()
        {
            txtsearch.Clear();
            txtqty.Clear();
            txtsubtotal.Clear();
            txtdiscount.Clear();
            txtnetamt.Clear();
        }
        public void autodealsellid()
        {
            cmd = new SqlCommand("select max(dsellid) from D_billtable", cn);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "max");
            if (ds.Tables["max"].Rows.Count == 0)
            {
                txtdealsell_id.Text = "1";
            }
            else
            {
                int max = Convert.ToInt32(ds.Tables["max"].Rows[0][0].ToString());
                txtdealsell_id.Text = Convert.ToString(max + 1);
            }
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
        public void display_dealer()
        {
            cmd = new SqlCommand("select * from  dealer_regst ", cn);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "dealer_regst");

            cmbdealname.DataSource = ds.Tables["dealer_regst"];
            cmbdealname.ValueMember = "deal_id";
            cmbdealname.DisplayMember = "deal_name";
        }
        public void deal_sell()
        {
            cmd = new SqlCommand("select * from D_billtable", cn);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "D_billtable");
        }
        private void DealerBillInfo_Load(object sender, EventArgs e)
        {
            displaygrid();
            txtclear();
            display_product();
            deal_sell();
            autodealsellid();
            display_dealer();
            txtsearch.Focus();
            btnsave.Enabled = true;
            btndelete.Enabled = false;
            btnupdate.Enabled = false;
            txtsubtotal.Text = "0";
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtdealsell_id.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["dsellid"].Value);
            txtproductid.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["pro_id"].Value);
            txtprice.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["pro_price"].Value);
            txtqty.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["qty"].Value);
            txttotal.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["total"].Value);

        }

        private void cmbproname_Leave(object sender, EventArgs e)
        {
            txtproductid.Text = cmbproname.SelectedValue.ToString();

            cmd = new SqlCommand("select pro_price from Price_info where pro_id=" + txtproductid.Text, cn);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "pro_price");
            txtprice.Text = ds.Tables["pro_price"].Rows[0][0].ToString();

            cmd = new SqlCommand("select qty from stockinfo where pro_id =" + txtproductid.Text, cn);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "qty");
            txtstock.Text = ds.Tables["qty"].Rows[0][0].ToString();
        }

        private void cmbdealname_Leave(object sender, EventArgs e)
        {
            try
            {
                txtdeal_id.Text = cmbdealname.SelectedValue.ToString();

                /*  cmd = new SqlCommand("select dsellid from D_billtable where deal_id=" + txtdeal_id.Text, cn);
                  da = new SqlDataAdapter(cmd);
                  ds = new DataSet();
                  da.Fill(ds, "dsellid");
                  txtdealsell_id.Text = ds.Tables["dsellid"].Rows[0][0].ToString();
                */
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void txtdiscount_TextChanged(object sender, EventArgs e)
        {
            if (txtdiscount.Text.Length > 0)
            {
                int subtotal = Convert.ToInt32(txtsubtotal.Text);
                int discount = Convert.ToInt32(txtdiscount.Text);
                int netamt = Convert.ToInt32(subtotal - (subtotal * discount / 100));

                txtnetamt.Text = netamt.ToString("0.00");
            }
        }

        private void btnadditem_Click(object sender, EventArgs e)
        {
            String[] arr = new String[4];
            arr[0] = cmbproname.Text;
            arr[1] = txtprice.Text;
            arr[2] = txtqty.Text;
            arr[3] = txttotal.Text;

            ListViewItem ls = new ListViewItem(arr);
            listView1.Items.Add(ls);

            txtsubtotal.Text = (Convert.ToInt32(txtsubtotal.Text) + Convert.ToInt32(txttotal.Text)).ToString();
        }

        private void btnremoveitem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    if (listView1.Items[i].Selected)
                    {
                        txtsubtotal.Text = (Convert.ToInt32(txtsubtotal.Text) - Convert.ToInt32(listView1.Items[i].SubItems[3].Text)).ToString();
                        listView1.Items[i].Remove();
                    }
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = DateTime.Today;
            if (dateTimePicker1.Value < DateTime.Today)
            {
                dateTimePicker1.Value = DateTime.Today;
            }
        }

        private void txtdealsell_id_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtdeal_id_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtprice_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txttotal_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtsubtotal_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtdiscount_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtnetamt_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtstock_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cmbdealname_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtdealsell_id.Text == "")
                {
                    MessageBox.Show("Please,Enter dealer sell Id", "Record Details", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (txtproductid.Text == "")
                {
                    MessageBox.Show("Please,Enter product Id", "Record Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    cmd = new SqlCommand("insert into D_billtable values (" + txtdealsell_id.Text + "," + txtdeal_id.Text + ",'" + dateTimePicker1.Text + "')", cn);
                    da = new SqlDataAdapter(cmd);
                    ds = new DataSet();
                    da.Fill(ds, "insert");

                    cmd = new SqlCommand("update stockinfo set qty=" + txtstock.Text + "where pro_id=" + txtproductid.Text, cn);
                    da = new SqlDataAdapter(cmd);
                    ds = new DataSet();
                    da.Fill(ds, "update");

                    cmd = new SqlCommand("insert into D_billinfo values (" + txtdealsell_id.Text + "," + txtproductid.Text + "," + txtprice.Text + "," + txtqty.Text + "," + txttotal.Text + ")", cn);
                    da = new SqlDataAdapter(cmd);
                    ds = new DataSet();
                    da.Fill(ds, "insert");
                    MessageBox.Show("Record Successfully inserted ", "Successfuly", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DealerBillInfo_Load(sender, e);
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
                if (txtdealsell_id.Text == "")
                {
                    MessageBox.Show("Please,Enter dealersell Id", "Record Details", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (txtproductid.Text == "")
                {
                    MessageBox.Show("Please,Enter product Id", "Record Details", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    cmd = new SqlCommand("update D_billinfo set pro_id=" + txtproductid.Text + ",pro_price=" + txtprice.Text + ",qty=" + txtqty.Text + ",total=" + txttotal.Text + "where dsellid=" + txtdealsell_id.Text, cn);
                    da = new SqlDataAdapter(cmd);
                    ds = new DataSet();
                    da.Fill(ds, "update");
                    MessageBox.Show("Record Successfully updated ", "Successfuly", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DealerBillInfo_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            DealerBillInfo_Load(sender , e);
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtdealsell_id.Text == "")
                {
                    MessageBox.Show("Please,Enter dealersell Id", "Record Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txtproductid.Text == "")
                {
                    MessageBox.Show("Please,Enter product Id", "Record Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    cmd = new SqlCommand("delete from D_billinfo where dsellid=" + txtdealsell_id.Text, cn);
                    da = new SqlDataAdapter(cmd);
                    ds = new DataSet();
                    da.Fill(ds, "delete");
                    MessageBox.Show("Record Successfully Deleted ", "Successfuly", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DealerBillInfo_Load(sender, e);
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
                    MessageBox.Show("Please,Enter dealsell Id for search record", "Record Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    cmd = new SqlCommand("select * from D_billinfo where dsellid=" + Convert.ToInt32(txtsearch.Text), cn);
                    da = new SqlDataAdapter(cmd);
                    ds = new DataSet();
                    da.Fill(ds, "search");
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

        private void txtqty_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtqty.Text.Length > 0)
                {
                    txttotal.Text = (Convert.ToInt32(txtprice.Text) * Convert.ToInt32(txtqty.Text)).ToString();
                }

                int stock = Convert.ToInt32(txtstock.Text);
                int qty = Convert.ToInt32(txtqty.Text);

                stock = stock - qty;
                txtstock.Text = Convert.ToString(stock);

                if (Convert.ToInt32(txtstock.Text) < Convert.ToInt32(txtqty.Text))
                {
                    MessageBox.Show("Required Quantity is not Available");
                    txtqty.Clear();
                    txtqty.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
