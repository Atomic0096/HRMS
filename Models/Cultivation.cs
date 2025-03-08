using System.ComponentModel.DataAnnotations;
using HRMS.Data;

namespace HRMS.Models;

public class Cultivation
{
    public int Id { get; set; }
    public DateOnly StartDate { get; set; }
    public DateOnly EndDate { get; set; }
    public string? IsAccepted { get; set; }
    public string? Content { get; set; }

    //外键
    public string? ApplicationUserId { get; set; }//员工
    public ApplicationUser? ApplicationUser { get; set; }
}