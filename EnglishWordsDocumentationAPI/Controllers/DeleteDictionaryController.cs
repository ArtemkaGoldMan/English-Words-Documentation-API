using Microsoft.AspNetCore.Mvc;
using EnglishWordsDocumentationAPI.Clients;
using EnglishWordsDocumentationAPI.Models;
namespace EnglishWordsDocumentationAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DeleteDictionaryController : ControllerBase
    {
        [HttpDelete]
        public DictionaryModel DeleteDictionary(string Word)
        {
            WordsDocumentationClient client = new WordsDocumentationClient();
            return client.DeleteDictionary(Word).Result;
        }
    }
}
