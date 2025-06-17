using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DataAccess.Enums;
using DataAccess.Models;

namespace DataAccess.Schemas.Public;

    [Table("job_vacancies")]
    public class JobVacancy : Entity
    {
        [MaxLength(200)]
        [Column("title", TypeName = "varchar(200)")]
        public string? Title { get; set; }
        
        [Required]
        [Column("description", TypeName = "text")]
        public string? Description { get; set; }
        
        [Column("requirements", TypeName = "text")]
        public string? Requirements { get; set; }
        
        [MaxLength(100)]
        [Column("location", TypeName = "varchar(100)")]
        public string? Location { get; set; }
        
        [Column("salary_min", TypeName = "decimal(10,2)")]
        public decimal? SalaryMin { get; set; }
        
        [Column("salary_max", TypeName = "decimal(10,2)")]
        public decimal? SalaryMax { get; set; }
        
        [Column("salary_currency")]
        public SupportedCurrency SalaryCurrency { get; set; }
        
        [Column("employment_type")]
        public EmploymentType EmploymentType { get; set; }
        
        [MaxLength(50)]
        [Column("experience_level", TypeName = "varchar(50)")]
        public string? ExperienceLevel { get; set; }
        
        [MaxLength(50)]
        [Column("status")]
        public JobVacancyStatus Status { get; set; }
        
        [Column("deadline", TypeName = "timestamp with time zone")]
        public DateTime? Deadline { get; set; }
        
        [Column("target_hires")]
        public short? TargetHires { get; set; } = 1;

        // Foreign key
        [Required]
        [Column("company_id")]
        public Guid CompanyId { get; set; }
        
        // Navigation properties
        [ForeignKey(nameof(CompanyId))]
        public virtual Company? Company { get; set; }
        public virtual ICollection<CandidateVacancy> CandidateVacancies { get; set; } = new List<CandidateVacancy>();
        public virtual ICollection<VacancySkill> VacancySkills { get; set; } = new List<VacancySkill>();
    }
