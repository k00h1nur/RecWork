using DataAccess.Enums;
using DataAccess.Models;
using DataAccess.Schemas.Public;
using Microsoft.EntityFrameworkCore;

namespace DataAccess;

public partial class EntityContext(
    DbContextOptions<EntityContext> options) : DbContext(options)
{
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure PostgreSQL-specific settings
            modelBuilder.HasPostgresExtension("uuid-ossp");

            // Configure indexes for better performance
            modelBuilder.Entity<Candidate>()
                .HasIndex(c => c.Email)
                .IsUnique()
                .HasDatabaseName("idx_candidates_email_unique");

            modelBuilder.Entity<Company>()
                .HasIndex(c => c.Name)
                .HasDatabaseName("idx_companies_name");

            modelBuilder.Entity<JobVacancy>()
                .HasIndex(v => v.Status)
                .HasDatabaseName("idx_job_vacancies_status");

            modelBuilder.Entity<JobVacancy>()
                .HasIndex(v => v.CompanyId)
                .HasDatabaseName("idx_job_vacancies_company_id");

            modelBuilder.Entity<CandidateVacancy>()
                .HasIndex(cv => cv.Status)
                .HasDatabaseName("idx_candidate_vacancies_status");

            modelBuilder.Entity<CandidateVacancy>()
                .HasIndex(cv => new { cv.CandidateId, cv.VacancyId })
                .IsUnique()
                .HasDatabaseName("idx_candidate_vacancies_candidate_vacancy_unique");

            modelBuilder.Entity<Skill>()
                .HasIndex(s => s.Name)
                .IsUnique()
                .HasDatabaseName("idx_skills_name_unique");

            // Configure composite indexes for junction tables
            modelBuilder.Entity<CandidateSkill>()
                .HasIndex(cs => new { cs.CandidateId, cs.SkillId })
                .IsUnique()
                .HasDatabaseName("idx_candidate_skills_candidate_skill_unique");

            modelBuilder.Entity<VacancySkill>()
                .HasIndex(vs => new { vs.VacancyId, vs.SkillId })
                .IsUnique()
                .HasDatabaseName("idx_vacancy_skills_vacancy_skill_unique");

            modelBuilder.Entity<ProjectVacancy>()
                .HasIndex(pv => new { pv.ProjectId, pv.VacancyId })
                .IsUnique()
                .HasDatabaseName("idx_project_vacancies_project_vacancy_unique");

            // Additional performance indexes
            modelBuilder.Entity<CandidateExperience>()
                .HasIndex(ce => ce.CandidateId)
                .HasDatabaseName("idx_candidate_experiences_candidate_id");

            modelBuilder.Entity<CandidateEducation>()
                .HasIndex(ce => ce.CandidateId)
                .HasDatabaseName("idx_candidate_education_candidate_id");

            modelBuilder.Entity<Interview>()
                .HasIndex(i => i.CandidateVacancyId)
                .HasDatabaseName("idx_interviews_candidate_vacancy_id");

            modelBuilder.Entity<Interview>()
                .HasIndex(i => i.ScheduledDate)
                .HasDatabaseName("idx_interviews_scheduled_date");

            // Configure foreign key relationships with proper naming
            modelBuilder.Entity<JobVacancy>()
                .HasOne(jv => jv.Company)
                .WithMany(c => c.JobVacancies)
                .HasForeignKey(jv => jv.CompanyId)
                .HasConstraintName("fk_job_vacancies_company_id")
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<CandidateVacancy>()
                .HasOne(cv => cv.Candidate)
                .WithMany(c => c.CandidateVacancies)
                .HasForeignKey(cv => cv.CandidateId)
                .HasConstraintName("fk_candidate_vacancies_candidate_id")
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<CandidateVacancy>()
                .HasOne(cv => cv.Vacancy)
                .WithMany(v => v.CandidateVacancies)
                .HasForeignKey(cv => cv.VacancyId)
                .HasConstraintName("fk_candidate_vacancies_vacancy_id")
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<CandidateSkill>()
                .HasOne(cs => cs.Candidate)
                .WithMany(c => c.CandidateSkills)
                .HasForeignKey(cs => cs.CandidateId)
                .HasConstraintName("fk_candidate_skills_candidate_id")
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<CandidateSkill>()
                .HasOne(cs => cs.Skill)
                .WithMany(s => s.CandidateSkills)
                .HasForeignKey(cs => cs.SkillId)
                .HasConstraintName("fk_candidate_skills_skill_id")
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<VacancySkill>()
                .HasOne(vs => vs.Vacancy)
                .WithMany(v => v.VacancySkills)
                .HasForeignKey(vs => vs.VacancyId)
                .HasConstraintName("fk_vacancy_skills_vacancy_id")
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<VacancySkill>()
                .HasOne(vs => vs.Skill)
                .WithMany(s => s.VacancySkills)
                .HasForeignKey(vs => vs.SkillId)
                .HasConstraintName("fk_vacancy_skills_skill_id")
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<CandidateExperience>()
                .HasOne(ce => ce.Candidate)
                .WithMany(c => c.Experiences)
                .HasForeignKey(ce => ce.CandidateId)
                .HasConstraintName("fk_candidate_experiences_candidate_id")
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<CandidateEducation>()
                .HasOne(ce => ce.Candidate)
                .WithMany(c => c.Education)
                .HasForeignKey(ce => ce.CandidateId)
                .HasConstraintName("fk_candidate_education_candidate_id")
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Project>()
                .HasOne(p => p.Company)
                .WithMany(c => c.Projects)
                .HasForeignKey(p => p.CompanyId)
                .HasConstraintName("fk_projects_company_id")
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ProjectVacancy>()
                .HasOne(pv => pv.Project)
                .WithMany(p => p.ProjectVacancies)
                .HasForeignKey(pv => pv.ProjectId)
                .HasConstraintName("fk_project_vacancies_project_id")
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ProjectVacancy>()
                .HasOne(pv => pv.Vacancy)
                .WithMany()
                .HasForeignKey(pv => pv.VacancyId)
                .HasConstraintName("fk_project_vacancies_vacancy_id")
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Interview>()
                .HasOne(i => i.CandidateVacancy)
                .WithMany(cv => cv.Interviews)
                .HasForeignKey(i => i.CandidateVacancyId)
                .HasConstraintName("fk_interviews_candidate_vacancy_id")
                .OnDelete(DeleteBehavior.Cascade);

            // Configure check constraints for PostgreSQL
            modelBuilder.Entity<CandidateSkill>()
                .HasCheckConstraint("ck_candidate_skills_proficiency_level", "proficiency_level >= 1 AND proficiency_level <= 10");

            modelBuilder.Entity<VacancySkill>()
                .HasCheckConstraint("ck_vacancy_skills_min_proficiency_level", "min_proficiency_level >= 1 AND min_proficiency_level <= 10");

            modelBuilder.Entity<Interview>()
                .HasCheckConstraint("ck_interviews_rating", "rating >= 1 AND rating <= 10");

            modelBuilder.Entity<CandidateVacancy>()
                .HasCheckConstraint("ck_candidate_vacancies_score", "score >= 1 AND score <= 100");

            modelBuilder.Entity<ProjectVacancy>()
                .HasCheckConstraint("ck_project_vacancies_priority", "priority >= 1 AND priority <= 5");

            // Add soft delete filter
            modelBuilder.Entity<Company>().HasQueryFilter(c => c.State != EntityStatus.Deleted);
            modelBuilder.Entity<JobVacancy>().HasQueryFilter(c => c.State != EntityStatus.Deleted);
            modelBuilder.Entity<Candidate>().HasQueryFilter(c => c.State != EntityStatus.Deleted);
            modelBuilder.Entity<Project>().HasQueryFilter(c => c.State != EntityStatus.Deleted);
            modelBuilder.Entity<Skill>().HasQueryFilter(c => c.State != EntityStatus.Deleted);

            // Configure PostgreSQL-specific column defaults
            modelBuilder.Entity<Company>()
                .Property(c => c.CreatedDate)
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            modelBuilder.Entity<JobVacancy>()
                .Property(jv => jv.CreatedDate)
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            modelBuilder.Entity<Candidate>()
                .Property(c => c.CreatedDate)
                .HasDefaultValueSql("CURRENT_TIMESTAMP");
        }

        public override int SaveChanges()
        {
            UpdateTimestamps();
            return base.SaveChanges();
        }

        public async override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            UpdateTimestamps();
            return await base.SaveChangesAsync(cancellationToken);
        }

        private void UpdateTimestamps()
        {
            var entries = ChangeTracker.Entries<Entity>();
            
            foreach (var entry in entries)
            {
                if (entry.State == EntityState.Modified)
                {
                    entry.Entity.UpdatedDate = DateTime.UtcNow;
                }
            }
        }

}