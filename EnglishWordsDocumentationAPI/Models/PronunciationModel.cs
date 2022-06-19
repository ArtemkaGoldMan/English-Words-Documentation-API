namespace EnglishWordsDocumentationAPI.Models
{
    public class PronunciationModel
    {
        public Pronunciation pronunciation { get; set; }
    }

    public class Pronunciation
    {
        public string all { get; set; }
        public string noun { get; set; }
        public string verb { get; set; }
    }
}
