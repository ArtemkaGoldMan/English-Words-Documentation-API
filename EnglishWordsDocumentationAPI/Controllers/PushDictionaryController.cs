using Microsoft.AspNetCore.Mvc;
using EnglishWordsDocumentationAPI.Clients;
using EnglishWordsDocumentationAPI.Models;

namespace EnglishWordsDocumentationAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PushDictionaryController : ControllerBase
    {
        [HttpPost]
        public DefenitionModel PushDictionary()
        {
            WordsDocumentationClient client = new WordsDocumentationClient();
            return client.PushDictionary().Result;
        }
    }
}
