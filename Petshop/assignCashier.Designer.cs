namespace Petshop
{
    partial class assignCashier
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
            this.employeeCb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // employeeCb
            // 
            this.employeeCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.employeeCb.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeCb.FormattingEnabled = true;
            this.employeeCb.Items.AddRange(new object[] {
            "Select Cashier"});
            this.employeeCb.Location = new System.Drawing.Point(153, 90);
            this.employeeCb.Name = "employeeCb";
            this.employeeCb.Size = new System.Drawing.Size(168, 36);
            this.employeeCb.TabIndex = 0;
            this.employeeCb.SelectedIndexChanged += new System.EventHandler(this.employeeCb_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Assign Cashier";
            // 
            // assignCashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 195);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.employeeCb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "assignCashier";
            this.Text = "assignCashier";
            this.Load += new System.EventHandler(this.assignCashier_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox employeeCb;
        private System.Windows.Forms.Label label1;
    }
}