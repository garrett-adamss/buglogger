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

        internal Bug Create(Bug bugData)
        {
            string sql=@"
            INSERT INTO bugs
            (creatorId, name, description, priority)
            VALUES
            (@creatorId, @name, @description, @priority)
            SELECT LAST_INSERT_ID();
            ";
            int id = _db.ExecuteScalar<int>(sql, bugData);
            bugData.Id = id; 
            return bugData;
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

        internal Bug GetOne(int id)
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
            }, new { id }).FirstOrDefault();
        }

        internal Bug Update(Bug newData)
        {
            string sql =@"
            UPDATE bugs SET
            name = @name,
            description = @description,
            priority = @priority,
            following = @following
            WHERE id = @id;
            ";
            _db.Execute(sql, newData);
            return newData;
        }

        internal void Delete(int id)
        {
            string sql = @"
            DELETE FROM bugs WHERE id = @id;
            ";
            _db.Execute(sql, new { id });
        }
    }
}