namespace PayRoll_Application
{
    partial class EmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeForm));
            this.grpEmployeeContactDetails = new System.Windows.Forms.GroupBox();
            this.grpMaritalStatus = new System.Windows.Forms.GroupBox();
            this.rdbSingle = new System.Windows.Forms.RadioButton();
            this.rdbMarried = new System.Windows.Forms.RadioButton();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lblDOB = new System.Windows.Forms.Label();
            this.txtNationalInsuranceNo = new System.Windows.Forms.TextBox();
            this.lblNationalInsuranceNo = new System.Windows.Forms.Label();
            this.grpGender = new System.Windows.Forms.GroupBox();
            this.rdbFemale = new System.Windows.Forms.RadioButton();
            this.rdbMale = new System.Windows.Forms.RadioButton();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.txtPostCode = new System.Windows.Forms.TextBox();
            this.lblPostCode = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnUpdateEmployee = new System.Windows.Forms.Button();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.ShowData = new System.Windows.Forms.Button();
            this.btnPayroll = new System.Windows.Forms.Button();
            this.grpEmployeeContactDetails.SuspendLayout();
            this.grpMaritalStatus.SuspendLayout();
            this.grpGender.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpEmployeeContactDetails
            // 
            this.grpEmployeeContactDetails.Controls.Add(this.grpMaritalStatus);
            this.grpEmployeeContactDetails.Controls.Add(this.dateTimePicker);
            this.grpEmployeeContactDetails.Controls.Add(this.lblDOB);
            this.grpEmployeeContactDetails.Controls.Add(this.txtNationalInsuranceNo);
            this.grpEmployeeContactDetails.Controls.Add(this.lblNationalInsuranceNo);
            this.grpEmployeeContactDetails.Controls.Add(this.grpGender);
            this.grpEmployeeContactDetails.Controls.Add(this.txtLastName);
            this.grpEmployeeContactDetails.Controls.Add(this.lblLastName);
            this.grpEmployeeContactDetails.Controls.Add(this.txtFirstName);
            this.grpEmployeeContactDetails.Controls.Add(this.lblFirstName);
            this.grpEmployeeContactDetails.Controls.Add(this.txtEmployeeID);
            this.grpEmployeeContactDetails.Controls.Add(this.lblEmployeeID);
            this.grpEmployeeContactDetails.Location = new System.Drawing.Point(37, 28);
            this.grpEmployeeContactDetails.Name = "grpEmployeeContactDetails";
            this.grpEmployeeContactDetails.Size = new System.Drawing.Size(527, 548);
            this.grpEmployeeContactDetails.TabIndex = 0;
            this.grpEmployeeContactDetails.TabStop = false;
            this.grpEmployeeContactDetails.Text = "Employee information";
            // 
            // grpMaritalStatus
            // 
            this.grpMaritalStatus.Controls.Add(this.rdbSingle);
            this.grpMaritalStatus.Controls.Add(this.rdbMarried);
            this.grpMaritalStatus.Location = new System.Drawing.Point(55, 439);
            this.grpMaritalStatus.Name = "grpMaritalStatus";
            this.grpMaritalStatus.Size = new System.Drawing.Size(394, 73);
            this.grpMaritalStatus.TabIndex = 6;
            this.grpMaritalStatus.TabStop = false;
            this.grpMaritalStatus.Text = "Marital Status :";
            // 
            // rdbSingle
            // 
            this.rdbSingle.AutoSize = true;
            this.rdbSingle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbSingle.Location = new System.Drawing.Point(268, 30);
            this.rdbSingle.Name = "rdbSingle";
            this.rdbSingle.Size = new System.Drawing.Size(69, 22);
            this.rdbSingle.TabIndex = 1;
            this.rdbSingle.Text = "Single";
            this.rdbSingle.UseVisualStyleBackColor = true;
            // 
            // rdbMarried
            // 
            this.rdbMarried.AutoSize = true;
            this.rdbMarried.Checked = true;
            this.rdbMarried.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMarried.Location = new System.Drawing.Point(139, 30);
            this.rdbMarried.Name = "rdbMarried";
            this.rdbMarried.Size = new System.Drawing.Size(79, 22);
            this.rdbMarried.TabIndex = 0;
            this.rdbMarried.TabStop = true;
            this.rdbMarried.Text = "Married";
            this.rdbMarried.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(235, 377);
            this.dateTimePicker.MaxDate = new System.DateTime(2020, 4, 10, 18, 10, 11, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(214, 24);
            this.dateTimePicker.TabIndex = 5;
            this.dateTimePicker.Value = new System.DateTime(2020, 4, 10, 0, 0, 0, 0);
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.Location = new System.Drawing.Point(52, 378);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(101, 18);
            this.lblDOB.TabIndex = 9;
            this.lblDOB.Text = "Date Of Birth :";
            // 
            // txtNationalInsuranceNo
            // 
            this.txtNationalInsuranceNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNationalInsuranceNo.Location = new System.Drawing.Point(235, 311);
            this.txtNationalInsuranceNo.MaxLength = 10;
            this.txtNationalInsuranceNo.Name = "txtNationalInsuranceNo";
            this.txtNationalInsuranceNo.Size = new System.Drawing.Size(214, 24);
            this.txtNationalInsuranceNo.TabIndex = 4;
            this.txtNationalInsuranceNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNationalInsuranceNo_KeyPress);
            this.txtNationalInsuranceNo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtEmployeeID_KeyUp);
            // 
            // lblNationalInsuranceNo
            // 
            this.lblNationalInsuranceNo.AutoSize = true;
            this.lblNationalInsuranceNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNationalInsuranceNo.Location = new System.Drawing.Point(59, 315);
            this.lblNationalInsuranceNo.Name = "lblNationalInsuranceNo";
            this.lblNationalInsuranceNo.Size = new System.Drawing.Size(128, 18);
            this.lblNationalInsuranceNo.TabIndex = 7;
            this.lblNationalInsuranceNo.Text = "ES Insurance No :";
            // 
            // grpGender
            // 
            this.grpGender.Controls.Add(this.rdbFemale);
            this.grpGender.Controls.Add(this.rdbMale);
            this.grpGender.Location = new System.Drawing.Point(55, 194);
            this.grpGender.Name = "grpGender";
            this.grpGender.Size = new System.Drawing.Size(394, 73);
            this.grpGender.TabIndex = 3;
            this.grpGender.TabStop = false;
            this.grpGender.Text = "Gender :";
            // 
            // rdbFemale
            // 
            this.rdbFemale.AutoSize = true;
            this.rdbFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFemale.Location = new System.Drawing.Point(268, 30);
            this.rdbFemale.Name = "rdbFemale";
            this.rdbFemale.Size = new System.Drawing.Size(78, 22);
            this.rdbFemale.TabIndex = 1;
            this.rdbFemale.Text = "Female";
            this.rdbFemale.UseVisualStyleBackColor = true;
            // 
            // rdbMale
            // 
            this.rdbMale.AutoSize = true;
            this.rdbMale.Checked = true;
            this.rdbMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMale.Location = new System.Drawing.Point(139, 30);
            this.rdbMale.Name = "rdbMale";
            this.rdbMale.Size = new System.Drawing.Size(61, 22);
            this.rdbMale.TabIndex = 0;
            this.rdbMale.TabStop = true;
            this.rdbMale.Text = "Male";
            this.rdbMale.UseVisualStyleBackColor = true;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(235, 147);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(214, 24);
            this.txtLastName.TabIndex = 2;
            this.txtLastName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtEmployeeID_KeyUp);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(52, 149);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(92, 18);
            this.lblLastName.TabIndex = 4;
            this.lblLastName.Text = "Last Name : ";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(235, 100);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(214, 24);
            this.txtFirstName.TabIndex = 1;
            this.txtFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirstName_KeyPress);
            this.txtFirstName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtEmployeeID_KeyUp);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(52, 102);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(93, 18);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "First Name : ";
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeID.Location = new System.Drawing.Point(235, 54);
            this.txtEmployeeID.MaxLength = 10;
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(214, 24);
            this.txtEmployeeID.TabIndex = 0;
            this.txtEmployeeID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmployeeID_KeyPress);
            this.txtEmployeeID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtEmployeeID_KeyUp);
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeID.Location = new System.Drawing.Point(52, 56);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(104, 18);
            this.lblEmployeeID.TabIndex = 0;
            this.lblEmployeeID.Text = "Employee ID : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbCountry);
            this.groupBox1.Controls.Add(this.txtNotes);
            this.groupBox1.Controls.Add(this.lblNotes);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.txtPhoneNumber);
            this.groupBox1.Controls.Add(this.lblPhoneNumber);
            this.groupBox1.Controls.Add(this.lblCountry);
            this.groupBox1.Controls.Add(this.txtPostCode);
            this.groupBox1.Controls.Add(this.lblPostCode);
            this.groupBox1.Controls.Add(this.txtCity);
            this.groupBox1.Controls.Add(this.lblCity);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.lblAddress);
            this.groupBox1.Location = new System.Drawing.Point(576, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(527, 548);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Contact Details";
            // 
            // cbCountry
            // 
            this.cbCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Items.AddRange(new object[] {
            "India",
            "USA",
            "Canada",
            "Russia",
            "Australia",
            "Japan",
            "South Koria"});
            this.cbCountry.Location = new System.Drawing.Point(243, 237);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(214, 26);
            this.cbCountry.TabIndex = 3;
            this.cbCountry.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbCountry_KeyPress);
            // 
            // txtNotes
            // 
            this.txtNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotes.Location = new System.Drawing.Point(243, 390);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotes.Size = new System.Drawing.Size(214, 105);
            this.txtNotes.TabIndex = 6;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.Location = new System.Drawing.Point(60, 392);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(56, 18);
            this.lblNotes.TabIndex = 18;
            this.lblNotes.Text = "Notes :";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(243, 339);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(214, 24);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtEmployeeID_KeyUp);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(60, 341);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(115, 18);
            this.lblEmail.TabIndex = 16;
            this.lblEmail.Text = "Email Address : ";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(243, 292);
            this.txtPhoneNumber.MaxLength = 12;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(214, 24);
            this.txtPhoneNumber.TabIndex = 4;
            this.txtPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhoneNumber_KeyPress);
            this.txtPhoneNumber.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtEmployeeID_KeyUp);
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(60, 294);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(116, 18);
            this.lblPhoneNumber.TabIndex = 14;
            this.lblPhoneNumber.Text = "Phone Number :";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.Location = new System.Drawing.Point(60, 237);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(72, 18);
            this.lblCountry.TabIndex = 12;
            this.lblCountry.Text = "Country : ";
            // 
            // txtPostCode
            // 
            this.txtPostCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostCode.Location = new System.Drawing.Point(243, 182);
            this.txtPostCode.Name = "txtPostCode";
            this.txtPostCode.Size = new System.Drawing.Size(214, 24);
            this.txtPostCode.TabIndex = 2;
            this.txtPostCode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtEmployeeID_KeyUp);
            // 
            // lblPostCode
            // 
            this.lblPostCode.AutoSize = true;
            this.lblPostCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostCode.Location = new System.Drawing.Point(60, 184);
            this.lblPostCode.Name = "lblPostCode";
            this.lblPostCode.Size = new System.Drawing.Size(91, 18);
            this.lblPostCode.TabIndex = 10;
            this.lblPostCode.Text = "Post Code : ";
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Location = new System.Drawing.Point(243, 135);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(214, 24);
            this.txtCity.TabIndex = 1;
            this.txtCity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCity_KeyPress);
            this.txtCity.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtEmployeeID_KeyUp);
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(60, 137);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(45, 18);
            this.lblCity.TabIndex = 8;
            this.lblCity.Text = "City : ";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(243, 56);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAddress.Size = new System.Drawing.Size(214, 64);
            this.txtAddress.TabIndex = 0;
            this.txtAddress.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtEmployeeID_KeyUp);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(60, 58);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(74, 18);
            this.lblAddress.TabIndex = 6;
            this.lblAddress.Text = "Address : ";
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.BackColor = System.Drawing.Color.Black;
            this.btnAddEmployee.ForeColor = System.Drawing.Color.White;
            this.btnAddEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnAddEmployee.Image")));
            this.btnAddEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddEmployee.Location = new System.Drawing.Point(37, 601);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(166, 43);
            this.btnAddEmployee.TabIndex = 2;
            this.btnAddEmployee.Text = "&Add Employee     ";
            this.btnAddEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddEmployee.UseVisualStyleBackColor = false;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnUpdateEmployee
            // 
            this.btnUpdateEmployee.BackColor = System.Drawing.Color.Black;
            this.btnUpdateEmployee.ForeColor = System.Drawing.Color.White;
            this.btnUpdateEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateEmployee.Image")));
            this.btnUpdateEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateEmployee.Location = new System.Drawing.Point(221, 601);
            this.btnUpdateEmployee.Name = "btnUpdateEmployee";
            this.btnUpdateEmployee.Size = new System.Drawing.Size(168, 43);
            this.btnUpdateEmployee.TabIndex = 3;
            this.btnUpdateEmployee.Text = "&Update Employee";
            this.btnUpdateEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateEmployee.UseVisualStyleBackColor = false;
            this.btnUpdateEmployee.Click += new System.EventHandler(this.btnUpdateEmployee_Click);
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.BackColor = System.Drawing.Color.Black;
            this.btnDeleteEmployee.ForeColor = System.Drawing.Color.White;
            this.btnDeleteEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteEmployee.Image")));
            this.btnDeleteEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteEmployee.Location = new System.Drawing.Point(407, 601);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(168, 43);
            this.btnDeleteEmployee.TabIndex = 4;
            this.btnDeleteEmployee.Text = "      &Delete Employee";
            this.btnDeleteEmployee.UseVisualStyleBackColor = false;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Black;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(958, 601);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(168, 43);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.BackColor = System.Drawing.Color.Black;
            this.btnPreview.ForeColor = System.Drawing.Color.White;
            this.btnPreview.Image = ((System.Drawing.Image)(resources.GetObject("btnPreview.Image")));
            this.btnPreview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPreview.Location = new System.Drawing.Point(776, 601);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(168, 43);
            this.btnPreview.TabIndex = 6;
            this.btnPreview.Text = "Pre&view";
            this.btnPreview.UseVisualStyleBackColor = false;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Black;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(592, 601);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(168, 43);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // ShowData
            // 
            this.ShowData.BackColor = System.Drawing.Color.Black;
            this.ShowData.ForeColor = System.Drawing.Color.White;
            this.ShowData.Image = ((System.Drawing.Image)(resources.GetObject("ShowData.Image")));
            this.ShowData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShowData.Location = new System.Drawing.Point(407, 657);
            this.ShowData.Name = "ShowData";
            this.ShowData.Size = new System.Drawing.Size(168, 43);
            this.ShowData.TabIndex = 8;
            this.ShowData.Text = "   &Employee Data";
            this.ShowData.UseVisualStyleBackColor = false;
            this.ShowData.Click += new System.EventHandler(this.ShowData_Click);
            // 
            // btnPayroll
            // 
            this.btnPayroll.BackColor = System.Drawing.Color.Black;
            this.btnPayroll.ForeColor = System.Drawing.Color.White;
            this.btnPayroll.Image = ((System.Drawing.Image)(resources.GetObject("btnPayroll.Image")));
            this.btnPayroll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayroll.Location = new System.Drawing.Point(592, 657);
            this.btnPayroll.Name = "btnPayroll";
            this.btnPayroll.Size = new System.Drawing.Size(168, 43);
            this.btnPayroll.TabIndex = 9;
            this.btnPayroll.Text = "      &Payroll Calculator";
            this.btnPayroll.UseVisualStyleBackColor = false;
            this.btnPayroll.Click += new System.EventHandler(this.btnPayroll_Click);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1138, 712);
            this.Controls.Add(this.btnPayroll);
            this.Controls.Add(this.ShowData);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnDeleteEmployee);
            this.Controls.Add(this.btnUpdateEmployee);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpEmployeeContactDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmployeeForm";
            this.Text = "Hotel Management";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            this.grpEmployeeContactDetails.ResumeLayout(false);
            this.grpEmployeeContactDetails.PerformLayout();
            this.grpMaritalStatus.ResumeLayout(false);
            this.grpMaritalStatus.PerformLayout();
            this.grpGender.ResumeLayout(false);
            this.grpGender.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.GroupBox grpEmployeeContactDetails;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpMaritalStatus;
        private System.Windows.Forms.RadioButton rdbSingle;
        private System.Windows.Forms.RadioButton rdbMarried;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.TextBox txtNationalInsuranceNo;
        private System.Windows.Forms.Label lblNationalInsuranceNo;
        private System.Windows.Forms.GroupBox grpGender;
        private System.Windows.Forms.RadioButton rdbFemale;
        private System.Windows.Forms.RadioButton rdbMale;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.TextBox txtPostCode;
        private System.Windows.Forms.Label lblPostCode;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnUpdateEmployee;
        private System.Windows.Forms.Button btnDeleteEmployee;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button ShowData;
        private System.Windows.Forms.Button btnPayroll;
    }
}

