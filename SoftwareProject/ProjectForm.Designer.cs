
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
            this.ActivePojectButton = new System.Windows.Forms.Button();
            this.StartProject = new System.Windows.Forms.Button();
            this.NewProject = new System.Windows.Forms.Button();
            this.PersonelButton = new System.Windows.Forms.Button();
            this.PassivePojectButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.project = new SoftwareProject.Project();
            this.projectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectTableAdapter = new SoftwareProject.ProjectTableAdapters.ProjectTableAdapter();
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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.project)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ActivePojectButton
            // 
            this.ActivePojectButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ActivePojectButton.Location = new System.Drawing.Point(0, 3);
            this.ActivePojectButton.Name = "ActivePojectButton";
            this.ActivePojectButton.Size = new System.Drawing.Size(87, 25);
            this.ActivePojectButton.TabIndex = 0;
            this.ActivePojectButton.Text = "Aktif Projeler";
            this.ActivePojectButton.UseVisualStyleBackColor = true;
            this.ActivePojectButton.Click += new System.EventHandler(this.ActivePojectButton_Click);
            // 
            // StartProject
            // 
            this.StartProject.Location = new System.Drawing.Point(12, 288);
            this.StartProject.Name = "StartProject";
            this.StartProject.Size = new System.Drawing.Size(134, 23);
            this.StartProject.TabIndex = 4;
            this.StartProject.Text = "Projeyi Başlat";
            this.StartProject.UseVisualStyleBackColor = true;
            this.StartProject.Click += new System.EventHandler(this.StartProject_Click_1);
            // 
            // NewProject
            // 
            this.NewProject.Location = new System.Drawing.Point(193, 288);
            this.NewProject.Name = "NewProject";
            this.NewProject.Size = new System.Drawing.Size(128, 23);
            this.NewProject.TabIndex = 6;
            this.NewProject.Text = "Yeni Proje ( Ekle / Sil )";
            this.NewProject.UseVisualStyleBackColor = true;
            this.NewProject.Click += new System.EventHandler(this.NewProject_Click_1);
            // 
            // PersonelButton
            // 
            this.PersonelButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.PersonelButton.Location = new System.Drawing.Point(161, 3);
            this.PersonelButton.Name = "PersonelButton";
            this.PersonelButton.Size = new System.Drawing.Size(87, 25);
            this.PersonelButton.TabIndex = 7;
            this.PersonelButton.Text = "Personel";
            this.PersonelButton.UseVisualStyleBackColor = true;
            this.PersonelButton.Click += new System.EventHandler(this.PersonelButton_Click);
            // 
            // PassivePojectButton
            // 
            this.PassivePojectButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.PassivePojectButton.Location = new System.Drawing.Point(80, 3);
            this.PassivePojectButton.Name = "PassivePojectButton";
            this.PassivePojectButton.Size = new System.Drawing.Size(87, 25);
            this.PassivePojectButton.TabIndex = 8;
            this.PassivePojectButton.Text = "Pasif Projeler";
            this.PassivePojectButton.UseVisualStyleBackColor = true;
            this.PassivePojectButton.Click += new System.EventHandler(this.PassivePojectButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(0, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1037, 240);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.dataGridView1.Location = new System.Drawing.Point(0, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1036, 199);
            this.dataGridView1.TabIndex = 10;
            // 
            // project
            // 
            this.project.DataSetName = "Project";
            this.project.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projectBindingSource
            // 
            this.projectBindingSource.DataMember = "Project";
            this.projectBindingSource.DataSource = this.project;
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
            // ProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 330);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PassivePojectButton);
            this.Controls.Add(this.PersonelButton);
            this.Controls.Add(this.NewProject);
            this.Controls.Add(this.StartProject);
            this.Controls.Add(this.ActivePojectButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ProjectForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProjectForm";
            this.Load += new System.EventHandler(this.ProjectForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.project)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ActivePojectButton;
        private System.Windows.Forms.Button StartProject;
        private System.Windows.Forms.Button NewProject;
        private System.Windows.Forms.Button PersonelButton;
        private System.Windows.Forms.Button PassivePojectButton;
        private System.Windows.Forms.GroupBox groupBox1;
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
    }
}