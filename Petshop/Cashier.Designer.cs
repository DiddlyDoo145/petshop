namespace Petshop
{
    partial class Cashier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cashier));
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.productCategory = new MaterialSkin.Controls.MaterialButton();
            this.services = new MaterialSkin.Controls.MaterialButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.ID = new System.Windows.Forms.Label();
            this.cashierName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cashierDgv = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cancelOrder = new MaterialSkin.Controls.MaterialButton();
            this.addOrder = new MaterialSkin.Controls.MaterialButton();
            this.productPanel = new MaterialSkin.Controls.MaterialCard();
            this.panel5 = new System.Windows.Forms.Panel();
            this.productQty = new System.Windows.Forms.TextBox();
            this.subQty = new System.Windows.Forms.Button();
            this.productPrice = new MaterialSkin.Controls.MaterialTextBox2();
            this.qtyCategory = new MaterialSkin.Controls.MaterialButton();
            this.addQty = new System.Windows.Forms.Button();
            this.productName = new MaterialSkin.Controls.MaterialTextBox2();
            this.label4 = new System.Windows.Forms.Label();
            this.servicePanel = new MaterialSkin.Controls.MaterialCard();
            this.panel6 = new System.Windows.Forms.Panel();
            this.fullGroom = new System.Windows.Forms.CheckBox();
            this.petSize = new System.Windows.Forms.ComboBox();
            this.petType = new MaterialSkin.Controls.MaterialTextBox2();
            this.servicePrice = new MaterialSkin.Controls.MaterialTextBox2();
            this.serviceName = new MaterialSkin.Controls.MaterialTextBox2();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.receiptDgv = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            this.panel3.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cashierDgv)).BeginInit();
            this.panel2.SuspendLayout();
            this.productPanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.servicePanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.receiptDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "product_name";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.HeaderText = "Product Name";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Quantity";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column2.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column2.HeaderText = "Quantity";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "pTransac_total";
            this.Column3.HeaderText = "Total";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "employee_fname";
            this.Column4.HeaderText = "Employee Name";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // productCategory
            // 
            this.productCategory.AutoSize = false;
            this.productCategory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.productCategory.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.productCategory.Depth = 0;
            this.productCategory.HighEmphasis = true;
            this.productCategory.Icon = null;
            this.productCategory.Location = new System.Drawing.Point(7, 5);
            this.productCategory.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.productCategory.MouseState = MaterialSkin.MouseState.HOVER;
            this.productCategory.Name = "productCategory";
            this.productCategory.NoAccentTextColor = System.Drawing.Color.Empty;
            this.productCategory.Size = new System.Drawing.Size(890, 66);
            this.productCategory.TabIndex = 6;
            this.productCategory.Text = "Products";
            this.productCategory.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.productCategory.UseAccentColor = false;
            this.productCategory.UseVisualStyleBackColor = true;
            this.productCategory.Click += new System.EventHandler(this.productCategory_Click);
            // 
            // services
            // 
            this.services.AutoSize = false;
            this.services.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.services.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.services.Depth = 0;
            this.services.HighEmphasis = true;
            this.services.Icon = null;
            this.services.Location = new System.Drawing.Point(908, 5);
            this.services.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.services.MouseState = MaterialSkin.MouseState.HOVER;
            this.services.Name = "services";
            this.services.NoAccentTextColor = System.Drawing.Color.Empty;
            this.services.Size = new System.Drawing.Size(890, 66);
            this.services.TabIndex = 9;
            this.services.Text = "Services";
            this.services.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.services.UseAccentColor = false;
            this.services.UseVisualStyleBackColor = true;
            this.services.Click += new System.EventHandler(this.services_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.services);
            this.panel3.Controls.Add(this.productCategory);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 87);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1802, 75);
            this.panel3.TabIndex = 7;
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.ID);
            this.materialCard2.Controls.Add(this.cashierName);
            this.materialCard2.Controls.Add(this.label1);
            this.materialCard2.Depth = 0;
            this.materialCard2.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(13, 14);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(13, 14, 13, 14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(13, 14, 13, 14);
            this.materialCard2.Size = new System.Drawing.Size(1776, 57);
            this.materialCard2.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(378, 14);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(186, 32);
            this.ID.TabIndex = 2;
            this.ID.Text = "Employee ID";
            // 
            // cashierName
            // 
            this.cashierName.AutoSize = true;
            this.cashierName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierName.Location = new System.Drawing.Point(146, 14);
            this.cashierName.Name = "cashierName";
            this.cashierName.Size = new System.Drawing.Size(119, 32);
            this.cashierName.TabIndex = 2;
            this.cashierName.Text = "Cashier";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cashier:";
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.materialCard2);
            this.materialCard1.Depth = 0;
            this.materialCard1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(0, 0);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(13, 14, 13, 14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(13, 14, 13, 14);
            this.materialCard1.Size = new System.Drawing.Size(1802, 87);
            this.materialCard1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cashierDgv);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 162);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(693, 776);
            this.panel1.TabIndex = 8;
            // 
            // cashierDgv
            // 
            this.cashierDgv.AllowUserToAddRows = false;
            this.cashierDgv.AllowUserToDeleteRows = false;
            this.cashierDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cashierDgv.ColumnHeadersHeight = 25;
            this.cashierDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.cashierDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cashierDgv.Location = new System.Drawing.Point(0, 0);
            this.cashierDgv.Name = "cashierDgv";
            this.cashierDgv.ReadOnly = true;
            this.cashierDgv.RowHeadersVisible = false;
            this.cashierDgv.RowHeadersWidth = 51;
            this.cashierDgv.RowTemplate.Height = 24;
            this.cashierDgv.Size = new System.Drawing.Size(693, 776);
            this.cashierDgv.TabIndex = 0;
            this.cashierDgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cashierDgv_CellClick);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cancelOrder);
            this.panel2.Controls.Add(this.addOrder);
            this.panel2.Controls.Add(this.productPanel);
            this.panel2.Controls.Add(this.servicePanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(693, 162);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(543, 776);
            this.panel2.TabIndex = 9;
            // 
            // cancelOrder
            // 
            this.cancelOrder.AutoSize = false;
            this.cancelOrder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cancelOrder.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.cancelOrder.Depth = 0;
            this.cancelOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelOrder.HighEmphasis = true;
            this.cancelOrder.Icon = null;
            this.cancelOrder.Location = new System.Drawing.Point(23, 554);
            this.cancelOrder.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cancelOrder.MouseState = MaterialSkin.MouseState.HOVER;
            this.cancelOrder.Name = "cancelOrder";
            this.cancelOrder.NoAccentTextColor = System.Drawing.Color.Empty;
            this.cancelOrder.Size = new System.Drawing.Size(238, 64);
            this.cancelOrder.TabIndex = 1;
            this.cancelOrder.Text = "Cancel Order";
            this.cancelOrder.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.cancelOrder.UseAccentColor = false;
            this.cancelOrder.UseVisualStyleBackColor = true;
            this.cancelOrder.Click += new System.EventHandler(this.cancelOrder_Click);
            // 
            // addOrder
            // 
            this.addOrder.AutoSize = false;
            this.addOrder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addOrder.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.addOrder.Depth = 0;
            this.addOrder.HighEmphasis = true;
            this.addOrder.Icon = null;
            this.addOrder.Location = new System.Drawing.Point(279, 554);
            this.addOrder.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addOrder.MouseState = MaterialSkin.MouseState.HOVER;
            this.addOrder.Name = "addOrder";
            this.addOrder.NoAccentTextColor = System.Drawing.Color.Empty;
            this.addOrder.Size = new System.Drawing.Size(238, 64);
            this.addOrder.TabIndex = 1;
            this.addOrder.Text = "Add Order";
            this.addOrder.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.addOrder.UseAccentColor = false;
            this.addOrder.UseVisualStyleBackColor = true;
            this.addOrder.Click += new System.EventHandler(this.addOrder_Click);
            // 
            // productPanel
            // 
            this.productPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.productPanel.Controls.Add(this.panel5);
            this.productPanel.Depth = 0;
            this.productPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.productPanel.Location = new System.Drawing.Point(23, 192);
            this.productPanel.Margin = new System.Windows.Forms.Padding(14);
            this.productPanel.MouseState = MaterialSkin.MouseState.HOVER;
            this.productPanel.Name = "productPanel";
            this.productPanel.Padding = new System.Windows.Forms.Padding(14);
            this.productPanel.Size = new System.Drawing.Size(494, 349);
            this.productPanel.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SteelBlue;
            this.panel5.Controls.Add(this.productQty);
            this.panel5.Controls.Add(this.subQty);
            this.panel5.Controls.Add(this.productPrice);
            this.panel5.Controls.Add(this.qtyCategory);
            this.panel5.Controls.Add(this.addQty);
            this.panel5.Controls.Add(this.productName);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(14, 14);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(466, 321);
            this.panel5.TabIndex = 0;
            // 
            // productQty
            // 
            this.productQty.Font = new System.Drawing.Font("Copperplate Gothic Bold", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productQty.Location = new System.Drawing.Point(182, 207);
            this.productQty.Multiline = true;
            this.productQty.Name = "productQty";
            this.productQty.Size = new System.Drawing.Size(102, 55);
            this.productQty.TabIndex = 4;
            this.productQty.Text = "00";
            this.productQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.productQty.TextChanged += new System.EventHandler(this.productQty_TextChanged);
            this.productQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.productQty_KeyPress);
            // 
            // subQty
            // 
            this.subQty.BackColor = System.Drawing.Color.CadetBlue;
            this.subQty.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("subQty.BackgroundImage")));
            this.subQty.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.subQty.Location = new System.Drawing.Point(76, 207);
            this.subQty.Name = "subQty";
            this.subQty.Size = new System.Drawing.Size(100, 55);
            this.subQty.TabIndex = 3;
            this.subQty.UseVisualStyleBackColor = false;
            this.subQty.Click += new System.EventHandler(this.subQty_Click);
            // 
            // productPrice
            // 
            this.productPrice.AnimateReadOnly = false;
            this.productPrice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.productPrice.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.productPrice.Depth = 0;
            this.productPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.productPrice.HideSelection = true;
            this.productPrice.Hint = "Product Price";
            this.productPrice.LeadingIcon = null;
            this.productPrice.Location = new System.Drawing.Point(76, 140);
            this.productPrice.MaxLength = 32767;
            this.productPrice.MouseState = MaterialSkin.MouseState.OUT;
            this.productPrice.Name = "productPrice";
            this.productPrice.PasswordChar = '\0';
            this.productPrice.PrefixSuffixText = null;
            this.productPrice.ReadOnly = false;
            this.productPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.productPrice.SelectedText = "";
            this.productPrice.SelectionLength = 0;
            this.productPrice.SelectionStart = 0;
            this.productPrice.ShortcutsEnabled = true;
            this.productPrice.Size = new System.Drawing.Size(314, 48);
            this.productPrice.TabIndex = 1;
            this.productPrice.TabStop = false;
            this.productPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.productPrice.TrailingIcon = null;
            this.productPrice.UseSystemPasswordChar = false;
            this.productPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.productPrice_KeyPress);
            // 
            // qtyCategory
            // 
            this.qtyCategory.AutoSize = false;
            this.qtyCategory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.qtyCategory.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.qtyCategory.Depth = 0;
            this.qtyCategory.HighEmphasis = true;
            this.qtyCategory.Icon = null;
            this.qtyCategory.Location = new System.Drawing.Point(356, 11);
            this.qtyCategory.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.qtyCategory.MouseState = MaterialSkin.MouseState.HOVER;
            this.qtyCategory.Name = "qtyCategory";
            this.qtyCategory.NoAccentTextColor = System.Drawing.Color.Empty;
            this.qtyCategory.Size = new System.Drawing.Size(97, 39);
            this.qtyCategory.TabIndex = 0;
            this.qtyCategory.Text = "Kilo";
            this.qtyCategory.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.qtyCategory.UseAccentColor = false;
            this.qtyCategory.UseVisualStyleBackColor = true;
            this.qtyCategory.Click += new System.EventHandler(this.qtyCategory_Click);
            // 
            // addQty
            // 
            this.addQty.BackColor = System.Drawing.Color.CadetBlue;
            this.addQty.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addQty.BackgroundImage")));
            this.addQty.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addQty.Location = new System.Drawing.Point(290, 207);
            this.addQty.Name = "addQty";
            this.addQty.Size = new System.Drawing.Size(100, 55);
            this.addQty.TabIndex = 3;
            this.addQty.UseVisualStyleBackColor = false;
            this.addQty.Click += new System.EventHandler(this.addQty_Click);
            // 
            // productName
            // 
            this.productName.AnimateReadOnly = false;
            this.productName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.productName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.productName.Depth = 0;
            this.productName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.productName.HideSelection = true;
            this.productName.Hint = "Product Name";
            this.productName.LeadingIcon = null;
            this.productName.Location = new System.Drawing.Point(76, 74);
            this.productName.MaxLength = 32767;
            this.productName.MouseState = MaterialSkin.MouseState.OUT;
            this.productName.Name = "productName";
            this.productName.PasswordChar = '\0';
            this.productName.PrefixSuffixText = null;
            this.productName.ReadOnly = false;
            this.productName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.productName.SelectedText = "";
            this.productName.SelectionLength = 0;
            this.productName.SelectionStart = 0;
            this.productName.ShortcutsEnabled = true;
            this.productName.Size = new System.Drawing.Size(314, 48);
            this.productName.TabIndex = 1;
            this.productName.TabStop = false;
            this.productName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.productName.TrailingIcon = null;
            this.productName.UseSystemPasswordChar = false;
            this.productName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.productName_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ebrima", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 38);
            this.label4.TabIndex = 2;
            this.label4.Text = "Avail Product ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // servicePanel
            // 
            this.servicePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.servicePanel.Controls.Add(this.panel6);
            this.servicePanel.Depth = 0;
            this.servicePanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.servicePanel.Location = new System.Drawing.Point(23, 192);
            this.servicePanel.Margin = new System.Windows.Forms.Padding(14);
            this.servicePanel.MouseState = MaterialSkin.MouseState.HOVER;
            this.servicePanel.Name = "servicePanel";
            this.servicePanel.Padding = new System.Windows.Forms.Padding(14);
            this.servicePanel.Size = new System.Drawing.Size(494, 349);
            this.servicePanel.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.SteelBlue;
            this.panel6.Controls.Add(this.fullGroom);
            this.panel6.Controls.Add(this.petSize);
            this.panel6.Controls.Add(this.petType);
            this.panel6.Controls.Add(this.servicePrice);
            this.panel6.Controls.Add(this.serviceName);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(14, 14);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(466, 321);
            this.panel6.TabIndex = 0;
            // 
            // fullGroom
            // 
            this.fullGroom.AutoSize = true;
            this.fullGroom.Font = new System.Drawing.Font("Copperplate Gothic Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullGroom.Location = new System.Drawing.Point(299, 20);
            this.fullGroom.Name = "fullGroom";
            this.fullGroom.Size = new System.Drawing.Size(149, 24);
            this.fullGroom.TabIndex = 5;
            this.fullGroom.Text = "Full Groom";
            this.fullGroom.UseVisualStyleBackColor = true;
            this.fullGroom.CheckedChanged += new System.EventHandler(this.fullGroom_CheckedChanged);
            // 
            // petSize
            // 
            this.petSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.petSize.Font = new System.Drawing.Font("Century", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.petSize.FormattingEnabled = true;
            this.petSize.Items.AddRange(new object[] {
            "Select Size",
            "Small ",
            "Medium",
            "Large",
            "Extra Large",
            "2XL"});
            this.petSize.Location = new System.Drawing.Point(232, 230);
            this.petSize.Name = "petSize";
            this.petSize.Size = new System.Drawing.Size(179, 35);
            this.petSize.TabIndex = 4;
            // 
            // petType
            // 
            this.petType.AnimateReadOnly = false;
            this.petType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.petType.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.petType.Depth = 0;
            this.petType.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.petType.HideSelection = true;
            this.petType.Hint = "Pet Type";
            this.petType.LeadingIcon = null;
            this.petType.Location = new System.Drawing.Point(53, 219);
            this.petType.MaxLength = 32767;
            this.petType.MouseState = MaterialSkin.MouseState.OUT;
            this.petType.Name = "petType";
            this.petType.PasswordChar = '\0';
            this.petType.PrefixSuffixText = null;
            this.petType.ReadOnly = false;
            this.petType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.petType.SelectedText = "";
            this.petType.SelectionLength = 0;
            this.petType.SelectionStart = 0;
            this.petType.ShortcutsEnabled = true;
            this.petType.Size = new System.Drawing.Size(154, 48);
            this.petType.TabIndex = 1;
            this.petType.TabStop = false;
            this.petType.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.petType.TrailingIcon = null;
            this.petType.UseSystemPasswordChar = false;
            this.petType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.petType_KeyPress);
            // 
            // servicePrice
            // 
            this.servicePrice.AnimateReadOnly = false;
            this.servicePrice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.servicePrice.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.servicePrice.Depth = 0;
            this.servicePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.servicePrice.HideSelection = true;
            this.servicePrice.Hint = "Service Price";
            this.servicePrice.LeadingIcon = null;
            this.servicePrice.Location = new System.Drawing.Point(53, 140);
            this.servicePrice.MaxLength = 32767;
            this.servicePrice.MouseState = MaterialSkin.MouseState.OUT;
            this.servicePrice.Name = "servicePrice";
            this.servicePrice.PasswordChar = '\0';
            this.servicePrice.PrefixSuffixText = null;
            this.servicePrice.ReadOnly = false;
            this.servicePrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.servicePrice.SelectedText = "";
            this.servicePrice.SelectionLength = 0;
            this.servicePrice.SelectionStart = 0;
            this.servicePrice.ShortcutsEnabled = true;
            this.servicePrice.Size = new System.Drawing.Size(358, 48);
            this.servicePrice.TabIndex = 1;
            this.servicePrice.TabStop = false;
            this.servicePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.servicePrice.TrailingIcon = null;
            this.servicePrice.UseSystemPasswordChar = false;
            this.servicePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.petType_KeyPress);
            // 
            // serviceName
            // 
            this.serviceName.AnimateReadOnly = false;
            this.serviceName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.serviceName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.serviceName.Depth = 0;
            this.serviceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.serviceName.HideSelection = true;
            this.serviceName.Hint = "Service Name";
            this.serviceName.LeadingIcon = null;
            this.serviceName.Location = new System.Drawing.Point(53, 74);
            this.serviceName.MaxLength = 32767;
            this.serviceName.MouseState = MaterialSkin.MouseState.OUT;
            this.serviceName.Name = "serviceName";
            this.serviceName.PasswordChar = '\0';
            this.serviceName.PrefixSuffixText = null;
            this.serviceName.ReadOnly = false;
            this.serviceName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.serviceName.SelectedText = "";
            this.serviceName.SelectionLength = 0;
            this.serviceName.SelectionStart = 0;
            this.serviceName.ShortcutsEnabled = true;
            this.serviceName.Size = new System.Drawing.Size(358, 48);
            this.serviceName.TabIndex = 1;
            this.serviceName.TabStop = false;
            this.serviceName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.serviceName.TrailingIcon = null;
            this.serviceName.UseSystemPasswordChar = false;
            this.serviceName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.petType_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ebrima", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 38);
            this.label5.TabIndex = 2;
            this.label5.Text = "Avail Service";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.materialButton1);
            this.panel4.Controls.Add(this.receiptDgv);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1236, 162);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(566, 776);
            this.panel4.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 728);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total:";
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(359, 716);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(190, 41);
            this.materialButton1.TabIndex = 1;
            this.materialButton1.Text = "Complete Order";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            // 
            // receiptDgv
            // 
            this.receiptDgv.AllowUserToAddRows = false;
            this.receiptDgv.AllowUserToDeleteRows = false;
            this.receiptDgv.AllowUserToResizeColumns = false;
            this.receiptDgv.AllowUserToResizeRows = false;
            this.receiptDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.receiptDgv.ColumnHeadersHeight = 45;
            this.receiptDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.receiptDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column9,
            this.Column7,
            this.Column8});
            this.receiptDgv.Dock = System.Windows.Forms.DockStyle.Top;
            this.receiptDgv.Location = new System.Drawing.Point(0, 0);
            this.receiptDgv.Name = "receiptDgv";
            this.receiptDgv.ReadOnly = true;
            this.receiptDgv.RowHeadersVisible = false;
            this.receiptDgv.RowHeadersWidth = 60;
            this.receiptDgv.RowTemplate.Height = 24;
            this.receiptDgv.Size = new System.Drawing.Size(564, 700);
            this.receiptDgv.TabIndex = 0;
            this.receiptDgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.receiptDgv_CellClick);
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Name";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Price";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Category";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Qty";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Sub Total";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(119, 728);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "00";
            // 
            // Cashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1802, 938);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.materialCard1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Cashier";
            this.Text = "Cashier";
            this.Load += new System.EventHandler(this.Cashier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            this.panel3.ResumeLayout(false);
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cashierDgv)).EndInit();
            this.panel2.ResumeLayout(false);
            this.productPanel.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.servicePanel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.receiptDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.Panel panel3;
        private MaterialSkin.Controls.MaterialButton services;
        private MaterialSkin.Controls.MaterialButton productCategory;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView cashierDgv;
        private MaterialSkin.Controls.MaterialCard productPanel;
        private System.Windows.Forms.DataGridView receiptDgv;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private MaterialSkin.Controls.MaterialButton qtyCategory;
        private MaterialSkin.Controls.MaterialTextBox2 productName;
        private MaterialSkin.Controls.MaterialTextBox2 productPrice;
        private System.Windows.Forms.Button subQty;
        private System.Windows.Forms.Button addQty;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialCard servicePanel;
        private System.Windows.Forms.Panel panel6;
        private MaterialSkin.Controls.MaterialTextBox2 servicePrice;
        private MaterialSkin.Controls.MaterialTextBox2 serviceName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox petSize;
        private System.Windows.Forms.TextBox productQty;
        private System.Windows.Forms.CheckBox fullGroom;
        private MaterialSkin.Controls.MaterialButton addOrder;
        private MaterialSkin.Controls.MaterialButton cancelOrder;
        public MaterialSkin.Controls.MaterialTextBox2 petType;
        public System.Windows.Forms.Label cashierName;
        public System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label label3;
    }
}