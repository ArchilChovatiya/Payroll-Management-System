using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayRoll_Application
{
    public partial class PayrollCalculator : Form
    {

        public PayrollCalculator()
        {
            InitializeComponent();
        }

        private void PayrollCalculator_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'payrollSystemDBDataSet11.Payroll' table. You can move, or remove it, as needed.
            this.payrollTableAdapter.Fill(this.payrollSystemDBDataSet11.Payroll);
            timer1.Start();
            dtpPaymentMonth.CustomFormat = " MM/yyyy";
            dtpPayMonth.CustomFormat = " MM/yyyy";
           
        }
        private void btnGet_Click(object sender, EventArgs e)
        {
            setNameDetails();
        }
        private void setNameDetails()
        {
            string cs = ConfigurationManager.ConnectionStrings["PayrollSystemDBConnectionStringMS"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            String selectCommand = "SELECT FirstName,LastName,ESINumber FROM EMPLOYEE WHERE EmployeeID=" + txtEmployeeID.Text;
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand(selectCommand, con);
                SqlDataReader sdr = com.ExecuteReader();
                if (sdr.Read())
                {
                    txtFirstName.Text = sdr[0].ToString();
                    txtLastName.Text = sdr[1].ToString();
                    txtESINumber.Text = sdr[2].ToString();
                }
                else
                {
                    MessageBox.Show("No Records Found of EmployeeID " + txtEmployeeID.Text, "No Record Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message, "SQL error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            lblName.Text = txtFirstName.Text + " " + txtLastName.Text;
        }

        private void txtEmployeeID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void GetWeek1Values()
        {
            Mon1 = getValues(mon1);
            Tue1 = getValues(tue1);
            Wed1 = getValues(wed1);
            Thu1 = getValues(thu1);
            Fri1 = getValues(fri1);
            Sat1 = getValues(sat1);
        }
        private void GetWeek2Values()
        {
            Mon2 = getValues(mon2);
            Tue2 = getValues(tue2);
            Wed2 = getValues(wed2);
            Thu2 = getValues(thu2);
            Fri2 = getValues(fri2);
            Sat2 = getValues(sat2);
        }
        private void GetWeek3Values()
        {
            Mon3 = getValues(mon3);
            Tue3 = getValues(tue3);
            Wed3 = getValues(wed3);
            Thu3 = getValues(thu3);
            Fri3 = getValues(fri3);
            Sat3 = getValues(sat3);
        }
        private void GetWeek4Values()
        {
            Mon4 = getValues(mon4);
            Tue4 = getValues(tue4);
            Wed4 = getValues(wed4);
            Thu4 = getValues(thu4);
            Fri4 = getValues(fri4);
            Sat4 = getValues(sat4);
        }

        double getValues(NumericUpDown nud)
        {
            try
            {
                return double.Parse(nud.Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("The following error occoured : " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nud.Focus();
            }
            return 0;
        }

        private void btnComputePay_Click(object sender, EventArgs e)
        {
            GetWeek1Values();
            GetWeek2Values();
            GetWeek3Values();
            GetWeek4Values();

            totalHoursWK1 = Mon1 + Tue1 + Wed1 + Thu1 + Fri1 + Sat1;
            totalHoursWK2 = Mon2 + Tue2 + Wed2 + Thu2 + Fri2 + Sat2;
            totalHoursWK3 = Mon3 + Tue3 + Wed3 + Thu3 + Fri3 + Sat3;
            totalHoursWK4 = Mon4 + Tue4 + Wed4 + Thu4 + Fri4 + Sat4;


            try
            {
                hourlySalaryRate = double.Parse(hourlyRate.Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("The following error occoured : " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                hourlyRate.Focus();
            }

            try
            {
                if (txtOvertimeRate.Text == "")
                {
                    overtimeSalaryRate = hourlySalaryRate * 1.5;
                    MessageBox.Show("No overtime Salary rate is provided so it is considered 1.5 * hourlySalaryRate as standerds.", "No Overtime Salary Rate Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    overtimeSalaryRate = double.Parse(txtOvertimeRate.Text.ToString());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("The following error occoured : " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (totalHoursWK1 <= 36)
            {
                contractualHoursWK1 = totalHoursWK1;
                contractualAmountWK1 = hourlySalaryRate * totalHoursWK1;
                overtimeHoursWK1 = 0;
                overtimeAmountWK1 = 0;
            }
            else
            {
                contractualHoursWK1 = 36;
                contractualAmountWK1 = hourlySalaryRate * 36;
                overtimeHoursWK1 = totalHoursWK1 - 36;
                overtimeAmountWK1 = overtimeHoursWK1 * overtimeSalaryRate;
            }

            if (totalHoursWK2 <= 36)
            {
                contractualHoursWK2 = totalHoursWK2;
                contractualAmountWK2 = hourlySalaryRate * totalHoursWK2;
                overtimeHoursWK2 = 0;
                overtimeAmountWK2 = 0;
            }
            else
            {
                contractualHoursWK2 = 36;
                contractualAmountWK2 = hourlySalaryRate * 36;
                overtimeHoursWK2 = totalHoursWK2 - 36;
                overtimeAmountWK2 = overtimeHoursWK2 * overtimeSalaryRate;
            }

            if (totalHoursWK3 <= 36)
            {
                contractualHoursWK3 = totalHoursWK3;
                contractualAmountWK3 = hourlySalaryRate * totalHoursWK3;
                overtimeHoursWK3 = 0;
                overtimeAmountWK3 = 0;
            }
            else
            {
                contractualHoursWK3 = 36;
                contractualAmountWK3 = hourlySalaryRate * 36;
                overtimeHoursWK3 = totalHoursWK3 - 36;
                overtimeAmountWK3 = overtimeHoursWK3 * overtimeSalaryRate;
            }

            if (totalHoursWK4 <= 36)
            {
                contractualHoursWK4 = totalHoursWK4;
                contractualAmountWK4 = hourlySalaryRate * totalHoursWK4;
                overtimeHoursWK4 = 0;
                overtimeAmountWK4 = 0;
            }
            else
            {
                contractualHoursWK4 = 36;
                contractualAmountWK4 = hourlySalaryRate * 36;
                overtimeHoursWK4 = totalHoursWK4 - 36;
                overtimeAmountWK4 = overtimeHoursWK4 * overtimeSalaryRate;
            }

            totalContractualHours = contractualHoursWK1 + contractualHoursWK2 + contractualHoursWK3 + contractualHoursWK4;
            totalContractualAmount = contractualAmountWK1 + contractualAmountWK2 + contractualAmountWK3 + contractualAmountWK4;
            totalOvertimeHours = overtimeHoursWK1 + overtimeHoursWK2 + overtimeHoursWK3 + overtimeHoursWK4;
            totalOvertimeAmount = overtimeAmountWK1 + overtimeAmountWK2 + overtimeAmountWK3 + overtimeAmountWK4;
            totalHoursWorked = totalContractualHours + totalOvertimeHours;
            totalAmountEarned = totalContractualAmount + totalOvertimeAmount;

            txtContractualHours.Text = totalContractualHours.ToString();
            txtOvertimeHours.Text = totalOvertimeHours.ToString();
            txtOvertimeRate.Text = overtimeSalaryRate.ToString();
            txtTotalHours.Text = totalHoursWorked.ToString();

            txtContractualEarning.Text = totalContractualAmount.ToString();
            txtOvertimeEarning.Text = totalOvertimeAmount.ToString();
            txtTotalEarning.Text = totalAmountEarned.ToString();


            if (totalAmountEarned * 12 <= 250000)
            {
                taxRate = 0;
            }
            else if (totalAmountEarned * 12 <= 500000)
            {
                taxRate = 0.05;
            }
            else if (totalAmountEarned * 12 <= 750000)
            {
                taxRate = 0.1;
            }
            else if (totalAmountEarned * 12 <= 1000000)
            {
                taxRate = 0.15;
            }
            else if (totalAmountEarned * 12 <= 1250000)
            {
                taxRate = 0.20;
            }
            else if (totalAmountEarned * 12 <= 1500000)
            {
                taxRate = 0.25;
            }
            else
            {
                taxRate = 0.30;
            }

            tax = taxRate * totalAmountEarned;

            txtTDS.Text = tax.ToString();
            txtTaxRate.Text = taxRate.ToString() + "%";
            ESIContribution = 0;
            if (totalAmountEarned < 15000)
            {
                ESIContribution = totalAmountEarned * 0.01;
            }
            txtESIContribution.Text = ESIContribution.ToString();
            PF = double.Parse(txtPF.Text);
            PT = double.Parse(txtPT.Text);
            LWF = double.Parse(txtLWF.Text);
            ADV = double.Parse(txtADV.Text);

            totalDeductions = tax + PF + PT + LWF + ADV + ESIContribution;
            txtTotalDeduction.Text = totalDeductions.ToString();

            netPay = totalAmountEarned - totalDeductions;

            txtNetPay.Text = netPay.ToString();

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            txtDecimal.Text = Math.Round((double.Parse(txtHour.Text) + (double.Parse(txtMinute.Text) / 60)), 2).ToString();
        }

        private void reset()
        {
            txtEmployeeID.Clear();
            txtFirstName.Text = "AUTO";
            txtLastName.Text = "AUTO";
            txtESINumber.Text = "AUTO";
            dtpCurrentDate.ResetText();
            mon1.Value = 0;
            tue1.Value = 0;
            wed1.Value = 0;
            thu1.Value = 0;
            fri1.Value = 0;
            sat1.Value = 0;
            mon2.Value = 0;
            tue2.Value = 0;
            wed2.Value = 0;
            thu2.Value = 0;
            fri2.Value = 0;
            sat2.Value = 0;
            mon3.Value = 0;
            tue3.Value = 0;
            wed3.Value = 0;
            thu3.Value = 0;
            fri3.Value = 0;
            sat3.Value = 0;
            mon4.Value = 0;
            tue4.Value = 0;
            wed4.Value = 0;
            thu4.Value = 0;
            fri4.Value = 0;
            sat4.Value = 0;
            hourlyRate.Value = 150;
            txtContractualHours.Text = "AUTO";
            txtOvertimeHours.Text = "AUTO";
            txtOvertimeRate.Text = "";
            txtTotalHours.Text = "AUTO";
            txtContractualEarning.Text = "AUTO";
            txtOvertimeEarning.Text = "AUTO";
            txtTotalEarning.Text = "AUTO";
            txtTDS.Text = "AUTO";
            txtPT.Text = "120";
            txtESIContribution.Text = "AUTO";
            txtLWF.Text = "0";
            txtTaxRate.Text = "AUTO";
            txtPF.Text = "100";
            txtADV.Text = "0";
            txtTotalDeduction.Text = "AUTO";
            txtNetPay.Text = "AUTO";
            txtHour.Text = "0.00";
            txtMinute.Text = "0.00";
            txtDecimal.Text = "0.00";
            txtPaymentID2.Text = "AUTO";
            dtpPaymentMonth.ResetText();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }
        private void btnSavePay_Click(object sender, EventArgs e)
        {
            string CreatePaymentID(int length)
            {
                const string valid = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
                StringBuilder res = new StringBuilder();
                Random rnd = new Random();
                while (0 < length--)
                {
                    res.Append(valid[rnd.Next(valid.Length)]);
                }
                if (txtPaymentID2.Text == "AUTO")
                {
                    return res.ToString();
                }
                else
                    return txtPaymentID2.Text;

            }

            string cs = ConfigurationManager.ConnectionStrings["PayrollSystemDBConnectionStringMS"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            String Pid= CreatePaymentID(10);
            String selectCommand = "INSERT INTO PAYROLL VALUES('"+ Pid + "',"+txtEmployeeID.Text + ",'"
                + txtFirstName.Text + " " + txtLastName.Text + "','" + txtESINumber.Text + "','" + dtpCurrentDate.Text + "','" + dtpPaymentMonth.Text
                + "','" + hourlyRate.Value + "','" + txtOvertimeRate.Text + "'," + txtContractualHours.Text + "," + txtOvertimeHours.Text + "," + txtTotalHours.Text + ",'" +
                txtContractualEarning.Text + "','" + txtOvertimeEarning.Text + "','" + txtTotalEarning.Text + "','" + txtTaxCode.Text + "','" + txtTDS.Text + "','" + txtPT.Text + "','" +
                txtESIContribution.Text + "','" + txtLWF.Text + "','" + txtTaxRate.Text + "','" + txtPF.Text + "','" + txtADV.Text + "','" + txtTotalDeduction.Text + "','" +
                txtNetPay.Text + "')";
            txtPaymentID2.Text = Pid;
            try
            {
                if(txtFirstName.Text=="AUTO" || txtContractualEarning.Text=="AUTO" || 
                    !dtpPaymentMonth.Checked || !dtpCurrentDate.Checked)
                {
                    MessageBox.Show("Please Enter Proper Details","",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                    con.Open();
                    SqlCommand com = new SqlCommand(selectCommand, con);
                    com.ExecuteNonQuery();
                    this.payrollTableAdapter.Fill(this.payrollSystemDBDataSet11.Payroll);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message, "SQL error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGeneratePayslip_Click(object sender, EventArgs e)
        {
            if(txtLastName.Text!="AUTO" && txtNetPay.Text!="AUTO" && dtpCurrentDate.Checked==true && dtpPaymentMonth.Checked==true)
            {
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.Show();
            }
            else
            {
                MessageBox.Show("Please Enter Proper Details", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnPrintPayslip_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            printDialog1.ShowDialog();
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var reader = dataGridView.Rows[e.RowIndex].Cells;
            txtPaymentID2.Text = reader[0].FormattedValue.ToString();
            txtEmployeeID.Text = reader[1].FormattedValue.ToString();
            setNameDetails();
            dtpCurrentDate.Text = reader[4].FormattedValue.ToString();
            dtpPaymentMonth.Text = reader[5].FormattedValue.ToString();
            dtpPaymentMonth.Checked = true;
            dtpCurrentDate.Checked = true;
            hourlyRate.Value = decimal.Parse(reader[6].FormattedValue.ToString());
            txtOvertimeRate.Text= reader[7].FormattedValue.ToString();
            txtContractualHours.Text = reader[8].FormattedValue.ToString();
            txtOvertimeHours.Text= reader[9].FormattedValue.ToString();
            txtTotalHours.Text= reader[10].FormattedValue.ToString();
            txtContractualEarning.Text= reader[11].FormattedValue.ToString();
            txtOvertimeEarning.Text= reader[12].FormattedValue.ToString();
            txtTotalEarning.Text= reader[13].FormattedValue.ToString();
            txtTDS.Text= reader[15].FormattedValue.ToString();
            txtPT.Text= reader[16].FormattedValue.ToString();
            txtESIContribution.Text= reader[17].FormattedValue.ToString();
            txtLWF.Text= reader[18].FormattedValue.ToString();
            txtTaxRate.Text= reader[19].FormattedValue.ToString();
            txtPF.Text= reader[20].FormattedValue.ToString();
            txtADV.Text= reader[21].FormattedValue.ToString();
            txtTotalDeduction.Text= reader[22].FormattedValue.ToString();
            txtNetPay.Text= reader[23].FormattedValue.ToString();

        }

        private void btnDeletePay_Click(object sender, EventArgs e)
        {
            if(txtPaymentID2.Text=="AUTO")
            {
                MessageBox.Show("Please select record to delete", "Record not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string cs = ConfigurationManager.ConnectionStrings["PayrollSystemDBConnectionStringMS"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                String selectCommand = "DELETE FROM PAYROLL WHERE PaymentID='" + txtPaymentID2.Text+"'";
                
                try
                {
                    con.Open();
                    SqlCommand com = new SqlCommand(selectCommand, con);
                    com.ExecuteNonQuery();
                    this.payrollTableAdapter.Fill(this.payrollSystemDBDataSet11.Payroll);
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error : " + ex.Message, "SQL error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void llWindowsCalculator_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            lblTime.Text = dt.ToString("HH : mm : ss");
        }

        private void setFilter()
        {
            try
            {
                StringBuilder ss = new StringBuilder();
                if (txtPaymentID.Text.Length > 0)
                {
                    ss.Append("Convert(PaymentID,'System.String') like '%" + txtPaymentID.Text + "%'");
                }
                if (txtEmployeeID2.Text.Length > 0)
                {
                    if(ss.Length > 0)
                    {
                        ss.Append(" and ");
                    }
                    ss.Append("Convert(EmployeeID,'System.String') like '%" + txtEmployeeID2.Text + "%'");
                }
                if (txtFullName.Text.Length > 0)
                {
                    if (ss.Length > 0)
                    {
                        ss.Append(" and ");
                    }
                    ss.Append("Convert(FullName,'System.String') like '%" + txtFullName.Text + "%'");
                }
                if (dtpPayDate.Text.Length > 0 && dtpPayDate.Checked)
                {
                    if (ss.Length > 0)
                    {
                        ss.Append(" and ");
                    }
                    ss.Append("Convert(PaymentDate,'System.String') like '%" + dtpPayDate.Text + "%'");
                }
                if (dtpPayMonth.Text.Length > 0 && dtpPayMonth.Checked)
                {
                    if (ss.Length > 0)
                    {
                        ss.Append(" and ");
                    }
                    ss.Append("Convert(PaymentMonth,'System.String') like '%" + dtpPayMonth.Text + "%'");
                }
                payrollBindingSource1.Filter = ss.ToString();
              
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message, "SQL error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            setFilter();
        }

        private void txtPaymentID_KeyPress(object sender, KeyPressEventArgs e)
        {
            setFilter();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPaymentID.Text = "";
            txtEmployeeID2.Text = "";
            txtFullName.Text = "";
            dtpPayDate.ResetText();
            dtpPayMonth.ResetText();
            dtpPayMonth.Checked = false;
            dtpPayDate.Checked = false;
            setFilter();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawLine(new Pen(Color.Blue, 2), 60, 90, 750, 90);
            Image objImage = Image.FromFile(@"C:\Users\archi\source\repos\PayRoll Application\PayRoll Application\icon\CompanyLogo.png");
            e.Graphics.DrawImage(objImage, 60, 100);
            e.Graphics.DrawString("ABC Company Pvt. Ltd.", new Font("Arial", 24, FontStyle.Bold), Brushes.DarkBlue, new Point(220, 110));
            e.Graphics.DrawLine(new Pen(Color.Blue, 2), 60, 230, 750, 230);
            e.Graphics.DrawString("Payment Date : " + dtpCurrentDate.Value.ToString("dd/mm/yyyy"), new Font("Times New Roman", 12, FontStyle.Bold), Brushes.DarkBlue, new Point(70, 240));
            e.Graphics.DrawString("Payment ID : " + txtPaymentID2.Text, new Font("Times New Roman", 12, FontStyle.Bold), Brushes.DarkBlue, new Point(500, 240));


            e.Graphics.DrawString("Employee ID : " + txtEmployeeID.Text, new Font("Times New Roman", 12, FontStyle.Bold), Brushes.DarkBlue, new Point(70, 300));
            e.Graphics.DrawString("ESI Number : " + txtESINumber.Text, new Font("Times New Roman", 12, FontStyle.Bold), Brushes.DarkBlue, new Point(500, 300));
            e.Graphics.DrawString("Name : " + txtFirstName.Text + " " + txtLastName.Text, new Font("Times New Roman", 12, FontStyle.Bold), Brushes.DarkBlue, new Point(70, 330));
            e.Graphics.DrawLine(new Pen(Color.Blue, 2), 60, 290, 750, 290);
            e.Graphics.DrawLine(new Pen(Color.Blue, 2), 60, 360, 750, 360);
            e.Graphics.DrawLine(new Pen(Color.Blue, 2), 60, 290, 60, 360);
            e.Graphics.DrawLine(new Pen(Color.Blue, 2), 750, 290, 750, 360);

            e.Graphics.DrawString("EARNINGS ", new Font("Times New Roman", 12, FontStyle.Bold), Brushes.DarkBlue, new Point(70, 400));
            e.Graphics.DrawString("HOURS ", new Font("Times New Roman", 12, FontStyle.Bold), Brushes.DarkBlue, new Point(205, 400));
            e.Graphics.DrawString("RATES ", new Font("Times New Roman", 12, FontStyle.Bold), Brushes.DarkBlue, new Point(280, 400));
            e.Graphics.DrawString("AMOUNTS ", new Font("Times New Roman", 12, FontStyle.Bold), Brushes.DarkBlue, new Point(360, 400));
            e.Graphics.DrawString("DEDUCTIONS ", new Font("Times New Roman", 12, FontStyle.Bold), Brushes.DarkBlue, new Point(510, 400));
            e.Graphics.DrawString("AMOUNTS ", new Font("Times New Roman", 12, FontStyle.Bold), Brushes.DarkBlue, new Point(640, 400));
            e.Graphics.DrawLine(new Pen(Color.Blue, 3), 60, 425, 750, 425);

            e.Graphics.DrawString("BASIC : ", new Font("Times New Roman", 12, FontStyle.Bold), Brushes.DarkBlue, new Point(70, 440));
            e.Graphics.DrawString("OVERTIME : ", new Font("Times New Roman", 12, FontStyle.Bold), Brushes.DarkBlue, new Point(70, 470));

            e.Graphics.DrawString( txtContractualHours.Text, new Font("Times New Roman", 12, FontStyle.Italic), Brushes.DarkBlue, new Point(205, 440));
            e.Graphics.DrawString("₹" + hourlyRate.Value.ToString(), new Font("Times New Roman", 12, FontStyle.Italic), Brushes.DarkBlue, new Point(280, 440));
            e.Graphics.DrawString("₹" + txtContractualEarning.Text, new Font("Times New Roman", 12, FontStyle.Italic), Brushes.DarkBlue, new Point(360, 440));
            e.Graphics.DrawString(txtOvertimeHours.Text, new Font("Times New Roman", 12, FontStyle.Italic), Brushes.DarkBlue, new Point(205, 470));
            e.Graphics.DrawString("₹" + txtOvertimeRate.Text, new Font("Times New Roman", 12, FontStyle.Italic), Brushes.DarkBlue, new Point(280, 470));
            e.Graphics.DrawString("₹" + txtOvertimeEarning.Text, new Font("Times New Roman", 12, FontStyle.Italic), Brushes.DarkBlue, new Point(360, 470));


            e.Graphics.DrawString("TDS : ", new Font("Times New Roman", 12, FontStyle.Bold), Brushes.DarkBlue, new Point(510, 440));
            e.Graphics.DrawString("P.T : ", new Font("Times New Roman", 12, FontStyle.Bold), Brushes.DarkBlue, new Point(510, 470));
            e.Graphics.DrawString("ESIC : ", new Font("Times New Roman", 12, FontStyle.Bold), Brushes.DarkBlue, new Point(510, 500));
            e.Graphics.DrawString("P.F : ", new Font("Times New Roman", 12, FontStyle.Bold), Brushes.DarkBlue, new Point(510, 530));
            e.Graphics.DrawString("L.W.F : ", new Font("Times New Roman", 12, FontStyle.Bold), Brushes.DarkBlue, new Point(510, 560));
            e.Graphics.DrawString("ADV : ", new Font("Times New Roman", 12, FontStyle.Bold), Brushes.DarkBlue, new Point(510, 590));

            e.Graphics.DrawString("₹" + txtTDS.Text, new Font("Times New Roman", 12, FontStyle.Italic), Brushes.DarkBlue, new Point(640, 440));
            e.Graphics.DrawString("₹" + txtPT.Text, new Font("Times New Roman", 12, FontStyle.Italic), Brushes.DarkBlue, new Point(640, 470));
            e.Graphics.DrawString("₹" + txtESIContribution.Text, new Font("Times New Roman", 12, FontStyle.Italic), Brushes.DarkBlue, new Point(640, 500));
            e.Graphics.DrawString("₹" + txtPF.Text, new Font("Times New Roman", 12, FontStyle.Italic), Brushes.DarkBlue, new Point(640, 530));
            e.Graphics.DrawString("₹" + txtLWF.Text, new Font("Times New Roman", 12, FontStyle.Italic), Brushes.DarkBlue, new Point(640, 560));
            e.Graphics.DrawString("₹" + txtADV.Text, new Font("Times New Roman", 12, FontStyle.Italic), Brushes.DarkBlue, new Point(640, 590));

            e.Graphics.DrawLine(new Pen(Color.Blue, 3), 60, 625, 750, 625);

            e.Graphics.DrawString("TOTAL EARNINGS : ", new Font("Times New Roman", 12, FontStyle.Bold), Brushes.DarkBlue, new Point(70, 640));
            e.Graphics.DrawString("₹" + txtTotalEarning.Text, new Font("Times New Roman", 12, FontStyle.Italic), Brushes.DarkBlue, new Point(360, 640));
            e.Graphics.DrawString("TOTAL  ", new Font("Times New Roman", 12, FontStyle.Bold), Brushes.DarkBlue, new Point(505, 640));
            e.Graphics.DrawString("DEDUCTIONS : ", new Font("Times New Roman", 12, FontStyle.Bold), Brushes.DarkBlue, new Point(505, 660));

            e.Graphics.DrawString("₹" + txtTotalDeduction.Text, new Font("Times New Roman", 12, FontStyle.Italic), Brushes.DarkBlue, new Point(640, 660));

            e.Graphics.DrawLine(new Pen(Color.Blue, 3), 60, 690, 750, 690);

            e.Graphics.DrawLine(new Pen(Color.Blue, 3), 60, 715, 750, 715);
            e.Graphics.DrawLine(new Pen(Color.Blue, 3), 60, 760, 750, 760);
            e.Graphics.DrawLine(new Pen(Color.Blue, 3), 60, 715, 60, 760);
            e.Graphics.DrawLine(new Pen(Color.Blue, 3), 750, 715, 750, 760);

            e.Graphics.DrawString("NET PAY : ", new Font("Times New Roman", 12, FontStyle.Bold), Brushes.DarkBlue, new Point(505, 730));
            e.Graphics.DrawString("₹" + txtNetPay.Text, new Font("Times New Roman", 12, FontStyle.Italic), Brushes.DarkBlue, new Point(610, 730));

        }


    }
}
