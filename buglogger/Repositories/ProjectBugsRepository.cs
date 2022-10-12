using System.Data;

namespace buglogger.Repositories
{
    public class ProjectBugsRepository
    {
        private readonly IDbConnection _db;

        public ProjectBugsRepository(IDbConnection db)
        {
            _db = db;
        }
    }
}