namespace Domain.Models.API.Requests;

public record SignInRequest(
    Guid SessionId,
    string Code);