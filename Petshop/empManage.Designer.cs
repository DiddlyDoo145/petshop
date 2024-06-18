namespace Petshop
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
            this.label18 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.endShift = new System.Windows.Forms.ComboBox();
            this.startShift = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.jobTitle = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
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
            this.empSearchBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.empSearch = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialCard5 = new MaterialSkin.Controls.MaterialCard();
            this.materialCard6 = new MaterialSkin.Controls.MaterialCard();
            this.label1 = new System.Windows.Forms.Label();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.label19 = new System.Windows.Forms.Label();
            this.firstName = new MaterialSkin.Controls.MaterialTextBox2();
            this.lastName = new MaterialSkin.Controls.MaterialTextBox2();
            this.contactNumber = new MaterialSkin.Controls.MaterialTextBox2();
            this.emergencyNumber = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.materialCard4 = new MaterialSkin.Controls.MaterialCard();
            this.label2 = new System.Windows.Forms.Label();
            this.newCity = new MaterialSkin.Controls.MaterialTextBox2();
            this.newMunicipality = new MaterialSkin.Controls.MaterialTextBox2();
            this.newBarangay = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialCard7 = new MaterialSkin.Controls.MaterialCard();
            ((System.ComponentModel.ISupportInitialize)(this.employees)).BeginInit();
            this.panel1.SuspendLayout();
            this.materialCard5.SuspendLayout();
            this.materialCard6.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.materialCard4.SuspendLayout();
            this.materialCard7.SuspendLayout();
            this.SuspendLayout();
            // 
            // addEmp
            // 
            this.addEmp.BackColor = System.Drawing.Color.SteelBlue;
            this.addEmp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addEmp.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.addEmp.Location = new System.Drawing.Point(928, 671);
            this.addEmp.Name = "addEmp";
            this.addEmp.Size = new System.Drawing.Size(275, 56);
            this.addEmp.TabIndex = 12;
            this.addEmp.Text = "Add Employee";
            this.addEmp.UseVisualStyleBackColor = false;
            this.addEmp.Click += new System.EventHandler(this.addEmp_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(679, 198);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(17, 24);
            this.label18.TabIndex = 14;
            this.label18.Text = "-";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(714, 165);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 24);
            this.label13.TabIndex = 11;
            this.label13.Text = "Shift End";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(566, 165);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 24);
            this.label11.TabIndex = 10;
            this.label11.Text = "Shift Start";
            // 
            // endShift
            // 
            this.endShift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.endShift.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.endShift.Location = new System.Drawing.Point(705, 194);
            this.endShift.MaxDropDownItems = 20;
            this.endShift.Name = "endShift";
            this.endShift.Size = new System.Drawing.Size(111, 36);
            this.endShift.TabIndex = 9;
            // 
            // startShift
            // 
            this.startShift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.startShift.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.startShift.Location = new System.Drawing.Point(567, 194);
            this.startShift.MaxDropDownItems = 20;
            this.startShift.Name = "startShift";
            this.startShift.Size = new System.Drawing.Size(102, 36);
            this.startShift.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(562, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "New employee?";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(723, 71);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(92, 21);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Click here";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // jobTitle
            // 
            this.jobTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.jobTitle.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobTitle.FormattingEnabled = true;
            this.jobTitle.Items.AddRange(new object[] {
            "Select Option"});
            this.jobTitle.Location = new System.Drawing.Point(286, 194);
            this.jobTitle.MaxDropDownItems = 20;
            this.jobTitle.Name = "jobTitle";
            this.jobTitle.Size = new System.Drawing.Size(254, 36);
            this.jobTitle.TabIndex = 3;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(285, 165);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(86, 24);
            this.label20.TabIndex = 1;
            this.label20.Text = "Job Title";
            // 
            // updateEmp
            // 
            this.updateEmp.BackColor = System.Drawing.Color.Coral;
            this.updateEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateEmp.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateEmp.ForeColor = System.Drawing.Color.White;
            this.updateEmp.Location = new System.Drawing.Point(1218, 671);
            this.updateEmp.Name = "updateEmp";
            this.updateEmp.Size = new System.Drawing.Size(275, 56);
            this.updateEmp.TabIndex = 13;
            this.updateEmp.Text = "Update Employee";
            this.updateEmp.UseVisualStyleBackColor = false;
            this.updateEmp.Click += new System.EventHandler(this.updateEmp_Click);
            // 
            // deleteEmp
            // 
            this.deleteEmp.BackColor = System.Drawing.Color.Red;
            this.deleteEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteEmp.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteEmp.ForeColor = System.Drawing.Color.White;
            this.deleteEmp.Location = new System.Drawing.Point(1508, 671);
            this.deleteEmp.Name = "deleteEmp";
            this.deleteEmp.Size = new System.Drawing.Size(275, 56);
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
            this.employees.Location = new System.Drawing.Point(16, 154);
            this.employees.Name = "employees";
            this.employees.ReadOnly = true;
            this.employees.RowHeadersWidth = 51;
            this.employees.RowTemplate.Height = 24;
            this.employees.Size = new System.Drawing.Size(905, 600);
            this.employees.TabIndex = 15;
            this.employees.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employees_CellClick);
            this.employees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employees_CellContentClick);
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
            // empSearchBox
            // 
            this.empSearchBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empSearchBox.Location = new System.Drawing.Point(234, 116);
            this.empSearchBox.Name = "empSearchBox";
            this.empSearchBox.Size = new System.Drawing.Size(553, 32);
            this.empSearchBox.TabIndex = 16;
            this.empSearchBox.TextChanged += new System.EventHandler(this.empSearchBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Employee List";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // empSearch
            // 
            this.empSearch.BackColor = System.Drawing.Color.DarkSlateGray;
            this.empSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.empSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empSearch.ForeColor = System.Drawing.Color.White;
            this.empSearch.Location = new System.Drawing.Point(793, 116);
            this.empSearch.Name = "empSearch";
            this.empSearch.Size = new System.Drawing.Size(128, 32);
            this.empSearch.TabIndex = 17;
            this.empSearch.Text = "Search";
            this.empSearch.UseVisualStyleBackColor = false;
            this.empSearch.Click += new System.EventHandler(this.empSearch_Click);
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
            this.panel1.TabIndex = 18;
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
            this.label1.Text = "E        M        P        L        O        Y        E        E                 " +
    "   M        A        N        A        G        E        M        E        N    " +
    "    T";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.label18);
            this.materialCard1.Controls.Add(this.emergencyNumber);
            this.materialCard1.Controls.Add(this.label5);
            this.materialCard1.Controls.Add(this.linkLabel1);
            this.materialCard1.Controls.Add(this.label13);
            this.materialCard1.Controls.Add(this.contactNumber);
            this.materialCard1.Controls.Add(this.label11);
            this.materialCard1.Controls.Add(this.lastName);
            this.materialCard1.Controls.Add(this.firstName);
            this.materialCard1.Controls.Add(this.materialCard2);
            this.materialCard1.Controls.Add(this.label20);
            this.materialCard1.Controls.Add(this.endShift);
            this.materialCard1.Controls.Add(this.startShift);
            this.materialCard1.Controls.Add(this.jobTitle);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(13, 16);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(830, 261);
            this.materialCard1.TabIndex = 19;
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.label19);
            this.materialCard2.Depth = 0;
            this.materialCard2.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(14, 14);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(802, 51);
            this.materialCard2.TabIndex = 0;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(12, 11);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(222, 28);
            this.label19.TabIndex = 1;
            this.label19.Text = "Personal Information";
            // 
            // firstName
            // 
            this.firstName.AnimateReadOnly = false;
            this.firstName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.firstName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.firstName.Depth = 0;
            this.firstName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.firstName.HideSelection = true;
            this.firstName.Hint = "First Name";
            this.firstName.LeadingIcon = null;
            this.firstName.Location = new System.Drawing.Point(16, 102);
            this.firstName.MaxLength = 32767;
            this.firstName.MouseState = MaterialSkin.MouseState.OUT;
            this.firstName.Name = "firstName";
            this.firstName.PasswordChar = '\0';
            this.firstName.PrefixSuffixText = null;
            this.firstName.ReadOnly = false;
            this.firstName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.firstName.SelectedText = "";
            this.firstName.SelectionLength = 0;
            this.firstName.SelectionStart = 0;
            this.firstName.ShortcutsEnabled = true;
            this.firstName.Size = new System.Drawing.Size(250, 48);
            this.firstName.TabIndex = 1;
            this.firstName.TabStop = false;
            this.firstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.firstName.TrailingIcon = null;
            this.firstName.UseSystemPasswordChar = false;
            // 
            // lastName
            // 
            this.lastName.AnimateReadOnly = false;
            this.lastName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.lastName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.lastName.Depth = 0;
            this.lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lastName.HideSelection = true;
            this.lastName.Hint = "Last Name";
            this.lastName.LeadingIcon = null;
            this.lastName.Location = new System.Drawing.Point(289, 102);
            this.lastName.MaxLength = 32767;
            this.lastName.MouseState = MaterialSkin.MouseState.OUT;
            this.lastName.Name = "lastName";
            this.lastName.PasswordChar = '\0';
            this.lastName.PrefixSuffixText = null;
            this.lastName.ReadOnly = false;
            this.lastName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lastName.SelectedText = "";
            this.lastName.SelectionLength = 0;
            this.lastName.SelectionStart = 0;
            this.lastName.ShortcutsEnabled = true;
            this.lastName.Size = new System.Drawing.Size(250, 48);
            this.lastName.TabIndex = 1;
            this.lastName.TabStop = false;
            this.lastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.lastName.TrailingIcon = null;
            this.lastName.UseSystemPasswordChar = false;
            // 
            // contactNumber
            // 
            this.contactNumber.AnimateReadOnly = false;
            this.contactNumber.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.contactNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.contactNumber.Depth = 0;
            this.contactNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.contactNumber.HideSelection = true;
            this.contactNumber.Hint = "Contact Number";
            this.contactNumber.LeadingIcon = null;
            this.contactNumber.Location = new System.Drawing.Point(567, 102);
            this.contactNumber.MaxLength = 32767;
            this.contactNumber.MouseState = MaterialSkin.MouseState.OUT;
            this.contactNumber.Name = "contactNumber";
            this.contactNumber.PasswordChar = '\0';
            this.contactNumber.PrefixSuffixText = null;
            this.contactNumber.ReadOnly = false;
            this.contactNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.contactNumber.SelectedText = "";
            this.contactNumber.SelectionLength = 0;
            this.contactNumber.SelectionStart = 0;
            this.contactNumber.ShortcutsEnabled = true;
            this.contactNumber.Size = new System.Drawing.Size(250, 48);
            this.contactNumber.TabIndex = 1;
            this.contactNumber.TabStop = false;
            this.contactNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.contactNumber.TrailingIcon = null;
            this.contactNumber.UseSystemPasswordChar = false;
            // 
            // emergencyNumber
            // 
            this.emergencyNumber.AnimateReadOnly = false;
            this.emergencyNumber.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.emergencyNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.emergencyNumber.Depth = 0;
            this.emergencyNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.emergencyNumber.HideSelection = true;
            this.emergencyNumber.Hint = "Emergency Number";
            this.emergencyNumber.LeadingIcon = null;
            this.emergencyNumber.Location = new System.Drawing.Point(16, 183);
            this.emergencyNumber.MaxLength = 32767;
            this.emergencyNumber.MouseState = MaterialSkin.MouseState.OUT;
            this.emergencyNumber.Name = "emergencyNumber";
            this.emergencyNumber.PasswordChar = '\0';
            this.emergencyNumber.PrefixSuffixText = null;
            this.emergencyNumber.ReadOnly = false;
            this.emergencyNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.emergencyNumber.SelectedText = "";
            this.emergencyNumber.SelectionLength = 0;
            this.emergencyNumber.SelectionStart = 0;
            this.emergencyNumber.ShortcutsEnabled = true;
            this.emergencyNumber.Size = new System.Drawing.Size(250, 48);
            this.emergencyNumber.TabIndex = 1;
            this.emergencyNumber.TabStop = false;
            this.emergencyNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.emergencyNumber.TrailingIcon = null;
            this.emergencyNumber.UseSystemPasswordChar = false;
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.materialCard4);
            this.materialCard3.Controls.Add(this.newBarangay);
            this.materialCard3.Controls.Add(this.newMunicipality);
            this.materialCard3.Controls.Add(this.newCity);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(13, 295);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(833, 168);
            this.materialCard3.TabIndex = 20;
            // 
            // materialCard4
            // 
            this.materialCard4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard4.Controls.Add(this.label2);
            this.materialCard4.Depth = 0;
            this.materialCard4.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialCard4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard4.Location = new System.Drawing.Point(14, 14);
            this.materialCard4.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard4.Name = "materialCard4";
            this.materialCard4.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard4.Size = new System.Drawing.Size(805, 51);
            this.materialCard4.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address Information";
            // 
            // newCity
            // 
            this.newCity.AnimateReadOnly = false;
            this.newCity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.newCity.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.newCity.Depth = 0;
            this.newCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.newCity.HideSelection = true;
            this.newCity.Hint = "City Address";
            this.newCity.LeadingIcon = null;
            this.newCity.Location = new System.Drawing.Point(16, 92);
            this.newCity.MaxLength = 32767;
            this.newCity.MouseState = MaterialSkin.MouseState.OUT;
            this.newCity.Name = "newCity";
            this.newCity.PasswordChar = '\0';
            this.newCity.PrefixSuffixText = null;
            this.newCity.ReadOnly = false;
            this.newCity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.newCity.SelectedText = "";
            this.newCity.SelectionLength = 0;
            this.newCity.SelectionStart = 0;
            this.newCity.ShortcutsEnabled = true;
            this.newCity.Size = new System.Drawing.Size(250, 48);
            this.newCity.TabIndex = 1;
            this.newCity.TabStop = false;
            this.newCity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.newCity.TrailingIcon = null;
            this.newCity.UseSystemPasswordChar = false;
            // 
            // newMunicipality
            // 
            this.newMunicipality.AnimateReadOnly = false;
            this.newMunicipality.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.newMunicipality.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.newMunicipality.Depth = 0;
            this.newMunicipality.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.newMunicipality.HideSelection = true;
            this.newMunicipality.Hint = "Municipality Address";
            this.newMunicipality.LeadingIcon = null;
            this.newMunicipality.Location = new System.Drawing.Point(290, 92);
            this.newMunicipality.MaxLength = 32767;
            this.newMunicipality.MouseState = MaterialSkin.MouseState.OUT;
            this.newMunicipality.Name = "newMunicipality";
            this.newMunicipality.PasswordChar = '\0';
            this.newMunicipality.PrefixSuffixText = null;
            this.newMunicipality.ReadOnly = false;
            this.newMunicipality.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.newMunicipality.SelectedText = "";
            this.newMunicipality.SelectionLength = 0;
            this.newMunicipality.SelectionStart = 0;
            this.newMunicipality.ShortcutsEnabled = true;
            this.newMunicipality.Size = new System.Drawing.Size(250, 48);
            this.newMunicipality.TabIndex = 1;
            this.newMunicipality.TabStop = false;
            this.newMunicipality.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.newMunicipality.TrailingIcon = null;
            this.newMunicipality.UseSystemPasswordChar = false;
            // 
            // newBarangay
            // 
            this.newBarangay.AnimateReadOnly = false;
            this.newBarangay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.newBarangay.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.newBarangay.Depth = 0;
            this.newBarangay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.newBarangay.HideSelection = true;
            this.newBarangay.Hint = "Barangay Address";
            this.newBarangay.LeadingIcon = null;
            this.newBarangay.Location = new System.Drawing.Point(567, 92);
            this.newBarangay.MaxLength = 32767;
            this.newBarangay.MouseState = MaterialSkin.MouseState.OUT;
            this.newBarangay.Name = "newBarangay";
            this.newBarangay.PasswordChar = '\0';
            this.newBarangay.PrefixSuffixText = null;
            this.newBarangay.ReadOnly = false;
            this.newBarangay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.newBarangay.SelectedText = "";
            this.newBarangay.SelectionLength = 0;
            this.newBarangay.SelectionStart = 0;
            this.newBarangay.ShortcutsEnabled = true;
            this.newBarangay.Size = new System.Drawing.Size(250, 48);
            this.newBarangay.TabIndex = 1;
            this.newBarangay.TabStop = false;
            this.newBarangay.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.newBarangay.TrailingIcon = null;
            this.newBarangay.UseSystemPasswordChar = false;
            // 
            // materialCard7
            // 
            this.materialCard7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard7.Controls.Add(this.materialCard1);
            this.materialCard7.Controls.Add(this.materialCard3);
            this.materialCard7.Depth = 0;
            this.materialCard7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard7.Location = new System.Drawing.Point(929, 181);
            this.materialCard7.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard7.Name = "materialCard7";
            this.materialCard7.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard7.Size = new System.Drawing.Size(856, 479);
            this.materialCard7.TabIndex = 21;
            // 
            // empManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1793, 766);
            this.Controls.Add(this.materialCard7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.empSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.empSearchBox);
            this.Controls.Add(this.employees);
            this.Controls.Add(this.deleteEmp);
            this.Controls.Add(this.updateEmp);
            this.Controls.Add(this.addEmp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "empManage";
            this.Text = "empManage";
            this.Load += new System.EventHandler(this.empManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employees)).EndInit();
            this.panel1.ResumeLayout(false);
            this.materialCard5.ResumeLayout(false);
            this.materialCard6.ResumeLayout(false);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.materialCard3.ResumeLayout(false);
            this.materialCard4.ResumeLayout(false);
            this.materialCard4.PerformLayout();
            this.materialCard7.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addEmp;
        private System.Windows.Forms.ComboBox jobTitle;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button updateEmp;
        private System.Windows.Forms.Button deleteEmp;
        private System.Windows.Forms.DataGridView employees;
        private System.Windows.Forms.TextBox empSearchBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button empSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label18;
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
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialCard materialCard5;
        private MaterialSkin.Controls.MaterialCard materialCard6;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialTextBox2 firstName;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private System.Windows.Forms.Label label19;
        private MaterialSkin.Controls.MaterialTextBox2 lastName;
        private MaterialSkin.Controls.MaterialTextBox2 contactNumber;
        private MaterialSkin.Controls.MaterialTextBox2 emergencyNumber;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialCard materialCard4;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialTextBox2 newCity;
        private MaterialSkin.Controls.MaterialTextBox2 newBarangay;
        private MaterialSkin.Controls.MaterialTextBox2 newMunicipality;
        private MaterialSkin.Controls.MaterialCard materialCard7;
    }
}