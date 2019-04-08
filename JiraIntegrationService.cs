using Atlassian.Jira;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectJiraInt
{
    public class JiraIntegrationService : IJiraIntegrationService
    {
        private readonly Jira _jira;

        public JiraIntegrationService(string jiraUrl, string user, string password)
        {
            _jira = Jira.CreateRestClient(jiraUrl, user, password);
        }


        public IEnumerable<Project> GetProjects()
        {
            var projectService = _jira.Projects;
            var projects = (from p in projectService.GetProjectsAsync().Result
                           select new Project { Key = p.Key, Name = p.Name }).ToArray();
            return projects;
        }

        public void SyncProject()
        {
            Microsoft.Office.Interop.MSProject.Project project = Globals.ThisAddIn.Application.ActiveProject;

            var selectedProjectNames = Properties.Settings.Default.SelectedProjects;
            var projects = JsonConvert.DeserializeObject<IEnumerable<Project>>(Properties.Settings.Default.Projects);

            var selectedProjects = (from p in projects
                                       where selectedProjectNames.Contains(p.Name)
                                       select p).ToList();

            foreach (var selectedProject in selectedProjects)
            {
                Microsoft.Office.Interop.MSProject.Task newProjectTask = project.Tasks.Add(selectedProject.Name);
                newProjectTask.WBS = selectedProject.Key;
                if (newProjectTask.OutlineLevel == 2)
                {
                    newProjectTask.OutlineOutdent();
                }

                var issues = (from i in _jira.Issues.Queryable
                              where i.Status != "Done" && i.Project == selectedProject.Key
                              orderby i.Created
                              select i).Take(100);

                var isIndented = false;
                foreach (var issue in issues)
                {
                    Microsoft.Office.Interop.MSProject.Task newTask = project.Tasks.Add(issue.Summary);
                    newTask.WBS = issue.Key.ToString();
                    if (issue.TimeTrackingData.OriginalEstimate != null)
                    {
                        newTask.Duration = issue.TimeTrackingData.OriginalEstimate.Split(' ')[0];
                    }
                    newTask.ResourceNames = issue.Assignee;
                    if(!isIndented)
                    {
                        newTask.OutlineIndent();
                        isIndented = true;
                    }
                    //newTask.Priority = issue.Priority;
                }
            }
        }

        private void SyncProjectToJira(Microsoft.Office.Interop.MSProject.Project project, Jira jira)
        {
            foreach(Microsoft.Office.Interop.MSProject.Task task in project.Tasks)
            {
                if (task.OutlineLevel != 1)
                {
                    if (task.WBS == "")
                    {
                        //create task
                    }
                    else
                    {
                        var issue = jira.CreateIssue(task.Name);
                        issue.Type = "Story";
                        issue.Priority = "Medium";
                        issue.Summary = task.Summary;
                        issue.Assignee = task.ResourceNames;
                        var issueResult = issue.SaveChangesAsync().Result;
                        task.WBS = issueResult.Key.ToString();
                    }
                }
            }
        }
    }
}
