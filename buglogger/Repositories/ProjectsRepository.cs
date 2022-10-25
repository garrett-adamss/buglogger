using System.Collections.Generic;
using System.Data;
using System.Linq;
using buglogger.Models;
using Dapper;

namespace buglogger.Repositories
{
    public class ProjectsRepository
    {
        private readonly IDbConnection _db;

        public ProjectsRepository(IDbConnection db)
        {
            _db = db;
        }

        internal List<Project> GetAll()
        {
            string sql = @"
            SELECT
            p.*,
            a.*
            FROM projects p
            JOIN accounts a ON p.creatorId = a.id
            GROUP BY (p.id)
            ";
            return _db.Query<Project, Profile, Project>(sql, (project, profile)=>
            {
                project.Creator = profile; 
                return project;
            }).ToList();
        }

    }
}