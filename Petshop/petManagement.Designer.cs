namespace Petshop
{
    partial class petManagement
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
            this.petDgv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.sizeCb = new System.Windows.Forms.ComboBox();
            this.petPrice = new MaterialSkin.Controls.MaterialTextBox2();
            this.petType = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.label3 = new System.Windows.Forms.Label();
            this.deletePrice = new System.Windows.Forms.Button();
            this.updatePrice = new System.Windows.Forms.Button();
            this.addPrice = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.petDgv)).BeginInit();
            this.materialCard1.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.SuspendLayout();
            // 
            // petDgv
            // 
            this.petDgv.AllowUserToAddRows = false;
            this.petDgv.AllowUserToDeleteRows = false;
            this.petDgv.AllowUserToResizeColumns = false;
            this.petDgv.AllowUserToResizeRows = false;
            this.petDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.petDgv.ColumnHeadersHeight = 35;
            this.petDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.petDgv.Location = new System.Drawing.Point(71, 77);
            this.petDgv.Name = "petDgv";
            this.petDgv.ReadOnly = true;
            this.petDgv.RowHeadersVisible = false;
            this.petDgv.RowHeadersWidth = 51;
            this.petDgv.RowTemplate.Height = 24;
            this.petDgv.Size = new System.Drawing.Size(613, 617);
            this.petDgv.TabIndex = 0;
            this.petDgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.petDgv_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "pet_type";
            this.Column1.HeaderText = "Pet Type";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "pet_size";
            this.Column2.HeaderText = "Pet Size";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "ptsize_price";
            this.Column3.HeaderText = "Price";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.sizeCb);
            this.materialCard1.Controls.Add(this.petPrice);
            this.materialCard1.Controls.Add(this.petType);
            this.materialCard1.Controls.Add(this.materialCard2);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(783, 185);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(675, 276);
            this.materialCard1.TabIndex = 1;
            // 
            // sizeCb
            // 
            this.sizeCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sizeCb.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeCb.FormattingEnabled = true;
            this.sizeCb.IntegralHeight = false;
            this.sizeCb.ItemHeight = 28;
            this.sizeCb.Items.AddRange(new object[] {
            "Select Size",
            "Small",
            "Medium",
            "Large",
            "Extra Large",
            "2XL"});
            this.sizeCb.Location = new System.Drawing.Point(367, 152);
            this.sizeCb.Name = "sizeCb";
            this.sizeCb.Size = new System.Drawing.Size(217, 36);
            this.sizeCb.TabIndex = 4;
            // 
            // petPrice
            // 
            this.petPrice.AnimateReadOnly = false;
            this.petPrice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.petPrice.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.petPrice.Depth = 0;
            this.petPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.petPrice.HideSelection = true;
            this.petPrice.Hint = "Service Price";
            this.petPrice.LeadingIcon = null;
            this.petPrice.Location = new System.Drawing.Point(53, 189);
            this.petPrice.MaxLength = 32767;
            this.petPrice.MouseState = MaterialSkin.MouseState.OUT;
            this.petPrice.Name = "petPrice";
            this.petPrice.PasswordChar = '\0';
            this.petPrice.PrefixSuffixText = null;
            this.petPrice.ReadOnly = false;
            this.petPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.petPrice.SelectedText = "";
            this.petPrice.SelectionLength = 0;
            this.petPrice.SelectionStart = 0;
            this.petPrice.ShortcutsEnabled = true;
            this.petPrice.Size = new System.Drawing.Size(247, 48);
            this.petPrice.TabIndex = 3;
            this.petPrice.TabStop = false;
            this.petPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.petPrice.TrailingIcon = null;
            this.petPrice.UseSystemPasswordChar = false;
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
            this.petType.Location = new System.Drawing.Point(53, 109);
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
            this.petType.Size = new System.Drawing.Size(247, 48);
            this.petType.TabIndex = 3;
            this.petType.TabStop = false;
            this.petType.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.petType.TrailingIcon = null;
            this.petType.UseSystemPasswordChar = false;
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.label1);
            this.materialCard2.Controls.Add(this.linkLabel1);
            this.materialCard2.Controls.Add(this.label3);
            this.materialCard2.Depth = 0;
            this.materialCard2.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(14, 14);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(647, 50);
            this.materialCard2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(4, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 38);
            this.label3.TabIndex = 41;
            this.label3.Text = "Pet Information";
            // 
            // deletePrice
            // 
            this.deletePrice.BackColor = System.Drawing.Color.SteelBlue;
            this.deletePrice.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletePrice.ForeColor = System.Drawing.Color.White;
            this.deletePrice.Location = new System.Drawing.Point(1238, 494);
            this.deletePrice.Margin = new System.Windows.Forms.Padding(4);
            this.deletePrice.Name = "deletePrice";
            this.deletePrice.Size = new System.Drawing.Size(220, 50);
            this.deletePrice.TabIndex = 41;
            this.deletePrice.Text = "DELETE";
            this.deletePrice.UseVisualStyleBackColor = false;
            this.deletePrice.Click += new System.EventHandler(this.deletePrice_Click);
            // 
            // updatePrice
            // 
            this.updatePrice.BackColor = System.Drawing.Color.SteelBlue;
            this.updatePrice.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatePrice.ForeColor = System.Drawing.Color.White;
            this.updatePrice.Location = new System.Drawing.Point(1010, 494);
            this.updatePrice.Margin = new System.Windows.Forms.Padding(4);
            this.updatePrice.Name = "updatePrice";
            this.updatePrice.Size = new System.Drawing.Size(220, 50);
            this.updatePrice.TabIndex = 40;
            this.updatePrice.Text = "UPDATE";
            this.updatePrice.UseVisualStyleBackColor = false;
            this.updatePrice.Click += new System.EventHandler(this.updatePrice_Click);
            // 
            // addPrice
            // 
            this.addPrice.BackColor = System.Drawing.Color.SteelBlue;
            this.addPrice.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPrice.ForeColor = System.Drawing.Color.White;
            this.addPrice.Location = new System.Drawing.Point(783, 494);
            this.addPrice.Margin = new System.Windows.Forms.Padding(4);
            this.addPrice.Name = "addPrice";
            this.addPrice.Size = new System.Drawing.Size(220, 50);
            this.addPrice.TabIndex = 39;
            this.addPrice.Text = "ADD";
            this.addPrice.UseVisualStyleBackColor = false;
            this.addPrice.Click += new System.EventHandler(this.addPrice_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(536, 13);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(95, 21);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Click Here";
            this.linkLabel1.Click += new System.EventHandler(this.linkLabel1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(448, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 21);
            this.label1.TabIndex = 42;
            this.label1.Text = "New Pet?";
            // 
            // petManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1793, 766);
            this.Controls.Add(this.deletePrice);
            this.Controls.Add(this.updatePrice);
            this.Controls.Add(this.addPrice);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.petDgv);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "petManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.petManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.petDgv)).EndInit();
            this.materialCard1.ResumeLayout(false);
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView petDgv;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button deletePrice;
        private System.Windows.Forms.Button updatePrice;
        private System.Windows.Forms.Button addPrice;
        private System.Windows.Forms.ComboBox sizeCb;
        private MaterialSkin.Controls.MaterialTextBox2 petPrice;
        private MaterialSkin.Controls.MaterialTextBox2 petType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}