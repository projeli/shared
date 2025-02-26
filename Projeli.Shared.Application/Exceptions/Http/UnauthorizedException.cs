using System.Net;

namespace Projeli.Shared.Application.Exceptions.Http;

public class UnauthorizedException(string message = nameof(HttpStatusCode.Unauthorized)) 
    : HttpException(HttpStatusCode.Unauthorized, message)
{
    
}