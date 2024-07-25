namespace Petshop
{
    partial class checkoutTotal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(checkoutTotal));
            this.customerCash = new MaterialSkin.Controls.MaterialTextBox2();
            this.receiptPrint = new MaterialSkin.Controls.MaterialButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.orderTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sukli = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // customerCash
            // 
            this.customerCash.AnimateReadOnly = false;
            this.customerCash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.customerCash.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.customerCash.Depth = 0;
            this.customerCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.customerCash.HideSelection = true;
            this.customerCash.Hint = "Total Cash";
            this.customerCash.LeadingIcon = null;
            this.customerCash.Location = new System.Drawing.Point(92, 195);
            this.customerCash.MaxLength = 32767;
            this.customerCash.MouseState = MaterialSkin.MouseState.OUT;
            this.customerCash.Name = "customerCash";
            this.customerCash.PasswordChar = '\0';
            this.customerCash.PrefixSuffixText = null;
            this.customerCash.ReadOnly = false;
            this.customerCash.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.customerCash.SelectedText = "";
            this.customerCash.SelectionLength = 0;
            this.customerCash.SelectionStart = 0;
            this.customerCash.ShortcutsEnabled = true;
            this.customerCash.Size = new System.Drawing.Size(254, 48);
            this.customerCash.TabIndex = 0;
            this.customerCash.TabStop = false;
            this.customerCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.customerCash.TrailingIcon = null;
            this.customerCash.UseSystemPasswordChar = false;
            this.customerCash.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.customerCash_KeyPress);
            this.customerCash.TextChanged += new System.EventHandler(this.customerCash_TextChanged);
            // 
            // receiptPrint
            // 
            this.receiptPrint.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.receiptPrint.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.receiptPrint.Depth = 0;
            this.receiptPrint.HighEmphasis = true;
            this.receiptPrint.Icon = null;
            this.receiptPrint.Location = new System.Drawing.Point(162, 323);
            this.receiptPrint.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.receiptPrint.MouseState = MaterialSkin.MouseState.HOVER;
            this.receiptPrint.Name = "receiptPrint";
            this.receiptPrint.NoAccentTextColor = System.Drawing.Color.Empty;
            this.receiptPrint.Size = new System.Drawing.Size(125, 36);
            this.receiptPrint.TabIndex = 1;
            this.receiptPrint.Text = "Print Receipt";
            this.receiptPrint.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.receiptPrint.UseAccentColor = false;
            this.receiptPrint.UseVisualStyleBackColor = true;
            this.receiptPrint.Click += new System.EventHandler(this.receiptPrint_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total: ₱";
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(101, 8);
            this.pictureBox11.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(333, 71);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 8;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // orderTotal
            // 
            this.orderTotal.AutoSize = true;
            this.orderTotal.Font = new System.Drawing.Font("Yu Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderTotal.Location = new System.Drawing.Point(229, 142);
            this.orderTotal.Name = "orderTotal";
            this.orderTotal.Size = new System.Drawing.Size(47, 36);
            this.orderTotal.TabIndex = 2;
            this.orderTotal.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 39);
            this.label3.TabIndex = 2;
            this.label3.Text = "Change: ₱";
            // 
            // sukli
            // 
            this.sukli.AutoSize = true;
            this.sukli.Font = new System.Drawing.Font("Yu Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sukli.Location = new System.Drawing.Point(229, 263);
            this.sukli.Name = "sukli";
            this.sukli.Size = new System.Drawing.Size(47, 36);
            this.sukli.TabIndex = 2;
            this.sukli.Text = "00";
            // 
            // checkoutTotal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(449, 398);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.sukli);
            this.Controls.Add(this.orderTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.receiptPrint);
            this.Controls.Add(this.customerCash);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "checkoutTotal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductTransac";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 customerCash;
        private MaterialSkin.Controls.MaterialButton receiptPrint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label sukli;
        public System.Windows.Forms.Label orderTotal;
    }
}