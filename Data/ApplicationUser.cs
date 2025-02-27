using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace HRMS.Data;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
    [Required]
    [MaxLength(100)]
    public string Name { get; set; } = string.Empty;
}