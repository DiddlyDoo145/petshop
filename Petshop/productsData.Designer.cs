namespace Petshop
{
    partial class ProductsData
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.productname = new System.Windows.Forms.TextBox();
            this.product_price = new System.Windows.Forms.TextBox();
            this.product_stock = new System.Windows.Forms.TextBox();
            this.pCategory = new System.Windows.Forms.ComboBox();
            this.strCategory = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.AddCategory = new System.Windows.Forms.Button();
            this.ProductTable = new System.Windows.Forms.DataGridView();
            this.pCategory_ID = new System.Windows.Forms.Label();
            this.strCategory_ID = new System.Windows.Forms.Label();
            this.product_id = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProductTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            this.SuspendLayout();
            // 
            // productname
            // 
            this.productname.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productname.Location = new System.Drawing.Point(87, 71);
            this.productname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.productname.Multiline = true;
            this.productname.Name = "productname";
            this.productname.Size = new System.Drawing.Size(200, 30);
            this.productname.TabIndex = 0;
            // 
            // product_price
            // 
            this.product_price.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_price.Location = new System.Drawing.Point(577, 71);
            this.product_price.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.product_price.Multiline = true;
            this.product_price.Name = "product_price";
            this.product_price.Size = new System.Drawing.Size(207, 30);
            this.product_price.TabIndex = 1;
            this.product_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.product_price_KeyPress);
            // 
            // product_stock
            // 
            this.product_stock.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_stock.Location = new System.Drawing.Point(819, 71);
            this.product_stock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.product_stock.Multiline = true;
            this.product_stock.Name = "product_stock";
            this.product_stock.Size = new System.Drawing.Size(207, 30);
            this.product_stock.TabIndex = 2;
            this.product_stock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.product_stock_KeyPress);
            // 
            // pCategory
            // 
            this.pCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pCategory.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pCategory.FormattingEnabled = true;
            this.pCategory.Items.AddRange(new object[] {
            "SELECT CATEGORY"});
            this.pCategory.Location = new System.Drawing.Point(327, 71);
            this.pCategory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pCategory.Name = "pCategory";
            this.pCategory.Size = new System.Drawing.Size(191, 29);
            this.pCategory.TabIndex = 3;
            this.pCategory.SelectedIndexChanged += new System.EventHandler(this.pCategory_SelectedIndexChanged);
            // 
            // strCategory
            // 
            this.strCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.strCategory.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strCategory.FormattingEnabled = true;
            this.strCategory.Items.AddRange(new object[] {
            "SELECT CATEGORY"});
            this.strCategory.Location = new System.Drawing.Point(1060, 71);
            this.strCategory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.strCategory.Name = "strCategory";
            this.strCategory.Size = new System.Drawing.Size(225, 29);
            this.strCategory.TabIndex = 4;
            this.strCategory.SelectedIndexChanged += new System.EventHandler(this.strCategory_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Aqua;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(695, 150);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 37);
            this.button2.TabIndex = 14;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Edit
            // 
            this.Edit.BackColor = System.Drawing.Color.Aqua;
            this.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit.Location = new System.Drawing.Point(507, 150);
            this.Edit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(156, 37);
            this.Edit.TabIndex = 13;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = false;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // AddCategory
            // 
            this.AddCategory.BackColor = System.Drawing.Color.Aqua;
            this.AddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCategory.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCategory.Location = new System.Drawing.Point(327, 150);
            this.AddCategory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddCategory.Name = "AddCategory";
            this.AddCategory.Size = new System.Drawing.Size(156, 37);
            this.AddCategory.TabIndex = 12;
            this.AddCategory.Text = "Add";
            this.AddCategory.UseVisualStyleBackColor = false;
            this.AddCategory.Click += new System.EventHandler(this.AddCategory_Click);
            // 
            // ProductTable
            // 
            this.ProductTable.AllowUserToOrderColumns = true;
            this.ProductTable.AllowUserToResizeColumns = false;
            this.ProductTable.AllowUserToResizeRows = false;
            this.ProductTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductTable.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.ProductTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ProductTable.ColumnHeadersHeight = 30;
            this.ProductTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.ProductTable.Location = new System.Drawing.Point(92, 310);
            this.ProductTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProductTable.Name = "ProductTable";
            this.ProductTable.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ProductTable.RowHeadersVisible = false;
            this.ProductTable.RowHeadersWidth = 51;
            this.ProductTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ProductTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ProductTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductTable.Size = new System.Drawing.Size(1200, 281);
            this.ProductTable.TabIndex = 15;
            this.ProductTable.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ProductTable_MouseClick);
            // 
            // pCategory_ID
            // 
            this.pCategory_ID.AutoSize = true;
            this.pCategory_ID.Dock = System.Windows.Forms.DockStyle.Top;
            this.pCategory_ID.Location = new System.Drawing.Point(0, 0);
            this.pCategory_ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pCategory_ID.Name = "pCategory_ID";
            this.pCategory_ID.Size = new System.Drawing.Size(44, 16);
            this.pCategory_ID.TabIndex = 16;
            this.pCategory_ID.Text = "label1";
            this.pCategory_ID.Visible = false;
            // 
            // strCategory_ID
            // 
            this.strCategory_ID.AutoSize = true;
            this.strCategory_ID.Dock = System.Windows.Forms.DockStyle.Top;
            this.strCategory_ID.Location = new System.Drawing.Point(0, 16);
            this.strCategory_ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.strCategory_ID.Name = "strCategory_ID";
            this.strCategory_ID.Size = new System.Drawing.Size(44, 16);
            this.strCategory_ID.TabIndex = 17;
            this.strCategory_ID.Text = "label1";
            this.strCategory_ID.Visible = false;
            // 
            // product_id
            // 
            this.product_id.AutoSize = true;
            this.product_id.Dock = System.Windows.Forms.DockStyle.Top;
            this.product_id.Location = new System.Drawing.Point(0, 32);
            this.product_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.product_id.Name = "product_id";
            this.product_id.Size = new System.Drawing.Size(44, 16);
            this.product_id.TabIndex = 18;
            this.product_id.Text = "label1";
            this.product_id.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(84, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 21);
            this.label1.TabIndex = 19;
            this.label1.Text = "Product Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(323, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "Product Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(573, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 21);
            this.label3.TabIndex = 21;
            this.label3.Text = "Product Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(815, 47);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 21);
            this.label4.TabIndex = 22;
            this.label4.Text = "Product Stock";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(1056, 48);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 21);
            this.label5.TabIndex = 23;
            this.label5.Text = "Store Category";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Location = new System.Drawing.Point(97, 258);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(210, 37);
            this.label6.TabIndex = 24;
            this.label6.Text = "PRODUCT LIST";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // errorProvider5
            // 
            this.errorProvider5.ContainerControl = this;
            // 
            // Reset
            // 
            this.Reset.BackColor = System.Drawing.Color.Aqua;
            this.Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reset.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset.Location = new System.Drawing.Point(876, 150);
            this.Reset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(156, 37);
            this.Reset.TabIndex = 25;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = false;
            this.Reset.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProductsData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1365, 706);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.product_id);
            this.Controls.Add(this.strCategory_ID);
            this.Controls.Add(this.pCategory_ID);
            this.Controls.Add(this.ProductTable);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.AddCategory);
            this.Controls.Add(this.strCategory);
            this.Controls.Add(this.pCategory);
            this.Controls.Add(this.product_stock);
            this.Controls.Add(this.product_price);
            this.Controls.Add(this.productname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ProductsData";
            this.Text = "ProductsData";
            this.Load += new System.EventHandler(this.ProductsData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox productname;
        private System.Windows.Forms.TextBox product_price;
        private System.Windows.Forms.TextBox product_stock;
        private System.Windows.Forms.ComboBox pCategory;
        private System.Windows.Forms.ComboBox strCategory;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button AddCategory;
        private System.Windows.Forms.DataGridView ProductTable;
        private System.Windows.Forms.Label pCategory_ID;
        private System.Windows.Forms.Label strCategory_ID;
        private System.Windows.Forms.Label product_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.Button Reset;
    }
}