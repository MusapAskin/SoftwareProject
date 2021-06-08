
namespace SoftwareProject
{
    partial class NewProjectForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DesignerComboBox = new System.Windows.Forms.ComboBox();
            this.DeveloperComboBox = new System.Windows.Forms.ComboBox();
            this.AnalystComboBox = new System.Windows.Forms.ComboBox();
            this.TesterComboBox = new System.Windows.Forms.ComboBox();
            this.AdminComboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ProjectID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CompanyComboBox = new System.Windows.Forms.ComboBox();
            this.AddProjectButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ProjectStatus = new System.Windows.Forms.CheckBox();
            this.ProjectName = new System.Windows.Forms.TextBox();
            this.ProjectCost = new System.Windows.Forms.TextBox();
            this.DeleteProjectButton = new System.Windows.Forms.Button();
            this.ProjectDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.projectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.project = new SoftwareProject.Project();
            this.projectTableAdapter = new SoftwareProject.ProjectTableAdapters.ProjectTableAdapter();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ProjecUpdateButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.project)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.DesignerComboBox);
            this.groupBox1.Controls.Add(this.DeveloperComboBox);
            this.groupBox1.Controls.Add(this.AnalystComboBox);
            this.groupBox1.Controls.Add(this.TesterComboBox);
            this.groupBox1.Controls.Add(this.AdminComboBox);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.ProjectID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CompanyComboBox);
            this.groupBox1.Controls.Add(this.AddProjectButton);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ProjectStatus);
            this.groupBox1.Controls.Add(this.ProjectName);
            this.groupBox1.Controls.Add(this.ProjectCost);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 304);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // DesignerComboBox
            // 
            this.DesignerComboBox.FormattingEnabled = true;
            this.DesignerComboBox.Location = new System.Drawing.Point(99, 122);
            this.DesignerComboBox.Name = "DesignerComboBox";
            this.DesignerComboBox.Size = new System.Drawing.Size(121, 21);
            this.DesignerComboBox.TabIndex = 3;
            this.DesignerComboBox.Text = "Tasarımcı seçiniz";
            // 
            // DeveloperComboBox
            // 
            this.DeveloperComboBox.FormattingEnabled = true;
            this.DeveloperComboBox.Location = new System.Drawing.Point(99, 148);
            this.DeveloperComboBox.Name = "DeveloperComboBox";
            this.DeveloperComboBox.Size = new System.Drawing.Size(121, 21);
            this.DeveloperComboBox.TabIndex = 4;
            this.DeveloperComboBox.Text = "Geliştirici seçiniz";
            // 
            // AnalystComboBox
            // 
            this.AnalystComboBox.FormattingEnabled = true;
            this.AnalystComboBox.Location = new System.Drawing.Point(99, 200);
            this.AnalystComboBox.Name = "AnalystComboBox";
            this.AnalystComboBox.Size = new System.Drawing.Size(121, 21);
            this.AnalystComboBox.TabIndex = 6;
            this.AnalystComboBox.Text = "Analistçi seçiniz";
            // 
            // TesterComboBox
            // 
            this.TesterComboBox.FormattingEnabled = true;
            this.TesterComboBox.Location = new System.Drawing.Point(99, 174);
            this.TesterComboBox.Name = "TesterComboBox";
            this.TesterComboBox.Size = new System.Drawing.Size(121, 21);
            this.TesterComboBox.TabIndex = 5;
            this.TesterComboBox.Text = "Testçi seçiniz";
            // 
            // AdminComboBox
            // 
            this.AdminComboBox.FormattingEnabled = true;
            this.AdminComboBox.Location = new System.Drawing.Point(99, 96);
            this.AdminComboBox.Name = "AdminComboBox";
            this.AdminComboBox.Size = new System.Drawing.Size(121, 21);
            this.AdminComboBox.TabIndex = 2;
            this.AdminComboBox.Text = "Yönetici seçiniz";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 48;
            this.label10.Text = "Admin ";
            // 
            // ProjectID
            // 
            this.ProjectID.Enabled = false;
            this.ProjectID.Location = new System.Drawing.Point(100, 19);
            this.ProjectID.Name = "ProjectID";
            this.ProjectID.Size = new System.Drawing.Size(120, 20);
            this.ProjectID.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Proje No";
            // 
            // CompanyComboBox
            // 
            this.CompanyComboBox.FormattingEnabled = true;
            this.CompanyComboBox.Location = new System.Drawing.Point(99, 229);
            this.CompanyComboBox.Name = "CompanyComboBox";
            this.CompanyComboBox.Size = new System.Drawing.Size(121, 21);
            this.CompanyComboBox.TabIndex = 7;
            this.CompanyComboBox.Text = "Şirket seçiniz";
            // 
            // AddProjectButton
            // 
            this.AddProjectButton.BackColor = System.Drawing.SystemColors.Info;
            this.AddProjectButton.Location = new System.Drawing.Point(129, 279);
            this.AddProjectButton.Name = "AddProjectButton";
            this.AddProjectButton.Size = new System.Drawing.Size(75, 25);
            this.AddProjectButton.TabIndex = 9;
            this.AddProjectButton.Text = "Ekle";
            this.AddProjectButton.UseVisualStyleBackColor = false;
            this.AddProjectButton.Click += new System.EventHandler(this.AddProjectButton_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 232);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 40;
            this.label9.Text = "Şirket";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "Analyst ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Tester ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Developer ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Designer ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Maliyet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Proje Adı";
            // 
            // ProjectStatus
            // 
            this.ProjectStatus.AutoSize = true;
            this.ProjectStatus.Location = new System.Drawing.Point(114, 256);
            this.ProjectStatus.Name = "ProjectStatus";
            this.ProjectStatus.Size = new System.Drawing.Size(90, 17);
            this.ProjectStatus.TabIndex = 8;
            this.ProjectStatus.Text = "Proje Durumu";
            this.ProjectStatus.UseVisualStyleBackColor = true;
            this.ProjectStatus.CheckedChanged += new System.EventHandler(this.ProjectStatus_CheckedChanged);
            // 
            // ProjectName
            // 
            this.ProjectName.Location = new System.Drawing.Point(100, 45);
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.Size = new System.Drawing.Size(120, 20);
            this.ProjectName.TabIndex = 0;
            // 
            // ProjectCost
            // 
            this.ProjectCost.Location = new System.Drawing.Point(100, 71);
            this.ProjectCost.Name = "ProjectCost";
            this.ProjectCost.Size = new System.Drawing.Size(120, 20);
            this.ProjectCost.TabIndex = 1;
            // 
            // DeleteProjectButton
            // 
            this.DeleteProjectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DeleteProjectButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.DeleteProjectButton.Location = new System.Drawing.Point(372, 291);
            this.DeleteProjectButton.Name = "DeleteProjectButton";
            this.DeleteProjectButton.Size = new System.Drawing.Size(75, 25);
            this.DeleteProjectButton.TabIndex = 11;
            this.DeleteProjectButton.Text = "Sil";
            this.DeleteProjectButton.UseVisualStyleBackColor = false;
            this.DeleteProjectButton.Click += new System.EventHandler(this.DeleteProjectButton_Click);
            // 
            // ProjectDataGridView
            // 
            this.ProjectDataGridView.AllowUserToAddRows = false;
            this.ProjectDataGridView.AllowUserToDeleteRows = false;
            this.ProjectDataGridView.AutoGenerateColumns = false;
            this.ProjectDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProjectDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProjectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProjectDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewCheckBoxColumn1});
            this.ProjectDataGridView.DataSource = this.projectBindingSource;
            this.ProjectDataGridView.Location = new System.Drawing.Point(275, 12);
            this.ProjectDataGridView.Name = "ProjectDataGridView";
            this.ProjectDataGridView.ReadOnly = true;
            this.ProjectDataGridView.RowTemplate.Height = 25;
            this.ProjectDataGridView.Size = new System.Drawing.Size(921, 273);
            this.ProjectDataGridView.TabIndex = 7;
            this.ProjectDataGridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProjectDataGridView_CellEnter);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "projectID";
            this.dataGridViewTextBoxColumn1.HeaderText = "projectID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "projectName";
            this.dataGridViewTextBoxColumn2.HeaderText = "projectName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "projectCost";
            this.dataGridViewTextBoxColumn3.HeaderText = "projectCost";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "StartDate";
            this.dataGridViewTextBoxColumn4.HeaderText = "StartDate";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "EndDate";
            this.dataGridViewTextBoxColumn5.HeaderText = "EndDate";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "adminID";
            this.dataGridViewTextBoxColumn6.HeaderText = "adminID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "designerID";
            this.dataGridViewTextBoxColumn7.HeaderText = "designerID";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "developerID";
            this.dataGridViewTextBoxColumn8.HeaderText = "developerID";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "testerID";
            this.dataGridViewTextBoxColumn9.HeaderText = "testerID";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "analystID";
            this.dataGridViewTextBoxColumn10.HeaderText = "analystID";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "companyID";
            this.dataGridViewTextBoxColumn11.HeaderText = "companyID";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "projectStatus";
            this.dataGridViewCheckBoxColumn1.HeaderText = "projectStatus";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // projectBindingSource
            // 
            this.projectBindingSource.DataMember = "Project";
            this.projectBindingSource.DataSource = this.project;
            // 
            // project
            // 
            this.project.DataSetName = "Project";
            this.project.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projectTableAdapter
            // 
            this.projectTableAdapter.ClearBeforeFill = true;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ExitButton.Location = new System.Drawing.Point(473, 291);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 25);
            this.ExitButton.TabIndex = 12;
            this.ExitButton.Text = "Vazgeç";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ProjecUpdateButton
            // 
            this.ProjecUpdateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ProjecUpdateButton.Location = new System.Drawing.Point(275, 291);
            this.ProjecUpdateButton.Name = "ProjecUpdateButton";
            this.ProjecUpdateButton.Size = new System.Drawing.Size(75, 25);
            this.ProjecUpdateButton.TabIndex = 10;
            this.ProjecUpdateButton.Text = "Güncelle";
            this.ProjecUpdateButton.UseVisualStyleBackColor = false;
            this.ProjecUpdateButton.Click += new System.EventHandler(this.ProjecUpdateButton_Click);
            // 
            // NewProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 325);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ProjecUpdateButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DeleteProjectButton);
            this.Controls.Add(this.ProjectDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "NewProjectForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewProjectForm";
            this.Load += new System.EventHandler(this.NewProjectForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.project)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CompanyComboBox;
        private System.Windows.Forms.Button AddProjectButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ProjectStatus;
        private System.Windows.Forms.TextBox ProjectName;
        private System.Windows.Forms.TextBox ProjectCost;
        private System.Windows.Forms.Button DeleteProjectButton;
        private System.Windows.Forms.TextBox ProjectID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView ProjectDataGridView;
   
        private System.Windows.Forms.DataGridViewTextBoxColumn projectIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn designerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn developerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn testerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn analystIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn projectStatusDataGridViewCheckBoxColumn;
        private System.Windows.Forms.ComboBox DesignerComboBox;
        private System.Windows.Forms.ComboBox DeveloperComboBox;
        private System.Windows.Forms.ComboBox AnalystComboBox;
        private System.Windows.Forms.ComboBox TesterComboBox;
        private System.Windows.Forms.ComboBox AdminComboBox;
        private Project project;
        private System.Windows.Forms.BindingSource projectBindingSource;
        private ProjectTableAdapters.ProjectTableAdapter projectTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Button ProjecUpdateButton;
        private System.Windows.Forms.Button ExitButton;
    }
}