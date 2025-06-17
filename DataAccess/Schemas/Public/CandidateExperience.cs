using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DataAccess.Models;

namespace DataAccess.Schemas.Public;

[Table("candidate_experiences")]
public class CandidateExperience : Entity
{
    [Required]
    [Column("candidate_id")]
    public Guid CandidateId { get; set; }
        
    [Required]
    [MaxLength(200)]
    [Column("company_name", TypeName = "varchar(200)")]
    public string CompanyName { get; set; }
        
    [Required]
    [MaxLength(100)]
    [Column("job_title", TypeName = "varchar(100)")]
    public string JobTitle { get; set; }
        
    [Column("description", TypeName = "text")]
    public string? Description { get; set; }
        
    [MaxLength(100)]
    [Column("location", TypeName = "varchar(100)")]
    public string? Location { get; set; }
        
    [Required]
    [Column("start_date", TypeName = "date")]
    public DateTime StartDate { get; set; }
        
    [Column("end_date", TypeName = "date")]
    public DateTime? EndDate { get; set; }
        
    [Column("is_current_job")]
    public bool IsCurrentJob { get; set; } = false;

    // Navigation properties
    public virtual Candidate Candidate { get; set; }
}
