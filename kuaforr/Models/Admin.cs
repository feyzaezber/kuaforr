using System.ComponentModel.DataAnnotations;

namespace kuaforr.Models
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }
        public string AdminIsim {  get; set; }
        public string SoyIsim { get; set; }
        public string AdminEmail { get; set; }
        public string AdminSifre { get; set; }
    }
}
