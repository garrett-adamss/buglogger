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

        internal Project GetOne(int id)
        {
            string sql = @"
                SELECT
                p.*,
                a.*
                FROM project p
                JOIN accounts a ON p.creatorId = a.id
                WHERE p.id = @id
            ";
            return _db.Query<Project, Profile, Project>(sql, (project, profile)=>
            {
                project.Creator = profile; 
                return project;
            }, new { id }).FirstOrDefault();
        }

        internal Project Create(Project projectData)
        {
            string sql = @"
            INSERT INTO projects
            (creatorId, name, description)
            VALUES
            (@creatorId, @name, @description);
            SELECT LAST_INSERT_ID();
            ";
            int id = _db.ExecuteScalar<int>(sql, projectData);
            projectData.Id = id;
            return projectData;
        }
    }
}