namespace Domain.Models.API.Requests;

public record CreateChatRequest(
    Guid AiModelId,
    string Name);