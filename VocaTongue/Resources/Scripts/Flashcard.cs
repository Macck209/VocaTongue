namespace VocaTongue.Resources.Scripts
{
    public class Flashcard
    {
        private static int lastId = 0;
        public int Id {  get; set; }
        public string Word { get; set; }
        public string Translation { get; set; }
        public Flashcard(string word,string trans)
        {
            Id = ++lastId;
            Word = word;
            Translation = trans;
        }
    }
}
