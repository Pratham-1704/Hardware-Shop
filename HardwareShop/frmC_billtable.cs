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
    public partial class frmC_billtable : Form
    {
        SqlConnection cn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\PRASAD\\Documents\\HardwareShop.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        public frmC_billtable()
        {
            InitializeComponent();
        }
        public void displaygrid()
        {
            cmd = new SqlCommand("select * from C_billtable", cn);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "C_billtable");
            dataGridView1.DataSource = ds.Tables["C_billtable"];
        }
        public void txtclear()
        {
            txtcust_id.Clear();
        }
        public void autocustsellid()
        {
            
            cmd = new SqlCommand("select max(custsellid)from C_billtable", cn);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "max");
             int max = Convert.ToInt32(ds.Tables["max"].Rows[0][0].ToString());
             txtcustsell_id.Text = Convert.ToString(max + 1);
        }
        public void display_cust_Regist()
        {
            cmd = new SqlCommand("select * from cust_Regist", cn);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "cust_Regist");

            cmbcustname.DataSource = ds.Tables["cust_Regist"];
            cmbcustname.ValueMember = "cust_id";
            cmbcustname.DisplayMember = "cust_name";
        }

        private void frmC_billtable_Load(object sender, EventArgs e)
        {
            displaygrid();
            txtclear();
            autocustsellid();
            display_cust_Regist();
            txtsearch.Focus();
            //btnsave.Enabled = true;
            //btndelete.Enabled = false;
            //btnupdate.Enabled = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcustsell_id.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["custsellid"].Value);
            txtcust_id.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["cust_id"].Value);
            dateTimePicker1.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["date"].Value);
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

        private void cmbcustname_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnsearch_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cmbcustname_Leave(object sender, EventArgs e)
        {
            txtcust_id.Text = cmbcustname.SelectedValue.ToString();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {

                cmd = new SqlCommand("select custsellid from C_billinfo where custsellid=" + txtcustsell_id.Text, cn);
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
                    if (txtcustsell_id.Text == "")
                    {
                        MessageBox.Show("Please,Enter customer sell Id", "Record Details", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else if (txtcust_id.Text == "")
                    {
                        MessageBox.Show("Please,Enter customer Id", "Record Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        cmd = new SqlCommand("insert into C_billtable values (" + txtcustsell_id.Text + "," + txtcust_id.Text + ",'" + dateTimePicker1.Text + "')", cn);
                        da = new SqlDataAdapter(cmd);
                        ds = new DataSet();
                        da.Fill(ds, "insert");
                        MessageBox.Show("Record Successfully inserted ", "Successfuly", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmC_billtable_Load(sender, e);
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
                if (txtcustsell_id.Text == "")
                {
                    MessageBox.Show("Please,Enter customersell Id", "Record Details", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (txtcust_id.Text == "")
                {
                    MessageBox.Show("Please,Enter customer Id", "Record Details", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    cmd = new SqlCommand("update C_billtable set cust_id=" + txtcust_id.Text + ",date='" + dateTimePicker1.Text + "' where custsellid=" + txtcustsell_id.Text, cn);
                    da = new SqlDataAdapter(cmd);
                    ds = new DataSet();
                    da.Fill(ds, "update");
                    MessageBox.Show("Record Successfully updated ", "Successfuly", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmC_billtable_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            frmC_billtable_Load(sender, e);
            txtsearch.Clear();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtcustsell_id.Text == "")
                {
                    MessageBox.Show("Please,Enter customersell Id", "Record Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txtcust_id.Text == "")
                {
                    MessageBox.Show("Please,Enter customer Id", "Record Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    cmd = new SqlCommand("delete from C_billtable where custsellid=" + txtcustsell_id.Text, cn);
                    da = new SqlDataAdapter(cmd);
                    ds = new DataSet();
                    da.Fill(ds, "delete");
                    MessageBox.Show("Record Successfully deleted ", "Successfuly", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmC_billtable_Load(sender, e);
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
                    cmd = new SqlCommand("select * from C_billtable where custsellid=" + Convert.ToInt32(txtsearch.Text), cn);
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

        private void cmbcustname_SelectedValueChanged(object sender, EventArgs e)
        {
            txtcust_id.Text = cmbcustname.SelectedValue.ToString();
        }
    }
}
