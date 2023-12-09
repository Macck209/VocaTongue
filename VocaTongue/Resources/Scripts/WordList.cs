namespace VocaTongue.Resources.Scripts
{
    public class WordList
    {
        private static int lastId = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public int Highscore { get; set; }
        public List<Flashcard> Flashcards { get; set; }
        public WordList(string name, int best = 0, List<Flashcard> flashcards = null)
        {
            Id = ++lastId;
            Name = name;
            Highscore = best;
            Flashcards = flashcards ?? new List<Flashcard>();
            Flashcards.Add(new Flashcard("pociąg","train"));
        }
    }
}
