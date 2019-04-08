using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectJiraInt
{
    public interface IJiraIntegrationService
    {
        IEnumerable<Project> GetProjects();
        void SyncProject();
    }
}
