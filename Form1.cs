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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void choiceEmployee_Click(object sender, EventArgs e)
        {
            EmployeeLogIN employeeLogIN = new EmployeeLogIN();
            employeeLogIN.Show();
            this.Hide();
        }
    }
}
