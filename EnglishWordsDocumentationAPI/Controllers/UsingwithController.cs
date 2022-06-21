using Microsoft.AspNetCore.Mvc;
using EnglishWordsDocumentationAPI.Clients;
using EnglishWordsDocumentationAPI.Models;

namespace EnglishWordsDocumentationAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsingwithController : ControllerBase
    {
        [HttpGet]
        public UsingWithModel GetUsingWith(string Word)
        {
            WordsDocumentationClient client = new WordsDocumentationClient();
            return client.GetUsingWith(Word).Result;
        }
    }
}
