namespace Petshop
{
    partial class empOt
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
            this.otDgv = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.payBtn = new MaterialSkin.Controls.MaterialButton();
            this.jobTitle = new MaterialSkin.Controls.MaterialTextBox2();
            this.otPay = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.otDgv)).BeginInit();
            this.materialCard1.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.SuspendLayout();
            // 
            // otDgv
            // 
            this.otDgv.AllowUserToAddRows = false;
            this.otDgv.AllowUserToDeleteRows = false;
            this.otDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.otDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.otDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1,
            this.Column3});
            this.otDgv.Location = new System.Drawing.Point(72, 106);
            this.otDgv.Name = "otDgv";
            this.otDgv.ReadOnly = true;
            this.otDgv.RowHeadersWidth = 51;
            this.otDgv.RowTemplate.Height = 24;
            this.otDgv.Size = new System.Drawing.Size(952, 674);
            this.otDgv.TabIndex = 3;
            this.otDgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.otDgv_CellClick);
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "otRate_id";
            this.Column2.HeaderText = "Overtime Pay ID";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "position_desc";
            this.Column1.HeaderText = "Job Title";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "otRate_pay";
            this.Column3.HeaderText = "OT Rate";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.materialCard3);
            this.materialCard1.Controls.Add(this.materialCard2);
            this.materialCard1.Controls.Add(this.otDgv);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(3, 3);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(1779, 822);
            this.materialCard1.TabIndex = 4;
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.materialCard3.Controls.Add(this.payBtn);
            this.materialCard3.Controls.Add(this.jobTitle);
            this.materialCard3.Controls.Add(this.otPay);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(1184, 249);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(418, 321);
            this.materialCard3.TabIndex = 10;
            // 
            // payBtn
            // 
            this.payBtn.AutoSize = false;
            this.payBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.payBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.payBtn.Depth = 0;
            this.payBtn.HighEmphasis = true;
            this.payBtn.Icon = null;
            this.payBtn.Location = new System.Drawing.Point(133, 228);
            this.payBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.payBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.payBtn.Name = "payBtn";
            this.payBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.payBtn.Size = new System.Drawing.Size(138, 45);
            this.payBtn.TabIndex = 8;
            this.payBtn.Text = "Set Pay";
            this.payBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.payBtn.UseAccentColor = false;
            this.payBtn.UseVisualStyleBackColor = true;
            this.payBtn.Click += new System.EventHandler(this.payBtn_Click);
            // 
            // jobTitle
            // 
            this.jobTitle.AnimateReadOnly = false;
            this.jobTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.jobTitle.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.jobTitle.Depth = 0;
            this.jobTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.jobTitle.HideSelection = true;
            this.jobTitle.Hint = "Job title";
            this.jobTitle.LeadingIcon = null;
            this.jobTitle.Location = new System.Drawing.Point(38, 59);
            this.jobTitle.MaxLength = 32767;
            this.jobTitle.MouseState = MaterialSkin.MouseState.OUT;
            this.jobTitle.Name = "jobTitle";
            this.jobTitle.PasswordChar = '\0';
            this.jobTitle.PrefixSuffixText = null;
            this.jobTitle.ReadOnly = false;
            this.jobTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.jobTitle.SelectedText = "";
            this.jobTitle.SelectionLength = 0;
            this.jobTitle.SelectionStart = 0;
            this.jobTitle.ShortcutsEnabled = true;
            this.jobTitle.Size = new System.Drawing.Size(334, 48);
            this.jobTitle.TabIndex = 9;
            this.jobTitle.TabStop = false;
            this.jobTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.jobTitle.TrailingIcon = null;
            this.jobTitle.UseSystemPasswordChar = false;
            this.jobTitle.TextChanged += new System.EventHandler(this.jobTitle_TextChanged);
            // 
            // otPay
            // 
            this.otPay.AnimateReadOnly = false;
            this.otPay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.otPay.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.otPay.Depth = 0;
            this.otPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.otPay.HideSelection = true;
            this.otPay.Hint = "Overtime pay per hour";
            this.otPay.LeadingIcon = null;
            this.otPay.Location = new System.Drawing.Point(38, 140);
            this.otPay.MaxLength = 32767;
            this.otPay.MouseState = MaterialSkin.MouseState.OUT;
            this.otPay.Name = "otPay";
            this.otPay.PasswordChar = '\0';
            this.otPay.PrefixSuffixText = null;
            this.otPay.ReadOnly = false;
            this.otPay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.otPay.SelectedText = "";
            this.otPay.SelectionLength = 0;
            this.otPay.SelectionStart = 0;
            this.otPay.ShortcutsEnabled = true;
            this.otPay.Size = new System.Drawing.Size(334, 48);
            this.otPay.TabIndex = 7;
            this.otPay.TabStop = false;
            this.otPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.otPay.TrailingIcon = null;
            this.otPay.UseSystemPasswordChar = false;
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.label2);
            this.materialCard2.Depth = 0;
            this.materialCard2.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(14, 14);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(1751, 57);
            this.materialCard2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(381, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Overtime Pay Management";
            // 
            // empOt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1805, 858);
            this.Controls.Add(this.materialCard1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "empOt";
            this.Text = "empOt";
            this.Load += new System.EventHandler(this.empOt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.otDgv)).EndInit();
            this.materialCard1.ResumeLayout(false);
            this.materialCard3.ResumeLayout(false);
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView otDgv;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialTextBox2 otPay;
        private MaterialSkin.Controls.MaterialTextBox2 jobTitle;
        private MaterialSkin.Controls.MaterialButton payBtn;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}