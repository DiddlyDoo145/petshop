namespace Petshop
{
    partial class empAttendance
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
            this.attendanceFl = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialCard5 = new MaterialSkin.Controls.MaterialCard();
            this.materialCard6 = new MaterialSkin.Controls.MaterialCard();
            this.label1 = new System.Windows.Forms.Label();
            this.employeeComplete = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.materialCard5.SuspendLayout();
            this.materialCard6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeComplete)).BeginInit();
            this.SuspendLayout();
            // 
            // attendanceFl
            // 
            this.attendanceFl.AutoScroll = true;
            this.attendanceFl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.attendanceFl.Location = new System.Drawing.Point(19, 106);
            this.attendanceFl.Name = "attendanceFl";
            this.attendanceFl.Size = new System.Drawing.Size(1145, 627);
            this.attendanceFl.TabIndex = 3;
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
            this.panel1.TabIndex = 19;
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
            this.label1.Location = new System.Drawing.Point(2, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1758, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "E        M        P        L        O        Y        E        E                 " +
    "   A        T        T        E        N        D        A        N        C    " +
    "    E";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // employeeComplete
            // 
            this.employeeComplete.AllowUserToAddRows = false;
            this.employeeComplete.AllowUserToDeleteRows = false;
            this.employeeComplete.AllowUserToResizeRows = false;
            this.employeeComplete.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.employeeComplete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeComplete.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.employeeComplete.Location = new System.Drawing.Point(1185, 106);
            this.employeeComplete.Name = "employeeComplete";
            this.employeeComplete.ReadOnly = true;
            this.employeeComplete.RowHeadersVisible = false;
            this.employeeComplete.RowHeadersWidth = 51;
            this.employeeComplete.RowTemplate.Height = 24;
            this.employeeComplete.Size = new System.Drawing.Size(598, 627);
            this.employeeComplete.TabIndex = 20;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Job Title";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "First Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Last Name";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Shift Start";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Shift End";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Contact Number";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // empAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1793, 766);
            this.Controls.Add(this.employeeComplete);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.attendanceFl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "empAttendance";
            this.Text = "empOne";
            this.Load += new System.EventHandler(this.empOne_Load);
            this.panel1.ResumeLayout(false);
            this.materialCard5.ResumeLayout(false);
            this.materialCard6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employeeComplete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel attendanceFl;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialCard materialCard5;
        private MaterialSkin.Controls.MaterialCard materialCard6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView employeeComplete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}