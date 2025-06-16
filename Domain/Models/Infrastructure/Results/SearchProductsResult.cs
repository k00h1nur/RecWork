using Domain.Models.Infrastructure.InnerModels;

namespace Domain.Models.Infrastructure.Results;

public record SearchProductsResult(IEnumerable<ProductInnerModel> Items);