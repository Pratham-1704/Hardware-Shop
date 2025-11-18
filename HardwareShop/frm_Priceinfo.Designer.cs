
namespace HardwareShop
{
    partial class frm_Priceinfo
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
            this.lblproduct_name = new System.Windows.Forms.Label();
            this.cmbproname = new System.Windows.Forms.ComboBox();
            this.lblproduct_price = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.txtproductprice = new System.Windows.Forms.TextBox();
            this.txtproductid = new System.Windows.Forms.TextBox();
            this.lblproductid = new System.Windows.Forms.Label();
            this.lblproductprice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblproduct_name
            // 
            this.lblproduct_name.AutoSize = true;
            this.lblproduct_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproduct_name.Location = new System.Drawing.Point(51, 101);
            this.lblproduct_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblproduct_name.Name = "lblproduct_name";
            this.lblproduct_name.Size = new System.Drawing.Size(145, 25);
            this.lblproduct_name.TabIndex = 30;
            this.lblproduct_name.Text = "Product name";
            // 
            // cmbproname
            // 
            this.cmbproname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbproname.FormattingEnabled = true;
            this.cmbproname.Location = new System.Drawing.Point(244, 93);
            this.cmbproname.Margin = new System.Windows.Forms.Padding(4);
            this.cmbproname.Name = "cmbproname";
            this.cmbproname.Size = new System.Drawing.Size(200, 32);
            this.cmbproname.TabIndex = 2;
            this.cmbproname.SelectedIndexChanged += new System.EventHandler(this.cmbproname_SelectedIndexChanged);
            this.cmbproname.SelectedValueChanged += new System.EventHandler(this.cmbproname_SelectedValueChanged);
            this.cmbproname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbproname_KeyPress);
            // 
            // lblproduct_price
            // 
            this.lblproduct_price.AutoSize = true;
            this.lblproduct_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproduct_price.Location = new System.Drawing.Point(51, 172);
            this.lblproduct_price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblproduct_price.Name = "lblproduct_price";
            this.lblproduct_price.Size = new System.Drawing.Size(141, 25);
            this.lblproduct_price.TabIndex = 28;
            this.lblproduct_price.Text = "Product Price";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 311);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(737, 220);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.Location = new System.Drawing.Point(741, 263);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(123, 30);
            this.txtsearch.TabIndex = 8;
            this.txtsearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsearch_KeyPress);
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnsearch.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.Location = new System.Drawing.Point(609, 255);
            this.btnsearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(124, 49);
            this.btnsearch.TabIndex = 9;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnclear.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(351, 251);
            this.btnclear.Margin = new System.Windows.Forms.Padding(4);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(117, 48);
            this.btnclear.TabIndex = 6;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btndelete.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(476, 255);
            this.btndelete.Margin = new System.Windows.Forms.Padding(4);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(125, 47);
            this.btndelete.TabIndex = 7;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnupdate.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(191, 251);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(140, 47);
            this.btnupdate.TabIndex = 5;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnsave.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(56, 251);
            this.btnsave.Margin = new System.Windows.Forms.Padding(4);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(127, 47);
            this.btnsave.TabIndex = 4;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txtproductprice
            // 
            this.txtproductprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtproductprice.Location = new System.Drawing.Point(244, 169);
            this.txtproductprice.Margin = new System.Windows.Forms.Padding(4);
            this.txtproductprice.Name = "txtproductprice";
            this.txtproductprice.Size = new System.Drawing.Size(108, 30);
            this.txtproductprice.TabIndex = 3;
            this.txtproductprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtproductprice_KeyPress);
            // 
            // txtproductid
            // 
            this.txtproductid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtproductid.Location = new System.Drawing.Point(584, 93);
            this.txtproductid.Margin = new System.Windows.Forms.Padding(4);
            this.txtproductid.Name = "txtproductid";
            this.txtproductid.Size = new System.Drawing.Size(99, 30);
            this.txtproductid.TabIndex = 1;
            this.txtproductid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtproductid_KeyPress);
            // 
            // lblproductid
            // 
            this.lblproductid.AutoSize = true;
            this.lblproductid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproductid.Location = new System.Drawing.Point(453, 96);
            this.lblproductid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblproductid.Name = "lblproductid";
            this.lblproductid.Size = new System.Drawing.Size(110, 25);
            this.lblproductid.TabIndex = 18;
            this.lblproductid.Text = "Product Id";
            // 
            // lblproductprice
            // 
            this.lblproductprice.AutoSize = true;
            this.lblproductprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproductprice.Location = new System.Drawing.Point(360, 34);
            this.lblproductprice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblproductprice.Name = "lblproductprice";
            this.lblproductprice.Size = new System.Drawing.Size(171, 29);
            this.lblproductprice.TabIndex = 17;
            this.lblproductprice.Text = "Product Price";
            // 
            // frm_Priceinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 564);
            this.Controls.Add(this.lblproduct_name);
            this.Controls.Add(this.cmbproname);
            this.Controls.Add(this.lblproduct_price);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txtproductprice);
            this.Controls.Add(this.txtproductid);
            this.Controls.Add(this.lblproductid);
            this.Controls.Add(this.lblproductprice);
            this.Name = "frm_Priceinfo";
            this.Text = "frm_Priceinfo";
            this.Load += new System.EventHandler(this.frm_Priceinfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblproduct_name;
        private System.Windows.Forms.ComboBox cmbproname;
        private System.Windows.Forms.Label lblproduct_price;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txtproductprice;
        private System.Windows.Forms.TextBox txtproductid;
        private System.Windows.Forms.Label lblproductid;
        private System.Windows.Forms.Label lblproductprice;
    }
}