namespace WebAppGenerator
{
    partial class FrmCreateNewProject
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCreateProject = new System.Windows.Forms.Button();
            this.btnProjectLocation = new System.Windows.Forms.Button();
            this.txtProjectLocation = new System.Windows.Forms.TextBox();
            this.lblProjectLocation = new System.Windows.Forms.Label();
            this.cboProjectType = new System.Windows.Forms.ComboBox();
            this.lblProjectType = new System.Windows.Forms.Label();
            this.txtSolutionName = new System.Windows.Forms.TextBox();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.lblSolutionName = new System.Windows.Forms.Label();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // btnCreateProject
            // 
            this.btnCreateProject.Enabled = false;
            this.btnCreateProject.Location = new System.Drawing.Point(187, 186);
            this.btnCreateProject.Name = "btnCreateProject";
            this.btnCreateProject.Size = new System.Drawing.Size(115, 23);
            this.btnCreateProject.TabIndex = 18;
            this.btnCreateProject.Text = "Create Project";
            this.btnCreateProject.UseVisualStyleBackColor = true;
            this.btnCreateProject.Click += new System.EventHandler(this.btnCreateProject_Click);
            // 
            // btnProjectLocation
            // 
            this.btnProjectLocation.Location = new System.Drawing.Point(427, 127);
            this.btnProjectLocation.Name = "btnProjectLocation";
            this.btnProjectLocation.Size = new System.Drawing.Size(24, 23);
            this.btnProjectLocation.TabIndex = 17;
            this.btnProjectLocation.Text = "...";
            this.btnProjectLocation.UseVisualStyleBackColor = true;
            this.btnProjectLocation.Click += new System.EventHandler(this.btnProjectLocation_Click);
            // 
            // txtProjectLocation
            // 
            this.txtProjectLocation.Location = new System.Drawing.Point(124, 127);
            this.txtProjectLocation.Name = "txtProjectLocation";
            this.txtProjectLocation.Size = new System.Drawing.Size(297, 20);
            this.txtProjectLocation.TabIndex = 14;
            this.txtProjectLocation.TextChanged += new System.EventHandler(this.txtProjectLocation_TextChanged);
            // 
            // lblProjectLocation
            // 
            this.lblProjectLocation.AutoSize = true;
            this.lblProjectLocation.Location = new System.Drawing.Point(31, 130);
            this.lblProjectLocation.Name = "lblProjectLocation";
            this.lblProjectLocation.Size = new System.Drawing.Size(87, 13);
            this.lblProjectLocation.TabIndex = 16;
            this.lblProjectLocation.Text = "Project Location:";
            // 
            // cboProjectType
            // 
            this.cboProjectType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProjectType.FormattingEnabled = true;
            this.cboProjectType.Items.AddRange(new object[] {
            "C# Web Application"});
            this.cboProjectType.Location = new System.Drawing.Point(124, 39);
            this.cboProjectType.Name = "cboProjectType";
            this.cboProjectType.Size = new System.Drawing.Size(327, 21);
            this.cboProjectType.TabIndex = 10;
            this.cboProjectType.Tag = "";
            this.cboProjectType.TextChanged += new System.EventHandler(this.cboProjectType_TextChanged);
            // 
            // lblProjectType
            // 
            this.lblProjectType.AutoSize = true;
            this.lblProjectType.Location = new System.Drawing.Point(50, 42);
            this.lblProjectType.Name = "lblProjectType";
            this.lblProjectType.Size = new System.Drawing.Size(70, 13);
            this.lblProjectType.TabIndex = 15;
            this.lblProjectType.Text = "Project Type:";
            // 
            // txtSolutionName
            // 
            this.txtSolutionName.Location = new System.Drawing.Point(124, 98);
            this.txtSolutionName.Name = "txtSolutionName";
            this.txtSolutionName.Size = new System.Drawing.Size(327, 20);
            this.txtSolutionName.TabIndex = 13;
            this.txtSolutionName.TextChanged += new System.EventHandler(this.txtSolutionName_TextChanged);
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(124, 69);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(327, 20);
            this.txtProjectName.TabIndex = 12;
            this.txtProjectName.TextChanged += new System.EventHandler(this.txtProjectName_TextChanged);
            this.txtProjectName.Leave += new System.EventHandler(this.txtProjectName_Leave);
            // 
            // lblSolutionName
            // 
            this.lblSolutionName.AutoSize = true;
            this.lblSolutionName.Location = new System.Drawing.Point(14, 101);
            this.lblSolutionName.Name = "lblSolutionName";
            this.lblSolutionName.Size = new System.Drawing.Size(104, 13);
            this.lblSolutionName.TabIndex = 11;
            this.lblSolutionName.Text = "New Solution Name:";
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Location = new System.Drawing.Point(19, 72);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(99, 13);
            this.lblProjectName.TabIndex = 9;
            this.lblProjectName.Text = "New Project Name:";
            // 
            // FrmCreateNewProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 232);
            this.Controls.Add(this.btnCreateProject);
            this.Controls.Add(this.btnProjectLocation);
            this.Controls.Add(this.txtProjectLocation);
            this.Controls.Add(this.lblProjectLocation);
            this.Controls.Add(this.cboProjectType);
            this.Controls.Add(this.lblProjectType);
            this.Controls.Add(this.txtSolutionName);
            this.Controls.Add(this.txtProjectName);
            this.Controls.Add(this.lblSolutionName);
            this.Controls.Add(this.lblProjectName);
            this.Name = "FrmCreateNewProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create New Project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateProject;
        private System.Windows.Forms.Button btnProjectLocation;
        private System.Windows.Forms.TextBox txtProjectLocation;
        private System.Windows.Forms.Label lblProjectLocation;
        private System.Windows.Forms.ComboBox cboProjectType;
        private System.Windows.Forms.Label lblProjectType;
        private System.Windows.Forms.TextBox txtSolutionName;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.Label lblSolutionName;
        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}