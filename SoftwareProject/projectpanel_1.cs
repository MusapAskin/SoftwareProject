using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SoftwareProject;
using System.Data.SqlClient;


namespace SoftwareProject
{
    public partial class ProjectPanel : Form
    {
        SQL c = new SQL();

        public ProjectPanel()
        {
            InitializeComponent();
        }

        void GetProject()
        {
            
        }

        private void PasivveProjectButton_Click(object sender, EventArgs e)
        {

        }

        private void PersonelButton_Click(object sender, EventArgs e)
        {

        }

        private void ActiveProjectButton_Click(object sender, EventArgs e)
        {
            
        }

        private void StartProject_Click(object sender, EventArgs e)A
        {
             
        }

        private void DeleteProject_Click(object sender, EventArgs e)
        {
          
        }

        private void NewProject_Click(object sender, EventArgs e)
        {
            NewProjectForm newProject = new NewProjectForm();
            newProject.Show();
        }

        private void ProjePanel_Load(object sender, EventArgs e)
        {
            GetProject();
        }

    }
}
