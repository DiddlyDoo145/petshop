namespace Petshop
{
    partial class empAttendanceRecord
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
            this.records = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reload = new System.Windows.Forms.Button();
            this.specificDate = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialCard5 = new MaterialSkin.Controls.MaterialCard();
            this.materialCard6 = new MaterialSkin.Controls.MaterialCard();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.records)).BeginInit();
            this.panel1.SuspendLayout();
            this.materialCard5.SuspendLayout();
            this.materialCard6.SuspendLayout();
            this.SuspendLayout();
            // 
            // records
            // 
            this.records.AllowUserToAddRows = false;
            this.records.AllowUserToDeleteRows = false;
            this.records.AllowUserToResizeColumns = false;
            this.records.AllowUserToResizeRows = false;
            this.records.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.records.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.records.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4,
            this.Column2,
            this.Column3});
            this.records.Location = new System.Drawing.Point(55, 152);
            this.records.Name = "records";
            this.records.ReadOnly = true;
            this.records.RowHeadersVisible = false;
            this.records.RowHeadersWidth = 51;
            this.records.RowTemplate.Height = 24;
            this.records.Size = new System.Drawing.Size(1674, 592);
            this.records.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "employee_fname";
            this.Column1.HeaderText = "Employee First Name";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "employee_lname";
            this.Column4.HeaderText = "Employee Last Name";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "attendance_date";
            this.Column2.HeaderText = "Attendance Date";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "attendance_status";
            this.Column3.HeaderText = "Status";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // reload
            // 
            this.reload.BackColor = System.Drawing.Color.SeaGreen;
            this.reload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reload.ForeColor = System.Drawing.Color.White;
            this.reload.Location = new System.Drawing.Point(1602, 116);
            this.reload.Name = "reload";
            this.reload.Size = new System.Drawing.Size(127, 33);
            this.reload.TabIndex = 3;
            this.reload.Text = "Reload";
            this.reload.UseVisualStyleBackColor = false;
            this.reload.Click += new System.EventHandler(this.reload_Click);
            // 
            // specificDate
            // 
            this.specificDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.specificDate.Location = new System.Drawing.Point(55, 125);
            this.specificDate.Name = "specificDate";
            this.specificDate.Size = new System.Drawing.Size(106, 22);
            this.specificDate.TabIndex = 4;
            this.specificDate.ValueChanged += new System.EventHandler(this.specificDate_ValueChanged);
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
            this.panel1.TabIndex = 20;
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
            this.label1.TabIndex = 4;
            this.label1.Text = "A        T        T        E        N        D        A        N        C        " +
    "E                    R        E        C        O        R        D";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // empAttendanceRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1793, 766);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.specificDate);
            this.Controls.Add(this.reload);
            this.Controls.Add(this.records);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "empAttendanceRecord";
            this.Text = "empAttendanceRecord";
            this.Load += new System.EventHandler(this.empAttendanceRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.records)).EndInit();
            this.panel1.ResumeLayout(false);
            this.materialCard5.ResumeLayout(false);
            this.materialCard6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView records;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button reload;
        private System.Windows.Forms.DateTimePicker specificDate;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialCard materialCard5;
        private MaterialSkin.Controls.MaterialCard materialCard6;
        private System.Windows.Forms.Label label1;
    }
}