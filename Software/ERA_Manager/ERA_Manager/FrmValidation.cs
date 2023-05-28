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
using DBLayer;
using ERA_Manager.Repositories;

namespace ERA_Manager
{
    public partial class FrmValidation : Form
    {
        private Student selectedStudent;
        private int id;

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
            id = selectedStudent.Id ;
        }

        private void FrmValidation_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            var firstname = txtFirstName.Text ;
            var lastname = txtLastName.Text ;
            var motivation = txtMotivation.Text ;
            var preference = txtPreference.Text ;
            var possibleDestinations = txtPossibleDestinations.Text ;
            var validator = txtValidatedBy.Text ;

            ValidationRepository.ValidateStudent(firstname, lastname, motivation, preference, possibleDestinations, validator, id) ;
            this.DialogResult = DialogResult.OK ;
            Close();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var firstname = txtFirstName.Text;
            var lastname = txtLastName.Text;
            var motivation = txtMotivation.Text;
            var preference = txtPreference.Text;
            var possibleDestinations = txtPossibleDestinations.Text;
            var validator = txtValidatedBy.Text;

            StudentRepository.UpdateStudent(firstname, lastname, motivation, preference, id);
            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
