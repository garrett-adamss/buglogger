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

        internal Project Create(Project projectData, Account user)
        {
            return _projectsRepo.Create(projectData);
        }

        internal Project Update(Project projectData, Account user)
        {
            Project original = GetOne(projectData.Id, user.Id);
            if (original.CreatorId != user.Id)
            {
                throw new Exception($"You are not the owner of {original.Name}");
            }
            original.Name = projectData.Name ?? original.Name;
            original.Description = projectData.Description ?? original.Description;

            return _projectsRepo.Update(original);
        }

        internal string Delete(int id, Account user)
        {
            Project original = GetOne(id, user.Id);
            if(original.CreatorId != user.Id)
            {
                throw new Exception($"Cannot delete {original.Name}, this is not your project");
            }
            _projectsRepo.Delete(id);
            return $"{original.Name} was deleted.";
        }
    }
}