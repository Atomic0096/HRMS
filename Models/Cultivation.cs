using System.ComponentModel.DataAnnotations;

namespace HRMS.Models;

public class Cultivation
{
    public int Id { get; set; }
    public DateOnly StartDate { get; set; }
    public DateOnly EndDate { get; set; }
    public string? Content { get; set; }

    //外键
    [Range(1,int.MaxValue)]
    public int? EmployeeId { get; set; }//员工
    public Employee? Employee { get; set; }
}