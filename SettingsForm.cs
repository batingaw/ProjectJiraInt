using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectJiraInt
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.JiraUrl = txtJiraUrl.Text;
            Properties.Settings.Default.User = txtUser.Text;
            Properties.Settings.Default.Password = txtPassword.Text;
            StringCollection selectedProjects = new StringCollection();
            selectedProjects.AddRange(clbProjects.CheckedItems.OfType<string>().ToArray());
            Properties.Settings.Default.SelectedProjects = selectedProjects;
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            txtJiraUrl.Text = Properties.Settings.Default.JiraUrl;
            txtUser.Text = Properties.Settings.Default.User;
            txtPassword.Text = Properties.Settings.Default.Password;

            if (!string.IsNullOrEmpty(Properties.Settings.Default.Projects))
            {
                var projects = JsonConvert.DeserializeObject<IEnumerable<Project>>(Properties.Settings.Default.Projects);
                clbProjects.Items.Clear();
                clbProjects.Items.AddRange((from p in projects
                                            select p.Name).ToArray());

                if (Properties.Settings.Default.SelectedProjects != null && Properties.Settings.Default.SelectedProjects.Count > 0)
                {
                    for (int i = 0; i < clbProjects.Items.Count; i++)
                    {
                        if (IsInSelectedProjects(clbProjects.Items[i].ToString()))
                        {
                            clbProjects.SetItemChecked(i, true);
                        }
                    }

                }
            }
        }

        private bool IsInSelectedProjects(string project)
        {
            foreach(var selectedProject in Properties.Settings.Default.SelectedProjects)
            {
                if(project == selectedProject)
                {
                    return true;
                }
            }
            return false;
        }

        private void BtnGetProjects_Click(object sender, EventArgs e)
        {
            if(txtJiraUrl.Text == "" || txtUser.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please enter JIRA URL, User and Password!");
                return;
            }

            IJiraIntegrationService jiraIntegrationService = new JiraIntegrationService(txtJiraUrl.Text, txtUser.Text, txtPassword.Text);
            var projects = jiraIntegrationService.GetProjects().ToArray();

            clbProjects.Items.Clear();
            clbProjects.Items.AddRange((from p in projects
                                       select p.Name).ToArray());
            
            Properties.Settings.Default.Projects = JsonConvert.SerializeObject(projects);
            Properties.Settings.Default.Save();
        }
    }
}
