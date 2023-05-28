using ERA_Manager.Models;
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
    public partial class FrmStudents : Form
    {
        public FrmStudents()
        {
            InitializeComponent();
        }

        private void FrmStudents_Load(object sender, EventArgs e)
        {
            ShowStudents();
        }

        private void ShowStudents()
        {
            List<Student> students = StudentRepository.GetStudents();
            dgvStudents.DataSource = students;
            dgvStudents.Columns["Id"].DisplayIndex = 0;
            dgvStudents.Columns["FirstName"].DisplayIndex = 1;
            dgvStudents.Columns["LastName"].DisplayIndex = 2;
            dgvStudents.Columns["Motivation"].DisplayIndex = 3;
            dgvStudents.Columns["Preference"].DisplayIndex= 4;
        }



        private void btnValidate_Click(object sender, EventArgs e)
        {
            Student selectedStudent = dgvStudents.CurrentRow.DataBoundItem as Student;

            FrmValidation frmValidation = new FrmValidation(selectedStudent);
            //frmValidation.ShowDialog();
            if(frmValidation.ShowDialog() == DialogResult.OK)
            {
                dgvStudents.Refresh();
                ShowStudents();
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            FrmValidatedStudents frmValidatedStudents = new FrmValidatedStudents();
            frmValidatedStudents.ShowDialog();
            Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var search = txtSearch.Text;
            List<Student> students = StudentRepository.SearchStudent(search);
            dgvStudents.DataSource = students;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ShowStudents();
        }
    }
}
