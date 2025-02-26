using System.Net;

namespace Projeli.Shared.Application.Exceptions.Http;

public class ForbiddenException(string message = nameof(HttpStatusCode.Forbidden)) 
    : HttpException(HttpStatusCode.Forbidden, message)
{
    
}