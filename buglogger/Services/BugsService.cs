using System;
using System.Collections.Generic;
using buglogger.Models;
using buglogger.Repositories;

namespace buglogger.Services
{
    public class BugsService
    {
        private readonly BugsRepository _bugsRepo;

        public BugsService(BugsRepository bugsRepo)
        {
            _bugsRepo = bugsRepo;
        }

        internal Bug Create(Bug bugData, Account user)
        {
            return _bugsRepo.Create(bugData);
        }
        internal List<Bug> GetAll()
        {
            return _bugsRepo.GetAll();
        }

        internal Bug GetOne(int id, string userId)
        {
            Bug bug = _bugsRepo.GetOne(id);
            if (bug == null )
            {
                throw new Exception("no bug by that id");
            }
            return bug;
        }
        internal Bug Update(Bug newData, Account user)
        {
            Bug original = GetOne(newData.Id, user.Id);
            if (original.CreatorId != user.Id)
            {
                throw new Exception($"You are not the creator of {original.Name}");
            }
            original.Name = newData.Name ?? original.Name;
            original.Description = newData.Description ?? original.Description;
            original.Priority = newData.Priority ?? original.Priority;
            original.Following = newData.Following ?? original.Following;

            return _bugsRepo.Update(original);
        }
        internal string Delete(int id, Account user)
        {
            Bug original = GetOne(id, user.Id);
            if(original.CreatorId != user.Id)
            {
                throw new Exception($"Cannot delete {original.Name}");
            }
            _bugsRepo.Delete(id);
            return $"{original.Name} was deleted";
        }

    }
}