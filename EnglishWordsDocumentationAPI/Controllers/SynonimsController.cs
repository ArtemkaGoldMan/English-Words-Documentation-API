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

        public SynonymsModel GetSynonyms(string Word)
        {
            WordsDocumentationClient client = new WordsDocumentationClient();
            return client.GetSynonyms(Word).Result;
        }
    }
}
