using Microsoft.AspNetCore.Mvc;
using EnglishWordsDocumentationAPI.Clients;
using EnglishWordsDocumentationAPI.Models;

namespace EnglishWordsDocumentationAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SimilarToController : Controller
    {
        [HttpGet]
        public SimilarToModel GetSimilarTo()
        {
            WordsDocumentationClient client = new WordsDocumentationClient();
            return client.GetSimilarTo().Result;
        }
    }
}
