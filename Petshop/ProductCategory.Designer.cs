namespace Petshop
{
    partial class productcategory
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
            this.pCategory = new System.Windows.Forms.DataGridView();
            this.pCategoryName = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.AddProduct = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.CategoryID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pCategory
            // 
            this.pCategory.AllowUserToOrderColumns = true;
            this.pCategory.AllowUserToResizeColumns = false;
            this.pCategory.AllowUserToResizeRows = false;
            this.pCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.pCategory.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.pCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.pCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.pCategory.ColumnHeadersHeight = 30;
            this.pCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.pCategory.DefaultCellStyle = dataGridViewCellStyle2;
            this.pCategory.Location = new System.Drawing.Point(168, 188);
            this.pCategory.Margin = new System.Windows.Forms.Padding(4);
            this.pCategory.Name = "pCategory";
            this.pCategory.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.pCategory.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.pCategory.RowHeadersVisible = false;
            this.pCategory.RowHeadersWidth = 51;
            this.pCategory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.pCategory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.pCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pCategory.Size = new System.Drawing.Size(1099, 278);
            this.pCategory.TabIndex = 16;
            this.pCategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pCategory_CellClick);
            this.pCategory.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pCategory_MouseClick);
            // 
            // pCategoryName
            // 
            this.pCategoryName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pCategoryName.Location = new System.Drawing.Point(511, 60);
            this.pCategoryName.Margin = new System.Windows.Forms.Padding(4);
            this.pCategoryName.Multiline = true;
            this.pCategoryName.Name = "pCategoryName";
            this.pCategoryName.Size = new System.Drawing.Size(331, 37);
            this.pCategoryName.TabIndex = 32;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Aqua;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(795, 129);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 37);
            this.button2.TabIndex = 47;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Edit
            // 
            this.Edit.BackColor = System.Drawing.Color.Aqua;
            this.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit.Location = new System.Drawing.Point(607, 129);
            this.Edit.Margin = new System.Windows.Forms.Padding(4);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(156, 37);
            this.Edit.TabIndex = 46;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = false;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // AddProduct
            // 
            this.AddProduct.BackColor = System.Drawing.Color.Aqua;
            this.AddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddProduct.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProduct.Location = new System.Drawing.Point(427, 129);
            this.AddProduct.Margin = new System.Windows.Forms.Padding(4);
            this.AddProduct.Name = "AddProduct";
            this.AddProduct.Size = new System.Drawing.Size(156, 37);
            this.AddProduct.TabIndex = 45;
            this.AddProduct.Text = "Add";
            this.AddProduct.UseVisualStyleBackColor = false;
            this.AddProduct.Click += new System.EventHandler(this.AddProduct_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // CategoryID
            // 
            this.CategoryID.AutoSize = true;
            this.CategoryID.Dock = System.Windows.Forms.DockStyle.Left;
            this.CategoryID.Location = new System.Drawing.Point(0, 0);
            this.CategoryID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CategoryID.Name = "CategoryID";
            this.CategoryID.Size = new System.Drawing.Size(44, 16);
            this.CategoryID.TabIndex = 49;
            this.CategoryID.Text = "label1";
            this.CategoryID.Visible = false;
            // 
            // productcategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1344, 658);
            this.Controls.Add(this.CategoryID);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.AddProduct);
            this.Controls.Add(this.pCategoryName);
            this.Controls.Add(this.pCategory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "productcategory";
            this.Text = "productcategory";
            ((System.ComponentModel.ISupportInitialize)(this.pCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView pCategory;
        private System.Windows.Forms.TextBox pCategoryName;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button AddProduct;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label CategoryID;
    }
}