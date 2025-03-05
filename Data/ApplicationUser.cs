using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HRMS.Models;
using Microsoft.AspNetCore.Identity;

namespace HRMS.Data;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
    [Required]
    [MaxLength(100)]
    public string Name { get; set; } = string.Empty;

    [Required]
    [RegularExpression(@"^(男|女)$")]
    public string Gender { get; set; } = string.Empty;

    public DateOnly DateOfBirth { get; set; }

    [Range(0,int.MaxValue)]
    [DataType(DataType.Currency)]
    [Column(TypeName = "decimal(18,2)")]
    public decimal Salary { get; set; }

    public DateOnly DateOfEntry { get; set; }

    //外键
    [Range(1,int.MaxValue)]
    public int? DepartmentId { get; set; }//部门
    public Department? Department { get; set; }

    [Range(1,int.MaxValue)]
    public int? LevelId { get; set; }//职位
    public Level? Level { get; set; }

    //被发现
    public ICollection<Cultivation> Cultivations { get; } = [];
    public ICollection<Leave> Leaves { get; } = [];
}