namespace EnglishWordsDocumentationAPI.Models
{
    public class SyllablesModel
    {
        public Syllables syllables { get; set; }
    }
    public class Syllables
    {
        public int count { get; set; }
        public List<string> list { get; set; }
    }
}
