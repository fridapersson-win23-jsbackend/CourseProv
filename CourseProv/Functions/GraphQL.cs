using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace CourseProv.Functions
{
    public class GraphQL
    {
        private readonly ILogger<GraphQL> _logger;

        public GraphQL(ILogger<GraphQL> logger)
        {
            _logger = logger;
        }

        [Function("GraphQL")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "post", Route = "graphql")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
            return new OkObjectResult("Welcome to Azure Functions!");
        }
    }
}
