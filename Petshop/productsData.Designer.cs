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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsData));
            this.ProductTable = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pCategory_ID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.AddProduct = new System.Windows.Forms.Button();
            this.pCategory = new System.Windows.Forms.ComboBox();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.label3 = new System.Windows.Forms.Label();
            this.pPrice = new MaterialSkin.Controls.MaterialTextBox2();
            this.pStock = new MaterialSkin.Controls.MaterialTextBox2();
            this.label1 = new System.Windows.Forms.Label();
            this.pName = new MaterialSkin.Controls.MaterialTextBox2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProductTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            this.materialCard1.SuspendLayout();
            this.materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductTable
            // 
            this.ProductTable.AllowUserToAddRows = false;
            this.ProductTable.AllowUserToDeleteRows = false;
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
            this.ProductTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.ProductTable.Location = new System.Drawing.Point(26, 89);
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
            this.ProductTable.Size = new System.Drawing.Size(583, 480);
            this.ProductTable.TabIndex = 60;
            this.ProductTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductTable_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "product_name";
            this.Column1.HeaderText = "Product";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "pCategory_name";
            this.Column2.HeaderText = "Product Category";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "product_price";
            this.Column3.HeaderText = "Price";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "product_stock";
            this.Column4.HeaderText = "Stock";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "strCategory_desc";
            this.Column5.HeaderText = "Store Category";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // pCategory_ID
            // 
            this.pCategory_ID.AutoSize = true;
            this.pCategory_ID.Location = new System.Drawing.Point(10, 602);
            this.pCategory_ID.Name = "pCategory_ID";
            this.pCategory_ID.Size = new System.Drawing.Size(35, 13);
            this.pCategory_ID.TabIndex = 16;
            this.pCategory_ID.Text = "label1";
            this.pCategory_ID.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Location = new System.Drawing.Point(21, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 28);
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label7.Location = new System.Drawing.Point(190, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 16);
            this.label7.TabIndex = 29;
            this.label7.Text = "Search";
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(193, 50);
            this.search.Multiline = true;
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(416, 34);
            this.search.TabIndex = 28;
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(274, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 40;
            this.label2.Text = "Product Category";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SteelBlue;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(1109, 338);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 41);
            this.button2.TabIndex = 38;
            this.button2.Text = "DELETE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Edit
            // 
            this.Edit.BackColor = System.Drawing.Color.SteelBlue;
            this.Edit.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit.ForeColor = System.Drawing.Color.White;
            this.Edit.Location = new System.Drawing.Point(938, 338);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(165, 41);
            this.Edit.TabIndex = 37;
            this.Edit.Text = "UPDATE";
            this.Edit.UseVisualStyleBackColor = false;
            this.Edit.Click += new System.EventHandler(this.Edit_Click_1);
            // 
            // AddProduct
            // 
            this.AddProduct.BackColor = System.Drawing.Color.SteelBlue;
            this.AddProduct.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProduct.ForeColor = System.Drawing.Color.White;
            this.AddProduct.Location = new System.Drawing.Point(768, 338);
            this.AddProduct.Name = "AddProduct";
            this.AddProduct.Size = new System.Drawing.Size(165, 41);
            this.AddProduct.TabIndex = 36;
            this.AddProduct.Text = "ADD";
            this.AddProduct.UseVisualStyleBackColor = false;
            this.AddProduct.Click += new System.EventHandler(this.AddProduct_Click);
            // 
            // pCategory
            // 
            this.pCategory.DropDownHeight = 150;
            this.pCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pCategory.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pCategory.FormattingEnabled = true;
            this.pCategory.IntegralHeight = false;
            this.pCategory.Items.AddRange(new object[] {
            "SELECT CATEGORY"});
            this.pCategory.Location = new System.Drawing.Point(274, 184);
            this.pCategory.Name = "pCategory";
            this.pCategory.Size = new System.Drawing.Size(216, 30);
            this.pCategory.TabIndex = 34;
            this.pCategory.SelectedIndexChanged += new System.EventHandler(this.pCategory_SelectedIndexChanged_1);
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.linkLabel1);
            this.materialCard1.Controls.Add(this.materialCard2);
            this.materialCard1.Controls.Add(this.pPrice);
            this.materialCard1.Controls.Add(this.pStock);
            this.materialCard1.Controls.Add(this.label1);
            this.materialCard1.Controls.Add(this.label2);
            this.materialCard1.Controls.Add(this.pName);
            this.materialCard1.Controls.Add(this.pCategory);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(768, 81);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.materialCard1.Size = new System.Drawing.Size(506, 249);
            this.materialCard1.TabIndex = 61;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(421, 64);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(77, 19);
            this.linkLabel1.TabIndex = 63;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Click here";
            this.linkLabel1.Click += new System.EventHandler(this.Reset_Click);
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.label3);
            this.materialCard2.Depth = 0;
            this.materialCard2.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(10, 11);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.materialCard2.Size = new System.Drawing.Size(486, 41);
            this.materialCard2.TabIndex = 62;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 30);
            this.label3.TabIndex = 40;
            this.label3.Text = "Product Information";
            // 
            // pPrice
            // 
            this.pPrice.AnimateReadOnly = false;
            this.pPrice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pPrice.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.pPrice.Depth = 0;
            this.pPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.pPrice.HideSelection = true;
            this.pPrice.Hint = "Product Price";
            this.pPrice.LeadingIcon = null;
            this.pPrice.Location = new System.Drawing.Point(274, 95);
            this.pPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pPrice.MaxLength = 32767;
            this.pPrice.MouseState = MaterialSkin.MouseState.OUT;
            this.pPrice.Name = "pPrice";
            this.pPrice.PasswordChar = '\0';
            this.pPrice.PrefixSuffixText = null;
            this.pPrice.ReadOnly = false;
            this.pPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pPrice.SelectedText = "";
            this.pPrice.SelectionLength = 0;
            this.pPrice.SelectionStart = 0;
            this.pPrice.ShortcutsEnabled = true;
            this.pPrice.Size = new System.Drawing.Size(214, 48);
            this.pPrice.TabIndex = 62;
            this.pPrice.TabStop = false;
            this.pPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.pPrice.TrailingIcon = null;
            this.pPrice.UseSystemPasswordChar = false;
            // 
            // pStock
            // 
            this.pStock.AnimateReadOnly = false;
            this.pStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pStock.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.pStock.Depth = 0;
            this.pStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.pStock.HideSelection = true;
            this.pStock.Hint = "Product Stock";
            this.pStock.LeadingIcon = null;
            this.pStock.Location = new System.Drawing.Point(25, 180);
            this.pStock.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pStock.MaxLength = 32767;
            this.pStock.MouseState = MaterialSkin.MouseState.OUT;
            this.pStock.Name = "pStock";
            this.pStock.PasswordChar = '\0';
            this.pStock.PrefixSuffixText = null;
            this.pStock.ReadOnly = false;
            this.pStock.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pStock.SelectedText = "";
            this.pStock.SelectionLength = 0;
            this.pStock.SelectionStart = 0;
            this.pStock.ShortcutsEnabled = true;
            this.pStock.Size = new System.Drawing.Size(220, 48);
            this.pStock.TabIndex = 62;
            this.pStock.TabStop = false;
            this.pStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.pStock.TrailingIcon = null;
            this.pStock.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(316, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 40;
            this.label1.Text = "New Category";
            // 
            // pName
            // 
            this.pName.AnimateReadOnly = false;
            this.pName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.pName.Depth = 0;
            this.pName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.pName.HideSelection = true;
            this.pName.Hint = "Product Name";
            this.pName.LeadingIcon = null;
            this.pName.Location = new System.Drawing.Point(22, 95);
            this.pName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pName.MaxLength = 32767;
            this.pName.MouseState = MaterialSkin.MouseState.OUT;
            this.pName.Name = "pName";
            this.pName.PasswordChar = '\0';
            this.pName.PrefixSuffixText = null;
            this.pName.ReadOnly = false;
            this.pName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pName.SelectedText = "";
            this.pName.SelectionLength = 0;
            this.pName.SelectionStart = 0;
            this.pName.ShortcutsEnabled = true;
            this.pName.Size = new System.Drawing.Size(223, 48);
            this.pName.TabIndex = 62;
            this.pName.TabStop = false;
            this.pName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.pName.TrailingIcon = null;
            this.pName.UseSystemPasswordChar = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(470, -21);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(476, 466);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 62;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(987, 346);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(350, 313);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 62;
            this.pictureBox2.TabStop = false;
            // 
            // ProductsData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1297, 622);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.AddProduct);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pCategory_ID);
            this.Controls.Add(this.ProductTable);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductsData";
            this.Text = "ProductsData";
            this.Load += new System.EventHandler(this.ProductsData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView ProductTable;
        private System.Windows.Forms.Label pCategory_ID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button AddProduct;
        private System.Windows.Forms.ComboBox pCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialTextBox2 pStock;
        private MaterialSkin.Controls.MaterialTextBox2 pPrice;
        private MaterialSkin.Controls.MaterialTextBox2 pName;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}