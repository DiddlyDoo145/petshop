namespace Petshop
{
    partial class Product
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ProductTable = new System.Windows.Forms.DataGridView();
            this.panel8 = new System.Windows.Forms.Panel();
            this.product_ID = new System.Windows.Forms.Label();
            this.DeleteProducts = new System.Windows.Forms.Button();
            this.EditProducts = new System.Windows.Forms.Button();
            this.SaveProducts = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.productPrice = new System.Windows.Forms.TextBox();
            this.quantity = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.category = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.productName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductTable)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(9, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1942, 1105);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightBlue;
            this.panel2.Controls.Add(this.ProductTable);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Location = new System.Drawing.Point(372, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(916, 661);
            this.panel2.TabIndex = 0;
            // 
            // ProductTable
            // 
            this.ProductTable.AllowUserToAddRows = false;
            this.ProductTable.AllowUserToDeleteRows = false;
            this.ProductTable.AllowUserToResizeColumns = false;
            this.ProductTable.AllowUserToResizeRows = false;
            this.ProductTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ProductTable.Location = new System.Drawing.Point(66, 295);
            this.ProductTable.Margin = new System.Windows.Forms.Padding(2);
            this.ProductTable.Name = "ProductTable";
            this.ProductTable.ReadOnly = true;
            this.ProductTable.RowHeadersVisible = false;
            this.ProductTable.RowHeadersWidth = 51;
            this.ProductTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductTable.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ProductTable.RowTemplate.Height = 24;
            this.ProductTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductTable.Size = new System.Drawing.Size(818, 300);
            this.ProductTable.TabIndex = 4;
            this.ProductTable.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ProductTable_MouseClick);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel8.Controls.Add(this.product_ID);
            this.panel8.Controls.Add(this.DeleteProducts);
            this.panel8.Controls.Add(this.EditProducts);
            this.panel8.Controls.Add(this.SaveProducts);
            this.panel8.Controls.Add(this.label12);
            this.panel8.Controls.Add(this.productPrice);
            this.panel8.Controls.Add(this.quantity);
            this.panel8.Controls.Add(this.label11);
            this.panel8.Controls.Add(this.category);
            this.panel8.Controls.Add(this.label10);
            this.panel8.Controls.Add(this.productName);
            this.panel8.Controls.Add(this.label9);
            this.panel8.Controls.Add(this.label8);
            this.panel8.Location = new System.Drawing.Point(66, 32);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(818, 207);
            this.panel8.TabIndex = 1;
            // 
            // product_ID
            // 
            this.product_ID.AutoSize = true;
            this.product_ID.Location = new System.Drawing.Point(157, 7);
            this.product_ID.Name = "product_ID";
            this.product_ID.Size = new System.Drawing.Size(41, 13);
            this.product_ID.TabIndex = 12;
            this.product_ID.Text = "label14";
            this.product_ID.Visible = false;
            // 
            // DeleteProducts
            // 
            this.DeleteProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(14)))), ((int)(((byte)(53)))));
            this.DeleteProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteProducts.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteProducts.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DeleteProducts.Location = new System.Drawing.Point(476, 127);
            this.DeleteProducts.Name = "DeleteProducts";
            this.DeleteProducts.Size = new System.Drawing.Size(117, 32);
            this.DeleteProducts.TabIndex = 11;
            this.DeleteProducts.Text = "Delete";
            this.DeleteProducts.UseVisualStyleBackColor = false;
            this.DeleteProducts.Click += new System.EventHandler(this.DeleteProducts_Click);
            // 
            // EditProducts
            // 
            this.EditProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(14)))), ((int)(((byte)(53)))));
            this.EditProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditProducts.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditProducts.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.EditProducts.Location = new System.Drawing.Point(326, 127);
            this.EditProducts.Name = "EditProducts";
            this.EditProducts.Size = new System.Drawing.Size(117, 32);
            this.EditProducts.TabIndex = 10;
            this.EditProducts.Text = "Edit";
            this.EditProducts.UseVisualStyleBackColor = false;
            this.EditProducts.Click += new System.EventHandler(this.EditProducts_Click);
            // 
            // SaveProducts
            // 
            this.SaveProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(14)))), ((int)(((byte)(53)))));
            this.SaveProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveProducts.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveProducts.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SaveProducts.Location = new System.Drawing.Point(177, 127);
            this.SaveProducts.Name = "SaveProducts";
            this.SaveProducts.Size = new System.Drawing.Size(117, 32);
            this.SaveProducts.TabIndex = 9;
            this.SaveProducts.Text = "Save";
            this.SaveProducts.UseVisualStyleBackColor = false;
            this.SaveProducts.Click += new System.EventHandler(this.SaveProducts_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(619, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 21);
            this.label12.TabIndex = 8;
            this.label12.Text = "Price";
            // 
            // productPrice
            // 
            this.productPrice.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productPrice.Location = new System.Drawing.Point(622, 79);
            this.productPrice.Multiline = true;
            this.productPrice.Name = "productPrice";
            this.productPrice.Size = new System.Drawing.Size(152, 25);
            this.productPrice.TabIndex = 7;
            this.productPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.productPrice_KeyPress);
            // 
            // quantity
            // 
            this.quantity.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity.Location = new System.Drawing.Point(424, 79);
            this.quantity.Multiline = true;
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(152, 25);
            this.quantity.TabIndex = 6;
            this.quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantity_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(421, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 21);
            this.label11.TabIndex = 5;
            this.label11.Text = "Quantity";
            // 
            // category
            // 
            this.category.DisplayMember = "Sleep";
            this.category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.category.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category.FormattingEnabled = true;
            this.category.Items.AddRange(new object[] {
            "Select Category",
            "Cat",
            "Dog",
            "Food"});
            this.category.Location = new System.Drawing.Point(224, 80);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(152, 25);
            this.category.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(221, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 21);
            this.label10.TabIndex = 3;
            this.label10.Text = "Category";
            // 
            // productName
            // 
            this.productName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productName.Location = new System.Drawing.Point(30, 80);
            this.productName.Multiline = true;
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(152, 25);
            this.productName.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(27, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 21);
            this.label9.TabIndex = 1;
            this.label9.Text = "Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 32);
            this.label8.TabIndex = 0;
            this.label8.Text = "Products";
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
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Product";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product";
            this.Load += new System.EventHandler(this.Product_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductTable)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label product_ID;
        private System.Windows.Forms.Button DeleteProducts;
        private System.Windows.Forms.Button EditProducts;
        private System.Windows.Forms.Button SaveProducts;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox productPrice;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox category;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox productName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView ProductTable;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
    }
}