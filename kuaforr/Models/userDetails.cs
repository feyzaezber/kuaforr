using Microsoft.AspNetCore.Identity;

namespace kuaforr.Models
{
    public class userDetails:IdentityUser
    {
        public string UserAd { get; set; }
        public string UserSoyad { get; set; }
    }
}
