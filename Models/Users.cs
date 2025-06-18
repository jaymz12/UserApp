using Microsoft.AspNetCore.Identity;

namespace UserApplication.Models
{
    public class Users : IdentityUser
    {
        public string FullName { get; set; }
    }
}
