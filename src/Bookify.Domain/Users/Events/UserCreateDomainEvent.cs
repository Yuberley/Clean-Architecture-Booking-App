using Bookify.Domain.Abstractions;

namespace Bookify.Domain.Users.Events;

public sealed record UserCreateDomainEvent(Guid UserId) : IDomainEvent;