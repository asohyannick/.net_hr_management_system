using Minimalhr_ms.Web.Domain.CartAggregate;
using Minimalhr_ms.Web.Domain.GuestUserAggregate;
using Minimalhr_ms.Web.Domain.OrderAggregate;
using Minimalhr_ms.Web.Domain.ProductAggregate;
using Vogen;

namespace Minimalhr_ms.Web.Infrastructure.Data.Config;

[EfCoreConverter<ProductId>]
[EfCoreConverter<CartId>]
[EfCoreConverter<CartItemId>]
[EfCoreConverter<GuestUserId>]
[EfCoreConverter<OrderId>]
[EfCoreConverter<OrderItemId>]
[EfCoreConverter<Quantity>]
[EfCoreConverter<Price>]
internal partial class VogenEfCoreConverters;
