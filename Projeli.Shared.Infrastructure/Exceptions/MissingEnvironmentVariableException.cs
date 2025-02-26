using Projeli.Shared.Domain.Exceptions;

namespace Projeli.Shared.Infrastructure.Exceptions;

public class MissingEnvironmentVariableException(string missingEnvironmentVariable)
    : ProjeliException("Missing environment variable: " + missingEnvironmentVariable);