using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRMS.Models;

public class Employee
{
    public int Id { get; set; }
    [Required]
    [StringLength(50)]
    public string? Name { get; set; }
    [Required]
    [RegularExpression(@"^(男|女)$")]
    public string? Gender { get; set; }
    public DateOnly DateOfBirth { get; set; }
    [Range(0,int.MaxValue)]
    [DataType(DataType.Currency)]
    [Column(TypeName = "decimal(18,2)")]
    public decimal Salary { get; set; }
    public DateOnly DateOfEntry { get; set; }
    public int AnnualLeave { get; set; }

    //外键
    [Range(1,int.MaxValue)]
    public int? DepartmentId { get; set; }//部门
    public Department? Department { get; set; }

    [Range(1,int.MaxValue)]
    public int? LevelId { get; set; }//职位
    public Level? Level { get; set; }

    //被发现
    public ICollection<Cultivation> Cultivations { get; } = [];
    public ICollection<Attendance> Attendances { get; } = [];
}