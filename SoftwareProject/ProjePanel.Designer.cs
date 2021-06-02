
namespace SoftwareProject
{
    partial class ProjePanel
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
            this.ActiveProjectButton = new System.Windows.Forms.Button();
            this.PasivveProjectButton = new System.Windows.Forms.Button();
            this.PersonelButton = new System.Windows.Forms.Button();
            this.StartProject = new System.Windows.Forms.Button();
            this.DeleteProject = new System.Windows.Forms.Button();
            this.NewProject = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ıd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sektör = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yöneticiID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TasarımcıID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TesterID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeveloperID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnalistID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ActiveProjectButton
            // 
            this.ActiveProjectButton.Location = new System.Drawing.Point(0, 10);
            this.ActiveProjectButton.Name = "ActiveProjectButton";
            this.ActiveProjectButton.Size = new System.Drawing.Size(75, 20);
            this.ActiveProjectButton.TabIndex = 0;
            this.ActiveProjectButton.Text = "Aktif Projeler";
            this.ActiveProjectButton.UseVisualStyleBackColor = true;
            this.ActiveProjectButton.Click += new System.EventHandler(this.ActiveProjectButton_Click);
            // 
            // PasivveProjectButton
            // 
            this.PasivveProjectButton.Location = new System.Drawing.Point(80, 10);
            this.PasivveProjectButton.Name = "PasivveProjectButton";
            this.PasivveProjectButton.Size = new System.Drawing.Size(78, 20);
            this.PasivveProjectButton.TabIndex = 1;
            this.PasivveProjectButton.Text = "Pasif Projeler";
            this.PasivveProjectButton.UseVisualStyleBackColor = true;
            this.PasivveProjectButton.Click += new System.EventHandler(this.PasivveProjectButton_Click);
            // 
            // PersonelButton
            // 
            this.PersonelButton.Location = new System.Drawing.Point(163, 10);
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
            this.StartProject.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.StartProject.Location = new System.Drawing.Point(0, 179);
            this.StartProject.Name = "StartProject";
            this.StartProject.Size = new System.Drawing.Size(135, 35);
            this.StartProject.TabIndex = 3;
            this.StartProject.Text = "Projeyi Başlat";
            this.StartProject.UseVisualStyleBackColor = true;
            this.StartProject.Click += new System.EventHandler(this.StartProject_Click);
            // 
            // DeleteProject
            // 
            this.DeleteProject.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.DeleteProject.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.DeleteProject.Location = new System.Drawing.Point(143, 179);
            this.DeleteProject.Name = "DeleteProject";
            this.DeleteProject.Size = new System.Drawing.Size(135, 35);
            this.DeleteProject.TabIndex = 4;
            this.DeleteProject.Text = "Projeyi Sil";
            this.DeleteProject.UseVisualStyleBackColor = true;
            this.DeleteProject.Click += new System.EventHandler(this.DeleteProject_Click);
            // 
            // NewProject
            // 
            this.NewProject.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.NewProject.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.NewProject.Location = new System.Drawing.Point(288, 179);
            this.NewProject.Name = "NewProject";
            this.NewProject.Size = new System.Drawing.Size(135, 35);
            this.NewProject.TabIndex = 5;
            this.NewProject.Text = "Yeni Proje";
            this.NewProject.UseVisualStyleBackColor = true;
            this.NewProject.Click += new System.EventHandler(this.NewProject_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıd,
            this.projeName,
            this.Sektör,
            this.yöneticiID,
            this.TasarımcıID,
            this.TesterID,
            this.DeveloperID,
            this.AnalistID});
            this.dataGridView1.Location = new System.Drawing.Point(0, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(844, 130);
            this.dataGridView1.TabIndex = 6;
            // 
            // ıd
            // 
            this.ıd.HeaderText = "ID";
            this.ıd.Name = "ıd";
            // 
            // projeName
            // 
            this.projeName.HeaderText = "Proje Adı";
            this.projeName.Name = "projeName";
            // 
            // Sektör
            // 
            this.Sektör.HeaderText = "Sektör";
            this.Sektör.Name = "Sektör";
            // 
            // yöneticiID
            // 
            this.yöneticiID.HeaderText = "YöneticiID";
            this.yöneticiID.Name = "yöneticiID";
            // 
            // TasarımcıID
            // 
            this.TasarımcıID.HeaderText = "TasarımcıID";
            this.TasarımcıID.Name = "TasarımcıID";
            // 
            // TesterID
            // 
            this.TesterID.HeaderText = "TesterID";
            this.TesterID.Name = "TesterID";
            // 
            // DeveloperID
            // 
            this.DeveloperID.HeaderText = "DeveloperID";
            this.DeveloperID.Name = "DeveloperID";
            // 
            // AnalistID
            // 
            this.AnalistID.HeaderText = "AnalistID";
            this.AnalistID.Name = "AnalistID";
            // 
            // ProjePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 250);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.NewProject);
            this.Controls.Add(this.DeleteProject);
            this.Controls.Add(this.StartProject);
            this.Controls.Add(this.PersonelButton);
            this.Controls.Add(this.PasivveProjectButton);
            this.Controls.Add(this.ActiveProjectButton);
            this.Name = "ProjePanel";
            this.Text = "ProjePanel";
            this.Load += new System.EventHandler(this.ProjePanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ActiveProjectButton;
        private System.Windows.Forms.Button PasivveProjectButton;
        private System.Windows.Forms.Button PersonelButton;
        private System.Windows.Forms.Button StartProject;
        private System.Windows.Forms.Button DeleteProject;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıd;
        private System.Windows.Forms.DataGridViewTextBoxColumn projeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sektör;
        private System.Windows.Forms.DataGridViewTextBoxColumn yöneticiID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TasarımcıID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TesterID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeveloperID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnalistID;
        private System.Windows.Forms.Button NewProject;
    }
}