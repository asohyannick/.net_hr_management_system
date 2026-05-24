using Minimalhr_ms.Web.Domain.ProductAggregate;

namespace Minimalhr_ms.Web.ProductFeatures;
public record ProductDto(ProductId Id, string Name, decimal UnitPrice);
