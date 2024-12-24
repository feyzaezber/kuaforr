using System.ComponentModel.DataAnnotations;

namespace kuaforr.Models
{
    public class Hizmetlerimiz
    {
        [Key]
        public int HizmetId { get; set; }
        public string HizmetIsim { get; set; }
        public string HizmetUcret { get; set; }
        public string HizmetFoto { get; set; }
        public virtual Calisanlarimiz? Calisanlarimiz { get; set; }
        public virtual Randevu? Randevu { get; set; }


    }
}
