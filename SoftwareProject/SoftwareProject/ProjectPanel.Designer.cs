
namespace SoftwareProject
{
    partial class ProjectPanel
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
            this.ActiveProjectButton = new System.Windows.Forms.Button();
            this.PasivveProjectButton = new System.Windows.Forms.Button();
            this.PersonelButton = new System.Windows.Forms.Button();
            this.StartProject = new System.Windows.Forms.Button();
            this.NewProject = new System.Windows.Forms.Button();
            this.ProjectDataGridView = new System.Windows.Forms.DataGridView();
            this.project = new SoftwareProject.Project();
            this.projectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectTableAdapter = new SoftwareProject.ProjectTableAdapters.ProjectTableAdapter();
            this.projectIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectStartDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectEndDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.developerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.analystIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectStatusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.project)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ActiveProjectButton
            // 
            this.ActiveProjectButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ActiveProjectButton.Location = new System.Drawing.Point(12, 10);
            this.ActiveProjectButton.Name = "ActiveProjectButton";
            this.ActiveProjectButton.Size = new System.Drawing.Size(75, 20);
            this.ActiveProjectButton.TabIndex = 0;
            this.ActiveProjectButton.Text = "Aktif Projeler";
            this.ActiveProjectButton.UseVisualStyleBackColor = true;
            this.ActiveProjectButton.Click += new System.EventHandler(this.ActiveProjectButton_Click);
            // 
            // PasivveProjectButton
            // 
            this.PasivveProjectButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.PasivveProjectButton.Location = new System.Drawing.Point(93, 10);
            this.PasivveProjectButton.Name = "PasivveProjectButton";
            this.PasivveProjectButton.Size = new System.Drawing.Size(78, 20);
            this.PasivveProjectButton.TabIndex = 1;
            this.PasivveProjectButton.Text = "Pasif Projeler";
            this.PasivveProjectButton.UseVisualStyleBackColor = true;
            this.PasivveProjectButton.Click += new System.EventHandler(this.PasivveProjectButton_Click);
            // 
            // PersonelButton
            // 
            this.PersonelButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.PersonelButton.Location = new System.Drawing.Point(177, 10);
            this.PersonelButton.Name = "PersonelButton";
            this.PersonelButton.Size = new System.Drawing.Size(82, 20);
            this.PersonelButton.TabIndex = 2;
            this.PersonelButton.Text = "Personel";
            this.PersonelButton.UseVisualStyleBackColor = true;
            this.PersonelButton.Click += new System.EventHandler(this.PersonelButton_Click);
            // 
            // StartProject
            // 
            this.StartProject.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.StartProject.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.StartProject.Location = new System.Drawing.Point(12, 179);
            this.StartProject.Name = "StartProject";
            this.StartProject.Size = new System.Drawing.Size(159, 35);
            this.StartProject.TabIndex = 3;
            this.StartProject.Text = "Projeyi Başlat";
            this.StartProject.UseVisualStyleBackColor = true;
            this.StartProject.Click += new System.EventHandler(this.StartProject_Click);
            // 
            // NewProject
            // 
            this.NewProject.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.NewProject.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NewProject.Location = new System.Drawing.Point(177, 179);
            this.NewProject.Name = "NewProject";
            this.NewProject.Size = new System.Drawing.Size(175, 35);
            this.NewProject.TabIndex = 5;
            this.NewProject.Text = "Yeni Proje ( Ekle / Sil )";
            this.NewProject.UseVisualStyleBackColor = true;
            this.NewProject.Click += new System.EventHandler(this.NewProject_Click);
            // 
            // ProjectDataGridView
            // 
            this.ProjectDataGridView.AllowUserToAddRows = false;
            this.ProjectDataGridView.AllowUserToDeleteRows = false;
            this.ProjectDataGridView.AutoGenerateColumns = false;
            this.ProjectDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProjectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProjectDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.projectIDDataGridViewTextBoxColumn,
            this.projectNameDataGridViewTextBoxColumn,
            this.projectCostDataGridViewTextBoxColumn,
            this.projectStartDateDataGridViewTextBoxColumn,
            this.projectEndDateDataGridViewTextBoxColumn,
            this.adminIDDataGridViewTextBoxColumn,
            this.designerIDDataGridViewTextBoxColumn,
            this.developerIDDataGridViewTextBoxColumn,
            this.testerIDDataGridViewTextBoxColumn,
            this.analystIDDataGridViewTextBoxColumn,
            this.projectStatusDataGridViewCheckBoxColumn});
            this.ProjectDataGridView.DataSource = this.projectBindingSource;
            this.ProjectDataGridView.Location = new System.Drawing.Point(12, 43);
            this.ProjectDataGridView.Name = "ProjectDataGridView";
            this.ProjectDataGridView.ReadOnly = true;
            this.ProjectDataGridView.RowTemplate.Height = 25;
            this.ProjectDataGridView.Size = new System.Drawing.Size(1145, 121);
            this.ProjectDataGridView.TabIndex = 6;
       
            // 
            // project
            // 
            this.project.DataSetName = "Project";
            this.project.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projectBindingSource
            // 
            this.projectBindingSource.DataMember = "Project";
           
            // 
            // projectTableAdapter
            // 
            this.projectTableAdapter.ClearBeforeFill = true;
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
            // projectStartDateDataGridViewTextBoxColumn
            // 
            this.projectStartDateDataGridViewTextBoxColumn.DataPropertyName = "projectStartDate";
            this.projectStartDateDataGridViewTextBoxColumn.HeaderText = "projectStartDate";
            this.projectStartDateDataGridViewTextBoxColumn.Name = "projectStartDateDataGridViewTextBoxColumn";
            this.projectStartDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // projectEndDateDataGridViewTextBoxColumn
            // 
            this.projectEndDateDataGridViewTextBoxColumn.DataPropertyName = "projectEndDate";
            this.projectEndDateDataGridViewTextBoxColumn.HeaderText = "projectEndDate";
            this.projectEndDateDataGridViewTextBoxColumn.Name = "projectEndDateDataGridViewTextBoxColumn";
            this.projectEndDateDataGridViewTextBoxColumn.ReadOnly = true;
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
            // projectStatusDataGridViewCheckBoxColumn
            // 
            this.projectStatusDataGridViewCheckBoxColumn.DataPropertyName = "projectStatus";
            this.projectStatusDataGridViewCheckBoxColumn.HeaderText = "projectStatus";
            this.projectStatusDataGridViewCheckBoxColumn.Name = "projectStatusDataGridViewCheckBoxColumn";
            this.projectStatusDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // ProjectPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 223);
            this.Controls.Add(this.ProjectDataGridView);
            this.Controls.Add(this.NewProject);
            this.Controls.Add(this.StartProject);
            this.Controls.Add(this.PersonelButton);
            this.Controls.Add(this.PasivveProjectButton);
            this.Controls.Add(this.ActiveProjectButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ProjectPanel";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proje Paneli";
            this.Load += new System.EventHandler(this.ProjePanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProjectDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.project)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ActiveProjectButton;
        private System.Windows.Forms.Button PasivveProjectButton;
        private System.Windows.Forms.Button PersonelButton;
        private System.Windows.Forms.Button StartProject;
        private System.Windows.Forms.DataGridView ProjectDataGridView;
        private System.Windows.Forms.Button NewProject;
        private Project project;
        private System.Windows.Forms.BindingSource projectBindingSource;
        private ProjectTableAdapters.ProjectTableAdapter projectTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectStartDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectEndDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn designerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn developerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn testerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn analystIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn projectStatusDataGridViewCheckBoxColumn;
    }
}