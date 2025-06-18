using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DataAccess.Enums;
using DataAccess.Models;

namespace DataAccess.Schemas.Public;

[Table("vacancy_skills")]
public class VacancySkill : Entity
{
    [Required]
    [Column("vacancy_id")]
    public Guid VacancyId { get; set; }
        
    [Required]
    [Column("skill_id")]
    public Guid SkillId { get; set; }
        
    [MaxLength(50)]
    [Column("requirement_level")]
    public RequirementLevel RequirementLevel { get; set; }
        
    [Range(1, 10)]
    [Column("min_proficiency_level")]
    public int? MinProficiencyLevel { get; set; }
        
    [Column("min_years_of_experience")]
    public int? MinYearsOfExperience { get; set; }

    // Navigation properties
    public virtual JobVacancy Vacancy { get; set; }
    public virtual Skill Skill { get; set; }
}
