using Microsoft.AspNetCore.Mvc;
using EnglishWordsDocumentationAPI.Clients;
using EnglishWordsDocumentationAPI.Models;

namespace EnglishWordsDocumentationAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AntonymsController : ControllerBase
    {
        [HttpGet]

        public AntonymsModel GetAntonyms(string Word)
        {
            WordsDocumentationClient client = new WordsDocumentationClient();
            return client.GetAntonyms(Word).Result;
        }

    }
}
