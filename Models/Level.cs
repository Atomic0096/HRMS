using System.ComponentModel.DataAnnotations;
using HRMS.Data;

namespace HRMS.Models;

public class Level
{
    public int Id { get; set; }
    [Required(ErrorMessage = "职位名称为必填项")]
    [StringLength(50)]
    public string? LevelName { get; set; }

    //被发现
    public ICollection<ApplicationUser> ApplicationUsers { get; } = [];
    public ICollection<Recruitment> Recruitments { get; } = [];
}