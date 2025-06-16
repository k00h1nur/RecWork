using Domain.Enums;

namespace Domain.Models.Infrastructure.InnerModels;

public record ProductInnerModel(
    string Photo,
    string Name,
    string Description,
    string Price,
    string Link,
    string Id,
    StoreType StoreType = StoreType.Uzum);