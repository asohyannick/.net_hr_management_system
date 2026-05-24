using hr_ms.Core.ContributorAggregate;

namespace hr_ms.UseCases.Contributors.Update;

public record UpdateContributorCommand(ContributorId ContributorId, ContributorName NewName) : ICommand<Result<ContributorDto>>;
