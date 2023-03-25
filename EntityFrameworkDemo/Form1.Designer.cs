namespace EntityFrameworkDemo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRemove = new System.Windows.Forms.Button();
            this.gbxUpdate = new System.Windows.Forms.GroupBox();
            this.btnupdate = new System.Windows.Forms.Button();
            this.lblstockAmountUpdate = new System.Windows.Forms.Label();
            this.tbxunitPriceUpdate = new System.Windows.Forms.TextBox();
            this.lblunitPriceUpdate = new System.Windows.Forms.Label();
            this.tbxnameUpdate = new System.Windows.Forms.TextBox();
            this.lblnameUpdate = new System.Windows.Forms.Label();
            this.tbxstockAmountUpdate = new System.Windows.Forms.TextBox();
            this.gbx = new System.Windows.Forms.GroupBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.lblstockAmount = new System.Windows.Forms.Label();
            this.tbxunitPrice = new System.Windows.Forms.TextBox();
            this.lvlunitPrice = new System.Windows.Forms.Label();
            this.tbxname = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.tbxstockAmount = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblSearch = new System.Windows.Forms.Label();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.btnGetbyId = new System.Windows.Forms.Button();
            this.gbxUpdate.SuspendLayout();
            this.gbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(56, 26);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(100, 23);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // gbxUpdate
            // 
            this.gbxUpdate.Controls.Add(this.btnupdate);
            this.gbxUpdate.Controls.Add(this.lblstockAmountUpdate);
            this.gbxUpdate.Controls.Add(this.tbxunitPriceUpdate);
            this.gbxUpdate.Controls.Add(this.lblunitPriceUpdate);
            this.gbxUpdate.Controls.Add(this.tbxnameUpdate);
            this.gbxUpdate.Controls.Add(this.lblnameUpdate);
            this.gbxUpdate.Controls.Add(this.tbxstockAmountUpdate);
            this.gbxUpdate.Location = new System.Drawing.Point(398, 221);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Size = new System.Drawing.Size(319, 170);
            this.gbxUpdate.TabIndex = 6;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "Update for product";
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(119, 141);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(100, 23);
            this.btnupdate.TabIndex = 8;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // lblstockAmountUpdate
            // 
            this.lblstockAmountUpdate.AutoSize = true;
            this.lblstockAmountUpdate.Location = new System.Drawing.Point(11, 106);
            this.lblstockAmountUpdate.Name = "lblstockAmountUpdate";
            this.lblstockAmountUpdate.Size = new System.Drawing.Size(83, 15);
            this.lblstockAmountUpdate.TabIndex = 7;
            this.lblstockAmountUpdate.Text = "Stock Amount";
            // 
            // tbxunitPriceUpdate
            // 
            this.tbxunitPriceUpdate.Location = new System.Drawing.Point(119, 64);
            this.tbxunitPriceUpdate.Name = "tbxunitPriceUpdate";
            this.tbxunitPriceUpdate.Size = new System.Drawing.Size(100, 23);
            this.tbxunitPriceUpdate.TabIndex = 3;
            // 
            // lblunitPriceUpdate
            // 
            this.lblunitPriceUpdate.AutoSize = true;
            this.lblunitPriceUpdate.Location = new System.Drawing.Point(11, 67);
            this.lblunitPriceUpdate.Name = "lblunitPriceUpdate";
            this.lblunitPriceUpdate.Size = new System.Drawing.Size(58, 15);
            this.lblunitPriceUpdate.TabIndex = 6;
            this.lblunitPriceUpdate.Text = "Unit Price";
            // 
            // tbxnameUpdate
            // 
            this.tbxnameUpdate.Location = new System.Drawing.Point(119, 29);
            this.tbxnameUpdate.Name = "tbxnameUpdate";
            this.tbxnameUpdate.Size = new System.Drawing.Size(100, 23);
            this.tbxnameUpdate.TabIndex = 2;
            // 
            // lblnameUpdate
            // 
            this.lblnameUpdate.AutoSize = true;
            this.lblnameUpdate.Location = new System.Drawing.Point(11, 29);
            this.lblnameUpdate.Name = "lblnameUpdate";
            this.lblnameUpdate.Size = new System.Drawing.Size(39, 15);
            this.lblnameUpdate.TabIndex = 5;
            this.lblnameUpdate.Text = "Name";
            // 
            // tbxstockAmountUpdate
            // 
            this.tbxstockAmountUpdate.Location = new System.Drawing.Point(119, 98);
            this.tbxstockAmountUpdate.Name = "tbxstockAmountUpdate";
            this.tbxstockAmountUpdate.Size = new System.Drawing.Size(100, 23);
            this.tbxstockAmountUpdate.TabIndex = 4;
            // 
            // gbx
            // 
            this.gbx.Controls.Add(this.btnadd);
            this.gbx.Controls.Add(this.lblstockAmount);
            this.gbx.Controls.Add(this.tbxunitPrice);
            this.gbx.Controls.Add(this.lvlunitPrice);
            this.gbx.Controls.Add(this.tbxname);
            this.gbx.Controls.Add(this.lblname);
            this.gbx.Controls.Add(this.tbxstockAmount);
            this.gbx.Location = new System.Drawing.Point(45, 221);
            this.gbx.Name = "gbx";
            this.gbx.Size = new System.Drawing.Size(319, 170);
            this.gbx.TabIndex = 5;
            this.gbx.TabStop = false;
            this.gbx.Text = "Add a product";
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(119, 141);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(100, 23);
            this.btnadd.TabIndex = 8;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // lblstockAmount
            // 
            this.lblstockAmount.AutoSize = true;
            this.lblstockAmount.Location = new System.Drawing.Point(11, 106);
            this.lblstockAmount.Name = "lblstockAmount";
            this.lblstockAmount.Size = new System.Drawing.Size(83, 15);
            this.lblstockAmount.TabIndex = 7;
            this.lblstockAmount.Text = "Stock Amount";
            // 
            // tbxunitPrice
            // 
            this.tbxunitPrice.Location = new System.Drawing.Point(119, 64);
            this.tbxunitPrice.Name = "tbxunitPrice";
            this.tbxunitPrice.Size = new System.Drawing.Size(100, 23);
            this.tbxunitPrice.TabIndex = 3;
            // 
            // lvlunitPrice
            // 
            this.lvlunitPrice.AutoSize = true;
            this.lvlunitPrice.Location = new System.Drawing.Point(11, 67);
            this.lvlunitPrice.Name = "lvlunitPrice";
            this.lvlunitPrice.Size = new System.Drawing.Size(58, 15);
            this.lvlunitPrice.TabIndex = 6;
            this.lvlunitPrice.Text = "Unit Price";
            // 
            // tbxname
            // 
            this.tbxname.Location = new System.Drawing.Point(119, 29);
            this.tbxname.Name = "tbxname";
            this.tbxname.Size = new System.Drawing.Size(100, 23);
            this.tbxname.TabIndex = 2;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(11, 29);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(39, 15);
            this.lblname.TabIndex = 5;
            this.lblname.Text = "Name";
            // 
            // tbxstockAmount
            // 
            this.tbxstockAmount.Location = new System.Drawing.Point(119, 98);
            this.tbxstockAmount.Name = "tbxstockAmount";
            this.tbxstockAmount.Size = new System.Drawing.Size(100, 23);
            this.tbxstockAmount.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(45, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(680, 150);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(476, 30);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(42, 15);
            this.lblSearch.TabIndex = 8;
            this.lblSearch.Text = "Search";
            this.lblSearch.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(540, 27);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(100, 23);
            this.tbxSearch.TabIndex = 9;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // btnGetbyId
            // 
            this.btnGetbyId.Location = new System.Drawing.Point(201, 26);
            this.btnGetbyId.Name = "btnGetbyId";
            this.btnGetbyId.Size = new System.Drawing.Size(100, 23);
            this.btnGetbyId.TabIndex = 10;
            this.btnGetbyId.Text = "Get by Id";
            this.btnGetbyId.UseVisualStyleBackColor = true;
            this.btnGetbyId.Click += new System.EventHandler(this.btnGetbyId_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGetbyId);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.gbxUpdate);
            this.Controls.Add(this.gbx);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxUpdate.ResumeLayout(false);
            this.gbxUpdate.PerformLayout();
            this.gbx.ResumeLayout(false);
            this.gbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnRemove;
        private GroupBox gbxUpdate;
        private Button btnupdate;
        private Label lblstockAmountUpdate;
        private TextBox tbxunitPriceUpdate;
        private Label lblunitPriceUpdate;
        private TextBox tbxnameUpdate;
        private Label lblnameUpdate;
        private TextBox tbxstockAmountUpdate;
        private GroupBox gbx;
        private Button btnadd;
        private Label lblstockAmount;
        private TextBox tbxunitPrice;
        private Label lvlunitPrice;
        private TextBox tbxname;
        private Label lblname;
        private TextBox tbxstockAmount;
        private DataGridView dataGridView1;
        private Button btnSearch;
        private Label lblSearch;
        private TextBox tbxSearch;
        private Button btnGetbyId;
    }
}