using GCBData.DTO;
using GCBModel.FragranceModel;

namespace GCBCORE.IServices
{
    public interface IFrangranceService
    {
        List<Fragrance> GetAllFragrances();
        Fragrance GetFragranceById(string Id);
        void AddFragrance(FragranceDTO fragrance);
        void UpdateFragrance(string Id, FragranceDTO updatedFragrance);
        void DeleteFragrance(string Id);
    }
}
