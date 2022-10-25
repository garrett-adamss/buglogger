using System.Collections.Generic;
using buglogger.Models;
using buglogger.Repositories;

namespace buglogger.Services
{
    public class ProjectsService
    {
        private readonly ProjectsRepository _projectsRepo;

        public ProjectsService(ProjectsRepository projectsRepo)
        {
            _projectsRepo = projectsRepo;
        }

        internal List<Project> GetAll()
        {
            return _projectsRepo.GetAll();
        }
    }
}