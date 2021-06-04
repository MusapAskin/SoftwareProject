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
using SoftwareProject;

namespace SoftwareProject
{
    public partial class NewProjectForm : Form
    {
        SQL c = new SQL();

        public NewProjectForm()
        {
            InitializeComponent();
        }

        void GetProject()
        {
            this.projectTableAdapter.Fill(this.project._Project);
        }

        private void NewProjectForm_Load(object sender, EventArgs e)
        {
            GetProject();

            SqlCommand command = new SqlCommand("Select companyName From Company", c.Sql());
            SqlDataReader reader = command.ExecuteReader();
            SqlCommand command1 = new SqlCommand("Select name From Analyst ", c.Sql());
            SqlDataReader reader1 = command1.ExecuteReader();
            SqlCommand command2 = new SqlCommand("Select name From Designer ", c.Sql());
            SqlDataReader reader2 = command2.ExecuteReader();
            SqlCommand command3 = new SqlCommand("Select name From Developer ", c.Sql());
            SqlDataReader reader3 = command3.ExecuteReader();
            SqlCommand command4 = new SqlCommand("Select name From Tester ", c.Sql());
            SqlDataReader reader4 = command4.ExecuteReader();
            SqlCommand command5 = new SqlCommand("Select adminName From Admin ", c.Sql());
            SqlDataReader reader5 = command5.ExecuteReader();
            while (reader.Read()) CompanyComboBox.Items.Add(reader["companyName"]);
            while (reader1.Read()) AnalystComboBox.Items.Add(reader1["name"]);
            while (reader2.Read()) DesignerComboBox.Items.Add(reader2["name"]);
            while (reader3.Read()) DeveloperComboBox.Items.Add(reader3["name"]);
            while (reader4.Read()) TesterComboBox.Items.Add(reader4["name"]);
            while (reader5.Read()) AdminComboBox.Items.Add(reader5["adminName"]);


        }

        private void ProjectAdd_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("insert into Project (projectName,projectCost,adminID,designerID,developerID,testerID,analystID,companyID,projectStatus) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", c.Sql());
                command.Parameters.AddWithValue("@p1", ProjectName.Text);
                command.Parameters.AddWithValue("@p2", Convert.ToDouble(ProjectCost.Text));
                command.Parameters.AddWithValue("@p3", AdminComboBox.SelectedIndex + 1);
                command.Parameters.AddWithValue("@p4", DesignerComboBox.SelectedIndex + 1);
                command.Parameters.AddWithValue("@p5", DeveloperComboBox.SelectedIndex + 1);
                command.Parameters.AddWithValue("@p6", TesterComboBox.SelectedIndex + 1);
                command.Parameters.AddWithValue("@p7", AnalystComboBox.SelectedIndex + 1);
                command.Parameters.AddWithValue("@p8", CompanyComboBox.SelectedIndex + 1);
                command.Parameters.AddWithValue("@p9", Convert.ToBoolean(ProjectStatus.Checked));

                int i = command.ExecuteNonQuery();

                if (i != 0)
                {
                    MessageBox.Show("Şirket Başarıyla Eklendi.");
                }
                else
                {
                    MessageBox.Show("Hata!! Lütfen Bilgileri eksiksiz giriniz.");
                }
                c.Sql().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            GetProject();
        }

        private void DeleteProjectButton_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Delete From Project Where projectID=@projectID", c.Sql());
            command.Parameters.AddWithValue("@projectID", Convert.ToInt32(ProjectID.Text));
            int i = command.ExecuteNonQuery();
            if (i != 0)
            {
                MessageBox.Show("Kayıt Silindi");
            }
            else
            {
                MessageBox.Show("Hata!!Lütfen bilgileri kontrol ediniz.");
            }

            GetProject();
        }

        private void ProjectDataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            ProjectID.Text = ProjectDataGridView.CurrentRow.Cells[0].Value.ToString();
            ProjectName.Text = ProjectDataGridView.CurrentRow.Cells[1].Value.ToString();
            ProjectCost.Text = ProjectDataGridView.CurrentRow.Cells[2].Value.ToString();
            AdminComboBox.Text = ProjectDataGridView.CurrentRow.Cells[5].Value.ToString();
            DesignerComboBox.Text = ProjectDataGridView.CurrentRow.Cells[6].Value.ToString();
            DeveloperComboBox.Text = ProjectDataGridView.CurrentRow.Cells[7].Value.ToString();
            TesterComboBox.Text = ProjectDataGridView.CurrentRow.Cells[8].Value.ToString();
            AnalystComboBox.Text = ProjectDataGridView.CurrentRow.Cells[9].Value.ToString();
            CompanyComboBox.Text = ProjectDataGridView.CurrentRow.Cells[10].Value.ToString();

        }


    }
}

