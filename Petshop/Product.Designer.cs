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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product));
            this.panel4 = new System.Windows.Forms.Panel();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.label26 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.services = new MaterialSkin.Controls.MaterialButton();
            this.productCategory = new MaterialSkin.Controls.MaterialButton();
            this.pCategorybtn = new MaterialSkin.Controls.MaterialButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.Controls.Add(this.materialCard1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1802, 87);
            this.panel4.TabIndex = 1;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.materialCard2);
            this.materialCard1.Depth = 0;
            this.materialCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(0, 0);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(1802, 87);
            this.materialCard1.TabIndex = 4;
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.label26);
            this.materialCard2.Controls.Add(this.pictureBox1);
            this.materialCard2.Depth = 0;
            this.materialCard2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(14, 14);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(1774, 59);
            this.materialCard2.TabIndex = 0;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.Black;
            this.label26.Location = new System.Drawing.Point(107, 10);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(323, 40);
            this.label26.TabIndex = 3;
            this.label26.Text = "Product Management";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.services);
            this.panel3.Controls.Add(this.productCategory);
            this.panel3.Controls.Add(this.pCategorybtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 87);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1802, 75);
            this.panel3.TabIndex = 6;
            // 
            // services
            // 
            this.services.AutoSize = false;
            this.services.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.services.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.services.Depth = 0;
            this.services.HighEmphasis = true;
            this.services.Icon = null;
            this.services.Location = new System.Drawing.Point(1203, 5);
            this.services.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.services.MouseState = MaterialSkin.MouseState.HOVER;
            this.services.Name = "services";
            this.services.NoAccentTextColor = System.Drawing.Color.Empty;
            this.services.Size = new System.Drawing.Size(590, 66);
            this.services.TabIndex = 9;
            this.services.Text = "Services";
            this.services.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.services.UseAccentColor = false;
            this.services.UseVisualStyleBackColor = true;
            this.services.Click += new System.EventHandler(this.services_Click);
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
            this.productCategory.Size = new System.Drawing.Size(590, 66);
            this.productCategory.TabIndex = 6;
            this.productCategory.Text = "Products";
            this.productCategory.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.productCategory.UseAccentColor = false;
            this.productCategory.UseVisualStyleBackColor = true;
            this.productCategory.Click += new System.EventHandler(this.productCategory_Click);
            // 
            // pCategorybtn
            // 
            this.pCategorybtn.AutoSize = false;
            this.pCategorybtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pCategorybtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.pCategorybtn.Depth = 0;
            this.pCategorybtn.HighEmphasis = true;
            this.pCategorybtn.Icon = null;
            this.pCategorybtn.Location = new System.Drawing.Point(605, 5);
            this.pCategorybtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.pCategorybtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.pCategorybtn.Name = "pCategorybtn";
            this.pCategorybtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.pCategorybtn.Size = new System.Drawing.Size(590, 66);
            this.pCategorybtn.TabIndex = 7;
            this.pCategorybtn.Text = "Product Category";
            this.pCategorybtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.pCategorybtn.UseAccentColor = false;
            this.pCategorybtn.UseVisualStyleBackColor = true;
            this.pCategorybtn.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel5.Location = new System.Drawing.Point(4, 168);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1793, 766);
            this.panel5.TabIndex = 7;
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1802, 938);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Product";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Product_Load);
            this.panel4.ResumeLayout(false);
            this.materialCard1.ResumeLayout(false);
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private MaterialSkin.Controls.MaterialButton services;
        private MaterialSkin.Controls.MaterialButton pCategorybtn;
        private MaterialSkin.Controls.MaterialButton productCategory;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialCard materialCard2;
    }
}