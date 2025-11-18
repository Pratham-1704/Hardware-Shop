
namespace HardwareShop
{
    partial class frmD_billtable
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
            this.lbldealname = new System.Windows.Forms.Label();
            this.cmbdealname = new System.Windows.Forms.ComboBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.txtdeal_id = new System.Windows.Forms.TextBox();
            this.txtdealsell_id = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbldate = new System.Windows.Forms.Label();
            this.lbldealid = new System.Windows.Forms.Label();
            this.lbldealsellid = new System.Windows.Forms.Label();
            this.lblD_billtable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbldealname
            // 
            this.lbldealname.AutoSize = true;
            this.lbldealname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldealname.Location = new System.Drawing.Point(42, 186);
            this.lbldealname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldealname.Name = "lbldealname";
            this.lbldealname.Size = new System.Drawing.Size(121, 25);
            this.lbldealname.TabIndex = 44;
            this.lbldealname.Text = "Deal_name";
            // 
            // cmbdealname
            // 
            this.cmbdealname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbdealname.FormattingEnabled = true;
            this.cmbdealname.Location = new System.Drawing.Point(196, 186);
            this.cmbdealname.Margin = new System.Windows.Forms.Padding(4);
            this.cmbdealname.Name = "cmbdealname";
            this.cmbdealname.Size = new System.Drawing.Size(205, 33);
            this.cmbdealname.TabIndex = 3;
            this.cmbdealname.Leave += new System.EventHandler(this.cmbdealname_Leave);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btndelete.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(522, 248);
            this.btndelete.Margin = new System.Windows.Forms.Padding(4);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(128, 49);
            this.btndelete.TabIndex = 8;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnupdate.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(202, 248);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(128, 49);
            this.btnupdate.TabIndex = 6;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.Location = new System.Drawing.Point(820, 265);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(100, 30);
            this.txtsearch.TabIndex = 9;
            // 
            // txtdeal_id
            // 
            this.txtdeal_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdeal_id.Location = new System.Drawing.Point(590, 125);
            this.txtdeal_id.Margin = new System.Windows.Forms.Padding(4);
            this.txtdeal_id.Name = "txtdeal_id";
            this.txtdeal_id.Size = new System.Drawing.Size(100, 30);
            this.txtdeal_id.TabIndex = 2;
            this.txtdeal_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdeal_id_KeyPress);
            // 
            // txtdealsell_id
            // 
            this.txtdealsell_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdealsell_id.Location = new System.Drawing.Point(202, 117);
            this.txtdealsell_id.Margin = new System.Windows.Forms.Padding(4);
            this.txtdealsell_id.Name = "txtdealsell_id";
            this.txtdealsell_id.Size = new System.Drawing.Size(184, 30);
            this.txtdealsell_id.TabIndex = 1;
            this.txtdealsell_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdealsell_id_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 322);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(887, 230);
            this.dataGridView1.TabIndex = 40;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnsearch.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.Location = new System.Drawing.Point(684, 248);
            this.btnsearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(128, 49);
            this.btnsearch.TabIndex = 10;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnclear.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(356, 248);
            this.btnclear.Margin = new System.Windows.Forms.Padding(4);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(128, 49);
            this.btnclear.TabIndex = 7;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnsave.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(48, 248);
            this.btnsave.Margin = new System.Windows.Forms.Padding(4);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(128, 49);
            this.btnsave.TabIndex = 5;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM-dd-yy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(590, 189);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(147, 30);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.Location = new System.Drawing.Point(440, 196);
            this.lbldate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(57, 25);
            this.lbldate.TabIndex = 39;
            this.lbldate.Text = "Date";
            // 
            // lbldealid
            // 
            this.lbldealid.AutoSize = true;
            this.lbldealid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldealid.Location = new System.Drawing.Point(440, 125);
            this.lbldealid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldealid.Name = "lbldealid";
            this.lbldealid.Size = new System.Drawing.Size(92, 25);
            this.lbldealid.TabIndex = 38;
            this.lbldealid.Text = "Deal _Id";
            // 
            // lbldealsellid
            // 
            this.lbldealsellid.AutoSize = true;
            this.lbldealsellid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldealsellid.Location = new System.Drawing.Point(42, 117);
            this.lbldealsellid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldealsellid.Name = "lbldealsellid";
            this.lbldealsellid.Size = new System.Drawing.Size(122, 25);
            this.lbldealsellid.TabIndex = 37;
            this.lbldealsellid.Text = "DealSell_id";
            // 
            // lblD_billtable
            // 
            this.lblD_billtable.AutoSize = true;
            this.lblD_billtable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblD_billtable.Location = new System.Drawing.Point(366, 62);
            this.lblD_billtable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblD_billtable.Name = "lblD_billtable";
            this.lblD_billtable.Size = new System.Drawing.Size(211, 29);
            this.lblD_billtable.TabIndex = 36;
            this.lblD_billtable.Text = "Dealer Bill Table";
            // 
            // frmD_billtable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 615);
            this.Controls.Add(this.lbldealname);
            this.Controls.Add(this.cmbdealname);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.txtdeal_id);
            this.Controls.Add(this.txtdealsell_id);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.lbldealid);
            this.Controls.Add(this.lbldealsellid);
            this.Controls.Add(this.lblD_billtable);
            this.Name = "frmD_billtable";
            this.Text = "frmD_billtable";
            this.Load += new System.EventHandler(this.frmD_billtable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldealname;
        private System.Windows.Forms.ComboBox cmbdealname;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.TextBox txtdeal_id;
        private System.Windows.Forms.TextBox txtdealsell_id;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label lbldealid;
        private System.Windows.Forms.Label lbldealsellid;
        private System.Windows.Forms.Label lblD_billtable;
    }
}