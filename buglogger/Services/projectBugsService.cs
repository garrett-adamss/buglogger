using System.Collections.Generic;
using buglogger.Models;
using buglogger.Repositories;

namespace buglogger.Services
{
    public class ProjectBugsService
    {
        private readonly ProjectBugsRepository _projectBugsRepo;

        public ProjectBugsService(ProjectBugsRepository projectBugsRepo)
        {
            _projectBugsRepo = projectBugsRepo;
        }

        internal List<Project> GetAll()
        {
            return _projectBugsRepo.GetAll();
        }
    }
}