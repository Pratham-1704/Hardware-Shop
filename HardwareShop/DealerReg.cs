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
    public partial class DealerReg : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\PRASAD\\Documents\\HardwareShop.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds = new DataSet();

        public DealerReg()
        {
            InitializeComponent();
        }

        public void displaygrid()
        {
            cmd = new SqlCommand("select * from dealer_regst", conn);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "dealer_regst");
            DealerGridView.DataSource = ds.Tables["dealer_regst"];
        }

        public void txtClear()
        {
            txtdealer_id.Clear();
            txtdealer_mob.Clear();
            txtdealer_name.Clear();
            txtdealer_addr.Clear();
        }

        public void auto_deal_id()
        {
            cmd = new SqlCommand("select max(deal_id) from dealer_regst", conn);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "max");
            int max = Convert.ToInt32(ds.Tables["max"].Rows[0][0].ToString());
            txtdealer_id.Text = Convert.ToString(max + 1);
        }

        private void DealerReg_Load(object sender, EventArgs e)
        {
            displaygrid();
            txtClear();
            auto_deal_id();
            txtSearch.Focus();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtdealer_id.Text) || string.IsNullOrWhiteSpace(txtdealer_name.Text) || string.IsNullOrWhiteSpace(txtdealer_addr.Text) || string.IsNullOrWhiteSpace(txtdealer_mob.Text) || dateTimePicker1.Text == "")
                {
                    MessageBox.Show("Please Enter Valid Data...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    cmd = new SqlCommand("insert into dealer_regst values(@deal_id, @deal_name, @deal_add, @deal_mob, @regdate)", conn);
                    cmd.Parameters.AddWithValue("@deal_id", txtdealer_id.Text);
                    cmd.Parameters.AddWithValue("@deal_name", txtdealer_name.Text);
                    cmd.Parameters.AddWithValue("@deal_add", txtdealer_addr.Text);
                    cmd.Parameters.AddWithValue("@deal_mob", txtdealer_mob.Text);
                    cmd.Parameters.AddWithValue("@regdate", dateTimePicker1.Text);
                    da = new SqlDataAdapter(cmd);
                    ds = new DataSet();
                    da.Fill(ds, "insert");
                    MessageBox.Show("Record Successfully inserted", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DealerReg_Load(sender, e);
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
                if (string.IsNullOrWhiteSpace(txtdealer_id.Text) || string.IsNullOrWhiteSpace(txtdealer_name.Text) || string.IsNullOrWhiteSpace(txtdealer_addr.Text) || string.IsNullOrWhiteSpace(txtdealer_mob.Text) || dateTimePicker1.Text == "")
                {
                    MessageBox.Show("Please Enter Valid Data...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    cmd = new SqlCommand("update dealer_regst set deal_name=@deal_name, deal_add=@deal_add, deal_mob=@deal_mob, regdate=@regdate where deal_id=@deal_id", conn);
                    cmd.Parameters.AddWithValue("@deal_id", txtdealer_id.Text);
                    cmd.Parameters.AddWithValue("@deal_name", txtdealer_name.Text);
                    cmd.Parameters.AddWithValue("@deal_add", txtdealer_addr.Text);
                    cmd.Parameters.AddWithValue("@deal_mob", txtdealer_mob.Text);
                    cmd.Parameters.AddWithValue("@regdate", dateTimePicker1.Text);
                    da = new SqlDataAdapter(cmd);
                    ds = new DataSet();
                    da.Fill(ds, "update");
                    MessageBox.Show("Record Successfully updated", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DealerReg_Load(sender, e);
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
                if (string.IsNullOrWhiteSpace(txtdealer_id.Text) || string.IsNullOrWhiteSpace(txtdealer_name.Text) || string.IsNullOrWhiteSpace(txtdealer_mob.Text) || string.IsNullOrWhiteSpace(txtdealer_addr.Text) || dateTimePicker1.Text == "")
                {
                    MessageBox.Show("Please Enter Valid Data...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    cmd = new SqlCommand("delete from dealer_regst where deal_id=@deal_id", conn);
                    cmd.Parameters.AddWithValue("@deal_id", txtdealer_id.Text);
                    da = new SqlDataAdapter(cmd);
                    ds = new DataSet();
                    da.Fill(ds, "delete");
                    MessageBox.Show("Record Successfully deleted", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DealerReg_Load(sender, e);
                    txtClear();
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
                if (string.IsNullOrWhiteSpace(txtSearch.Text))
                {
                    MessageBox.Show("Please,Enter Customer id for search record", "Record Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    cmd = new SqlCommand("select * from dealer_regst where deal_id=" + Convert.ToInt32(txtSearch.Text), conn);
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
                        DealerGridView.DataSource = ds.Tables["search"];
                        btnadd.Enabled = false;
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

        private void DealerGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    txtdealer_id.Text = DealerGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txtdealer_name.Text = DealerGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtdealer_addr.Text = DealerGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtdealer_mob.Text = DealerGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                    dateTimePicker1.Text = DealerGridView.Rows[e.RowIndex].Cells[4].Value.ToString();

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
            txtdealer_id.Clear();
            txtdealer_mob.Clear();
            txtdealer_addr.Clear();
            txtdealer_name.Clear();
            txtSearch.Clear();
           
        }
    }
}