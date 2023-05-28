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
    public partial class FrmValidatedStudents : Form
    {
        public FrmValidatedStudents()
        {
            InitializeComponent();
            this.dgvValidatedStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvValidatedStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        }

        private void ShowValidatedStudents()
        {
            List<Validation> students = ValidationRepository.GetValidatedStudents();
            dgvValidatedStudents.DataSource = students;
            dgvValidatedStudents.Columns["Id"].DisplayIndex = 0;
            dgvValidatedStudents.Columns["FirstName"].DisplayIndex = 1;
            dgvValidatedStudents.Columns["LastName"].DisplayIndex = 2;
            dgvValidatedStudents.Columns["Motivation"].DisplayIndex = 3;
            dgvValidatedStudents.Columns["Preference"].DisplayIndex = 4;
            dgvValidatedStudents.Columns["PossibleDestinations"].DisplayIndex = 5;
            dgvValidatedStudents.Columns["ValidatedBy"].DisplayIndex = 6;
            dgvValidatedStudents.Columns["StudentID"].DisplayIndex = 7;
        }

        private void FrmValidatedStudents_Load_1(object sender, EventArgs e)
        {
            ShowValidatedStudents();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmStudents frmStudents = new FrmStudents();
            frmStudents.ShowDialog();
            Close();
        }
    }
}
