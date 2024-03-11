using Microsoft.AspNetCore.Identity;

namespace atbackend.Data;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
    public DateTime LastConnection { get; set; } = DateTime.UtcNow;
    public DateTime LastSeenComments { get; set; } = DateTime.UtcNow;
    
    public ApplicationUser()
    {
        LastConnection = DateTime.UtcNow;
        LastSeenComments = DateTime.UtcNow;
    }
}