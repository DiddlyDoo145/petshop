namespace Petshop
{
    partial class attendance
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(attendance));
            this.absent = new System.Windows.Forms.Button();
            this.present = new System.Windows.Forms.Button();
            this.empId = new System.Windows.Forms.Label();
            this.empDesc = new System.Windows.Forms.Label();
            this.empName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.empNo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // absent
            // 
            this.absent.BackColor = System.Drawing.Color.Red;
            this.absent.Font = new System.Drawing.Font("Yu Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.absent.ForeColor = System.Drawing.Color.White;
            this.absent.Location = new System.Drawing.Point(391, 178);
            this.absent.Name = "absent";
            this.absent.Size = new System.Drawing.Size(123, 42);
            this.absent.TabIndex = 9;
            this.absent.Text = "Absent";
            this.absent.UseVisualStyleBackColor = false;
            this.absent.Click += new System.EventHandler(this.absent_Click);
            // 
            // present
            // 
            this.present.BackColor = System.Drawing.Color.ForestGreen;
            this.present.Font = new System.Drawing.Font("Yu Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.present.ForeColor = System.Drawing.Color.White;
            this.present.Location = new System.Drawing.Point(262, 178);
            this.present.Name = "present";
            this.present.Size = new System.Drawing.Size(123, 42);
            this.present.TabIndex = 8;
            this.present.Text = "Present";
            this.present.UseVisualStyleBackColor = false;
            this.present.Click += new System.EventHandler(this.present_Click);
            // 
            // empId
            // 
            this.empId.AutoSize = true;
            this.empId.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empId.ForeColor = System.Drawing.Color.Black;
            this.empId.Location = new System.Drawing.Point(448, 0);
            this.empId.Name = "empId";
            this.empId.Size = new System.Drawing.Size(22, 20);
            this.empId.TabIndex = 5;
            this.empId.Text = "id";
            this.empId.Visible = false;
            // 
            // empDesc
            // 
            this.empDesc.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empDesc.ForeColor = System.Drawing.Color.Black;
            this.empDesc.Location = new System.Drawing.Point(315, 98);
            this.empDesc.Name = "empDesc";
            this.empDesc.Size = new System.Drawing.Size(214, 28);
            this.empDesc.TabIndex = 6;
            this.empDesc.Text = "Position";
            // 
            // empName
            // 
            this.empName.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empName.ForeColor = System.Drawing.Color.Black;
            this.empName.Location = new System.Drawing.Point(242, 63);
            this.empName.Name = "empName";
            this.empName.Size = new System.Drawing.Size(269, 37);
            this.empName.TabIndex = 7;
            this.empName.Text = "Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 207);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // empNo
            // 
            this.empNo.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empNo.ForeColor = System.Drawing.Color.Black;
            this.empNo.Location = new System.Drawing.Point(388, 126);
            this.empNo.Name = "empNo";
            this.empNo.Size = new System.Drawing.Size(137, 28);
            this.empNo.TabIndex = 11;
            this.empNo.Text = "Position";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(228, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 28);
            this.label1.TabIndex = 12;
            this.label1.Text = "Job Title:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(228, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 28);
            this.label2.TabIndex = 13;
            this.label2.Text = "Contact Number:";
            // 
            // attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.empNo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.absent);
            this.Controls.Add(this.present);
            this.Controls.Add(this.empId);
            this.Controls.Add(this.empDesc);
            this.Controls.Add(this.empName);
            this.Name = "attendance";
            this.Size = new System.Drawing.Size(552, 240);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button absent;
        private System.Windows.Forms.Button present;
        private System.Windows.Forms.Label empId;
        private System.Windows.Forms.Label empDesc;
        private System.Windows.Forms.Label empName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label empNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
