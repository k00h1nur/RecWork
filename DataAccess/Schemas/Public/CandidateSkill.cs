using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DataAccess.Models;

namespace DataAccess.Schemas.Public;

[Table("candidate_skills")]
public class CandidateSkill : Entity
{
    [Required]
    [Column("candidate_id")]
    public Guid CandidateId { get; set; }
        
    [Required]
    [Column("skill_id")]
    public Guid SkillId { get; set; }
        
    [Range(1, 10)]
    [Column("proficiency_level")]
    public int ProficiencyLevel { get; set; } // 1-10 scale
        
    [Column("years_of_experience")]
    public short? YearsOfExperience { get; set; }
        
    [Column("is_certified")]
    public bool IsCertified { get; set; } = false;

    // Navigation properties
    public virtual Candidate Candidate { get; set; }
    public virtual Skill Skill { get; set; }
}
