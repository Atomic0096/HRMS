using System.ComponentModel.DataAnnotations;

namespace HRMS.Models;

public class Department
{
    public int Id { get; set; }
    [Required]
    [StringLength(50)]
    public string? DepartmentName { get; set; }

    //被发现
    public ICollection<Employee> Employees { get; } = [];
    public ICollection<Recruitment> Recruitments { get; } = [];
}