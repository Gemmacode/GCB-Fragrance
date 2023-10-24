using GCBModel.Enum;

namespace GCBModel.FragranceModel
{
    public class Fragrance : BaseEntity
    {
        public string Name { get; set; }

        public string Brand { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }

        public int VolumeInMilliliters { get; set; }

        public FragranceType Type { get; set; }

        public FragranceIntensity Intensity { get; set; }

        public GenderPreference Preference { get; set; }
    }
}