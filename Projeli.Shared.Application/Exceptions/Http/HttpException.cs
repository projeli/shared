using System.Net;

namespace Projeli.Shared.Application.Exceptions.Http;

public abstract class HttpException(HttpStatusCode statusCode, string message) 
    : Exception(message)
{
    public HttpStatusCode StatusCode { get; } = statusCode;
}