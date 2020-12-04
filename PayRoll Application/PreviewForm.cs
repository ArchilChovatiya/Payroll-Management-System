using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayRoll_Application
{
    public partial class PreviewForm : Form
    {
        public PreviewForm()
        {
            InitializeComponent();
        }

        private void PreviewForm_Load(object sender, EventArgs e)
        {

        }

        public void setPreview(string EmployeeID , string FirstName, string LastName, string Gender,
                              string NINO, string DOB, string MaritialStatus, string Address,
                              string City, string PostCode, string ctry, string PhoneNo, string Email,
                              string Notes)
        {
            this.EmployeeID.Text = EmployeeID;
            this.FirstName.Text = FirstName;
            this.LastName.Text = LastName;
            this.Gender.Text = Gender;
            this.NINO.Text = NINO;
            this.MaritalStatus.Text = MaritialStatus;
            this.Address.Text = Address;
            this.City.Text = City;
            this.PostCode.Text = PostCode;
            this.Country.Text = ctry;
            this.PhoneNumber.Text = PhoneNo;
            this.Email.Text = Email;
            this.Notes.Text = Notes;
            this.DOB.Text = DOB;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
