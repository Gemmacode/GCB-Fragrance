using GemsData.DTO;
using GemsModel.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GemsCore.IServices
{
    public interface IFragranceService
    {
        List<Fragrance> GetAllFragrances();
        Fragrance GetFragranceById(string Id);
        string AddFragrance(FragranceDTO fragrance);
        string UpdateFragrance(string Id, FragranceDTO updatedFragrance);
        string DeleteFragrance(string Id);
    }
}
