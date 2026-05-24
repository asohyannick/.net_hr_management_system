using hr_ms.Core.ContributorAggregate;
using Vogen;

namespace hr_ms.Infrastructure.Data.Config;

[EfCoreConverter<ContributorId>]
[EfCoreConverter<ContributorName>]
internal partial class VogenEfCoreConverters;
