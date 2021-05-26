using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Net.Http;
using Newtonsoft.Json;

namespace IWriteIPadApps.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        static HttpClient client;

        public IEnumerable<string> ThingsICanDo { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;

            client = new HttpClient();
        }

        public async Task OnGet()
        {
            var functionUrl = "https://codemillmatt-dotnet-ipad-3v7w-7071.githubpreview.dev/api/LetsGetFunky";

            var thingsICanDoJson = await client.GetStringAsync(functionUrl);

            ThingsICanDo = JsonConvert.DeserializeObject<string[]>(thingsICanDoJson);
        }
    }
}
