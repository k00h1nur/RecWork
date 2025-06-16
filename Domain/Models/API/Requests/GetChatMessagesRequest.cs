using Domain.Models.Common;

namespace Domain.Models.API.Requests;

public record GetChatMessagesRequest(Guid ChatId) : PagedRequest;