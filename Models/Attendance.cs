using System.ComponentModel.DataAnnotations;

namespace HRMS.Models;

public class Attendance
{
    public int Id { get; set; }
    public DateOnly DateOfAttendance { get; set; }
    [RegularExpression(@"^(出勤|缺席|迟到)$")]
    public string? Status { get; set; }

    //外键
    [Range(1,int.MaxValue)]
    public int? EmployeeId { get; set; }//员工
    public Employee? Employee { get; set; }
}