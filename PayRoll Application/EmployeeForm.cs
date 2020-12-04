using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PayRoll_Application
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
            LogIn lg = new LogIn();
            lg.setForm(this);
            lg.ShowDialog();
        }
        private void EmployeeForm_Load(object sender, EventArgs e)
        {
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtEmployeeID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }

        }
        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        private void txtNationalInsuranceNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        private void txtCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        public bool isValud()
        {
            if (txtEmployeeID.Text.Length != 10)
            {
                txtEmployeeID.Focus();
                txtEmployeeID.BackColor = Color.Silver;
                MessageBox.Show("Username must be of length 10.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                txtEmployeeID.BackColor = Color.White;
            }


            if (txtFirstName.Text.Length <= 0)
            {
                txtFirstName.Focus();
                txtFirstName.BackColor = Color.Silver;
                MessageBox.Show("Plese enter valid First Name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                txtFirstName.BackColor = Color.White;
            }


            if (txtLastName.Text.Length <= 0)
            {
                txtLastName.Focus();
                txtLastName.BackColor = Color.Silver;
                MessageBox.Show("Plese enter valid Last Name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                txtLastName.BackColor = Color.White;
            }


            if (txtNationalInsuranceNo.Text.Length != 10)
            {
                txtNationalInsuranceNo.Focus();
                txtNationalInsuranceNo.BackColor = Color.Silver;
                MessageBox.Show("Plese enter valid National Insurance No.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                txtNationalInsuranceNo.BackColor = Color.White;
            }

            if (txtAddress.Text.Length <= 0)
            {
                txtAddress.Focus();
                txtAddress.BackColor = Color.Silver;
                MessageBox.Show("Plese enter valid Address.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                txtAddress.BackColor = Color.White;
            }


            if (txtCity.Text.Length <= 0)
            {
                txtCity.Focus();
                txtCity.BackColor = Color.Silver;
                MessageBox.Show("Plese enter valid City.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                txtCity.BackColor = Color.White;
            }


            if (txtPostCode.Text.Length != 6)
            {
                txtPostCode.Focus();
                txtPostCode.BackColor = Color.Silver;
                MessageBox.Show("Plese enter valid Post Code.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                txtPostCode.BackColor = Color.White;
            }


            if (cbCountry.SelectedIndex == -1)
            {
                cbCountry.Focus();
                cbCountry.BackColor = Color.Silver;
                MessageBox.Show("Plese select Country.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                cbCountry.BackColor = Color.White;
            }


            if (txtPhoneNumber.Text.Length != 12)
            {
                txtPhoneNumber.Focus();
                txtPhoneNumber.BackColor = Color.Silver;
                MessageBox.Show("Plese enter valid Phone No.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                txtPhoneNumber.BackColor = Color.White;
            }
            String email = txtEmail.Text;
            email = email.Trim();
            Regex expr = new Regex(@"^[A-Za-z0-9]+[.]{0,1}[A-Za-z0-9]+[@]{1}[a-z]{2,10}[.]{1}[a-z]{2,3}$");

            if (!expr.IsMatch(email))
            {
                txtEmail.Focus();
                txtEmail.BackColor = Color.Silver;
                MessageBox.Show("Plese enter valid Email.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                txtEmail.BackColor = Color.White;
            }

            return true;
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            if (isValud())
            {


                string cs = ConfigurationManager.ConnectionStrings["PayrollSystemDBConnectionStringMS"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                try
                {
                    DialogResult dr = MessageBox.Show("Do you want to add EmployeeID " + txtEmployeeID.Text+" ?", "Confirm add event", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if(dr==DialogResult.Yes)
                    {
                        con.Open();
                        string InsertCommand = "INSERT INTO EMPLOYEE VALUES(" + int.Parse(txtEmployeeID.Text) + ",'" + txtFirstName.Text + "','" +
                            txtLastName.Text + "','" + checkGender() + "','" + txtNationalInsuranceNo.Text + "','" +
                            dateTimePicker.Text + "','" + checkMaritalStatus() + "','" + txtAddress.Text + "','" + txtCity.Text + "','" +
                            txtPostCode.Text + "','" + cbCountry.SelectedItem + "','" + txtPhoneNumber.Text + "','" + txtEmail.Text + "','" +
                            txtNotes.Text + "')";
                        SqlCommand com = new SqlCommand(InsertCommand, con);
                        com.ExecuteNonQuery();
                        MessageBox.Show("EmployeeID: " + txtEmployeeID.Text + "inserted successfully!", "Employee Add event", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error : " + ex.Message, "SQL error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtEmployeeID.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            rdbMale.Select();
            rdbMarried.Checked = true;//two methods to check radio button
            txtNationalInsuranceNo.Clear();
            txtAddress.Clear();
            txtCity.Clear();
            txtPostCode.Clear();
            cbCountry.SelectedIndex = -1;
            txtPhoneNumber.Clear();
            txtNotes.Clear();
            txtEmail.Clear();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {

            if (isValud())
            {

                PreviewForm preview_form = new PreviewForm();
                preview_form.setPreview(txtEmployeeID.Text, txtFirstName.Text, txtLastName.Text, checkGender(),
                                        txtNationalInsuranceNo.Text, dateTimePicker.Text, checkMaritalStatus(),
                                        txtAddress.Text, txtCity.Text, txtPostCode.Text, cbCountry.SelectedItem.ToString(),
                                        txtPhoneNumber.Text, txtEmail.Text, txtNotes.Text);
                preview_form.ShowDialog();


            }

        }

        private string checkGender()
        {
            if (rdbMale.Checked)
            {
                return "Male";
            }
            else
            {
                return "Female";
            }
        }

        private string checkMaritalStatus()
        {
            if (rdbMarried.Checked)
            {
                return "Married";
            }
            else
            {
                return "Single";
            }
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            if(isValud())
            {
                string cs = ConfigurationManager.ConnectionStrings["PayrollSystemDBConnectionStringMS"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                try
                {
                    DialogResult dr = MessageBox.Show("Do you want to delete EmployeeID " + txtEmployeeID.Text + " ?", "Confirm delete event", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        con.Open();
                        string InsertCommand = "DELETE FROM EMPLOYEE WHERE EMPLOYEEID=" + txtEmployeeID.Text;
                        SqlCommand com = new SqlCommand(InsertCommand, con);
                        com.ExecuteNonQuery();
                        MessageBox.Show("EmployeeID: " + txtEmployeeID.Text + " Deleted successfully!", "Employee delete Event ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error : " + ex.Message, "SQL error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void ShowData_Click(object sender, EventArgs e)
        {
            DataShow sd = new DataShow();
  
            sd.setForm(this);
            sd.ShowDialog();
        }

    private void btnUpdateEmployee_Click(object sender, EventArgs e)
    {
            string cs = ConfigurationManager.ConnectionStrings["PayrollSystemDBConnectionStringMS"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            try
            {
                DialogResult dr = MessageBox.Show("Do you want to update EmployeeID " + txtEmployeeID.Text + " ?", "Confirm update event", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    con.Open();
                    string InsertCommand = "UPDATE EMPLOYEE SET FirstName='" + txtFirstName.Text + "',LastName='" +
                        txtLastName.Text + "',Gender='" + checkGender() + "',ESINumber='" + txtNationalInsuranceNo.Text + "',DateOfBirth='" +
                        dateTimePicker.Text + "',MaritalStatus='" + checkMaritalStatus() + "' ,Address='" + txtAddress.Text + "',City='" + txtCity.Text + "',PostCode='" +
                        txtPostCode.Text + "',Country='" + cbCountry.SelectedItem + "',PhoneNumber='" + txtPhoneNumber.Text + "',Email='" + txtEmail.Text + "',Notes='" +
                        txtNotes.Text + "' "+" WHERE EmployeeID="+txtEmployeeID.Text;
                    SqlCommand com = new SqlCommand(InsertCommand, con);
                    com.ExecuteNonQuery();
                    MessageBox.Show("EmployeeID: " + txtEmployeeID.Text + " updated successfully!", "Employee update event", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message, "SQL error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        public void setValues(string EmployeeID, string FirstName, string LastName, bool Gender,
                              string NINO, string DOB, bool MaritialStatus,string Address,
                              string City, string PostCode, string Country, string PhoneNo, string Email,
                              string Notes)
        {
            this.txtEmployeeID.Text = EmployeeID;
            this.txtFirstName.Text = FirstName;
            this.txtLastName.Text = LastName;
            if(Gender)
            {
                this.rdbMale.Checked = true;
            }
            else
            {
                this.rdbFemale.Checked = true;

            }
            this.txtNationalInsuranceNo.Text = NINO;
            if (MaritialStatus)
            {
                this.rdbMarried.Checked = true;
            }
            else
            {
                this.rdbSingle.Checked = true;

            }
            this.txtAddress.Text = Address;
            this.txtCity.Text = City;
            this.txtPostCode.Text = PostCode;
            this.cbCountry.SelectedItem = Country;
            this.txtPhoneNumber.Text = PhoneNo;
            this.txtEmail.Text = Email;
            this.txtNotes.Text = Notes;
            this.dateTimePicker.Text = DOB;
        }

        public void Closeisvalid(bool isValid)
        {
            if(!isValid)
            {
                this.Close();
            }
            
        }

        private void cbCountry_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnPayroll_Click(object sender, EventArgs e)
        {
            PayrollCalculator pc = new PayrollCalculator();
            pc.ShowDialog();
        }

        private void txtEmployeeID_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.BackColor = Color.White;
        }
    }
}
