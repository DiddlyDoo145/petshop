namespace Petshop
{
    partial class empPosition
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(empPosition));
            this.label5 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.jobDgv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobSearchBox = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.addJobBtn = new System.Windows.Forms.Button();
            this.updateJobBtn = new System.Windows.Forms.Button();
            this.deleteJobBtn = new System.Windows.Forms.Button();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.jSalary = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.label6 = new System.Windows.Forms.Label();
            this.jTitle = new MaterialSkin.Controls.MaterialTextBox2();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialCard5 = new MaterialSkin.Controls.MaterialCard();
            this.materialCard6 = new MaterialSkin.Controls.MaterialCard();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.jobDgv)).BeginInit();
            this.materialCard1.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.materialCard5.SuspendLayout();
            this.materialCard6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(217, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "New job?";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(314, 70);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(92, 21);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Click here";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(23, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 24);
            this.label9.TabIndex = 2;
            this.label9.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(45, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 24);
            this.label8.TabIndex = 3;
            this.label8.Text = "Required";
            // 
            // jobDgv
            // 
            this.jobDgv.AllowUserToAddRows = false;
            this.jobDgv.AllowUserToDeleteRows = false;
            this.jobDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.jobDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jobDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.jobDgv.Location = new System.Drawing.Point(57, 154);
            this.jobDgv.Name = "jobDgv";
            this.jobDgv.ReadOnly = true;
            this.jobDgv.RowHeadersVisible = false;
            this.jobDgv.RowHeadersWidth = 51;
            this.jobDgv.RowTemplate.Height = 24;
            this.jobDgv.Size = new System.Drawing.Size(631, 573);
            this.jobDgv.TabIndex = 2;
            this.jobDgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.jobDgv_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "position_id";
            this.Column1.HeaderText = "JOB ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "position_desc";
            this.Column2.HeaderText = "JOB TITLE";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "position_salary";
            this.Column3.HeaderText = "JOB SALARY";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // jobSearchBox
            // 
            this.jobSearchBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobSearchBox.Location = new System.Drawing.Point(193, 116);
            this.jobSearchBox.Name = "jobSearchBox";
            this.jobSearchBox.Size = new System.Drawing.Size(348, 32);
            this.jobSearchBox.TabIndex = 4;
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.RosyBrown;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Location = new System.Drawing.Point(547, 116);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(141, 32);
            this.searchBtn.TabIndex = 5;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Job List";
            // 
            // addJobBtn
            // 
            this.addJobBtn.BackColor = System.Drawing.Color.RosyBrown;
            this.addJobBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addJobBtn.Location = new System.Drawing.Point(720, 532);
            this.addJobBtn.Name = "addJobBtn";
            this.addJobBtn.Size = new System.Drawing.Size(141, 53);
            this.addJobBtn.TabIndex = 6;
            this.addJobBtn.Text = "Add Job";
            this.addJobBtn.UseVisualStyleBackColor = false;
            this.addJobBtn.Click += new System.EventHandler(this.addJobBtn_Click);
            // 
            // updateJobBtn
            // 
            this.updateJobBtn.BackColor = System.Drawing.Color.RosyBrown;
            this.updateJobBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateJobBtn.Location = new System.Drawing.Point(867, 532);
            this.updateJobBtn.Name = "updateJobBtn";
            this.updateJobBtn.Size = new System.Drawing.Size(136, 53);
            this.updateJobBtn.TabIndex = 7;
            this.updateJobBtn.Text = "Update Job";
            this.updateJobBtn.UseVisualStyleBackColor = false;
            this.updateJobBtn.Click += new System.EventHandler(this.updateJobBtn_Click);
            // 
            // deleteJobBtn
            // 
            this.deleteJobBtn.BackColor = System.Drawing.Color.RosyBrown;
            this.deleteJobBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteJobBtn.Location = new System.Drawing.Point(1009, 532);
            this.deleteJobBtn.Name = "deleteJobBtn";
            this.deleteJobBtn.Size = new System.Drawing.Size(129, 53);
            this.deleteJobBtn.TabIndex = 8;
            this.deleteJobBtn.Text = "Delete Job";
            this.deleteJobBtn.UseVisualStyleBackColor = false;
            this.deleteJobBtn.Click += new System.EventHandler(this.deleteJobBtn_Click);
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.label5);
            this.materialCard1.Controls.Add(this.jSalary);
            this.materialCard1.Controls.Add(this.linkLabel1);
            this.materialCard1.Controls.Add(this.materialCard2);
            this.materialCard1.Controls.Add(this.jTitle);
            this.materialCard1.Controls.Add(this.label8);
            this.materialCard1.Controls.Add(this.label3);
            this.materialCard1.Controls.Add(this.label2);
            this.materialCard1.Controls.Add(this.label9);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(717, 230);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(418, 281);
            this.materialCard1.TabIndex = 9;
            // 
            // jSalary
            // 
            this.jSalary.AnimateReadOnly = false;
            this.jSalary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.jSalary.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.jSalary.Depth = 0;
            this.jSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.jSalary.HideSelection = true;
            this.jSalary.Hint = "Job Salary";
            this.jSalary.LeadingIcon = null;
            this.jSalary.Location = new System.Drawing.Point(52, 177);
            this.jSalary.MaxLength = 32767;
            this.jSalary.MouseState = MaterialSkin.MouseState.OUT;
            this.jSalary.Name = "jSalary";
            this.jSalary.PasswordChar = '\0';
            this.jSalary.PrefixSuffixText = null;
            this.jSalary.ReadOnly = false;
            this.jSalary.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.jSalary.SelectedText = "";
            this.jSalary.SelectionLength = 0;
            this.jSalary.SelectionStart = 0;
            this.jSalary.ShortcutsEnabled = true;
            this.jSalary.Size = new System.Drawing.Size(300, 48);
            this.jSalary.TabIndex = 11;
            this.jSalary.TabStop = false;
            this.jSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.jSalary.TrailingIcon = null;
            this.jSalary.UseSystemPasswordChar = false;
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.label6);
            this.materialCard2.Depth = 0;
            this.materialCard2.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(14, 14);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(390, 45);
            this.materialCard2.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(245, 29);
            this.label6.TabIndex = 4;
            this.label6.Text = "Position Information";
            // 
            // jTitle
            // 
            this.jTitle.AnimateReadOnly = false;
            this.jTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.jTitle.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.jTitle.Depth = 0;
            this.jTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.jTitle.HideSelection = true;
            this.jTitle.Hint = "Job Title";
            this.jTitle.LeadingIcon = null;
            this.jTitle.Location = new System.Drawing.Point(52, 103);
            this.jTitle.MaxLength = 32767;
            this.jTitle.MouseState = MaterialSkin.MouseState.OUT;
            this.jTitle.Name = "jTitle";
            this.jTitle.PasswordChar = '\0';
            this.jTitle.PrefixSuffixText = null;
            this.jTitle.ReadOnly = false;
            this.jTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.jTitle.SelectedText = "";
            this.jTitle.SelectionLength = 0;
            this.jTitle.SelectionStart = 0;
            this.jTitle.ShortcutsEnabled = true;
            this.jTitle.Size = new System.Drawing.Size(300, 48);
            this.jTitle.TabIndex = 11;
            this.jTitle.TabStop = false;
            this.jTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.jTitle.TrailingIcon = null;
            this.jTitle.UseSystemPasswordChar = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(351, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(348, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "*";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.materialCard5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1793, 63);
            this.panel1.TabIndex = 11;
            // 
            // materialCard5
            // 
            this.materialCard5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard5.Controls.Add(this.materialCard6);
            this.materialCard5.Depth = 0;
            this.materialCard5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard5.Location = new System.Drawing.Point(0, 0);
            this.materialCard5.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard5.Name = "materialCard5";
            this.materialCard5.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard5.Size = new System.Drawing.Size(1791, 61);
            this.materialCard5.TabIndex = 12;
            // 
            // materialCard6
            // 
            this.materialCard6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard6.Controls.Add(this.label1);
            this.materialCard6.Depth = 0;
            this.materialCard6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard6.Location = new System.Drawing.Point(14, 14);
            this.materialCard6.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard6.Name = "materialCard6";
            this.materialCard6.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard6.Size = new System.Drawing.Size(1763, 33);
            this.materialCard6.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1758, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "P        O        S        I        T        I        O        N                 " +
    "   M        A        N        A        G        E        M        E        N    " +
    "    T";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1086, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(809, 710);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // empPosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1793, 766);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.deleteJobBtn);
            this.Controls.Add(this.updateJobBtn);
            this.Controls.Add(this.addJobBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.jobSearchBox);
            this.Controls.Add(this.jobDgv);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "empPosition";
            this.Text = "employeePosition";
            this.Load += new System.EventHandler(this.empPosition_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jobDgv)).EndInit();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.materialCard5.ResumeLayout(false);
            this.materialCard6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView jobDgv;
        private System.Windows.Forms.TextBox jobSearchBox;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addJobBtn;
        private System.Windows.Forms.Button updateJobBtn;
        private System.Windows.Forms.Button deleteJobBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label5;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private System.Windows.Forms.Label label6;
        private MaterialSkin.Controls.MaterialTextBox2 jTitle;
        private MaterialSkin.Controls.MaterialTextBox2 jSalary;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialCard materialCard5;
        private MaterialSkin.Controls.MaterialCard materialCard6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}