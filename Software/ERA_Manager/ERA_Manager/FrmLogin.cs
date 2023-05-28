using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ERA_Manager.Models;
using ERA_Manager.Repositories;

namespace ERA_Manager
{
    public partial class FrmLogin : Form
    {

        public static EosmManager LoggedManager { get; set; }

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            Logg

            if (txtUsername.Text == "")
            {
                MessageBox.Show("Username missing !", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Password missing !", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                if (txtPassword.Text == password && txtUsername.Text==username)

                {
                    FrmStudents frmStudents = new FrmStudents();
                    Hide();
                    frmStudents.ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show("Wrong credentials !", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
