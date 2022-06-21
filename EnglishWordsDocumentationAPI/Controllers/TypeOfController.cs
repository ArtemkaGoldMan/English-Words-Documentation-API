using Microsoft.AspNetCore.Mvc;
using EnglishWordsDocumentationAPI.Clients;
using EnglishWordsDocumentationAPI.Models;

namespace EnglishWordsDocumentationAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TypeOfController : ControllerBase
    {
        [HttpGet]
        public TypeOfModel GetTypeOf(string Word)
        {
            WordsDocumentationClient client = new WordsDocumentationClient();
            return client.GetTypeOf(Word).Result;
        }
    }
}
