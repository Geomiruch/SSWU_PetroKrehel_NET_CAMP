namespace Task_4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "This is a sentence. This is another sentence, with (parentheses). And here's a question: What's up? And finally, an exclamation!";

            SentenceCollection sentences = new SentenceCollection();
            sentences.AddText(text);

            List<Sentence> sentencesWithParentheses = sentences.FindSentencesWithParentheses();

            foreach (Sentence sentence in sentencesWithParentheses)
            {
                Console.WriteLine(sentence.Text);
            }

            text = "Це речення. Це інше речення, з (круглими дужками). А ще питання: Як справи? Та, нарешті, вигук!";

            sentences = new SentenceCollection();
            sentences.AddText(text);

            sentencesWithParentheses = sentences.FindSentencesWithParentheses();

            foreach (Sentence sentence in sentencesWithParentheses)
            {
                Console.WriteLine(sentence.Text);
            }
        }
    }

    class SentenceCollection
    {
        private List<Sentence> sentences;

        public SentenceCollection()
        {
            sentences = new List<Sentence>();
        }

        public void AddText(string text)
        {
            string[] sentenceStrings = text.Split('.', ',', '!', '?');

            foreach (string sentenceString in sentenceStrings)
            {
                Sentence sentence = new Sentence(sentenceString.Trim());
                sentences.Add(sentence);
            }
        }

        public List<Sentence> FindSentencesWithParentheses()
        {
            List<Sentence> result = new List<Sentence>();

            foreach (Sentence sentence in sentences)
            {
                if (sentence.ContainsParentheses())
                {
                    result.Add(sentence);
                }
            }

            return result;
        }
    }

    class Sentence
    {
        public string Text { get; private set; }

        public Sentence(string text)
        {
            Text = text;
        }

        public bool ContainsParentheses()
        {
            return Text.Contains("(") && Text.Contains(")");
        }
    }
}