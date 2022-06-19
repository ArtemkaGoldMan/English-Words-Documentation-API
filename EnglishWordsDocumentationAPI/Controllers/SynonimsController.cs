using Microsoft.AspNetCore.Mvc;
using EnglishWordsDocumentationAPI.Clients;
using EnglishWordsDocumentationAPI.Models;

namespace EnglishWordsDocumentationAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SynonimsController : ControllerBase
    {
        [HttpGet]

        public SynonymsModel GetSynonyms()
        {
            WordsDocumentationClient client = new WordsDocumentationClient();
            return client.GetSynonyms().Result;
        }
    }
}
