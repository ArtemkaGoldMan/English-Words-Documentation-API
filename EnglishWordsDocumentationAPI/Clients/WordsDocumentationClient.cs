using EnglishWordsDocumentationAPI.Models;
using Newtonsoft.Json;

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

        //отримати значення 
        public async Task<DefenitionModel> GetDefinisionOfWord(string Word)
        {
            var responce = await _client.GetAsync($"/words/{Word}/definitions");
            responce.EnsureSuccessStatusCode();

            var content = responce.Content.ReadAsStringAsync().Result;

            var result = JsonConvert.DeserializeObject<DefenitionModel>(content);
            if (result.definitions.Count > 2)
                result.definitions.RemoveRange(2, result.definitions.Count - 2);

            return result;
        }

        //отримати синоніми 
        public async Task<SynonymsModel> GetSynonyms(string Word)
        {
            var responce = await _client.GetAsync($"/words/{Word}/synonyms");
            responce.EnsureSuccessStatusCode();

            var content = responce.Content.ReadAsStringAsync().Result;

            var result = JsonConvert.DeserializeObject<SynonymsModel>(content);
            if(result.synonyms.Count>4)
                result.synonyms.RemoveRange(4,result.synonyms.Count-4);

            return result;
        }

        //отримати антоніми 
        public async Task<AntonymsModel> GetAntonyms(string Word)
        {
            var responce = await _client.GetAsync($"/words/{Word}/antonyms");
            responce.EnsureSuccessStatusCode();

            var content = responce.Content.ReadAsStringAsync().Result;

            var result = JsonConvert.DeserializeObject<AntonymsModel>(content);
            if (result.antonyms.Count > 4)
                result.antonyms.RemoveRange(4, result.antonyms.Count - 4);

            return result;
        }

        //отримати приклад використання 
        public async Task<ExamplesModel> GetExamples(string Word)
        {
            var responce = await _client.GetAsync($"/words/{Word}/examples");
            responce.EnsureSuccessStatusCode();

            var content = responce.Content.ReadAsStringAsync().Result;

            var result = JsonConvert.DeserializeObject<ExamplesModel>(content);
            if (result.examples.Count > 4)
                result.examples.RemoveRange(4, result.examples.Count - 4);

            return result;
        }

        //отримати вимову слова 
        public async Task<PronunciationModel> GetPronunciation(string Word)
        {
            var responce = await _client.GetAsync($"/words/{Word}/pronunciation");
            responce.EnsureSuccessStatusCode();

            var content = responce.Content.ReadAsStringAsync().Result;

            var result = JsonConvert.DeserializeObject<PronunciationModel>(content);


            return result;
        }

        //отримати розклад на склади 
        public async Task<SyllablesModel> GetSyllables(string Word)
        {
            var responce = await _client.GetAsync($"/words/{Word}/syllables");
            responce.EnsureSuccessStatusCode();

            var content = responce.Content.ReadAsStringAsync().Result;

            var result = JsonConvert.DeserializeObject<SyllablesModel>(content);

            return result;
        }

        //отримати схоже за значенням 
        public async Task<SimilarToModel> GetSimilarTo(string Word)
        {
            var responce = await _client.GetAsync($"/words/{Word}/similarTo");
            responce.EnsureSuccessStatusCode();

            var content = responce.Content.ReadAsStringAsync().Result;
            

            var result = JsonConvert.DeserializeObject<SimilarToModel>(content);
            if (result.similarTo.Count > 7)
                result.similarTo.RemoveRange(7, result.similarTo.Count - 7);

            return result;
        }

        //отримати слова з якими використовується 
        public async Task<UsingWithModel> GetUsingWith(string Word)
        {
            var responce = await _client.GetAsync($"/words/{Word}/also");
            responce.EnsureSuccessStatusCode();

            var content = responce.Content.ReadAsStringAsync().Result;

            var result = JsonConvert.DeserializeObject<UsingWithModel>(content);

            return result;
        }

        //отримати категорію 
        public async Task<CategoriesModel> GetCategories(string Word)
        {
            var responce = await _client.GetAsync($"/words/{Word}/inCategory");
            responce.EnsureSuccessStatusCode();

            var content = responce.Content.ReadAsStringAsync().Result;

            var result = JsonConvert.DeserializeObject<CategoriesModel>(content);

            return result;
        }

        //отримати загальне значення 
        public async Task<TypeOfModel> GetTypeOf(string Word)
        {
            var responce = await _client.GetAsync($"/words/{Word}/typeOf");
            responce.EnsureSuccessStatusCode();

            var content = responce.Content.ReadAsStringAsync().Result;

            var result = JsonConvert.DeserializeObject<TypeOfModel>(content);

            return result;
        }
        //додати до словника
        public async Task<DictionaryModel> PushDictionary(string Word)
        {
            var responce = await _client.GetAsync($"/words/{Word}");
            responce.EnsureSuccessStatusCode();

            var content = responce.Content.ReadAsStringAsync().Result;
            
            var result = JsonConvert.DeserializeObject<DictionaryModel>(content);
            if (result.results.Count > 2)
            {
                result.results.RemoveRange(2, result.results.Count - 2);
            }
               

            var dictionary = JsonConvert.SerializeObject(result);

            if (!File.Exists($"C:\\EnglishWordsDictionary\\{Word}.txt"))
            {
                File.Create($"C:\\EnglishWordsDictionary\\{Word}.txt").Close();

                File.WriteAllText($"C:\\EnglishWordsDictionary\\{Word}.txt", dictionary);
            }
            else if (File.Exists($"C:\\EnglishWordsDictionary\\{Word}.txt"))
            {
                File.WriteAllText($"C:\\EnglishWordsDictionary\\{Word}.txt", dictionary);
            }
            
            return result;
        }
        //видалити зі словника
        public async Task<DictionaryModel> DeleteDictionary(string Word)
        {
            if (File.Exists($"C:\\EnglishWordsDictionary\\{Word}.txt"))
            {
                File.Delete($"C:\\EnglishWordsDictionary\\{Word}.txt");
            }
            else if (!File.Exists($"C:\\EnglishWordsDictionary\\{Word}.txt"))
            {
                Console.WriteLine($"Error.{Word}.txt not found. Maybe this word has not added to dictionary");
            }
            Console.WriteLine("Succsesful");
            await _client.DeleteAsync(Word);
            return null;
            
        }

    }

}
