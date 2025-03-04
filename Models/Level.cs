using System.ComponentModel.DataAnnotations;

namespace HRMS.Models;

public class Level
{
    public int Id { get; set; }
    [Required(ErrorMessage = "职位名称为必填项")]
    [StringLength(50)]
    public string? LevelName { get; set; }

    //被发现
    public ICollection<Employee> Employees { get; } = [];
    public ICollection<Recruitment> Recruitments { get; } = [];
}