using Appointments_Schedule;
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
    public partial class Schedule : Form
    {
        public Schedule()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            appointmentBindingSource.AddNew();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            appointmentBindingSource.EndEdit();
            
        }
    }
}
