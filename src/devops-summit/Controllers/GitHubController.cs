using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using devops_summit.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace devops_summit.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GitHubController
    {
        private readonly IHttpClientFactory _clientFactory;

        public GitHubController(IHttpClientFactory clientFactory)
        {
            this._clientFactory = clientFactory;
            
        }
        public async Task<IEnumerable<CommitDto>> GetCommits()
        {
            var httpClient = _clientFactory.CreateClient("github");
            var response = await httpClient.GetStringAsync("https://api.github.com/repos/mrsmitty/devopssummit2020/commits");
            var commits = JsonConvert.DeserializeObject<List<CommitModel>>(response);
            return commits.Select(x => new CommitDto {By = x.Commit.Author.Name, Date = x.Commit.Author.Date, Url = x.Html_Url});
        }
    }
}