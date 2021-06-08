
namespace SoftwareProject
{
    partial class Personel
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PersonelStatus = new System.Windows.Forms.CheckBox();
            this.PersonelLastName = new System.Windows.Forms.TextBox();
            this.PersonelAdress = new System.Windows.Forms.TextBox();
            this.PersonelPhone = new System.Windows.Forms.TextBox();
            this.PersonelMail = new System.Windows.Forms.TextBox();
            this.PersonelName = new System.Windows.Forms.TextBox();
            this.PersonelID = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PersonelJob = new System.Windows.Forms.ComboBox();
            this.AddPersonelButton = new System.Windows.Forms.Button();
            this.PersonelDataGridView = new System.Windows.Forms.DataGridView();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.personelData = new SoftwareProject.PersonelData();
            this.personelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelTableAdapter = new SoftwareProject.PersonelDataTableAdapters.PersonelTableAdapter();
            this.personelIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelMailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelAdressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelStatusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ExitButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PersonelDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personel No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Personel Adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Personel Soyad :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Personel E-Mail :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Personel Telefon :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Personel Adresi :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Personelin İşi :";
            // 
            // PersonelStatus
            // 
            this.PersonelStatus.AutoSize = true;
            this.PersonelStatus.Location = new System.Drawing.Point(132, 199);
            this.PersonelStatus.Name = "PersonelStatus";
            this.PersonelStatus.Size = new System.Drawing.Size(110, 17);
            this.PersonelStatus.TabIndex = 8;
            this.PersonelStatus.Text = "Personel Durumu ";
            this.PersonelStatus.UseVisualStyleBackColor = true;
            this.PersonelStatus.CheckedChanged += new System.EventHandler(this.PersonelStatus_CheckedChanged);
            // 
            // PersonelLastName
            // 
            this.PersonelLastName.Location = new System.Drawing.Point(107, 65);
            this.PersonelLastName.Name = "PersonelLastName";
            this.PersonelLastName.Size = new System.Drawing.Size(135, 20);
            this.PersonelLastName.TabIndex = 3;
            // 
            // PersonelAdress
            // 
            this.PersonelAdress.Location = new System.Drawing.Point(107, 147);
            this.PersonelAdress.Name = "PersonelAdress";
            this.PersonelAdress.Size = new System.Drawing.Size(135, 20);
            this.PersonelAdress.TabIndex = 6;
            // 
            // PersonelPhone
            // 
            this.PersonelPhone.Location = new System.Drawing.Point(107, 121);
            this.PersonelPhone.Name = "PersonelPhone";
            this.PersonelPhone.Size = new System.Drawing.Size(135, 20);
            this.PersonelPhone.TabIndex = 5;
            // 
            // PersonelMail
            // 
            this.PersonelMail.Location = new System.Drawing.Point(107, 95);
            this.PersonelMail.Name = "PersonelMail";
            this.PersonelMail.Size = new System.Drawing.Size(135, 20);
            this.PersonelMail.TabIndex = 4;
            // 
            // PersonelName
            // 
            this.PersonelName.Location = new System.Drawing.Point(107, 39);
            this.PersonelName.Name = "PersonelName";
            this.PersonelName.Size = new System.Drawing.Size(135, 20);
            this.PersonelName.TabIndex = 2;
            // 
            // PersonelID
            // 
            this.PersonelID.Enabled = false;
            this.PersonelID.Location = new System.Drawing.Point(107, 13);
            this.PersonelID.Name = "PersonelID";
            this.PersonelID.Size = new System.Drawing.Size(135, 20);
            this.PersonelID.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.PersonelJob);
            this.groupBox1.Controls.Add(this.AddPersonelButton);
            this.groupBox1.Controls.Add(this.PersonelLastName);
            this.groupBox1.Controls.Add(this.PersonelStatus);
            this.groupBox1.Controls.Add(this.PersonelID);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.PersonelName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.PersonelAdress);
            this.groupBox1.Controls.Add(this.PersonelPhone);
            this.groupBox1.Controls.Add(this.PersonelMail);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 247);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // PersonelJob
            // 
            this.PersonelJob.FormattingEnabled = true;
            this.PersonelJob.Items.AddRange(new object[] {
            "Analistçi\t\t",
            "Geliştirici",
            "Tasarımcı",
            "Testçi"});
            this.PersonelJob.Location = new System.Drawing.Point(107, 173);
            this.PersonelJob.Name = "PersonelJob";
            this.PersonelJob.Size = new System.Drawing.Size(135, 21);
            this.PersonelJob.TabIndex = 7;
            this.PersonelJob.Text = "Çalışanın işini seçiniz";
            // 
            // AddPersonelButton
            // 
            this.AddPersonelButton.BackColor = System.Drawing.SystemColors.Info;
            this.AddPersonelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.AddPersonelButton.Location = new System.Drawing.Point(144, 222);
            this.AddPersonelButton.Name = "AddPersonelButton";
            this.AddPersonelButton.Size = new System.Drawing.Size(75, 25);
            this.AddPersonelButton.TabIndex = 9;
            this.AddPersonelButton.Text = "Ekle";
            this.AddPersonelButton.UseVisualStyleBackColor = false;
            this.AddPersonelButton.Click += new System.EventHandler(this.AddPersonelButton_Click);
            // 
            // PersonelDataGridView
            // 
            this.PersonelDataGridView.AllowUserToAddRows = false;
            this.PersonelDataGridView.AllowUserToDeleteRows = false;
            this.PersonelDataGridView.AutoGenerateColumns = false;
            this.PersonelDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PersonelDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PersonelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PersonelDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personelIDDataGridViewTextBoxColumn,
            this.personelNameDataGridViewTextBoxColumn,
            this.personelLastNameDataGridViewTextBoxColumn,
            this.personelMailDataGridViewTextBoxColumn,
            this.personelPhoneDataGridViewTextBoxColumn,
            this.personelAdressDataGridViewTextBoxColumn,
            this.personelStatusDataGridViewCheckBoxColumn});
            this.PersonelDataGridView.DataSource = this.personelBindingSource;
            this.PersonelDataGridView.Location = new System.Drawing.Point(280, 12);
            this.PersonelDataGridView.Name = "PersonelDataGridView";
            this.PersonelDataGridView.ReadOnly = true;
            this.PersonelDataGridView.Size = new System.Drawing.Size(843, 216);
            this.PersonelDataGridView.TabIndex = 21;
            this.PersonelDataGridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.PersonelDataGridView_CellEnter);
            // 
            // UpdateButton
            // 
            this.UpdateButton.AutoSize = true;
            this.UpdateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.UpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.UpdateButton.Location = new System.Drawing.Point(280, 234);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 25);
            this.UpdateButton.TabIndex = 10;
            this.UpdateButton.Text = "Güncelle";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.AutoSize = true;
            this.DeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.DeleteButton.Location = new System.Drawing.Point(377, 234);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 25);
            this.DeleteButton.TabIndex = 11;
            this.DeleteButton.Text = "Sil";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // personelData
            // 
            this.personelData.DataSetName = "PersonelData";
            this.personelData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personelBindingSource
            // 
            this.personelBindingSource.DataMember = "Personel";
            this.personelBindingSource.DataSource = this.personelData;
            // 
            // personelTableAdapter
            // 
            this.personelTableAdapter.ClearBeforeFill = true;
            // 
            // personelIDDataGridViewTextBoxColumn
            // 
            this.personelIDDataGridViewTextBoxColumn.DataPropertyName = "personelID";
            this.personelIDDataGridViewTextBoxColumn.HeaderText = "personelID";
            this.personelIDDataGridViewTextBoxColumn.Name = "personelIDDataGridViewTextBoxColumn";
            this.personelIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personelNameDataGridViewTextBoxColumn
            // 
            this.personelNameDataGridViewTextBoxColumn.DataPropertyName = "personelName";
            this.personelNameDataGridViewTextBoxColumn.HeaderText = "personelName";
            this.personelNameDataGridViewTextBoxColumn.Name = "personelNameDataGridViewTextBoxColumn";
            this.personelNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personelLastNameDataGridViewTextBoxColumn
            // 
            this.personelLastNameDataGridViewTextBoxColumn.DataPropertyName = "personelLastName";
            this.personelLastNameDataGridViewTextBoxColumn.HeaderText = "personelLastName";
            this.personelLastNameDataGridViewTextBoxColumn.Name = "personelLastNameDataGridViewTextBoxColumn";
            this.personelLastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personelMailDataGridViewTextBoxColumn
            // 
            this.personelMailDataGridViewTextBoxColumn.DataPropertyName = "personelMail";
            this.personelMailDataGridViewTextBoxColumn.HeaderText = "personelMail";
            this.personelMailDataGridViewTextBoxColumn.Name = "personelMailDataGridViewTextBoxColumn";
            this.personelMailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personelPhoneDataGridViewTextBoxColumn
            // 
            this.personelPhoneDataGridViewTextBoxColumn.DataPropertyName = "personelPhone";
            this.personelPhoneDataGridViewTextBoxColumn.HeaderText = "personelPhone";
            this.personelPhoneDataGridViewTextBoxColumn.Name = "personelPhoneDataGridViewTextBoxColumn";
            this.personelPhoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personelAdressDataGridViewTextBoxColumn
            // 
            this.personelAdressDataGridViewTextBoxColumn.DataPropertyName = "personelAdress";
            this.personelAdressDataGridViewTextBoxColumn.HeaderText = "personelAdress";
            this.personelAdressDataGridViewTextBoxColumn.Name = "personelAdressDataGridViewTextBoxColumn";
            this.personelAdressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personelStatusDataGridViewCheckBoxColumn
            // 
            this.personelStatusDataGridViewCheckBoxColumn.DataPropertyName = "personelStatus";
            this.personelStatusDataGridViewCheckBoxColumn.HeaderText = "personelStatus";
            this.personelStatusDataGridViewCheckBoxColumn.Name = "personelStatusDataGridViewCheckBoxColumn";
            this.personelStatusDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ExitButton.Location = new System.Drawing.Point(472, 234);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 25);
            this.ExitButton.TabIndex = 12;
            this.ExitButton.Text = "Vazgeç";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Personel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 268);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.PersonelDataGridView);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Personel";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel";
            this.Load += new System.EventHandler(this.Personel_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PersonelDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox PersonelStatus;
        private System.Windows.Forms.TextBox PersonelLastName;
        private System.Windows.Forms.TextBox PersonelAdress;
        private System.Windows.Forms.TextBox PersonelPhone;
        private System.Windows.Forms.TextBox PersonelMail;
        private System.Windows.Forms.TextBox PersonelName;
        private System.Windows.Forms.TextBox PersonelID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView PersonelDataGridView;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button AddPersonelButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.ComboBox PersonelJob;
        private PersonelData personelData;
        private System.Windows.Forms.BindingSource personelBindingSource;
        private PersonelDataTableAdapters.PersonelTableAdapter personelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelMailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelAdressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn personelStatusDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button ExitButton;
    }
}