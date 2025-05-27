using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HRMS.Data;

namespace HRMS.Models;

public class Reimbursement
{
    public int Id { get; set; }
    public DateOnly Date { get; set; }
    public string? Type { get; set; }
    [Range(0,int.MaxValue)]
    [DataType(DataType.Currency)]
    [Column(TypeName = "decimal(18,2)")]
    public decimal Amount { get; set; }
    public string? IsApproved { get; set; }

    //外键
    public string? ApplicationUserId { get; set; }//员工
    public ApplicationUser? ApplicationUser { get; set; }
}