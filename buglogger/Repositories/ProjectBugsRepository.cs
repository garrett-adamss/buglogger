using System;
using System.Collections.Generic;
using System.Data;
using buglogger.Models;

namespace buglogger.Repositories
{
    public class ProjectBugsRepository
    {
        private readonly IDbConnection _db;

        public ProjectBugsRepository(IDbConnection db)
        {
            _db = db;
        }

        internal List<Project> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}