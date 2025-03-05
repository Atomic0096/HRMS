using System.ComponentModel.DataAnnotations;
using HRMS.Data;

namespace HRMS.Models;

public class Department
{
    public int Id { get; set; }
    [Required(ErrorMessage = "部门名称为必填项")]
    [StringLength(50)]
    public string? DepartmentName { get; set; }

    //被发现
    public ICollection<ApplicationUser> ApplicationUsers { get; } = [];
    public ICollection<Recruitment> Recruitments { get; } = [];
}