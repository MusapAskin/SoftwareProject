
using System;

namespace SoftwareProject
{
    partial class CompanyForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.CompanyName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CreateCompany = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CompanyPhone = new System.Windows.Forms.TextBox();
            this.CompanyID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SectorNameComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CompanyAdress = new System.Windows.Forms.TextBox();
            this.CompanyMail = new System.Windows.Forms.TextBox();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.company = new SoftwareProject.Company();
            this.companyTableAdapter = new SoftwareProject.CompanyTableAdapters.CompanyTableAdapter();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.CompanyDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExitButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.company)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(17, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şirket Adı :";
            // 
            // CompanyName
            // 
            this.CompanyName.Location = new System.Drawing.Point(123, 73);
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.Size = new System.Drawing.Size(144, 20);
            this.CompanyName.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(17, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sektör :";
            // 
            // CreateCompany
            // 
            this.CreateCompany.BackColor = System.Drawing.SystemColors.Info;
            this.CreateCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.CreateCompany.Location = new System.Drawing.Point(156, 252);
            this.CreateCompany.Name = "CreateCompany";
            this.CreateCompany.Size = new System.Drawing.Size(75, 25);
            this.CreateCompany.TabIndex = 5;
            this.CreateCompany.Text = "Ekle";
            this.CreateCompany.UseVisualStyleBackColor = false;
            this.CreateCompany.Click += new System.EventHandler(this.CreateCompany_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(17, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lütfen Şirket Bilgilerini Giriniz";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.CompanyPhone);
            this.groupBox1.Controls.Add(this.CompanyID);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.SectorNameComboBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.CompanyAdress);
            this.groupBox1.Controls.Add(this.CompanyMail);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CreateCompany);
            this.groupBox1.Controls.Add(this.CompanyName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 277);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // CompanyPhone
            // 
            this.CompanyPhone.Location = new System.Drawing.Point(122, 148);
            this.CompanyPhone.Name = "CompanyPhone";
            this.CompanyPhone.Size = new System.Drawing.Size(144, 20);
            this.CompanyPhone.TabIndex = 2;
            // 
            // CompanyID
            // 
            this.CompanyID.Enabled = false;
            this.CompanyID.Location = new System.Drawing.Point(122, 40);
            this.CompanyID.Name = "CompanyID";
            this.CompanyID.Size = new System.Drawing.Size(144, 20);
            this.CompanyID.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(17, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 21);
            this.label7.TabIndex = 13;
            this.label7.Text = "Şirket No :";
            // 
            // SectorNameComboBox
            // 
            this.SectorNameComboBox.FormattingEnabled = true;
            this.SectorNameComboBox.Location = new System.Drawing.Point(123, 112);
            this.SectorNameComboBox.Name = "SectorNameComboBox";
            this.SectorNameComboBox.Size = new System.Drawing.Size(143, 21);
            this.SectorNameComboBox.TabIndex = 1;
            this.SectorNameComboBox.Text = "Sektör seçiniz";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(17, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Adres :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(17, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "E-Mail :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(17, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Telefon :";
            // 
            // CompanyAdress
            // 
            this.CompanyAdress.Location = new System.Drawing.Point(122, 224);
            this.CompanyAdress.Name = "CompanyAdress";
            this.CompanyAdress.Size = new System.Drawing.Size(144, 20);
            this.CompanyAdress.TabIndex = 4;
            // 
            // CompanyMail
            // 
            this.CompanyMail.Location = new System.Drawing.Point(122, 186);
            this.CompanyMail.Name = "CompanyMail";
            this.CompanyMail.Size = new System.Drawing.Size(144, 20);
            this.CompanyMail.TabIndex = 3;
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataMember = "Company";
            this.companyBindingSource.DataSource = this.company;
            // 
            // company
            // 
            this.company.DataSetName = "Company";
            this.company.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // companyTableAdapter
            // 
            this.companyTableAdapter.ClearBeforeFill = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.AutoSize = true;
            this.DeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.DeleteButton.Location = new System.Drawing.Point(401, 266);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 25);
            this.DeleteButton.TabIndex = 7;
            this.DeleteButton.Text = "Sil";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.AutoSize = true;
            this.UpdateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.UpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.UpdateButton.Location = new System.Drawing.Point(305, 266);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 25);
            this.UpdateButton.TabIndex = 6;
            this.UpdateButton.Text = "Güncelle";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // CompanyDataGridView
            // 
            this.CompanyDataGridView.AllowUserToAddRows = false;
            this.CompanyDataGridView.AllowUserToDeleteRows = false;
            this.CompanyDataGridView.AutoGenerateColumns = false;
            this.CompanyDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CompanyDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CompanyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CompanyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.sectorIDDataGridViewTextBoxColumn});
            this.CompanyDataGridView.DataSource = this.companyBindingSource;
            this.CompanyDataGridView.Location = new System.Drawing.Point(305, 14);
            this.CompanyDataGridView.Name = "CompanyDataGridView";
            this.CompanyDataGridView.ReadOnly = true;
            this.CompanyDataGridView.Size = new System.Drawing.Size(678, 244);
            this.CompanyDataGridView.TabIndex = 8;
            this.CompanyDataGridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.CompanyDataGridView_CellEnter);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "companyID";
            this.dataGridViewTextBoxColumn1.HeaderText = "companyID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "companyName";
            this.dataGridViewTextBoxColumn2.HeaderText = "companyName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "companyPhone";
            this.dataGridViewTextBoxColumn3.HeaderText = "companyPhone";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "companyMail";
            this.dataGridViewTextBoxColumn4.HeaderText = "companyMail";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "companyAdress";
            this.dataGridViewTextBoxColumn5.HeaderText = "companyAdress";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // sectorIDDataGridViewTextBoxColumn
            // 
            this.sectorIDDataGridViewTextBoxColumn.DataPropertyName = "sectorID";
            this.sectorIDDataGridViewTextBoxColumn.HeaderText = "sectorID";
            this.sectorIDDataGridViewTextBoxColumn.Name = "sectorIDDataGridViewTextBoxColumn";
            this.sectorIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ExitButton.Location = new System.Drawing.Point(501, 266);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 25);
            this.ExitButton.TabIndex = 13;
            this.ExitButton.Text = "Vazgeç";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // CompanyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 306);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CompanyDataGridView);
            this.Name = "CompanyForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Company";
            this.Load += new System.EventHandler(this.CompanyForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.company)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Label label2;
        private new System.Windows.Forms.TextBox CompanyName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button CreateCompany;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CompanyAdress;
        private System.Windows.Forms.TextBox CompanyMail;

 
        private System.Windows.Forms.ComboBox SectorNameComboBox;
        private System.Windows.Forms.TextBox CompanyID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox CompanyPhone;
        private Company company;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private CompanyTableAdapters.CompanyTableAdapter companyTableAdapter;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.DataGridView CompanyDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button ExitButton;
    }
}