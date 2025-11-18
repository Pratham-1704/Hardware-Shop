
namespace HardwareShop
{
    partial class frmC_billtable
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbcustname = new System.Windows.Forms.ComboBox();
            this.lblcustname = new System.Windows.Forms.Label();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.txtcust_id = new System.Windows.Forms.TextBox();
            this.txtcustsell_id = new System.Windows.Forms.TextBox();
            this.lbldate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblcustmorid = new System.Windows.Forms.Label();
            this.lblcust_sellid = new System.Windows.Forms.Label();
            this.llblc_billtable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbcustname
            // 
            this.cmbcustname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcustname.FormattingEnabled = true;
            this.cmbcustname.Location = new System.Drawing.Point(215, 137);
            this.cmbcustname.Margin = new System.Windows.Forms.Padding(4);
            this.cmbcustname.Name = "cmbcustname";
            this.cmbcustname.Size = new System.Drawing.Size(185, 32);
            this.cmbcustname.TabIndex = 2;
            this.cmbcustname.SelectedValueChanged += new System.EventHandler(this.cmbcustname_SelectedValueChanged);
            this.cmbcustname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbcustname_KeyPress);
            // 
            // lblcustname
            // 
            this.lblcustname.AutoSize = true;
            this.lblcustname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcustname.Location = new System.Drawing.Point(48, 137);
            this.lblcustname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcustname.Name = "lblcustname";
            this.lblcustname.Size = new System.Drawing.Size(117, 25);
            this.lblcustname.TabIndex = 43;
            this.lblcustname.Text = "cust_name";
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btndelete.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(531, 216);
            this.btndelete.Margin = new System.Windows.Forms.Padding(4);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(123, 55);
            this.btndelete.TabIndex = 8;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnupdate.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(195, 216);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(141, 55);
            this.btnupdate.TabIndex = 6;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(91, 280);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(766, 230);
            this.dataGridView1.TabIndex = 40;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.Location = new System.Drawing.Point(838, 228);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(123, 32);
            this.txtsearch.TabIndex = 9;
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnsearch.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.Location = new System.Drawing.Point(680, 216);
            this.btnsearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(136, 55);
            this.btnsearch.TabIndex = 10;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            this.btnsearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnsearch_KeyPress);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnclear.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(364, 216);
            this.btnclear.Margin = new System.Windows.Forms.Padding(4);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(136, 54);
            this.btnclear.TabIndex = 7;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnsave.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(50, 216);
            this.btnsave.Margin = new System.Windows.Forms.Padding(4);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(117, 54);
            this.btnsave.TabIndex = 5;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txtcust_id
            // 
            this.txtcust_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcust_id.Location = new System.Drawing.Point(624, 137);
            this.txtcust_id.Margin = new System.Windows.Forms.Padding(4);
            this.txtcust_id.Name = "txtcust_id";
            this.txtcust_id.Size = new System.Drawing.Size(128, 30);
            this.txtcust_id.TabIndex = 3;
            this.txtcust_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcust_id_KeyPress);
            // 
            // txtcustsell_id
            // 
            this.txtcustsell_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcustsell_id.Location = new System.Drawing.Point(215, 71);
            this.txtcustsell_id.Margin = new System.Windows.Forms.Padding(4);
            this.txtcustsell_id.Name = "txtcustsell_id";
            this.txtcustsell_id.Size = new System.Drawing.Size(101, 30);
            this.txtcustsell_id.TabIndex = 1;
            this.txtcustsell_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcustsell_id_KeyPress);
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.Location = new System.Drawing.Point(470, 71);
            this.lbldate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(57, 25);
            this.lbldate.TabIndex = 39;
            this.lbldate.Text = "Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM/dd/yy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(624, 68);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(148, 30);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // lblcustmorid
            // 
            this.lblcustmorid.AutoSize = true;
            this.lblcustmorid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcustmorid.Location = new System.Drawing.Point(470, 145);
            this.lblcustmorid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcustmorid.Name = "lblcustmorid";
            this.lblcustmorid.Size = new System.Drawing.Size(128, 25);
            this.lblcustmorid.TabIndex = 38;
            this.lblcustmorid.Text = "Customer id";
            // 
            // lblcust_sellid
            // 
            this.lblcust_sellid.AutoSize = true;
            this.lblcust_sellid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcust_sellid.Location = new System.Drawing.Point(44, 75);
            this.lblcust_sellid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcust_sellid.Name = "lblcust_sellid";
            this.lblcust_sellid.Size = new System.Drawing.Size(123, 25);
            this.lblcust_sellid.TabIndex = 37;
            this.lblcust_sellid.Text = "CustSell_id";
            // 
            // llblc_billtable
            // 
            this.llblc_billtable.AutoSize = true;
            this.llblc_billtable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblc_billtable.Location = new System.Drawing.Point(267, -31);
            this.llblc_billtable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llblc_billtable.Name = "llblc_billtable";
            this.llblc_billtable.Size = new System.Drawing.Size(245, 29);
            this.llblc_billtable.TabIndex = 36;
            this.llblc_billtable.Text = "Customer Bill Table";
            // 
            // frmC_billtable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 523);
            this.Controls.Add(this.cmbcustname);
            this.Controls.Add(this.lblcustname);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txtcust_id);
            this.Controls.Add(this.txtcustsell_id);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblcustmorid);
            this.Controls.Add(this.lblcust_sellid);
            this.Controls.Add(this.llblc_billtable);
            this.Name = "frmC_billtable";
            this.Text = "frmC_billtable";
            this.Load += new System.EventHandler(this.frmC_billtable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbcustname;
        private System.Windows.Forms.Label lblcustname;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txtcust_id;
        private System.Windows.Forms.TextBox txtcustsell_id;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblcustmorid;
        private System.Windows.Forms.Label lblcust_sellid;
        private System.Windows.Forms.Label llblc_billtable;
    }
}