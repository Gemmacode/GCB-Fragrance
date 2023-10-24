using GCBCORE.IServices;
using GCBData;
using GCBData.DTO;
using GCBModel.FragranceModel;

namespace GCBCORE.Services
{
    public class FragranceService : IFrangranceService
    {
        private readonly FDbContext _dbContext;

        public FragranceService(FDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddFragrance(FragranceDTO fragrance)
        {
            throw new NotImplementedException();
        }

        public void DeleteFragrance(string Id)
        {
            throw new NotImplementedException();
        }

        public List<Fragrance> GetAllFragrances()
        {
            throw new NotImplementedException();
        }

        public Fragrance GetFragranceById(string Id)
        {
            throw new NotImplementedException();
        }

        public void UpdateFragrance(string Id, FragranceDTO updatedFragrance)
        {
            throw new NotImplementedException();
        }
    }
}
