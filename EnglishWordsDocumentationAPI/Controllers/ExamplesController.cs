using Microsoft.AspNetCore.Mvc;
using EnglishWordsDocumentationAPI.Clients;
using EnglishWordsDocumentationAPI.Models;

namespace EnglishWordsDocumentationAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExamplesController : ControllerBase
    {
        [HttpGet]
        public ExamplesModel GetExamples(string Word)
        {
            WordsDocumentationClient client = new WordsDocumentationClient();
            return client.GetExamples(Word).Result;
        }
    }
}
