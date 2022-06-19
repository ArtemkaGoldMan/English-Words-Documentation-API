﻿using Microsoft.AspNetCore.Mvc;
using EnglishWordsDocumentationAPI.Clients;
using EnglishWordsDocumentationAPI.Models;

namespace EnglishWordsDocumentationAPI.Controllers 
{
    [ApiController]
    [Route("[controller]")]
    public class PronunciationController : ControllerBase
    {
        [HttpGet]
        public PronunciationModel GetPronunciation()
        {
            WordsDocumentationClient client = new WordsDocumentationClient();
            return client.GetPronunciation().Result;
        }
    }
}
