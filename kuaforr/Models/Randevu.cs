using System.ComponentModel.DataAnnotations;

namespace kuaforr.Models
{
    public class Randevu
    {
        [Key]
        public int RandevuId { get; set; }
        public string RandevuIsimSoyisim { get; set; }
        public string RandevuSaati { get; set; }
        public string RandevuTarihi { get; set; }
        public int CalisanId { get; set; }
        public virtual ICollection<Hizmetlerimiz>? Hizmetlerimizs { get; set; }
        public int HizmetId { get; set; }
        public virtual ICollection<Calisanlarimiz>? Calisanlarimizs { get; set; }

    }
}
