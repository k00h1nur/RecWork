using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "auth");

            migrationBuilder.AlterDatabase()
                .Annotation("Npgsql:PostgresExtension:uuid-ossp", ",,");

            migrationBuilder.CreateTable(
                name: "candidates",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    first_name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    last_name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    email = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    phone = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    location = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true),
                    summary = table.Column<string>(type: "text", nullable: true),
                    linkedin_url = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true),
                    github_url = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true),
                    portfolio_url = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true),
                    resume_url = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true),
                    current_title = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    current_company = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    years_of_experience = table.Column<int>(type: "integer", nullable: true),
                    expected_salary = table.Column<decimal>(type: "numeric", nullable: true),
                    salary_currency = table.Column<int>(type: "integer", maxLength: 50, nullable: false),
                    status = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    last_contact_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    created_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    updated_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    state = table.Column<byte>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_candidates", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "companies",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    website = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    industry = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    size = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    location = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    contact_email = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    contact_phone = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    created_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    updated_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    state = table.Column<byte>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_companies", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "item_files",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    item_id = table.Column<Guid>(type: "uuid", nullable: false),
                    location = table.Column<string>(type: "text", nullable: false),
                    extension = table.Column<string>(type: "text", nullable: false),
                    type = table.Column<int>(type: "integer", nullable: false),
                    original_name = table.Column<string>(type: "text", nullable: false),
                    size = table.Column<long>(type: "bigint", nullable: false),
                    created_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    state = table.Column<byte>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_item_files", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "skills",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    description = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false),
                    created_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    state = table.Column<byte>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_skills", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                schema: "auth",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    first_name = table.Column<string>(type: "text", nullable: false),
                    last_name = table.Column<string>(type: "text", nullable: true),
                    email = table.Column<string>(type: "text", nullable: true),
                    password = table.Column<string>(type: "text", nullable: true),
                    phone = table.Column<string>(type: "text", nullable: true),
                    created_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    state = table.Column<byte>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "candidate_education",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    candidate_id = table.Column<Guid>(type: "uuid", nullable: false),
                    institution = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    degree = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    field_of_study = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    grade = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true),
                    start_date = table.Column<DateTime>(type: "date", nullable: false),
                    end_date = table.Column<DateTime>(type: "date", nullable: true),
                    is_current_education = table.Column<bool>(type: "boolean", nullable: false),
                    created_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    state = table.Column<byte>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_candidate_education", x => x.id);
                    table.ForeignKey(
                        name: "fk_candidate_education_candidate_id",
                        column: x => x.candidate_id,
                        principalTable: "candidates",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "candidate_experiences",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    candidate_id = table.Column<Guid>(type: "uuid", nullable: false),
                    company_name = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    job_title = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    description = table.Column<string>(type: "text", nullable: true),
                    location = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    start_date = table.Column<DateTime>(type: "date", nullable: false),
                    end_date = table.Column<DateTime>(type: "date", nullable: true),
                    is_current_job = table.Column<bool>(type: "boolean", nullable: false),
                    created_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    state = table.Column<byte>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_candidate_experiences", x => x.id);
                    table.ForeignKey(
                        name: "fk_candidate_experiences_candidate_id",
                        column: x => x.candidate_id,
                        principalTable: "candidates",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "job_vacancies",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    title = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true),
                    description = table.Column<string>(type: "text", nullable: false),
                    requirements = table.Column<string>(type: "text", nullable: true),
                    location = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    salary_min = table.Column<decimal>(type: "numeric(10,2)", nullable: true),
                    salary_max = table.Column<decimal>(type: "numeric(10,2)", nullable: true),
                    salary_currency = table.Column<int>(type: "integer", nullable: false),
                    employment_type = table.Column<int>(type: "integer", nullable: false),
                    experience_level = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    status = table.Column<int>(type: "integer", maxLength: 50, nullable: false),
                    deadline = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    target_hires = table.Column<short>(type: "smallint", nullable: true),
                    company_id = table.Column<Guid>(type: "uuid", nullable: false),
                    created_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    updated_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    state = table.Column<byte>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_job_vacancies", x => x.id);
                    table.ForeignKey(
                        name: "fk_job_vacancies_company_id",
                        column: x => x.company_id,
                        principalTable: "companies",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "projects",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    description = table.Column<string>(type: "text", nullable: true),
                    status = table.Column<int>(type: "integer", maxLength: 50, nullable: false),
                    start_date = table.Column<DateTime>(type: "date", nullable: false),
                    end_date = table.Column<DateTime>(type: "date", nullable: true),
                    budget = table.Column<decimal>(type: "numeric(12,2)", nullable: true),
                    currency = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    company_id = table.Column<Guid>(type: "uuid", nullable: false),
                    created_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    state = table.Column<byte>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_projects", x => x.id);
                    table.ForeignKey(
                        name: "fk_projects_company_id",
                        column: x => x.company_id,
                        principalTable: "companies",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "candidate_skills",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    candidate_id = table.Column<Guid>(type: "uuid", nullable: false),
                    skill_id = table.Column<Guid>(type: "uuid", nullable: false),
                    proficiency_level = table.Column<int>(type: "integer", nullable: false),
                    years_of_experience = table.Column<short>(type: "smallint", nullable: true),
                    is_certified = table.Column<bool>(type: "boolean", nullable: false),
                    created_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    state = table.Column<byte>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_candidate_skills", x => x.id);
                    table.CheckConstraint("ck_candidate_skills_proficiency_level", "proficiency_level >= 1 AND proficiency_level <= 10");
                    table.ForeignKey(
                        name: "fk_candidate_skills_candidate_id",
                        column: x => x.candidate_id,
                        principalTable: "candidates",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_candidate_skills_skill_id",
                        column: x => x.skill_id,
                        principalTable: "skills",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "sessions",
                schema: "auth",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    user_id = table.Column<Guid>(type: "uuid", nullable: false),
                    code = table.Column<string>(type: "text", nullable: false),
                    expire_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    created_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    state = table.Column<byte>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sessions", x => x.id);
                    table.ForeignKey(
                        name: "FK_sessions_users_user_id",
                        column: x => x.user_id,
                        principalSchema: "auth",
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "candidate_vacancies",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    candidate_id = table.Column<Guid>(type: "uuid", nullable: false),
                    vacancy_id = table.Column<Guid>(type: "uuid", nullable: false),
                    status = table.Column<int>(type: "integer", maxLength: 50, nullable: false),
                    applied_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    notes = table.Column<string>(type: "text", nullable: true),
                    score = table.Column<int>(type: "integer", nullable: true),
                    last_interaction_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    created_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    state = table.Column<byte>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_candidate_vacancies", x => x.id);
                    table.CheckConstraint("ck_candidate_vacancies_score", "score >= 1 AND score <= 100");
                    table.ForeignKey(
                        name: "fk_candidate_vacancies_candidate_id",
                        column: x => x.candidate_id,
                        principalTable: "candidates",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_candidate_vacancies_vacancy_id",
                        column: x => x.vacancy_id,
                        principalTable: "job_vacancies",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "vacancy_skills",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    vacancy_id = table.Column<Guid>(type: "uuid", nullable: false),
                    skill_id = table.Column<Guid>(type: "uuid", nullable: false),
                    requirement_level = table.Column<int>(type: "integer", maxLength: 50, nullable: false),
                    min_proficiency_level = table.Column<int>(type: "integer", nullable: true),
                    min_years_of_experience = table.Column<int>(type: "integer", nullable: true),
                    created_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    state = table.Column<byte>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vacancy_skills", x => x.id);
                    table.CheckConstraint("ck_vacancy_skills_min_proficiency_level", "min_proficiency_level >= 1 AND min_proficiency_level <= 10");
                    table.ForeignKey(
                        name: "fk_vacancy_skills_skill_id",
                        column: x => x.skill_id,
                        principalTable: "skills",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_vacancy_skills_vacancy_id",
                        column: x => x.vacancy_id,
                        principalTable: "job_vacancies",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "project_vacancies",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    project_id = table.Column<Guid>(type: "uuid", nullable: false),
                    vacancy_id = table.Column<Guid>(type: "uuid", nullable: false),
                    priority = table.Column<int>(type: "integer", nullable: true),
                    created_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    state = table.Column<byte>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_project_vacancies", x => x.id);
                    table.CheckConstraint("ck_project_vacancies_priority", "priority >= 1 AND priority <= 5");
                    table.ForeignKey(
                        name: "fk_project_vacancies_project_id",
                        column: x => x.project_id,
                        principalTable: "projects",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_project_vacancies_vacancy_id",
                        column: x => x.vacancy_id,
                        principalTable: "job_vacancies",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "interviews",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    candidate_vacancy_id = table.Column<Guid>(type: "uuid", nullable: false),
                    type = table.Column<byte>(type: "smallint", maxLength: 100, nullable: false),
                    scheduled_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    duration_minutes = table.Column<short>(type: "smallint", nullable: false),
                    interviewer_name = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true),
                    interviewer_email = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true),
                    interviewer_id = table.Column<Guid>(type: "uuid", nullable: true),
                    status = table.Column<int>(type: "integer", nullable: true),
                    notes = table.Column<string>(type: "text", nullable: true),
                    rating = table.Column<int>(type: "integer", nullable: true),
                    meeting_link = table.Column<string>(type: "text", nullable: true),
                    created_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    state = table.Column<byte>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_interviews", x => x.id);
                    table.CheckConstraint("ck_interviews_rating", "rating >= 1 AND rating <= 10");
                    table.ForeignKey(
                        name: "FK_interviews_users_interviewer_id",
                        column: x => x.interviewer_id,
                        principalSchema: "auth",
                        principalTable: "users",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_interviews_candidate_vacancy_id",
                        column: x => x.candidate_vacancy_id,
                        principalTable: "candidate_vacancies",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "idx_candidate_education_candidate_id",
                table: "candidate_education",
                column: "candidate_id");

            migrationBuilder.CreateIndex(
                name: "idx_candidate_experiences_candidate_id",
                table: "candidate_experiences",
                column: "candidate_id");

            migrationBuilder.CreateIndex(
                name: "idx_candidate_skills_candidate_skill_unique",
                table: "candidate_skills",
                columns: new[] { "candidate_id", "skill_id" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_candidate_skills_skill_id",
                table: "candidate_skills",
                column: "skill_id");

            migrationBuilder.CreateIndex(
                name: "idx_candidate_vacancies_candidate_vacancy_unique",
                table: "candidate_vacancies",
                columns: new[] { "candidate_id", "vacancy_id" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "idx_candidate_vacancies_status",
                table: "candidate_vacancies",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "IX_candidate_vacancies_vacancy_id",
                table: "candidate_vacancies",
                column: "vacancy_id");

            migrationBuilder.CreateIndex(
                name: "idx_candidates_email_unique",
                table: "candidates",
                column: "email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "idx_companies_name",
                table: "companies",
                column: "name");

            migrationBuilder.CreateIndex(
                name: "idx_interviews_candidate_vacancy_id",
                table: "interviews",
                column: "candidate_vacancy_id");

            migrationBuilder.CreateIndex(
                name: "idx_interviews_scheduled_date",
                table: "interviews",
                column: "scheduled_date");

            migrationBuilder.CreateIndex(
                name: "IX_interviews_interviewer_id",
                table: "interviews",
                column: "interviewer_id");

            migrationBuilder.CreateIndex(
                name: "idx_job_vacancies_company_id",
                table: "job_vacancies",
                column: "company_id");

            migrationBuilder.CreateIndex(
                name: "idx_job_vacancies_status",
                table: "job_vacancies",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "idx_project_vacancies_project_vacancy_unique",
                table: "project_vacancies",
                columns: new[] { "project_id", "vacancy_id" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_project_vacancies_vacancy_id",
                table: "project_vacancies",
                column: "vacancy_id");

            migrationBuilder.CreateIndex(
                name: "IX_projects_company_id",
                table: "projects",
                column: "company_id");

            migrationBuilder.CreateIndex(
                name: "IX_sessions_user_id",
                schema: "auth",
                table: "sessions",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "idx_skills_name_unique",
                table: "skills",
                column: "name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "idx_vacancy_skills_vacancy_skill_unique",
                table: "vacancy_skills",
                columns: new[] { "vacancy_id", "skill_id" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_vacancy_skills_skill_id",
                table: "vacancy_skills",
                column: "skill_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "candidate_education");

            migrationBuilder.DropTable(
                name: "candidate_experiences");

            migrationBuilder.DropTable(
                name: "candidate_skills");

            migrationBuilder.DropTable(
                name: "interviews");

            migrationBuilder.DropTable(
                name: "item_files");

            migrationBuilder.DropTable(
                name: "project_vacancies");

            migrationBuilder.DropTable(
                name: "sessions",
                schema: "auth");

            migrationBuilder.DropTable(
                name: "vacancy_skills");

            migrationBuilder.DropTable(
                name: "candidate_vacancies");

            migrationBuilder.DropTable(
                name: "projects");

            migrationBuilder.DropTable(
                name: "users",
                schema: "auth");

            migrationBuilder.DropTable(
                name: "skills");

            migrationBuilder.DropTable(
                name: "candidates");

            migrationBuilder.DropTable(
                name: "job_vacancies");

            migrationBuilder.DropTable(
                name: "companies");
        }
    }
}
