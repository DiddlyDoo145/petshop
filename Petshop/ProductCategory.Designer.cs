namespace Petshop
{
    partial class ProductCategory
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
            this.PCategory = new System.Windows.Forms.TextBox();
            this.category = new System.Windows.Forms.DataGridView();
            this.AddCategory = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.category)).BeginInit();
            this.SuspendLayout();
            // 
            // PCategory
            // 
            this.PCategory.Location = new System.Drawing.Point(242, 36);
            this.PCategory.Multiline = true;
            this.PCategory.Name = "PCategory";
            this.PCategory.Size = new System.Drawing.Size(293, 27);
            this.PCategory.TabIndex = 0;
            // 
            // category
            // 
            this.category.AllowUserToResizeColumns = false;
            this.category.AllowUserToResizeRows = false;
            this.category.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.category.Location = new System.Drawing.Point(242, 116);
            this.category.Name = "category";
            this.category.ReadOnly = true;
            this.category.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.category.Size = new System.Drawing.Size(420, 157);
            this.category.TabIndex = 1;
            this.category.MouseClick += new System.Windows.Forms.MouseEventHandler(this.category_MouseClick);
            // 
            // AddCategory
            // 
            this.AddCategory.Location = new System.Drawing.Point(242, 80);
            this.AddCategory.Name = "AddCategory";
            this.AddCategory.Size = new System.Drawing.Size(88, 30);
            this.AddCategory.TabIndex = 2;
            this.AddCategory.Text = "Add";
            this.AddCategory.UseVisualStyleBackColor = true;
            this.AddCategory.Click += new System.EventHandler(this.AddCategory_Click);
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(348, 80);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(88, 30);
            this.Edit.TabIndex = 3;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(447, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 30);
            this.button2.TabIndex = 4;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "PRODUCT CATEGORY";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // ProductCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1024, 574);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.AddCategory);
            this.Controls.Add(this.category);
            this.Controls.Add(this.PCategory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductCategory";
            this.Text = "ProductCategory";
            ((System.ComponentModel.ISupportInitialize)(this.category)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PCategory;
        private System.Windows.Forms.Button AddCategory;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView category;
    }
}