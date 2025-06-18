using DataAccess.Schemas.Auth;
using DataAccess.Schemas.Public;
using Microsoft.EntityFrameworkCore;

namespace DataAccess;

public partial class EntityContext
{
    public virtual DbSet<User> Users { get; set; }
    public virtual DbSet<Session> Sessions { get; set; }
    public virtual DbSet<ItemFile> ItemFiles { get; set; }


    public virtual DbSet<Company> Companies { get; set; }
    public virtual DbSet<JobVacancy> JobVacancies { get; set; }
    public virtual DbSet<Candidate> Candidates { get; set; }
    public virtual DbSet<CandidateVacancy> CandidateVacancies { get; set; }
    public virtual DbSet<Skill> Skills { get; set; }
    public virtual DbSet<CandidateSkill> CandidateSkills { get; set; }
    public virtual DbSet<VacancySkill> VacancySkills { get; set; }
    public virtual DbSet<CandidateExperience> CandidateExperiences { get; set; }
    public virtual DbSet<CandidateEducation> CandidateEducation { get; set; }
    public virtual DbSet<Project> Projects { get; set; }
    public virtual DbSet<ProjectVacancy> ProjectVacancies { get; set; }
    public virtual DbSet<Interview> Interviews { get; set; }
}