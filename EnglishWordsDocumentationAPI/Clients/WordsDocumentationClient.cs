using Newtonsoft.Json;
using EnglishWordsDocumentationAPI.Models;
namespace EnglishWordsDocumentationAPI.Clients
{
    public class WordsDocumentationClient
    {
        private HttpClient _client;
        private static string _address;
        
        public WordsDocumentationClient()
        {
            _address = Constatnts.adress;
            
            _client = new HttpClient();
            _client.BaseAddress = new Uri(_address);
            _client.DefaultRequestHeaders.Add("X-RapidAPI-Key", "65b4f0102fmshb6c930de7370f8cp1c15f2jsn687ead6d4e72");
            _client.DefaultRequestHeaders.Add("X-RapidAPI-Host", "wordsapiv1.p.rapidapi.com");
           
        }
        
        //отримати значення +
        public async Task<DefenitionModel> GetDefinisionOfWord(string Word)
        {
            var responce = await _client.GetAsync($"/words/love/definitions");
            responce.EnsureSuccessStatusCode();

            var content = responce.Content.ReadAsStringAsync().Result;

            var result = JsonConvert.DeserializeObject<DefenitionModel>(content);

            return result;
        }

        //отримати синоніми +
        public async Task<SynonymsModel> GetSynonyms()
        {
            var responce = await _client.GetAsync($"/words/lovely/synonyms");
            responce.EnsureSuccessStatusCode();

            var content = responce.Content.ReadAsStringAsync().Result;
            
            var result = JsonConvert.DeserializeObject<SynonymsModel>(content);

            return result; 
        }

        //отримати антоніми +
        public async Task<AntonymsModel> GetAntonyms()
        {
            var responce = await _client.GetAsync($"/words/good/antonyms");
            responce.EnsureSuccessStatusCode();

            var content = responce.Content.ReadAsStringAsync().Result;

            var result = JsonConvert.DeserializeObject<AntonymsModel>(content);

            return result;
        }

        //отримати приклад використання +
        public async Task<ExamplesModel> GetExamples()
        {
            var responce = await _client.GetAsync($"/words/good/examples");
            responce.EnsureSuccessStatusCode();

            var content = responce.Content.ReadAsStringAsync().Result;

            var result = JsonConvert.DeserializeObject<ExamplesModel>(content);

            return result;
        }

        //отримати вимову слова +
        public async Task<PronunciationModel> GetPronunciation() 
        {
            var responce = await _client.GetAsync($"/words/lovely/pronunciation");
            responce.EnsureSuccessStatusCode();

            var content = responce.Content.ReadAsStringAsync().Result;

            var result = JsonConvert.DeserializeObject<PronunciationModel>(content);

            return result;
        }

        //отримати розклад на склади +
        public async Task<SyllablesModel> GetSyllables()
        {
            var responce = await _client.GetAsync($"/words/lovely/syllables");
            responce.EnsureSuccessStatusCode();

            var content = responce.Content.ReadAsStringAsync().Result;

            var result = JsonConvert.DeserializeObject<SyllablesModel>(content);

            return result;
        }

        //отримати схоже за значенням +
        public async Task<SimilarToModel> GetSimilarTo()
        {
            var responce = await _client.GetAsync($"/words/lovely/similarTo");
            responce.EnsureSuccessStatusCode();

            var content = responce.Content.ReadAsStringAsync().Result;

            var result = JsonConvert.DeserializeObject<SimilarToModel>(content);

            return result;
        }

        //отримати слова з якими використовується +
        public async Task<UsingWithModel> GetUsingWith()
        {
            var responce = await _client.GetAsync($"/words/look/also");
            responce.EnsureSuccessStatusCode();

            var content = responce.Content.ReadAsStringAsync().Result;

            var result = JsonConvert.DeserializeObject<UsingWithModel>(content);

            return result;
        }

        //отримати категорію +
        public async Task<CategoriesModel> GetCategories()
        {
            var responce = await _client.GetAsync($"/words/man/inCategory");
            responce.EnsureSuccessStatusCode();

            var content = responce.Content.ReadAsStringAsync().Result;

            var result = JsonConvert.DeserializeObject<CategoriesModel>(content);

            return result;
        }

        //отримати загальне значення +
        public async Task<TypeOfModel> GetTypeOf()
        {
            var responce = await _client.GetAsync($"/words/lovely/typeOf");
            responce.EnsureSuccessStatusCode();

            var content = responce.Content.ReadAsStringAsync().Result;

            var result = JsonConvert.DeserializeObject<TypeOfModel>(content);

            return result;
        }

        public async Task<DefenitionModel> PushDictionary()
        {
            var responce = await _client.GetAsync($"/words/free/definitions");
            responce.EnsureSuccessStatusCode();

            var content = responce.Content.ReadAsStringAsync().Result;

            var result = JsonConvert.DeserializeObject<DefenitionModel>(content);

            return result;
        }

    }

}
