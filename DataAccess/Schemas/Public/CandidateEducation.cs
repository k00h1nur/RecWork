using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DataAccess.Models;

namespace DataAccess.Schemas.Public;

[Table("candidate_education")]
public class CandidateEducation : Entity
{
    [Required]
    [Column("candidate_id")]
    public Guid CandidateId { get; set; }
        
    [Required]
    [MaxLength(200)]
    [Column("institution", TypeName = "varchar(200)")]
    public string? Institution { get; set; }
        
    [Required]
    [MaxLength(100)]
    [Column("degree", TypeName = "varchar(100)")]
    public string? Degree { get; set; }
        
    [MaxLength(100)]
    [Column("field_of_study", TypeName = "varchar(100)")]
    public string? FieldOfStudy { get; set; }
        
    [MaxLength(10)]
    [Column("grade", TypeName = "varchar(10)")]
    public string? Grade { get; set; }
        
    [Required]
    [Column("start_date", TypeName = "date")]
    public DateTime StartDate { get; set; }
        
    [Column("end_date", TypeName = "date")]
    public DateTime? EndDate { get; set; }
        
    [Column("is_current_education")]
    public bool IsCurrentEducation { get; set; } = false;

    // Navigation properties
    public virtual Candidate Candidate { get; set; }
}
