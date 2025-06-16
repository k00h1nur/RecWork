namespace Domain.Models.Infrastructure.Params;

public record GenerateTokenParams(
    Guid Id,
    string FirstName,
    string? LastName,
    string? Phone,
    string Role,
    string? Email);