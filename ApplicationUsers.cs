using Microsoft.AspNetCore.Identity;

namespace Recipe_Site.Models
{
    public class ApplicationUser : IdentityUser
    {
   
        public string FullName { get; set; }

      
        public string ProfilePicture { get; set; }
    }
}
