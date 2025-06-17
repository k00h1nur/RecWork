using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DataAccess.Enums;
using DataAccess.Models;

namespace DataAccess.Schemas.Public;

    [Table("candidates")]
    public class Candidate : Entity
    {
        [MaxLength(100)]
        [Column("first_name", TypeName = "varchar(100)")]
        public string FirstName { get; set; } = null!;
        
        [MaxLength(100)]
        [Column("last_name", TypeName = "varchar(100)")]
        public string? LastName { get; set; }
        
        [Required]
        [MaxLength(200)]
        [Column("email", TypeName = "varchar(200)")]
        public string? Email { get; set; }
        
        [MaxLength(20)]
        [Column("phone", TypeName = "varchar(20)")]
        public string? Phone { get; set; }
        
        [MaxLength(200)]
        [Column("location", TypeName = "varchar(200)")]
        public string? Location { get; set; }
        
        [Column("summary", TypeName = "text")]
        public string? Summary { get; set; }
        
        [MaxLength(200)]
        [Column("linkedin_url", TypeName = "varchar(200)")]
        public string? LinkedInUrl { get; set; }
        
        [MaxLength(200)]
        [Column("github_url", TypeName = "varchar(200)")]
        public string? GitHubUrl { get; set; }
        
        [MaxLength(200)]
        [Column("portfolio_url", TypeName = "varchar(200)")]
        public string? PortfolioUrl { get; set; }
        
        [MaxLength(200)]
        [Column("resume_url", TypeName = "varchar(200)")]
        public string? ResumeUrl { get; set; }
        
        [MaxLength(50)]
        [Column("current_title", TypeName = "varchar(50)")]
        public string CurrentTitle { get; set; }
        
        [MaxLength(100)]
        [Column("current_company", TypeName = "varchar(100)")]
        public string CurrentCompany { get; set; }
        
        [Column("years_of_experience")]
        public int? YearsOfExperience { get; set; }
        
        [Column("expected_salary")]
        public decimal? ExpectedSalary { get; set; }
        
        [MaxLength(50)]
        [Column("salary_currency")]
        public SupportedCurrency SalaryCurrency { get; set; }
        
        [MaxLength(50)]
        [Column("status", TypeName = "varchar(50)")]
        public string Status { get; set; } = "Active"; // Active, Inactive, Placed
        
        [Column("last_contact_date", TypeName = "timestamp with time zone")]
        public DateTime? LastContactDate { get; set; }

        [NotMapped]
        public string FullName => $"{FirstName} {LastName}";

        public virtual ICollection<CandidateVacancy> CandidateVacancies { get; set; } = new List<CandidateVacancy>();
        public virtual ICollection<CandidateSkill> CandidateSkills { get; set; } = new List<CandidateSkill>();
        public virtual ICollection<CandidateExperience> Experiences { get; set; } = new List<CandidateExperience>();
        public virtual ICollection<CandidateEducation> Education { get; set; } = new List<CandidateEducation>();
    }
