using hr_ms.Core.ContributorAggregate;

namespace hr_ms.UseCases.Contributors.Delete;

public record DeleteContributorCommand(ContributorId ContributorId) : ICommand<Result>;
