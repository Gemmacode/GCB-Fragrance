using GCBCORE.IServices;
using GCBData;

namespace GCBCORE.Services
{
    public class FragranceService : IFrangranceService
    {
        private readonly FDbContext _dbContext;

        public FragranceService(FDbContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
