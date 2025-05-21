using MassTransit;

namespace Projeli.Shared.Application.Messages.Users;

[EntityName("UserDeleted")]
public class UserDeletedMessage
{
    public string UserId { get; set; }
}