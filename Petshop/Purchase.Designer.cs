namespace Petshop
{
    partial class Purchase
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.productName = new System.Windows.Forms.ComboBox();
            this.employee_Name = new System.Windows.Forms.ComboBox();
            this.TransacTotal = new System.Windows.Forms.TextBox();
            this.AddProduct = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.productPrice = new System.Windows.Forms.Label();
            this.productStock = new System.Windows.Forms.Label();
            this.employee_ID = new System.Windows.Forms.Label();
            this.product_ID = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(143, 121);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(208, 25);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // productName
            // 
            this.productName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productName.FormattingEnabled = true;
            this.productName.Items.AddRange(new object[] {
            "SELECT CATEGORY"});
            this.productName.Location = new System.Drawing.Point(143, 58);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(208, 25);
            this.productName.TabIndex = 49;
            this.productName.SelectedIndexChanged += new System.EventHandler(this.productName_SelectedIndexChanged);
            // 
            // employee_Name
            // 
            this.employee_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.employee_Name.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee_Name.FormattingEnabled = true;
            this.employee_Name.Items.AddRange(new object[] {
            "SELECT CATEGORY"});
            this.employee_Name.Location = new System.Drawing.Point(143, 251);
            this.employee_Name.Name = "employee_Name";
            this.employee_Name.Size = new System.Drawing.Size(208, 25);
            this.employee_Name.TabIndex = 50;
            this.employee_Name.SelectedIndexChanged += new System.EventHandler(this.employee_Name_SelectedIndexChanged);
            // 
            // TransacTotal
            // 
            this.TransacTotal.Location = new System.Drawing.Point(143, 183);
            this.TransacTotal.Multiline = true;
            this.TransacTotal.Name = "TransacTotal";
            this.TransacTotal.Size = new System.Drawing.Size(208, 25);
            this.TransacTotal.TabIndex = 51;
            // 
            // AddProduct
            // 
            this.AddProduct.BackColor = System.Drawing.Color.Aqua;
            this.AddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddProduct.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProduct.Location = new System.Drawing.Point(143, 295);
            this.AddProduct.Name = "AddProduct";
            this.AddProduct.Size = new System.Drawing.Size(117, 30);
            this.AddProduct.TabIndex = 52;
            this.AddProduct.Text = "Add";
            this.AddProduct.UseVisualStyleBackColor = false;
            this.AddProduct.Click += new System.EventHandler(this.AddProduct_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(140, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 55;
            this.label2.Text = "Product Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(140, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 56;
            this.label1.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(140, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 57;
            this.label3.Text = "Total Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(140, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 17);
            this.label4.TabIndex = 58;
            this.label4.Text = "Employee Name";
            // 
            // productPrice
            // 
            this.productPrice.AutoSize = true;
            this.productPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.productPrice.Location = new System.Drawing.Point(70, 0);
            this.productPrice.Name = "productPrice";
            this.productPrice.Size = new System.Drawing.Size(35, 13);
            this.productPrice.TabIndex = 68;
            this.productPrice.Text = "label1";
            // 
            // productStock
            // 
            this.productStock.AutoSize = true;
            this.productStock.Location = new System.Drawing.Point(0, 13);
            this.productStock.Name = "productStock";
            this.productStock.Size = new System.Drawing.Size(35, 13);
            this.productStock.TabIndex = 67;
            this.productStock.Text = "label1";
            // 
            // employee_ID
            // 
            this.employee_ID.AutoSize = true;
            this.employee_ID.Dock = System.Windows.Forms.DockStyle.Left;
            this.employee_ID.Location = new System.Drawing.Point(35, 0);
            this.employee_ID.Name = "employee_ID";
            this.employee_ID.Size = new System.Drawing.Size(35, 13);
            this.employee_ID.TabIndex = 66;
            this.employee_ID.Text = "label1";
            // 
            // product_ID
            // 
            this.product_ID.AutoSize = true;
            this.product_ID.Dock = System.Windows.Forms.DockStyle.Left;
            this.product_ID.Location = new System.Drawing.Point(0, 0);
            this.product_ID.Name = "product_ID";
            this.product_ID.Size = new System.Drawing.Size(35, 13);
            this.product_ID.TabIndex = 65;
            this.product_ID.Text = "label1";
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
            // Purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(473, 450);
            this.Controls.Add(this.productPrice);
            this.Controls.Add(this.productStock);
            this.Controls.Add(this.employee_ID);
            this.Controls.Add(this.product_ID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddProduct);
            this.Controls.Add(this.TransacTotal);
            this.Controls.Add(this.employee_Name);
            this.Controls.Add(this.productName);
            this.Controls.Add(this.textBox2);
            this.Name = "Purchase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase";
            this.Load += new System.EventHandler(this.Purchase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox productName;
        private System.Windows.Forms.ComboBox employee_Name;
        private System.Windows.Forms.TextBox TransacTotal;
        private System.Windows.Forms.Button AddProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label productPrice;
        private System.Windows.Forms.Label productStock;
        private System.Windows.Forms.Label employee_ID;
        private System.Windows.Forms.Label product_ID;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
    }
}