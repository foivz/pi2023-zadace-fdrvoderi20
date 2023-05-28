using ERA_Manager.Models;
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
    public partial class FrmValidation : Form
    {
        private Student selectedStudent;


        public FrmValidation(Student selectedStudent)
        {
            InitializeComponent();
            this.selectedStudent = selectedStudent;
            this.Text = $"{selectedStudent.FirstName } {selectedStudent.LastName}";
            txtFirstName.Text = selectedStudent.FirstName ;
            txtLastName.Text = selectedStudent.LastName ; 
            txtMotivation.Text = selectedStudent.Motivation ;
            txtPreference.Text = selectedStudent.Preference ;
            txtValidatedBy.Text = FrmLogin.LoggedManager.ToString() ;
        }

        private void FrmValidation_Load(object sender, EventArgs e)
        {
            
        }
    }
}
