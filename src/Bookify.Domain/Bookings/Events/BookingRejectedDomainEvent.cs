using Bookify.Domain.Abstractions;

namespace Bookify.Domain.Bookings;

public sealed record BookingRejectedDomainEvent(Guid BookingId) : IDomainEvent;