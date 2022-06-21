namespace EnglishWordsDocumentationAPI.Models
{
    public class DefenitionModel
    {
        public string word { get; set; }
        public List<Definitions> definitions { get; set; }
    }

    public class Definitions
    {
        public string definition { get; set; }
        public string partOfSpeech { get; set; }
    }
}