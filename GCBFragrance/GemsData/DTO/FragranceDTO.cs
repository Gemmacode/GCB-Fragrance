using GemsModel.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GemsData.DTO
{
    public class FragranceDTO
    {
        [Required]
        public string Name { get; set; }
        [Required]

        public string Brand { get; set; }
        [Required]

        public decimal Price { get; set; }
        [Required]

        public string Description { get; set; }
        [Required]

        public int VolumeInMilliliters { get; set; }
        [Required]

        public FragranceType Type { get; set; }
        [Required]

        public FragranceIntensity Intensity { get; set; }
        [Required]

        public GenderPreference Preference { get; set; }
    }
}
