using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace CourseProvider.Functions;

public class Playground
{
    private readonly ILogger<Playground> _logger;

    public Playground(ILogger<Playground> logger)
    {
        _logger = logger;
    }
    //idk
    [Function("Playground")]
    public async Task<HttpResponseData> Run([HttpTrigger(AuthorizationLevel.Function, "get", Route = "graphql")] HttpRequestData req)
    {
        //try
        //{
            var response = req.CreateResponse();
            response.Headers.Add("Content-Type", "text/html; charset=utf-8");
            await response.WriteStringAsync(PlaygroundPage());
            if (response != null)
            {
                return response;
            }
        //}
        //catch (Exception ex)
        //{
        //    _logger.LogError($"ERROR : EmailSender.Run() :: {ex.Message} ");
        //}
        return null!;
    }

    private string PlaygroundPage()
    {
        return @"
            <!DOCTYPE html>
            <html>
            <head>
                <meta charset=""UTF-8"">
                <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">

                <link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/npm/graphql-playground-react/build/static/css/index.css""
                <link rel=""shortcut icon"" href=""https://cdn.jsdelivr.net/npm/graphql-playground-react/build/favicon.png"" />
                <script src=""https://cdn.jsdelivr.net/npm/graphql-playground-react/build/static/js/middleware.js""></script>



                <title>Playground</title>
            </head>
            <body>
                <div id=""root""></div>
                <script>
                    window.addEventListener('load', function(event) {
                        GraphQLPlayground.init(document.getElementById('root'), {
                            endpoint: '/api/graphql'
                        })
                    })
                </script>
            </body>
            </html>";
    }
}
