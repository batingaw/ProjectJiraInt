using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Atlassian.Jira;
using Microsoft.Office.Tools.Ribbon;

namespace ProjectJiraInt
{
    public partial class SyncJiraRibbon
    {
        private void SyncJiraRibbon_Load(object sender, RibbonUIEventArgs e)
        {
            
        }

        private void BtnSettings_Click(object sender, RibbonControlEventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.ShowDialog();
        }

        private void BtnSync_Click(object sender, RibbonControlEventArgs e)
        {
            var jiraUrl = Properties.Settings.Default.JiraUrl;
            var user = Properties.Settings.Default.User;
            var password = Properties.Settings.Default.Password;
            if (string.IsNullOrEmpty(jiraUrl) || string.IsNullOrEmpty(user) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please check your settings. JIRA URL, user and password are required.");
                return;
            }
            IJiraIntegrationService jiraIntegrationService = new JiraIntegrationService(jiraUrl, user, password);
            jiraIntegrationService.SyncProject();
        }
    }
}
