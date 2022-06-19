﻿using Microsoft.AspNetCore.Mvc;
using EnglishWordsDocumentationAPI.Clients;
using EnglishWordsDocumentationAPI.Models;
namespace EnglishWordsDocumentationAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InCategoryController : ControllerBase
    {
        [HttpGet]
        public CategoriesModel GetCategories()
        {
            WordsDocumentationClient client = new WordsDocumentationClient();
            return client.GetCategories().Result;
        }
    }
}
