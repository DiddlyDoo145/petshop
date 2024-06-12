namespace Petshop
{
    partial class Employee
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.recordBtn = new System.Windows.Forms.Button();
            this.positionMngmntBtn = new System.Windows.Forms.Button();
            this.payrollBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.attendanceBtn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label26 = new System.Windows.Forms.Label();
            this.oT = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.oT);
            this.panel2.Controls.Add(this.recordBtn);
            this.panel2.Controls.Add(this.attendanceBtn);
            this.panel2.Controls.Add(this.positionMngmntBtn);
            this.panel2.Controls.Add(this.payrollBtn);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1796, 75);
            this.panel2.TabIndex = 7;
            // 
            // recordBtn
            // 
            this.recordBtn.Location = new System.Drawing.Point(1196, 3);
            this.recordBtn.Name = "recordBtn";
            this.recordBtn.Size = new System.Drawing.Size(290, 66);
            this.recordBtn.TabIndex = 10;
            this.recordBtn.Text = "Attendance Records";
            this.recordBtn.UseVisualStyleBackColor = true;
            this.recordBtn.Click += new System.EventHandler(this.recordBtn_Click);
            // 
            // positionMngmntBtn
            // 
            this.positionMngmntBtn.Location = new System.Drawing.Point(900, 3);
            this.positionMngmntBtn.Name = "positionMngmntBtn";
            this.positionMngmntBtn.Size = new System.Drawing.Size(290, 66);
            this.positionMngmntBtn.TabIndex = 9;
            this.positionMngmntBtn.Text = "Manage Position";
            this.positionMngmntBtn.UseVisualStyleBackColor = true;
            this.positionMngmntBtn.Click += new System.EventHandler(this.positionMngmntBtn_Click);
            // 
            // payrollBtn
            // 
            this.payrollBtn.Location = new System.Drawing.Point(308, 3);
            this.payrollBtn.Name = "payrollBtn";
            this.payrollBtn.Size = new System.Drawing.Size(290, 66);
            this.payrollBtn.TabIndex = 8;
            this.payrollBtn.Text = "Payroll";
            this.payrollBtn.UseVisualStyleBackColor = true;
            this.payrollBtn.Click += new System.EventHandler(this.payrollBtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(604, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(290, 66);
            this.button2.TabIndex = 6;
            this.button2.Text = "MANAGE EMPLOYEE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // attendanceBtn
            // 
            this.attendanceBtn.Location = new System.Drawing.Point(12, 3);
            this.attendanceBtn.Name = "attendanceBtn";
            this.attendanceBtn.Size = new System.Drawing.Size(290, 66);
            this.attendanceBtn.TabIndex = 7;
            this.attendanceBtn.Text = "Attendance";
            this.attendanceBtn.UseVisualStyleBackColor = true;
            this.attendanceBtn.Click += new System.EventHandler(this.attendanceBtn_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(78)))), ((int)(((byte)(128)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label26);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1796, 57);
            this.panel4.TabIndex = 6;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.label26.Location = new System.Drawing.Point(19, 8);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(354, 40);
            this.label26.TabIndex = 2;
            this.label26.Text = "Employee Management";
            // 
            // oT
            // 
            this.oT.Location = new System.Drawing.Point(1492, 3);
            this.oT.Name = "oT";
            this.oT.Size = new System.Drawing.Size(290, 66);
            this.oT.TabIndex = 11;
            this.oT.Text = "Salary Management";
            this.oT.UseVisualStyleBackColor = true;
            this.oT.Click += new System.EventHandler(this.oT_Click);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1796, 965);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button attendanceBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button positionMngmntBtn;
        private System.Windows.Forms.Button payrollBtn;
        private System.Windows.Forms.Button recordBtn;
        private System.Windows.Forms.Button oT;
    }
}