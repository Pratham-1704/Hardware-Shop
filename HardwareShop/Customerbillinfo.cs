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
    public partial class Customerbillinfo : Form
    {
        SqlConnection cn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\PRASAD\\Documents\\HardwareShop.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds = new DataSet();

        public Customerbillinfo()
        {
            InitializeComponent();
        }

        public void displaygrid()
        {
            cmd = new SqlCommand("select * from C_billinfo", cn);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "C_billinfo");
            dataGridView1.DataSource = ds.Tables["C_billinfo"];
        }
        public void txtclear()
        {
            txtsearch.Clear();
            txtqty.Clear();
            txtsubtotal.Clear();
            txtdiscount.Clear();
            txtnetamt.Clear();
        }
        public void autocustsellid()
        {
            cmd = new SqlCommand("select max(custsellid) from C_billtable", cn);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "max");
            if (ds.Tables["max"].Rows.Count == 0)
            {
                txtcustsell_id.Text = "1";
            }
            else
            {
                int max = Convert.ToInt32(ds.Tables["max"].Rows[0][0].ToString());
                txtcustsell_id.Text = Convert.ToString(max + 1);
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
        public void display_customer()
        {
            cmd = new SqlCommand("select * from  Cust_Regist ", cn);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "Cust_Regist");

            cmbcustname.DataSource = ds.Tables["Cust_Regist"];
            cmbcustname.ValueMember = "cust_id";
            cmbcustname.DisplayMember = "cust_name";
        }
      /*  public void display_price()
        {
            cmd = new SqlCommand("select * from  Price_info ", cn);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "Price_info");

            cmbcustname.DataSource = ds.Tables["Price_info"];
            cmbcustname.ValueMember = "pro_id";
            cmbcustname.DisplayMember = "pro_price";
        }*/
        private void Customerbillinfo_Load(object sender, EventArgs e)
        {
         //   display_price();
            displaygrid();
            txtclear();
            display_product();
            autocustsellid();
            display_customer();
            txtsearch.Focus();
            btnsave.Enabled = true;
            btndelete.Enabled = false;
            btnupdate.Enabled = false;
            txtsubtotal.Text = "0";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcustsell_id.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["custsellid"].Value);
            txtproductid.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["pro_id"].Value);
            txtprice.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["pro_price"].Value);
            txtqty.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["qty"].Value);
            txttotal.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["total"].Value);
        }

        private void cmbcustname_Leave(object sender, EventArgs e)
        {
           
            txtproductid.Text = cmbproname.SelectedValue.ToString();
            cmd = new SqlCommand("select qty from stockinfo where pro_id =" + txtproductid.Text, cn);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "qty");
            txtstock.Text = ds.Tables["qty"].Rows[0][0].ToString();
            try
            {
                int pro_id;
                cmd = new SqlCommand("select pro_price from Price_info where pro_id=" + txtproductid.Text, cn);
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds, "pro_price");

                pro_id = Convert.ToInt32(ds.Tables["pro_price"].Rows[0][0].ToString());
                txtprice.Text = ds.Tables["pro_price"].Rows[0][0].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbproname_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbproname_Leave(object sender, EventArgs e)
        {
            try
            {
                txtcust_id.Text = cmbcustname.SelectedValue.ToString();

                /*  cmd = new SqlCommand("select custsellid from C_billtable where cust_id=" + txtcust_id.Text, cn);
                  da = new SqlDataAdapter(cmd);
                  ds = new DataSet();
                  da.Fill(ds, "custsellid");
                  txtcustsell_id.Text = ds.Tables["custsellid"].Rows[0][0].ToString();

                 */
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtcustsell_id.Text == "")
                {
                    MessageBox.Show("Please,Enter customer sell Id", "Record Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txtproductid.Text == "")
                {
                    MessageBox.Show("Please,Enter customer Id", "Record Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    cmd = new SqlCommand("insert into C_billtable values (" + txtcustsell_id.Text + "," + txtcust_id.Text + ",'" + dateTimePicker1.Text + "')", cn);
                    da = new SqlDataAdapter(cmd);
                    ds = new DataSet();
                    da.Fill(ds, "insert");

                    cmd = new SqlCommand("update stockinfo set qty=" + txtstock.Text + "where pro_id=" + txtproductid.Text, cn);
                    da = new SqlDataAdapter(cmd);
                    ds = new DataSet();
                    da.Fill(ds, "update");

                    cmd = new SqlCommand("insert into C_billinfo values (" + txtcustsell_id.Text + "," + txtproductid.Text + "," + txtprice.Text + "," + txtqty.Text + "," + txttotal.Text + ")", cn);
                    da = new SqlDataAdapter(cmd);
                    ds = new DataSet();
                    da.Fill(ds, "insert");
                    MessageBox.Show("Record Successfully inserted ", "Successfuly", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Customerbillinfo_Load(sender, e);

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
                if (txtcustsell_id.Text == "")
                {
                    MessageBox.Show("Please,Enter customersell Id", "Record Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txtproductid.Text == "")
                {
                    MessageBox.Show("Please,Enter product Id", "Record Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    cmd = new SqlCommand("update C_billinfo set pro_id=" + txtproductid.Text + ",pro_price=" + txtprice.Text + ",qty=" + txtqty.Text + ",total=" + txttotal.Text + "where custsellid=" + txtcustsell_id.Text, cn);
                    da = new SqlDataAdapter(cmd);
                    ds = new DataSet();
                    da.Fill(ds, "update");
                    Customerbillinfo_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            Customerbillinfo_Load(sender, e);
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtcustsell_id.Text == "")
                {
                    MessageBox.Show("Please,Enter customersell Id", "Record Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txtproductid.Text == "")
                {
                    MessageBox.Show("Please,Enter product Id", "Record Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    cmd = new SqlCommand("delete from C_billinfo where custsellid=" + txtcustsell_id.Text, cn);
                    da = new SqlDataAdapter(cmd);
                    ds = new DataSet();
                    da.Fill(ds, "delete");
                    MessageBox.Show("Record Successfully Deleted ", "Successfuly", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Customerbillinfo_Load(sender, e);
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
                    MessageBox.Show("Please,Enter Customersell Id for search record", "Record Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    cmd = new SqlCommand("select * from C_billinfo where custsellid=" + Convert.ToInt32(txtsearch.Text), cn);
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

        private void btnremove_Click(object sender, EventArgs e)
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

        private void txtdiscount_TextChanged(object sender, EventArgs e)
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

        private void txtcustsell_id_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cmbcustname_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void btnadditem_Click(object sender, EventArgs e)
        {
            String[] arr = new String[4];
            arr[0] = cmbproname.Text;
            arr[1] = txtprice.Text;
            arr[2] = txtqty.Text;
            arr[3] = txttotal.Text;

            ListViewItem ls = new ListViewItem(arr);
            listView1.Items.Add(ls);
            // txtsubtotal.Text = (Convert.ToInt32(txtsubtotal.Text) + Convert.ToInt32(listView1.Items[r].SubItems[3].Text)).ToString();
            // listView1.Items[r].SubItems[3].Text =( (Convert.ToInt32(listView1.Items[r].SubItems[2].Text)) *( Convert.ToInt32(listView1.Items[r].SubItems[1].Text))).ToString();
            //  int subtot=0;//= Convert.ToInt32(txtsubtotal.Text);
            //  int tot = Convert.ToInt32(txttotal.Text);

            // subtot = subtot + tot;
            //txtsubtotal.Text= Convert.ToString(subtot); 
            // r++;
            txtsubtotal.Text = (Convert.ToInt32(txtsubtotal.Text) + Convert.ToInt32(txttotal.Text)).ToString();

            cmbcustname.Enabled = false;
        }

        private void txtcust_id_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cmbcustname_SelectedValueChanged(object sender, EventArgs e)
        {
            txtcust_id.Text = cmbcustname.SelectedValue.ToString();
        }

        private void cmbproname_SelectedValueChanged(object sender, EventArgs e)
        {
            txtproductid.Text = cmbproname.SelectedValue.ToString();
        }
    }
}
