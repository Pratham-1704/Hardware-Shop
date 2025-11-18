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
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\PRASAD\\Documents\\HardwareShop.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds = new DataSet();
       // int index;
        public Form1()
        {
            InitializeComponent();
        }
        public void displaygrid()
        {
            cmd = new SqlCommand("select * from cust_Regist", conn);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "cust_Regist");
            CustGridView.DataSource = ds.Tables["cust_Regist"];

        }
        public void txtClear()
        {
            txtcust_id.Clear();
            txtcust_mob.Clear();
            txtcust_name.Clear();
            txtcust_addr.Clear();
        }
        public void auto_cust_id()
        {
            cmd = new SqlCommand("select max(cust_id)from cust_Regist", conn);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "max");
            int max = Convert.ToInt32(ds.Tables["max"].Rows[0][0].ToString());
            txtcust_id.Text = Convert.ToString(max + 1);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            displaygrid();
            txtClear();
            auto_cust_id();
            txtSearch.Focus();
        
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtcust_id.Text) || string.IsNullOrWhiteSpace(txtcust_name.Text) || string.IsNullOrWhiteSpace(txtcust_addr.Text) || string.IsNullOrWhiteSpace(txtcust_mob.Text) || dateTimePicker1.Text == "")
                {
                    MessageBox.Show("Please Enter Valid Data...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    cmd = new SqlCommand("insert into cust_Regist values(@cust_id, @cust_name, @cust_add, @cust_mob, @regdate)", conn);
                    cmd.Parameters.AddWithValue("@cust_id", txtcust_id.Text);
                    cmd.Parameters.AddWithValue("@cust_name", txtcust_name.Text);
                    cmd.Parameters.AddWithValue("@cust_add", txtcust_addr.Text);
                    cmd.Parameters.AddWithValue("@cust_mob", txtcust_mob.Text);
                    cmd.Parameters.AddWithValue("@regdate", dateTimePicker1.Text);
                    da = new SqlDataAdapter(cmd);
                    ds = new DataSet();
                    da.Fill(ds, "insert");
                    MessageBox.Show("Record Successfully inserted", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form1_Load(sender, e);
                    txtClear();
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
                if (string.IsNullOrWhiteSpace(txtcust_id.Text) || string.IsNullOrWhiteSpace(txtcust_name.Text) || string.IsNullOrWhiteSpace(txtcust_addr.Text) || string.IsNullOrWhiteSpace(txtcust_mob.Text) || dateTimePicker1.Text == "")
                {
                    MessageBox.Show("Please Enter Valid Data...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    cmd = new SqlCommand("update cust_Regist set cust_name=@cust_name, cust_add=@cust_add, cust_mob=@cust_mob, regdate=@regdate where cust_id=@cust_id", conn);
                    cmd.Parameters.AddWithValue("@cust_id", txtcust_id.Text);
                    cmd.Parameters.AddWithValue("@cust_name", txtcust_name.Text);
                    cmd.Parameters.AddWithValue("@cust_add", txtcust_addr.Text);
                    cmd.Parameters.AddWithValue("@cust_mob", txtcust_mob.Text);
                    cmd.Parameters.AddWithValue("@regdate", dateTimePicker1.Text);
                    da = new SqlDataAdapter(cmd);
                    ds = new DataSet();
                    da.Fill(ds, "update");
                    MessageBox.Show("Record Successfully updated", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form1_Load(sender, e);
                    txtClear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtcust_id.Text) || string.IsNullOrWhiteSpace(txtcust_name.Text) || string.IsNullOrWhiteSpace(txtcust_mob.Text) || string.IsNullOrWhiteSpace(txtcust_addr.Text) || dateTimePicker1.Text == "")
                {
                    MessageBox.Show("Please Enter Valid Data...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    cmd = new SqlCommand("delete from cust_regist where cust_id=@cust_id", conn);
                    cmd.Parameters.AddWithValue("@cust_id", txtcust_id.Text);
                    da = new SqlDataAdapter(cmd);
                    ds = new DataSet();
                    da.Fill(ds, "delete");
                    MessageBox.Show("Record Successfully deleted", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form1_Load(sender, e);
                    txtClear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CustGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = CustGridView.Rows[e.RowIndex];

                    txtcust_id.Text = row.Cells[0].Value.ToString();
                    txtcust_name.Text = row.Cells[1].Value.ToString();
                    txtcust_addr.Text = row.Cells[2].Value.ToString();
                    txtcust_mob.Text = row.Cells[3].Value.ToString();
                    dateTimePicker1.Text = row.Cells[4].Value.ToString();

                }
            
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtSearch.Text))
                {
                    MessageBox.Show("Please,Enter Customer id for search record", "Record Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    cmd = new SqlCommand("select * from cust_regist where cust_id=" + Convert.ToInt32(txtSearch.Text), conn);
                    da = new SqlDataAdapter(cmd);
                    ds = new DataSet();
                    da.Fill(ds, "search");
                    int s = ds.Tables[0].Rows.Count;
                    if (s == 0)
                    {
                        MessageBox.Show("Customer id does not exists", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtSearch.Clear();
                    }
                    else
                    {
                        CustGridView.DataSource = ds.Tables["search"];
                       // btnadd.Enabled = false;
                        btndelete.Enabled = true;
                        btnupdate.Enabled = true;
                        txtSearch.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CustGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    txtcust_id.Text = CustGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txtcust_name.Text = CustGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtcust_addr.Text = CustGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtcust_mob.Text = CustGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                    dateTimePicker1.Text = CustGridView.Rows[e.RowIndex].Cells[4].Value.ToString();

                    // btnadd.Enabled = false;
                    btndelete.Enabled = true;
                    btnupdate.Enabled = true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtcust_id.Clear();
            txtcust_mob.Clear();
            txtcust_name.Clear();
            txtcust_addr.Clear();
        }
    }
}
