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

    public partial class LoginForm : Form
    {
        SQL c = new SQL();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UserName.Select();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(UserName.Text) && !string.IsNullOrEmpty(UserPassword.Text))
            {
                SqlCommand command = new SqlCommand("Select * From [User] where userName=@p1 and userPassword=@p2", c.Sql());
                command.Parameters.AddWithValue("@p1", UserName.Text);
                command.Parameters.AddWithValue("@p2", UserPassword.Text);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    ProjectForm Project = new ProjectForm();
                    Project.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış.Yeniden deneyiniz.", "YSOFT", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                }
            }
            else
            {
                MessageBox.Show("Lütfen kullanıcı adı ve parolayı giriniz.", "YSOFT",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                UserName.Select();
            }
        }

        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassword.Checked)
                UserPassword.UseSystemPasswordChar = false;
            else UserPassword.UseSystemPasswordChar = true;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
