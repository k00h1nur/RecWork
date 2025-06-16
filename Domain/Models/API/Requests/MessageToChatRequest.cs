using Microsoft.AspNetCore.Http;

namespace Domain.Models.API.Requests;

public record MessageToChatRequest(Guid ChatId, string Message, IFormFile? File, Guid ModelVersionId);