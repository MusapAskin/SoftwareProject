using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using SoftwareProject;

namespace SoftwareProject
{
    public partial class CompanyForm : Form
    {
        SQL c = new SQL();

        public CompanyForm()
        {
            InitializeComponent();
        }

        void GetCompany()
        {
            this.companyTableAdapter.Fill(this.companyData.Company);
        }

        private void CompanyForm_Load(object sender, EventArgs e)
        {

            GetCompany();

            SqlCommand command = new SqlCommand("Select sectorName From Sector", c.Sql());
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                SectorNameComboBox.Items.Add(reader["sectorName"]);
            }
            c.Sql().Close();
        }

        private void CreateCompany_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("insert into Company (companyName,sectorID,companyPhone,companyMail,companyAdress) values(@p1,@p2,@p3,@p4,@p5)", c.Sql());
                command.Parameters.AddWithValue("@p1", CompanyName.Text);
                command.Parameters.AddWithValue("@p2", SectorNameComboBox.SelectedIndex + 1);
                command.Parameters.AddWithValue("@p3", Convert.ToInt64(CompanyPhone.Text));
                command.Parameters.AddWithValue("@p4", CompanyMail.Text);
                command.Parameters.AddWithValue("@p5", CompanyAdress.Text);
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
            GetCompany();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("Update Company Set companyName=@p1,sectorID=@p2,companyPhone=@p3,companyMail=@p4,companyAdress=@p5 Where companyID=@companyID", c.Sql());
                command.Parameters.AddWithValue("@companyID", Convert.ToInt32(CompanyID.Text));
                command.Parameters.AddWithValue("@p1", CompanyName.Text);
                command.Parameters.AddWithValue("@p2", SectorNameComboBox.SelectedIndex + 1);
                command.Parameters.AddWithValue("@p3", Convert.ToInt64(CompanyPhone.Text));
                command.Parameters.AddWithValue("@p4", CompanyMail.Text);
                command.Parameters.AddWithValue("@p5", CompanyAdress.Text);
                int i = command.ExecuteNonQuery();

                if (i != 0)
                {
                    MessageBox.Show("Şirket Listesi Başarıyla Güncellendi.");
                }
                else
                {
                    MessageBox.Show("Hata!! Lütfen Bilgileri eksiksiz giriniz.");
                }  
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            c.Sql().Close();
            GetCompany();
        }

        private void CompanyDataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            CompanyID.Text = CompanyDataGridView.CurrentRow.Cells[0].Value.ToString();
            CompanyName.Text = CompanyDataGridView.CurrentRow.Cells[1].Value.ToString();
            SectorNameComboBox.Text = CompanyDataGridView.CurrentRow.Cells[6].Value.ToString();
            CompanyPhone.Text = CompanyDataGridView.CurrentRow.Cells[2].Value.ToString();
            CompanyMail.Text = CompanyDataGridView.CurrentRow.Cells[3].Value.ToString();
            CompanyAdress.Text = CompanyDataGridView.CurrentRow.Cells[4].Value.ToString();

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("Delete From Company Where companyID=@companyID", c.Sql());
                command.Parameters.AddWithValue("@companyID", Convert.ToInt32(CompanyID.Text));
                int i = command.ExecuteNonQuery();

                if (i != 0)
                {
                    MessageBox.Show("Şirket Kaydı Başarıyla Silindi.");
                }
                else
                {
                    MessageBox.Show("Hata!! Lütfen Kaydı Kontrol Ediniz.");
                }
                c.Sql().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            GetCompany();
        }
    }

}
