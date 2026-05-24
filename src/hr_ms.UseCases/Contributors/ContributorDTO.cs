using hr_ms.Core.ContributorAggregate;

namespace hr_ms.UseCases.Contributors;
public record ContributorDto(ContributorId Id, ContributorName Name, PhoneNumber PhoneNumber);
