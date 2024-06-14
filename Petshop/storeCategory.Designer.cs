namespace Petshop
{
    partial class storeCategory
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
            this.DeleteProducts = new System.Windows.Forms.Button();
            this.EditProducts = new System.Windows.Forms.Button();
            this.SaveProducts = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.producttotal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.productName = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ProductTransactionTable = new System.Windows.Forms.DataGridView();
            this.employee = new System.Windows.Forms.ComboBox();
            this.product_ID = new System.Windows.Forms.Label();
            this.employeeID = new System.Windows.Forms.Label();
            this.pTransac_id = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Reset = new System.Windows.Forms.Button();
            this.total = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProductTransactionTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // DeleteProducts
            // 
            this.DeleteProducts.BackColor = System.Drawing.Color.Cyan;
            this.DeleteProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteProducts.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DeleteProducts.Location = new System.Drawing.Point(558, 108);
            this.DeleteProducts.Name = "DeleteProducts";
            this.DeleteProducts.Size = new System.Drawing.Size(117, 30);
            this.DeleteProducts.TabIndex = 22;
            this.DeleteProducts.Text = "Delete";
            this.DeleteProducts.UseVisualStyleBackColor = false;
            this.DeleteProducts.Click += new System.EventHandler(this.DeleteProducts_Click);
            // 
            // EditProducts
            // 
            this.EditProducts.BackColor = System.Drawing.Color.Cyan;
            this.EditProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditProducts.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EditProducts.Location = new System.Drawing.Point(415, 108);
            this.EditProducts.Name = "EditProducts";
            this.EditProducts.Size = new System.Drawing.Size(117, 30);
            this.EditProducts.TabIndex = 21;
            this.EditProducts.Text = "Edit";
            this.EditProducts.UseVisualStyleBackColor = false;
            this.EditProducts.Click += new System.EventHandler(this.EditProducts_Click);
            // 
            // SaveProducts
            // 
            this.SaveProducts.BackColor = System.Drawing.Color.Cyan;
            this.SaveProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveProducts.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SaveProducts.Location = new System.Drawing.Point(264, 108);
            this.SaveProducts.Name = "SaveProducts";
            this.SaveProducts.Size = new System.Drawing.Size(117, 30);
            this.SaveProducts.TabIndex = 20;
            this.SaveProducts.Text = "Save";
            this.SaveProducts.UseVisualStyleBackColor = false;
            this.SaveProducts.Click += new System.EventHandler(this.SaveProducts_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(623, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 16);
            this.label12.TabIndex = 19;
            this.label12.Text = "Employee";
            // 
            // producttotal
            // 
            this.producttotal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.producttotal.Location = new System.Drawing.Point(449, 61);
            this.producttotal.Multiline = true;
            this.producttotal.Name = "producttotal";
            this.producttotal.Size = new System.Drawing.Size(151, 25);
            this.producttotal.TabIndex = 17;
            this.producttotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.product_total_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(446, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 16);
            this.label11.TabIndex = 16;
            this.label11.Text = "Product Total";
            // 
            // productName
            // 
            this.productName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productName.FormattingEnabled = true;
            this.productName.Items.AddRange(new object[] {
            "Select Category"});
            this.productName.Location = new System.Drawing.Point(264, 61);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(151, 25);
            this.productName.TabIndex = 15;
            this.productName.SelectedIndexChanged += new System.EventHandler(this.productName_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(261, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "Product Name";
            // 
            // ProductTransactionTable
            // 
            this.ProductTransactionTable.AllowUserToResizeColumns = false;
            this.ProductTransactionTable.AllowUserToResizeRows = false;
            this.ProductTransactionTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductTransactionTable.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.ProductTransactionTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductTransactionTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ProductTransactionTable.ColumnHeadersHeight = 30;
            this.ProductTransactionTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductTransactionTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.ProductTransactionTable.Location = new System.Drawing.Point(126, 191);
            this.ProductTransactionTable.Name = "ProductTransactionTable";
            this.ProductTransactionTable.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductTransactionTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ProductTransactionTable.RowHeadersVisible = false;
            this.ProductTransactionTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ProductTransactionTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ProductTransactionTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductTransactionTable.Size = new System.Drawing.Size(832, 228);
            this.ProductTransactionTable.TabIndex = 23;
            this.ProductTransactionTable.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ProductTransactionTable_MouseClick);
            // 
            // employee
            // 
            this.employee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.employee.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee.FormattingEnabled = true;
            this.employee.Items.AddRange(new object[] {
            "SELECT CATEGORY"});
            this.employee.Location = new System.Drawing.Point(626, 61);
            this.employee.Name = "employee";
            this.employee.Size = new System.Drawing.Size(144, 25);
            this.employee.TabIndex = 24;
            this.employee.SelectedIndexChanged += new System.EventHandler(this.employee_SelectedIndexChanged);
            // 
            // product_ID
            // 
            this.product_ID.AutoSize = true;
            this.product_ID.Dock = System.Windows.Forms.DockStyle.Left;
            this.product_ID.Location = new System.Drawing.Point(0, 0);
            this.product_ID.Name = "product_ID";
            this.product_ID.Size = new System.Drawing.Size(35, 13);
            this.product_ID.TabIndex = 25;
            this.product_ID.Text = "label1";
            // 
            // employeeID
            // 
            this.employeeID.AutoSize = true;
            this.employeeID.Dock = System.Windows.Forms.DockStyle.Left;
            this.employeeID.Location = new System.Drawing.Point(35, 0);
            this.employeeID.Name = "employeeID";
            this.employeeID.Size = new System.Drawing.Size(35, 13);
            this.employeeID.TabIndex = 26;
            this.employeeID.Text = "label2";
            // 
            // pTransac_id
            // 
            this.pTransac_id.AutoSize = true;
            this.pTransac_id.Dock = System.Windows.Forms.DockStyle.Left;
            this.pTransac_id.Location = new System.Drawing.Point(70, 0);
            this.pTransac_id.Name = "pTransac_id";
            this.pTransac_id.Size = new System.Drawing.Size(35, 13);
            this.pTransac_id.TabIndex = 27;
            this.pTransac_id.Text = "label1";
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
            // Reset
            // 
            this.Reset.BackColor = System.Drawing.Color.Cyan;
            this.Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Reset.Location = new System.Drawing.Point(697, 108);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(117, 30);
            this.Reset.TabIndex = 28;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = false;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Location = new System.Drawing.Point(36, 39);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(35, 13);
            this.total.TabIndex = 29;
            this.total.Text = "label1";
            // 
            // storeCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1008, 535);
            this.Controls.Add(this.total);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.pTransac_id);
            this.Controls.Add(this.employeeID);
            this.Controls.Add(this.product_ID);
            this.Controls.Add(this.employee);
            this.Controls.Add(this.ProductTransactionTable);
            this.Controls.Add(this.DeleteProducts);
            this.Controls.Add(this.EditProducts);
            this.Controls.Add(this.SaveProducts);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.producttotal);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.productName);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "storeCategory";
            this.Text = "storeCategory";
            this.Load += new System.EventHandler(this.storeCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductTransactionTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeleteProducts;
        private System.Windows.Forms.Button EditProducts;
        private System.Windows.Forms.Button SaveProducts;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox producttotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox productName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView ProductTransactionTable;
        private System.Windows.Forms.ComboBox employee;
        private System.Windows.Forms.Label product_ID;
        private System.Windows.Forms.Label employeeID;
        private System.Windows.Forms.Label pTransac_id;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Label total;
    }
}