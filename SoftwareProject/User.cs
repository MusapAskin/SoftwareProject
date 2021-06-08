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
    public partial class User : Form
    {
        SQL c = new SQL();
        public User()
        {
            InitializeComponent();
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(UserName.Text) && !string.IsNullOrEmpty(UserPassword.Text))
                {

                    SqlCommand command = new SqlCommand("insert into [User] (userName,userPassword) values(@p1,@p2)", c.Sql());
                    command.Parameters.AddWithValue("@p1", UserName.Text);
                    command.Parameters.AddWithValue("@p2", UserPassword.Text);
                    if (UserPassword.Text.Equals(UserPassword2.Text))
                    {
                        int i = command.ExecuteNonQuery();

                        if (i != 0)
                        {
                            MessageBox.Show("Kullanıcı Başarıyla Eklendi.", "YSOFT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        c.Sql().Close();
                        Hide();
                        Application.Exit();
                    }
                    else
                    {
                        MessageBox.Show("Hata!! Şifreler Eşleşmiyor.", "YSOFT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen kullanıcı adı ve parolayı giriniz.", "YSOFT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    UserName.Select();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
