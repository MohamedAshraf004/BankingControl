using MediatR.Pipeline;
using Microsoft.Extensions;
using Microsoft.Extensions.Logging;

namespace Application.Common.Behaviours;

public class LoggingBehaviour<TRequest> : IRequestPreProcessor<TRequest> where TRequest : notnull
{
    private readonly ILogger _logger;

    public class LoggingRequest
    { }

    public LoggingBehaviour(ILogger<LoggingRequest> logger)
    {
        _logger = logger;
    }

    public Task Process(TRequest request, CancellationToken cancellationToken)
    {
        var requestName = typeof(TRequest).Name;
        string userName = string.Empty;

        _logger.LogInformation("Request: {Name} {@UserName} {@Request}",
            requestName, userName, request);

        return Task.CompletedTask;
    }
}