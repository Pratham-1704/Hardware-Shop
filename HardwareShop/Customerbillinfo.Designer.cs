
namespace HardwareShop
{
    partial class Customerbillinfo
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
            this.txtstock = new System.Windows.Forms.TextBox();
            this.txtcust_id = new System.Windows.Forms.TextBox();
            this.lblcust_id = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbldate = new System.Windows.Forms.Label();
            this.cmbcustname = new System.Windows.Forms.ComboBox();
            this.lblcustname = new System.Windows.Forms.Label();
            this.lbldisplaystock = new System.Windows.Forms.Label();
            this.btnremove = new System.Windows.Forms.Button();
            this.btnadditem = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblproname = new System.Windows.Forms.Label();
            this.txtdiscount = new System.Windows.Forms.TextBox();
            this.txtsubtotal = new System.Windows.Forms.TextBox();
            this.lbldiscount = new System.Windows.Forms.Label();
            this.lblsubtotal = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.txtcustsell_id = new System.Windows.Forms.TextBox();
            this.txtproductid = new System.Windows.Forms.TextBox();
            this.cmbproname = new System.Windows.Forms.ComboBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.lbltotal = new System.Windows.Forms.Label();
            this.lblprice = new System.Windows.Forms.Label();
            this.lblqty = new System.Windows.Forms.Label();
            this.lblproductid = new System.Windows.Forms.Label();
            this.lblcustsell_id = new System.Windows.Forms.Label();
            this.lblc_billinfotable = new System.Windows.Forms.Label();
            this.txtnetamt = new System.Windows.Forms.TextBox();
            this.netamount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtstock
            // 
            this.txtstock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstock.Location = new System.Drawing.Point(175, 180);
            this.txtstock.Margin = new System.Windows.Forms.Padding(4);
            this.txtstock.Name = "txtstock";
            this.txtstock.Size = new System.Drawing.Size(119, 30);
            this.txtstock.TabIndex = 102;
            // 
            // txtcust_id
            // 
            this.txtcust_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcust_id.Location = new System.Drawing.Point(804, 52);
            this.txtcust_id.Margin = new System.Windows.Forms.Padding(4);
            this.txtcust_id.Name = "txtcust_id";
            this.txtcust_id.Size = new System.Drawing.Size(108, 30);
            this.txtcust_id.TabIndex = 3;
            this.txtcust_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcust_id_KeyPress);
            // 
            // lblcust_id
            // 
            this.lblcust_id.AutoSize = true;
            this.lblcust_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcust_id.Location = new System.Drawing.Point(701, 54);
            this.lblcust_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcust_id.Name = "lblcust_id";
            this.lblcust_id.Size = new System.Drawing.Size(81, 25);
            this.lblcust_id.TabIndex = 101;
            this.lblcust_id.Text = "cust_id";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM-dd-yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(801, -4);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(149, 29);
            this.dateTimePicker1.TabIndex = 99;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.Location = new System.Drawing.Point(701, 0);
            this.lbldate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(57, 25);
            this.lbldate.TabIndex = 98;
            this.lbldate.Text = "Date";
            // 
            // cmbcustname
            // 
            this.cmbcustname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcustname.FormattingEnabled = true;
            this.cmbcustname.Location = new System.Drawing.Point(163, -4);
            this.cmbcustname.Margin = new System.Windows.Forms.Padding(4);
            this.cmbcustname.Name = "cmbcustname";
            this.cmbcustname.Size = new System.Drawing.Size(224, 33);
            this.cmbcustname.TabIndex = 2;
            this.cmbcustname.SelectedIndexChanged += new System.EventHandler(this.cmbcustname_SelectedIndexChanged);
            this.cmbcustname.SelectedValueChanged += new System.EventHandler(this.cmbcustname_SelectedValueChanged);
            this.cmbcustname.Leave += new System.EventHandler(this.cmbcustname_Leave);
            // 
            // lblcustname
            // 
            this.lblcustname.AutoSize = true;
            this.lblcustname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcustname.Location = new System.Drawing.Point(4, 0);
            this.lblcustname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcustname.Name = "lblcustname";
            this.lblcustname.Size = new System.Drawing.Size(117, 25);
            this.lblcustname.TabIndex = 96;
            this.lblcustname.Text = "cust_name";
            // 
            // lbldisplaystock
            // 
            this.lbldisplaystock.AutoSize = true;
            this.lbldisplaystock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldisplaystock.Location = new System.Drawing.Point(27, 183);
            this.lbldisplaystock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldisplaystock.Name = "lbldisplaystock";
            this.lbldisplaystock.Size = new System.Drawing.Size(67, 25);
            this.lbldisplaystock.TabIndex = 95;
            this.lbldisplaystock.Text = "Stock";
            // 
            // btnremove
            // 
            this.btnremove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnremove.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremove.Location = new System.Drawing.Point(781, 138);
            this.btnremove.Margin = new System.Windows.Forms.Padding(4);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(164, 37);
            this.btnremove.TabIndex = 94;
            this.btnremove.Text = "Remove item";
            this.btnremove.UseVisualStyleBackColor = false;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // btnadditem
            // 
            this.btnadditem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnadditem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadditem.Location = new System.Drawing.Point(581, 138);
            this.btnadditem.Margin = new System.Windows.Forms.Padding(4);
            this.btnadditem.Name = "btnadditem";
            this.btnadditem.Size = new System.Drawing.Size(164, 37);
            this.btnadditem.TabIndex = 93;
            this.btnadditem.Text = "Add Item";
            this.btnadditem.UseVisualStyleBackColor = false;
            this.btnadditem.Click += new System.EventHandler(this.btnadditem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 441);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(653, 176);
            this.dataGridView1.TabIndex = 92;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblproname
            // 
            this.lblproname.AutoSize = true;
            this.lblproname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproname.Location = new System.Drawing.Point(-7, 60);
            this.lblproname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblproname.Name = "lblproname";
            this.lblproname.Size = new System.Drawing.Size(149, 24);
            this.lblproname.TabIndex = 91;
            this.lblproname.Text = "Product Name ";
            // 
            // txtdiscount
            // 
            this.txtdiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiscount.Location = new System.Drawing.Point(897, 514);
            this.txtdiscount.Margin = new System.Windows.Forms.Padding(4);
            this.txtdiscount.Name = "txtdiscount";
            this.txtdiscount.Size = new System.Drawing.Size(119, 30);
            this.txtdiscount.TabIndex = 90;
            this.txtdiscount.TextChanged += new System.EventHandler(this.txtdiscount_TextChanged);
            this.txtdiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdiscount_KeyPress);
            // 
            // txtsubtotal
            // 
            this.txtsubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsubtotal.Location = new System.Drawing.Point(897, 448);
            this.txtsubtotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtsubtotal.Name = "txtsubtotal";
            this.txtsubtotal.Size = new System.Drawing.Size(119, 30);
            this.txtsubtotal.TabIndex = 89;
            this.txtsubtotal.Text = "0";
            this.txtsubtotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsubtotal_KeyPress);
            // 
            // lbldiscount
            // 
            this.lbldiscount.AutoSize = true;
            this.lbldiscount.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldiscount.Location = new System.Drawing.Point(716, 514);
            this.lbldiscount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldiscount.Name = "lbldiscount";
            this.lbldiscount.Size = new System.Drawing.Size(106, 25);
            this.lbldiscount.TabIndex = 88;
            this.lbldiscount.Text = "Discount";
            // 
            // lblsubtotal
            // 
            this.lblsubtotal.AutoSize = true;
            this.lblsubtotal.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsubtotal.Location = new System.Drawing.Point(716, 457);
            this.lblsubtotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsubtotal.Name = "lblsubtotal";
            this.lblsubtotal.Size = new System.Drawing.Size(107, 25);
            this.lblsubtotal.TabIndex = 87;
            this.lblsubtotal.Text = "Sub total";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(13, 212);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(671, 221);
            this.listView1.TabIndex = 86;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Product Name";
            this.columnHeader1.Width = 200;
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
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.Location = new System.Drawing.Point(896, 375);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(103, 30);
            this.txtsearch.TabIndex = 78;
            // 
            // txttotal
            // 
            this.txttotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotal.Location = new System.Drawing.Point(355, 143);
            this.txttotal.Margin = new System.Windows.Forms.Padding(4);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(152, 30);
            this.txttotal.TabIndex = 8;
            this.txttotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttotal_KeyPress);
            // 
            // txtprice
            // 
            this.txtprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprice.Location = new System.Drawing.Point(9, 143);
            this.txtprice.Margin = new System.Windows.Forms.Padding(4);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(119, 30);
            this.txtprice.TabIndex = 6;
            this.txtprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprice_KeyPress);
            // 
            // txtqty
            // 
            this.txtqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqty.Location = new System.Drawing.Point(175, 140);
            this.txtqty.Margin = new System.Windows.Forms.Padding(4);
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(135, 30);
            this.txtqty.TabIndex = 7;
            this.txtqty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtqty_KeyPress);
            this.txtqty.Leave += new System.EventHandler(this.txtqty_Leave);
            // 
            // txtcustsell_id
            // 
            this.txtcustsell_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcustsell_id.Location = new System.Drawing.Point(548, -4);
            this.txtcustsell_id.Margin = new System.Windows.Forms.Padding(4);
            this.txtcustsell_id.Name = "txtcustsell_id";
            this.txtcustsell_id.Size = new System.Drawing.Size(108, 30);
            this.txtcustsell_id.TabIndex = 1;
            this.txtcustsell_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcustsell_id_KeyPress);
            // 
            // txtproductid
            // 
            this.txtproductid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtproductid.Location = new System.Drawing.Point(548, 54);
            this.txtproductid.Margin = new System.Windows.Forms.Padding(4);
            this.txtproductid.Name = "txtproductid";
            this.txtproductid.Size = new System.Drawing.Size(115, 30);
            this.txtproductid.TabIndex = 5;
            this.txtproductid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtproductid_KeyPress);
            // 
            // cmbproname
            // 
            this.cmbproname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbproname.FormattingEnabled = true;
            this.cmbproname.Location = new System.Drawing.Point(163, 58);
            this.cmbproname.Margin = new System.Windows.Forms.Padding(4);
            this.cmbproname.Name = "cmbproname";
            this.cmbproname.Size = new System.Drawing.Size(224, 33);
            this.cmbproname.TabIndex = 4;
            this.cmbproname.SelectedIndexChanged += new System.EventHandler(this.cmbproname_SelectedIndexChanged);
            this.cmbproname.SelectedValueChanged += new System.EventHandler(this.cmbproname_SelectedValueChanged);
            this.cmbproname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbproname_KeyPress);
            this.cmbproname.Leave += new System.EventHandler(this.cmbproname_Leave);
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnsearch.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.Location = new System.Drawing.Point(711, 370);
            this.btnsearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(139, 39);
            this.btnsearch.TabIndex = 79;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btndelete.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(896, 297);
            this.btndelete.Margin = new System.Windows.Forms.Padding(4);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(121, 42);
            this.btndelete.TabIndex = 77;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnupdate.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(888, 212);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(129, 43);
            this.btnupdate.TabIndex = 76;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnclear.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(711, 297);
            this.btnclear.Margin = new System.Windows.Forms.Padding(4);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(120, 42);
            this.btnclear.TabIndex = 75;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnsave.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(707, 212);
            this.btnsave.Margin = new System.Windows.Forms.Padding(4);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(124, 43);
            this.btnsave.TabIndex = 74;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(400, 110);
            this.lbltotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(61, 25);
            this.lbltotal.TabIndex = 85;
            this.lbltotal.Text = "Total";
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprice.Location = new System.Drawing.Point(27, 110);
            this.lblprice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(61, 25);
            this.lblprice.TabIndex = 84;
            this.lblprice.Text = "Price";
            // 
            // lblqty
            // 
            this.lblqty.AutoSize = true;
            this.lblqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblqty.Location = new System.Drawing.Point(181, 110);
            this.lblqty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblqty.Name = "lblqty";
            this.lblqty.Size = new System.Drawing.Size(93, 25);
            this.lblqty.TabIndex = 83;
            this.lblqty.Text = "Quantity";
            // 
            // lblproductid
            // 
            this.lblproductid.AutoSize = true;
            this.lblproductid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproductid.Location = new System.Drawing.Point(400, 58);
            this.lblproductid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblproductid.Name = "lblproductid";
            this.lblproductid.Size = new System.Drawing.Size(110, 25);
            this.lblproductid.TabIndex = 82;
            this.lblproductid.Text = "Product Id";
            // 
            // lblcustsell_id
            // 
            this.lblcustsell_id.AutoSize = true;
            this.lblcustsell_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcustsell_id.Location = new System.Drawing.Point(400, 0);
            this.lblcustsell_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcustsell_id.Name = "lblcustsell_id";
            this.lblcustsell_id.Size = new System.Drawing.Size(123, 25);
            this.lblcustsell_id.TabIndex = 81;
            this.lblcustsell_id.Text = "CustSell_id";
            // 
            // lblc_billinfotable
            // 
            this.lblc_billinfotable.AutoSize = true;
            this.lblc_billinfotable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblc_billinfotable.Location = new System.Drawing.Point(321, -53);
            this.lblc_billinfotable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblc_billinfotable.Name = "lblc_billinfotable";
            this.lblc_billinfotable.Size = new System.Drawing.Size(307, 29);
            this.lblc_billinfotable.TabIndex = 80;
            this.lblc_billinfotable.Text = "Customer Bill Information";
            // 
            // txtnetamt
            // 
            this.txtnetamt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnetamt.Location = new System.Drawing.Point(897, 566);
            this.txtnetamt.Margin = new System.Windows.Forms.Padding(4);
            this.txtnetamt.Name = "txtnetamt";
            this.txtnetamt.Size = new System.Drawing.Size(119, 30);
            this.txtnetamt.TabIndex = 104;
            // 
            // netamount
            // 
            this.netamount.AutoSize = true;
            this.netamount.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.netamount.Location = new System.Drawing.Point(729, 566);
            this.netamount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.netamount.Name = "netamount";
            this.netamount.Size = new System.Drawing.Size(138, 25);
            this.netamount.TabIndex = 103;
            this.netamount.Text = "Net Amount";
            // 
            // Customerbillinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 667);
            this.Controls.Add(this.txtnetamt);
            this.Controls.Add(this.netamount);
            this.Controls.Add(this.txtstock);
            this.Controls.Add(this.txtcust_id);
            this.Controls.Add(this.lblcust_id);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.cmbcustname);
            this.Controls.Add(this.lblcustname);
            this.Controls.Add(this.lbldisplaystock);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.btnadditem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblproname);
            this.Controls.Add(this.txtdiscount);
            this.Controls.Add(this.txtsubtotal);
            this.Controls.Add(this.lbldiscount);
            this.Controls.Add(this.lblsubtotal);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.txtqty);
            this.Controls.Add(this.txtcustsell_id);
            this.Controls.Add(this.txtproductid);
            this.Controls.Add(this.cmbproname);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.lblprice);
            this.Controls.Add(this.lblqty);
            this.Controls.Add(this.lblproductid);
            this.Controls.Add(this.lblcustsell_id);
            this.Controls.Add(this.lblc_billinfotable);
            this.Name = "Customerbillinfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customerbillinfo";
            this.Load += new System.EventHandler(this.Customerbillinfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtstock;
        private System.Windows.Forms.TextBox txtcust_id;
        private System.Windows.Forms.Label lblcust_id;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.ComboBox cmbcustname;
        private System.Windows.Forms.Label lblcustname;
        private System.Windows.Forms.Label lbldisplaystock;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.Button btnadditem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblproname;
        private System.Windows.Forms.TextBox txtdiscount;
        private System.Windows.Forms.TextBox txtsubtotal;
        private System.Windows.Forms.Label lbldiscount;
        private System.Windows.Forms.Label lblsubtotal;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.TextBox txtqty;
        private System.Windows.Forms.TextBox txtcustsell_id;
        private System.Windows.Forms.TextBox txtproductid;
        private System.Windows.Forms.ComboBox cmbproname;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.Label lblqty;
        private System.Windows.Forms.Label lblproductid;
        private System.Windows.Forms.Label lblcustsell_id;
        private System.Windows.Forms.Label lblc_billinfotable;
        private System.Windows.Forms.TextBox txtnetamt;
        private System.Windows.Forms.Label netamount;
    }
}