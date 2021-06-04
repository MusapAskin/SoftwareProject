using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void ProjectForm_Load(object sender, EventArgs e)
        {
            GetProject();
        }

        private void NewProject_Click_1(object sender, EventArgs e)
        {
            NewProjectForm newProject = new NewProjectForm();
            newProject.Show();
        }

        private void StartProject_Click_1(object sender, EventArgs e)
        {

        }

        private void ActivePojectButton_Click(object sender, EventArgs e)
        {

        }

        private void PassivePojectButton_Click(object sender, EventArgs e)
        {

        }

        private void PersonelButton_Click(object sender, EventArgs e)
        {

        }
    }
}

