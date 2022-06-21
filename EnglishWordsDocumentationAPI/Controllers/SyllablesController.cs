using Microsoft.AspNetCore.Mvc;
using EnglishWordsDocumentationAPI.Clients;
using EnglishWordsDocumentationAPI.Models;

namespace EnglishWordsDocumentationAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SyllablesController : ControllerBase//не пахає
    {
        [HttpGet]
        public SyllablesModel GetSyllables(string Word)
        {
            WordsDocumentationClient client = new WordsDocumentationClient();
            return client.GetSyllables(Word).Result;
        }
    }
}
