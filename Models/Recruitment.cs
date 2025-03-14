using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HRMS.Data;

namespace HRMS.Models;

public class Recruitment
{
    public int Id { get; set; }
    public string? Description { get; set; }
    [Range(0,int.MaxValue)]
    [DataType(DataType.Currency)]
    [Column(TypeName = "decimal(18,2)")]
    public decimal BottomSalary { get; set; }
    [Range(0,int.MaxValue)]
    [DataType(DataType.Currency)]
    [Column(TypeName = "decimal(18,2)")]
    public decimal TopSalary { get; set; }

    //外键
    [Range(1,int.MaxValue)]
    public int? DepartmentId { get; set; }//部门
    public Department? Department { get; set; }

    [Range(1,int.MaxValue)]
    public int? LevelId { get; set; }//职位
    public Level? Level { get; set; }

    public string? ApplicationUserId { get; set; }//员工
    public ApplicationUser? ApplicationUser { get; set; }
}