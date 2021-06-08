
namespace SoftwareProject
{
    partial class ProjectForm
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
            this.NewProject = new System.Windows.Forms.Button();
            this.PersonelButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.projectIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.developerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.analystIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectStatusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.projectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.project = new SoftwareProject.Project();
            this.projectTableAdapter = new SoftwareProject.ProjectTableAdapters.ProjectTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.project)).BeginInit();
            this.SuspendLayout();
            // 
            // NewProject
            // 
            this.NewProject.BackColor = System.Drawing.SystemColors.Info;
            this.NewProject.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NewProject.ForeColor = System.Drawing.SystemColors.Highlight;
            this.NewProject.Location = new System.Drawing.Point(12, 311);
            this.NewProject.Name = "NewProject";
            this.NewProject.Size = new System.Drawing.Size(180, 40);
            this.NewProject.TabIndex = 0;
            this.NewProject.Text = "Yeni Proje ( Ekle / Sil / Güncelle )";
            this.NewProject.UseVisualStyleBackColor = false;
            this.NewProject.Click += new System.EventHandler(this.NewProject_Click_1);
            // 
            // PersonelButton
            // 
            this.PersonelButton.BackColor = System.Drawing.SystemColors.Info;
            this.PersonelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PersonelButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.PersonelButton.Location = new System.Drawing.Point(12, 12);
            this.PersonelButton.Name = "PersonelButton";
            this.PersonelButton.Size = new System.Drawing.Size(87, 25);
            this.PersonelButton.TabIndex = 1;
            this.PersonelButton.Text = "Personel";
            this.PersonelButton.UseVisualStyleBackColor = false;
            this.PersonelButton.Click += new System.EventHandler(this.PersonelButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Crimson;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ExitButton.Location = new System.Drawing.Point(964, 312);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(90, 40);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Çıkış Yap";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.projectIDDataGridViewTextBoxColumn,
            this.projectNameDataGridViewTextBoxColumn,
            this.projectCostDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn,
            this.adminIDDataGridViewTextBoxColumn,
            this.designerIDDataGridViewTextBoxColumn,
            this.developerIDDataGridViewTextBoxColumn,
            this.testerIDDataGridViewTextBoxColumn,
            this.analystIDDataGridViewTextBoxColumn,
            this.companyIDDataGridViewTextBoxColumn,
            this.projectStatusDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.projectBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1042, 262);
            this.dataGridView1.TabIndex = 10;
            // 
            // projectIDDataGridViewTextBoxColumn
            // 
            this.projectIDDataGridViewTextBoxColumn.DataPropertyName = "projectID";
            this.projectIDDataGridViewTextBoxColumn.HeaderText = "projectID";
            this.projectIDDataGridViewTextBoxColumn.Name = "projectIDDataGridViewTextBoxColumn";
            this.projectIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // projectNameDataGridViewTextBoxColumn
            // 
            this.projectNameDataGridViewTextBoxColumn.DataPropertyName = "projectName";
            this.projectNameDataGridViewTextBoxColumn.HeaderText = "projectName";
            this.projectNameDataGridViewTextBoxColumn.Name = "projectNameDataGridViewTextBoxColumn";
            this.projectNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // projectCostDataGridViewTextBoxColumn
            // 
            this.projectCostDataGridViewTextBoxColumn.DataPropertyName = "projectCost";
            this.projectCostDataGridViewTextBoxColumn.HeaderText = "projectCost";
            this.projectCostDataGridViewTextBoxColumn.Name = "projectCostDataGridViewTextBoxColumn";
            this.projectCostDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "StartDate";
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            this.startDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            this.endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            this.endDateDataGridViewTextBoxColumn.HeaderText = "EndDate";
            this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            this.endDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adminIDDataGridViewTextBoxColumn
            // 
            this.adminIDDataGridViewTextBoxColumn.DataPropertyName = "adminID";
            this.adminIDDataGridViewTextBoxColumn.HeaderText = "adminID";
            this.adminIDDataGridViewTextBoxColumn.Name = "adminIDDataGridViewTextBoxColumn";
            this.adminIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // designerIDDataGridViewTextBoxColumn
            // 
            this.designerIDDataGridViewTextBoxColumn.DataPropertyName = "designerID";
            this.designerIDDataGridViewTextBoxColumn.HeaderText = "designerID";
            this.designerIDDataGridViewTextBoxColumn.Name = "designerIDDataGridViewTextBoxColumn";
            this.designerIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // developerIDDataGridViewTextBoxColumn
            // 
            this.developerIDDataGridViewTextBoxColumn.DataPropertyName = "developerID";
            this.developerIDDataGridViewTextBoxColumn.HeaderText = "developerID";
            this.developerIDDataGridViewTextBoxColumn.Name = "developerIDDataGridViewTextBoxColumn";
            this.developerIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // testerIDDataGridViewTextBoxColumn
            // 
            this.testerIDDataGridViewTextBoxColumn.DataPropertyName = "testerID";
            this.testerIDDataGridViewTextBoxColumn.HeaderText = "testerID";
            this.testerIDDataGridViewTextBoxColumn.Name = "testerIDDataGridViewTextBoxColumn";
            this.testerIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // analystIDDataGridViewTextBoxColumn
            // 
            this.analystIDDataGridViewTextBoxColumn.DataPropertyName = "analystID";
            this.analystIDDataGridViewTextBoxColumn.HeaderText = "analystID";
            this.analystIDDataGridViewTextBoxColumn.Name = "analystIDDataGridViewTextBoxColumn";
            this.analystIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // companyIDDataGridViewTextBoxColumn
            // 
            this.companyIDDataGridViewTextBoxColumn.DataPropertyName = "companyID";
            this.companyIDDataGridViewTextBoxColumn.HeaderText = "companyID";
            this.companyIDDataGridViewTextBoxColumn.Name = "companyIDDataGridViewTextBoxColumn";
            this.companyIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // projectStatusDataGridViewCheckBoxColumn
            // 
            this.projectStatusDataGridViewCheckBoxColumn.DataPropertyName = "projectStatus";
            this.projectStatusDataGridViewCheckBoxColumn.HeaderText = "projectStatus";
            this.projectStatusDataGridViewCheckBoxColumn.Name = "projectStatusDataGridViewCheckBoxColumn";
            this.projectStatusDataGridViewCheckBoxColumn.ReadOnly = true;
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(211, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 40);
            this.button1.TabIndex = 11;
            this.button1.Text = "Şirket ( Ekle / Sil / Güncelle )";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 360);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.PersonelButton);
            this.Controls.Add(this.NewProject);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ProjectForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProjectForm";
            this.Load += new System.EventHandler(this.ProjectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.project)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button NewProject;
        private System.Windows.Forms.Button PersonelButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Project project;
        private System.Windows.Forms.BindingSource projectBindingSource;
        private ProjectTableAdapters.ProjectTableAdapter projectTableAdapter;
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
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button button1;
    }
}