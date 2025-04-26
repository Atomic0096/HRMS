using HRMS.Data;

namespace HRMS.Models;

public class Assignment
{
    public int Id { get; set; }
    public string? AssignmentName { get; set; }
    public DateOnly StartDate { get; set; }
    public string? Status { get; set; }

    //被发现
    public ICollection<ApplicationUser> ApplicationUsers { get; } = [];
}