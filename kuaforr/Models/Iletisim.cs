using System.ComponentModel.DataAnnotations;

namespace kuaforr.Models
{
    public class Iletisim
    {
        [Key]
        public int IletisimId { get; set; }
        public string IletisimAdresi { get; set; }
        public string IletisimMail { get; set; }
        public string IletisimTelefon { get; set; }
    }
}
