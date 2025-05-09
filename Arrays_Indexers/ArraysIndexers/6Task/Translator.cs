namespace _6Task
{
    internal class Translator
    {
        private string ukr;
        private string eng;

        public Translator(string ukr, string eng)
        {
            this.ukr = ukr;
            this.eng = eng;
        }

        public string Ukr => ukr;
        public string Eng => eng;

        public void ShowTranslateWord()
        {
            Console.WriteLine($"{ukr} — {eng}");
        }
    }
}
