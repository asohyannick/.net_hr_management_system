using hr_ms.Core.ContributorAggregate;

namespace hr_ms.UseCases.Contributors.Get;

public record GetContributorQuery(ContributorId ContributorId) : IQuery<Result<ContributorDto>>;
