using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DataAccess.Models;

namespace DataAccess.Schemas.Public;

[Table("companies")]
public class Company : Entity
{
    [MaxLength(200)]
    [Column("name", TypeName = "varchar(200)")]
    public string Name { get; set; }
        
    [Column("description", TypeName = "text")]
    public string Description { get; set; }
        
    [MaxLength(200)]
    [Column("website", TypeName = "varchar(200)")]
    public string Website { get; set; }
        
    [MaxLength(100)]
    [Column("industry", TypeName = "varchar(100)")]
    public string Industry { get; set; }
        
    [MaxLength(100)]
    [Column("size", TypeName = "varchar(100)")]
    public string? Size { get; set; } // e.g., "1-10", "11-50", "51-200", etc.
        
    [MaxLength(200)]
    [Column("location", TypeName = "varchar(200)")]
    public string Location { get; set; }
        
    [MaxLength(200)]
    [Column("contact_email", TypeName = "varchar(200)")]
    public string ContactEmail { get; set; }
        
    [MaxLength(20)]
    [Column("contact_phone", TypeName = "varchar(20)")]
    public string? ContactPhone { get; set; }

    // Navigation properties
    public virtual ICollection<JobVacancy> JobVacancies { get; set; } = new List<JobVacancy>();
    public virtual ICollection<Project> Projects { get; set; } = new List<Project>();
}
