using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DataAccess.Models;

namespace DataAccess.Schemas.Public;

[Table("project_vacancies")]
public class ProjectVacancy : Entity
{
    [Required]
    [Column("project_id")]
    public Guid ProjectId { get; set; }
        
    [Required]
    [Column("vacancy_id")]
    public Guid VacancyId { get; set; }
        
    [Column("priority")]
    public int? Priority { get; set; } // 1-5 priority level

    // Navigation properties
    public virtual Project Project { get; set; }
    public virtual JobVacancy Vacancy { get; set; }
}
