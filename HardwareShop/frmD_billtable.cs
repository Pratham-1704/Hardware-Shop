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
    public partial class frmD_billtable : Form
    {
        SqlConnection cn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\PRASAD\\Documents\\HardwareShop.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        public frmD_billtable()
        {
            InitializeComponent();
        }
        public void displaygrid()
        {
            cmd = new SqlCommand("select * from D_billtable", cn);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "D_billtable");
            dataGridView1.DataSource = ds.Tables["D_billtable"];
        }
        public void txtclear()
        {
            txtdeal_id.Clear();
        }
        public void autodealsellid()
        {
            cmd = new SqlCommand("select max(dsellid) from D_billtable", cn);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "max");
            int max = Convert.ToInt32(ds.Tables["max"].Rows[0][0].ToString());
            txtdealsell_id.Text = Convert.ToString(max + 1);
        }
        public void display_deal_Regist()
        {
            cmd = new SqlCommand("select * from dealer_regst", cn);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "dealer_regst");

            cmbdealname.DataSource = ds.Tables["dealer_regst"];
            cmbdealname.ValueMember = "deal_id";
            cmbdealname.DisplayMember = "deal_name";
        }
        private void frmD_billtable_Load(object sender, EventArgs e)
        {
            displaygrid();
            txtclear();
            autodealsellid();
            display_deal_Regist();
            txtsearch.Focus();
            btnsave.Enabled = true;
            btndelete.Enabled = false;
            btnupdate.Enabled = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtdealsell_id.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["dsellid"].Value);
            txtdeal_id.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["deal_id"].Value);
            dateTimePicker1.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["date"].Value);
        }
        private void cmbdealname_Leave(object sender, EventArgs e)
        {
            txtdeal_id.Text = cmbdealname.SelectedValue.ToString();
        }
        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("select dsellid from D_billinfo where dsellid=" + txtdealsell_id.Text, cn);
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds, "s");
                int dsellid = ds.Tables["s"].Rows.Count;

                if (dsellid > 0)
                {
                    MessageBox.Show("Already Exists dealersell Id ,See Below", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    if (txtdealsell_id.Text == "")
                    {
                        MessageBox.Show("Please,Enter dealer sell Id", "Record Details", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else if (txtdeal_id.Text == "")
                    {
                        MessageBox.Show("Please,Enter dealer Id", "Record Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        cmd = new SqlCommand("insert into D_billtable values (" + txtdealsell_id.Text + "," + txtdeal_id.Text + ",'" + dateTimePicker1.Text + "')", cn);
                        da = new SqlDataAdapter(cmd);
                        ds = new DataSet();
                        da.Fill(ds, "insert");
                        MessageBox.Show("Record Successfully inserted ", "Successfuly", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmD_billtable_Load(sender, e);
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
                if (txtdealsell_id.Text == "")
                {
                    MessageBox.Show("Please,Enter dealersell Id", "Record Details", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (txtdeal_id.Text == "")
                {
                    MessageBox.Show("Please,Enter dealer Id", "Record Details", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    cmd = new SqlCommand("update D_billtable set deal_id=" + txtdeal_id.Text + ",date='" + dateTimePicker1.Text + "' where dsellid=" + txtdealsell_id.Text, cn);
                    da = new SqlDataAdapter(cmd);
                    ds = new DataSet();
                    da.Fill(ds, "update");
                    MessageBox.Show("Record Successfully updated ", "Successfuly", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmD_billtable_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            frmD_billtable_Load(sender , e);
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtdealsell_id.Text == "")
                {
                    MessageBox.Show("Please,Enter dealersell Id", "Record Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txtdeal_id.Text == "")
                {
                    MessageBox.Show("Please,Enter dealer Id", "Record Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    cmd = new SqlCommand("delete from D_billtable where dsellid=" + txtdealsell_id.Text, cn);
                    da = new SqlDataAdapter(cmd);
                    ds = new DataSet();
                    da.Fill(ds, "delete");
                    MessageBox.Show("Record Successfully deleted ", "Successfuly", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmD_billtable_Load(sender, e);
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
                    MessageBox.Show("Please,Enter Dealersell Id for search record", "Record Details", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    cmd = new SqlCommand("select * from D_billtable where dsellid=" + Convert.ToInt32(txtsearch.Text), cn);
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
    }
}
