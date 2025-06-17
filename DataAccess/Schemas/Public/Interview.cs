using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DataAccess.Enums;
using DataAccess.Models;
using DataAccess.Schemas.Auth;

namespace DataAccess.Schemas.Public;

[Table("interviews")]
public class Interview : Entity
{
    [Required]
    [Column("candidate_vacancy_id")]
    public Guid CandidateVacancyId { get; set; }
        
    [Required]
    [MaxLength(100)]
    [Column("type")]
    public InterviewType Type { get; set; }
        
    [Required]
    [Column("scheduled_date", TypeName = "timestamp with time zone")]
    public DateTime ScheduledDate { get; set; }
        
    [Column("duration_minutes")]
    public short DurationMinutes { get; set; } = 60;
        
    [MaxLength(200)]
    [Column("interviewer_name", TypeName = "varchar(200)")]
    public string? InterviewerName { get; set; }
        
    [MaxLength(200)]
    [Column("interviewer_email", TypeName = "varchar(200)")]
    public string? InterviewerEmail { get; set; }

    [Column("interviewer_id")]
    public Guid? InterviewerId { get; set; }
        
    [Column("status")]
    public InterviewStatus? Status { get; set; }
        
    [Column("notes", TypeName = "text")]
    public string? Notes { get; set; }
        
    [Range(1, 10)]
    [Column("rating")]
    public int? Rating { get; set; }
        
    [Column("meeting_link", TypeName = "text")]
    public string? MeetingLink { get; set; }

    // Navigation properties
    public virtual CandidateVacancy? CandidateVacancy { get; set; }

    [ForeignKey(nameof(InterviewerId))]
    public virtual User? Interviewer { get; set; }
}
