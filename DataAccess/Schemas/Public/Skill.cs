using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DataAccess.Models;

namespace DataAccess.Schemas.Public;

[Table("skills")]
public class Skill : Entity
{
    [MaxLength(100)]
    [Column("name", TypeName = "varchar(100)")]
    public string Name { get; set; } = null!;
        
    [MaxLength(50)]
    [Column("category", TypeName = "varchar(50)")]
    public string? Category { get; set; } // Programming, Framework, Tool, Soft Skill, etc.
        
    [MaxLength(500)]
    [Column("description", TypeName = "varchar(500)")]
    public string Description { get; set; }

    public virtual ICollection<CandidateSkill> CandidateSkills { get; set; } = new List<CandidateSkill>();
    public virtual ICollection<VacancySkill> VacancySkills { get; set; } = new List<VacancySkill>();
}
