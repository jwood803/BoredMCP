using ModelContextProtocol.Server;
using System.ComponentModel;
using System.Text.Json;

namespace BoredMCP
{
    [McpServerToolType]
    public class RandomActivityTool(IHttpClientFactory httpClientFactory)
    {
        [McpServerTool]
        public async Task<Activity> GetRandomActivityAsync()
        {
            var client = httpClientFactory.CreateClient("bored");

            return await client.GetFromJsonAsync<Activity>("random");
        }

        [McpServerTool]
        public async Task<List<Activity>> GetActivitiesByFilter(string type, int? participants)
        {
            var client = httpClientFactory.CreateClient("bored");
            var apiString = $"filter?type={type}";

            if (participants.HasValue)
            {
                apiString += $"&participants={participants.Value}";
            }

            return await client.GetFromJsonAsync<List<Activity>>(apiString);
        }
    }
}
