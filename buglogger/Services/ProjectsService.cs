using System;
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

        internal Project GetOne(int id, string userId)
        {
            Project project = _projectsRepo.GetOne(id);
            if (project == null )
            {
                throw new Exception("No project by that id");
            }
            return project;
        }
    }
}