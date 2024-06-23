using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace IPG203_C2_HW
{
    public partial class EmployeeLogIN : Form
    {
        public EmployeeLogIN()
        {
            InitializeComponent();
        }

        private void btnBack1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userename = txtUsername.Text;
            string password = txtPassword.Text;

            if (userename == "kutaiba" && password == "262237")
            {
                MessageBox.Show("Login successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EmployeeAccount employeeAccount = new EmployeeAccount();
                employeeAccount.Show();
                this.Hide();
            }
            else if (userename == "yasein" && password == "236512")
            {
                MessageBox.Show("Login successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EmployeeAccount employeeAccount = new EmployeeAccount();
                employeeAccount.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
