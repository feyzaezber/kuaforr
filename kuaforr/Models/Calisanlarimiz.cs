using System.ComponentModel.DataAnnotations;

namespace kuaforr.Models
{
    public class Calisanlarimiz
    {
        [Key]
        public int CalisanId {  get; set; }
        public string CalisanIsim { get; set; }
        public string CalisanSoyisim { get; set; }
        public string CalisanFoto { get; set; }
        public string CalisanMaas {  get; set; }
        public virtual ICollection<Hizmetlerimiz>? Hizmetlerimizs { get; set; }


    }
}
