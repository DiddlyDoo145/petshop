namespace Petshop
{
    partial class ProductTransac
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.materialListBox1 = new MaterialSkin.Controls.MaterialListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.AddProduct = new System.Windows.Forms.Button();
            this.employee_Name = new System.Windows.Forms.ComboBox();
            this.productName = new System.Windows.Forms.ComboBox();
            this.TransacTotal = new System.Windows.Forms.TextBox();
            this.product_ID = new System.Windows.Forms.Label();
            this.employee_ID = new System.Windows.Forms.Label();
            this.TransacTable = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productStock = new System.Windows.Forms.Label();
            this.qty = new System.Windows.Forms.TextBox();
            this.productPrice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TransacTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            this.SuspendLayout();
            // 
            // materialListBox1
            // 
            this.materialListBox1.BackColor = System.Drawing.Color.White;
            this.materialListBox1.BorderColor = System.Drawing.Color.LightGray;
            this.materialListBox1.Depth = 0;
            this.materialListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialListBox1.Location = new System.Drawing.Point(129, 25);
            this.materialListBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialListBox1.Name = "materialListBox1";
            this.materialListBox1.SelectedIndex = -1;
            this.materialListBox1.SelectedItem = null;
            this.materialListBox1.Size = new System.Drawing.Size(747, 154);
            this.materialListBox1.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(681, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 17);
            this.label5.TabIndex = 57;
            this.label5.Text = "Employee Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(498, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 55;
            this.label3.Text = "Transaction Total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(146, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 54;
            this.label2.Text = "Product Name";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Aqua;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(521, 121);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 30);
            this.button2.TabIndex = 52;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Edit
            // 
            this.Edit.BackColor = System.Drawing.Color.Aqua;
            this.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit.Location = new System.Drawing.Point(380, 121);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(117, 30);
            this.Edit.TabIndex = 51;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = false;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // AddProduct
            // 
            this.AddProduct.BackColor = System.Drawing.Color.Aqua;
            this.AddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddProduct.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProduct.Location = new System.Drawing.Point(245, 121);
            this.AddProduct.Name = "AddProduct";
            this.AddProduct.Size = new System.Drawing.Size(117, 30);
            this.AddProduct.TabIndex = 50;
            this.AddProduct.Text = "Add";
            this.AddProduct.UseVisualStyleBackColor = false;
            this.AddProduct.Click += new System.EventHandler(this.AddProduct_Click);
            // 
            // employee_Name
            // 
            this.employee_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.employee_Name.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee_Name.FormattingEnabled = true;
            this.employee_Name.Items.AddRange(new object[] {
            "SELECT CATEGORY"});
            this.employee_Name.Location = new System.Drawing.Point(684, 64);
            this.employee_Name.Name = "employee_Name";
            this.employee_Name.Size = new System.Drawing.Size(170, 25);
            this.employee_Name.TabIndex = 49;
            this.employee_Name.SelectedIndexChanged += new System.EventHandler(this.employee_Name_SelectedIndexChanged);
            // 
            // productName
            // 
            this.productName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productName.FormattingEnabled = true;
            this.productName.Items.AddRange(new object[] {
            "SELECT CATEGORY"});
            this.productName.Location = new System.Drawing.Point(149, 64);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(144, 25);
            this.productName.TabIndex = 48;
            this.productName.SelectedIndexChanged += new System.EventHandler(this.productName_SelectedIndexChanged);
            // 
            // TransacTotal
            // 
            this.TransacTotal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransacTotal.Location = new System.Drawing.Point(501, 64);
            this.TransacTotal.Multiline = true;
            this.TransacTotal.Name = "TransacTotal";
            this.TransacTotal.Size = new System.Drawing.Size(156, 25);
            this.TransacTotal.TabIndex = 46;
            // 
            // product_ID
            // 
            this.product_ID.AutoSize = true;
            this.product_ID.Dock = System.Windows.Forms.DockStyle.Left;
            this.product_ID.Location = new System.Drawing.Point(0, 0);
            this.product_ID.Name = "product_ID";
            this.product_ID.Size = new System.Drawing.Size(35, 13);
            this.product_ID.TabIndex = 58;
            this.product_ID.Text = "label1";
            this.product_ID.Visible = false;
            // 
            // employee_ID
            // 
            this.employee_ID.AutoSize = true;
            this.employee_ID.Dock = System.Windows.Forms.DockStyle.Left;
            this.employee_ID.Location = new System.Drawing.Point(35, 0);
            this.employee_ID.Name = "employee_ID";
            this.employee_ID.Size = new System.Drawing.Size(35, 13);
            this.employee_ID.TabIndex = 59;
            this.employee_ID.Text = "label1";
            this.employee_ID.Visible = false;
            // 
            // TransacTable
            // 
            this.TransacTable.AllowUserToAddRows = false;
            this.TransacTable.AllowUserToDeleteRows = false;
            this.TransacTable.AllowUserToResizeColumns = false;
            this.TransacTable.AllowUserToResizeRows = false;
            this.TransacTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TransacTable.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.TransacTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TransacTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TransacTable.ColumnHeadersHeight = 30;
            this.TransacTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.TransacTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TransacTable.DefaultCellStyle = dataGridViewCellStyle4;
            this.TransacTable.Location = new System.Drawing.Point(128, 239);
            this.TransacTable.Name = "TransacTable";
            this.TransacTable.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TransacTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.TransacTable.RowHeadersVisible = false;
            this.TransacTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.TransacTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TransacTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TransacTable.Size = new System.Drawing.Size(748, 228);
            this.TransacTable.TabIndex = 60;
            this.TransacTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TransacTable_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "product_name";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.HeaderText = "Product Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Quantity";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column2.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column2.HeaderText = "Quantity";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "pTransac_total";
            this.Column3.HeaderText = "Total";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "employee_fname";
            this.Column4.HeaderText = "Employee Name";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // productStock
            // 
            this.productStock.AutoSize = true;
            this.productStock.Location = new System.Drawing.Point(5, 93);
            this.productStock.Name = "productStock";
            this.productStock.Size = new System.Drawing.Size(35, 13);
            this.productStock.TabIndex = 61;
            this.productStock.Text = "label1";
            this.productStock.Visible = false;
            // 
            // qty
            // 
            this.qty.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qty.Location = new System.Drawing.Point(317, 64);
            this.qty.Multiline = true;
            this.qty.Name = "qty";
            this.qty.Size = new System.Drawing.Size(156, 25);
            this.qty.TabIndex = 62;
            this.qty.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // productPrice
            // 
            this.productPrice.AutoSize = true;
            this.productPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.productPrice.Location = new System.Drawing.Point(70, 0);
            this.productPrice.Name = "productPrice";
            this.productPrice.Size = new System.Drawing.Size(35, 13);
            this.productPrice.TabIndex = 63;
            this.productPrice.Text = "label1";
            this.productPrice.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(314, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 64;
            this.label1.Text = "Quantity";
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
            // ProductTransac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(992, 496);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productPrice);
            this.Controls.Add(this.qty);
            this.Controls.Add(this.productStock);
            this.Controls.Add(this.TransacTable);
            this.Controls.Add(this.employee_ID);
            this.Controls.Add(this.product_ID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.AddProduct);
            this.Controls.Add(this.employee_Name);
            this.Controls.Add(this.productName);
            this.Controls.Add(this.TransacTotal);
            this.Controls.Add(this.materialListBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductTransac";
            this.Text = "ProductTransac";
            this.Load += new System.EventHandler(this.ProductTransac_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TransacTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialListBox materialListBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button AddProduct;
        private System.Windows.Forms.ComboBox employee_Name;
        private System.Windows.Forms.ComboBox productName;
        private System.Windows.Forms.TextBox TransacTotal;
        private System.Windows.Forms.Label product_ID;
        private System.Windows.Forms.Label employee_ID;
        private System.Windows.Forms.DataGridView TransacTable;
        private System.Windows.Forms.Label productStock;
        private System.Windows.Forms.TextBox qty;
        private System.Windows.Forms.Label productPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}