using Bookify.Domain.Abstractions;
using Bookify.Domain.Users.Events;

namespace Bookify.Domain.Users;

public sealed class User : Entity
{
    private User(Guid id, FirstName firstName, LastName lastName, Email email) : base(id)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
    }
    
    public FirstName FirstName { get; private set; }
    public LastName LastName { get; private set; }
    public Email Email { get; private set; }
    
    public static User Create(Guid id, FirstName firstName, LastName lastName, Email email)
    {
        var user = new User(id, firstName, lastName, email);
        user.AddDomainEvent(new UserCreateDomainEvent(user.Id));
        return user;
    }
}