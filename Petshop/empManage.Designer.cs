﻿namespace Petshop
{
    partial class empManage
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
            this.addEmp = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.endShift = new System.Windows.Forms.ComboBox();
            this.startShift = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.jobTitle = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.addMuni = new System.Windows.Forms.TextBox();
            this.addCity = new System.Windows.Forms.TextBox();
            this.addBrgy = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.eCnum = new System.Windows.Forms.TextBox();
            this.cNum = new System.Windows.Forms.TextBox();
            this.sName = new System.Windows.Forms.TextBox();
            this.fName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.updateEmp = new System.Windows.Forms.Button();
            this.deleteEmp = new System.Windows.Forms.Button();
            this.employees = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.empSearch = new System.Windows.Forms.Button();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.empSearchBox = new MaterialSkin.Controls.MaterialTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employees)).BeginInit();
            this.materialCard1.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.SuspendLayout();
            // 
            // addEmp
            // 
            this.addEmp.BackColor = System.Drawing.Color.DarkSlateGray;
            this.addEmp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addEmp.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.addEmp.Location = new System.Drawing.Point(989, 616);
            this.addEmp.Name = "addEmp";
            this.addEmp.Size = new System.Drawing.Size(230, 46);
            this.addEmp.TabIndex = 12;
            this.addEmp.Text = "Add Employee";
            this.addEmp.UseVisualStyleBackColor = false;
            this.addEmp.Click += new System.EventHandler(this.addEmp_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.endShift);
            this.groupBox1.Controls.Add(this.startShift);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.jobTitle);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.eCnum);
            this.groupBox1.Controls.Add(this.cNum);
            this.groupBox1.Controls.Add(this.sName);
            this.groupBox1.Controls.Add(this.fName);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(943, 262);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(830, 331);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Information";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(681, 187);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(17, 24);
            this.label18.TabIndex = 14;
            this.label18.Text = "-";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(796, 155);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(21, 24);
            this.label16.TabIndex = 13;
            this.label16.Text = "*";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(653, 155);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(21, 24);
            this.label15.TabIndex = 12;
            this.label15.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(701, 158);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 24);
            this.label13.TabIndex = 11;
            this.label13.Text = "Shift End";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(554, 158);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 24);
            this.label11.TabIndex = 10;
            this.label11.Text = "Shift Start";
            // 
            // endShift
            // 
            this.endShift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.endShift.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endShift.FormattingEnabled = true;
            this.endShift.Items.AddRange(new object[] {
            "End",
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday"});
            this.endShift.Location = new System.Drawing.Point(705, 185);
            this.endShift.MaxDropDownItems = 20;
            this.endShift.Name = "endShift";
            this.endShift.Size = new System.Drawing.Size(116, 32);
            this.endShift.TabIndex = 9;
            // 
            // startShift
            // 
            this.startShift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.startShift.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startShift.FormattingEnabled = true;
            this.startShift.Items.AddRange(new object[] {
            "Start",
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday"});
            this.startShift.Location = new System.Drawing.Point(558, 185);
            this.startShift.MaxDropDownItems = 20;
            this.startShift.Name = "startShift";
            this.startShift.Size = new System.Drawing.Size(116, 32);
            this.startShift.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(588, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "New employee?";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(731, 43);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(86, 22);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Click here";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // jobTitle
            // 
            this.jobTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.jobTitle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobTitle.FormattingEnabled = true;
            this.jobTitle.Items.AddRange(new object[] {
            "Select Option"});
            this.jobTitle.Location = new System.Drawing.Point(558, 108);
            this.jobTitle.MaxDropDownItems = 20;
            this.jobTitle.Name = "jobTitle";
            this.jobTitle.Size = new System.Drawing.Size(263, 32);
            this.jobTitle.TabIndex = 3;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(554, 81);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(86, 24);
            this.label20.TabIndex = 1;
            this.label20.Text = "Job Title";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.addMuni);
            this.groupBox3.Controls.Add(this.addCity);
            this.groupBox3.Controls.Add(this.addBrgy);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label28);
            this.groupBox3.Controls.Add(this.label30);
            this.groupBox3.Controls.Add(this.label31);
            this.groupBox3.Controls.Add(this.label27);
            this.groupBox3.Controls.Add(this.label29);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(129, 223);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(570, 109);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Address";
            // 
            // addMuni
            // 
            this.addMuni.Location = new System.Drawing.Point(200, 54);
            this.addMuni.Multiline = true;
            this.addMuni.Name = "addMuni";
            this.addMuni.Size = new System.Drawing.Size(173, 35);
            this.addMuni.TabIndex = 0;
            // 
            // addCity
            // 
            this.addCity.Location = new System.Drawing.Point(16, 54);
            this.addCity.Multiline = true;
            this.addCity.Name = "addCity";
            this.addCity.Size = new System.Drawing.Size(173, 35);
            this.addCity.TabIndex = 0;
            // 
            // addBrgy
            // 
            this.addBrgy.Location = new System.Drawing.Point(384, 54);
            this.addBrgy.Multiline = true;
            this.addBrgy.Name = "addBrgy";
            this.addBrgy.Size = new System.Drawing.Size(173, 35);
            this.addBrgy.TabIndex = 0;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(63, 27);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(21, 24);
            this.label17.TabIndex = 1;
            this.label17.Text = "*";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.Red;
            this.label28.Location = new System.Drawing.Point(312, 27);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(21, 24);
            this.label28.TabIndex = 1;
            this.label28.Text = "*";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.Red;
            this.label30.Location = new System.Drawing.Point(474, 27);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(21, 24);
            this.label30.TabIndex = 1;
            this.label30.Text = "*";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(380, 26);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(94, 24);
            this.label31.TabIndex = 1;
            this.label31.Text = "Barangay";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(12, 26);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(44, 24);
            this.label27.TabIndex = 1;
            this.label27.Text = "City";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(196, 26);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(115, 24);
            this.label29.TabIndex = 1;
            this.label29.Text = "Municipality";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(167, 155);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(21, 24);
            this.label14.TabIndex = 1;
            this.label14.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(282, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(258, 24);
            this.label7.TabIndex = 1;
            this.label7.Text = "Emergency Contact Number";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Red;
            this.label23.Location = new System.Drawing.Point(642, 78);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(21, 24);
            this.label23.TabIndex = 1;
            this.label23.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "Contact Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(282, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Surname";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(372, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 24);
            this.label12.TabIndex = 1;
            this.label12.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(116, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 24);
            this.label10.TabIndex = 1;
            this.label10.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(12, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 24);
            this.label9.TabIndex = 1;
            this.label9.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(34, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 24);
            this.label8.TabIndex = 1;
            this.label8.Text = "Required";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name";
            // 
            // eCnum
            // 
            this.eCnum.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eCnum.Location = new System.Drawing.Point(286, 184);
            this.eCnum.Multiline = true;
            this.eCnum.Name = "eCnum";
            this.eCnum.Size = new System.Drawing.Size(263, 35);
            this.eCnum.TabIndex = 0;
            // 
            // cNum
            // 
            this.cNum.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cNum.Location = new System.Drawing.Point(11, 184);
            this.cNum.Multiline = true;
            this.cNum.Name = "cNum";
            this.cNum.Size = new System.Drawing.Size(263, 35);
            this.cNum.TabIndex = 0;
            // 
            // sName
            // 
            this.sName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sName.Location = new System.Drawing.Point(286, 108);
            this.sName.Multiline = true;
            this.sName.Name = "sName";
            this.sName.Size = new System.Drawing.Size(263, 35);
            this.sName.TabIndex = 0;
            // 
            // fName
            // 
            this.fName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fName.Location = new System.Drawing.Point(11, 108);
            this.fName.Multiline = true;
            this.fName.Name = "fName";
            this.fName.Size = new System.Drawing.Size(263, 35);
            this.fName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employee Management";
            // 
            // updateEmp
            // 
            this.updateEmp.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.updateEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateEmp.ForeColor = System.Drawing.Color.White;
            this.updateEmp.Location = new System.Drawing.Point(1231, 616);
            this.updateEmp.Name = "updateEmp";
            this.updateEmp.Size = new System.Drawing.Size(230, 46);
            this.updateEmp.TabIndex = 13;
            this.updateEmp.Text = "Update Employee";
            this.updateEmp.UseVisualStyleBackColor = false;
            this.updateEmp.Click += new System.EventHandler(this.updateEmp_Click);
            // 
            // deleteEmp
            // 
            this.deleteEmp.BackColor = System.Drawing.Color.Red;
            this.deleteEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteEmp.ForeColor = System.Drawing.Color.White;
            this.deleteEmp.Location = new System.Drawing.Point(1478, 616);
            this.deleteEmp.Name = "deleteEmp";
            this.deleteEmp.Size = new System.Drawing.Size(230, 46);
            this.deleteEmp.TabIndex = 14;
            this.deleteEmp.Text = "Delete Employee";
            this.deleteEmp.UseVisualStyleBackColor = false;
            this.deleteEmp.Click += new System.EventHandler(this.deleteEmp_Click);
            // 
            // employees
            // 
            this.employees.AllowUserToAddRows = false;
            this.employees.AllowUserToDeleteRows = false;
            this.employees.AllowUserToResizeColumns = false;
            this.employees.AllowUserToResizeRows = false;
            this.employees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.employees.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.employees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column7,
            this.Column8,
            this.Column4,
            this.Column5});
            this.employees.Location = new System.Drawing.Point(21, 169);
            this.employees.Name = "employees";
            this.employees.ReadOnly = true;
            this.employees.RowHeadersWidth = 51;
            this.employees.RowTemplate.Height = 24;
            this.employees.Size = new System.Drawing.Size(905, 604);
            this.employees.TabIndex = 15;
            this.employees.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employees_CellClick);
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "employee_id";
            this.Column6.HeaderText = "Employee ID";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "position_desc";
            this.Column1.HeaderText = "Job Title";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "employee_fname";
            this.Column2.HeaderText = "First Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "employee_lname";
            this.Column3.HeaderText = "Last Name";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "shift_start";
            this.Column7.HeaderText = "Shift Start";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "shift_end";
            this.Column8.HeaderText = "Shift End";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "employee_cNumber";
            this.Column4.HeaderText = "Contact Number";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "employee_ecNumber";
            this.Column5.HeaderText = "Emergency Number";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Employee List";
            // 
            // empSearch
            // 
            this.empSearch.BackColor = System.Drawing.Color.DarkSlateGray;
            this.empSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.empSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empSearch.ForeColor = System.Drawing.Color.White;
            this.empSearch.Location = new System.Drawing.Point(785, 104);
            this.empSearch.Name = "empSearch";
            this.empSearch.Size = new System.Drawing.Size(141, 52);
            this.empSearch.TabIndex = 17;
            this.empSearch.Text = "Search";
            this.empSearch.UseVisualStyleBackColor = false;
            this.empSearch.Click += new System.EventHandler(this.empSearch_Click);
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.materialCard2);
            this.materialCard1.Depth = 0;
            this.materialCard1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(0, 0);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(1788, 87);
            this.materialCard1.TabIndex = 18;
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.label1);
            this.materialCard2.Depth = 0;
            this.materialCard2.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(14, 14);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(1760, 57);
            this.materialCard2.TabIndex = 18;
            // 
            // empSearchBox
            // 
            this.empSearchBox.AnimateReadOnly = false;
            this.empSearchBox.BackColor = System.Drawing.Color.CadetBlue;
            this.empSearchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.empSearchBox.Depth = 0;
            this.empSearchBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.empSearchBox.Hint = "Search";
            this.empSearchBox.LeadingIcon = null;
            this.empSearchBox.Location = new System.Drawing.Point(229, 106);
            this.empSearchBox.MaxLength = 50;
            this.empSearchBox.MouseState = MaterialSkin.MouseState.OUT;
            this.empSearchBox.Multiline = false;
            this.empSearchBox.Name = "empSearchBox";
            this.empSearchBox.Size = new System.Drawing.Size(550, 50);
            this.empSearchBox.TabIndex = 19;
            this.empSearchBox.Text = "";
            this.empSearchBox.TrailingIcon = null;
            // 
            // empManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1788, 795);
            this.Controls.Add(this.empSearchBox);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.empSearch);
            this.Controls.Add(this.deleteEmp);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.employees);
            this.Controls.Add(this.addEmp);
            this.Controls.Add(this.updateEmp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "empManage";
            this.Text = "empManage";
            this.Load += new System.EventHandler(this.empManage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employees)).EndInit();
            this.materialCard1.ResumeLayout(false);
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addEmp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox jobTitle;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox addMuni;
        private System.Windows.Forms.TextBox addCity;
        private System.Windows.Forms.TextBox addBrgy;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox eCnum;
        private System.Windows.Forms.TextBox cNum;
        private System.Windows.Forms.TextBox sName;
        private System.Windows.Forms.TextBox fName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button updateEmp;
        private System.Windows.Forms.Button deleteEmp;
        private System.Windows.Forms.DataGridView employees;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button empSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox endShift;
        private System.Windows.Forms.ComboBox startShift;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialTextBox empSearchBox;
    }
}