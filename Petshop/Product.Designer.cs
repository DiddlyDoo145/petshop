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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.services = new MaterialSkin.Controls.MaterialButton();
            this.TransacBtn = new MaterialSkin.Controls.MaterialButton();
            this.pCategorybtn = new MaterialSkin.Controls.MaterialButton();
            this.productCategory = new MaterialSkin.Controls.MaterialButton();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1328, 765);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.services);
            this.panel4.Controls.Add(this.TransacBtn);
            this.panel4.Controls.Add(this.pCategorybtn);
            this.panel4.Controls.Add(this.productCategory);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1328, 58);
            this.panel4.TabIndex = 1;
            // 
            // services
            // 
            this.services.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.services.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.services.Depth = 0;
            this.services.Dock = System.Windows.Forms.DockStyle.Left;
            this.services.HighEmphasis = true;
            this.services.Icon = null;
            this.services.Location = new System.Drawing.Point(456, 0);
            this.services.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.services.MouseState = MaterialSkin.MouseState.HOVER;
            this.services.Name = "services";
            this.services.NoAccentTextColor = System.Drawing.Color.Empty;
            this.services.Size = new System.Drawing.Size(88, 58);
            this.services.TabIndex = 5;
            this.services.Text = "Services";
            this.services.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.services.UseAccentColor = false;
            this.services.UseVisualStyleBackColor = true;
            this.services.Click += new System.EventHandler(this.services_Click);
            // 
            // TransacBtn
            // 
            this.TransacBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TransacBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.TransacBtn.Depth = 0;
            this.TransacBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.TransacBtn.HighEmphasis = true;
            this.TransacBtn.Icon = null;
            this.TransacBtn.Location = new System.Drawing.Point(264, 0);
            this.TransacBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.TransacBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.TransacBtn.Name = "TransacBtn";
            this.TransacBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.TransacBtn.Size = new System.Drawing.Size(192, 58);
            this.TransacBtn.TabIndex = 4;
            this.TransacBtn.Text = "Product Transaction";
            this.TransacBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.TransacBtn.UseAccentColor = false;
            this.TransacBtn.UseVisualStyleBackColor = true;
            this.TransacBtn.Click += new System.EventHandler(this.TransacBtn_Click);
            // 
            // pCategorybtn
            // 
            this.pCategorybtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pCategorybtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.pCategorybtn.Depth = 0;
            this.pCategorybtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.pCategorybtn.HighEmphasis = true;
            this.pCategorybtn.Icon = null;
            this.pCategorybtn.Location = new System.Drawing.Point(97, 0);
            this.pCategorybtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.pCategorybtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.pCategorybtn.Name = "pCategorybtn";
            this.pCategorybtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.pCategorybtn.Size = new System.Drawing.Size(167, 58);
            this.pCategorybtn.TabIndex = 3;
            this.pCategorybtn.Text = "Product Category";
            this.pCategorybtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.pCategorybtn.UseAccentColor = false;
            this.pCategorybtn.UseVisualStyleBackColor = true;
            this.pCategorybtn.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // productCategory
            // 
            this.productCategory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.productCategory.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.productCategory.Depth = 0;
            this.productCategory.Dock = System.Windows.Forms.DockStyle.Left;
            this.productCategory.HighEmphasis = true;
            this.productCategory.Icon = null;
            this.productCategory.Location = new System.Drawing.Point(0, 0);
            this.productCategory.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.productCategory.MouseState = MaterialSkin.MouseState.HOVER;
            this.productCategory.Name = "productCategory";
            this.productCategory.NoAccentTextColor = System.Drawing.Color.Empty;
            this.productCategory.Size = new System.Drawing.Size(97, 58);
            this.productCategory.TabIndex = 2;
            this.productCategory.Text = "Products";
            this.productCategory.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.productCategory.UseAccentColor = false;
            this.productCategory.UseVisualStyleBackColor = true;
            this.productCategory.Click += new System.EventHandler(this.productCategory_Click);
            // 
            // Product
            // 
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1328, 765);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Product";
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private MaterialSkin.Controls.MaterialButton productCategory;
        private MaterialSkin.Controls.MaterialButton pCategorybtn;
        private MaterialSkin.Controls.MaterialButton TransacBtn;
        private MaterialSkin.Controls.MaterialButton services;
    }
}