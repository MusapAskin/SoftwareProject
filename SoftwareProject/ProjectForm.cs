using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SoftwareProject
{
    public partial class ProjectForm : Form
    {
        SQL c = new SQL();

        public ProjectForm()
        {
            InitializeComponent();
        }

        void GetProject()
        {
            this.projectTableAdapter.Fill(this.project._Project);
        }

        private void ProjectForm_Load(object sender, EventArgs e) { 
            GetProject();
        }

        private void NewProject_Click_1(object sender, EventArgs e)
        {
            NewProjectForm newProject = new NewProjectForm();
            newProject.Show();
            Hide();
        }

        private void PersonelButton_Click(object sender, EventArgs e)
        {
            Personel personel = new Personel();
            personel.Show();
            Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CompanyForm company = new CompanyForm();
            company.Show();
            Hide();
        }
    }
}

