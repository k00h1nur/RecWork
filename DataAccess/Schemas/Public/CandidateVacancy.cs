using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DataAccess.Enums;
using DataAccess.Models;

namespace DataAccess.Schemas.Public;

[Table("candidate_vacancies")]
public class CandidateVacancy : Entity
{
    [Required]
    [Column("candidate_id")]
    public Guid CandidateId { get; set; }
        
    [Required]
    [Column("vacancy_id")]
    public Guid VacancyId { get; set; }
        
    [MaxLength(50)]
    [Column("status")]
    public CandidateVacancyStatus Status { get; set; }
        
    [Column("applied_date", TypeName = "timestamp with time zone")]
    public DateTime AppliedDate { get; set; } = DateTime.UtcNow;
        
    [Column("notes", TypeName = "text")]
    public string? Notes { get; set; }
        
    [Column("score")]
    public int? Score { get; set; }
        
    [Column("last_interaction_date", TypeName = "timestamp with time zone")]
    public DateTime? LastInteractionDate { get; set; }

    // Navigation properties
    public virtual Candidate? Candidate { get; set; }
    public virtual JobVacancy? Vacancy { get; set; }
    public virtual ICollection<Interview> Interviews { get; set; } = new List<Interview>();
}
