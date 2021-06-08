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
    public partial class Personel : Form
    {
        SQL c = new SQL();

        public Personel()
        {
            InitializeComponent();
        }
        void GetPersonel()
        {
            this.personelTableAdapter.Fill(this.personelData.Personel);
        }

        private void Personel_Load(object sender, EventArgs e)
        {
         
            GetPersonel();
        }

        private void AddPersonelButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("insert into Personel (personelName,personelLastName,personelMail,personelPhone,personelAdress,personelStatus) values(@p1,@p2,@p3,@p4,@p5,@p6)", c.Sql());

                command.Parameters.AddWithValue("@p1", PersonelName.Text);
                command.Parameters.AddWithValue("@p2", PersonelLastName.Text);
                command.Parameters.AddWithValue("@p3", PersonelMail.Text);
                command.Parameters.AddWithValue("@p4", Convert.ToInt64(PersonelPhone.Text));
                command.Parameters.AddWithValue("@p5", PersonelAdress.Text);
                command.Parameters.AddWithValue("@p6", Convert.ToBoolean(PersonelStatus.Checked));
                if (PersonelJob.Text.Equals("Analistçi"))
                {
                    SqlCommand command1 = new SqlCommand("insert into Analyst (name, personelID) values(@p1,@p2)", c.Sql());
                    command1.Parameters.AddWithValue("@p1", PersonelJob.SelectedItem.ToString());
                    command1.Parameters.AddWithValue("@p2", Convert.ToInt32(PersonelID.Text));
                    command1.ExecuteNonQuery();
                   

                }

                else if (PersonelJob.SelectedIndex == 1)
                {
                    SqlCommand command1 = new SqlCommand("insert into  Developer (name, personelID) values(@p1,@p2)", c.Sql());
                    command1.Parameters.AddWithValue("@p1", PersonelJob.SelectedValue);
                    command1.Parameters.AddWithValue("@p2", Convert.ToInt32(PersonelID.Text));
                    command1.ExecuteNonQuery();
                    
                }
                else if (PersonelJob.SelectedIndex == 2)
                {
                    SqlCommand command1 = new SqlCommand("insert into   Designer (name, personelID) values(@p1,@p2)", c.Sql());
                    command1.Parameters.AddWithValue("@p1", PersonelJob.SelectedValue);
                    command1.Parameters.AddWithValue("@p2", Convert.ToInt32(PersonelID.Text));
                    command1.ExecuteNonQuery();

                }
                else if (PersonelJob.SelectedIndex == 3)
                {
                    SqlCommand command1 = new SqlCommand("insert into  Tester (name, personelID) values(@p1,@p2)", c.Sql());
                    command1.Parameters.AddWithValue("@p1", PersonelJob.SelectedValue);
                    command1.Parameters.AddWithValue("@p2", Convert.ToInt32(PersonelID.Text));
                    command1.ExecuteNonQuery();
                }

                int i = command.ExecuteNonQuery();
                

                if (i != 0)
                {
                    MessageBox.Show("Personel Başarıyla Eklendi.");
                }
                else
                {
                    MessageBox.Show("Hata!! Lütfen Bilgileri eksiksiz giriniz.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            GetPersonel();
            c.Sql().Close();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            ProjectForm project = new ProjectForm();
            project.Show();
            Hide();
            GetPersonel();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
                SqlCommand command = new SqlCommand("Delete From Personel Where personelID=@personelID", c.Sql());
                command.Parameters.AddWithValue("@personelID", Convert.ToInt32(PersonelID.Text));
                int i = command.ExecuteNonQuery();
                if (i != 0)
                {
                MessageBox.Show("Kayıt Silindi", "YSOFT", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                else
                {
                    MessageBox.Show("Hata!!Lütfen bilgileri kontrol ediniz.");
                }

                GetPersonel();
            
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("Update Personel Set personelName=@p1,personelLastName=@p2,personelMail=@p3,personelPhone=@p4,personelAdress=@p5,personelStatus=@p6 Where personelID=@personelID", c.Sql());
                command.Parameters.AddWithValue("@personelID", Convert.ToInt32(PersonelID.Text));
                command.Parameters.AddWithValue("@p1", PersonelName.Text);
                command.Parameters.AddWithValue("@p2", PersonelLastName.Text);
                command.Parameters.AddWithValue("@p3", PersonelMail.Text);
                command.Parameters.AddWithValue("@p4", Convert.ToInt64(PersonelPhone.Text));
                command.Parameters.AddWithValue("@p5", PersonelAdress.Text);
                command.Parameters.AddWithValue("@p6", Convert.ToBoolean(PersonelStatus.Checked));
                int i = command.ExecuteNonQuery();

                if (i != 0)
                {
                    MessageBox.Show("Personel Listesi Başarıyla Güncellendi.");
                }
                else
                {
                    MessageBox.Show("Hata!! Lütfen Bilgileri eksiksiz giriniz.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            c.Sql().Close();
            GetPersonel();
        }

        private void PersonelDataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            PersonelID.Text = PersonelDataGridView.CurrentRow.Cells[0].Value.ToString();
            PersonelName.Text = PersonelDataGridView.CurrentRow.Cells[1].Value.ToString();
            PersonelLastName.Text = PersonelDataGridView.CurrentRow.Cells[2].Value.ToString();
            PersonelMail.Text = PersonelDataGridView.CurrentRow.Cells[3].Value.ToString();
            PersonelPhone.Text = PersonelDataGridView.CurrentRow.Cells[4].Value.ToString();
            PersonelAdress.Text = PersonelDataGridView.CurrentRow.Cells[5].Value.ToString();
            PersonelJob.Text = PersonelDataGridView.CurrentRow.Cells[6].Value.ToString();
        }

        private void PersonelStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (PersonelStatus.Checked)
            {
                PersonelStatus.Text = "Aktif";
            }
            else
            {
                PersonelStatus.Text = "Pasif";
            }
        }

    }
}
