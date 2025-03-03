using System.ComponentModel.DataAnnotations;

namespace HRMS.Models;

public class Leave
{
    public int Id { get; set; }
    public DateOnly StartDate { get; set; }
    public DateOnly EndDate { get; set; }
    public bool IsApproved { get; set; }

    //外键
    [Range(1,int.MaxValue)]
    public int? EmployeeId { get; set; }//员工
    public Employee? Employee { get; set; }
}