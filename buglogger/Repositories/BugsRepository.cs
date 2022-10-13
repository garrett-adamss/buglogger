using System.Collections.Generic;
using System.Data;
using System.Linq;
using buglogger.Models;
using Dapper;

namespace buglogger.Repositories
{
    public class BugsRepository
    {
        private readonly IDbConnection _db;

        public BugsRepository(IDbConnection db)
        {
            _db = db;
        }

        internal List<Bug> GetAll()
        {
            string sql = @"
                SELECT
                b.*,
                a.*
                FROM bugs b
                JOIN accounts a ON b.creatorId = a.id
                GROUP BY (b.id)
            ";
            return _db.Query<Bug, Profile, Bug>(sql, (bug, profile) =>
            {
                bug.Creator = profile;
                return bug;
            }).ToList();
        }

        internal Bug GetOne(int bugId)
        {
            string sql = @"
                SELECT
                b.*,
                a.*
                FROM bugs b
                JOIN accounts a ON b.creatorId = a.id
                WHERE b.id = @id
            ";
            return _db.Query<Bug, Profile, Bug>(sql, (bug, profile)=>
            {
                bug.Creator = profile;
                return bug;
            }, new { bugId }).FirstOrDefault();
        }
    }
}