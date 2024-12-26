using System.ComponentModel.DataAnnotations;

namespace kuaforr.Models
{
    public class Uye
    {
        [Key]
        public int UyeId { get; set; }
        public string UyeIsim { get; set; }
        public string UyeSoyisim { get; set; }
        public string UyeEmail { get; set; }
        public string UyeSifre { get; set; }
        public virtual ICollection<Hizmetlerimiz>? Hizmetlerimizs { get; set; }
        public int HizmetId { get; set; }
        public virtual ICollection<Randevu>? Randevus { get; set; }
        public int RandevuId { get; set; }
    }
}
