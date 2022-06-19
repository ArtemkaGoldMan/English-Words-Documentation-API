using Microsoft.AspNetCore.Mvc;
using EnglishWordsDocumentationAPI.Clients;
using EnglishWordsDocumentationAPI.Models;

namespace EnglishWordsDocumentationAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DefenitionController : ControllerBase
    {
       
        [HttpGet]

        public DefenitionModel GetDefinisionOfWord(string Word)
        {
           WordsDocumentationClient client = new WordsDocumentationClient();
            return client.GetDefinisionOfWord(Word).Result;
        }

    }
}