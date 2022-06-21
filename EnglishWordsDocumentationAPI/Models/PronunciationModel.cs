namespace EnglishWordsDocumentationAPI.Models
{
    public class PronunciationModel
    {
        public Pronunciations pronunciation { get; set; }
    }

    public class Pronunciations
    {
        public string all { get; set; }
        public string noun { get; set; }
        public string verb { get; set; }
    }
}
