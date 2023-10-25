using GemsModel.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GemsModel.Entity
{
    public class Fragrance :BaseEntity
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
