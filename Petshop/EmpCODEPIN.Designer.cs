namespace Petshop
{
    partial class EmpCODEPIN
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
            this.firstPin = new System.Windows.Forms.TextBox();
            this.secondPin = new System.Windows.Forms.TextBox();
            this.thirdPin = new System.Windows.Forms.TextBox();
            this.fourthPin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstPin
            // 
            this.firstPin.BackColor = System.Drawing.Color.White;
            this.firstPin.Font = new System.Drawing.Font("Tahoma", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstPin.Location = new System.Drawing.Point(61, 112);
            this.firstPin.MaxLength = 1;
            this.firstPin.Multiline = true;
            this.firstPin.Name = "firstPin";
            this.firstPin.PasswordChar = '*';
            this.firstPin.Size = new System.Drawing.Size(106, 138);
            this.firstPin.TabIndex = 0;
            this.firstPin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.firstPin.TextChanged += new System.EventHandler(this.firstPin_TextChanged);
            // 
            // secondPin
            // 
            this.secondPin.BackColor = System.Drawing.Color.White;
            this.secondPin.Font = new System.Drawing.Font("Tahoma", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondPin.Location = new System.Drawing.Point(207, 112);
            this.secondPin.MaxLength = 1;
            this.secondPin.Multiline = true;
            this.secondPin.Name = "secondPin";
            this.secondPin.PasswordChar = '*';
            this.secondPin.Size = new System.Drawing.Size(106, 138);
            this.secondPin.TabIndex = 1;
            this.secondPin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.secondPin.TextChanged += new System.EventHandler(this.secondPin_TextChanged);
            this.secondPin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.secondPin_KeyPress);
            // 
            // thirdPin
            // 
            this.thirdPin.BackColor = System.Drawing.Color.White;
            this.thirdPin.Font = new System.Drawing.Font("Tahoma", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thirdPin.Location = new System.Drawing.Point(353, 112);
            this.thirdPin.MaxLength = 1;
            this.thirdPin.Multiline = true;
            this.thirdPin.Name = "thirdPin";
            this.thirdPin.PasswordChar = '*';
            this.thirdPin.Size = new System.Drawing.Size(106, 138);
            this.thirdPin.TabIndex = 2;
            this.thirdPin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.thirdPin.TextChanged += new System.EventHandler(this.thirdPin_TextChanged);
            this.thirdPin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.thirdPin_KeyPress);
            // 
            // fourthPin
            // 
            this.fourthPin.BackColor = System.Drawing.Color.White;
            this.fourthPin.Font = new System.Drawing.Font("Tahoma", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fourthPin.Location = new System.Drawing.Point(499, 112);
            this.fourthPin.MaxLength = 1;
            this.fourthPin.Multiline = true;
            this.fourthPin.Name = "fourthPin";
            this.fourthPin.PasswordChar = '*';
            this.fourthPin.Size = new System.Drawing.Size(106, 138);
            this.fourthPin.TabIndex = 3;
            this.fourthPin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fourthPin.TextChanged += new System.EventHandler(this.fourthPin_TextChanged);
            this.fourthPin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fourthPin_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "LOG-IN PIN";
            // 
            // EmpCODEPIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(686, 324);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fourthPin);
            this.Controls.Add(this.thirdPin);
            this.Controls.Add(this.secondPin);
            this.Controls.Add(this.firstPin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmpCODEPIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmpCODEPIN";
            this.Load += new System.EventHandler(this.EmpCODEPIN_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox firstPin;
        private System.Windows.Forms.TextBox secondPin;
        private System.Windows.Forms.TextBox thirdPin;
        private System.Windows.Forms.TextBox fourthPin;
        private System.Windows.Forms.Label label1;
    }
}