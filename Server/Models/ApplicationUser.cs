using Microsoft.AspNetCore.Identity;

namespace DepoManagment.Server.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? StaffName { get; set; }
        public string? BadgeNumber { get; set; }
    }
}