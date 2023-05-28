using ERA_Manager.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERA_Manager
{
    public partial class FrmAddStudent : Form
    {
        public FrmAddStudent()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var firstname= txtFirstName.Text;
            var lastname= txtLastName.Text;   
            var preference = txtPreference.Text;
            var motivation = txtMotivation.Text;

            StudentRepository.AddStudent(firstname, lastname, motivation, preference); 
            Close();

        }
    }
}
