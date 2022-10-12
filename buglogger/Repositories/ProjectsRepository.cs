using System.Data;

namespace buglogger.Repositories
{
    public class ProjectsRepository
    {
        private readonly IDbConnection _db;

        public ProjectsRepository(IDbConnection db)
        {
            _db = db;
        }
    }
}