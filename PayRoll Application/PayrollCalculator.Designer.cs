namespace PayRoll_Application
{
    partial class PayrollCalculator
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
        string FullName = string.Empty;

        double Mon1 = 0, Tue1 = 0, Wed1 = 0, Thu1 = 0, Fri1 = 0, Sat1 = 0;
        double Mon2 = 0, Tue2 = 0, Wed2 = 0, Thu2 = 0, Fri2 = 0, Sat2 = 0;
        double Mon3 = 0, Tue3 = 0, Wed3 = 0, Thu3 = 0, Fri3 = 0, Sat3 = 0;
        double Mon4 = 0, Tue4 = 0, Wed4 = 0, Thu4 = 0, Fri4 = 0, Sat4 = 0;

        double totalHoursWK1, totalHoursWK2, totalHoursWK3, totalHoursWK4;
        double contractualHoursWK1, contractualHoursWK2, contractualHoursWK3, contractualHoursWK4;
        double overtimeHoursWK1, overtimeHoursWK2, overtimeHoursWK3, overtimeHoursWK4;
        double totalContractualHours;
        double totalOvertimeHours;
        double totalHoursWorked;

        double contractualAmountWK1, contractualAmountWK2, contractualAmountWK3, contractualAmountWK4;
        double overtimeAmountWK1, overtimeAmountWK2, overtimeAmountWK3, overtimeAmountWK4;
        double totalContractualAmount;
        double totalOvertimeAmount;
        double totalAmountEarned;

        double tax, ESIContribution, taxRate, PT,PF,LWF,ADV;
        double totalDeductions;

        const double Union = 1500;
        const double SLCRate = .05;

        double hourlySalaryRate, overtimeSalaryRate;

        double netPay;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayrollCalculator));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPaymentID2 = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.txtNetPay = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtADV = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtLWF = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.txtPT = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtTaxRate = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.txtTaxCode = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.txtPF = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.txtTotalDeduction = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.txtESIContribution = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.txtTDS = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.label46 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.txtTotalEarning = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtOvertimeEarning = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtContractualEarning = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txtTotalHours = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtOvertimeRate = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtOvertimeHours = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtContractualHours = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.dates = new System.Windows.Forms.GroupBox();
            this.dtpPaymentMonth = new System.Windows.Forms.DateTimePicker();
            this.label44 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dtpCurrentDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnGet = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtESINumber = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.llWindowsCalculator = new System.Windows.Forms.LinkLabel();
            this.label18 = new System.Windows.Forms.Label();
            this.hourlyRate = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.sat4 = new System.Windows.Forms.NumericUpDown();
            this.sat3 = new System.Windows.Forms.NumericUpDown();
            this.sat2 = new System.Windows.Forms.NumericUpDown();
            this.sat1 = new System.Windows.Forms.NumericUpDown();
            this.fri4 = new System.Windows.Forms.NumericUpDown();
            this.fri3 = new System.Windows.Forms.NumericUpDown();
            this.fri2 = new System.Windows.Forms.NumericUpDown();
            this.fri1 = new System.Windows.Forms.NumericUpDown();
            this.thu4 = new System.Windows.Forms.NumericUpDown();
            this.thu3 = new System.Windows.Forms.NumericUpDown();
            this.thu2 = new System.Windows.Forms.NumericUpDown();
            this.thu1 = new System.Windows.Forms.NumericUpDown();
            this.wed4 = new System.Windows.Forms.NumericUpDown();
            this.wed3 = new System.Windows.Forms.NumericUpDown();
            this.wed2 = new System.Windows.Forms.NumericUpDown();
            this.wed1 = new System.Windows.Forms.NumericUpDown();
            this.tue4 = new System.Windows.Forms.NumericUpDown();
            this.tue3 = new System.Windows.Forms.NumericUpDown();
            this.tue2 = new System.Windows.Forms.NumericUpDown();
            this.tue1 = new System.Windows.Forms.NumericUpDown();
            this.mon4 = new System.Windows.Forms.NumericUpDown();
            this.mon3 = new System.Windows.Forms.NumericUpDown();
            this.mon2 = new System.Windows.Forms.NumericUpDown();
            this.mon1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.dtpPayMonth = new System.Windows.Forms.DateTimePicker();
            this.dtpPayDate = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.txtEmployeeID2 = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.txtPaymentID = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.txtDecimal = new System.Windows.Forms.TextBox();
            this.txtMinute = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.txtHour = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payrollBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.payrollSystemDBDataSet11 = new PayRoll_Application.PayrollSystemDBDataSet1();
            this.payrollBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.payrollSystemDBDataSet1 = new PayRoll_Application.PayrollSystemDBDataSet();
            this.btnComputePay = new System.Windows.Forms.Button();
            this.btnSavePay = new System.Windows.Forms.Button();
            this.btnGeneratePayslip = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.payrollTableAdapter = new PayRoll_Application.PayrollSystemDBDataSet1TableAdapters.PayrollTableAdapter();
            this.btnPrintPayslip = new System.Windows.Forms.Button();
            this.btnDeletePay = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.dates.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hourlyRate)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sat4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sat3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sat2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sat1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fri4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fri3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fri2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fri1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thu4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thu3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thu2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wed4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wed3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wed2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wed1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tue4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tue3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tue2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tue1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mon4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mon3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mon2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mon1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollSystemDBDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollSystemDBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPaymentID2);
            this.groupBox1.Controls.Add(this.label45);
            this.groupBox1.Controls.Add(this.txtNetPay);
            this.groupBox1.Controls.Add(this.label32);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox7);
            this.groupBox1.Controls.Add(this.dates);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(21, -2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1074, 742);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // txtPaymentID2
            // 
            this.txtPaymentID2.Location = new System.Drawing.Point(601, 713);
            this.txtPaymentID2.Name = "txtPaymentID2";
            this.txtPaymentID2.ReadOnly = true;
            this.txtPaymentID2.Size = new System.Drawing.Size(128, 22);
            this.txtPaymentID2.TabIndex = 71;
            this.txtPaymentID2.Text = "AUTO";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.Location = new System.Drawing.Point(494, 714);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(100, 17);
            this.label45.TabIndex = 70;
            this.label45.Text = "Payment ID :";
            // 
            // txtNetPay
            // 
            this.txtNetPay.Location = new System.Drawing.Point(937, 709);
            this.txtNetPay.Name = "txtNetPay";
            this.txtNetPay.ReadOnly = true;
            this.txtNetPay.Size = new System.Drawing.Size(125, 22);
            this.txtNetPay.TabIndex = 69;
            this.txtNetPay.Text = "AUTO";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(842, 711);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(106, 17);
            this.label32.TabIndex = 68;
            this.label32.Text = "Net Pay (₹)  :";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(724, 23);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 27);
            this.lblName.TabIndex = 5;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtADV);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Controls.Add(this.txtLWF);
            this.groupBox6.Controls.Add(this.label30);
            this.groupBox6.Controls.Add(this.txtPT);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.txtTaxRate);
            this.groupBox6.Controls.Add(this.label43);
            this.groupBox6.Controls.Add(this.txtTaxCode);
            this.groupBox6.Controls.Add(this.label31);
            this.groupBox6.Controls.Add(this.txtPF);
            this.groupBox6.Controls.Add(this.label29);
            this.groupBox6.Controls.Add(this.txtTotalDeduction);
            this.groupBox6.Controls.Add(this.label28);
            this.groupBox6.Controls.Add(this.txtESIContribution);
            this.groupBox6.Controls.Add(this.label27);
            this.groupBox6.Controls.Add(this.txtTDS);
            this.groupBox6.Controls.Add(this.label26);
            this.groupBox6.Location = new System.Drawing.Point(632, 513);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(436, 189);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Deductions";
            // 
            // txtADV
            // 
            this.txtADV.Location = new System.Drawing.Point(317, 124);
            this.txtADV.Name = "txtADV";
            this.txtADV.Size = new System.Drawing.Size(109, 22);
            this.txtADV.TabIndex = 75;
            this.txtADV.Text = "0";
            this.txtADV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmployeeID_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(249, 125);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(70, 17);
            this.label17.TabIndex = 74;
            this.label17.Text = "ADV (₹) : ";
            // 
            // txtLWF
            // 
            this.txtLWF.Location = new System.Drawing.Point(113, 123);
            this.txtLWF.Name = "txtLWF";
            this.txtLWF.Size = new System.Drawing.Size(122, 22);
            this.txtLWF.TabIndex = 73;
            this.txtLWF.Text = "0";
            this.txtLWF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmployeeID_KeyPress);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(9, 125);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(95, 17);
            this.label30.TabIndex = 72;
            this.label30.Text = "L . W . F  (₹) :";
            // 
            // txtPT
            // 
            this.txtPT.Location = new System.Drawing.Point(112, 57);
            this.txtPT.Name = "txtPT";
            this.txtPT.Size = new System.Drawing.Size(123, 22);
            this.txtPT.TabIndex = 71;
            this.txtPT.Text = "120";
            this.txtPT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmployeeID_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(14, 59);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 17);
            this.label15.TabIndex = 70;
            this.label15.Text = "P . T (₹)  : ";
            // 
            // txtTaxRate
            // 
            this.txtTaxRate.Location = new System.Drawing.Point(317, 56);
            this.txtTaxRate.Name = "txtTaxRate";
            this.txtTaxRate.ReadOnly = true;
            this.txtTaxRate.Size = new System.Drawing.Size(108, 22);
            this.txtTaxRate.TabIndex = 69;
            this.txtTaxRate.Text = "AUTO";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.Location = new System.Drawing.Point(246, 59);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(77, 17);
            this.label43.TabIndex = 68;
            this.label43.Text = "Tax Rate : ";
            // 
            // txtTaxCode
            // 
            this.txtTaxCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaxCode.Location = new System.Drawing.Point(317, 23);
            this.txtTaxCode.Name = "txtTaxCode";
            this.txtTaxCode.Size = new System.Drawing.Size(108, 21);
            this.txtTaxCode.TabIndex = 67;
            this.txtTaxCode.Text = "24ABCDE12341Z5";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(248, 23);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(71, 17);
            this.label31.TabIndex = 66;
            this.label31.Text = "GST No : ";
            // 
            // txtPF
            // 
            this.txtPF.Location = new System.Drawing.Point(317, 93);
            this.txtPF.Name = "txtPF";
            this.txtPF.Size = new System.Drawing.Size(110, 22);
            this.txtPF.TabIndex = 65;
            this.txtPF.Text = "100";
            this.txtPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmployeeID_KeyPress);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(249, 94);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(71, 17);
            this.label29.TabIndex = 64;
            this.label29.Text = "P . F (₹) : ";
            // 
            // txtTotalDeduction
            // 
            this.txtTotalDeduction.Location = new System.Drawing.Point(156, 156);
            this.txtTotalDeduction.Name = "txtTotalDeduction";
            this.txtTotalDeduction.ReadOnly = true;
            this.txtTotalDeduction.Size = new System.Drawing.Size(271, 22);
            this.txtTotalDeduction.TabIndex = 61;
            this.txtTotalDeduction.Text = "AUTO";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(8, 158);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(142, 15);
            this.label28.TabIndex = 60;
            this.label28.Text = "Total Deduction (₹)  :";
            // 
            // txtESIContribution
            // 
            this.txtESIContribution.Location = new System.Drawing.Point(130, 92);
            this.txtESIContribution.Name = "txtESIContribution";
            this.txtESIContribution.ReadOnly = true;
            this.txtESIContribution.Size = new System.Drawing.Size(106, 22);
            this.txtESIContribution.TabIndex = 55;
            this.txtESIContribution.Text = "AUTO";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(10, 94);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(72, 17);
            this.label27.TabIndex = 54;
            this.label27.Text = "ESIC (₹) : ";
            // 
            // txtTDS
            // 
            this.txtTDS.Location = new System.Drawing.Point(113, 24);
            this.txtTDS.Name = "txtTDS";
            this.txtTDS.ReadOnly = true;
            this.txtTDS.Size = new System.Drawing.Size(123, 22);
            this.txtTDS.TabIndex = 53;
            this.txtTDS.Text = "AUTO";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(8, 26);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(74, 17);
            this.label26.TabIndex = 52;
            this.label26.Text = "TDS (₹)  : ";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.groupBox9);
            this.groupBox7.Controls.Add(this.groupBox8);
            this.groupBox7.Location = new System.Drawing.Point(20, 507);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(606, 195);
            this.groupBox7.TabIndex = 4;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Hours && Earning";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.label46);
            this.groupBox9.Controls.Add(this.label38);
            this.groupBox9.Controls.Add(this.txtTotalEarning);
            this.groupBox9.Controls.Add(this.label25);
            this.groupBox9.Controls.Add(this.txtOvertimeEarning);
            this.groupBox9.Controls.Add(this.label23);
            this.groupBox9.Controls.Add(this.txtContractualEarning);
            this.groupBox9.Controls.Add(this.label24);
            this.groupBox9.Location = new System.Drawing.Point(307, 21);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(284, 162);
            this.groupBox9.TabIndex = 4;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Earning";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.Location = new System.Drawing.Point(90, 59);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(30, 17);
            this.label46.TabIndex = 74;
            this.label46.Text = "(₹) ";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(90, 97);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(30, 17);
            this.label38.TabIndex = 73;
            this.label38.Text = "(₹) ";
            // 
            // txtTotalEarning
            // 
            this.txtTotalEarning.Location = new System.Drawing.Point(141, 129);
            this.txtTotalEarning.Name = "txtTotalEarning";
            this.txtTotalEarning.ReadOnly = true;
            this.txtTotalEarning.Size = new System.Drawing.Size(136, 22);
            this.txtTotalEarning.TabIndex = 59;
            this.txtTotalEarning.Text = "AUTO";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(6, 133);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(131, 15);
            this.label25.TabIndex = 58;
            this.label25.Text = "Total Earning (₹)   :";
            // 
            // txtOvertimeEarning
            // 
            this.txtOvertimeEarning.Location = new System.Drawing.Point(141, 78);
            this.txtOvertimeEarning.Name = "txtOvertimeEarning";
            this.txtOvertimeEarning.ReadOnly = true;
            this.txtOvertimeEarning.Size = new System.Drawing.Size(136, 22);
            this.txtOvertimeEarning.TabIndex = 57;
            this.txtOvertimeEarning.Text = "AUTO";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(5, 78);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(130, 17);
            this.label23.TabIndex = 56;
            this.label23.Text = "Overtime Earning : ";
            // 
            // txtContractualEarning
            // 
            this.txtContractualEarning.Location = new System.Drawing.Point(141, 41);
            this.txtContractualEarning.Name = "txtContractualEarning";
            this.txtContractualEarning.ReadOnly = true;
            this.txtContractualEarning.Size = new System.Drawing.Size(136, 22);
            this.txtContractualEarning.TabIndex = 55;
            this.txtContractualEarning.Text = "AUTO";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(4, 43);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(145, 17);
            this.label24.TabIndex = 54;
            this.label24.Text = "Contractual Earning : ";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.txtTotalHours);
            this.groupBox8.Controls.Add(this.label22);
            this.groupBox8.Controls.Add(this.txtOvertimeRate);
            this.groupBox8.Controls.Add(this.label21);
            this.groupBox8.Controls.Add(this.txtOvertimeHours);
            this.groupBox8.Controls.Add(this.label20);
            this.groupBox8.Controls.Add(this.txtContractualHours);
            this.groupBox8.Controls.Add(this.label19);
            this.groupBox8.Location = new System.Drawing.Point(17, 21);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(284, 162);
            this.groupBox8.TabIndex = 5;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Hours";
            // 
            // txtTotalHours
            // 
            this.txtTotalHours.Location = new System.Drawing.Point(142, 131);
            this.txtTotalHours.Name = "txtTotalHours";
            this.txtTotalHours.ReadOnly = true;
            this.txtTotalHours.Size = new System.Drawing.Size(136, 22);
            this.txtTotalHours.TabIndex = 57;
            this.txtTotalHours.Text = "AUTO";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(11, 133);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(89, 15);
            this.label22.TabIndex = 56;
            this.label22.Text = "Total Hours :";
            // 
            // txtOvertimeRate
            // 
            this.txtOvertimeRate.Location = new System.Drawing.Point(142, 97);
            this.txtOvertimeRate.Name = "txtOvertimeRate";
            this.txtOvertimeRate.Size = new System.Drawing.Size(136, 22);
            this.txtOvertimeRate.TabIndex = 55;
            this.txtOvertimeRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmployeeID_KeyPress);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(10, 97);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(129, 17);
            this.label21.TabIndex = 54;
            this.label21.Text = "Overtime Rate (₹) :";
            // 
            // txtOvertimeHours
            // 
            this.txtOvertimeHours.Location = new System.Drawing.Point(142, 62);
            this.txtOvertimeHours.Name = "txtOvertimeHours";
            this.txtOvertimeHours.ReadOnly = true;
            this.txtOvertimeHours.Size = new System.Drawing.Size(136, 22);
            this.txtOvertimeHours.TabIndex = 53;
            this.txtOvertimeHours.Text = "AUTO";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(10, 62);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(119, 17);
            this.label20.TabIndex = 52;
            this.label20.Text = "Overtime Hours : ";
            // 
            // txtContractualHours
            // 
            this.txtContractualHours.Location = new System.Drawing.Point(142, 26);
            this.txtContractualHours.Name = "txtContractualHours";
            this.txtContractualHours.ReadOnly = true;
            this.txtContractualHours.Size = new System.Drawing.Size(136, 22);
            this.txtContractualHours.TabIndex = 51;
            this.txtContractualHours.Text = "AUTO";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(10, 28);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(134, 17);
            this.label19.TabIndex = 50;
            this.label19.Text = "Contractual Hours : ";
            // 
            // dates
            // 
            this.dates.Controls.Add(this.dtpPaymentMonth);
            this.dates.Controls.Add(this.label44);
            this.dates.Controls.Add(this.label16);
            this.dates.Controls.Add(this.dtpCurrentDate);
            this.dates.Location = new System.Drawing.Point(596, 53);
            this.dates.Name = "dates";
            this.dates.Size = new System.Drawing.Size(446, 101);
            this.dates.TabIndex = 1;
            this.dates.TabStop = false;
            this.dates.Text = "Dates ";
            // 
            // dtpPaymentMonth
            // 
            this.dtpPaymentMonth.Checked = false;
            this.dtpPaymentMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPaymentMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPaymentMonth.Location = new System.Drawing.Point(179, 23);
            this.dtpPaymentMonth.Name = "dtpPaymentMonth";
            this.dtpPaymentMonth.ShowCheckBox = true;
            this.dtpPaymentMonth.Size = new System.Drawing.Size(215, 27);
            this.dtpPaymentMonth.TabIndex = 66;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.Location = new System.Drawing.Point(18, 23);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(135, 20);
            this.label44.TabIndex = 64;
            this.label44.Text = "Payment Month :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(20, 59);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(125, 20);
            this.label16.TabIndex = 51;
            this.label16.Text = "Payment Date :";
            // 
            // dtpCurrentDate
            // 
            this.dtpCurrentDate.Checked = false;
            this.dtpCurrentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCurrentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCurrentDate.Location = new System.Drawing.Point(179, 56);
            this.dtpCurrentDate.Name = "dtpCurrentDate";
            this.dtpCurrentDate.ShowCheckBox = true;
            this.dtpCurrentDate.Size = new System.Drawing.Size(217, 27);
            this.dtpCurrentDate.TabIndex = 50;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnGet);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.txtLastName);
            this.groupBox4.Controls.Add(this.txtESINumber);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.txtFirstName);
            this.groupBox4.Controls.Add(this.txtEmployeeID);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(20, 14);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(570, 139);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "EmployeeDetails";
            // 
            // btnGet
            // 
            this.btnGet.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnGet.Location = new System.Drawing.Point(306, 30);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(94, 42);
            this.btnGet.TabIndex = 56;
            this.btnGet.Text = "Get";
            this.btnGet.UseVisualStyleBackColor = false;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(298, 103);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(109, 20);
            this.label14.TabIndex = 55;
            this.label14.Text = "ESI Number :";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(121, 101);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(165, 22);
            this.txtLastName.TabIndex = 54;
            this.txtLastName.Text = "AUTO";
            // 
            // txtESINumber
            // 
            this.txtESINumber.Location = new System.Drawing.Point(406, 102);
            this.txtESINumber.Name = "txtESINumber";
            this.txtESINumber.ReadOnly = true;
            this.txtESINumber.Size = new System.Drawing.Size(154, 22);
            this.txtESINumber.TabIndex = 52;
            this.txtESINumber.Text = "AUTO";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(10, 103);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 20);
            this.label13.TabIndex = 51;
            this.label13.Text = "Last Name :";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(121, 66);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(166, 22);
            this.txtFirstName.TabIndex = 50;
            this.txtFirstName.Text = "AUTO";
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(121, 30);
            this.txtEmployeeID.MaxLength = 10;
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(166, 22);
            this.txtEmployeeID.TabIndex = 49;
            this.txtEmployeeID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmployeeID_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(10, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 20);
            this.label12.TabIndex = 48;
            this.label12.Text = "First Name :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(7, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 20);
            this.label11.TabIndex = 47;
            this.label11.Text = "Employee ID :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.llWindowsCalculator);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.hourlyRate);
            this.groupBox3.Controls.Add(this.tableLayoutPanel1);
            this.groupBox3.Location = new System.Drawing.Point(20, 163);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1048, 336);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Time Sheet";
            // 
            // llWindowsCalculator
            // 
            this.llWindowsCalculator.AutoSize = true;
            this.llWindowsCalculator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llWindowsCalculator.Location = new System.Drawing.Point(659, 295);
            this.llWindowsCalculator.Name = "llWindowsCalculator";
            this.llWindowsCalculator.Size = new System.Drawing.Size(163, 20);
            this.llWindowsCalculator.TabIndex = 53;
            this.llWindowsCalculator.TabStop = true;
            this.llWindowsCalculator.Text = "Windows Canculator";
            this.llWindowsCalculator.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llWindowsCalculator_LinkClicked);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(188, 291);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(154, 25);
            this.label18.TabIndex = 52;
            this.label18.Text = "Hourly Rate (₹) :";
            // 
            // hourlyRate
            // 
            this.hourlyRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hourlyRate.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.hourlyRate.Location = new System.Drawing.Point(347, 288);
            this.hourlyRate.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.hourlyRate.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.hourlyRate.Name = "hourlyRate";
            this.hourlyRate.Size = new System.Drawing.Size(217, 32);
            this.hourlyRate.TabIndex = 41;
            this.hourlyRate.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Controls.Add(this.sat4, 4, 6);
            this.tableLayoutPanel1.Controls.Add(this.sat3, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.sat2, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.sat1, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.fri4, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.fri3, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.fri2, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.fri1, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.thu4, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.thu3, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.thu2, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.thu1, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.wed4, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.wed3, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.wed2, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.wed1, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tue4, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.tue3, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.tue2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.tue1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.mon4, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.mon3, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.mon2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.mon1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(17, 26);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1022, 252);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // sat4
            // 
            this.sat4.DecimalPlaces = 2;
            this.sat4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sat4.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.sat4.Location = new System.Drawing.Point(819, 213);
            this.sat4.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.sat4.Name = "sat4";
            this.sat4.Size = new System.Drawing.Size(200, 32);
            this.sat4.TabIndex = 40;
            // 
            // sat3
            // 
            this.sat3.DecimalPlaces = 2;
            this.sat3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sat3.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.sat3.Location = new System.Drawing.Point(615, 213);
            this.sat3.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.sat3.Name = "sat3";
            this.sat3.Size = new System.Drawing.Size(198, 32);
            this.sat3.TabIndex = 39;
            // 
            // sat2
            // 
            this.sat2.DecimalPlaces = 2;
            this.sat2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sat2.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.sat2.Location = new System.Drawing.Point(411, 213);
            this.sat2.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.sat2.Name = "sat2";
            this.sat2.Size = new System.Drawing.Size(198, 32);
            this.sat2.TabIndex = 38;
            // 
            // sat1
            // 
            this.sat1.DecimalPlaces = 2;
            this.sat1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sat1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.sat1.Location = new System.Drawing.Point(207, 213);
            this.sat1.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.sat1.Name = "sat1";
            this.sat1.Size = new System.Drawing.Size(198, 32);
            this.sat1.TabIndex = 37;
            // 
            // fri4
            // 
            this.fri4.DecimalPlaces = 2;
            this.fri4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fri4.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.fri4.Location = new System.Drawing.Point(819, 178);
            this.fri4.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.fri4.Name = "fri4";
            this.fri4.Size = new System.Drawing.Size(200, 32);
            this.fri4.TabIndex = 34;
            // 
            // fri3
            // 
            this.fri3.DecimalPlaces = 2;
            this.fri3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fri3.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.fri3.Location = new System.Drawing.Point(615, 178);
            this.fri3.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.fri3.Name = "fri3";
            this.fri3.Size = new System.Drawing.Size(198, 32);
            this.fri3.TabIndex = 33;
            // 
            // fri2
            // 
            this.fri2.DecimalPlaces = 2;
            this.fri2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fri2.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.fri2.Location = new System.Drawing.Point(411, 178);
            this.fri2.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.fri2.Name = "fri2";
            this.fri2.Size = new System.Drawing.Size(198, 32);
            this.fri2.TabIndex = 32;
            // 
            // fri1
            // 
            this.fri1.DecimalPlaces = 2;
            this.fri1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fri1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.fri1.Location = new System.Drawing.Point(207, 178);
            this.fri1.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.fri1.Name = "fri1";
            this.fri1.Size = new System.Drawing.Size(198, 32);
            this.fri1.TabIndex = 31;
            // 
            // thu4
            // 
            this.thu4.DecimalPlaces = 2;
            this.thu4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thu4.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.thu4.Location = new System.Drawing.Point(819, 143);
            this.thu4.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.thu4.Name = "thu4";
            this.thu4.Size = new System.Drawing.Size(200, 32);
            this.thu4.TabIndex = 28;
            // 
            // thu3
            // 
            this.thu3.DecimalPlaces = 2;
            this.thu3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thu3.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.thu3.Location = new System.Drawing.Point(615, 143);
            this.thu3.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.thu3.Name = "thu3";
            this.thu3.Size = new System.Drawing.Size(198, 32);
            this.thu3.TabIndex = 27;
            // 
            // thu2
            // 
            this.thu2.DecimalPlaces = 2;
            this.thu2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thu2.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.thu2.Location = new System.Drawing.Point(411, 143);
            this.thu2.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.thu2.Name = "thu2";
            this.thu2.Size = new System.Drawing.Size(198, 32);
            this.thu2.TabIndex = 26;
            // 
            // thu1
            // 
            this.thu1.DecimalPlaces = 2;
            this.thu1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thu1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.thu1.Location = new System.Drawing.Point(207, 143);
            this.thu1.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.thu1.Name = "thu1";
            this.thu1.Size = new System.Drawing.Size(198, 32);
            this.thu1.TabIndex = 25;
            // 
            // wed4
            // 
            this.wed4.DecimalPlaces = 2;
            this.wed4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wed4.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.wed4.Location = new System.Drawing.Point(819, 108);
            this.wed4.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.wed4.Name = "wed4";
            this.wed4.Size = new System.Drawing.Size(200, 32);
            this.wed4.TabIndex = 22;
            // 
            // wed3
            // 
            this.wed3.DecimalPlaces = 2;
            this.wed3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wed3.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.wed3.Location = new System.Drawing.Point(615, 108);
            this.wed3.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.wed3.Name = "wed3";
            this.wed3.Size = new System.Drawing.Size(198, 32);
            this.wed3.TabIndex = 21;
            // 
            // wed2
            // 
            this.wed2.DecimalPlaces = 2;
            this.wed2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wed2.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.wed2.Location = new System.Drawing.Point(411, 108);
            this.wed2.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.wed2.Name = "wed2";
            this.wed2.Size = new System.Drawing.Size(198, 32);
            this.wed2.TabIndex = 20;
            // 
            // wed1
            // 
            this.wed1.DecimalPlaces = 2;
            this.wed1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wed1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.wed1.Location = new System.Drawing.Point(207, 108);
            this.wed1.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.wed1.Name = "wed1";
            this.wed1.Size = new System.Drawing.Size(198, 32);
            this.wed1.TabIndex = 19;
            // 
            // tue4
            // 
            this.tue4.DecimalPlaces = 2;
            this.tue4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tue4.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.tue4.Location = new System.Drawing.Point(819, 73);
            this.tue4.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.tue4.Name = "tue4";
            this.tue4.Size = new System.Drawing.Size(200, 32);
            this.tue4.TabIndex = 16;
            // 
            // tue3
            // 
            this.tue3.DecimalPlaces = 2;
            this.tue3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tue3.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.tue3.Location = new System.Drawing.Point(615, 73);
            this.tue3.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.tue3.Name = "tue3";
            this.tue3.Size = new System.Drawing.Size(198, 32);
            this.tue3.TabIndex = 15;
            // 
            // tue2
            // 
            this.tue2.DecimalPlaces = 2;
            this.tue2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tue2.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.tue2.Location = new System.Drawing.Point(411, 73);
            this.tue2.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.tue2.Name = "tue2";
            this.tue2.Size = new System.Drawing.Size(198, 32);
            this.tue2.TabIndex = 14;
            // 
            // tue1
            // 
            this.tue1.DecimalPlaces = 2;
            this.tue1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tue1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.tue1.Location = new System.Drawing.Point(207, 73);
            this.tue1.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.tue1.Name = "tue1";
            this.tue1.Size = new System.Drawing.Size(198, 32);
            this.tue1.TabIndex = 13;
            // 
            // mon4
            // 
            this.mon4.DecimalPlaces = 2;
            this.mon4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mon4.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.mon4.Location = new System.Drawing.Point(819, 38);
            this.mon4.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.mon4.Name = "mon4";
            this.mon4.Size = new System.Drawing.Size(200, 32);
            this.mon4.TabIndex = 10;
            // 
            // mon3
            // 
            this.mon3.DecimalPlaces = 2;
            this.mon3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mon3.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.mon3.Location = new System.Drawing.Point(615, 38);
            this.mon3.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.mon3.Name = "mon3";
            this.mon3.Size = new System.Drawing.Size(198, 32);
            this.mon3.TabIndex = 9;
            // 
            // mon2
            // 
            this.mon2.DecimalPlaces = 2;
            this.mon2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mon2.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.mon2.Location = new System.Drawing.Point(411, 38);
            this.mon2.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.mon2.Name = "mon2";
            this.mon2.Size = new System.Drawing.Size(198, 32);
            this.mon2.TabIndex = 8;
            // 
            // mon1
            // 
            this.mon1.DecimalPlaces = 2;
            this.mon1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mon1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.mon1.Location = new System.Drawing.Point(207, 38);
            this.mon1.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.mon1.Name = "mon1";
            this.mon1.Size = new System.Drawing.Size(198, 32);
            this.mon1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 42;
            this.label1.Text = "First Week";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(411, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 43;
            this.label2.Text = "Second Week";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(615, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 44;
            this.label3.Text = "Third Week";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(819, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 45;
            this.label4.Text = "Fourth Week";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 46;
            this.label5.Text = "Monday";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 47;
            this.label6.Text = "Tuesday";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 20);
            this.label7.TabIndex = 48;
            this.label7.Text = "Wednesday";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 49;
            this.label8.Text = "Thursday";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 20);
            this.label9.TabIndex = 50;
            this.label9.Text = "Friday";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 210);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 20);
            this.label10.TabIndex = 51;
            this.label10.Text = "Saturday";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox11);
            this.groupBox2.Controls.Add(this.groupBox10);
            this.groupBox2.Location = new System.Drawing.Point(1104, -2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(385, 742);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblTime);
            this.groupBox5.Location = new System.Drawing.Point(7, 18);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(372, 83);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(68, 17);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 51);
            this.lblTime.TabIndex = 0;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.dtpPayMonth);
            this.groupBox11.Controls.Add(this.dtpPayDate);
            this.groupBox11.Controls.Add(this.btnSearch);
            this.groupBox11.Controls.Add(this.btnClear);
            this.groupBox11.Controls.Add(this.label41);
            this.groupBox11.Controls.Add(this.label42);
            this.groupBox11.Controls.Add(this.txtEmployeeID2);
            this.groupBox11.Controls.Add(this.label40);
            this.groupBox11.Controls.Add(this.txtFullName);
            this.groupBox11.Controls.Add(this.label39);
            this.groupBox11.Controls.Add(this.txtPaymentID);
            this.groupBox11.Controls.Add(this.label37);
            this.groupBox11.Location = new System.Drawing.Point(6, 261);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(373, 453);
            this.groupBox11.TabIndex = 3;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Search Payment";
            // 
            // dtpPayMonth
            // 
            this.dtpPayMonth.Checked = false;
            this.dtpPayMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPayMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPayMonth.Location = new System.Drawing.Point(153, 262);
            this.dtpPayMonth.Name = "dtpPayMonth";
            this.dtpPayMonth.ShowCheckBox = true;
            this.dtpPayMonth.Size = new System.Drawing.Size(196, 22);
            this.dtpPayMonth.TabIndex = 65;
            // 
            // dtpPayDate
            // 
            this.dtpPayDate.Checked = false;
            this.dtpPayDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPayDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPayDate.Location = new System.Drawing.Point(153, 216);
            this.dtpPayDate.Name = "dtpPayDate";
            this.dtpPayDate.ShowCheckBox = true;
            this.dtpPayDate.Size = new System.Drawing.Size(196, 22);
            this.dtpPayDate.TabIndex = 64;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Black;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(190, 367);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(166, 43);
            this.btnSearch.TabIndex = 62;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Black;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(18, 367);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(166, 43);
            this.btnClear.TabIndex = 59;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.Location = new System.Drawing.Point(22, 214);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(88, 20);
            this.label41.TabIndex = 60;
            this.label41.Text = "Pay Date :";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.Location = new System.Drawing.Point(23, 264);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(98, 20);
            this.label42.TabIndex = 58;
            this.label42.Text = "Pay Month :";
            // 
            // txtEmployeeID2
            // 
            this.txtEmployeeID2.Location = new System.Drawing.Point(153, 103);
            this.txtEmployeeID2.Name = "txtEmployeeID2";
            this.txtEmployeeID2.Size = new System.Drawing.Size(198, 22);
            this.txtEmployeeID2.TabIndex = 57;
            this.txtEmployeeID2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPaymentID_KeyPress);
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(23, 103);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(114, 20);
            this.label40.TabIndex = 56;
            this.label40.Text = "Employee ID :";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(153, 156);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(198, 22);
            this.txtFullName.TabIndex = 55;
            this.txtFullName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPaymentID_KeyPress);
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(22, 156);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(95, 20);
            this.label39.TabIndex = 54;
            this.label39.Text = "Full Name :";
            // 
            // txtPaymentID
            // 
            this.txtPaymentID.Location = new System.Drawing.Point(153, 48);
            this.txtPaymentID.Name = "txtPaymentID";
            this.txtPaymentID.Size = new System.Drawing.Size(198, 22);
            this.txtPaymentID.TabIndex = 51;
            this.txtPaymentID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPaymentID_KeyPress);
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(23, 48);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(106, 20);
            this.label37.TabIndex = 50;
            this.label37.Text = "Payment ID :";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.txtDecimal);
            this.groupBox10.Controls.Add(this.txtMinute);
            this.groupBox10.Controls.Add(this.label36);
            this.groupBox10.Controls.Add(this.btnConvert);
            this.groupBox10.Controls.Add(this.label35);
            this.groupBox10.Controls.Add(this.label34);
            this.groupBox10.Controls.Add(this.txtHour);
            this.groupBox10.Controls.Add(this.label33);
            this.groupBox10.Location = new System.Drawing.Point(6, 132);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(373, 86);
            this.groupBox10.TabIndex = 2;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Convert Time to Decimal";
            // 
            // txtDecimal
            // 
            this.txtDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDecimal.Location = new System.Drawing.Point(288, 47);
            this.txtDecimal.Name = "txtDecimal";
            this.txtDecimal.ReadOnly = true;
            this.txtDecimal.Size = new System.Drawing.Size(63, 24);
            this.txtDecimal.TabIndex = 60;
            this.txtDecimal.Text = "0.00";
            // 
            // txtMinute
            // 
            this.txtMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinute.Location = new System.Drawing.Point(122, 47);
            this.txtMinute.Name = "txtMinute";
            this.txtMinute.Size = new System.Drawing.Size(63, 24);
            this.txtMinute.TabIndex = 59;
            this.txtMinute.Text = "0.00";
            this.txtMinute.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmployeeID_KeyPress);
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(99, 44);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(18, 25);
            this.label36.TabIndex = 58;
            this.label36.Text = ":";
            // 
            // btnConvert
            // 
            this.btnConvert.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnConvert.Location = new System.Drawing.Point(209, 42);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(61, 32);
            this.btnConvert.TabIndex = 57;
            this.btnConvert.Text = "=";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(291, 24);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(58, 17);
            this.label35.TabIndex = 54;
            this.label35.Text = "Decimal";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(119, 24);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(67, 17);
            this.label34.TabIndex = 52;
            this.label34.Text = "Minute(s)";
            // 
            // txtHour
            // 
            this.txtHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHour.Location = new System.Drawing.Point(27, 47);
            this.txtHour.Name = "txtHour";
            this.txtHour.Size = new System.Drawing.Size(63, 24);
            this.txtHour.TabIndex = 51;
            this.txtHour.Text = "0.00";
            this.txtHour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmployeeID_KeyPress);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(30, 22);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(56, 17);
            this.label33.TabIndex = 50;
            this.label33.Text = "Hour(s)";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24});
            this.dataGridView.DataSource = this.payrollBindingSource1;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView.Location = new System.Drawing.Point(0, 792);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1507, 177);
            this.dataGridView.TabIndex = 52;
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PaymentID";
            this.dataGridViewTextBoxColumn1.HeaderText = "PaymentID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "EmployeeID";
            this.dataGridViewTextBoxColumn2.HeaderText = "EmployeeID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FullName";
            this.dataGridViewTextBoxColumn3.HeaderText = "FullName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ESINumber";
            this.dataGridViewTextBoxColumn4.HeaderText = "ESINumber";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PaymentDate";
            this.dataGridViewTextBoxColumn5.HeaderText = "PaymentDate";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "PaymentMonth";
            this.dataGridViewTextBoxColumn6.HeaderText = "PaymentMonth";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "HourlyRate";
            this.dataGridViewTextBoxColumn7.HeaderText = "HourlyRate";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "OvertimeRate";
            this.dataGridViewTextBoxColumn8.HeaderText = "OvertimeRate";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ContractualHours";
            this.dataGridViewTextBoxColumn9.HeaderText = "ContractualHours";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "OvertimeHours";
            this.dataGridViewTextBoxColumn10.HeaderText = "OvertimeHours";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "TotalHours";
            this.dataGridViewTextBoxColumn11.HeaderText = "TotalHours";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "ContractualEarning";
            this.dataGridViewTextBoxColumn12.HeaderText = "ContractualEarning";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "OvertimeEarning";
            this.dataGridViewTextBoxColumn13.HeaderText = "OvertimeEarning";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "TotalEarning";
            this.dataGridViewTextBoxColumn14.HeaderText = "TotalEarning";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "GSTNO";
            this.dataGridViewTextBoxColumn15.HeaderText = "GSTNO";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "TDS";
            this.dataGridViewTextBoxColumn16.HeaderText = "TDS";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "PT";
            this.dataGridViewTextBoxColumn17.HeaderText = "PT";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "ESIC";
            this.dataGridViewTextBoxColumn18.HeaderText = "ESIC";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "LWF";
            this.dataGridViewTextBoxColumn19.HeaderText = "LWF";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "TaxRate";
            this.dataGridViewTextBoxColumn20.HeaderText = "TaxRate";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "PF";
            this.dataGridViewTextBoxColumn21.HeaderText = "PF";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "ADV";
            this.dataGridViewTextBoxColumn22.HeaderText = "ADV";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "TotalDeduction";
            this.dataGridViewTextBoxColumn23.HeaderText = "TotalDeduction";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "NetPay";
            this.dataGridViewTextBoxColumn24.HeaderText = "NetPay";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.ReadOnly = true;
            // 
            // payrollBindingSource1
            // 
            this.payrollBindingSource1.DataMember = "Payroll";
            this.payrollBindingSource1.DataSource = this.payrollSystemDBDataSet11;
            // 
            // payrollSystemDBDataSet11
            // 
            this.payrollSystemDBDataSet11.DataSetName = "PayrollSystemDBDataSet1";
            this.payrollSystemDBDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // payrollSystemDBDataSet1
            // 
            this.payrollSystemDBDataSet1.DataSetName = "PayrollSystemDBDataSet";
            this.payrollSystemDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnComputePay
            // 
            this.btnComputePay.BackColor = System.Drawing.Color.Black;
            this.btnComputePay.ForeColor = System.Drawing.Color.White;
            this.btnComputePay.Image = ((System.Drawing.Image)(resources.GetObject("btnComputePay.Image")));
            this.btnComputePay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComputePay.Location = new System.Drawing.Point(21, 743);
            this.btnComputePay.Name = "btnComputePay";
            this.btnComputePay.Size = new System.Drawing.Size(166, 43);
            this.btnComputePay.TabIndex = 53;
            this.btnComputePay.Text = "      &Compute Pay     ";
            this.btnComputePay.UseVisualStyleBackColor = false;
            this.btnComputePay.Click += new System.EventHandler(this.btnComputePay_Click);
            // 
            // btnSavePay
            // 
            this.btnSavePay.BackColor = System.Drawing.Color.Black;
            this.btnSavePay.ForeColor = System.Drawing.Color.White;
            this.btnSavePay.Image = ((System.Drawing.Image)(resources.GetObject("btnSavePay.Image")));
            this.btnSavePay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSavePay.Location = new System.Drawing.Point(241, 743);
            this.btnSavePay.Name = "btnSavePay";
            this.btnSavePay.Size = new System.Drawing.Size(166, 43);
            this.btnSavePay.TabIndex = 54;
            this.btnSavePay.Text = "   &Save Pay  ";
            this.btnSavePay.UseVisualStyleBackColor = false;
            this.btnSavePay.Click += new System.EventHandler(this.btnSavePay_Click);
            // 
            // btnGeneratePayslip
            // 
            this.btnGeneratePayslip.BackColor = System.Drawing.Color.Black;
            this.btnGeneratePayslip.ForeColor = System.Drawing.Color.White;
            this.btnGeneratePayslip.Image = ((System.Drawing.Image)(resources.GetObject("btnGeneratePayslip.Image")));
            this.btnGeneratePayslip.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGeneratePayslip.Location = new System.Drawing.Point(848, 743);
            this.btnGeneratePayslip.Name = "btnGeneratePayslip";
            this.btnGeneratePayslip.Size = new System.Drawing.Size(165, 45);
            this.btnGeneratePayslip.TabIndex = 56;
            this.btnGeneratePayslip.Text = "&Generate Payslip ";
            this.btnGeneratePayslip.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGeneratePayslip.UseVisualStyleBackColor = false;
            this.btnGeneratePayslip.Click += new System.EventHandler(this.btnGeneratePayslip_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Black;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(645, 743);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(168, 43);
            this.btnReset.TabIndex = 59;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Black;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(1327, 743);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(168, 43);
            this.btnExit.TabIndex = 60;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // payrollTableAdapter
            // 
            this.payrollTableAdapter.ClearBeforeFill = true;
            // 
            // btnPrintPayslip
            // 
            this.btnPrintPayslip.BackColor = System.Drawing.Color.Black;
            this.btnPrintPayslip.ForeColor = System.Drawing.Color.White;
            this.btnPrintPayslip.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintPayslip.Image")));
            this.btnPrintPayslip.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrintPayslip.Location = new System.Drawing.Point(1046, 742);
            this.btnPrintPayslip.Name = "btnPrintPayslip";
            this.btnPrintPayslip.Size = new System.Drawing.Size(165, 45);
            this.btnPrintPayslip.TabIndex = 58;
            this.btnPrintPayslip.Text = "&Print Payslip";
            this.btnPrintPayslip.UseVisualStyleBackColor = false;
            this.btnPrintPayslip.Click += new System.EventHandler(this.btnPrintPayslip_Click);
            // 
            // btnDeletePay
            // 
            this.btnDeletePay.BackColor = System.Drawing.Color.Black;
            this.btnDeletePay.ForeColor = System.Drawing.Color.White;
            this.btnDeletePay.Image = ((System.Drawing.Image)(resources.GetObject("btnDeletePay.Image")));
            this.btnDeletePay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeletePay.Location = new System.Drawing.Point(440, 743);
            this.btnDeletePay.Name = "btnDeletePay";
            this.btnDeletePay.Size = new System.Drawing.Size(168, 43);
            this.btnDeletePay.TabIndex = 61;
            this.btnDeletePay.Text = "&Delete Pay";
            this.btnDeletePay.UseVisualStyleBackColor = false;
            this.btnDeletePay.Click += new System.EventHandler(this.btnDeletePay_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // PayrollCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1507, 969);
            this.Controls.Add(this.btnDeletePay);
            this.Controls.Add(this.btnGeneratePayslip);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPrintPayslip);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSavePay);
            this.Controls.Add(this.btnComputePay);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PayrollCalculator";
            this.Text = "Payroll Calculator";
            this.Load += new System.EventHandler(this.PayrollCalculator_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.dates.ResumeLayout(false);
            this.dates.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hourlyRate)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sat4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sat3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sat2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sat1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fri4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fri3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fri2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fri1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thu4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thu3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thu2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wed4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wed3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wed2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wed1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tue4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tue3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tue2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tue1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mon4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mon3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mon2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mon1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollSystemDBDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollSystemDBDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox dates;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.NumericUpDown sat4;
        private System.Windows.Forms.NumericUpDown sat3;
        private System.Windows.Forms.NumericUpDown sat2;
        private System.Windows.Forms.NumericUpDown sat1;
        private System.Windows.Forms.NumericUpDown fri4;
        private System.Windows.Forms.NumericUpDown fri3;
        private System.Windows.Forms.NumericUpDown fri2;
        private System.Windows.Forms.NumericUpDown fri1;
        private System.Windows.Forms.NumericUpDown thu4;
        private System.Windows.Forms.NumericUpDown thu3;
        private System.Windows.Forms.NumericUpDown thu2;
        private System.Windows.Forms.NumericUpDown thu1;
        private System.Windows.Forms.NumericUpDown wed4;
        private System.Windows.Forms.NumericUpDown wed3;
        private System.Windows.Forms.NumericUpDown wed2;
        private System.Windows.Forms.NumericUpDown wed1;
        private System.Windows.Forms.NumericUpDown tue4;
        private System.Windows.Forms.NumericUpDown tue3;
        private System.Windows.Forms.NumericUpDown tue2;
        private System.Windows.Forms.NumericUpDown tue1;
        private System.Windows.Forms.NumericUpDown mon4;
        private System.Windows.Forms.NumericUpDown mon3;
        private System.Windows.Forms.NumericUpDown mon2;
        private System.Windows.Forms.NumericUpDown mon1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtESINumber;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnGet;
        private PayrollSystemDBDataSet payrollSystemDBDataSet1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker dtpCurrentDate;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown hourlyRate;
        private System.Windows.Forms.TextBox txtTotalDeduction;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtESIContribution;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtTDS;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtTotalEarning;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtOvertimeEarning;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtContractualEarning;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtTotalHours;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtOvertimeRate;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtOvertimeHours;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtContractualHours;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtTaxCode;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.LinkLabel llWindowsCalculator;
        private System.Windows.Forms.TextBox txtNetPay;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox txtEmployeeID2;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TextBox txtPaymentID;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox txtDecimal;
        private System.Windows.Forms.TextBox txtMinute;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox txtHour;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnComputePay;
        private System.Windows.Forms.Button btnSavePay;
        private System.Windows.Forms.Button btnGeneratePayslip;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtTaxRate;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.TextBox txtPF;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox txtPT;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtADV;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtLWF;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.DateTimePicker dtpPayDate;
        private System.Windows.Forms.DateTimePicker dtpPaymentMonth;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.BindingSource payrollBindingSource;
        private PayrollSystemDBDataSet1 payrollSystemDBDataSet11;
        private System.Windows.Forms.BindingSource payrollBindingSource1;
        private PayrollSystemDBDataSet1TableAdapters.PayrollTableAdapter payrollTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.Button btnPrintPayslip;
        private System.Windows.Forms.TextBox txtPaymentID2;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Button btnDeletePay;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DateTimePicker dtpPayMonth;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label38;
    }
}