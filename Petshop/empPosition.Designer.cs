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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.jobSalary = new System.Windows.Forms.TextBox();
            this.jobTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jobDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1805, 65);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Manage Position";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.jobSalary);
            this.groupBox1.Controls.Add(this.jobTitle);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(965, 280);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(724, 166);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Position Information";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(15, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 24);
            this.label9.TabIndex = 2;
            this.label9.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(390, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Job Salary";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(37, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 24);
            this.label8.TabIndex = 3;
            this.label8.Text = "Required";
            // 
            // jobSalary
            // 
            this.jobSalary.Location = new System.Drawing.Point(394, 105);
            this.jobSalary.Name = "jobSalary";
            this.jobSalary.Size = new System.Drawing.Size(297, 40);
            this.jobSalary.TabIndex = 2;
            // 
            // jobTitle
            // 
            this.jobTitle.Location = new System.Drawing.Point(41, 105);
            this.jobTitle.Name = "jobTitle";
            this.jobTitle.Size = new System.Drawing.Size(297, 40);
            this.jobTitle.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Job Title";
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
            this.jobDgv.Location = new System.Drawing.Point(204, 168);
            this.jobDgv.Name = "jobDgv";
            this.jobDgv.ReadOnly = true;
            this.jobDgv.RowHeadersWidth = 51;
            this.jobDgv.RowTemplate.Height = 24;
            this.jobDgv.Size = new System.Drawing.Size(620, 579);
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
            this.jobSearchBox.Location = new System.Drawing.Point(340, 130);
            this.jobSearchBox.Name = "jobSearchBox";
            this.jobSearchBox.Size = new System.Drawing.Size(337, 32);
            this.jobSearchBox.TabIndex = 4;
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.RosyBrown;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Location = new System.Drawing.Point(683, 130);
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
            this.label4.Location = new System.Drawing.Point(204, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Job List";
            // 
            // addJobBtn
            // 
            this.addJobBtn.BackColor = System.Drawing.Color.RosyBrown;
            this.addJobBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addJobBtn.Location = new System.Drawing.Point(995, 463);
            this.addJobBtn.Name = "addJobBtn";
            this.addJobBtn.Size = new System.Drawing.Size(209, 53);
            this.addJobBtn.TabIndex = 6;
            this.addJobBtn.Text = "Add Job";
            this.addJobBtn.UseVisualStyleBackColor = false;
            this.addJobBtn.Click += new System.EventHandler(this.addJobBtn_Click);
            // 
            // updateJobBtn
            // 
            this.updateJobBtn.BackColor = System.Drawing.Color.RosyBrown;
            this.updateJobBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateJobBtn.Location = new System.Drawing.Point(1228, 463);
            this.updateJobBtn.Name = "updateJobBtn";
            this.updateJobBtn.Size = new System.Drawing.Size(209, 53);
            this.updateJobBtn.TabIndex = 7;
            this.updateJobBtn.Text = "Update Job";
            this.updateJobBtn.UseVisualStyleBackColor = false;
            this.updateJobBtn.Click += new System.EventHandler(this.updateJobBtn_Click);
            // 
            // deleteJobBtn
            // 
            this.deleteJobBtn.BackColor = System.Drawing.Color.RosyBrown;
            this.deleteJobBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteJobBtn.Location = new System.Drawing.Point(1458, 463);
            this.deleteJobBtn.Name = "deleteJobBtn";
            this.deleteJobBtn.Size = new System.Drawing.Size(209, 53);
            this.deleteJobBtn.TabIndex = 8;
            this.deleteJobBtn.Text = "Delete Job";
            this.deleteJobBtn.UseVisualStyleBackColor = false;
            this.deleteJobBtn.Click += new System.EventHandler(this.deleteJobBtn_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(605, 38);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(86, 22);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Click here";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(516, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "New job?";
            // 
            // empPosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1805, 858);
            this.Controls.Add(this.deleteJobBtn);
            this.Controls.Add(this.updateJobBtn);
            this.Controls.Add(this.addJobBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.jobSearchBox);
            this.Controls.Add(this.jobDgv);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "empPosition";
            this.Text = "employeePosition";
            this.Load += new System.EventHandler(this.empPosition_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jobDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox jobSalary;
        private System.Windows.Forms.TextBox jobTitle;
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
    }
}