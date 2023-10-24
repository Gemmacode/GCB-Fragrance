using GCBData.DTO;
using GCBModel.FragranceModel;

namespace GCBCORE.IServices
{
    public interface IFrangranceService
    {
        List<Fragrance> GetAllFragrances();
        Fragrance GetFragranceById(int id);
        void AddFragrance(FragranceDTO fragrance);
        void UpdateFragrance(int Id, FragranceDTO updatedFragrance);
        void DeleteFragrance(int Id);
    }
}
