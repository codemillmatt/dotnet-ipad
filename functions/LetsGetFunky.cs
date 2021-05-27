using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace IWriteIPadApps.Functions
{
    public static class LetsGetFunky
    {
[FunctionName("LetsGetFunky")]
public static async Task<IActionResult> Run(
    [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
    ILogger log)
{
    string[] thingsICanDo = new string[] { 
        "Write .NET apps on an IPAD!!", 
        "Write Azure Functions on an IPAD!!", 
        "Write blogs on an IPAD!!!" 
    };

    return new OkObjectResult(thingsICanDo);
}
    }
}
