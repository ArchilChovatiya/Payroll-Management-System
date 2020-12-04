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
    public partial class DataShow : Form
    {
        EmployeeForm ef;
        public DataShow()
        {
            InitializeComponent();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataShow_Load(object sender, EventArgs e)
        {
          

        }
        public void setForm(EmployeeForm ef)
        {
            this.ef = ef;
        }

        private void DataShow_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'payrollSystemDBDataSet.employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.payrollSystemDBDataSet.employee);

        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var reader = dataGridView.Rows[e.RowIndex].Cells;
            string EmployeeID = reader[0].FormattedValue.ToString();
            string FirstName = reader[1].FormattedValue.ToString();
            string LastName = reader[2].FormattedValue.ToString();
            bool Gender = false;
            if (reader[3].FormattedValue.ToString().Equals("Male"))
            {
                Gender = true;
            }
            string NINO = reader[4].FormattedValue.ToString();
            string DOB = reader[5].FormattedValue.ToString();
            bool isMarried = false;
            if (reader[6].FormattedValue.ToString().Equals("Married"))
            {
                isMarried = true;
            }
            string Address = reader[7].FormattedValue.ToString();
            string City = reader[8].FormattedValue.ToString();
            string PostCode = reader[9].FormattedValue.ToString();
            string Country = reader[10].FormattedValue.ToString();
            string PhoneNo = reader[11].FormattedValue.ToString();
            string Email = reader[12].FormattedValue.ToString();
            string Notes = reader[13].FormattedValue.ToString();
            this.ef.setValues(EmployeeID, FirstName, LastName, Gender, NINO, DOB, isMarried, Address, City, PostCode, Country, PhoneNo, Email, Notes);
            this.Close();
        }
    }
}
