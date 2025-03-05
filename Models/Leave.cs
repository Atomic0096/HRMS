using System.ComponentModel.DataAnnotations;
using HRMS.Data;

namespace HRMS.Models;

public class Leave
{
    public int Id { get; set; }
    public DateOnly StartDate { get; set; }
    public DateOnly EndDate { get; set; }
    public bool IsApproved { get; set; }

    //外键
    [Range(1,int.MaxValue)]
    public int? UserId { get; set; }//员工
    public ApplicationUser? ApplicationUser { get; set; }
}