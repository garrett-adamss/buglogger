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

        internal List<Bug> GetAll()
        {
            return _bugsRepo.GetAll();
        }

        internal Bug GetOne(int bugId)
        {
            Bug bug = _bugsRepo.GetOne(bugId);
            if (bug == null )
            {
                throw new Exception("no bug by that id");
            }
            return bug;
        }
    }
}