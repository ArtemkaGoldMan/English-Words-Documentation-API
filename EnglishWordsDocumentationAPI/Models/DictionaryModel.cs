namespace EnglishWordsDocumentationAPI.Models
{
    public class Pronunciation
    {
        public string all { get; set; }
    }

    public class Result
    {
        public string definition { get; set; }
        public string partOfSpeech { get; set; }
    }

    public class DictionaryModel
    {
        public string word { get; set; }
        public List<Result> results { get; set; }
        public Pronunciation pronunciation { get; set; }
    }

}