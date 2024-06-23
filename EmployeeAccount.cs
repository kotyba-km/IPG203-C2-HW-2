using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPG203_C2_HW
{
    public partial class EmployeeAccount : Form
    {
        public EmployeeAccount()
        {
            InitializeComponent();
        }

        private void btnBack1_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeLogIN employeeLogIN = new EmployeeLogIN();
            employeeLogIN.Show();
        }
    }
}
