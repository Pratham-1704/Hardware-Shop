
namespace HardwareShop
{
    partial class DealerBillInfo
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
            this.txtdeal_id = new System.Windows.Forms.TextBox();
            this.lbldeal_id = new System.Windows.Forms.Label();
            this.txtstock = new System.Windows.Forms.TextBox();
            this.lbldisplaystock = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbldate = new System.Windows.Forms.Label();
            this.cmbdealname = new System.Windows.Forms.ComboBox();
            this.lbldealname = new System.Windows.Forms.Label();
            this.btnremoveitem = new System.Windows.Forms.Button();
            this.btnadditem = new System.Windows.Forms.Button();
            this.txtdiscount = new System.Windows.Forms.TextBox();
            this.txtsubtotal = new System.Windows.Forms.TextBox();
            this.lbldiscount = new System.Windows.Forms.Label();
            this.lblsubtotal = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblproname = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.txtproductid = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtdealsell_id = new System.Windows.Forms.TextBox();
            this.cmbproname = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.lbltotal = new System.Windows.Forms.Label();
            this.lblprice = new System.Windows.Forms.Label();
            this.lblqty = new System.Windows.Forms.Label();
            this.lblproductid = new System.Windows.Forms.Label();
            this.lblDealsellid = new System.Windows.Forms.Label();
            this.lbldinfotable = new System.Windows.Forms.Label();
            this.txtnetamt = new System.Windows.Forms.TextBox();
            this.lblnetamt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtdeal_id
            // 
            this.txtdeal_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdeal_id.Location = new System.Drawing.Point(858, 72);
            this.txtdeal_id.Margin = new System.Windows.Forms.Padding(4);
            this.txtdeal_id.Name = "txtdeal_id";
            this.txtdeal_id.Size = new System.Drawing.Size(108, 30);
            this.txtdeal_id.TabIndex = 3;
            this.txtdeal_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdeal_id_KeyPress);
            // 
            // lbldeal_id
            // 
            this.lbldeal_id.AutoSize = true;
            this.lbldeal_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldeal_id.Location = new System.Drawing.Point(761, 76);
            this.lbldeal_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldeal_id.Name = "lbldeal_id";
            this.lbldeal_id.Size = new System.Drawing.Size(82, 25);
            this.lbldeal_id.TabIndex = 107;
            this.lbldeal_id.Text = "deal_id";
            // 
            // txtstock
            // 
            this.txtstock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstock.Location = new System.Drawing.Point(241, 210);
            this.txtstock.Margin = new System.Windows.Forms.Padding(4);
            this.txtstock.Name = "txtstock";
            this.txtstock.Size = new System.Drawing.Size(139, 30);
            this.txtstock.TabIndex = 105;
            this.txtstock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtstock_KeyPress);
            // 
            // lbldisplaystock
            // 
            this.lbldisplaystock.AutoSize = true;
            this.lbldisplaystock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldisplaystock.Location = new System.Drawing.Point(61, 210);
            this.lbldisplaystock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldisplaystock.Name = "lbldisplaystock";
            this.lbldisplaystock.Size = new System.Drawing.Size(67, 25);
            this.lbldisplaystock.TabIndex = 104;
            this.lbldisplaystock.Text = "Stock";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM-dd-yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(857, 15);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(149, 29);
            this.dateTimePicker1.TabIndex = 103;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.Location = new System.Drawing.Point(765, 15);
            this.lbldate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(57, 25);
            this.lbldate.TabIndex = 102;
            this.lbldate.Text = "Date";
            // 
            // cmbdealname
            // 
            this.cmbdealname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbdealname.FormattingEnabled = true;
            this.cmbdealname.Location = new System.Drawing.Point(182, 9);
            this.cmbdealname.Margin = new System.Windows.Forms.Padding(4);
            this.cmbdealname.Name = "cmbdealname";
            this.cmbdealname.Size = new System.Drawing.Size(224, 33);
            this.cmbdealname.TabIndex = 2;
            this.cmbdealname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbdealname_KeyPress);
            this.cmbdealname.Leave += new System.EventHandler(this.cmbdealname_Leave);
            // 
            // lbldealname
            // 
            this.lbldealname.AutoSize = true;
            this.lbldealname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldealname.Location = new System.Drawing.Point(22, 9);
            this.lbldealname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldealname.Name = "lbldealname";
            this.lbldealname.Size = new System.Drawing.Size(118, 25);
            this.lbldealname.TabIndex = 100;
            this.lbldealname.Text = "deal_name";
            // 
            // btnremoveitem
            // 
            this.btnremoveitem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremoveitem.Location = new System.Drawing.Point(843, 148);
            this.btnremoveitem.Margin = new System.Windows.Forms.Padding(4);
            this.btnremoveitem.Name = "btnremoveitem";
            this.btnremoveitem.Size = new System.Drawing.Size(164, 49);
            this.btnremoveitem.TabIndex = 99;
            this.btnremoveitem.Text = "Remove Item";
            this.btnremoveitem.UseVisualStyleBackColor = true;
            this.btnremoveitem.Click += new System.EventHandler(this.btnremoveitem_Click);
            // 
            // btnadditem
            // 
            this.btnadditem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadditem.Location = new System.Drawing.Point(631, 148);
            this.btnadditem.Margin = new System.Windows.Forms.Padding(4);
            this.btnadditem.Name = "btnadditem";
            this.btnadditem.Size = new System.Drawing.Size(168, 49);
            this.btnadditem.TabIndex = 98;
            this.btnadditem.Text = "Add Item";
            this.btnadditem.UseVisualStyleBackColor = true;
            this.btnadditem.Click += new System.EventHandler(this.btnadditem_Click);
            // 
            // txtdiscount
            // 
            this.txtdiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiscount.Location = new System.Drawing.Point(891, 527);
            this.txtdiscount.Margin = new System.Windows.Forms.Padding(4);
            this.txtdiscount.Name = "txtdiscount";
            this.txtdiscount.Size = new System.Drawing.Size(137, 30);
            this.txtdiscount.TabIndex = 97;
            this.txtdiscount.TextChanged += new System.EventHandler(this.txtdiscount_TextChanged);
            this.txtdiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdiscount_KeyPress);
            // 
            // txtsubtotal
            // 
            this.txtsubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsubtotal.Location = new System.Drawing.Point(891, 477);
            this.txtsubtotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtsubtotal.Name = "txtsubtotal";
            this.txtsubtotal.Size = new System.Drawing.Size(137, 30);
            this.txtsubtotal.TabIndex = 96;
            this.txtsubtotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsubtotal_KeyPress);
            // 
            // lbldiscount
            // 
            this.lbldiscount.AutoSize = true;
            this.lbldiscount.Font = new System.Drawing.Font("HP Simplified Hans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldiscount.Location = new System.Drawing.Point(705, 536);
            this.lbldiscount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldiscount.Name = "lbldiscount";
            this.lbldiscount.Size = new System.Drawing.Size(111, 27);
            this.lbldiscount.TabIndex = 95;
            this.lbldiscount.Text = "Discount";
            // 
            // lblsubtotal
            // 
            this.lblsubtotal.AutoSize = true;
            this.lblsubtotal.Font = new System.Drawing.Font("HP Simplified Hans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsubtotal.Location = new System.Drawing.Point(705, 486);
            this.lblsubtotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsubtotal.Name = "lblsubtotal";
            this.lblsubtotal.Size = new System.Drawing.Size(119, 27);
            this.lblsubtotal.TabIndex = 94;
            this.lblsubtotal.Text = "Sub Total";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(22, 249);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(632, 192);
            this.listView1.TabIndex = 93;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Product Name";
            this.columnHeader1.Width = 160;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Price";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Quanitity";
            this.columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Total";
            this.columnHeader4.Width = 80;
            // 
            // lblproname
            // 
            this.lblproname.AutoSize = true;
            this.lblproname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproname.Location = new System.Drawing.Point(23, 81);
            this.lblproname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblproname.Name = "lblproname";
            this.lblproname.Size = new System.Drawing.Size(143, 24);
            this.lblproname.TabIndex = 92;
            this.lblproname.Text = "Product Name";
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.Location = new System.Drawing.Point(875, 408);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(137, 30);
            this.txtsearch.TabIndex = 83;
            // 
            // txttotal
            // 
            this.txttotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotal.Location = new System.Drawing.Point(437, 166);
            this.txttotal.Margin = new System.Windows.Forms.Padding(4);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(140, 30);
            this.txttotal.TabIndex = 8;
            this.txttotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttotal_KeyPress);
            // 
            // txtqty
            // 
            this.txtqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqty.Location = new System.Drawing.Point(241, 166);
            this.txtqty.Margin = new System.Windows.Forms.Padding(4);
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(139, 30);
            this.txtqty.TabIndex = 7;
            this.txtqty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtqty_KeyPress);
            this.txtqty.Leave += new System.EventHandler(this.txtqty_Leave);
            // 
            // txtproductid
            // 
            this.txtproductid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtproductid.Location = new System.Drawing.Point(605, 71);
            this.txtproductid.Margin = new System.Windows.Forms.Padding(4);
            this.txtproductid.Name = "txtproductid";
            this.txtproductid.Size = new System.Drawing.Size(101, 30);
            this.txtproductid.TabIndex = 5;
            this.txtproductid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtproductid_KeyPress);
            // 
            // txtprice
            // 
            this.txtprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprice.Location = new System.Drawing.Point(27, 166);
            this.txtprice.Margin = new System.Windows.Forms.Padding(4);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(139, 30);
            this.txtprice.TabIndex = 6;
            this.txtprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprice_KeyPress);
            // 
            // txtdealsell_id
            // 
            this.txtdealsell_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdealsell_id.Location = new System.Drawing.Point(605, 12);
            this.txtdealsell_id.Margin = new System.Windows.Forms.Padding(4);
            this.txtdealsell_id.Name = "txtdealsell_id";
            this.txtdealsell_id.Size = new System.Drawing.Size(123, 30);
            this.txtdealsell_id.TabIndex = 1;
            this.txtdealsell_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdealsell_id_KeyPress);
            // 
            // cmbproname
            // 
            this.cmbproname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbproname.FormattingEnabled = true;
            this.cmbproname.Location = new System.Drawing.Point(186, 76);
            this.cmbproname.Margin = new System.Windows.Forms.Padding(4);
            this.cmbproname.Name = "cmbproname";
            this.cmbproname.Size = new System.Drawing.Size(224, 33);
            this.cmbproname.TabIndex = 4;
            this.cmbproname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbproname_KeyPress);
            this.cmbproname.Leave += new System.EventHandler(this.cmbproname_Leave);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 454);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(633, 168);
            this.dataGridView1.TabIndex = 91;
            // 
            // btnsearch
            // 
            this.btnsearch.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.Location = new System.Drawing.Point(701, 397);
            this.btnsearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(132, 53);
            this.btnsearch.TabIndex = 84;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(875, 326);
            this.btndelete.Margin = new System.Windows.Forms.Padding(4);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(132, 53);
            this.btndelete.TabIndex = 82;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(858, 249);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(136, 53);
            this.btnupdate.TabIndex = 81;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(698, 326);
            this.btnclear.Margin = new System.Windows.Forms.Padding(4);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(131, 53);
            this.btnclear.TabIndex = 80;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(701, 249);
            this.btnsave.Margin = new System.Windows.Forms.Padding(4);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(128, 53);
            this.btnsave.TabIndex = 79;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(463, 137);
            this.lbltotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(61, 25);
            this.lbltotal.TabIndex = 90;
            this.lbltotal.Text = "Total";
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprice.Location = new System.Drawing.Point(61, 126);
            this.lblprice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(61, 25);
            this.lblprice.TabIndex = 89;
            this.lblprice.Text = "Price";
            // 
            // lblqty
            // 
            this.lblqty.AutoSize = true;
            this.lblqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblqty.Location = new System.Drawing.Point(251, 126);
            this.lblqty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblqty.Name = "lblqty";
            this.lblqty.Size = new System.Drawing.Size(93, 25);
            this.lblqty.TabIndex = 88;
            this.lblqty.Text = "Quantity";
            // 
            // lblproductid
            // 
            this.lblproductid.AutoSize = true;
            this.lblproductid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproductid.Location = new System.Drawing.Point(442, 76);
            this.lblproductid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblproductid.Name = "lblproductid";
            this.lblproductid.Size = new System.Drawing.Size(109, 25);
            this.lblproductid.TabIndex = 87;
            this.lblproductid.Text = "Product id";
            // 
            // lblDealsellid
            // 
            this.lblDealsellid.AutoSize = true;
            this.lblDealsellid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealsellid.Location = new System.Drawing.Point(442, 19);
            this.lblDealsellid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDealsellid.Name = "lblDealsellid";
            this.lblDealsellid.Size = new System.Drawing.Size(123, 25);
            this.lblDealsellid.TabIndex = 86;
            this.lblDealsellid.Text = "DealSell_Id";
            // 
            // lbldinfotable
            // 
            this.lbldinfotable.AutoSize = true;
            this.lbldinfotable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldinfotable.Location = new System.Drawing.Point(368, -40);
            this.lbldinfotable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldinfotable.Name = "lbldinfotable";
            this.lbldinfotable.Size = new System.Drawing.Size(273, 29);
            this.lbldinfotable.TabIndex = 85;
            this.lbldinfotable.Text = "Dealer Bill Information";
            // 
            // txtnetamt
            // 
            this.txtnetamt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnetamt.Location = new System.Drawing.Point(891, 576);
            this.txtnetamt.Margin = new System.Windows.Forms.Padding(4);
            this.txtnetamt.Name = "txtnetamt";
            this.txtnetamt.Size = new System.Drawing.Size(137, 30);
            this.txtnetamt.TabIndex = 109;
            this.txtnetamt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnetamt_KeyPress);
            // 
            // lblnetamt
            // 
            this.lblnetamt.AutoSize = true;
            this.lblnetamt.Font = new System.Drawing.Font("HP Simplified Hans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnetamt.Location = new System.Drawing.Point(705, 576);
            this.lblnetamt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnetamt.Name = "lblnetamt";
            this.lblnetamt.Size = new System.Drawing.Size(145, 27);
            this.lblnetamt.TabIndex = 108;
            this.lblnetamt.Text = "Net Amount";
            // 
            // DealerBillInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 638);
            this.Controls.Add(this.txtnetamt);
            this.Controls.Add(this.lblnetamt);
            this.Controls.Add(this.txtdeal_id);
            this.Controls.Add(this.lbldeal_id);
            this.Controls.Add(this.txtstock);
            this.Controls.Add(this.lbldisplaystock);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.cmbdealname);
            this.Controls.Add(this.lbldealname);
            this.Controls.Add(this.btnremoveitem);
            this.Controls.Add(this.btnadditem);
            this.Controls.Add(this.txtdiscount);
            this.Controls.Add(this.txtsubtotal);
            this.Controls.Add(this.lbldiscount);
            this.Controls.Add(this.lblsubtotal);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lblproname);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.txtqty);
            this.Controls.Add(this.txtproductid);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.txtdealsell_id);
            this.Controls.Add(this.cmbproname);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.lblprice);
            this.Controls.Add(this.lblqty);
            this.Controls.Add(this.lblproductid);
            this.Controls.Add(this.lblDealsellid);
            this.Controls.Add(this.lbldinfotable);
            this.Name = "DealerBillInfo";
            this.Text = "DealerBillInfo";
            this.Load += new System.EventHandler(this.DealerBillInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtdeal_id;
        private System.Windows.Forms.Label lbldeal_id;
        private System.Windows.Forms.TextBox txtstock;
        private System.Windows.Forms.Label lbldisplaystock;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.ComboBox cmbdealname;
        private System.Windows.Forms.Label lbldealname;
        private System.Windows.Forms.Button btnremoveitem;
        private System.Windows.Forms.Button btnadditem;
        private System.Windows.Forms.TextBox txtdiscount;
        private System.Windows.Forms.TextBox txtsubtotal;
        private System.Windows.Forms.Label lbldiscount;
        private System.Windows.Forms.Label lblsubtotal;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label lblproname;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.TextBox txtqty;
        private System.Windows.Forms.TextBox txtproductid;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.TextBox txtdealsell_id;
        private System.Windows.Forms.ComboBox cmbproname;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.Label lblqty;
        private System.Windows.Forms.Label lblproductid;
        private System.Windows.Forms.Label lblDealsellid;
        private System.Windows.Forms.Label lbldinfotable;
        private System.Windows.Forms.TextBox txtnetamt;
        private System.Windows.Forms.Label lblnetamt;
    }
}