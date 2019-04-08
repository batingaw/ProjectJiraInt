namespace ProjectJiraInt
{
    partial class SettingsForm
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
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtJiraUrl = new System.Windows.Forms.TextBox();
            this.lblJiraUrl = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.clbProjects = new System.Windows.Forms.CheckedListBox();
            this.lblProjects = new System.Windows.Forms.Label();
            this.btnGetProjects = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(223, 302);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(130, 302);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // txtJiraUrl
            // 
            this.txtJiraUrl.Location = new System.Drawing.Point(89, 23);
            this.txtJiraUrl.Name = "txtJiraUrl";
            this.txtJiraUrl.Size = new System.Drawing.Size(290, 20);
            this.txtJiraUrl.TabIndex = 2;
            // 
            // lblJiraUrl
            // 
            this.lblJiraUrl.AutoSize = true;
            this.lblJiraUrl.Location = new System.Drawing.Point(12, 26);
            this.lblJiraUrl.Name = "lblJiraUrl";
            this.lblJiraUrl.Size = new System.Drawing.Size(55, 13);
            this.lblJiraUrl.TabIndex = 3;
            this.lblJiraUrl.Text = "JIRA URL";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(89, 60);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(290, 20);
            this.txtUser.TabIndex = 4;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(12, 63);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(29, 13);
            this.lblUser.TabIndex = 6;
            this.lblUser.Text = "User";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(12, 105);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(89, 102);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = 'X';
            this.txtPassword.Size = new System.Drawing.Size(290, 20);
            this.txtPassword.TabIndex = 8;
            // 
            // clbProjects
            // 
            this.clbProjects.FormattingEnabled = true;
            this.clbProjects.Location = new System.Drawing.Point(89, 179);
            this.clbProjects.Name = "clbProjects";
            this.clbProjects.Size = new System.Drawing.Size(290, 94);
            this.clbProjects.TabIndex = 9;
            // 
            // lblProjects
            // 
            this.lblProjects.AutoSize = true;
            this.lblProjects.Location = new System.Drawing.Point(13, 179);
            this.lblProjects.Name = "lblProjects";
            this.lblProjects.Size = new System.Drawing.Size(45, 13);
            this.lblProjects.TabIndex = 10;
            this.lblProjects.Text = "Projects";
            // 
            // btnGetProjects
            // 
            this.btnGetProjects.Location = new System.Drawing.Point(89, 139);
            this.btnGetProjects.Name = "btnGetProjects";
            this.btnGetProjects.Size = new System.Drawing.Size(139, 23);
            this.btnGetProjects.TabIndex = 11;
            this.btnGetProjects.Text = "Get Projects From JIRA";
            this.btnGetProjects.UseVisualStyleBackColor = true;
            this.btnGetProjects.Click += new System.EventHandler(this.BtnGetProjects_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 347);
            this.Controls.Add(this.btnGetProjects);
            this.Controls.Add(this.lblProjects);
            this.Controls.Add(this.clbProjects);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblJiraUrl);
            this.Controls.Add(this.txtJiraUrl);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtJiraUrl;
        private System.Windows.Forms.Label lblJiraUrl;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckedListBox clbProjects;
        private System.Windows.Forms.Label lblProjects;
        private System.Windows.Forms.Button btnGetProjects;
    }
}