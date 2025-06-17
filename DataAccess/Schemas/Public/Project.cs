using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DataAccess.Enums;
using DataAccess.Models;

namespace DataAccess.Schemas.Public;

[Table("projects")]
public class Project : Entity
{
    [MaxLength(200)]
    [Column("name", TypeName = "varchar(200)")]
    public string Name { get; set; } = null!;
        
    [Column("description", TypeName = "text")]
    public string? Description { get; set; }
        
    [MaxLength(50)]
    [Column("status")]
    public ProjectStatus Status { get; set; }
        
    [Required]
    [Column("start_date", TypeName = "date")]
    public DateTime StartDate { get; set; }
        
    [Column("end_date", TypeName = "date")]
    public DateTime? EndDate { get; set; }
        
    [Column("budget", TypeName = "decimal(12,2)")]
    public decimal? Budget { get; set; }
        
    [MaxLength(50)]
    [Column("currency", TypeName = "varchar(50)")]
    public string Currency { get; set; } = "USD";

    // Foreign key
    [Required]
    [Column("company_id")]
    public Guid CompanyId { get; set; }

    // Navigation properties
    public virtual Company Company { get; set; }
    public virtual ICollection<ProjectVacancy> ProjectVacancies { get; set; } = new List<ProjectVacancy>();
}
